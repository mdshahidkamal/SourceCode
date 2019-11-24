using LetterTrackingSystem.Views;
using HospitalManagementSystem.ViewModels;
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
using System.Windows.Shapes;

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for StaffSearch.xaml
    /// </summary>
    public partial class StaffSearch : UserControl
    {
        public event myCallback onCallback;
        StaffDetailsViewModel objViewModel = null;
        public StaffSearch()
        {
            InitializeComponent();
            objViewModel = new StaffDetailSearchViewModel();
            this.DataContext = objViewModel;
        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
            if (e.AddedItems.Count > 0)
            {
                var x = ((System.Windows.Controls.DataGrid)(sender)).SelectedCells;
                var y = x.FirstOrDefault();
                var z = y.Item;
                var a = ((HospitalManagementSystem.ViewModels.StaffDetailsViewModelEntity)(z)).StaffID;

                string PK = a;
                //objviewmodel.SearchWithID(PK);
                string[] arr = new string[] { "StaffAdd", PK };
                onCallback(arr);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddNew(object sender, RoutedEventArgs e)
        {
            string[] arr = new string[] { "StaffAdd" };
            onCallback(arr);
        }
    }
}
