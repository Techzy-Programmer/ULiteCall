using System;
using UClient.Tools;
using NAudio.CoreAudioApi;
using System.Windows.Forms;

namespace UClient.UIDesign
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Bridge.LoadUserSettings();
            LBMicrophone.Items.Clear();
            using (MMDeviceEnumerator DEnum = new MMDeviceEnumerator())
                foreach (MMDevice RecDevice in DEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
                    LBMicrophone.Items.Add($"{RecDevice.DeviceFriendlyName}");

            if (LBMicrophone.Items.Count > 0)
            {
                if (Bridge.MicIndex < LBMicrophone.Items.Count)
                    LBMicrophone.SelectedIndex = Bridge.MicIndex;
                else LBMicrophone.SelectedIndex = 0;
            }

            string UNM;
            if (!string.IsNullOrWhiteSpace(UNM = Bridge.Name))
                if (UNM.Length <= 20 && UNM.Length > 3) TBName.Text = UNM;
            RBtnPerformance.Checked = !Convert.ToBoolean(Bridge.OptIndex);
            CBJoinState.Checked = Convert.ToBoolean(Bridge.JoinState);
        }

        private void BtnSave_Click(object _, EventArgs E)
        { 
            Bridge.SaveSetting(TBName.Text, LBMicrophone
                .SelectedIndex, RBtnLow.Checked, CBJoinState.Checked);
            this.Pop("Settings Saved!", "Your settings has been saved " +
                "successfully.\r\nHit Ok to continue!", MsgType.Success);
            Close();
        }

        private void BtnReset_Click(object _, EventArgs E)
        { 
            Bridge.SaveSetting(TBName.Text, 0, true, true);
            CBJoinState.Checked = true;
            RBtnLow.Checked = true;

            this.Pop("Settings Reset!", "Settings was restored to " +
                "it's initial state.\r\nHit Ok to continue!", MsgType.Success);
            Close();
        }
    }
}
