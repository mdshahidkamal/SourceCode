using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Controls;
using System.Configuration;

namespace HospitalManagementSystem.ViewModels
{
    public class StudentDetailsViewModelEntity : BaseViewModel
    {
        private string _StudentID; public string StudentID { get { return _StudentID; } set { if (value != _StudentID) { _StudentID = value; RaisePropertyChanged(() => StudentID); } } }
        private string _EnrollmentNo; public string EnrollmentNo { get { return _EnrollmentNo; } set { if (value != _EnrollmentNo) { _EnrollmentNo = value; RaisePropertyChanged(() => EnrollmentNo); } } }
        private string _FirstName; public string FirstName { get { return _FirstName; } set { if (value != _FirstName) { _FirstName = value; RaisePropertyChanged(() => FirstName); } } }
        private string _MiddleName; public string MiddleName { get { return _MiddleName; } set { if (value != _MiddleName) { _MiddleName = value; RaisePropertyChanged(() => MiddleName); } } }
        private string _LastName; public string LastName { get { return _LastName; } set { if (value != _LastName) { _LastName = value; RaisePropertyChanged(() => LastName); } } }
        private string _Surname; public string Surname { get { return _Surname; } set { if (value != _Surname) { _Surname = value; RaisePropertyChanged(() => Surname); } } }
        private DateTime _DateOfBirth; public virtual DateTime DateOfBirth { get { return _DateOfBirth; } set { if (value != _DateOfBirth) { _DateOfBirth = value; RaisePropertyChanged(() => DateOfBirth); } } }
        private string _DateofBirthStr;
        public string DateofBirthStr
        {
            get { return _DateofBirthStr; }
            set
            {
                if (value != _DateofBirthStr)
                {
                    _DateofBirthStr = value;
                    RaisePropertyChanged(() => DateofBirthStr);
                }
            }
        }
        private string _DateofLeavingStr;
        public string DateofLeavingStr
        {
            get { return _DateofLeavingStr; }
            set
            {
                if (value != _DateofLeavingStr)
                {
                    _DateofLeavingStr = value;
                    RaisePropertyChanged(() => DateofLeavingStr);
                }
            }
        }


