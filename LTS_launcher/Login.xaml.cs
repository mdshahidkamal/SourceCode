using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;
using System.Data;
using System.Xml;
using System.Diagnostics;
using System.Net.Security;
using System.Configuration;

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        //public string BlobLocation = "https://moskitblob.blob.core.windows.net/moskitprojects/IMS/";
        public string BlobLocation = "http://13.233.165.114:80/";
        

        public string ConfigFile = "IMSConfigFile.xml";
        public string DownloadFolder = @"c:\Temp\IMS\";

        string filename = string.Empty;
        string ClientID = string.Empty;
        string Env = string.Empty;


        public Login()
        {
            InitializeComponent();
            try
            {                //Env = ConfigurationSettings.AppSettings["ENV"].ToString();
                //ClientID = ConfigurationSettings.AppSettings["CLIENTID"].ToString();

                //BlobLocation = BlobLocation + ClientID + "/" + Env + "/";
                //DownloadFolder = DownloadFolder + "\\" + ClientID + "\\";
                    DownloadFile(ConfigFile);
                    BackgroundWorker worker = new BackgroundWorker();
                    worker.WorkerReportsProgress = true;
                    worker.DoWork += Worker_DoWork; ;
                    worker.ProgressChanged += Worker_ProgressChanged; ;
                    worker.RunWorkerCompleted += Worker_RunWorkerCompleted; ;
                    worker.RunWorkerAsync();
                


            }
            catch (Exception ex)
            {

            }

        }
      
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Process.Start(DownloadFolder + "IMS.exe");
            this.Close();
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value = e.ProgressPercentage;
            //this.Dispatcher.BeginInvoke(DispatcherPriority.Background,
            //           (ThreadStart)delegate ()
            //           {
            //               txtFileName.Text = "Please Wait " + filename + " ..."; ;
            //           }
            //             );
            this.Dispatcher.BeginInvoke(DispatcherPriority.Background,
                       (ThreadStart)delegate ()
                       {
                           txtFileName.Text = "Please Wait..." + "System Initializing..";
                       }
                         );

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadConfigFileAndDownload(sender);
        }

        public void ReadConfigFileAndDownload(object sender)
        {

            XmlDocument doc = new XmlDocument();
            string xmlFile = DownloadFolder + ConfigFile;
            doc.Load(xmlFile);

            XmlNode FileNameNodes = doc.SelectSingleNode("/Files");
            XmlNodeList StudentNodeList = FileNameNodes.SelectNodes("Name");
            int counter = 0;
            foreach (XmlNode node in StudentNodeList)
            {
                (sender as BackgroundWorker).ReportProgress(counter);
                string updated = Convert.ToString(node.Attributes.GetNamedItem("updated").Value);
                filename = Convert.ToString(node.Attributes.GetNamedItem("name").Value);
                bool fileexist = File.Exists(DownloadFolder + filename);
                if (updated == "Y" || (!fileexist))
                {
                    DownloadFile(filename);
                }
                counter = counter + 10;
            }
        }
        public void DownloadFile(string FileName)
        {
            try
            {
                string FileNameWithFullPath = DownloadFolder + FileName;
                bool isExist = Directory.Exists(DownloadFolder);
                if (!isExist)
                {
                    Directory.CreateDirectory(DownloadFolder);
                }
                WebClient dove = new WebClient();
                dove.Credentials = new NetworkCredential();
                dove.DownloadFileCompleted += Dove_DownloadFileCompleted;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                dove.DownloadFile(new Uri(BlobLocation + FileName), FileNameWithFullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(FileName + ": " + ex.Message);
            }
        }


        private void Dove_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Close();
        }
    }
}
