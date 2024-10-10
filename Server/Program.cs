using System;
using System.Net;
using System.Net.Sockets;
using Editor;

Console.WriteLine("正在初始化应用程序");
Socket socket;
Dictionary<String, Socket> TCPClients = new Dictionary<string, Socket>();
Dictionary<string, Socket> UDPClients = new Dictionary<string, Socket>();
Dictionary<string, Socket> WebClients = new Dictionary<string, Socket>();
string writekeys;

void StartTCP()
{
    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 888));
    Console.WriteLine("开始监听");
    socket.Listen(100);
    socket.BeginAccept(Commends.AcceptCallBack, socket);
}

//弃用
/*string[] helps =
{
"帮助                --help",
"开启服务器           --开启服务器",
"关闭服务器           --关闭服务器",
};*/

Dictionary<string, Action> helps = new Dictionary<string, Action>();
Ins_Helps();
void Ins_Helps()
{
    helps.Add("开启TCP服务器", StartTCP);
}

Console.WriteLine("输入  --help,获取更多信息");


while (true)
{
    writekeys = Console.ReadLine();
    switch (helps.ContainsKey(writekeys))
    {
        case true:
            helps[writekeys]();
            break;
        case false:
            Console.WriteLine("未找到相关命令");
            break;
    }

}