        private DateTime _DateOfAdmission; public virtual DateTime DateOfAdmission { get { return _DateOfAdmission; } set { if (value != _DateOfAdmission) { _DateOfAdmission = value; RaisePropertyChanged(() => DateOfAdmission); } } }
        private bool _GenderMale; public bool GenderMale { get { return _GenderMale; } set { if (value != _GenderMale) { _GenderMale = value; RaisePropertyChanged(() => GenderMale); } } }
        private bool _GenderFemale; public bool GenderFemale { get { return _GenderFemale; } set { if (value != _GenderFemale) { _GenderFemale = value; RaisePropertyChanged(() => GenderFemale); } } }
        private string _Gender; public string Gender { get { return _Gender; } set { if (value != _Gender) { _Gender = value; RaisePropertyChanged(() => Gender); } } }
        private string _Address; public string Address { get { return _Address; } set { if (value != _Address) { _Address = value; RaisePropertyChanged(() => Address); } } }
        private string _MobileNumber; public string MobileNumber { get { return _MobileNumber; } set { if (value != _MobileNumber) { _MobileNumber = value; RaisePropertyChanged(() => MobileNumber); } } }
        private string _EmergencyContactNo1; public string EmergencyContactNo1 { get { return _EmergencyContactNo1; } set { if (value != _EmergencyContactNo1) { _EmergencyContactNo1 = value; RaisePropertyChanged(() => EmergencyContactNo1); } } }
        private string _EmergencyContactNo2; public string EmergencyContactNo2 { get { return _EmergencyContactNo2; } set { if (value != _EmergencyContactNo2) { _EmergencyContactNo2 = value; RaisePropertyChanged(() => EmergencyContactNo2); } } }
        private string _MotherName; public string MotherName { get { return _MotherName; } set { if (value != _MotherName) { _MotherName = value; RaisePropertyChanged(() => MotherName); } } }
        private string _MotherOccupation; public string MotherOccupation { get { return _MotherOccupation; } set { if (value != _MotherOccupation) { _MotherOccupation = value; RaisePropertyChanged(() => MotherOccupation); } } }
        private string _FatherName; public string FatherName { get { return _FatherName; } set { if (value != _FatherName) { _FatherName = value; RaisePropertyChanged(() => FatherName); } } }
        private string _FatherOccupation; public string FatherOccupation { get { return _FatherOccupation; } set { if (value != _FatherOccupation) { _FatherOccupation = value; RaisePropertyChanged(() => FatherOccupation); } } }
        private string _EmailAddress; public string EmailAddress { get { return _EmailAddress; } set { if (value != _EmailAddress) { _EmailAddress = value; RaisePropertyChanged(() => EmailAddress); } } }
        private string _Nationality; public string Nationality { get { return _Nationality; } set { if (value != _Nationality) { _Nationality = value; RaisePropertyChanged(() => Nationality); } } }
        private string _Caste; public string Caste { get { return _Caste; } set { if (value != _Caste) { _Caste = value; RaisePropertyChanged(() => Caste); } } }
        private string _SubCaste; public string SubCaste { get { return _SubCaste; } set { if (value != _SubCaste) { _SubCaste = value; RaisePropertyChanged(() => SubCaste); } } }
        private DateTime _LeavingDate; public virtual DateTime LeavingDate { get { return _LeavingDate; } set { if (value != _LeavingDate) { _LeavingDate = value; RaisePropertyChanged(() => LeavingDate); } } }
        private string _PreviousSchool; public string PreviousSchool { get { return _PreviousSchool; } set { if (value != _PreviousSchool) { _PreviousSchool = value; RaisePropertyChanged(() => PreviousSchool); } } }
        private string _Picture; public string Picture { get { return _Picture; } set { if (value != _Picture) { _Picture = value; RaisePropertyChanged(() => Picture); } } }
        private string _IUDFlag; public string IUDFlag { get { return _IUDFlag; } set { if (value != _IUDFlag) { _IUDFlag = value; RaisePropertyChanged(() => IUDFlag); } } }
        private string _Age; public string Age { get { return _Age; } set { if (value != _Age) { _Age = value; RaisePropertyChanged(() => Age); } } }
        //private ObservableCollection<string> _lstFathersOccupation; public ObservableCollection<string> lstFathersOccupation { get { return _lstFathersOccupation; } set { if (value != _lstFathersOccupation) { _lstFathersOccupation = value; RaisePropertyChanged(() => lstFathersOccupation); } } }
        private ObservableCollection<StaticDataModel> _lstFathersOccupation;
        public ObservableCollection<StaticDataModel> lstFathersOccupation
        {
            get { return _lstFathersOccupation; }
            set
            {
                if (value != _lstFathersOccupation)
                {
                    _lstFathersOccupation = value;
                    RaisePropertyChanged(() => lstFathersOccupation);
                }
            }
        }
        private StaticDataModel _SelectedOccupationFather;
        public StaticDataModel SelectedOccupationFather
        {
            get { return _SelectedOccupationFather; }
            set
            {
                if (value != _SelectedOccupationFather)
                {
                    _SelectedOccupationFather = value;
                    RaisePropertyChanged(() => SelectedOccupationFather);
                }
            }
        }
        private ObservableCollection<StaticDataModel> _lstDocumentType;
        public ObservableCollection<StaticDataModel> lstDocumentType
        {
            get { return _lstDocumentType; }
            set
            {
                if (value != _lstDocumentType)
                {
                    _lstDocumentType = value;
                    RaisePropertyChanged(() => lstDocumentType);
                }
            }
        }


        private ObservableCollection<StaticDataModel> _lstMothersOccupation; public ObservableCollection<StaticDataModel> lstMothersOccupation { get { return _lstMothersOccupation; } set { if (value != _lstMothersOccupation) { _lstMothersOccupation = value; RaisePropertyChanged(() => lstMothersOccupation); } } }
        //private string _SelectedOccupationFather; public string SelectedOccupationFather { get { return _SelectedOccupationFather; } set { if (value != _SelectedOccupationFather) { _SelectedOccupationFather = value; RaisePropertyChanged(() => SelectedOccupationFather); } } }


