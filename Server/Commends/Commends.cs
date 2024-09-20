using System.Net;
using System.Net.Sockets;



namespace Commends
{
    public static class ServerSocket
    {
        static byte[] ReceiveBuffer = new byte[1024];
        static byte[] SendBuffer = new byte[1024];
        
        
        public static void AcceptCallBack(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            Socket Client = socket.EndAccept(ar);
            socket.BeginAccept(AcceptCallBack,socket);
        }

        public static void StartReceive(Socket ClientSocket)
        {
            try
            {
                ClientSocket.BeginReceive(ReceiveBuffer, 0, 1024, SocketFlags.None, ReceiveCallBack, ClientSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine("报错信息：" + e);
            }
        }
        static void ReceiveCallBack(IAsyncResult ar)
        {
            Socket ClientSocket = (Socket)ar.AsyncState;
            int bufferLength = ClientSocket.EndReceive(ar);
            
        }

        public static void StartSend(Socket ClientSocket)
        {
            ClientSocket.BeginSend(SendBuffer, 0, 1024, SocketFlags.None, SendCallBack,ClientSocket);
        }
        static void SendCallBack(IAsyncResult ar)
        {
            Socket ClientSocket = (Socket)ar.AsyncState;
            int datalength = ClientSocket.EndSend(ar);
        }

    }
}