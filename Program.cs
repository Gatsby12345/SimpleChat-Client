using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChat.pub;
using SimpleChat.server;
using SimpleChat.window;

namespace SimpleChat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogManager.WriteLog(LogManager.LOGINFO, "Program is Starting......");
            GlobalClass.ip = ConfigurationManager.AppSettings["ip"].ToString();
            GlobalClass.httpport = ConfigurationManager.AppSettings["httpport"].ToString();
            GlobalClass.tcpport = ConfigurationManager.AppSettings["tcpport"].ToString();
            TCPUtil t = new TCPUtil();
            t.StartThread();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            TCPUtil.CloseConn();
        }
    }
}
