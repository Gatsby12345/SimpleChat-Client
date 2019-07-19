using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChat.data;
using SimpleChat.data.db3model;
using SimpleChat.model;
using SimpleChat.pub;
using SimpleChat.window;

namespace SimpleChat.server
{
    public class TCPUtil
    {

        public static  Socket socketSend;
        public void StartThread()
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(GlobalClass.ip);
                IPEndPoint point = new IPEndPoint(ip, int.Parse(GlobalClass.tcpport));
                socketSend.Connect(point);
                Thread th = new Thread(Recive);
                th.Start();
                LogManager.WriteLog(LogManager.LOGINFO, "Socket Thread is Starting......");
            }
            catch(Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "StartSocketThread:" + ex.ToString());
                MessageBox.Show("请检查网络！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// 接收服务器发来的消息
        /// </summary>
        private void Recive()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3]; //3M
                    int recLength = socketSend.Receive(buffer);
                    if (recLength == 0)
                    {
                        continue;
                    }
                    string result = Encoding.UTF8.GetString(buffer, 0, recLength);
                    List<MessageType> mtList = MessageType.GetMessageTypeListByStr(result);
                    int type = mtList[0].Type;
                    if(type == 1 || type == 2 || type == 3) //聊天消息 || 接收的验证消息 || 发送的验证消息的回应
                    {
                        bool flag = false; 
                        foreach(MessageType mt in mtList)
                        {
                            int id = mt.Type == 1 ? mt.Id : 0;
                            if (MainForm.Id_Chat.TryGetValue(id, out Chat chat))
                            {
                                chat.ReceiveMsg(mt.Content);
                            }
                            else
                            {
                                flag = true;
                                if (MainForm.Id_Messages.TryGetValue(id, out List<MessageType> list))
                                {
                                    list.Add(mt);
                                }
                                else
                                {
                                    List<MessageType> newlist = new List<MessageType>();
                                    newlist.Add(mt);
                                    MainForm.Id_Messages.TryAdd(id, newlist);
                                }
                            }
                        }
                        if(flag)
                        {
                            GlobalClass.mf.Invoke((MethodInvoker)delegate
                            {
                                GlobalClass.mf.SetTimerStatus(true);
                            });
                        }
                    }
                    else if(type == 0) //收到登录消息 说明在其他地方登录了
                    {
                        GlobalClass.mf.Invoke((MethodInvoker)delegate
                        {
                            GlobalClass.mf.NotifyOffline();
                        });
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
        }
        
        public static void CloseConn()
        {
            MessageType mt = new MessageType(GlobalClass.CurrentUser.Id, 0, "", 4);
            socketSend.Send(mt.ToJsonBytes());
            socketSend.Close();
        }

       

        

    }

}
