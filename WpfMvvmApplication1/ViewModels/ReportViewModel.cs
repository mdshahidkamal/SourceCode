using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.ViewModels;
using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace IMS.ViewModels
{
    class ReportViewModel : BillReportModel
    {
        public string ReportType { get; set; }

        public Task GetBillDetails()
        {
            return new Task(() => Console.WriteLine(""));
                
        }

        private ObservableCollection<BillReportModel> _lstBillDataSource;
        public ObservableCollection<BillReportModel> lstBillDataSource { get { return _lstBillDataSource; } set { if (value != _lstBillDataSource) { _lstBillDataSource = value; RaisePropertyChanged(() => lstBillDataSource); } } }

    }
    class BillReportModel:FormEntity
    {
       

    }
}
