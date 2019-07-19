using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "log4net", Watch = true)]
namespace SimpleChat.pub
{
    public class LogManager
    {
        public static int LOGINFO = 2;
        public static int LOGERROR = 1;
        public static int LOGDEBUG = 3;

        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");

        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");

        public static readonly log4net.ILog logdebug = log4net.LogManager.GetLogger("logdebug");

        public static void WriteLog(int level, string logmsg)
        {
            if (level == LOGINFO && loginfo.IsInfoEnabled)
            {
                loginfo.Info(logmsg);
            }
            else if (level == LOGERROR && logerror.IsErrorEnabled)
            {
                logerror.Error(logmsg);
            }
            else if (level == LOGDEBUG && logdebug.IsErrorEnabled)
            {
                logdebug.Debug(logmsg);
            }
        }

        public static void WriteLog(string logmsg, Exception se)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(logmsg, se);
            }
        }
    }
}
