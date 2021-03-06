﻿using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for ExpenseReportHostingForm.xaml
    /// </summary>
    public partial class ExpenseReportHostingForm : UserControl
    {
        Models.ViewModelPatientDetails_RPT obj_ViewModelPatientDetails_RPT;
        public ExpenseReportHostingForm()
        {
            InitializeComponent();
        }

        public ExpenseReportHostingForm(string reporttype)
        {
            InitializeComponent();
            obj_ViewModelPatientDetails_RPT = new Models.ViewModelPatientDetails_RPT();
            this.ReportType = reporttype;
            this.DataContext = obj_ViewModelPatientDetails_RPT;
            ReportViewer_Load(null, null);

        }
        public string ReportType { get; set; }
        public int PrimaryKey { get; set; }
        public int StudentId { get; set; }
        public int SchoolID { get; set; }
        public string SelectedAcademicYear { get; set; }
        public string SelectedClass { get; set; }

        public ExpenseReportHostingForm(int primarykey, int studentid, int schoolid)
        {
            try
            {
                InitializeComponent();
                this.PrimaryKey = primarykey;
                this.StudentId = studentid;
                this.SchoolID = schoolid;
                ReportViewer_Load(null, null);
                //this.DataContext = obj_ViewModelPatientDetails_RPT;
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.InnerException.ToString(), MessageType.Debug);
            }

        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            //            LoadReport();
        }
        async void LoadReport()
        {
            try
            {
                ReportDataSource reportDataSource1 = new ReportDataSource();
                ReportDataSource reportDataSource2 = new ReportDataSource();
                string reportpath = string.Empty;
                if (ReportType == "ExpenseReport")
                {
                    
                    await obj_ViewModelPatientDetails_RPT.SelectExpenseReport();
                    DAL.logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);
                    reportpath = ConfigurationSettings.AppSettings["ExpenseReport"].ToString();
                    reportDataSource1.Name = "DataSet1";
                    reportDataSource1.Value = obj_ViewModelPatientDetails_RPT.lstModelExpenseDetails_RPT;
                    reportDataSource2.Name = "DataSet2";
                    reportDataSource2.Value = obj_ViewModelPatientDetails_RPT.lstSchoolDetails;
                }
              
                string logoPath = @"C:\Temp\SMS\" + Common.SchoolLogo;

                this._reportViewer.LocalReport.EnableExternalImages = true;

                this._reportViewer.LocalReport.DataSources.Clear();
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource2);

                this._reportViewer.LocalReport.ReportPath = reportpath;


                _reportViewer.RefreshReport();
                _reportViewer.Refresh();
            }
            catch (Exception ex)
            {
                DAL.logger.Log(Convert.ToString(ex.InnerException), MessageType.Debug);
            }

        }

        private void btnSearch(object sender, RoutedEventArgs e)
        {
            LoadReport();
        }
    }
}
