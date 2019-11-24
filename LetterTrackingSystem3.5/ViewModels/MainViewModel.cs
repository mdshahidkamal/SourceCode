using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.Models;
using System.Windows.Controls;
using HospitalManagementSystem.Views;
using System.Data;
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
        private PatientDetails _mycontrol;
        public PatientDetails mycontrol
        {
            get { return _mycontrol; }
            set
            {
                if (_mycontrol != value)
                {
                    _mycontrol = value;
                    RaisePropertyChanged(() => mycontrol);
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


        public MainViewModel(string userid)
        {
            logger = Helpers.Logger.IntializeLogger();

            string sql = "select m.application_id,a.applicationname,m.user_id,a.imagepath,u.Name from applicationmapping m, applications a, users u";
            sql += " where m.application_id=a.id";
            sql += " and m.user_id=u.id and u.id=" + userid + " order by SortOrder";

            DataTable dtResult = DataAccess.DAL.Select(sql);
            if (dtResult != null && dtResult.Rows.Count > 0)
            {
                UserName = "Welcome " + dtResult.Rows[0]["Name"].ToString();
                foreach (DataRow dr in dtResult.Rows)
                {
                    ButtonDataModel obj = new ButtonDataModel(dr["ApplicationName"].ToString(), new DelegateCommand(OnRenderForm), dr["ApplicationName"].ToString(), dr["ImagePath"].ToString());
                    MyData.Add(obj);
                }
            }
            OnRenderForm("Mail");
        }
        #endregion

        #region Command Handlers

        private void OnRenderForm(object param)
        {
            MyDateTime = param.ToString();
            string formname = param as string;
            if (formname == "Mail")
            {
                contentcontrol = new PatientDetails();
            }
            else if (formname == "Report")
            {
                contentcontrol = new ReportsHostingForm();
            }
        }

        #endregion

    }
    public class ButtonDataModel
    {
        public string Content { get; set; }
        public string Parameter { get; set; }
        public ICommand Command { get; set; }
        public string buttonimagepath { get; set; }

        public ButtonDataModel(string content, ICommand command, string parameter, string imagepath)
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
