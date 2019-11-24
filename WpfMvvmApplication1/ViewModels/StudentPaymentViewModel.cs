using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Views;
using System.IO;

namespace HospitalManagementSystem.ViewModels
{
    public class StudentPaymentViewModelEntity : BaseViewModel
    {
        private string _ID; public string ID { get { return _ID; } set { if (value != _ID) { _ID = value; RaisePropertyChanged(() => ID); } } }
        private string _EntityID; public string EntityID { get { return _EntityID; } set { if (value != _EntityID) { _EntityID = value; RaisePropertyChanged(() => EntityID); } } }
        private string _EntityType; public string EntityType { get { return _EntityType; } set { if (value != _EntityType) { _EntityType = value; RaisePropertyChanged(() => EntityType); } } }
        private string _PaymentType; public string PaymentType { get { return _PaymentType; } set { if (value != _PaymentType) { _PaymentType = value; RaisePropertyChanged(() => PaymentType); } } }
        private string _TransType; public string TransType { get { return _TransType; } set { if (value != _TransType) { _TransType = value; RaisePropertyChanged(() => TransType); } } }
        private string _Month; public string Month { get { return _Month; } set { if (value != _Month) { _Month = value; RaisePropertyChanged(() => Month); } } }
        private string _Amount; public string Amount { get { return _Amount; } set { if (value != _Amount) { _Amount = value; RaisePropertyChanged(() => Amount); } } }
        private string _Comments; public string Comments { get { return _Comments; } set { if (value != _Comments) { _Comments = value; RaisePropertyChanged(() => Comments); } } }
        private string _CreatedDate; public string CreatedDate { get { return _CreatedDate; } set { if (value != _CreatedDate) { _CreatedDate = value; RaisePropertyChanged(() => CreatedDate); } } }
        private string _IUDFlag; public string IUDFlag { get { return _IUDFlag; } set { if (value != _IUDFlag) { _IUDFlag = value; RaisePropertyChanged(() => IUDFlag); } } }


        private string _ModeofPayment; public string ModeofPayment { get { return _ModeofPayment; } set { if (value != _ModeofPayment) { _ModeofPayment = value; RaisePropertyChanged(() => ModeofPayment); } } }
        private string _ChequeNo; public string ChequeNo { get { return _ChequeNo; } set { if (value != _ChequeNo) { _ChequeNo = value; RaisePropertyChanged(() => ChequeNo); } } }
        private string _BankBranchDetails; public string BankBranchDetails { get { return _BankBranchDetails; } set { if (value != _BankBranchDetails) { _BankBranchDetails = value; RaisePropertyChanged(() => BankBranchDetails); } } }


        private bool _Cash; public bool Cash { get { return _Cash; } set { if (value != _Cash) { _Cash = value; RaisePropertyChanged(() => Cash); } } }
        private bool _Cheque; public bool Cheque { get { return _Cheque; } set { if (value != _Cheque) { _Cheque = value; RaisePropertyChanged(() => Cheque); } } }


        private bool _PrintingChecked;
        public bool PrintingChecked
        {
            get { return _PrintingChecked; }
            set
            {
                if (value != _PrintingChecked)
                {
                    _PrintingChecked = value;
                    RaisePropertyChanged(() => PrintingChecked);
                }
            }
        }


        private StudentDetailsViewModelEntity _SelectedStudentNew;
        public StudentDetailsViewModelEntity SelectedStudentNew
        {
            get { return _SelectedStudentNew; }
            set
            {
                if (value != _SelectedStudentNew)
                {
                    _SelectedStudentNew = value;
                    RaisePropertyChanged(() => SelectedStudentNew);
                }
            }
        }
        private string _FullName;
        public string FullName
        {
            get { return _FullName; }
            set
            {
                if (value != _FullName)
                {
                    _FullName = value;
                    RaisePropertyChanged(() => FullName);
                }
            }
        }
        private string _EnrollmentNo;
        public string EnrollmentNo
        {
            get { return _EnrollmentNo; }
            set
            {
                if (value != _EnrollmentNo)
                {
                    _EnrollmentNo = value;
                    RaisePropertyChanged(() => EnrollmentNo);
                }
            }
        }
        private string _ClassRoom;
        public string ClassRoom
        {
            get { return _ClassRoom; }
            set
            {
                if (value != _ClassRoom)
                {
                    _ClassRoom = value;
                    RaisePropertyChanged(() => ClassRoom);
                }
            }
        }



