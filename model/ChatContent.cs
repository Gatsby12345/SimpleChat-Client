using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat.model
{
    public class ChatContent
    {
        public string Content
        {
            get;set;
        }

        public DateTime Time
        {
            get;set;
        }

        public Color Color
        {
            get;set;
        }

        public float Size
        {
            get; set;
        }

        public string FontFamily
        {
            get; set;
        }

        public FontStyle FontStyle
        {
            get; set;
        }

        public static ChatContent GetChatContentByStr(string str,ref string style)
        {
            JObject obj = JObject.Parse(str);
            ChatContent cc = new ChatContent()
            {
                Content = (string)obj["content"],
                Time = DateTime.Parse((string)obj["time"]),
                Color = Color.FromArgb(int.Parse((string)obj["color"])),
                Size = float.Parse((string)obj["size"]),
                FontFamily = (string)obj["fontFamily"],
                FontStyle = (FontStyle)int.Parse((string)obj["fontStyle"]),
            };
            JObject styleObj = new JObject();
            styleObj.Add("color", (string)obj["color"]);
            styleObj.Add("size", (string)obj["size"]);
            styleObj.Add("fontFamily", (string)obj["fontFamily"]);
            styleObj.Add("fontStyle", (string)obj["fontStyle"]);
            style = styleObj.ToString();
            return cc;
        }

        public static string GetStringByContent(string content,Font font,Color color, DateTime dt, ref string style)
        {
            JObject obj = new JObject();
            obj.Add("content", content);
            obj.Add("time", dt.ToString("yyyy-MM-dd HH:mm:ss"));
            obj.Add("color", color.ToArgb());
            obj.Add("size", font.Size);
            obj.Add("fontFamily", font.FontFamily.Name);
            obj.Add("fontStyle", (int)font.Style);
            JObject styleObj = new JObject();
            styleObj.Add("color", color.ToArgb());
            styleObj.Add("size", font.Size);
            styleObj.Add("fontFamily", font.FontFamily.Name);
            styleObj.Add("fontStyle", (int)font.Style);
            style = styleObj.ToString();
            return obj.ToString();
        }

    }
}