        private StaticDataModel _SelectedOccupationMother; public StaticDataModel SelectedOccupationMother { get { return _SelectedOccupationMother; } set { if (value != _SelectedOccupationMother) { _SelectedOccupationMother = value; RaisePropertyChanged(() => SelectedOccupationMother); } } }
        //private ObservableCollection<string> _lstReligion; public ObservableCollection<string> lstReligion { get { return _lstReligion; } set { if (value != _lstReligion) { _lstReligion = value; RaisePropertyChanged(() => lstReligion); } } }
        private ObservableCollection<StaticDataModel> _lstReligion;
        public ObservableCollection<StaticDataModel> lstReligion
        {
            get { return _lstReligion; }
            set
            {
                if (value != _lstReligion)
                {
                    _lstReligion = value;
                    RaisePropertyChanged(() => lstReligion);
                }
            }
        }


        //private string _SelectedReligion; public string SelectedReligion { get { return _SelectedReligion; } set { if (value != _SelectedReligion) { _SelectedReligion = value; RaisePropertyChanged(() => SelectedReligion); } } }

        private StaticDataModel _SelectedReligion;
        public StaticDataModel SelectedReligion
        {
            get { return _SelectedReligion; }
            set
            {
                if (value != _SelectedReligion)
                {
                    _SelectedReligion = value;
                    RaisePropertyChanged(() => SelectedReligion);
                }
            }
        }

        private BitmapFrame _ImageSource; public BitmapFrame ImageSource { get { return _ImageSource; } set { if (value != _ImageSource) { _ImageSource = value; RaisePropertyChanged(() => ImageSource); } } }
        private string _PhotoID; public string PhotoID { get { return _PhotoID; } set { if (value != _PhotoID) { _PhotoID = value; RaisePropertyChanged(() => PhotoID); } } }

        private ObservableCollection<StaticDataModel> _lstClassRoom; public new ObservableCollection<StaticDataModel> lstClassRoom { get { return _lstClassRoom; } set { if (value != _lstClassRoom) { _lstClassRoom = value; RaisePropertyChanged(() => _lstClassRoom); } } }
        //private StaticDataModel _SelectedClassRoom; public override StaticDataModel SelectedClassRoom { get { return _SelectedClassRoom; } set { if (value != _SelectedClassRoom) { _SelectedClassRoom = value; RaisePropertyChanged(() => _SelectedClassRoom); } } }
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
        public DocumentViewModel objDocumentViewModel { get; set; }
        private ObservableCollection<DocumentViewModel> _lstDocuments;
        public ObservableCollection<DocumentViewModel> lstDocuments
        {
            get { return _lstDocuments; }
            set
            {
                if (value != _lstDocuments)
                {
                    _lstDocuments = value;
                    RaisePropertyChanged(() => lstDocuments);
                }
            }
        }


    }
    public class StudentDetailsViewModel : StudentDetailsViewModelEntity
    {
        public ICommand cmdsave { get { return new DelegateCommand(IUD, canSaveData); } }
        public ICommand cmdClearFormField { get { return new DelegateCommand(ClearFormField, canClearFormField); } }

        private bool canClearFormField()
        {
            return true;
        }

        public virtual void Search()
        {

        }
        public virtual void Search(int pk)
        {

        }

