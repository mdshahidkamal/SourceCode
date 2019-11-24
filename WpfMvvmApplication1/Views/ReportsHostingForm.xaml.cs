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
using HospitalManagementSystem.Models;
using System.Threading;
using System.ComponentModel;
using Microsoft.Reporting.WinForms;
using IMS.ViewModels;

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for ReportsHostingForm.xaml
    /// </summary>
    public partial class ReportsHostingForm : Window
    {

        //public ViewModelPatientDetails_RPT obj_ViewModelPatientDetails_RPT { get; set; }
        ReportViewModel objReportViewModel = new ReportViewModel();

        public string ReportType { get; set; }

        public ReportsHostingForm()
        {
            InitializeComponent();
            ReportViewer_Load(null, null);
        }
     
        public ReportsHostingForm(string ReportType)
        {
            try
            {
                InitializeComponent();
                this.ReportType = ReportType;
                ReportViewer_Load(null, null);

            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.InnerException.ToString(), MessageType.Debug);
            }

        }

        private void Bgworker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            ReportLoad();
        }
        async void ReportLoad()
        {
            try
            {
                ReportDataSource reportDataSource1 = new ReportDataSource();
                ReportDataSource reportDataSource2 = new ReportDataSource();
                string reportpath = string.Empty;
                if (ReportType == "Bill")
                {
                    
                    await objReportViewModel.GetBillDetails();
                    DAL.logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);
                    reportpath = ConfigurationSettings.AppSettings["Bill"].ToString();
                    reportDataSource1.Name = "DataSet1";
                    reportDataSource1.Value = objReportViewModel.lstBillDataSource;
                    
                }
                this._reportViewer.LocalReport.EnableExternalImages = true;
                this._reportViewer.LocalReport.DataSources.Clear();
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource2);

                this._reportViewer.LocalReport.ReportPath = reportpath;
                string imagePath = ConfigurationSettings.AppSettings["TempPath"].ToString();
                imagePath = "file:///" + "c://Temp/SMS//" + Common.ClientLogo;
                ReportParameter parameter = new ReportParameter("logopath", imagePath);

                _reportViewer.LocalReport.SetParameters(parameter);
                this._reportViewer.ProcessingMode = ProcessingMode.Local;
                _reportViewer.RefreshReport();
                _reportViewer.Refresh();
            }
            catch (Exception ex)
            {
                DAL.logger.Log(Convert.ToString(ex.InnerException), MessageType.Debug);
            }
        }
    }
}
