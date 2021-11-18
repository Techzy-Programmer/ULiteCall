using LiteNetLib;
using LiteNetLib.Utils;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UServer.Codes
{
    public class ServerHandler : INetEventListener
    {
        public NetManager SvrMgr;
        public NetPacketProcessor NPProc;
        private const string AcceptKey = "0";

        void INetEventListener.OnPeerConnected(NetPeer CPeer)
        {

        }

        void INetEventListener.OnConnectionRequest(ConnectionRequest ConReq)
        {
            var RejTXT = string.Empty;
            var RejWriter = new NetDataWriter();

            if (ConReq.Data == null || ConReq.Data.IsNull)
                RejTXT = "You have provided a null value" +
                    " as Access code! Please try again.";

            if (SvrMgr.ConnectedPeersCount > 20)
                RejTXT = "Sorry! Server has reached it's maximum" +
                    " connection capacity, kindly try again later.";

            if (ConReq.Data.TryGetString(out string CData))
            {
                if (!CData.Contains("~"))
                    RejTXT = "Oop! It looks like you have altered the data packets." +
                        " Your connection request was rejected, Kindly try again with intact data";
                else
                {
                    var DataPRT = CData.Split('~');

                    if (DataPRT.Length == 2)
                        if (DataPRT[0] == AcceptKey)
                        {
                            if (DataPRT[1].Length < 4 || DataPRT[1].Length > 20)
                                RejTXT = "Input parameter is invalid, kindly check to make sure that your name is from 4" +
                                    " to 20 characters long and name should not contain '~' character.";
                            else ConReq.Accept().Tag = PeerData.Create(DataPRT[1]);
                        }
                        else RejTXT = "Yuk! You have entered a wrong Access code for accesing the service on " +
                                "this server. Kindly contact owner to get correct code & then try again";
                    else RejTXT = "Invalid data provided for validations please try again later.";
                }
            }
            else RejTXT = "Whoops! You are trying to alter the variables type sent over network," +
                    " kindly stop this malicious acivity and try again later.";

            if (RejTXT.Length > 0)
            {
                RejWriter.Put(RejTXT);
                ConReq.RejectForce(RejWriter);
            }
        }

        public void OnGotPacket(NETPacket NPacket, NetPeer Sender)
        {
            if (NPacket.HasAudioData && NPacket.AudioData.Length <= 1024)
                Broadcast(NPacket, Sender);
        }

        private void Broadcast(NETPacket Sendable, params NetPeer[] ExepList)
        {
            foreach (var SClient in SvrMgr.ConnectedPeerList.Where
                (P => !ExepList.Contains(P) && P.ConnectionState == ConnectionState.Connected))
                new Thread(() => NPProc.Send(SClient, Sendable, DeliveryMethod.ReliableOrdered)).Start();
        }

        void INetEventListener.OnPeerDisconnected(NetPeer DPeer, DisconnectInfo DiscInfo)
        {

        }

        void INetEventListener.OnNetworkReceive(NetPeer RPeer,
            NetPacketReader NPReader, DeliveryMethod DelvMethod)
        {
            try
            {
                NPProc.ReadAllPackets
                    (NPReader, RPeer);
            }
            catch { }
        }

        #region Un-Significant Ones

        void DoNothing() { }

        void INetEventListener.OnNetworkError(IPEndPoint EP,
            SocketError SEr) => DoNothing();

        void INetEventListener.OnNetworkLatencyUpdate(NetPeer LPeer,
            int PeerLatency) => DoNothing();

        void INetEventListener.OnNetworkReceiveUnconnected(IPEndPoint RemEP, NetPacketReader NPP,
            UnconnectedMessageType messageType) => DoNothing();

        #endregion
    }

    public class PeerData
    {
        public string Name { get; private set; }

        public static PeerData Create(string PrNM)
            => new PeerData
            {
                Name = PrNM
            };
    }
}
