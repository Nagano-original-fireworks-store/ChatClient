using Google.Protobuf;
using Proto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WebSocketSharp;

namespace ChatClient
{
    public static class Program
    {
        public static WebSocket ws = new WebSocket("ws://127.0.0.1:8080/ws");
        public static void Init()
        {
            ws.Ping();
            ws.EmitOnPing = true;
            
            // 连接到服务器
            ws.OnOpen += (sender, e) =>
            {
                LogPage.Log("连接到服务器成功！");
            };
            // 接收消息
            ws.OnMessage += (sender, e) =>
            {
                if (e.IsPing)
                {
                    MessageBox.Show("收到 Ping 消息.");
                }
                else
                {
                    Console.WriteLine("收到消息: " + e.Data);
                }
            };

            // 连接到服务器
            ws.Connect();
        }
        public static void Ping()
        {
            LogPage.Log("PingServer");
            ws.Ping();
        }
        public static int Tests(string msg)
        {
            try
            {
                //Attachment attachment = new Attachment()
                //{
                //    AttachmentName = "A",
                //    Data = ByteString.FromStream(new MemoryStream(
                //        Encoding.UTF8.GetBytes(msg)
                //        )
                //    )
                //};
                LogPage.Log("Sending");
                BasePacket basePacket = new BasePacket()
                {
                    MessageType = MessageType.Message,
                };
                Message message = new Message();
                message.MessageId = 1;
                message.SendId = 1;
                message.SendTime = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                message.MessageId = 1;
                message.ReceiveId = 1;
                message.Data = ByteString.FromStream(new MemoryStream(
                        Encoding.UTF8.GetBytes(msg)
                        )
                    );
                //message.Attachments.Add(attachment);
                basePacket.Message = message;
                ws.Send(basePacket.ToByteArray());
            }
            catch (Exception ex) { 
                LogPage.Log(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
            
            return 1;
        }
    }
}