        public StudentDetailsViewModel()
        {

            LoadAsyncData();

        }
        void LoadAsyncData()
        {

            IUDFlag = "I";
            GetImageTempate();
            GetClassRoom();

            GetOccupation();
            GetReligion();
            GenerateEnrollMentNumber();
            GetDocumentTypes();

            this.DateOfBirth = DateTime.Now;
            this.DateOfAdmission = DateTime.Now;
            this.LeavingDate = new DateTime(1900, 01, 01);
        }
        public void GetDocumentTypes()
        {
            try
            {
                lstDocumentType = new ObservableCollection<StaticDataModel>();
                DataTable dt = Common.GetDocumentType();
                foreach (DataRow dr in dt.Rows)
                {
                    StaticDataModel obj = new StaticDataModel();
                    obj.StaticID = Convert.ToInt32(dr[0]);
                    obj.StaticName = dr[1].ToString();

                    lstDocumentType.Add(obj);
                }
                lstDocumentType.RemoveAt(0);
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }
        }
        void GenerateEnrollMentNumber()
        {
            try
            {
                string prefix = string.Empty;
                string Batch = string.Empty;
                string PrimaryKey = string.Empty;

                prefix = "IQ";
                Batch = DateTime.Now.Year.ToString();
                string sql = "select ISNULL(MAX(enrollmentid),0)+1 from sms.Students where SchoolID=" + this.Schoolid;
                int NextEnrollmentNo = DAL.ExecuteScalar(sql);
                PrimaryKey = NextEnrollmentNo.ToString().PadLeft(4, '0');
                if (string.IsNullOrEmpty(this.EnrollmentNo))
                {
                    this.EnrollmentNo = prefix + Batch + PrimaryKey;
                }
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }
        }
        void GetImageTempate()
        {
            try
            {
                string ImageTemplatePath = ConfigurationSettings.AppSettings["ImageTemplatePath"].ToString();
                StreamReader sr = new StreamReader(ImageTemplatePath);
                string str = sr.ReadToEnd();
                sr.Dispose();
                ImageConvertor objImageConvertor = new ImageConvertor();
                byte[] bytearr = Convert.FromBase64String(str);
                objImageConvertor.ConvertByteArrayToPhot(bytearr);
                this.ImageSource = objImageConvertor.ImageSource;
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }
        }
        void GetOccupation()
        {
            try
            {
                string sql = "exec sms.getstaticdata 0,'EmployementType'," + Schoolid;
                DataTable dt = DAL.Select(sql);
                lstFathersOccupation = new ObservableCollection<StaticDataModel>();
                lstMothersOccupation = new ObservableCollection<StaticDataModel>();
                foreach (DataRow dr in dt.Rows)
                {
                    StaticDataModel obj = new StaticDataModel();
                    obj.StaticID = int.Parse(dr[0].ToString());
                    obj.StaticName = dr[1].ToString();
                    lstFathersOccupation.Add(obj);
                    lstMothersOccupation.Add(obj);
                }
                SelectedOccupationFather = new StaticDataModel();
                SelectedOccupationMother = new StaticDataModel();
                SelectedOccupationFather = lstFathersOccupation.FirstOrDefault();
                SelectedOccupationMother = lstMothersOccupation.FirstOrDefault();
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }
        }

        public void GetReligion()
        {
            try
            {
                string sql = "exec sms.getstaticdata 0,'Religion'," + Schoolid;
                DataTable dt = DAL.Select(sql);
                lstReligion = new ObservableCollection<StaticDataModel>();
                foreach (DataRow dr in dt.Rows)
                {
                    StaticDataModel obj = new StaticDataModel();
                    obj.StaticID = int.Parse(dr[0].ToString());
                    obj.StaticName = dr[1].ToString();
                    lstReligion.Add(obj);
                }
                // lstReligion.RemoveAt(0);
                SelectedReligion = new StaticDataModel();
                SelectedReligion = lstReligion.First();
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }
            //SelectedReligion.StaticID = 7;
        }
        public new DataTable GetClassRoom()
        {
            DataTable dt = null;
            try
            {
                dt = Common.GetClassRoom();
                lstClassRoom = new ObservableCollection<StaticDataModel>();
                foreach (DataRow dr in dt.Rows)
                {
                    StaticDataModel obj = new StaticDataModel();
                    obj.StaticID = int.Parse(dr[0].ToString());
                    obj.StaticName = dr[1].ToString();
                    lstClassRoom.Add(obj);
                }

                SelectedClass = lstClassRoom.FirstOrDefault();
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }
            return dt;
        }
        public virtual void GetGender()
        {
            this.Gender = string.Empty;
            if (this.GenderMale)
                this.Gender = "Male";
            else if (this.GenderFemale)
                this.Gender = "Female";
        }
        public virtual void SetGender()
        {
            this.GenderFemale = false;
            this.GenderMale = false;
            if (this.Gender == "Male")
                this.GenderMale = true;
            else if (this.Gender == "Female")
                this.GenderFemale = true;
        }