        private ObservableCollection<StudentPaymentViewModelEntity> _lstStudentPaymentDetails;
        public ObservableCollection<StudentPaymentViewModelEntity> lstStudentPaymentDetails
        {
            get { return _lstStudentPaymentDetails; }
            set
            {
                if (value != _lstStudentPaymentDetails)
                {
                    _lstStudentPaymentDetails = value;
                    RaisePropertyChanged(() => lstStudentPaymentDetails);
                }
            }
        }
        private string _CreatedDateTime;
        public string CreatedDateTime
        {
            get { return _CreatedDateTime; }
            set
            {
                if (value != _CreatedDateTime)
                {
                    _CreatedDateTime = value;
                    RaisePropertyChanged(() => CreatedDateTime);
                }
            }
        }
        private string _AcademicYear;
        public string AcademicYear
        {
            get { return _AcademicYear; }
            set
            {
                if (value != _AcademicYear)
                {
                    _AcademicYear = value;
                    RaisePropertyChanged(() => AcademicYear);
                }
            }
        }

        private ObservableCollection<StudentDetailsViewModelEntity> _StudentDetailCollection;
        public ObservableCollection<StudentDetailsViewModelEntity> StudentDetailCollection
        {
            get { return _StudentDetailCollection; }
            set
            {
                if (value != _StudentDetailCollection)
                {
                    _StudentDetailCollection = value;
                    RaisePropertyChanged(() => StudentDetailCollection);
                }
            }
        }

        private ObservableCollection<StaticDataModel> _lstFeesType;
        public ObservableCollection<StaticDataModel> lstFeesType
        {
            get { return _lstFeesType; }
            set
            {
                if (value != _lstFeesType)
                {
                    _lstFeesType = value;
                    RaisePropertyChanged(() => lstFeesType);
                }
            }
        }

        private StaticDataModel _SelectedFees;
        public StaticDataModel SelectedFees
        {
            get { return _SelectedFees; }
            set
            {
                if (value != _SelectedFees)
                {
                    _SelectedFees = value;
                    RaisePropertyChanged(() => SelectedFees);
                }
            }
        }

        private int _selectedindex;
        public int selectedindex
        {
            get { return _selectedindex; }
            set
            {
                if (value != _selectedindex)
                {
                    _selectedindex = value;
                    RaisePropertyChanged(() => selectedindex);
                }
            }
        }
        private ObservableCollection<MonthModel> _lstMonths;
        public ObservableCollection<MonthModel> lstMonths
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
        private MonthModel _SelectedMonth;
        public MonthModel SelectedMonth
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

        private DateTime _PaymentExpenseDate;
        public DateTime PaymentExpenseDate
        {
            get { return _PaymentExpenseDate; }
            set
            {
                if (value != _PaymentExpenseDate)
                {
                    _PaymentExpenseDate = value;
                    RaisePropertyChanged(() => PaymentExpenseDate);
                }
            }
        }





    }
    public class MonthModel
    {
        public string Month { get; set; }

    }

    public class StudentPaymentViewModel : StudentPaymentViewModelEntity
    {


        void GetFeesMonth()
        {
            lstMonths = new ObservableCollection<MonthModel>();
            string[] names = DateTimeFormatInfo.CurrentInfo.MonthNames;
            foreach (string name in names)
            {
                MonthModel obj = new MonthModel();
                obj.Month = name;
                lstMonths.Add(obj);
            }


        }


        public StudentPaymentViewModel()
        {
            GetStudents("");
            GetFeesMonth();
            GetStaticData("Fees");
            AcademicYear = Common.AcademicYear;

        }
        public override DataTable GetStaticData(string StaticType)
        {
            lstFeesType = new ObservableCollection<StaticDataModel>();
            DataTable dt = base.GetStaticData(StaticType);

            foreach (DataRow dr in dt.Rows)
            {
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID = Convert.ToInt32(dr[0]);
                obj.StaticName = dr[1].ToString();

                lstFeesType.Add(obj);
            }
            lstFeesType.RemoveAt(0);
            SelectedFees = new StaticDataModel();
            SelectedFees = lstFeesType.FirstOrDefault();
            SelectedFees.StaticID = 0;
            //selectedindex = 0;
            return dt;
        }

