using Newtonsoft.Json.Linq;
using SimpleChat.pub;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleChat.http
{
    

    class WebSocketManager
    {

        private static ClientWebSocket _instance = null;
        public static ClientWebSocket Instance
        {
            get
            {
                if (_instance == null || _instance.State != WebSocketState.Open)
                {
                    _instance = CreateSessionAsync();
                }
                return _instance;
            }
        }

        public static ClientWebSocket CreateSessionAsync()
        {
            ClientWebSocket webSocket;
            try
            {
                 webSocket = new ClientWebSocket();
            }
            catch (Exception ex)
            {
                LogManager.WriteLog(LogManager.LOGERROR, "CreateSessionAsync:" + ex.ToString());
                throw;
            }

            webSocket.ConnectAsync(new Uri("ws://192.168.0.72:8081/webSocket"),new CancellationToken(false));

            return webSocket;
        }

        public static async Task SendMessage(int id,int destId,string msg)
        {
            JObject j = new JObject();

            j.Add("src", id.ToString());
            j.Add("dest", destId.ToString());

            j.Add("msg", msg);

            string jstring = j.ToString();

            ArraySegment<byte> array = new ArraySegment<byte>(System.Text.Encoding.Default.GetBytes(jstring));

            await Instance.SendAsync(array, WebSocketMessageType.Text, true,new CancellationToken(false));
            
            
        }

        public void Close(ClientWebSocket webSocket)
        {
            if(webSocket != null)
            {
                webSocket.Dispose();
            }
        }
        
    }
}
