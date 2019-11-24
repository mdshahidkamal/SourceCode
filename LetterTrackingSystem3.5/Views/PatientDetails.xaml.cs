using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;
using MODI;
using System.Threading;
using System.Windows.Threading;
using System.ComponentModel;
namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for PatientDetails.xaml
    /// </summary>
    public partial class PatientDetails : System.Windows.Controls.UserControl
    {
        PatientDetailsViewModel objviewmodel = null;
        public PatientDetails()
        {
            InitializeComponent();
            objviewmodel = new PatientDetailsViewModel();
            objviewmodel.ScreenWidth = (System.Windows.SystemParameters.PrimaryScreenWidth / 2) - 50;
            this.DataContext = objviewmodel;
            //FillAutoFill();

        }
        void FillAutoFill()
        {
            string sql = "select doctorname from doctors";
            DataTable dt = DAL.Select(sql);
            List<string> lstdoctorname = new List<string>();

            //foreach (DataRow dr in dt.Rows)
            //{
            //    lstdoctorname.Add(dr["doctorname"].ToString());
            //}
            //txtAutoComplete.ItemsSource = lstdoctorname;

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                string PK = ((System.Data.DataRowView)(((object[])(e.AddedItems))[0])).Row.ItemArray[0].ToString();
                objviewmodel.SearchWithID(PK);
            }
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            foreach (char ch in e.Text)
            {
                if (!((Char.IsDigit(ch) || ch.Equals(':'))))
                {
                    e.Handled = true;
                    break;
                }
            }
        }
        string FileName = string.Empty;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.FilterIndex = 1;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.IsEnabled = false;
                FileName = openFileDialog1.FileName;
                this.IsEnabled = false;
                ExecuteInBG();

            }
        }
        void ExecuteInBG()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Background,
                       (ThreadStart)delegate()
                           {
                               string ImagePath = CopyImage(FileName);
                               txtFileName.Text = ImagePath;
                               string LetterContent = ExtractTextFromImage(txtFileName.Text);
                               objviewmodel.LetterContent = LetterContent;
                               this.IsEnabled = true;
                           }
                         );

        }
        string CopyImage(string sourceFile)
        {
            string destpath = CreateFolder();
            string filename = System.IO.Path.GetFileName(sourceFile);
            string destFile = destpath + filename;
            System.IO.File.Copy(sourceFile, destFile, true);
            return destFile;
        }
        string CreateFolder()
        {
            //Get EXE Location
            string exePath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            //Create Document Folder
            string todayDate = DateTime.Now.ToString("yyyyMMdd");

            exePath += @"\Documents\" + todayDate + @"\";
            try
            {
                // Determine whether the directory exists.
                if (!Directory.Exists(exePath))
                {
                    //If not exist then create it
                    DirectoryInfo di = Directory.CreateDirectory(exePath);
                }
            }
            catch (Exception e)
            {

            }
            finally { }
            return exePath;
        }
        string ExtractTextFromImage(string filePath)
        {
            Document modiDocument = new Document();
            modiDocument.Create(filePath);
            modiDocument.OCR(MiLANGUAGES.miLANG_ENGLISH);
            MODI.Image modiImage = (modiDocument.Images[0] as MODI.Image);
            string extractedText = modiImage.Layout.Text;
            modiDocument.Close();
            return extractedText;
        }


    }
}
