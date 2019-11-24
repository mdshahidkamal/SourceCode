using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.ViewModels;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class ViewModelPatientDetails_RPT : ViewModels.BaseViewModel
    {
        public ObservableCollection<ModelPatientDetails_RPT> lst_ModelPatientDetails_RPT { get; set; }

        private ObservableCollection<ModelLetterDetails_RPT> _lst_ModelLetterDetails_RPT;
        public ObservableCollection<ModelLetterDetails_RPT> lst_ModelLetterDetails_RPT
        {
            get { return _lst_ModelLetterDetails_RPT; }
            set
            {
                if (value != _lst_ModelLetterDetails_RPT)
                {
                    _lst_ModelLetterDetails_RPT = value;
                    RaisePropertyChanged(() => lst_ModelLetterDetails_RPT);
                }
            }
        }

        private ObservableCollection<ModelPaymentReciept_RPT> _lst_ModelPaymentDetails_RPT;
        public ObservableCollection<ModelPaymentReciept_RPT> lst_ModelPaymentDetails_RPT
        {
            get { return _lst_ModelPaymentDetails_RPT; }
            set
            {
                if (value != _lst_ModelPaymentDetails_RPT)
                {
                    _lst_ModelPaymentDetails_RPT = value;
                    RaisePropertyChanged(() => lst_ModelPaymentDetails_RPT);
                }
            }
        }
        private ObservableCollection<ModelExpenseDetails_RPT> _lstModelExpenseDetails_RPT;
        public ObservableCollection<ModelExpenseDetails_RPT> lstModelExpenseDetails_RPT
        {
            get { return _lstModelExpenseDetails_RPT; }
            set
            {
                if (value != _lstModelExpenseDetails_RPT)
                {
                    _lstModelExpenseDetails_RPT = value;
                    RaisePropertyChanged(() => lstModelExpenseDetails_RPT);
                }
            }
        }


        private ObservableCollection<StaticDataModel> _lstAcademicYear;
        public ObservableCollection<StaticDataModel> lstAcademicYear
        {
            get { return _lstAcademicYear; }
            set
            {
                if (value != _lstAcademicYear)
                {
                    _lstAcademicYear = value;
                    RaisePropertyChanged(() => lstAcademicYear);
                }
            }
        }
        private ObservableCollection<StaticDataModel> _lstMonths;
        public ObservableCollection<StaticDataModel> lstMonths
        {
            get { return _lstMonths; }
            set
            {
                if (value != _lstMonths)
                {
                    _lstMonths = value;
                    RaisePropertyChanged(() => lstMonths);
                }
            }
        }
        private StaticDataModel _SelectedMonth;
        public StaticDataModel SelectedMonth
        {
            get { return _SelectedMonth; }
            set
            {
                if (value != _SelectedMonth)
                {
                    _SelectedMonth = value;
                    RaisePropertyChanged(() => SelectedMonth);
                }
            }
        }


        private StaticDataModel _SelectedAcademicYear;
        public StaticDataModel SelectedAcademicYear
        {
            get { return _SelectedAcademicYear; }
            set
            {
                if (value != _SelectedAcademicYear)
                {
                    _SelectedAcademicYear = value;
                    RaisePropertyChanged(() => SelectedAcademicYear);
                }
            }
        }

        private ObservableCollection<StaticDataModel> _lstClass;
        public ObservableCollection<StaticDataModel> lstClass
        {
            get { return _lstClass; }
            set
            {
                if (value != _lstClass)
                {
                    _lstClass = value;
                    RaisePropertyChanged(() => lstClass);
                }
            }
        }
        private StaticDataModel _SelectedClass;
        public StaticDataModel SelectedClass
        {
            get { return _SelectedClass; }
            set
            {
                if (value != _SelectedClass)
                {
                    _SelectedClass = value;
                    RaisePropertyChanged(() => SelectedClass);
                }
            }
        }




        //PatientDetailsViewModel objPatientDetailsViewModel = new PatientDetailsViewModel();

        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int studentId { get; set; }
        public int schoolid { get; set; }

        public int PrimaryKey { get; set; }

        private bool? _DialogResult;
        public bool? DialogResult
        {
            get { return _DialogResult; }
            set
            {
                if (value != _DialogResult)
                {
                    _DialogResult = value;
                    RaisePropertyChanged(() => DialogResult);
                }
            }
        }


        private ObservableCollection<ModelSchooldDetails> _lstSchoolDetails;
        public ObservableCollection<ModelSchooldDetails> lstSchoolDetails
        {
            get { return _lstSchoolDetails; }
            set
            {
                if (value != _lstSchoolDetails)
                {
                    _lstSchoolDetails = value;
                    RaisePropertyChanged(() => lstSchoolDetails);
                }
            }
        }

        public ViewModelPatientDetails_RPT()
        {
            //lst_ModelPatientDetails_RPT = new ObservableCollection<ModelPatientDetails_RPT>();
            lst_ModelPaymentDetails_RPT = new ObservableCollection<ModelPaymentReciept_RPT>();
            //SelectPaymentReport();
            GetClasssRoom();
            GetAcademicYear();
            GetMonth();
        }
        void GetClasssRoom()
        {
            DataTable dt = Common.GetClassRoom();
            lstClass = new ObservableCollection<StaticDataModel>();

            StaticDataModel obj1 = new StaticDataModel();
            obj1.StaticID = 0;
            obj1.StaticName = "All";
            lstClass.Add(obj1);

            foreach (DataRow dr in dt.Rows)
            {
                if (dr[1].ToString() != "--Select--")
                {
                    StaticDataModel obj = new StaticDataModel();
                    obj.StaticID = int.Parse(dr[0].ToString());
                    obj.StaticName = dr[1].ToString();
                    lstClass.Add(obj);
                }
            }
            
            

            this.SelectedClass = lstClass.OrderBy(x => "StaticName").FirstOrDefault();

        }
        void GetAcademicYear()
        {
            DataTable dt = Common.GetAcademicYear();
            lstAcademicYear = new ObservableCollection<StaticDataModel>();
            foreach (DataRow dr in dt.Rows)
            {
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID = int.Parse(dr[0].ToString());
                obj.StaticName = dr[1].ToString();
                lstAcademicYear.Add(obj);
            }

            this.SelectedAcademicYear = lstAcademicYear.FirstOrDefault();

        }
        void GetMonth()
        {
            string[] names = DateTimeFormatInfo.CurrentInfo.MonthNames;
            lstMonths = new ObservableCollection<StaticDataModel>();
            int counter = 0;
            StaticDataModel obj1 = new StaticDataModel();
            obj1.StaticID = counter;
            obj1.StaticName = "All";
            lstMonths.Add(obj1);
            foreach (string str in names)
            {
                counter++;
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID = counter;
                obj.StaticName = str;
                lstMonths.Add(obj);
                
            }

            this.SelectedMonth = lstMonths.FirstOrDefault();

        }

        public void SelectReport()
        {
            string sql = "select ID, PatientName,Age,Gender,ContactNumber as ContactDetails,Address,DoctorName,Amount,format(createddate,'Short Date') as CreatedDate1 from billdetails where CreatedDate >=#" + FromDate + "# and CreatedDate<=#" + ToDate + "# order by Id desc";
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
                //obj.Prescription = objPatientDetailsViewModel.GetCommaSeparatedValues(dtmedicine);
                obj.DoctorName = dr["DoctorName"].ToString();
                obj.Amount = dr["Amount"].ToString();
                obj.CreatedDate = Convert.ToDateTime(dr["CreatedDate1"]).Date;

                lst_ModelPatientDetails_RPT.Add(obj);
            }
        }
        public void SelectLetterReport()
        {
            lst_ModelLetterDetails_RPT = new ObservableCollection<ModelLetterDetails_RPT>();
            string sql = "EXEC DBO.GETREPORT '" + FromDate + "','" + ToDate + "'";
            DataTable SearchResult = DAL.Select(sql);
            foreach (DataRow dr in SearchResult.Rows)
            {
                Models.ModelLetterDetails_RPT obj = new Models.ModelLetterDetails_RPT();
                obj.SrNo = dr["SrNo"].ToString();
                obj.RefNo = dr["ReferenceNumber"].ToString();
                obj.Subject = dr["Subject"].ToString();
                obj.From = dr["From"].ToString();
                obj.To = dr["To"].ToString();
                obj.RecievedDate = dr["RecivedDate"].ToString();
                obj.LetterContent = dr["LetterContent"].ToString();
                obj.CreatedDate = dr["CreatedDate"].ToString();
                obj.CreatedTime = dr["CreatedTime"].ToString();
                lst_ModelLetterDetails_RPT.Add(obj);
            }
        }
        public Task SelectPaymentReport()
        {

            return Task.Run(() =>
            {

                lst_ModelPaymentDetails_RPT = new ObservableCollection<ModelPaymentReciept_RPT>();
                string sql = "[SMS].[GetStudentPaymentDetails] " + PrimaryKey + "," + studentId + "," + schoolid;
                DataTable SearchResult = DAL.Select(sql);
                foreach (DataRow dr in SearchResult.Rows)
                {
                    Models.ModelPaymentReciept_RPT obj = new Models.ModelPaymentReciept_RPT();
                    obj.AcademicYear = dr["AcademicYear"].ToString();
                    obj.Amount = dr["Amount"].ToString();
                    obj.CreatedDateTime = dr["CreatedDateTime"].ToString();
                    obj.EnrollmentNo = dr["EnrollmentNo"].ToString();
                    obj.ModeOfPayment = dr["ModeofPayment"].ToString();
                    obj.PaymentType = dr["PaymentType"].ToString();
                    obj.StudentName = dr["FullName"].ToString();
                    obj.RecieptID = dr["ID"].ToString();
                    obj.Class = dr["Class"].ToString();
                    lst_ModelPaymentDetails_RPT.Add(obj);
                }

                ModelSchooldDetails objSchooldetails = new ModelSchooldDetails();
                objSchooldetails.SchoolName = Common.SchoolName;
                objSchooldetails.SchoolAddress = Common.SchoolAddress;
                objSchooldetails.SchoolLogo = @"c:\Temp\SMS\" + Common.SchoolLogo;
                lstSchoolDetails = new ObservableCollection<ModelSchooldDetails>();
                lstSchoolDetails.Add(objSchooldetails);

            });
        }
        public Task SelectARAPReport()
        {
            return Task.Run(() =>
            {
                lst_ModelPaymentDetails_RPT = new ObservableCollection<ModelPaymentReciept_RPT>();
                string sql = "[SMS].[PaymentReport] " + this.Schoolid + ",'" + this.SelectedClass.StaticName + "','" + this.SelectedAcademicYear.StaticName + "'";
                DataTable SearchResult = DAL.Select(sql);
                foreach (DataRow dr in SearchResult.Rows)
                {
                    Models.ModelPaymentReciept_RPT obj = new Models.ModelPaymentReciept_RPT();
                    obj.AcademicYear = dr["AcademicYear"].ToString();
                    obj.Amount = dr["PaymentRecieved"].ToString();
                    obj.EnrollmentNo = dr["EnrollmentNo"].ToString();
                    obj.StudentName = dr["StudentName"].ToString();
                    obj.Class = dr["ClassRoom"].ToString();
                    lst_ModelPaymentDetails_RPT.Add(obj);


                }
                ModelSchooldDetails objSchooldetails = new ModelSchooldDetails();
                objSchooldetails.SchoolName = Common.SchoolName;
                objSchooldetails.SchoolAddress = Common.SchoolAddress;
                objSchooldetails.SchoolLogo = @"c:\Temp\SMS\" + Common.SchoolLogo;
                lstSchoolDetails = new ObservableCollection<ModelSchooldDetails>();
                lstSchoolDetails.Add(objSchooldetails);

            });
        }

        public Task SelectExpenseReport()
        {
            return Task.Run(() =>
            {
                lstModelExpenseDetails_RPT = new ObservableCollection<ModelExpenseDetails_RPT>();
                string sql = "[SMS].[ExpenseReport] " + this.Schoolid + ",'" + this.SelectedMonth.StaticID + "','" + this.SelectedAcademicYear.StaticName + "'";
                DataTable SearchResult = DAL.Select(sql);
                foreach (DataRow dr in SearchResult.Rows)
                {
                    Models.ModelExpenseDetails_RPT obj = new Models.ModelExpenseDetails_RPT();
                    obj.AcademicYear = dr["AcademicYear"].ToString();
                    obj.PaymentRecieved = dr["PaymentRecieved"].ToString();
                    obj.EntityName = dr["EntityName"].ToString();
                    obj.Month = dr["Month"].ToString();
                    lstModelExpenseDetails_RPT.Add(obj);


                }
                ModelSchooldDetails objSchooldetails = new ModelSchooldDetails();
                objSchooldetails.SchoolName = Common.SchoolName;
                objSchooldetails.SchoolAddress = Common.SchoolAddress;
                objSchooldetails.SchoolLogo = @"c:\Temp\SMS\" + Common.SchoolLogo;
                lstSchoolDetails = new ObservableCollection<ModelSchooldDetails>();
                lstSchoolDetails.Add(objSchooldetails);

            });
        }

    }
    public class ModelLetterDetails_RPT : ViewModels.BaseViewModel
    {
        private string _SrNo;
        public string SrNo
        {
            get { return _SrNo; }
            set
            {
                if (value != _SrNo)
                {
                    _SrNo = value;
                    RaisePropertyChanged(() => SrNo);
                }
            }
        }
        private string _RefNo;
        public string RefNo
        {
            get { return _RefNo; }
            set
            {
                if (value != _RefNo)
                {
                    _RefNo = value;
                    RaisePropertyChanged(() => RefNo);
                }
            }
        }
        private string _RecievedDate;
        public string RecievedDate
        {
            get { return _RecievedDate; }
            set
            {
                if (value != _RecievedDate)
                {
                    _RecievedDate = value;
                    RaisePropertyChanged(() => RecievedDate);
                }
            }
        }
        private string _Subject;
        public string Subject
        {
            get { return _Subject; }
            set
            {
                if (value != _Subject)
                {
                    _Subject = value;
                    RaisePropertyChanged(() => Subject);
                }
            }
        }
        private string _From;
        public string From
        {
            get { return _From; }
            set
            {
                if (value != _From)
                {
                    _From = value;
                    RaisePropertyChanged(() => From);
                }
            }
        }
        private string _To;
        public string To
        {
            get { return _To; }
            set
            {
                if (value != _To)
                {
                    _To = value;
                    RaisePropertyChanged(() => To);
                }
            }
        }
        private string _Comments;
        public string Comments
        {
            get { return _Comments; }
            set
            {
                if (value != _Comments)
                {
                    _Comments = value;
                    RaisePropertyChanged(() => Comments);
                }
            }
        }
        private string _CreatedDate;
        public string CreatedDate
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
        private string _CreatedTime;
        public string CreatedTime
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
        private string _LetterContent;
        public string LetterContent
        {
            get { return _LetterContent; }
            set
            {
                if (value != _LetterContent)
                {
                    _LetterContent = value;
                    RaisePropertyChanged(() => LetterContent);
                }
            }
        }

        private string _Createdby;
        public string Createdby
        {
            get { return _Createdby; }
            set
            {
                if (value != _Createdby)
                {
                    _Createdby = value;
                    RaisePropertyChanged(() => Createdby);
                }
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

    public class ModelPaymentReciept_RPT
    {

        public string StudentName { get; set; }
        public string EnrollmentNo { get; set; }
        public string AcademicYear { get; set; }
        public string PaymentType { get; set; }
        public string Amount { get; set; }
        public string ModeOfPayment { get; set; }
        public string CreatedDateTime { get; set; }
        public string Class { get; set; }
        public string RecieptID { get; set; }


    }
    public class ModelSchooldDetails
    {
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string SchoolLogo { get; set; }
    }
    public class ModelExpenseDetails_RPT
    {
        public string EntityID { get; set; }
        public string EntityName { get; set; }
        public string EntityType { get; set; }
        public string PaymentRecieved { get; set; }
        public string AcademicYear { get; set; }
        public string Month { get; set; }
        
    }
}
