using System;

namespace UClient.Tools
{
    public static class Metrics
    {
        public static event MetricsChanged OnMetricsChanged;
        public delegate void MetricsChanged(int Id, object NewStats);

        public static double InBytes { get; private set; }
        public static double OutBytes { get; private set; }
        public static int InPackets { get; private set; }
        public static int OutPackets { get; private set; }
        public static int Participants { get; private set; }

        public static void IncreasePacket(bool IsIncoming)
        {
            if (IsIncoming) InPackets++; else OutPackets++;
            OnMetricsChanged?.Invoke(Convert.ToInt32(IsIncoming),
                IsIncoming ? InPackets : OutPackets);
        }

        public static void AddBandwidth(double Bytes, bool IsIncoming)
        {
            if (IsIncoming) InBytes += Bytes;
            else OutBytes += Bytes;

            double TmpBytes; string DataUnit;
            int NId = Convert.ToInt32(IsIncoming) + 2;

            if ((TmpBytes = (IsIncoming ? InBytes : OutBytes) / 1024) > 999)
            {
                if ((TmpBytes /= 1024) > 999)
                {
                    TmpBytes /= 1024;
                    DataUnit = "GB";
                }
                else DataUnit = "MB";
            }
            else DataUnit = "KB";

            OnMetricsChanged?.Invoke(NId,
                $"{Math.Round(TmpBytes, 2)} {DataUnit}");
        }

        public static void AlterParticipant(bool IsAdd)
        {
            Participants += IsAdd ? 1 : -1;
            OnMetricsChanged?.Invoke(4, Participants);
        }

        public static void Reset(ResetType RType = ResetType.All)
        {
            Participants = 0;

            switch (RType)
            {
                case ResetType.Bytes:

                    InBytes = 0;
                    OutBytes = 0;
                    break;

                case ResetType.Packets:

                    InPackets = 0;
                    OutPackets = 0;
                    break;

                default:

                    InBytes = 0;
                    OutBytes = 0;
                    InPackets = 0;
                    OutPackets = 0;
                    break;
            }
        }

        public enum ResetType
        {
            All,
            Bytes,
            Packets
        }
    }
}