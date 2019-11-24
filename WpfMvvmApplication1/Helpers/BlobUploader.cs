using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;


namespace HospitalManagementSystem.Helpers
{
    public class BlobUploader
    {
        string BlobLocation = "https://moskitblob.blob.core.windows.net/moskitprojects/IMS/";

        string ConfigFile = "IMSConfigFile.xml";
        string DownloadFolder = @"c:\Temp\IMS\";

        string filename = string.Empty;
        string ClientID = string.Empty;
        string Env = string.Empty;
        String schoolId = string.Empty;
        public BlobUploader()
        {


        }

        public Task Download()
        {
            //   DownloadFile(ConfigFile);
            return Task.Run(() =>
            {
                DownloadFileForClientOnly(null);

            });
        }


        void DownloadFileForClientOnly(object sender)
        {

            DataTable dt = Common.DownloadFile;
            foreach (DataRow dr in dt.Rows)
            {
                string filename = dr["VALUE"].ToString();
                DownloadFile(filename);

            }
        }
        void DownloadFile(string FileName)
        {
            try
            {
                string FileNameWithFullPath = DownloadFolder + FileName;
                bool isExist = File.Exists(FileNameWithFullPath);
                if (!isExist)
                {
                    //Directory.CreateDirectory(DownloadFolder);
                    WebClient dove = new WebClient();
                    dove.Credentials = new NetworkCredential();
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                    dove.DownloadFile(new Uri(BlobLocation + FileName), FileNameWithFullPath);
                }

            }
            catch (Exception ex)
            {
            }
        }
        public string FileName { get; set; }
        public string SchoolID { get; set; }
        public string FullFileName { get; set; }
        public string EnrollmentNo { get; set; }

        public void UploadFile()
        {
            string accountName = "moskitblob";
            string accountKey = "VxMvycp4PN4DKc7aVj8/M8cIUfTJLfVORtrKxs5JqK1h0PNrd7zr4Qv/VTiO75ZpNu9txFsj7h6jCNKSqAG4aA==";

            try
            {

                StorageCredentials creds = new StorageCredentials(accountName, accountKey);
                CloudStorageAccount account = new CloudStorageAccount(creds, useHttps: true);

                CloudBlobClient client = account.CreateCloudBlobClient();

                CloudBlobContainer sampleContainer = client.GetContainerReference("moskitprojects");
                sampleContainer.CreateIfNotExists();

                string BlobReference =  FullFileName;//SchoolID + "/" + EnrollmentNo + "/" + Path.GetFileName(FileName);
                CloudBlockBlob blob = sampleContainer.GetBlockBlobReference("SMS/" + BlobReference);
                using (Stream file = System.IO.File.OpenRead(FileName))
                {
                    blob.UploadFromStream(file);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Done... press a key to end.");
        }
    }
}