        private bool canSaveData()
        {
            return true;
        }

        private void IUD()
        {
            ImageConvertor objImageConvertor = new ImageConvertor();
            GetGender();
            string sql = "exec [SMS].[IUDStudentDetails]";
            List<string> lst = new List<string>();
            this.Picture = string.Empty;
            lst.Add(IUDFlag);
            lst.Add(StudentID);
            lst.Add(EnrollmentNo);
            lst.Add(FirstName);
            lst.Add(MiddleName);
            lst.Add(LastName);
            lst.Add(Surname);
            lst.Add(DateOfBirth.ToString("yyyyMMdd"));
            lst.Add(DateOfAdmission.ToString("yyyyMMdd"));
            lst.Add(Gender);
            lst.Add(Address);
            lst.Add(MobileNumber);
            lst.Add(EmergencyContactNo1);
            lst.Add(EmergencyContactNo2);
            lst.Add(MotherName);
            lst.Add(SelectedOccupationMother.StaticID.ToString());
            lst.Add(FatherName);
            lst.Add(SelectedOccupationFather.StaticID.ToString());
            lst.Add(EmailAddress);
            lst.Add(Nationality);
            lst.Add(Caste);
            lst.Add(SelectedReligion.StaticID.ToString());
            lst.Add(LeavingDate.ToString("yyyyMMdd"));
            lst.Add(PreviousSchool);
            lst.Add(Picture);
            lst.Add(Age);
            lst.Add(PhotoID);
            lst.Add(Schoolid);
            DataTable dtResult = DAL.Select(sql, lst);
            if (dtResult != null && dtResult.Rows.Count > 0)
            {
                this.StudentID = dtResult.Rows[0][0].ToString();
                IUDStudentClassMapping();
                IUDDocumentMapping();
                MessageBox.Show("Data Saved Successfully");
                ClearFormField();
                GetStudentAsyn();
            }

        }
        void IUDStudentClassMapping()
        {

            List<string> lst = new List<string>();
            string sql = "exec [SMS].[IUDStudentClassMapping]";
            lst.Add(StudentID);
            lst.Add(Convert.ToString(SelectedClass.StaticID));
            lst.Add(Schoolid);
            lst.Add(Common.AcademicYearID);
            int dtResult = DAL.Execute(sql, lst);
        }
        void IUDDocumentMapping()
        {
            List<string> lst = new List<string>();
            string sql = "exec  SMS.DocumentMapping";
            lst.Add(Schoolid);
            lst.Add(this.EnrollmentNo);
            lst.Add(string.Empty);
            lst.Add("D");
            int dtResult = DAL.Execute(sql, lst);

            foreach (DocumentViewModel obj in lstDocuments)
            {
                lst = new List<string>();
                sql = "exec  SMS.DocumentMapping";
                lst.Add(Schoolid);
                lst.Add(this.EnrollmentNo);
                lst.Add(obj.FullFileName);
                lst.Add("I");
                dtResult = DAL.Execute(sql, lst);
            }




        }



