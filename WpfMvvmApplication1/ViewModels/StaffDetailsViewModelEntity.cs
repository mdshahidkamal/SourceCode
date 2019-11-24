using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace HospitalManagementSystem.ViewModels
{
    public class StaffDetailsViewModelEntity : BaseViewModel
    {
        private string _StaffID; public string StaffID { get { return _StaffID; } set { if (value != _StaffID) { _StaffID = value; RaisePropertyChanged(() => StaffID); } } }
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value != _Name)
                {
                    _Name = value; RaisePropertyChanged(() => Name);
                    GenerateUserid();

                }
            }
        }
        private string _EmailAddress; public string EmailAddress { get { return _EmailAddress; } set { if (value != _EmailAddress) { _EmailAddress = value; RaisePropertyChanged(() => EmailAddress); } } }
        private string _UserID; public string UserID { get { return _UserID; } set { if (value != _UserID) { _UserID = value; RaisePropertyChanged(() => UserID); } } }
        private string _Password; public string Password { get { return _Password; } set { if (value != _Password) { _Password = value; RaisePropertyChanged(() => Password); } } }
        private string _ContactNumber; public string ContactNumber { get { return _ContactNumber; } set { if (value != _ContactNumber) { _ContactNumber = value; RaisePropertyChanged(() => ContactNumber); } } }
        private string _Address; public string Address { get { return _Address; } set { if (value != _Address) { _Address = value; RaisePropertyChanged(() => Address); } } }
        private string _Designation; public string Designation { get { return _Designation; } set { if (value != _Designation) { _Designation = value; RaisePropertyChanged(() => Designation); } } }
        private string _Subjects; public string Subjects { get { return _Subjects; } set { if (value != _Subjects) { _Subjects = value; RaisePropertyChanged(() => Subjects); } } }
        private DateTime _DateOfBirth; public DateTime DateOfBirth { get { return _DateOfBirth; } set { if (value != _DateOfBirth) { _DateOfBirth = value; RaisePropertyChanged(() => DateOfBirth); } } }
        private DateTime _DateOfJoining; public DateTime DateOfJoining { get { return _DateOfJoining; } set { if (value != _DateOfJoining) { _DateOfJoining = value; RaisePropertyChanged(() => DateOfJoining); } } }
        private DateTime _DateofLeaving; public DateTime DateofLeaving { get { return _DateofLeaving; } set { if (value != _DateofLeaving) { _DateofLeaving = value; RaisePropertyChanged(() => DateofLeaving); } } }
        private string _Gender; public string Gender { get { return _Gender; } set { if (value != _Gender) { _Gender = value; RaisePropertyChanged(() => Gender); } } }
        private bool _GenderMale; public bool GenderMale { get { return _GenderMale; } set { if (value != _GenderMale) { _GenderMale = value; RaisePropertyChanged(() => GenderMale); } } }
        private bool _GenderFemale; public bool GenderFemale { get { return _GenderFemale; } set { if (value != _GenderFemale) { _GenderFemale = value; RaisePropertyChanged(() => GenderFemale); } } }

        private string _IUDFlag; public string IUDFlag { get { return _IUDFlag; } set { if (value != _IUDFlag) { _IUDFlag = value; RaisePropertyChanged(() => IUDFlag); } } }
        private string _StaticData; public string StaticData { get { return _StaticData; } set { if (value != _StaticData) { _StaticData = value; RaisePropertyChanged(() => StaticData); } } }
        private ObservableCollection<string> _lstDesignation; public ObservableCollection<string> lstDesignation { get { return _lstDesignation; } set { if (value != _lstDesignation) { _lstDesignation = value; RaisePropertyChanged(() => lstDesignation); } } }
        private string _SelectedDesignation; public string SelectedDesignation { get { return _SelectedDesignation; } set { if (value != _SelectedDesignation) { _SelectedDesignation = value; RaisePropertyChanged(() => SelectedDesignation); } } }
        private BitmapFrame _ImageSource; public BitmapFrame ImageSource { get { return _ImageSource; } set { if (value != _ImageSource) { _ImageSource = value; RaisePropertyChanged(() => ImageSource); } } }
        private string _PhotoID; public string PhotoID { get { return _PhotoID; } set { if (value != _PhotoID) { _PhotoID = value; RaisePropertyChanged(() => PhotoID); } } }
        private DateTime _LeavingDate1; public DateTime LeavingDate1 { get { return _LeavingDate1; } set { if (value != _LeavingDate1) { _LeavingDate1 = value; RaisePropertyChanged(() => LeavingDate1); } } }
        private DateTime _DateOfBirth1; public DateTime DateOfBirth1 { get { return _DateOfBirth1; } set { if (value != _DateOfBirth1) { _DateOfBirth1 = value; RaisePropertyChanged(() => DateOfBirth1); } } }
        private string _Picture; public string Picture { get { return _Picture; } set { if (value != _Picture) { _Picture = value; RaisePropertyChanged(() => Picture); } } }
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
        public static char GetLetter()
        {
            // This method returns a random lowercase letter.
            // ... Between 'a' and 'z' inclusize.
            Random _random = new Random();
            int num = _random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let;
        }

        void GenerateUserid()
        {
            if (string.IsNullOrEmpty(this.UserID))
            {
                string name = this.Name;
                string[] arrName = name.Split(' ');
                //arrName=arrName.OrderBy(aux => aux.Length).ToArray(); ;
                //            Array.Sort(arrName, (x, y) => x.Length.CompareTo(y.Length));
                var sortedWords = from w in arrName orderby w.Length descending select w;

                string userid = string.Empty;
                foreach (string n in sortedWords)
                {
                    if (n.Length > 4)
                    {
                        userid += n.Substring(0, 4);
                    }
                    else
                    {
                        userid += n;
                    }
                }
                if (userid.Length >= 8)
                {

                    userid = userid.Substring(0, 8);
                }
                else
                {
                    char[] arr = new char[8];
                    char[] arr1 = userid.ToCharArray();

                    for (int x = 0; x < 8; x++)
                    {
                        if (x < arr1.Length)
                        {
                            arr[x] = arr1[x];
                        }
                        else
                        {
                            arr[x] = GetLetter();
                        }
                    }
                    userid = new string(arr); ;

                }
                this.UserID = userid.ToUpper();
            }
        }
        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        protected void SetPassWord()
        {
            if (string.IsNullOrEmpty(this.Password))
            {
                this.Password = RandomString(8).ToUpper();
            }
        }

    }
    public class StaffDetailsViewModel : StaffDetailsViewModelEntity
    {
        public ICommand cmdsave { get { return new DelegateCommand(IUD, canSaveData); } }

        private void IUD()
        {
            ImageConvertor objImageConvertor = new ImageConvertor();
            GetGender();
            string sql = "exec [SMS].[IUDStaffDetails]";
            List<string> lst = new List<string>();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("StaffID", StaffID);
            dict.Add("Name", Name);
            dict.Add("EmailAddress", EmailAddress);
            dict.Add("UserID", UserID);
            SetPassWord();
            dict.Add("Password", this.Password);
            dict.Add("ContactNumber", ContactNumber);
            dict.Add("Address", Address);
            dict.Add("Designation", Designation);
            dict.Add("Subjects", Subjects);
            dict.Add("DateOfJoining", DateOfJoining.ToString("yyyyMMdd"));
            dict.Add("DateofLeaving", DateofLeaving.ToString("yyyyMMdd"));
            dict.Add("DateOfBirth", string.Empty);
            dict.Add("Gender", Gender);
            dict.Add("Picture", Picture);
            dict.Add("PhotoID", PhotoID);
            dict.Add("IUDFlag", IUDFlag);
            dict.Add("SchoolID", Schoolid);

            int result = DAL.Execute(sql, dict);

            sql = "exec [dbo].[IUDdboUsers] ";
            lst = new List<string>();
            dict = new Dictionary<string, string>();
            dict.Add("Name", Name);
            dict.Add("UserID", UserID);
            dict.Add("Password", this.Password);
            dict.Add("IUDFlag", IUDFlag);
            result += DAL.Execute(sql, dict);


            if (result > 1)
            {
                MessageBox.Show("Data Saved Successfully");
                ClearFormField();
            }
        }

        private void ClearFormField()
        {
            Name = string.Empty;
            EmailAddress = string.Empty;
            UserID = string.Empty;
            Password = string.Empty;
            ContactNumber = string.Empty;
            Address = string.Empty;
            Designation = string.Empty;
            Subjects = string.Empty;
            DateOfJoining = DateTime.Now;
            DateofLeaving = new DateTime(1900, 01, 01);
            DateOfBirth = DateTime.Now;
            Gender = string.Empty;
            GenderMale = false;
            GenderFemale = false;
            GetImageTempate();
            PhotoID = string.Empty;
            IUDFlag = "I";
            StaticData = string.Empty;
            Picture = string.Empty;

        }

        private bool canSaveData()
        {
            return true;
        }
        public virtual void Search()
        {

        }
        public virtual void Search(int pk)
        {

        }
        public StaffDetailsViewModel()
        {
            IUDFlag = "I";
            this.DateOfJoining = DateTime.Now;
            this.DateofLeaving = new DateTime(1900, 01, 01);
            GetImageTempate();
        }
        void GetImageTempate()
        {
            StreamReader sr = new StreamReader("Template.img");
            string str = sr.ReadToEnd();
            sr.Dispose();
            ImageConvertor objImageConvertor = new ImageConvertor();
            byte[] bytearr = Convert.FromBase64String(str);
            objImageConvertor.ConvertByteArrayToPhot(bytearr);
            this.ImageSource = objImageConvertor.ImageSource;
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

    }
    public class StaffDetailSearchViewModel : StaffDetailsViewModel
    {
        public StaffDetailSearchViewModel()
        {

        }
        public StaffDetailSearchViewModel(int primarykey)
        {
            Search(primarykey);
        }
        public ICommand cmdSearch { get { return new DelegateCommand(Search, canSearch); } }

        private bool canSearch()
        {
            return true;
        }
        private ObservableCollection<StaffDetailsViewModelEntity> _StaffDetailCollection;
        public ObservableCollection<StaffDetailsViewModelEntity> StaffDetailCollection
        {
            get { return _StaffDetailCollection; }
            set
            {
                if (value != _StaffDetailCollection)
                {
                    _StaffDetailCollection = value;
                    RaisePropertyChanged(() => StaffDetailCollection);
                }
            }
        }
        public override void Search()
        {
            string sql = "exec [SMS].[GetStaffDetails] '" + StaffID + "','" + Name + "','" + EmailAddress + "'," + this.Schoolid;
            ImageConvertor objImageConvertor = new ImageConvertor();
            SearchResult = DAL.Select(sql);
            StaffDetailsViewModelEntity obj = null;
            StaffDetailCollection = new ObservableCollection<StaffDetailsViewModelEntity>();
            if (SearchResult != null && SearchResult.Rows.Count > 0)
            {

                foreach (DataRow dr in SearchResult.Rows)
                {
                    obj = new StaffDetailsViewModelEntity()
                    {
                        StaffID = dr["StaffID"].ToString(),
                        Name = dr["Name"].ToString(),
                        EmailAddress = dr["EmailAddress"].ToString(),
                        ContactNumber = (dr["ContactNumber"].ToString()),
                        Gender = dr["Gender"].ToString(),

                        Address = dr["Address"].ToString(),
                        Designation = dr["Designation"].ToString(),
                        PhotoID = dr["PhotoID"].ToString(),
                    };
                    //base.SetGender();
                    Picture = dr["Picture"].ToString();
                    if (!string.IsNullOrEmpty(this.Picture))
                    {
                        byte[] bytearr = Convert.FromBase64String(Picture);
                        objImageConvertor.ConvertByteArrayToPhot(bytearr);
                    }
                    obj.ImageSource = objImageConvertor.ImageSource;

                    StaffDetailCollection.Add(obj);
                }

            }
        }
        public override void Search(int pk)
        {
            ImageConvertor objImageConvertor = new ImageConvertor();
            string sql = "exec [SMS].[GetStaffDetails] '" + pk + "','" + Name + "','" + EmailAddress + "'," + this.Schoolid;
            SearchResult = DAL.Select(sql);
            IUDFlag = "U";
            StaffID = SearchResult.Rows[0]["StaffID"].ToString();
            Name = SearchResult.Rows[0]["Name"].ToString();
            EmailAddress = SearchResult.Rows[0]["EmailAddress"].ToString();
            UserID = SearchResult.Rows[0]["UserID"].ToString();
            Password = SearchResult.Rows[0]["Password"].ToString();
            ContactNumber = SearchResult.Rows[0]["ContactNumber"].ToString();
            Address = SearchResult.Rows[0]["Address"].ToString();
            Designation = SearchResult.Rows[0]["Designation"].ToString();
            Subjects = SearchResult.Rows[0]["Subjects"].ToString();
            DateOfJoining = Convert.ToDateTime(SearchResult.Rows[0]["DateOfJoining"]);
            DateofLeaving = Convert.ToDateTime(SearchResult.Rows[0]["DateofLeaving"]);
            DateOfBirth = Convert.ToDateTime(SearchResult.Rows[0]["DateOfBirth"]);
            Gender = SearchResult.Rows[0]["Gender"].ToString();
            Picture = SearchResult.Rows[0]["Picture"].ToString();
            base.SetGender();
            PhotoID = SearchResult.Rows[0]["PhotoID"].ToString();

            if (!string.IsNullOrEmpty(this.Picture))
            {
                byte[] bytearr = Convert.FromBase64String(Picture);
                objImageConvertor.ConvertByteArrayToPhot(bytearr);
            }
            this.ImageSource = objImageConvertor.ImageSource;

        }
    }
}
