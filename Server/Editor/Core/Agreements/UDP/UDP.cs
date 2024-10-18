using System.Net.Sockets;
using System.Net;

namespace Editor
{
    namespace UDP
    {
        public class UdpServer
        {
            public void StartSocket(ref UdpClient ServerClient, IPEndPoint LocalIP)
            {
                ServerClient = new UdpClient(LocalIP);
            }
            public void Send(UdpClient ServerClient, byte[] Massage, IPEndPoint TargetIP)
            {
                ServerClient.Send(Massage, Massage.Length, TargetIP);
            }
            public void Receive(UdpClient ServerClient, out byte[] Massage, ref IPEndPoint TargetIP)
            {
                Massage = ServerClient.Receive(ref TargetIP);
            }
        }
    }
}