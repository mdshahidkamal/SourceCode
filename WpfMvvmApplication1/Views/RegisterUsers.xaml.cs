using HospitalManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
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
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;
namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for RegisterUsers.xaml
    /// </summary>
    public partial class RegisterUsers : Window
    {
        Hashtable previewRegex = new Hashtable();
        Hashtable completionRegex = new Hashtable();
        Hashtable errorMessage = new Hashtable();
        Hashtable validationState = new Hashtable();
        enum ValidationStates { OK, ERROR, WARNING };
        public RegisterUsers()
        {
            InitializeComponent();
            this.DataContext = new RegisterUsersViewModel();
            previewRegex["Date"] = @"^(\d| |-)*$";
            completionRegex["Date"] = @"^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$";
            errorMessage["Date"] = "Write date on the form YYYY-MM-DD";
            previewRegex["Email"] = @""; // Needs some keypress regex for valid chars in an email..
            completionRegex["Email"] = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
            errorMessage["Email"] = "Enter a valid email, eg. sven.svensson@sven.se";
            previewRegex["Telephone"] = @"^(\d| |-)*$";
            completionRegex["Telephone"] = @"^(\d| |-)*$"; // This regex needs some improvement!
            errorMessage["Telephone"] = "Valid phonenumbers contains digits, numbers or spaces";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RegisterUsersViewModel objmodel = this.DataContext as RegisterUsersViewModel;
            DataGrid dg = sender as DataGrid;
            var selecteditem = ((System.Windows.Controls.Primitives.MultiSelector)(dg)).SelectedItems;
            foreach (DataRowView dr in selecteditem)
            {
                objmodel.PrimaryKey = dr[0].ToString();
                objmodel.GetSingleRecord();
            }

        }

        private void KeypressValidation(object sender, TextCompositionEventArgs e)
        {
            // Handle to the textbox tjhat should be validated..
            TextBox tbox = (TextBox)sender;
            // Fetch regex..
            Regex regex = new Regex((string)previewRegex[(string)tbox.Tag]);
            // Check match and put error styles and messages..
            if (regex.IsMatch(e.Text))
            {
                if ((ValidationStates)validationState[tbox.Name] !=
                  ValidationStates.OK) tbox.Style = (Style)FindResource("textBoxNormalStyle");
                validationState[tbox.Name] = ValidationStates.OK;
            }
            else
            {
                if ((ValidationStates)validationState[tbox.Name] != ValidationStates.WARNING)
                {
                    tbox.Style = (Style)FindResource("textBoxInfoStyle");
                    validationState[tbox.Name] = ValidationStates.WARNING;
                    // Very important if want to use Template.FindName when changing
                    // style dynamically!
                    tbox.UpdateLayout();
                }
                // Fetch the errorimage in the tbox:s control template.. 
                Image errImg = (Image)tbox.Template.FindName("ErrorImage", tbox);
                // And set its tooltip to the errormessage of the textboxs validation code..
                errImg.ToolTip = (string)errorMessage[(string)tbox.Tag];
                // Use this if you dont want the user to enter something in textbox
                // that invalidates it.
                e.Handled = true;
            }
        }

        private void CompletionValidation(object sender, RoutedEventArgs e)
        {

        }

        private void InitValidation(object sender, RoutedEventArgs e)
        {

        }
    }
}
