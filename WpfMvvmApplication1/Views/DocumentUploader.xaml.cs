using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for DocumentUploader.xaml
    /// </summary>
    /// 
    public delegate void OnClose(DocumentModel objdocmodel);
    public partial class DocumentUploader : Window
    {
        public event OnClose myEvent;

        ImageConvertor objImageConvertor = new ImageConvertor();
        //DocumentModel objModel;
        string filename = string.Empty;
        public DocumentModel objModel { get; set; }
        public DocumentUploader(DocumentModel obj)
        {
            InitializeComponent();
            objModel = obj;
            AsyncLoadImageFromServer();
            this.DataContext = obj;
        }

        async void AsyncLoadImageFromServer()
        {
            //await awaitLoadImage();
        }
        Task awaitLoadImage()
        {
            return Task.Run(() =>
            {
                foreach (DocumentViewModel objmodel in objModel.lstDocuments_)
                {
                    string fullpath = "https://moskitblob.blob.core.windows.net/moskitprojects/SMS/";
                    fullpath += objmodel.FullFileName;
                    objmodel.DocumentImageSource = BitmapFrame.Create(new Uri(fullpath), BitmapCreateOptions.None,
                                                       BitmapCacheOption.OnLoad);
                }
            });
        }
        void CopyPhotoToLocalCacheFolder(string filename)
        {
            string TempPath = ConfigurationSettings.AppSettings["TempPath"].ToString();
            string PhotID = Guid.NewGuid().ToString();
            string NewFileName = TempPath + PhotID + ".photo";
            objImageConvertor.ConvertPhotoToByteArray(filename);
            byte[] bytearr = objImageConvertor.ImageStream;
            string Base64String = Convert.ToBase64String(bytearr);
            //            objviewmodel.Picture=Base64String;
            StreamWriter sr = new StreamWriter(NewFileName);
            sr.WriteLine(Base64String);
            sr.Close();
        }
        private void btnUploadDocument(object sender, RoutedEventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select Documents";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {

                filename = op.FileName;
                DocumentViewModel obj = new DocumentViewModel();

                obj.DocumentImageSource = BitmapFrame.Create(new Uri(op.FileName), BitmapCreateOptions.None,
                                                   BitmapCacheOption.OnLoad);

                obj.SRNo = obj.SRNo++;
                obj.EnrollmentNo = objModel.EnrollmentNo;
                obj.FileName = op.FileName;
                obj.FullFileName = objModel.Schoolid + "/" + objModel.EnrollmentNo + "/" + System.IO.Path.GetFileName(obj.FileName);
                obj.Schoolid = objModel.Schoolid;
                obj.Parameter = obj;
                //obj.isBusy = true;
                obj.Command = new DelegateCommand(objModel.RemoveDocument);
                objModel.lstDocuments_.Add(obj);
                LoadImageAsync();

            }

        }
        async void LoadImageAsync()
        {
            await loadImage();
        }
        Task loadImage()
        {
            return Task.Run(() =>
            {
                CopyPhotoToLocalCacheFolder(filename);

            }
            );
        }

        private void btnDone(object sender, RoutedEventArgs e)
        {
            UploadToBlob();



        }
        async void UploadToBlob()
        {
            foreach (DocumentViewModel obj in objModel.lstDocuments_)
            {

                obj.isBusy = true;
                await Upload(
                    obj.FileName, obj.FullFileName, obj.EnrollmentNo, obj.Schoolid

                    );
                obj.isBusy = false;

            }
            //objModel.lstDocuments.Clear();
            myEvent(objModel);

            this.Close();

        }
        Task Upload(string filename, string fullfilename, string Enrollmentno, string schoolid)
        {
            BlobUploader objUploader = new BlobUploader();
            return Task.Run(() =>
            {

                objUploader.FileName = filename;
                objUploader.FullFileName = fullfilename;
                objUploader.EnrollmentNo = Enrollmentno;
                objUploader.SchoolID = schoolid;
                objUploader.UploadFile();


            });
        }


    }
}
