using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Windows.Input;

namespace HospitalManagementSystem.ViewModels
{
    public class BaseViewModel : NotificationObject
    {
    
        private string _ClientId;
        public string ClientId { get { return _ClientId; } set { if (value != _ClientId) { _ClientId = value; RaisePropertyChanged(() => ClientId); } } }

        public BaseViewModel()
        {
            string ClientID  = Common.Clientid; // ConfigurationSettings.AppSettings["SchoolID"].ToString();
            this.ClientId = ClientID;
        }
        //public virtual DataTable GetClassRoom()
        //{

        //    string sql = "exec sms.getstaticdata 0,'ClassRoom'," + Schoolid;
        //    DataTable dt = DAL.Select(sql);
        //    return dt;
        //}
        public virtual DataTable GetStaticData(string StaticType)
        {
            string sql = "exec ims.getstaticdata 0,'" + StaticType + "'," + ClientId;
            DataTable dt = DAL.Select(sql);
            return dt;
        }
       
    }
    public class StaffModel
    {
        public string StaffID { get; set; }
        public string StaffName { get; set; }
        public object Parameter { get; set; }
        public ICommand Command { get; set; }
        public StaffModel()
        {

        }

    }
    public class SubjectModel
    {
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public object Parameter { get; set; }
        public ICommand Command { get; set; }
        public SubjectModel()
        {

        }

    }



    public class StaticDataModel : BaseViewModel
    {
        private string _StaticName;
        public string StaticName
        {
            get
            {
                return _StaticName;
            }
            set
            {
                if (value != _StaticName)
                {
                    _StaticName = value;
                    RaisePropertyChanged(() => _StaticName);
                }
            }
        }
        private int _StaticID;
        public int StaticID
        {
            get
            {
                return _StaticID;
            }
            set
            {
                if (value != _StaticID)
                {
                    _StaticID = value;
                    RaisePropertyChanged(() => _StaticID);
                }
            }
        }
        private bool _IsCheckControl;
        public bool IsCheckControl
        {
            get { return _IsCheckControl; }
            set
            {
                if (value != _IsCheckControl)
                {
                    _IsCheckControl = value;
                    RaisePropertyChanged(() => IsCheckControl);
                }
            }
        }


    }
    public class ItemControlDataModel
    {
        public string Content { get; set; }
        public object Parameter { get; set; }
        public ICommand Command { get; set; }
        public string buttonimagepath { get; set; }

        public ItemControlDataModel(string content, ICommand command, object parameter, string imagepath)
        {

            this.Command = command;
            this.buttonimagepath = imagepath;
            this.Parameter = parameter;
            this.Content = content;
        }

        public ItemControlDataModel()
        {
            // TODO: Complete member initialization
        }
    }
}