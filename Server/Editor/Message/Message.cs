using System;

namespace Editor
{
    class Message
    {
        //接收消息，处理消息
        public string receive(byte[] message)
        {
            Int32 HeaderLength;
            
            string data=System.Text.Encoding.UTF8.GetString(message);
            
            return data;
        }

        //传入数据头数据和数据体数据
        public byte[] send(Int32 Header,byte[] data)
        {
            //数据头
            byte[] message=new byte[1024];
            byte[] HeaderLength=BitConverter.GetBytes(Header);
            if(BitConverter.IsLittleEndian)
                Array.Reverse(HeaderLength);
            message=HeaderLength.Concat(data).ToArray();
            //添加分隔符
            byte[] delimiterbytes=System.Text.Encoding.UTF8.GetBytes("\n");
            return message;
        }
    }
}