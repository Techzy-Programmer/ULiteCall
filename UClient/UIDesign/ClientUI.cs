using System;
using System.Linq;
using UClient.Tools;
using System.Windows.Forms;
using LiteNetLib;
using LiteNetLib.Utils;
using System.Drawing;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace UClient.UIDesign
{
    public partial class ClientUI : Form
    {
        private IWaveIn Recorder;
        private IWavePlayer Player;
        private bool IsMuted = true;
        private const int CallPort = 6428;
        private BufferedWaveProvider AudioBuff;
        private const int MinH = 130, MaxH = 420;
        private const string Call_IP = "127.0.0.1";

        public ClientUI()
        {
            InitializeComponent();
            Bridge.Initialize(); Height = MinH;
            Bridge.PacketProc = new NetPacketProcessor();
            Metrics.OnMetricsChanged += Metrics_OnMetricsChanged;
            Bridge.PacketProc.SubscribeReusable<NETPacket>(OnPacketReceived);
        }

        private void OnPacketReceived(NETPacket NPacket)
        {
            var CurTS = Bridge.GetStamp();
            var TSDelta = CurTS - NPacket.TimeStamp;
            if (TSDelta < 0)
            {
                /* It seems like we got data from future aliens
                 * or the packet was altered by the end user */
            }

            Metrics.IncreasePacket(true);
            int HeadLen = NPacket.MSGHead.Length, TSLen = 15,
                PartLen = NPacket.MSGParts.Select(X => X.Length).Sum();
            Metrics.AddBandwidth(HeadLen + PartLen + TSLen + NPacket.AudioData.Length, true);

            if (Bridge.IsInCall)
                if (NPacket.HasAudioData)
                {
                    if (TSDelta <= 1000) // Only play audio if it is not older than 1 second
                    {
                        /* [To-Do] Remove the following code */
                        System.IO.File.AppendAllLines("Buff-Duration.txt",
                            new string[] { $"{AudioBuff?.BufferedDuration.Milliseconds}", "" });
                        var Audio = Bridge.DecodeVoice(NPacket.AudioData);
                        AudioBuff?.AddSamples(Audio, 0, Audio.Length);
                    }
                }
                else
                    switch (NPacket.MSGHead)
                    {
                        case "":

                            break;
                    }
        }

        private void Metrics_OnMetricsChanged(int Id, object NewStats)
        {
            switch (Id)
            {
                case 3: LSent.Text = $"Sent | {NewStats}"; break;
                case 2: LReceived.Text = $"Received | {NewStats}"; break;
                case 4: BtnParticipants.Text = $"Participants | {NewStats}"; break;
            }
        }

        #region Clicks-Handling

        private void BtnGO_Click(object _, EventArgs E)
        {
            if (!Bridge.IsInCall)
            {
                if (Bridge.Name.Contains("~"))
                {
                    this.Pop("Wrong Input", "Your name must not contain '~' character! Please " +
                        "check your settings and try again.", MsgType.Warning);
                    return;
                }

                if (Bridge.Name.Length < 4 || Bridge.Name.Length > 20)
                {
                    this.Pop("Invalid Input", "Please enter a short & descriptive name which should be at least 4" +
                        " characters long and at most 20 characters long.", MsgType.Warning);
                    return;
                }

                if (Bridge.RecDVC == null) // Check if user has Recording device installed or not
                {
                    this.Pop("Microphone Failure!", "It seems like you don't have any recording device" +
                        "or Microphone plugged in your computer. Program can not run properly " +
                        "without it, the application will terminate now!", MsgType.Error);
                    Environment.Exit(0);
                }

                Bridge.CallClient = new CallClientManager();
                Bridge.CallClient.OnUIEvents += OnUIEvents;
                LConStatus.Text = "Connecting.....";
                LConStatus.ForeColor = Color.Gold;
                var NWriter = new NetDataWriter();
                LConStatus.Visible = true;
                BtnGO.Enabled = false;

                NWriter.Put($"{TbAccess.Text}~{Bridge.Name}");
                var CMgr = new NetManager(Bridge.CallClient)
                {
                    AutoRecycle = true,
                    PingInterval = 5000,
                    UnsyncedEvents = true,
                    MaxConnectAttempts = 3
                };

                if (CMgr.Start())
                    Bridge.CallClient.Peer = CMgr
                        .Connect(Call_IP, CallPort, NWriter);
                else
                {
                    this.Pop("Port In Use!", "Unable to start service on the program's default port." +
                        " Application will terminate now!", MsgType.Error);
                    Environment.Exit(0);
                }
            }
        }

        private void BtnEndCall_Click(object _, EventArgs E)
        {
            Bridge.CallClient.OnUIEvents -= OnUIEvents;
            Bridge.CallClient.Disconnect();

            FireOnDisconnect(new DisconnectInfo()
            {
                AdditionalData = null,
                Reason = DisconnectReason.DisconnectPeerCalled
            }, true);
        }

        private void BtnSettings_Click(object _, EventArgs E)
            => new Settings().ShowDialog();

        private void BtnJoinGroup_Click(object _, EventArgs E)
        {

        }

        private void BtnVolToggle_Click(object _, EventArgs E)
        {
            if (Player != null)
            {
                if (VolControl.Value > 0)
                {
                    VolControl.Value = 0;
                    BtnVolToggle.Text = "0";
                }
                else
                {
                    VolControl.Value = 1;
                    BtnVolToggle.Text = "1.0";
                }
            }
        }

        private void BtnToggleState_Click(object _, EventArgs E)
        {
            IsMuted = !IsMuted;
            var MTxt = (IsMuted ? "UnMute" : "Mute");
            BtnToggleState.Text = $"{MTxt} : F10";
            if (IsMuted) Recorder?.StopRecording();
            else Recorder?.StartRecording();
        }

        private void BtnParticipants_Click(object _, EventArgs E)
        {

        }

        #endregion

        #region Generic-Events

        private void VolControl_Scroll(object _, EventArgs E)
        {
            if (Player != null)
            {
                var VolValue = (decimal)VolControl.Value / 10;
                BtnVolToggle.Text = VolValue == 1 ? "1.0" : VolValue.ToString();
                Player.Volume = (float)VolValue;
            }
        }

        private void ClientUI_KeyDown(object _, KeyEventArgs KEArgs)
        {
            if (Bridge.IsInCall)
                if (KEArgs.KeyCode == Keys.F10) BtnToggleState.PerformClick();
                else if (KEArgs.KeyCode == Keys.Escape && Bridge.IsInCall && this.Pop("Leave The Call", "Do you really" +
                     " want to end this call session?", MsgType.Question, MsgBtn.YesNo) == MsgResult.Yes) BtnEndCall.PerformClick();
            if (KEArgs.KeyCode == Keys.F2) BtnSettings.PerformClick();
            else if (KEArgs.KeyCode == Keys.F5) BtnGO.PerformClick();
        }

        private void ClientUI_FormClosing(object _, FormClosingEventArgs FCEArgs)
        {
            FCEArgs.Cancel = true;
            Environment.Exit(0);
        }

        private async void OnUIEvents(string UIAct, object Data = null)
        {
            if (IsHandleCreated)
                if (!InvokeRequired)
                    switch (UIAct)
                    {
                        case "Connected":

                            LConStatus.ForeColor = Color.GreenYellow;
                            IsMuted = Bridge.JoinState == 1;
                            LConStatus.Text = "Connected";
                            LConStatus.Visible = true;
                            Bridge.IsInCall = true;
                            await Task.Delay(800);
                            StartTimeCounter();
                            ToggleGUIState(false);
                            LConStatus.Visible = false;
                            var WaveForm = new WaveFormat(8000, 8, 1);
                            AudioBuff = new BufferedWaveProvider(WaveForm);

                            Recorder = new WaveInEvent
                            {
                                DeviceNumber = WaveIn.DeviceCount - 1, // [To-Do] use user settings here
                                BufferMilliseconds = 100,
                                WaveFormat = WaveForm,
                            };

                            Player = new WasapiOut(); AudioBuff.DiscardOnBufferOverflow = true;
                            Recorder.DataAvailable += Rec_DataAvailable;
                            Player.Init(AudioBuff);
                            Player.Play();

                            if (!IsMuted)
                            {
                                Recorder?.StartRecording();
                                BtnToggleState.Text = "Mute : F10";
                            }
                            break;

                        case "Latency": break;
                        case "Disconnected": FireOnDisconnect((DisconnectInfo)Data); break;
                    }
                else Invoke(new MethodInvoker
                    (() => OnUIEvents(UIAct, Data)));
            else Environment.FailFast("Found invalid thread"
                + " handle while attempting to alter UI elements");
        }

        private async void FireOnDisconnect(DisconnectInfo DiscINF, bool HasUnSub = false)
        {
            try
            {
                if (Recorder != null) Recorder.DataAvailable -= Rec_DataAvailable;
                if (!HasUnSub) Bridge.CallClient.OnUIEvents -= OnUIEvents;
                Bridge.CallClient = null;
            }
            catch { }
            finally
            {
                Metrics.Reset();
                Player?.Dispose();
                Recorder?.Dispose();
                Bridge.IsInCall = false;
                Recorder = null; Player = null;
                var AdtData = DiscINF.AdditionalData;
                LConStatus.ForeColor = Color.LightPink;
                LConStatus.Text = "Disconnected";
                LConStatus.Visible = true;
                ToggleGUIState(true);
                await Task.Delay(800);
                BtnGO.Enabled = true;
                TbAccess.ReadOnly = false;
                LConStatus.Visible = false;

                if (!HasUnSub)
                    if (AdtData != null && !AdtData.IsNull)
                        this.Pop("Connection Error!", AdtData.GetString(), MsgType.Warning);
                    else
                        switch (DiscINF.Reason)
                        {
                            case DisconnectReason.Reconnect:
                            case DisconnectReason.UnknownHost:
                            case DisconnectReason.HostUnreachable:
                            case DisconnectReason.NetworkUnreachable:
                                this.Pop("Network Error!", "Host server is unreachable" +
                                    ", kindly check your internet connection.", MsgType.Error);
                                break;

                            case DisconnectReason.RemoteConnectionClose:
                                this.Pop("Server Error!", "Server suddenly disconnected, You can try" +
                                    " connecting again later. We regret for the inconvienence caused!", MsgType.Info);
                                break;

                            case DisconnectReason.ConnectionRejected:
                                this.Pop("Request Rejected!", "You might have entered the wrong " +
                                    "Access code. Please try again.", MsgType.Warning);
                                break;

                            default:
                                this.Pop("Connection Failed!", "We have encountered an unknown error while trying" +
                                    " to handle your request. Check if you are connected and then try again.", MsgType.Error);
                                break;
                        }
            }
        }

        private void ToggleGUIState(bool IsHide)
        {
            if ((Height == MinH && IsHide)
                || (Height == MaxH && !IsHide)) return;
            else Height = IsHide ? MinH : MaxH;
            GbxCallManager.Visible = !IsHide;
        }

        private void Rec_DataAvailable(object _, WaveInEventArgs WInEArgs)
        {
            var CmpStream = Bridge.EncodeVoice(WInEArgs.Buffer);
            Bridge.CallClient?.Send(CmpStream);
        }

        private async void StartTimeCounter()
        {
            int TS = 0, TM = 0;

            while (Bridge.IsInCall && IsHandleCreated)
            {
                TS++;
                await Task.Delay(1000);
                if (TS > 59) { TS = 0; TM++; }
                var Sec = $"{(TS < 10 ? $"0{TS}" : $"{TS}")}";
                var Min = $"{(TM < 10 ? $"0{TM}" : $"{TM}")}";
                LDuration.Text = $"Duration | {Min}:{Sec}";
            }
        }

        #endregion
    }
}
