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
namespace HospitalManagementSystem.ViewModels
{
    public delegate void mydelegate();
    public class LoginViewModel : BaseViewModel
    {
        public event mydelegate onClose;
        public LoginViewModel()
        {
            
        }
        public ICommand cmdlogin { get { return new DelegateCommand(Login); } }

        private void Login(object passwordcontrol)
        {
            string sql = string.Empty;
            var passwordbox = passwordcontrol as PasswordBox;
            password = passwordbox.Password;
            sql = "select * from [users] where [emailaddress]='" + this.EmailAddress + "' and [password]='" + this.password + "'";
            DataTable dt= DataAccess.DAL.Select(sql);
            if (dt.Rows.Count > 0)
            {
                Main obj = new Main(dt.Rows[0]["ID"].ToString());
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
