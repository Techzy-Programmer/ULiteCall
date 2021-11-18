using LiteNetLib.Utils;
using Microsoft.Win32;
using NAudio.Codecs;
using NAudio.CoreAudioApi;
using System;

namespace UClient.Tools
{
    public static class Bridge
    {
        #region Declarations

        private static int _MIndex = -1;

        public static string Name { get; set; }
        public static int OptIndex { get; set; }
        public static bool IsInCall { get; set; }
        public static int JoinState { get; set; }
        public static MMDevice RecDVC { get; set; }
        public static CallClientManager CallClient { get; set; }
        public static NetPacketProcessor PacketProc { get; set; }

        public static int MicIndex
        {
            get => _MIndex;
            set
            {
                RecDVC = null;
                _MIndex = value;
                var DEnum = new MMDeviceEnumerator()
                    .EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
                if (DEnum.Count > 0) RecDVC = DEnum[MicIndex < DEnum.Count ? MicIndex : 0];
            }
        }

        #endregion

        public static void Initialize()
        {
            MicIndex = 0;
            LoadUserSettings();
        }

        public static void LoadUserSettings()
        {
            Name = RetrieveSettings("User-Name");
            if (int.TryParse(RetrieveSettings("Join-State"), out int JnSt)) JoinState = JnSt;
            if (int.TryParse(RetrieveSettings("Mic-Index"), out int MIndex)) MicIndex = MIndex;
            if (int.TryParse(RetrieveSettings("Optimizations"), out int Optzs)) OptIndex = Optzs;
        }

        public static void SaveSetting(string UName, int InDvcIndex, bool IsLowPF, bool IsMuteOnJoin)
        {
            try
            {
                using (RegistryKey RegKEY = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ULiteCall"))
                {
                    if (UName.Length <= 20 && UName.Length > 3) RegKEY.SetValue("User-Name", UName, RegistryValueKind.String);
                    RegKEY.SetValue("Join-State", IsMuteOnJoin ? "1" : "0", RegistryValueKind.String);
                    RegKEY.SetValue("Optimizations", IsLowPF ? "1" : "0", RegistryValueKind.String);
                    RegKEY.SetValue("Mic-Index", InDvcIndex.ToString(), RegistryValueKind.String);
                    RegKEY.Close();
                }

                LoadUserSettings();
            }
            catch (Exception) { }
        }

        public static double GetStamp()
            => new DateTimeOffset(DateTime.UtcNow)
            .ToUnixTimeMilliseconds();

        public static byte[] EncodeVoice(byte[] SMOrgData)
        {
            int OutIndex = 0;
            byte[] Encoded = new byte[SMOrgData.Length / 2];
            for (int N = 0; N < SMOrgData.Length; N += 2) Encoded[OutIndex++] =
                    MuLawEncoder.LinearToMuLawSample(BitConverter.ToInt16(SMOrgData, N));
            return Encoded;
        }

        public static byte[] DecodeVoice(byte[] SMEncData)
        {
            int OutIndex = 0;
            byte[] Decoded = new byte[SMEncData.Length * 2];

            for (int N = 0; N < SMEncData.Length; N++)
            {
                short DecodedSample = MuLawDecoder.MuLawToLinearSample(SMEncData[N]);
                Decoded[OutIndex++] = (byte)(DecodedSample & 0xFF);
                Decoded[OutIndex++] = (byte)(DecodedSample >> 8);
            }

            return Decoded;
        }

        #region Private Functions

        private static string RetrieveSettings(string Property)
        {
            var RetSet = string.Empty;

            try
            {
                RegistryKey RegKEY = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ULiteCall");
                RetSet = RegKEY.GetValue(Property, "1").ToString();
                RegKEY.Close(); RegKEY.Dispose();
            }
            catch (Exception) { }
            return RetSet;
        }

        #endregion
    }
}
