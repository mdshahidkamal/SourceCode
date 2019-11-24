using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using HospitalManagementSystem.ViewModels;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for StudentDetails.xaml
    /// </summary>
    public partial class StudentDetails : UserControl
    {
        StudentDetailsViewModel objviewmodel = null;
        //StudentSearchViewModel objStudentSearchViewModel = null;
        ImageConvertor objImageConvertor = new ImageConvertor();
        public StudentDetails()
        {
            InitializeComponent();
            objviewmodel = new StudentSearchViewModel();
            //objStudentSearchViewModel = new StudentSearchViewModel();
            this.DataContext = objviewmodel;
            string dir = System.Environment.CurrentDirectory;
        }
        public StudentDetails(int primarykey)
        {
            InitializeComponent();
            objviewmodel = new StudentSearchViewModel(primarykey);
            this.DataContext = objviewmodel;
            string dir = System.Environment.CurrentDirectory;
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            int result;
            if (!IsTextAllowed(e.Text))
            {
                e.Handled = true;
            }

        }
        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }
        private void txtEmailAddress_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int result;
            if (!IsValidEmail(e.Text))
            {
                e.Handled = true;
            }

        }

        void CopyPhotoToLocalCacheFolder(string filename)
        {
            string TempPath = ConfigurationSettings.AppSettings["TempPath"].ToString();
            string PhotID = Guid.NewGuid().ToString();
            string NewFileName = TempPath + PhotID + ".photo";
            objviewmodel.PhotoID = NewFileName;
            objImageConvertor.ConvertPhotoToByteArray(filename);
            byte[] bytearr = objImageConvertor.ImageStream;
            string Base64String = Convert.ToBase64String(bytearr);
            //            objviewmodel.Picture=Base64String;
            StreamWriter sr = new StreamWriter(NewFileName);
            sr.WriteLine(Base64String);
            sr.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
            "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
            "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {

                CopyPhotoToLocalCacheFolder(op.FileName);

                objviewmodel.ImageSource = BitmapFrame.Create(new Uri(op.FileName), BitmapCreateOptions.None,
                                                   BitmapCacheOption.OnLoad);
                //imgPhoto.Source = new BitmapImage(new Uri(op.FileName));



            }


        }
        StudentAdvanceSearch obj;
        private void cmdSearchPopUp(object sender, RoutedEventArgs e)
        {
            obj = new StudentAdvanceSearch();
            obj.onCallback += obj_onCallback;
            obj.ShowDialog();

        }

        void obj_onCallback(object param)
        {
            string[] pk = ((string[])param);
            objviewmodel.Search(Convert.ToInt32(pk[0]));
            obj.Close();
        }

        private void txtEmailAddress_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox text = (TextBox)sender;

            string strEMail = text.Text;
            if (strEMail.Length > 0)
            {
                Regex regx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regx.Match(strEMail);
                if (!match.Success)
                {
                    text.Text = string.Empty;
                    MessageBox.Show("Invalid Email Address", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }


        }
        private static bool IsValidEmail(string text)
        {
            return true;
            //Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
            //return !Regex.IsMatch(text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
        }


        private void btnUploadDocument(object sender, RoutedEventArgs e)
        {

            objviewmodel.objDocumentModel.EnrollmentNo = objviewmodel.EnrollmentNo;
            objviewmodel.objDocumentModel.lstDocuments_.Clear();
            if (objviewmodel.lstDocuments == null)
            {
                objviewmodel.lstDocuments = new System.Collections.ObjectModel.ObservableCollection<DocumentViewModel>();
            }
            System.Collections.ObjectModel.ObservableCollection<DocumentViewModel> lstTemp = new System.Collections.ObjectModel.ObservableCollection<DocumentViewModel>();
            lstTemp = objviewmodel.lstDocuments;
            DocumentViewModel[] arr = new DocumentViewModel[lstTemp.Count];
            lstTemp.CopyTo(arr,0);

            foreach (DocumentViewModel documentviewmodel in arr)
            {
                objviewmodel.objDocumentModel.lstDocuments_.Add(documentviewmodel);// = objviewmodel.lstDocuments;
            }

            DocumentUploader obj = new DocumentUploader(objviewmodel.objDocumentModel);
            obj.myEvent += Obj_myEvent;
            obj.ShowDialog();
        }

        private void Obj_myEvent(DocumentModel objmodel)
        {

            System.Collections.ObjectModel.ObservableCollection<DocumentViewModel> lstTemp = new System.Collections.ObjectModel.ObservableCollection<DocumentViewModel>();
            lstTemp = objviewmodel.objDocumentModel.lstDocuments_;
            DocumentViewModel[] arr = new DocumentViewModel[lstTemp.Count];
            lstTemp.CopyTo(arr, 0);
            objviewmodel.lstDocuments.Clear();
            foreach (DocumentViewModel documentviewmodel in arr)
            {
                objviewmodel.lstDocuments.Add(documentviewmodel);// = objviewmodel.lstDocuments;
            }
            //            objviewmodel.lstDocuments = objmodel.lstDocuments_;
        }
    }
}
