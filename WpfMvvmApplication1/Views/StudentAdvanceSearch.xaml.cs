using HospitalManagementSystem.ViewModels;
using LetterTrackingSystem.Views;
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

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for StudentAdvanceSearch.xaml
    /// </summary>
    public partial class StudentAdvanceSearch : Window
    {
        public event myCallback onCallback;
        StudentDetailsViewModel objStudentDetailsViewModel = null;
        public StudentAdvanceSearch()
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
                string[] arr = new string[] { PK };
                onCallback(arr);
                //this.Close();
            }
        }
    }
}
