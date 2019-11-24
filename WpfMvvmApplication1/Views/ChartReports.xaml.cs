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
using HospitalManagementSystem.ViewModels;
using System.Windows.Controls.DataVisualization.Charting;
using System.Collections.ObjectModel;
using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for ChartReports.xaml
    /// </summary>
    /// 

    public partial class ChartReports : UserControl
    {
        ChartViewModel objViewModel;
        public ChartReports()
        {
            try
            {
                InitializeComponent();
                objViewModel = new ChartViewModel();
                this.DataContext = objViewModel;

                var dataSourceList = new List<List<KeyValuePair<string, int>>>();

                List<KeyValuePair<string, int>> llistaGastats = new List<KeyValuePair<string, int>>();
                List<KeyValuePair<string, int>> llistaPreu = new List<KeyValuePair<string, int>>();

                llistaGastats.Add(new KeyValuePair<string, int>("", 1));


                llistaPreu.Add(new KeyValuePair<string, int>("", 1));
                dataSourceList.Add(llistaPreu);
                dataSourceList.Add(llistaGastats);
                mcChart.DataContext = dataSourceList;

            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }

        }

        private void btnSearch(object sender, RoutedEventArgs e)
        {
            objViewModel.Search();
            GetcolumnChart();
            GetExpenseDataChart();
        }
        void GetcolumnChart()
        {

            var dataSourceList = new List<ObservableCollection<KeyValuePair<string, int>>>();
            dataSourceList.Add(objViewModel.lstIncome);
            dataSourceList.Add(objViewModel.lstExpense);
            mcChart.DataContext = dataSourceList;
        }
        void GetExpenseDataChart()
        {
            var dataSourceList = new List<ObservableCollection<KeyValuePair<string, int>>>();
            dataSourceList.Add(objViewModel.lstExpenseData);
            expenseChart.DataContext = dataSourceList;

        }
    }
}
