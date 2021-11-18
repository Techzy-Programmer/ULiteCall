using LiteNetLib;
using System.Net;
using System.Linq;
using System.Net.Sockets;
using System;

namespace UClient.Tools
{
    public class CallClientManager : INetEventListener
    {
        public NetPeer Peer;
        public event UIEvents OnUIEvents;
        public delegate void UIEvents(string UIAct, object Data = null);

        public bool Send(byte[] _Audio)
        {
            if (Peer.ConnectionState == ConnectionState.Connected)
            {
                Bridge.PacketProc?.Send(Peer,
                      new NETPacket
                      {
                          AudioData = _Audio,
                          HasAudioData = true,
                          MSGHead = "Audio-Data",
                          MSGParts = new string[0],
                          TimeStamp = Bridge.GetStamp()
                      }, DeliveryMethod.ReliableOrdered);

                Metrics.IncreasePacket(false);
                int HeadLen = 10, AudioLen = _Audio.Length;
                Metrics.AddBandwidth(HeadLen + AudioLen, false);
            }

            return Peer.ConnectionState
                == ConnectionState.Connected;
        }

        public void Disconnect() => Peer.Disconnect();

        public bool Send(string _Head, params string[] _Parts)
        {
            if (Peer.ConnectionState == ConnectionState.Connected)
            {
                Bridge.PacketProc?.Send(Peer,
                      new NETPacket
                      {
                          MSGHead = _Head,
                          MSGParts = _Parts,
                          HasAudioData = false,
                          AudioData = new byte[0],
                          TimeStamp = Bridge.GetStamp()
                      }, DeliveryMethod.ReliableOrdered);

                Metrics.IncreasePacket(false);
                int HeadLen = _Head.Length, TSLen = 15,
                    PartLen = _Parts.Select(X => X.Length).Sum();
                Metrics.AddBandwidth(HeadLen + PartLen + TSLen, false);
            }

            return Peer.ConnectionState
                == ConnectionState.Connected;
        }

        void INetEventListener.OnPeerConnected(NetPeer CPeer)
            => OnUIEvents?.Invoke("Connected");

        void INetEventListener.OnNetworkLatencyUpdate(NetPeer LPeer,
            int PeerLatency) => OnUIEvents?.Invoke("Latency", PeerLatency);

        void INetEventListener.OnPeerDisconnected(NetPeer DPeer,
            DisconnectInfo DiscInfo) => OnUIEvents?.Invoke("Disconnected", DiscInfo);

        void INetEventListener.OnNetworkReceive(NetPeer RPeer, NetPacketReader NPReader,
            DeliveryMethod DelvMethod) => Bridge.PacketProc?.ReadAllPackets(NPReader);

        #region Un-Significant Ones

        void INetEventListener.OnConnectionRequest(ConnectionRequest
            ConReq) => ConReq.RejectForce();

        void INetEventListener.OnNetworkReceiveUnconnected(IPEndPoint RemoteEP, NetPacketReader
            NPReader, UnconnectedMessageType UCMType) => DoNothing();

        void INetEventListener.OnNetworkError(IPEndPoint IPEP,
            SocketError SErType) => DoNothing();

        void DoNothing() { }

        #endregion
    }
}
