using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UServer.Codes;
using System.Threading.Tasks;
using LiteNetLib;
using LiteNetLib.Utils;

namespace UServer
{
    public static class Program
    {
        private const int CallPort = 6428;

        public static void Main(string[] _)
        {
            Helper.SvrSpace = new ServerHandler();
            var ServerNM = new NetManager(Helper.SvrSpace)
            {
                AutoRecycle = true,
                PingInterval = 5000,
                UnsyncedEvents = true
            };

            if (ServerNM.Start(CallPort))
            {
                Console.WriteLine("Listening.");
                Helper.SvrSpace.SvrMgr = ServerNM;
                Helper.SvrSpace.NPProc = new NetPacketProcessor();
                Helper.SvrSpace.NPProc.SubscribeReusable<NETPacket, NetPeer>(Helper.SvrSpace.OnGotPacket);
            }

            while (true) { Console.ReadKey(false); }
        }
    }
}