        public ICommand cmdsave { get { return new DelegateCommand(IUD, canSaveData); } }
        public ICommand cmdGetStudentDetails { get { return new DelegateCommand(GetStudentDetails, canGetStudentDetails); } }

        private bool canGetStudentDetails()
        {
            return true;
        }
        private DataTable _SearchResult;
        public DataTable SearchResult
        {
            get { return _SearchResult; }
            set
            {
                if (value != _SearchResult)
                {
                    _SearchResult = value;
                    RaisePropertyChanged(() => SearchResult);
                }
            }
        }

        private BitmapFrame _ImageSource; public BitmapFrame ImageSource { get { return _ImageSource; } set { if (value != _ImageSource) { _ImageSource = value; RaisePropertyChanged(() => ImageSource); } } }

        void FormFields()
        {

            this.Amount = string.Empty;
            this.Comments = string.Empty;
            this.SelectedFees = lstFeesType.First();
            this.Cash = false;
            this.Cheque = false;
            this.BankBranchDetails = string.Empty;
            this.ChequeNo = string.Empty;

        }
        private void GetStudentDetails()
        {
            ImageConvertor objImageConvertor = new ImageConvertor();
            if (SelectedStudentNew == null)
            { return; }
            string studentid = SelectedStudentNew.StudentID;
            int student_id = 0;
            int.TryParse(studentid, out student_id);
            string sql = "exec [SMS].[GetStudentPaymentDetails] '" + this.ID + "'," + student_id + "," + this.Schoolid;
            SearchResult = DAL.Select(sql);
            if (SearchResult != null && SearchResult.Rows.Count > 0)
            {
                string PhotoID = SearchResult.Rows[0]["PhotoID"].ToString();
                if (!string.IsNullOrEmpty(PhotoID))
                {
                    if (File.Exists(PhotoID))
                    {
                        StreamReader sr = new StreamReader(PhotoID);
                        string photostring = sr.ReadToEnd();
                        sr.Close();
                        byte[] bytearr = Convert.FromBase64String(photostring);
                        objImageConvertor.ConvertByteArrayToPhot(bytearr);
                    }
                }
                this.ImageSource = objImageConvertor.ImageSource;
                this.FullName = SearchResult.Rows[0]["FullName"].ToString();
                this.EnrollmentNo = SearchResult.Rows[0]["EnrollmentNo"].ToString();
                this.ClassRoom = SearchResult.Rows[0]["Class"].ToString();
                FormFields();
                lstStudentPaymentDetails = new ObservableCollection<StudentPaymentViewModelEntity>();

                foreach (DataRow dr in SearchResult.Rows)
                {
                    StudentPaymentViewModelEntity obj = new StudentPaymentViewModelEntity();
                    obj.ID = dr["ID"].ToString();
                    obj.EntityID = dr["EntityID"].ToString();
                    obj.EntityType = dr["EntityType"].ToString();
                    obj.PaymentType = dr["PaymentType"].ToString();
                    obj.TransType = dr["TransType"].ToString();
                    obj.Amount = dr["Amount"].ToString();
                    obj.Comments = dr["Comments"].ToString();
                    obj.FullName = dr["FullName"].ToString();
                    obj.EnrollmentNo = dr["EnrollmentNo"].ToString();
                    obj.CreatedDateTime = dr["CreatedDateTime"].ToString();
                    obj.AcademicYear = dr["AcademicYear"].ToString();
                    obj.ModeofPayment = dr["ModeofPayment"].ToString();
                    //obj.ChequeNo = dr["chequeno"].ToString();
                    //obj.BankBranchDetails = dr["BankBranchDetails"].ToString();
                    lstStudentPaymentDetails.Add(obj);
                }


            }
        }

        private bool canSaveData()
        {
            bool flag = true;
            var query = from contact in lstFeesType.AsEnumerable()
                                                     where contact.IsCheckControl==true
                                                     select contact;
            if (query.Count()<=0)
            {
                flag = false;
            }
            if (this.Cheque==false && this.Cash==false)
            {
                flag = false;
            }

            if (this.Cheque)
            {
                if ((this.ChequeNo.Length <= 0) || this.BankBranchDetails.Length <= 0)
                {
                    flag = false;
                }
            }
            return flag;
        }

