using System.Net;
using System.Net.Sockets;
using Editor;

namespace Editor
{
    namespace TCP
    {

        public class TcpServer
        {
            public void StartSocket(ref Socket ServerSocket, IPEndPoint iP)
            {
                ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ServerSocket.Bind(iP);
                ServerSocket.Listen(10);
                ServerSocket.Accept();
            }
            public void send(Socket ServerSocket, byte[] Massage)
            {
                ServerSocket.Send(Massage);
            }
            public void Receive(Socket ServerSocket, ref byte[] Massage)
            {
                ServerSocket.Receive(Massage);
            }

        }
    }
}