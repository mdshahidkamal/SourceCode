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
using System.Windows.Navigation;
using System.Windows.Shapes;
using IMS.ViewModels;
using System.Text.RegularExpressions;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using HospitalManagementSystem.ViewModels;
namespace IMS.Views
{
    /// <summary>
    /// Interaction logic for InvoiceDetails.xaml
    /// </summary>
    public partial class InvoiceDetails : UserControl
    {
        InvoiceDetailsViewModel objInvoiceDetailsViewModel;
        public InvoiceDetails()
        {
            objInvoiceDetailsViewModel = new InvoiceDetailsViewModel();
            InitializeComponent();
            this.DataContext = objInvoiceDetailsViewModel;
        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {



            if (e.AddedItems.Count > 0)
            {
                var x = ((System.Windows.Controls.DataGrid)(sender)).SelectedCells;
                var y = x.FirstOrDefault();
                var z = y.Item;
                var a = ((FormEntity)(z));

                //objInvoiceDetailsViewModel.RemoveParticular(a);

            }

        }
        private void DataGrid_Selected_1(object sender, RoutedEventArgs e)
        {

        }
        private void btnSearch(object sender, RoutedEventArgs e)
        {

        }
        InvoiceSearch obj;
        private void cmdSearchPopUp(object sender, RoutedEventArgs e)
        {
            obj = new InvoiceSearch();
            obj.onCallback += obj_onCallback;
            obj.ShowDialog();

        }
        void obj_onCallback(object param)
        {

            string[] pk = ((string[])param);
            objInvoiceDetailsViewModel.Search(Convert.ToString(pk[0]));
            obj.Close();
        }
        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {

            
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DependencyObject dep = (DependencyObject)e.OriginalSource;

            while ((dep != null) && !(dep is DataGridCell) && !(dep is DataGridColumnHeader))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }
            if (dep == null)
                return;

            if (dep is DataGridColumnHeader)
            {
                DataGridColumnHeader columnHeader = dep as DataGridColumnHeader;
                // do something
            }

            if (dep is DataGridCell)
            {
                DataGridCell cell = dep as DataGridCell;
                // navigate further up the tree
                while ((dep != null) && !(dep is DataGridRow))
                {
                    dep = VisualTreeHelper.GetParent(dep);
                }

                DataGridRow row = dep as DataGridRow;
                var item = row.Item;

                DataGridColumn c = cell.Column;
                if (MessageBoxResult.Yes == MessageBox.Show("Do you want to delete this Item", "Delete", MessageBoxButton.YesNo,MessageBoxImage.Exclamation))
                {

                    objInvoiceDetailsViewModel.RemoveParticular((FormEntity)item);
                }

            }
            


        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DependencyObject dep = (DependencyObject)e.OriginalSource;

            while ((dep != null) && !(dep is DataGridCell) && !(dep is DataGridColumnHeader))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }
            if (dep == null)
                return;

            if (dep is DataGridColumnHeader)
            {
                DataGridColumnHeader columnHeader = dep as DataGridColumnHeader;
                // do something
            }

            if (dep is DataGridCell)
            {
                DataGridCell cell = dep as DataGridCell;
                // navigate further up the tree
                while ((dep != null) && !(dep is DataGridRow))
                {
                    dep = VisualTreeHelper.GetParent(dep);
                }

                DataGridRow row = dep as DataGridRow;
                var item = row.Item;

                DataGridColumn c = cell.Column;
                if (MessageBoxResult.Yes == MessageBox.Show("Do you want to delete this Item", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Exclamation))
                {

                    objInvoiceDetailsViewModel.RemovePayment((FormEntity)item);
                }

            }



        }
       
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //PaymentDetails obj = new PaymentDetails(objInvoiceDetailsViewModel);
            //obj.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            //ParticularDetails obj = new ParticularDetails();
            //obj.ShowDialog();
        }
        



    }
}
