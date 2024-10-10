using System.Net;
using System.Net.Sockets;

namespace Editor
{
    interface Tcp_interface
    {
        void StartSocket();
        void StartAccept();

    }
    interface Udp_interface
    {

    }
    interface SocketClient
    {
        void SendMassage(byte[] bytes);
    }
}