        string GetFeesType()
        {
            string feestype = string.Empty;
            foreach (StaticDataModel obj in lstFeesType)
            {
                if (obj.IsCheckControl)
                    feestype += obj.StaticName + ",";
            }
            return feestype;
        }
        private void IUD()
        {

            string sql = "exec [SMS].[IUDPaymentDetails]";
            List<string> lst = new List<string>();
            this.EntityID = SelectedStudentNew.StudentID;
            this.EntityType = "Student";
            this.PaymentType = GetFeesType().TrimEnd(',');
            //SelectedFees.StaticID.ToString();
            this.TransType = "C";
            if (this.Cash)
                this.ModeofPayment = "Cash";
            if (this.Cheque)
                this.ModeofPayment = "Cheque";
            lst.Add(ID);
            lst.Add(EntityID);
            lst.Add(EntityType);
            lst.Add(PaymentType);
            lst.Add(TransType);
            lst.Add(Amount);
            lst.Add(Comments);
            lst.Add(IUDFlag);
            lst.Add(Schoolid);
            lst.Add(AcademicYear);
            lst.Add(ModeofPayment);
            lst.Add(ChequeNo);
            lst.Add(BankBranchDetails);
            lst.Add(DateTime.Now.ToString("yyyy-MM-dd"));
            lst.Add(this.ClassRoom);

            DataTable dtResult = DAL.Select(sql, lst);
            GetStudentDetails();
            //GeneratePaymentReciept();
        }
        private ObservableCollection<StudentDetailsViewModelEntity> _lstStudentDetails;
        public ObservableCollection<StudentDetailsViewModelEntity> lstStudentDetails
        {
            get { return _lstStudentDetails; }
            set
            {
                if (value != _lstStudentDetails)
                {
                    _lstStudentDetails = value;
                    RaisePropertyChanged(() => lstStudentDetails);
                }
            }
        }

        public System.Data.DataTable GetStudents(string schoolid)
        {
            lstStudentDetails = new ObservableCollection<StudentDetailsViewModelEntity>();
            DataTable dt = Common.GetStudents();
            foreach (DataRow dr in dt.Rows)
            {
                StudentDetailsViewModelEntity obj = new StudentDetailsViewModelEntity();
                obj.FirstName = dr[0].ToString();
                obj.StudentID = dr[1].ToString();
                obj.EnrollmentNo = dr[2].ToString();
                lstStudentDetails.Add(obj);
            }
            return dt;
        }
        public AutoCompleteFilterPredicate<object> StudentFilter
        {
            get
            {
                return (searchText, obj) =>
                    (obj as StudentDetailsViewModelEntity).FirstName.ToUpper().Contains(searchText)
                    || (obj as StudentDetailsViewModelEntity).EnrollmentNo.ToUpper().Contains(searchText);
            }
        }
        public ICommand cmdGeneratePaymentReciept { get { return new DelegateCommand(GeneratePaymentReciept, canGeneratePaymentReciept); } }

        private bool canGeneratePaymentReciept()
        {
            if (lstStudentPaymentDetails != null)
            {
                StudentPaymentViewModelEntity obj = lstStudentPaymentDetails.FirstOrDefault(x => x.PrintingChecked == true);

                if (obj != null)
                    return true;
            }
            return false;
        }

        private void GeneratePaymentReciept()
        {

            //ShowDialog(viewModel => dialogService.ShowDialog<ReportsHostingForm>(this, viewModel));
        }

        //public StudentPaymentViewModel()
        //{
        //    GetStudents("");
        //    GetFeesMonth();
        //    GetStaticData("Fees");
        //    AcademicYear = DateTime.Now.Year + "-" + (DateTime.Now.Year + 1);
        //}
        private void ExplicitShowDialog()
        {

        }

        private void ShowDialog(Func<ViewModelPatientDetails_RPT, bool?> showDialog)
        {
            var dialogViewModel = new ViewModelPatientDetails_RPT();
            int result = 0;
            int.TryParse(this.Schoolid, out result);
            dialogViewModel.schoolid = result;
            int.TryParse(SelectedStudentNew.StudentID, out result);
            dialogViewModel.studentId = result;
            dialogViewModel.SelectPaymentReport();
            bool? success = showDialog(dialogViewModel);
            if (success == true)
            {

            }
        }


    }
}
