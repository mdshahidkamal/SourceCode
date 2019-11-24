using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for StaffDetails.xaml
    /// </summary>
    public partial class StaffDetails : UserControl
    {
        StaffDetailsViewModel objviewmodel = null;
        //StudentSearchViewModel objStudentSearchViewModel = null;
        ImageConvertor objImageConvertor = new ImageConvertor(); 
        public StaffDetails()
        {
            InitializeComponent();
            objviewmodel = new StaffDetailSearchViewModel();
            //objStudentSearchViewModel = new StudentSearchViewModel();
            this.DataContext = objviewmodel;
            string dir = System.Environment.CurrentDirectory;
        }
        public StaffDetails(int primarykey)
        {
            InitializeComponent();
            objviewmodel = new StaffDetailSearchViewModel(primarykey);
            //objStudentSearchViewModel = new StudentSearchViewModel();
            this.DataContext = objviewmodel;
            string dir = System.Environment.CurrentDirectory;
        }
        void CopyPhotoToLocalCacheFolder(string filename)
        {
            string TempPath = ConfigurationSettings.AppSettings["TempPath"].ToString();
            string PhotID = Guid.NewGuid().ToString();
            objviewmodel.PhotoID = PhotID;
            string NewFileName = TempPath + PhotID;
            objImageConvertor.ConvertPhotoToByteArray(filename);
            byte[] bytearr = objImageConvertor.ImageStream;
            string Base64String = Convert.ToBase64String(bytearr);
            objviewmodel.Picture = Base64String;
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

        private void cmdSearchPopUp(object sender, RoutedEventArgs e)
        {

           
        }
        void obj_onCallback(object param)
        {
            string[] pk = ((string[])param);
            objviewmodel.Search(Convert.ToInt32(pk[0]));
        }
    }
}