        void ClearFormField()
        {
            IUDFlag = "I";
            StudentID = string.Empty;
            EnrollmentNo = string.Empty;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            Surname = string.Empty;
            DateOfBirth = DateTime.Now;
            DateOfAdmission = DateTime.Now;
            Gender = string.Empty;
            Address = string.Empty;
            MobileNumber = string.Empty;
            EmergencyContactNo1 = string.Empty;
            EmergencyContactNo2 = string.Empty;
            MotherName = string.Empty;
            SelectedOccupationMother = lstMothersOccupation.First();//new StaticDataModel() { StaticID = 0, StaticName = "--Selected--" };
            FatherName = string.Empty;
            SelectedOccupationFather = lstFathersOccupation.First(); //new StaticDataModel() { StaticID = 0, StaticName = "--Selected--" };
            EmailAddress = string.Empty;
            Nationality = string.Empty;
            Caste = string.Empty;
            SelectedReligion = lstReligion.First(); //new StaticDataModel() { StaticID = 0, StaticName = "--Select--" };
            PreviousSchool = string.Empty;
            GetImageTempate();
            Age = string.Empty;
            SelectedClass = lstClassRoom.First();// new StaticDataModel() { StaticID = 0, StaticName = "--Selected--" };
            GenerateEnrollMentNumber();
            lstDocuments.Clear();

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
        public new System.Data.DataTable GetStudents(string schoolid)
        {
            DataTable dt = null;

            lstStudentDetails = new ObservableCollection<StudentDetailsViewModelEntity>();
            dt = Common.GetStudents();
            foreach (DataRow dr in dt.Rows)
            {
                StudentDetailsViewModelEntity obj = new StudentDetailsViewModelEntity();
                obj.FirstName = dr[0].ToString();
                obj.StudentID = dr[1].ToString();
                obj.EnrollmentNo = dr[2].ToString();
                lstStudentDetails.Add(obj);
                objDocumentViewModel = new DocumentViewModel();
            }
            return dt;
        }
        public void GetStudentAsyn()
        {
            try
            {
                GetStudents(Schoolid);
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }

        }
        private DocumentModel _objDocumentModel;
        public DocumentModel objDocumentModel
        {
            get { return _objDocumentModel; }
            set
            {
                if (value != _objDocumentModel)
                {
                    _objDocumentModel = value;
                    RaisePropertyChanged(() => objDocumentModel);
                }
            }
        }


    }
    public class StudentSearchViewModel : StudentDetailsViewModel
    {
        public ICommand cmdSearch { get { return new DelegateCommand(Search, canSearch); } }
        public ICommand cmdAdvanceSearchPopUp { get { return new DelegateCommand(Search, canSearch); } }
        private DateTime _LeavingDate1; public DateTime LeavingDate1 { get { return _LeavingDate1; } set { if (value != _LeavingDate1) { _LeavingDate1 = value; RaisePropertyChanged(() => LeavingDate1); } } }
        private DateTime _DateOfBirth1; public DateTime DateOfBirth1 { get { return _DateOfBirth1; } set { if (value != _DateOfBirth1) { _DateOfBirth1 = value; RaisePropertyChanged(() => DateOfBirth1); } } }

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
        



        public StudentSearchViewModel()
        {
            //this.DateOfBirth = DateTime.Now;
            //this.DateOfAdmission = DateTime.Now;
            this.DateOfBirth1 = new DateTime(1900, 01, 01);
            this.LeavingDate1 = new DateTime(1900, 01, 01);
            LoadDataAsync();
            this.objDocumentModel = new DocumentModel();
        }
        void LoadDataAsync()
        {
            try
            {
                base.GetStudentAsyn();
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }
        }
        public StudentSearchViewModel(int primarykey)
        {
            //this.DateOfBirth = DateTime.Now;
            //this.DateOfAdmission = DateTime.Now;
            //this.DateOfBirth1 = new DateTime(1900, 01, 01);
            //this.LeavingDate1 = new DateTime(1900, 01, 01);
            try
            {
                Search(primarykey);

            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }
        }
        private bool canSearch()
        {
            return true;
        }

