using HospitalManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for StudentPayments.xaml
    /// </summary>
    public partial class StudentPayments : UserControl
    {
        StudentPaymentViewModel objviewmodel = null;
        public StudentPayments()
        {
            InitializeComponent();
            objviewmodel = new StudentPaymentViewModel();
            //objStudentSearchViewModel = new StudentSearchViewModel();
            this.DataContext = objviewmodel;
        
        }
       
        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            foreach (StudentPaymentViewModelEntity entity in objviewmodel.lstStudentPaymentDetails)
            {
                if (entity.PrintingChecked)
                {
                    int result = 0;
                    int.TryParse(entity.Schoolid, out result);
                    int schoolid = result;
                    int.TryParse(entity.EntityID, out result);
                    int studentid = result;
                    int.TryParse(entity.ID, out result);
                    int primarykey = result;

                    ReportsHostingForm obj = new ReportsHostingForm(primarykey, studentid,schoolid, "PaymentReciept");
                    obj.ShowDialog();
                }
            }
            
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
    }
}
