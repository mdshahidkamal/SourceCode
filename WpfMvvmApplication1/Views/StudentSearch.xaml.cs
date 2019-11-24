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
    /// Interaction logic for StudentSearch.xaml
    /// </summary>
    public partial class StudentSearch : UserControl
    {
        public event myCallback onCallback;
        StudentDetailsViewModel objStudentDetailsViewModel = null;
        public StudentSearch()
        {
            InitializeComponent();
            objStudentDetailsViewModel = new StudentSearchViewModel();
            this.DataContext = objStudentDetailsViewModel;

        }
        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            if (e.AddedItems.Count > 0)
            {
                var x = ((System.Windows.Controls.DataGrid)(sender)).SelectedCells;
                var y = x.FirstOrDefault();
                var z = y.Item;
                var a = ((HospitalManagementSystem.ViewModels.StudentDetailsViewModelEntity)(z)).StudentID;
                string PK = a;
                //objviewmodel.SearchWithID(PK);
                //string[] arr = new string[] { PK };
                string[] arr = new string[] { "StudentAdd", PK };
                onCallback(arr);
                //this.Close();
            }
        }


        private void btnSearch(object sender, RoutedEventArgs e)
        {
            string[] arr = new string[] { "StudentAdd" };
            onCallback(arr);
        }
    }
}
