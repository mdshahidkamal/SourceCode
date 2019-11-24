using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;

namespace HospitalManagementSystem.Models
{
    public class ViewModelPatientDetails_RPT : ViewModels.BaseViewModel
    {
        public ObservableCollection<ModelPatientDetails_RPT> lst_ModelPatientDetails_RPT { get; set; }
        PatientDetailsViewModel objPatientDetailsViewModel = new PatientDetailsViewModel();

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public ViewModelPatientDetails_RPT()
        {
            lst_ModelPatientDetails_RPT = new ObservableCollection<ModelPatientDetails_RPT>();
        }
        public void SelectReport()
        {
            string sql = "select ID, PatientName,Age,Gender,ContactNumber as ContactDetails,Address,DoctorName,Amount,format(createddate,'Short Date') as CreatedDate1 from billdetails where CreatedDate >=#" + FromDate + "# and CreatedDate<=#" + ToDate+ "# order by Id desc";
            DataTable SearchResult = DAL.Select(sql);
            foreach (DataRow dr in SearchResult.Rows)
            {
                Models.ModelPatientDetails_RPT obj = new Models.ModelPatientDetails_RPT();
                obj.ID = dr["ID"].ToString();
                obj.PatientName = dr["PatientName"].ToString();
                obj.Age = dr["Age"].ToString();
                obj.Gender = dr["Gender"].ToString();
                obj.ContactNumber = dr["ContactDetails"].ToString();
                obj.Address = dr["Address"].ToString();
                sql = "select MedicineName from billmedicinemapping where billid='" + dr["ID"].ToString() + "'";
                DataTable dtmedicine = DAL.Select(sql);
                obj.Prescription = objPatientDetailsViewModel.GetCommaSeparatedValues(dtmedicine);
                obj.DoctorName = dr["DoctorName"].ToString();
                obj.Amount = dr["Amount"].ToString();
                obj.CreatedDate = Convert.ToDateTime(dr["CreatedDate1"]).Date;
            
                lst_ModelPatientDetails_RPT.Add(obj);
            }
        }
    }
    public class ModelPatientDetails_RPT : ViewModels.BaseViewModel
    {
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set
            {
                if (value != _ID)
                {
                    _ID = value;
                    RaisePropertyChanged(() => ID);
                }
            }
        }
        private string _PatientName;
        public string PatientName
        {
            get { return _PatientName; }
            set
            {
                if (value != _PatientName)
                {
                    _PatientName = value;
                    RaisePropertyChanged(() => PatientName);
                }
            }
        }
        private string _Age;
        public string Age
        {
            get { return _Age; }
            set
            {
                if (value != _Age)
                {
                    _Age = value;
                    RaisePropertyChanged(() => Age);
                }
            }
        }


        private string _Gender;
        public string Gender
        {
            get { return _Gender; }
            set
            {
                if (value != _Gender)
                {
                    _Gender = value;
                    RaisePropertyChanged(() => Gender);
                }
            }
        }
        private string _ContactNumber;
        public string ContactNumber
        {
            get { return _ContactNumber; }
            set
            {
                if (value != _ContactNumber)
                {
                    _ContactNumber = value;
                    RaisePropertyChanged(() => ContactNumber);
                }
            }
        }
        private string _Address;
        public string Address
        {
            get { return _Address; }
            set
            {
                if (value != _Address)
                {
                    _Address = value;
                    RaisePropertyChanged(() => Address);
                }
            }
        }
        private string _DoctorName;
        public string DoctorName
        {
            get { return _DoctorName; }
            set
            {
                if (value != _DoctorName)
                {
                    _DoctorName = value;
                    RaisePropertyChanged(() => DoctorName);
                }
            }
        }
        private string _Amount;
        public string Amount
        {
            get { return _Amount; }
            set
            {
                if (value != _Amount)
                {
                    _Amount = value;
                    RaisePropertyChanged(() => Amount);
                }
            }
        }
        private string _Prescription;
        public string Prescription
        {
            get { return _Prescription; }
            set
            {
                if (value != _Prescription)
                {
                    _Prescription = value;
                    RaisePropertyChanged(() => Prescription);
                }
            }
        }
        private DateTime _CreatedDate;
        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set
            {
                if (value != _CreatedDate)
                {
                    _CreatedDate = value;
                    RaisePropertyChanged(() => CreatedDate);
                }
            }
        }
        private DateTime _CreatedTime;
        public DateTime CreatedTime
        {
            get { return _CreatedTime; }
            set
            {
                if (value != _CreatedTime)
                {
                    _CreatedTime = value;
                    RaisePropertyChanged(() => CreatedTime);
                }
            }
        }







    }
}
