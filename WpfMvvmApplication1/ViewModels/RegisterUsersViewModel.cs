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
namespace HospitalManagementSystem.ViewModels
{
    public class RegisterUsersViewModel : BaseViewModel
    {
        public RegisterUsersViewModel()
        {


        }
        private DataRow _selectedrow;
        public DataRow selectedrow
        {
            get { return _selectedrow; }
            set
            {
                if (value != _selectedrow)
                {
                    _selectedrow = value;
                    RaisePropertyChanged(() => selectedrow);
                }
            }
        }

        private DataTable _dtresult;
        public DataTable dtResult
        {
            get { return _dtresult; }
            set
            {
                if (_dtresult != value)
                {
                    _dtresult = value;
                    RaisePropertyChanged(() => dtResult);
                }
            }
        }
        public ICommand cmdsearch { get { return new DelegateCommand(GetData); } }
        public ICommand cmdsave { get { return new DelegateCommand(IUD); } }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != _Name)
                {
                    _Name = value;
                    RaisePropertyChanged(() => Name);
                }
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
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                if (value != _Password)
                {
                    _Password = value;
                    RaisePropertyChanged(() => Password);
                }
            }
        }

        public void GetSingleRecord()
        {
            if (this.PrimaryKey != string.Empty)
            {
                DataTable dt = DataAccess.DAL.Select("select ID as [Record Id],Name,EmailAddress,Password from [users] where Id =" + this.PrimaryKey);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.Name = dt.Rows[0]["Name"].ToString();
                    this.EmailAddress = dt.Rows[0]["EmailAddress"].ToString();
                    this.Password = dt.Rows[0]["Password"].ToString();
                }
            }
        }


        private void GetData()
        {
            if (this.Name != string.Empty)
            {
                dtResult = DataAccess.DAL.Select("select ID as [Record Id],Name,EmailAddress,Password from [users] where Name like '" + this.Name + "%' or emailaddress like '" + this.EmailAddress + "%'");
            }

        }
        public void IUD(object passwordcontrol)
        {
            string sql = string.Empty;
            var passwordbox = passwordcontrol as PasswordBox;
            Password = passwordbox.Password;
            if (string.IsNullOrEmpty(this.PrimaryKey))
            {
                sql = "insert into users([name],[emailaddress],[password])values('" + this.Name + "','" + this.EmailAddress + "','" + this.Password + "')";
            }
            else
            {
                sql = "update users set [name] = '" + this.Name + "', [emailaddress]='" + this.EmailAddress + "' ,[password]='" + this.Password + "' where id=" + this.PrimaryKey + ";";
            }
            int result= DAL.Execute(sql);
            if (result > 0)
            {
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Data Saved Failed", "Error", MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }
    }
}
