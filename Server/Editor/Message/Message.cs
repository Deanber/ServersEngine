using System;

namespace Editor
{
    class Message
    {
        public string receive(int Header,byte[] message)
        {
            int HeaderLength=4;
            string data=System.Text.Encoding.UTF8.GetString(message);
            
            return data;
        }
        public byte[] send(int Header,string data)
        {
            byte[] message=new byte[1024];
            return message;
        }
    }
}