        public override void Search()
        {
            try
            {
                if (SelectedStudentNew != null)
                {
                    string studentid = SelectedStudentNew.StudentID;
                    int student_id = 0;
                    int.TryParse(studentid, out student_id);
                    Search(student_id);
                }
                else
                {
                    AdvanceSearch();
                }
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }

        }
        public override void Search(int primarykey)
        {
            ImageConvertor objImageConvertor = new ImageConvertor();
            string sql = "exec [SMS].[GetStudentDetails] '" + primarykey + "','" + EnrollmentNo + "','" + FirstName + "','" + MiddleName + "','" + LastName + "','" + DateOfBirth1.ToString("yyyyMMdd") + "','" + LeavingDate1.ToString("yyyyMMdd") + "','" + FatherName + "','" + MotherName + "'," + this.Schoolid;
            SearchResult = DAL.Select(sql);
            if (SearchResult == null || SearchResult.Rows.Count == 0)
            {
                return;
            }
            StudentDetailCollection = new ObservableCollection<StudentDetailsViewModelEntity>();

            foreach (DataRow dr in SearchResult.Rows)
            {
                this.IUDFlag = "U";
                this.StudentID = dr["StudentID"].ToString();
                this.EnrollmentNo = dr["EnrollmentNo"].ToString();
                this.FirstName = dr["FirstName"].ToString();
                this.MiddleName = dr["MiddleName"].ToString();
                this.LastName = dr["LastName"].ToString();
                this.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                this.DateOfAdmission = Convert.ToDateTime(dr["DateOfAdmission"]);
                this.Gender = dr["Gender"].ToString();
                SetGender();
                this.Address = dr["FullAddress"].ToString();
                this.MobileNumber = dr["MobileNumber"].ToString();
                this.EmergencyContactNo1 = dr["EmergencyContactNo1"].ToString();
                this.EmergencyContactNo2 = dr["EmergencyContactNo2"].ToString();
                this.MotherName = dr["MotherName"].ToString();
                this.FatherName = dr["FatherName"].ToString();
                int result = 0;
                int.TryParse(dr["MotherOccupation"].ToString(), out result);
                this.SelectedOccupationMother = lstMothersOccupation.First(x => x.StaticID == result);
                int.TryParse(dr["FatherOccupation"].ToString(), out result);
                this.SelectedOccupationFather = lstFathersOccupation.First(x => x.StaticID == result);
                this.EmailAddress = dr["EmailAddress"].ToString();
                this.Nationality = dr["Nationality"].ToString();
                int.TryParse(dr["Caste"].ToString(), out result);
                this.SelectedReligion = lstReligion.First(x => x.StaticID == result); //new StaticDataModel() { StaticID = result, StaticName = "Islam" }; //result;// int.Parse(dr["Caste"].ToString());
                this.Caste = dr["SubCaste"].ToString();
                this.LeavingDate = Convert.ToDateTime(dr["LeavingDate"]);
                this.Picture = dr["Picture"].ToString();
                this.PhotoID = dr["PhotoID"].ToString();
                this.PreviousSchool = dr["PreviousSchool"].ToString();
                if (!string.IsNullOrEmpty(this.PhotoID))
                {
                    if (File.Exists(this.PhotoID))
                    {
                        StreamReader sr = new StreamReader(this.PhotoID);
                        string photostring = sr.ReadToEnd();
                        sr.Close();
                        byte[] bytearr = Convert.FromBase64String(photostring);
                        objImageConvertor.ConvertByteArrayToPhot(bytearr);
                    }
                }
                this.ImageSource = objImageConvertor.ImageSource;
                this.Age = dr["Age"].ToString();
                int.TryParse(dr["ClassRoom"].ToString(), out result);
                this.SelectedClass = lstClassRoom.First(x => x.StaticID == result);// int.Parse(dr["ClassRoom"].ToString());
                StudentDetailCollection.Add(this);
                GetStudentDocuments();
            }

        }
        void GetStudentDocuments()
        {

            List<string> lst = new List<string>();
            string sql = "exec  SMS.DocumentMapping";
            lst.Add(Schoolid);
            lst.Add(this.EnrollmentNo);
            lst.Add(string.Empty);
            lst.Add("S");
            DataTable dt = DAL.Select(sql, lst);
            if (lstDocuments == null)
            {
                lstDocuments = new ObservableCollection<DocumentViewModel>();

            }
            lstDocuments.Clear();

            foreach (DataRow dr in dt.Rows)
            {
             
                DocumentViewModel obj = new DocumentViewModel();
                obj.FullFileName = dr["DocumentPath"].ToString();
                obj.Parameter = obj;
                obj.Command = new DelegateCommand(objDocumentModel.RemoveDocument);
                lstDocuments.Add(obj);
            }
        }
       

