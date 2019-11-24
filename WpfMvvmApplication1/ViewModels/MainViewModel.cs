using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.Models;
using System.Windows.Controls;
using HospitalManagementSystem.Views;
using System.Data;

using System.Configuration;
using System.IO;
using System.Windows.Media.Imaging;
using IMS.Views;

namespace HospitalManagementSystem.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        #region MyDateTime

        private string _myDateTime;
        public string MyDateTime
        {
            get { return _myDateTime; }
            set
            {
                if (_myDateTime != value)
                {
                    _myDateTime = value;
                    RaisePropertyChanged(() => MyDateTime);
                }
            }
        }
        //private PatientDetails _mycontrol;
        //public PatientDetails mycontrol
        //{
        //    get { return _mycontrol; }
        //    set
        //    {
        //        if (_mycontrol != value)
        //        {
        //            _mycontrol = value;
        //            RaisePropertyChanged(() => mycontrol);
        //        }
        //    }
        //}

        private UserControl _contentControl;
        public UserControl contentcontrol
        {
            get { return _contentControl; }
            set
            {
                if (value != _contentControl)
                {
                    _contentControl = value;
                    RaisePropertyChanged(() => contentcontrol);
                }
            }
        }
        private string _buttonimagepath;
        public string buttonimagepath
        {
            get { return _buttonimagepath; }
            set
            {
                if (value != _buttonimagepath)
                {
                    _buttonimagepath = value;
                    RaisePropertyChanged(() => buttonimagepath);
                }
            }
        }

        #endregion

        #endregion

        #region Commands

        public ICommand cmdRenderForm { get { return new DelegateCommand(OnRenderForm); } }

        #endregion

        #region Ctor
        Helpers.Logger logger;

        private readonly ObservableCollection<ButtonDataModel> _MyData = new ObservableCollection<ButtonDataModel>();
        public ObservableCollection<ButtonDataModel> MyData { get { return _MyData; } }

        private ObservableCollection<TabDataModel> _TabItemSource;
        public ObservableCollection<TabDataModel> TabItemSource
        {
            get { return _TabItemSource; }
            set
            {
                if (value != _TabItemSource)
                {
                    _TabItemSource = value;
                    RaisePropertyChanged(() => TabItemSource);
                }
            }
        }

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (value != _UserName)
                {
                    _UserName = value;
                    RaisePropertyChanged(() => UserName);
                }
            }
        }
        private string _ClientNAme;
        public string ClientNAme { get { return _ClientNAme; } set { if (value != _ClientNAme) { _ClientNAme = value; RaisePropertyChanged(() => ClientNAme); } } }

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


        private string _ConnectedTo;
        public string ConnectedTo
        {
            get { return _ConnectedTo; }
            set
            {
                if (value != _ConnectedTo)
                {
                    _ConnectedTo = value;
                    RaisePropertyChanged(() => ConnectedTo);
                }
            }
        }
        private BitmapFrame _ImageSource; public BitmapFrame ImageSource { get { return _ImageSource; } set { if (value != _ImageSource) { _ImageSource = value; RaisePropertyChanged(() => ImageSource); } } }
        void GetImageTempate()
        {
            try
            {
                string LogoPath = ConfigurationSettings.AppSettings["SchoolLogo"].ToString();
                LogoPath = LogoPath + Common.ClientLogo;
                this.ImageSource = BitmapFrame.Create(new Uri(LogoPath), BitmapCreateOptions.None,
                                                   BitmapCacheOption.OnLoad);
            }
            catch (Exception ex)
            {
                logger.Log(ex.StackTrace, MessageType.Error);
            }
        }
        public MainViewModel(string userid)
        {
            TabItemSource = new ObservableCollection<TabDataModel>();
            logger = Helpers.Logger.IntializeLogger();


            //string sql = "select m.application_id,a.applicationname,m.user_id,a.imagepath,u.Name from applicationmapping m, applications a, users u";
            //sql += " where m.application_id=a.id";

            //sql += " and m.user_id=u.id and u.id=" + userid + " order by SortOrder";

            string sql = "exec ims.imsUserAppMapping " + userid + "," + 25;
            DataTable dtResult = DataAccess.DAL.Select(sql);
            if (dtResult != null && dtResult.Rows.Count > 0)
            {
                UserName = "Welcome " + dtResult.Rows[0]["Name"].ToString();
                Common.LoggedInUserID= dtResult.Rows[0]["User_ID"].ToString();
                foreach (DataRow dr in dtResult.Rows)
                {
                    ButtonDataModel obj = new ButtonDataModel(dr["ApplicationName"].ToString(), new DelegateCommand(OnRenderForm), new string[] { dr["ApplicationName"].ToString() }, dr["ImagePath"].ToString());
                    MyData.Add(obj);
                }
            }
            this.ClientNAme = Common.ClientName;
            this.AcademicYear = Common.AcademicYear;
            this.ConnectedTo = "Connected To " + DataAccess.DAL.oConn.DataSource;
            //            string[] arr = new string[] { "Letter" };
            OnRenderForm(null);
            try
            {
                download();
               
            }
            catch (Exception ex)
            {
                logger.Log(ex.StackTrace, MessageType.Error);
            }
        }
        async void download()
        {
             BlobUploader obj = new BlobUploader();
            await obj.Download();
            GetImageTempate();
        }
        #endregion

        #region Command Handlers
        int tabCounter = 0;
        private void OnRenderForm(object param)
        {

            if (param != null)
            {
                string[] formname = ((string[])param);

                contentcontrol = null;
                if (formname[0] == "Invoice")
                {
                    contentcontrol = new InvoiceDetails();
                }
                else if(formname[0]=="Bill")
                {
                    contentcontrol = new Billing();
                }
                else if (formname[0] == "Inventory Report")
                {
                    contentcontrol = new InventoryReport();
                }

                //if (formname[0] == "Student")
                //{
                //    if (formname.Length == 2)
                //    {
                //        contentcontrol = new StudentDetails(Convert.ToInt32(formname[1]));
                //    }
                //    else
                //    {

                //        contentcontrol = new StudentDetails();
                //        //contentcontrol = new UserControl1();
                //    }

                //}
                //else if (formname[0] == "Staff")
                //{
                //    contentcontrol = new StaffSearch();
                //    ((StaffSearch)contentcontrol).onCallback += OnRenderForm;
                    
                //}
                //else if (formname[0] == "StaffAdd")
                //{
                //    if (formname.Length == 2)
                //    {
                //        contentcontrol = new StaffDetails(Convert.ToInt32(formname[1]));
                //    }
                //    else
                //    {
                //        contentcontrol = new StaffDetails();
                //    }
                //}
                //else if (formname[0] == "Report")
                //{

                //}
                //else if (formname[0] == "StudentClassMapping")
                //{
                //    contentcontrol = new StudentClassMapping();
                //}
                //else if (formname[0] == "StaffClassMapping")
                //{
                //    contentcontrol = new StaffClassMapping();
                //}
                //else if (formname[0] == "StaffSubjectMapping")
                //{
                //    contentcontrol = new StaffSubjectMapping();
                //}
                //else if (formname[0] == "Payments")
                //{
                //    contentcontrol = new StudentPayments();
                //}
                //else if (formname[0] == "Payment Report")
                //{
                //    ReportHostingFormUC obj = new ReportHostingFormUC("ARAP");
                //    contentcontrol = obj;
                //}
                //else if (formname[0] == "Expense")
                //{
                //    ExpenseEntry obj = new ExpenseEntry();
                //    contentcontrol = obj;
                //}
                //else if (formname[0] == "Expense Report")
                //{
                //    ExpenseReportHostingForm obj = new ExpenseReportHostingForm("ExpenseReport");
                //    contentcontrol = obj;
                //}
                //  else if (formname[0] == "Charts")
                //{
                //    ChartReports obj = new ChartReports();
                //    contentcontrol = obj;
                //}

                TabDataModel objTab = new TabDataModel(contentcontrol);
                objTab.Title = formname[0];
                objTab.cmdClose = new DelegateCommand(RemoveItemFromTabCollection);
                objTab.Parameter = objTab;
                this.tabindex = tabCounter;
                tabCounter++;
                TabItemSource.Add(objTab);

            }
        }

        public void RemoveItemFromTabCollection(object param)
        {
            TabDataModel obj = param as TabDataModel;
            TabItemSource.Remove(obj);
            tabCounter--;
        }
        #endregion
        private int _tabindex;
        public int tabindex
        {
            get { return _tabindex; }
            set
            {
                if (value != _tabindex)
                {
                    _tabindex = value;
                    RaisePropertyChanged(() => tabindex);
                }
            }
        }
    }

    public class TabDataModel : BaseViewModel
    {
        public TabDataModel(UserControl ctrl)
        {

            this.contentcontrol = ctrl;
            myClosableTab = new ClosableTab();
            myClosableTab.Content = contentcontrol;
            myClosableTab.Title = this.Title;
        }
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set
            {
                if (value != _Title)
                {
                    _Title = value;
                    RaisePropertyChanged(() => Title);
                }
            }
        }

        private ClosableTab _myClosableTab;
        public ClosableTab myClosableTab
        {
            get { return _myClosableTab; }
            set
            {
                if (value != _myClosableTab)
                {
                    _myClosableTab = value;
                    RaisePropertyChanged(() => myClosableTab);
                }
            }
        }



        private UserControl _contentControl;
        public UserControl contentcontrol
        {
            get { return _contentControl; }
            set
            {
                if (value != _contentControl)
                {
                    _contentControl = value;
                    RaisePropertyChanged(() => contentcontrol);
                }
            }
        }
        public ICommand cmdClose { get; set; }
        private TabDataModel _Parameter;
        public TabDataModel Parameter
        {
            get { return _Parameter; }
            set
            {
                if (value != _Parameter)
                {
                    _Parameter = value;
                    RaisePropertyChanged(() => Parameter);
                }
            }
        }



    }

    public class ButtonDataModel
    {
        public string Content { get; set; }
        public string[] Parameter { get; set; }
        public ICommand Command { get; set; }
        public string buttonimagepath { get; set; }

        public ButtonDataModel(string content, ICommand command, string[] parameter, string imagepath)
        {

            this.Command = command;
            this.buttonimagepath = imagepath;
            this.Parameter = parameter;
            this.Content = content;
        }

        public ButtonDataModel()
        {
            // TODO: Complete member initialization
        }
    }
}
