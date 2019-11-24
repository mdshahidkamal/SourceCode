using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using HospitalManagementSystem.Views;
using System.Windows;
using System.Windows.Media.Imaging;
using System.IO;
using System.Configuration;

namespace HospitalManagementSystem.ViewModels
{
    public delegate void mydelegate();
    public class LoginViewModel : BaseViewModel
    {
        private BitmapFrame _ImageSource; public BitmapFrame ImageSource { get { return _ImageSource; } set { if (value != _ImageSource) { _ImageSource = value; RaisePropertyChanged(() => ImageSource); } } }
        public event mydelegate onClose;
        public LoginViewModel()
        {
            //GetImageTempate();
        }
      
        public ICommand cmdlogin { get { return new DelegateCommand(Login); } }
        void DownloadFiles()
        {

        }
        private string _ClientId;
        public string ClientId { get { return _ClientId; } set { if (value != _ClientId) { _ClientId = value; RaisePropertyChanged(() => ClientId); } } }

        private void Login(object passwordcontrol)
        {
            string sql = string.Empty;
            var passwordbox = passwordcontrol as PasswordBox;
            password = passwordbox.Password;
            sql = "exec [IMS].[UserLogin] " + this.EmailAddress + "," + this.password;
            DataTable dt = DataAccess.DAL.Select(sql);
            if (dt.Rows.Count > 0)
            {
                Common.Clientid = dt.Rows[0]["ClientID"].ToString();
                Common.SetStaicData();
                this.ClientId = Common.Clientid;
                Main obj = new Main(dt.Rows[0]["StaffID"].ToString());
                obj.Show();
                onClose();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }


        }
        private string _EmailAddress;
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set
            {
                if (value != _EmailAddress)
                {
                    _EmailAddress = value;
                    RaisePropertyChanged(() => EmailAddress);
                }
            }
        }
        private string _password;
        public string password
        {
            get { return _password; }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    RaisePropertyChanged(() => password);
                }
            }
        }


    }
}