        public void AdvanceSearch()
        {
            ImageConvertor objImageConvertor = new ImageConvertor();
            string sql = "exec [SMS].[GetStudentDetails] '" + 0 + "','" + EnrollmentNo + "','" + FirstName + "','" + MiddleName + "','" + LastName + "','" + DateOfBirth1.ToString("yyyyMMdd") + "','" + LeavingDate1.ToString("yyyyMMdd") + "','" + FatherName + "','" + MotherName + "'," + this.Schoolid;
            SearchResult = DAL.Select(sql);
            if (SearchResult == null || SearchResult.Rows.Count == 0)
            {
                return;
            }
            StudentDetailCollection = new ObservableCollection<StudentDetailsViewModelEntity>();

            foreach (DataRow dr in SearchResult.Rows)
            {
                StudentDetailsViewModelEntity obj = new StudentDetailsViewModelEntity();
                obj.IUDFlag = "U";
                obj.StudentID = dr["StudentID"].ToString();
                obj.EnrollmentNo = dr["EnrollmentNo"].ToString();
                obj.FirstName = dr["FirstName"].ToString();
                obj.MiddleName = dr["MiddleName"].ToString();
                obj.LastName = dr["LastName"].ToString();
                obj.DateofBirthStr = dr["DateOfBirth"].ToString();
                obj.DateOfAdmission = Convert.ToDateTime(dr["DateOfAdmission"]);
                obj.Gender = dr["Gender"].ToString();
                SetGender();
                obj.Address = dr["FullAddress"].ToString();
                obj.MobileNumber = dr["MobileNumber"].ToString();
                obj.EmergencyContactNo1 = dr["EmergencyContactNo1"].ToString();
                obj.EmergencyContactNo2 = dr["EmergencyContactNo2"].ToString();
                obj.MotherName = dr["MotherName"].ToString();
                obj.FatherName = dr["FatherName"].ToString();
                int result = 0;
                int.TryParse(dr["MotherOccupation"].ToString(), out result);
                obj.SelectedOccupationMother = lstMothersOccupation.First(x => x.StaticID == result);
                int.TryParse(dr["FatherOccupation"].ToString(), out result);
                obj.SelectedOccupationFather = lstFathersOccupation.First(x => x.StaticID == result);
                obj.EmailAddress = dr["EmailAddress"].ToString();
                obj.Nationality = dr["Nationality"].ToString();
                int.TryParse(dr["Caste"].ToString(), out result);
                obj.SelectedReligion = lstReligion.First(x => x.StaticID == result); //new StaticDataModel() { StaticID = result, StaticName = "Islam" }; //result;// int.Parse(dr["Caste"].ToString());
                obj.Caste = dr["SubCaste"].ToString();
                obj.DateofLeavingStr = dr["LeavingDate"].ToString();
                obj.Picture = dr["Picture"].ToString();
                obj.PhotoID = dr["PhotoID"].ToString();
                obj.PreviousSchool = dr["PreviousSchool"].ToString();
                if (!string.IsNullOrEmpty(obj.PhotoID))
                {
                    if (File.Exists(obj.PhotoID))
                    {
                        StreamReader sr = new StreamReader(obj.PhotoID);
                        string photostring = sr.ReadToEnd();
                        sr.Close();
                        byte[] bytearr = Convert.FromBase64String(photostring);
                        objImageConvertor.ConvertByteArrayToPhot(bytearr);
                    }
                }
                obj.ImageSource = objImageConvertor.ImageSource;
                obj.Age = dr["Age"].ToString();
                int.TryParse(dr["ClassRoom"].ToString(), out result);
                obj.SelectedClass = lstClassRoom.First(x => x.StaticID == result);// int.Parse(dr["ClassRoom"].ToString());
                StudentDetailCollection.Add(obj);
            }

        }


        /// <summary STUDENT SEARCH AUTOCOMPLETE CODE>
        #region Studen Search AutoComplete



        public AutoCompleteFilterPredicate<object> StudentFilter
        {
            get
            {
                return (searchText, obj) =>
                    (obj as StudentDetailsViewModelEntity).FirstName.ToUpper().Contains(searchText)
                    || (obj as StudentDetailsViewModelEntity).EnrollmentNo.ToUpper().Contains(searchText);
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


        #endregion
        /// </summary>
    }

}
