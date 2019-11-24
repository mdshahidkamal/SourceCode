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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LetterTrackingSystem.Views
{
    /// <summary>
    /// Interaction logic for SearchLetter.xaml
    /// </summary>
    /// 
    public delegate void myCallback(object param);
    public partial class SearchLetter : UserControl
    {
        public event myCallback onCallback;
        PatientDetailsViewModel objviewmodel = null;
        public SearchLetter()
        {
            InitializeComponent();
            objviewmodel = new PatientDetailsViewModel();
            this.DataContext = objviewmodel;
        }
        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                string PK = ((System.Data.DataRowView)(((object[])(e.AddedItems))[0])).Row.ItemArray[0].ToString();
                //objviewmodel.SearchWithID(PK);
                string[] arr = new string[] { "Letter", PK };
                onCallback(arr);
            }
        }
    }
}
