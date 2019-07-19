using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChat.model;

namespace SimpleChat.pub
{
    public class GlobalClass
    {
        public static string ip;

        public static string httpport;

        public static string tcpport;

        public static User CurrentUser;

        public static List<string> Groups;

        public static MainForm mf;
    }
}
