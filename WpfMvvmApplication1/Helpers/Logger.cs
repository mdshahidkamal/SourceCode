using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Windows;

namespace HospitalManagementSystem.Helpers
{
    public class Logger
    {
        private static Logger objlogger;
        static StreamWriter sw;
        static string logpath = string.Empty;
        static void CreateDirectory()
        {
            logpath = ConfigurationSettings.AppSettings["logfilepath"].ToString();
            bool exists = System.IO.Directory.Exists(logpath);

            if (!exists)
                System.IO.Directory.CreateDirectory(logpath);
        }
        static Logger()
        {
            CreateDirectory();

            sw = new StreamWriter(logpath + "LogFile_" + DateTime.Now.Ticks + ".txt", true);
        }
        ~Logger()
        {
            //sw.Dispose();
        }

        public static Logger IntializeLogger()
        {
            if (objlogger == null)
            {
                objlogger = new Logger();
            }
            return objlogger;
        }
        public void Log(string msg, MessageType MessageType)
        {

            sw.WriteLine(DateTime.Now + " " + MessageType + " " + msg);
            sw.Flush();
            
            if (MessageType == MessageType.Error)
            {
                MessageBox.Show(msg, "Exception", MessageBoxButton.OK);
                EmailClient.SendMail(msg);
            }
        }

    }
    public enum MessageType
    {
        Error,
        Debug
    }
}
