using HospitalManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows;

namespace LTS_launcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            //e.Args is the string[] of command line argruments
            if (CheckForInternetConnection())
            {

                Login obj = new Login();
                obj.Show();

            }
            else
            {
                MessageBox.Show("System cannot connect to Internet. " + Environment.NewLine + "Please contact your local Administrator", "Network Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


    }
}
