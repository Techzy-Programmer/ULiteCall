namespace UServer.Codes
{
    public class NETPacket
    {
        public string MSGHead { get; set; }
        public byte[] AudioData { get; set; }
        public double TimeStamp { get; set; }
        public string[] MSGParts { get; set; }
        public bool HasAudioData { get; set; }
    }
}
