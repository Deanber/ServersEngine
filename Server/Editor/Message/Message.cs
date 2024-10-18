using System;
using System.ComponentModel;

namespace Editor
{
    class Message
    {
        //接收消息，处理消息
        public string ReceiveMassage(byte[] Massage, out UInt16 MassageType, out ulong TimeStamp)
        {
            //分离消息头
            byte[] header = new byte[2];
            Array.Copy(Massage, 0, header, 0, header.Length);
            MassageType = BitConverter.ToUInt16(header);

            //分离时间戳
            byte[] timestamp = new byte[8];
            Array.Copy(Massage, header.Length, timestamp, 0, timestamp.Length);
            TimeStamp = BitConverter.ToUInt64(timestamp);

            //分离消息体
            byte[] maindata = new byte[Massage.Length - header.Length - timestamp.Length];
            Array.Copy(Massage, header.Length + timestamp.Length, maindata, 0, maindata.Length);
            string MainMassage = BitConverter.ToString(maindata);

            return MainMassage;
        }

        //传入数据头数据和数据体数据
        public byte[] SendMassage(string Massage, UInt16 MassageType, ulong TimeStamp)
        {
            //数据头
            byte[] header = new byte[2];
            header = BitConverter.GetBytes(MassageType);

            //时间戳
            byte[] timestamp = new byte[8];
            timestamp = BitConverter.GetBytes(TimeStamp);

            //消息体
            byte[] maindata = new byte[1014];
            maindata = System.Text.Encoding.UTF8.GetBytes(Massage);

            //合并
            byte[] massage = new byte[1024];
            Array.Copy(header, 0, massage, 0, 2);
            Array.Copy(timestamp, 0, massage, 2, 8);
            Array.Copy(maindata, 0, massage, 10, 1014);
            return massage;
        }
    }
}