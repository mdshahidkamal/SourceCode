using HospitalManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Configuration;
using HospitalManagementSystem.Helpers;
namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for ReportsHostingForm.xaml
    /// </summary>
    public partial class ReportsHostingForm : UserControl
    {
        Models.ViewModelPatientDetails_RPT obj_ViewModelPatientDetails_RPT = new Models.ViewModelPatientDetails_RPT();
        public ReportsHostingForm()
        {
            try
            {
                InitializeComponent();
                fromdate.SelectedDate = DateTime.Now.Date.Subtract(new TimeSpan(1, 0, 0, 0));
                todate.SelectedDate = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.InnerException.ToString(), MessageType.Debug);
            }

        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                DAL.logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);
                string reportpath = ConfigurationSettings.AppSettings["reportpath"].ToString();
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new
                    Microsoft.Reporting.WinForms.ReportDataSource();
                reportDataSource1.Name = "DataSet3";
                reportDataSource1.Value = obj_ViewModelPatientDetails_RPT.lst_ModelPatientDetails_RPT;
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);

                this._reportViewer.LocalReport.ReportPath = reportpath;
                _reportViewer.RefreshReport();
                _reportViewer.Refresh();
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.InnerException.ToString(), MessageType.Debug);
            }

        }
        private void btnSearch(object sender, RoutedEventArgs e)
        {
            obj_ViewModelPatientDetails_RPT.FromDate = fromdate.SelectedDate.Value;
            obj_ViewModelPatientDetails_RPT.ToDate = todate.SelectedDate.Value;
            obj_ViewModelPatientDetails_RPT.SelectReport();
            ReportViewer_Load(null, null);
        }
    }
}
