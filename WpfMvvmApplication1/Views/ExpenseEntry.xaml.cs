using HospitalManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ExpenseEntry.xaml
    /// </summary>
    /// 
    
    public partial class ExpenseEntry : UserControl
    {
        SchoolExpenseModel objModel;
        public ExpenseEntry()
        {
            InitializeComponent();
            objModel = new SchoolExpenseModel();
            this.DataContext = objModel;
        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

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
