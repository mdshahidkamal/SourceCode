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
using IMS.ViewModels;
using HospitalManagementSystem.ViewModels;
namespace IMS.Views
{
    /// <summary>
    /// Interaction logic for InvoiceSearch.xaml
    /// </summary>
    public partial class InvoiceSearch : Window
    {
        InvoiceDetailsViewModel objInvoiceDetailsViewModel;
        public event myCallback onCallback;
        public InvoiceSearch()
        {
            InitializeComponent();
            objInvoiceDetailsViewModel = new InvoiceDetailsViewModel();
            this.DataContext = objInvoiceDetailsViewModel;

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var x = ((System.Windows.Controls.DataGrid)(sender)).SelectedCells;
                var y = x.FirstOrDefault();
                var z = y.Item;
                var a = ((FormEntity)(z)).InvoiceID;
                string PK = a;
                //objviewmodel.SearchWithID(PK);
                //string[] arr = new string[] { PK };
                string[] arr = new string[] { PK };
                onCallback(arr);
                //this.Close();
            }
        }
    }
}
