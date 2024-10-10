using System.Net;
using System.Net.Sockets;
using System.Reflection;

namespace Editor
{
    namespace TCP
    {
        interface Tcp_interface
        {
            void StartTCP(ref Socket socket, IPEndPoint iPEndPoint);
            void StartAccept(Socket socket, float waitings);
        }
        class TCPSeerver : Tcp_interface
        {
            void Tcp_interface.StartTCP(ref Socket socket, IPEndPoint iPEndPoint)
            {
                socket.Bind(iPEndPoint);
            }
            void Tcp_interface.StartAccept(Socket socket, float waitings)
            {
                socket.Listen(100);
                socket.Accept();
            }

        }
    }
}