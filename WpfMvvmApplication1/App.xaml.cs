using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using System;
using System.Windows;

namespace HospitalManagementSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            
        }
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
        }
        public bool DoHandle { get; set; }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //if (this.DoHandle)
            //{
            //    //Handling the exception within the UnhandledExcpeiton handler.
            //    DAL.logger.Log(e.Exception + Environment.NewLine , MessageType.Error);
            //    e.Handled = true;
            //}
            //else
            //{
                //If you do not set e.Handled to true, the application will close due to crash.
                EmailClient.SendMail(e.Exception.ToString());
                DAL.logger.Log(e.Exception + Environment.NewLine, MessageType.Error);
                MessageBox.Show("Application is going to close! ", "Uncaught Exception");
                e.Handled = true;
            //}
        }
    }
}
