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
namespace IMS.Views
{
    /// <summary>
    /// Interaction logic for BillSearch.xaml
    /// </summary>
    public partial class BillSearch : Window
    {
        BillingViewModel objBillModel;
        public event myCallback onCallback;
        public BillSearch()
        {
            objBillModel = new BillingViewModel();
            InitializeComponent();
            this.DataContext = objBillModel;
        }
      
        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var x = ((System.Windows.Controls.DataGrid)(sender)).SelectedCells;
                var y = x.FirstOrDefault();
                var z = y.Item;
                var a = ((HospitalManagementSystem.ViewModels.FormEntity)(z)).BillId;
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
