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

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for PatientDetails.xaml
    /// </summary>
    public partial class PatientDetails : UserControl
    {
        PatientDetailsViewModel objviewmodel = null;
        public PatientDetails()
        {
            InitializeComponent();
            objviewmodel = new PatientDetailsViewModel();
            this.DataContext = objviewmodel;
            FillAutoFill();

        }
        public PatientDetails(int primarykey)
        {
            InitializeComponent();
            objviewmodel = new PatientDetailsViewModel(primarykey);
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
                foreach(char ch in e.Text) 
                {
                  if (!((Char.IsDigit(ch) || ch.Equals(':')))) 
                  {
                    e.Handled = true;
                    break; 
                  }
                }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
