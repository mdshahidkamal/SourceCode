using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using ExportToExcel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Drawing.Imaging;
namespace HospitalManagementSystem.ViewModels
{
    public class PatientDetailsViewModel : BaseViewModel
    {
        public class Client
        {
            public string Fullname { get; set; }
            public string Lastname { get; set; }
            public string Firstname { get; set; }
            public string RepCodeString { get; set; }
            public int ClientUID { get; set; }
        }
        public class SelectedMedicine
        {
            public int SerialNumber { get; set; }
            public string medicine { get; set; }
        }


        private string _ReferenceNumber;
        public string ReferenceNumber
        {
            get { return _ReferenceNumber; }
            set
            {
                if (value != _ReferenceNumber)
                {
                    _ReferenceNumber = value;
                    RaisePropertyChanged(() => ReferenceNumber);
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

        private DateTime _RecivedDate;
        public DateTime RecivedDate
        {
            get { return _RecivedDate; }
            set
            {
                if (value != _RecivedDate)
                {
                    _RecivedDate = value;
                    RaisePropertyChanged(() => RecivedDate);
                }
            }
        }
        private string _KeyWord;
        public string KeyWord
        {
            get { return _KeyWord; }
            set
            {
                if (value != _KeyWord)
                {
                    _KeyWord = value;
                    RaisePropertyChanged(() => KeyWord);
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
        private string _Imagepath;
        public string Imagepath
        {
            get { return _Imagepath; }
            set
            {
                if (value != _Imagepath)
                {
                    _Imagepath = value;
                    RaisePropertyChanged(() => Imagepath);
                }
            }
        }
        private Stream _imageStream;
        public Stream NodeImage
        {
            get
            {
                return _imageStream;
            }
            set
            {
                _imageStream = value;
                RaisePropertyChanged(()=>NodeImage);
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
        private string _ColorCode;
        public string ColorCode
        {
            get { return _ColorCode; }
            set
            {
                if (value != _ColorCode)
                {
                    _ColorCode = value;
                    RaisePropertyChanged(() => ColorCode);
                }
            }
        }
        
        
        
        private bool _isCheckedRefNo=false;
        public bool isCheckedRefNo
        {
            get { return _isCheckedRefNo; }
            set
            {
                if (value != _isCheckedRefNo)
                {
                    _isCheckedRefNo = value;
                    RaisePropertyChanged(() => isCheckedRefNo);
                }
            }
        }
        private bool _isCheckedSubject = false;
        public bool isCheckedSubject
        {
            get { return _isCheckedSubject; }
            set
            {
                if (value != _isCheckedSubject)
                {
                    _isCheckedSubject = value;
                    RaisePropertyChanged(() => isCheckedSubject);
                }
            }
        }
        private bool _isCheckedTo = false;
        public bool isCheckedTo
        {
            get { return _isCheckedTo; }
            set
            {
                if (value != _isCheckedTo)
                {
                    _isCheckedTo = value;
                    RaisePropertyChanged(() => isCheckedTo);
                }
            }
        }
        private bool _isCheckedFrom = false;
        public bool isCheckedFrom
        {
            get { return _isCheckedFrom; }
            set
            {
                if (value != _isCheckedFrom)
                {
                    _isCheckedFrom = value;
                    RaisePropertyChanged(() => isCheckedFrom);
                }
            }
        }

        private bool _isCheckedComments;
        public bool isCheckedComments
        {
            get { return _isCheckedComments; }
            set
            {
                if (value != _isCheckedComments)
                {
                    _isCheckedComments = value;
                    RaisePropertyChanged(() => isCheckedComments);
                }
            }
        }
        private double _ScreenWidth;
        public double ScreenWidth
        {
            get { return _ScreenWidth; }
            set
            {
                if (value != _ScreenWidth)
                {
                    _ScreenWidth = value;
                    RaisePropertyChanged(() => ScreenWidth);
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
        private bool _GenderMale;
        public bool GenderMale
        {
            get { return _GenderMale; }
            set
            {
                if (value != _GenderMale)
                {
                    _GenderMale = value;
                    if (_GenderMale)
                    {
                        Gender = "Male";
                    }
                    RaisePropertyChanged(() => GenderMale);
                }
            }
        }
        private bool _GenderFemale;
        public bool GenderFemale
        {
            get { return _GenderFemale; }
            set
            {
                if (value != _GenderFemale)
                {
                    _GenderFemale = value;
                    if (_GenderFemale)
                    {
                        Gender = "Female";
                    }
                    RaisePropertyChanged(() => GenderFemale);
                }
            }
        }

        public string Gender { get; set; }
        private string _ContactDetails;
        public string ContactDetails
        {
            get { return _ContactDetails; }
            set
            {
                if (value != _ContactDetails)
                {
                    _ContactDetails = value;
                    RaisePropertyChanged(() => ContactDetails);
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

        private string _IUDFlag;
        public string IUDFlag
        {
            get { return _IUDFlag; }
            set
            {
                if (value != _IUDFlag)
                {
                    _IUDFlag = value;
                    RaisePropertyChanged(() => IUDFlag);
                }
            }
        }

        private string _PrimaryKey;
        public string PrimaryKey
        {
            get { return _PrimaryKey; }
            set
            {
                if (value != _PrimaryKey)
                {
                    _PrimaryKey = value;
                    RaisePropertyChanged(() => PrimaryKey);
                }
            }
        }

        private string _DoctorsId;
        public string DoctorsId
        {
            get { return _DoctorsId; }
            set
            {
                if (value != _DoctorsId)
                {
                    _DoctorsId = value;
                    RaisePropertyChanged(() => DoctorsId);
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

        private ObservableCollection<string> _lstDoctorsname;
        public ObservableCollection<string> lstDoctorsname
        {
            get { return _lstDoctorsname; }
            set
            {
                if (value != _lstDoctorsname)
                {
                    _lstDoctorsname = value;
                    RaisePropertyChanged(() => lstDoctorsname);
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

        private ObservableCollection<string> _lstMedicineName;
        public ObservableCollection<string> lstMedicineName
        {
            get { return _lstMedicineName; }
            set
            {
                if (value != _lstMedicineName)
                {
                    _lstMedicineName = value;
                    RaisePropertyChanged(() => lstMedicineName);
                }
            }
        }
        private string _MedicineName;
        public string MedicineName
        {
            get { return _MedicineName; }
            set
            {
                if (value != _MedicineName)
                {
                    _MedicineName = value;
                    RaisePropertyChanged(() => MedicineName);
                }
            }
        }
        private ObservableCollection<SelectedMedicine> _AddedMedicine;
        public ObservableCollection<SelectedMedicine> AddedMedicine
        {
            get { return _AddedMedicine; }
            set
            {
                if (value != _AddedMedicine)
                {
                    _AddedMedicine = value;
                    RaisePropertyChanged(() => AddedMedicine);
                }
            }
        }

        private DateTime _FromDate;
        public DateTime FromDate
        {
            get { return _FromDate; }
            set
            {
                if (value != _FromDate)
                {
                    _FromDate = value;
                    RaisePropertyChanged(() => FromDate);
                }
            }
        }
        private DateTime _ToDate;
        public DateTime ToDate
        {
            get { return _ToDate; }
            set
            {
                if (value != _ToDate)
                {
                    _ToDate = value;
                    RaisePropertyChanged(() => ToDate);
                }
            }
        }
        private bool _isfiledownloaded;
        public bool isfiledownloaded
        {
            get { return _isfiledownloaded; }
            set
            {
                if (value != _isfiledownloaded)
                {
                    _isfiledownloaded = value;
                    RaisePropertyChanged(() => isfiledownloaded);
                }
            }
        }





        #region Constructor

        public PatientDetailsViewModel()
        {

            this.RecivedDate = DateTime.Now.Date;
            this.FromDate = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0)).Date;
            this.ToDate = DateTime.Now.Date;
            Search();
            isfiledownloaded = false;
        }
        void GetDoctors()
        {
            string sql = "select doctorname from doctors";
            DataTable dt = DAL.Select(sql);
            lstDoctorsname = new ObservableCollection<string>();
            foreach (DataRow dr in dt.Rows)
            {
                lstDoctorsname.Add(dr[0].ToString());
            }
        }
        void GetMedicine()
        {
            string sql = "select medicinename from medicine";
            DataTable dt = DAL.Select(sql);
            lstMedicineName = new ObservableCollection<string>();
            AddedMedicine = new ObservableCollection<SelectedMedicine>();
            foreach (DataRow dr in dt.Rows)
            {
                lstMedicineName.Add(dr[0].ToString());

            }
        }
        #endregion

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

        public DataTable ResultDataWithID { get; set; }

        public ICommand cmdsave { get { return new DelegateCommand(IUD, canSaveData); } }
        public ICommand cmdAddMedicine { get { return new DelegateCommand(AddMedicine, CanAddMedicine); } }
        public ICommand cmdSearch { get { return new DelegateCommand(Search); } }
        public ICommand cmdSearchOnEnter { get { return new DelegateCommand(Search); } }
        public ICommand cmdprint { get { return new DelegateCommand(PrintForm, CanPrint); } }
        public ICommand cmdexport { get { return new DelegateCommand(ExportReport, CanExportReport); } }

        private bool CanExportReport()
        {
            bool flag = true;

            return flag;
        }

        private void ExportReport()
        {

            //SearchResult
            //select ID, PatientName,Age,Gender,ContactNumber,Address,DoctorName,Amount
            //string medicineList = string.Empty;
            DataTable dt = SearchResult.Clone();
            dt.Columns.Add(new DataColumn("Precriptions"));
            DataRow drnew = null;
            foreach (DataRow dr in SearchResult.Rows)
            {
                drnew = dt.NewRow();
                drnew["ID"] = dr["ID"];
                drnew["Age"] = dr["Age"];
                drnew["PatientName"] = dr["PatientName"];
                drnew["Gender"] = dr["Gender"];
                drnew["ContactDetails"] = dr["ContactDetails"];
                drnew["Address"] = dr["Address"];
                drnew["DoctorName"] = dr["DoctorName"];
                drnew["Amount"] = dr["Amount"];
                string sql = "select MedicineName from billmedicinemapping where billid='" + dr["ID"].ToString() + "'";
                DataTable dtmedicine = DAL.Select(sql);
                drnew["Precriptions"] = GetCommaSeparatedValues(dtmedicine);
                drnew["CreatedDate1"] = dr["CreatedDate1"];
                drnew["CreatedTime1"] = dr["CreatedTime1"];

                dt.Rows.Add(drnew);
            }

            string filename = @"c:\temp\Report_" + DateTime.Now.ToString("ddMMMyyyy") + ".xlsx";
            //dt.ToCSV(@"c:\temp\" + filename);
            CreateExcelFile.CreateExcelDocument(dt, filename);


            isfiledownloaded = true;
        }

        public string GetCommaSeparatedValues(DataTable dt)
        {
            string values = string.Empty;
            foreach (DataRow r in dt.Rows)
            {
                values += r["MedicineName"].ToString() + ",";
            }
            return values;
        }

        private bool CanPrint()
        {
            return canSaveData();
        }

        private void PrintForm()
        {
            //PrintForm obj = new PrintForm(this);
            //obj.ShowDialog();
        }


        private void RadioCommand(object value)
        {
            this.Gender = value as string;
        }
        private bool canSaveData()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(this.ReferenceNumber))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(this.Subject))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(this.From))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(this.To))
            {
                flag = false;
            }
            return flag;
        }


        private bool CanAddMedicine()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(this.MedicineName))
            {
                flag = false;
            }
            return flag;
        }
        int counter = 1;
        private void AddMedicine()
        {
            AddedMedicine.Add(new SelectedMedicine { SerialNumber = counter, medicine = this.MedicineName });
            this.MedicineName = string.Empty;
            counter++;
        }

        void InsertDoctors()
        {


            string sql = "select count(1) from doctors where doctorname='" + this.DoctorName.ToUpper() + "'";
            int result = DAL.ExecuteScalar(sql);
            if (result == 0)
            {
                sql = "insert into doctors(Doctorname)values('" + this.DoctorName.ToUpper() + "')";
                result = DAL.Execute(sql);
            }

        }
        void InsertMedicine()
        {

        }


        public void IUD()
        {
            string sql = string.Empty;
            if (string.IsNullOrEmpty(this.PrimaryKey))
            {

                sql = "insert into LetterDetails([ReferenceNumber],[RecivedDate],[Subject],[From],[To],[Comments],[ImagePath],[LetterContent],[ColorCode])values('" + this.ReferenceNumber + "','" + this.RecivedDate + "','" + this.Subject + "','" + this.From + "','" + this.To + "','" + this.Comments + "','" + this.Imagepath + "','" + this.LetterContent + "','" + this.ColorCode + "')";
            }
            else
            {
                sql = "update LetterDetails set [ReferenceNumber] = '" + this.ReferenceNumber + "', [Subject]='" + this.Subject + "' ,[RecivedDate]='" + this.RecivedDate + "' , [from]='" + this.From + "' ,[To]='" + this.To + "' ,[Comments]='" + this.Comments + "' ,[ImagePath]='" + this.Imagepath + "' ,[LetterContent]='" + this.LetterContent + "' ,[ColorCode]='" + this.ColorCode + "' where id=" + this.PrimaryKey + ";";
            }
            int result = DAL.Execute(sql);
            if (result > 0)
            {
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearForm();
                Search();
            }
            else
            {
                MessageBox.Show("Data Saved Failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        void IUDMedicineMapping(string strbillid)
        {
            string sql = string.Empty;
            string billid = string.Empty;
            if (string.IsNullOrEmpty(strbillid))
            {

                sql = "select max(id) from billdetails";
                DataTable result = DAL.Select(sql);
                billid = result.Rows[0][0].ToString();
                sql = string.Empty;
            }
            else
            {
                billid = strbillid;
            }

            sql = "delete from billmedicinemapping where billid='" + billid + "'";

            int r = DAL.Execute(sql);


            foreach (SelectedMedicine m in AddedMedicine)
            {
                sql = "insert into billmedicinemapping(billid,medicinename)values('" + billid + "','" + m.medicine + "')";
                DAL.Execute(sql);
            }




        }
        private void Search()
        {
            string sql = string.Empty;
            string r = string.Empty;
            string s = string.Empty;
            string f = string.Empty;
            string t = string.Empty;
            string c = string.Empty;

            if (this.isCheckedFrom)
            {
                f = "%";
            }
            if (this.isCheckedRefNo)
            {
                r = "%";
            }
            if (this.isCheckedSubject)
            {
                s = "%";
            }
            if (this.isCheckedTo)
            {
                t = "%";
            }
            if (this.isCheckedComments)
            {
                c = "%";
            }
            

            if (string.IsNullOrEmpty(this.KeyWord))
            {
                sql = "select ID, [ReferenceNumber],[Subject],[From],[To],[RecivedDate],format(createddate,'Short Date') as CreatedDate1,format(createdtime,'Short Time')as CreatedTime1,Comments,[ImagePath],[ColorCode],[LetterContent] from LetterDetails where CreatedDate >=#" + this.FromDate.ToString("MM/dd/yyyy") + "# and CreatedDate<=#" + this.ToDate.ToString("MM/dd/yyyy") + "#";
            }
            else
            {
                sql = "select ID, [ReferenceNumber],[Subject],[From],[To],[RecivedDate],format(createddate,'Short Date') as CreatedDate1,format(createdtime,'Short Time')as CreatedTime1,Comments,[ImagePath],[ColorCode],[LetterContent] from LetterDetails where CreatedDate >=#" + this.FromDate.ToString("MM/dd/yyyy") + "# and CreatedDate<=#" + this.ToDate.ToString("MM/dd/yyyy") + "#";
                sql += " and (";
                sql += " ReferenceNumber like '" + r + this.KeyWord + r + "' or Subject like '" + s + this.KeyWord + s + "' or [from] like '" + f + this.KeyWord + f + "' or [To] like '" + t + this.KeyWord + t + "' or [Comments] like '" + c + this.KeyWord + c + "')";
            }
            sql += " order by Id desc";

            SearchResult = DAL.Select(sql);
            isfiledownloaded = false;
        }
        public void SearchWithID(string ID)
        {
            string sql = "select ID, [ReferenceNumber],[Subject],[From],[To],[RecivedDate],[Comments],[ImagePath],[LetterContent],[ColorCode] from LetterDetails where ID=" + ID;
            ResultDataWithID = DAL.Select(sql);
            foreach (DataRow dr in ResultDataWithID.Rows)
            {
                this.PrimaryKey = dr["ID"].ToString();
                this.ReferenceNumber = dr["ReferenceNumber"].ToString();
                this.Subject = dr["Subject"].ToString();
                this.From = dr["From"].ToString();
                this.To = dr["To"].ToString();
                this.Comments = dr["Comments"].ToString();
                this.RecivedDate = Convert.ToDateTime(dr["RecivedDate"]);
                this.LetterContent = dr["LetterContent"].ToString();
                this.Imagepath = dr["ImagePath"].ToString();
                //System.Drawing.Image img = new System.Drawing.Bitmap(this.Imagepath);
                
                //this.NodeImage = GetStream(img,ImageFormat.Jpeg);
                this.ColorCode = dr["ColorCode"].ToString();
            }
            isfiledownloaded = false;
        }
        private void GetMedicineDetails(string BillID)
        {
            string sql = "select MedicineName from billmedicinemapping where billid='" + BillID + "'";
            DataTable dt = DAL.Select(sql);
            AddedMedicine.Clear();
            foreach (DataRow dr in dt.Rows)
            {

                AddedMedicine.Add(new SelectedMedicine { SerialNumber = 0, medicine = dr["MedicineName"].ToString() });
            }
        }

        void ClearForm()
        {
            this.ReferenceNumber = string.Empty;
            this.From = string.Empty;
            this.To = string.Empty;
            this.Subject = string.Empty;
            this.RecivedDate = DateTime.Now;
            this.Comments = string.Empty;
            this.ColorCode = string.Empty;
            this.LetterContent = string.Empty;
            this.Imagepath = string.Empty;
        }
        public Stream GetStream(System.Drawing.Image img, ImageFormat format)
        {
            var stream = new System.IO.MemoryStream();
            img.Save(stream, format);
            stream.Position = 0;
            return stream;
        }

    }
}
