using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat.data.db3model
{
    public class UserChatRecord
    {
        public int MyId
        {
            get; set;
        }

        public int UserId
        {
            get;set;
        }

        public DateTime Time
        {
            get; set;
        }

        public string Content
        {
            get; set;
        }

        public string Style
        {
            get; set;
        }

        public int Role
        {
            get; set;
        }

        public static Tuple<Font,Color> GetStyle(string style)
        {
            JObject obj = JObject.Parse(style);
            Color color = Color.FromArgb(int.Parse((string)obj["color"]));
            Font font = new Font((string)obj["fontFamily"], float.Parse((string)obj["size"]), (FontStyle)int.Parse((string)obj["fontStyle"]));
            return new Tuple<Font, Color>(font, color);
        }
    }
}
