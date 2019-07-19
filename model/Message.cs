using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat.model
{
    public class MessageType
    {
        public int Id
        {
            get;
            set;
        }

        public int DesId
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }

        public int Type
        {
            get;
            set;
        }

        public MessageType()
        {

        }

        public MessageType(int _id,int _desid,string _content,int _type)
        {
            this.Id = _id;
            this.DesId = _desid;
            this.Content = _content;
            this.Type = _type;
        }

        public static List<MessageType> GetMessageTypeListByStr(string str)
        {
            List<MessageType> list = new List<MessageType>();
            JArray jArray = JArray.Parse(str);
            for(int i=0;i<jArray.Count;i++)
            {
                MessageType mt = new MessageType()
                {
                    Id = int.Parse((string)jArray[i]["id"]),
                    DesId = int.Parse((string)jArray[i]["desId"]),
                    Content = (string)jArray[i]["content"],
                    Type = int.Parse((string)jArray[i]["type"])
                };
                list.Add(mt);
            }
            return list;
        }

        public static MessageType GetMessageTypeByStr(string str)
        {
            JObject obj = JObject.Parse(str);
            MessageType mt = new MessageType()
            {
                Id = int.Parse((string)obj["id"]),
                DesId = int.Parse((string)obj["desId"]),
                Content = (string)obj["content"],
                Type = int.Parse((string)obj["type"])
            };
            return mt;
        }

        public byte[] ToJsonBytes()
        {
            JObject obj = new JObject();
            obj.Add("id", this.Id);
            obj.Add("desId", this.DesId);
            obj.Add("content", this.Content);
            obj.Add("type", this.Type);
            return Encoding.UTF8.GetBytes(obj.ToString());
        }

    }
}
