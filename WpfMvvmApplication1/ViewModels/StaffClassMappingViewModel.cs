using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace HospitalManagementSystem.ViewModels
{
    public class StaffClassMappingViewModelEntity : BaseViewModel
    {
        private string _STACMID; public string STACMID { get { return _STACMID; } set { if (value != _STACMID) { _STACMID = value; RaisePropertyChanged(() => STACMID); } } }
        private string _StaffID; public string StaffID { get { return _StaffID; } set { if (value != _StaffID) { _StaffID = value; RaisePropertyChanged(() => StaffID); } } }
        private string _ClassRoomID; public string ClassRoomID { get { return _ClassRoomID; } set { if (value != _ClassRoomID) { _ClassRoomID = value; RaisePropertyChanged(() => ClassRoomID); } } }
        private string _SchoolID; public string SchoolID { get { return _SchoolID; } set { if (value != _SchoolID) { _SchoolID = value; RaisePropertyChanged(() => SchoolID); } } }
        private string _IUDFlag; public string IUDFlag { get { return _IUDFlag; } set { if (value != _IUDFlag) { _IUDFlag = value; RaisePropertyChanged(() => IUDFlag); } } }
        private string _SelectedStaff;
        public virtual string SelectedStaff
        {
            get
            {
                return _SelectedStaff;
            }
            set
            {
                if (value != _SelectedStaff)
                {
                    _SelectedStaff = value;
                    RaisePropertyChanged(() => _SelectedStaff);
                }
            }
        }


    }
    public class StaffClassMappingViewModel : StaffClassMappingViewModelEntity
    {
        public ICommand cmdAddStaff { get { return new DelegateCommand(AddStaff, canAddStaff); } }
        public ICommand cmdRemove { get { return new DelegateCommand(RemoveStaff, CanRemoveStaff); } }
        public ICommand cmdsave { get { return new DelegateCommand(IUD, canSave); } }
        private StaticDataModel _SelectedClassRoom; public StaticDataModel SelectedClassRoom { get { return _SelectedClassRoom; } set { if (value != _SelectedClassRoom) { _SelectedClassRoom = value; RaisePropertyChanged(() => _SelectedClassRoom); } } }
        private ObservableCollection<StaticDataModel> _lstClassRoom; public ObservableCollection<StaticDataModel> lstClassRoom { get { return _lstClassRoom; } set { if (value != _lstClassRoom) { _lstClassRoom = value; RaisePropertyChanged(() => _lstClassRoom); } } }
        void GetStaffClassMapping()
        {
            try
            {
                string sql = "exec [SMS].[GetStaffClassMapping]";
                List<string> lst = new List<string>();
                lst.Add(SelectedClassRoom.StaticID.ToString());
                lst.Add(Schoolid);
                DataTable dt = DAL.Select(sql, lst);
                AddedStaff = new ObservableCollection<StaffModel>();
                foreach (DataRow dr in dt.Rows)
                {
                    StaffModel obj = new StaffModel();
                    obj.StaffName = dr["staffname"].ToString();
                    obj.StaffID = dr["StaffID"].ToString();
                    obj.Command = new DelegateCommand(RemoveStaff);
                    obj.Parameter = obj;
                    AddedStaff.Add(obj);
                }
            }
            catch (Exception ex)
            {
 
            }
        }
        private bool canSave()
        {
            return true;
        }

        private void IUD()
        {
            string sql = "exec [SMS].[IUDStaffClassMapping]";
            List<string> lst = new List<string>();

            lst.Add(StaffID);
            lst.Add(SelectedClassRoom.StaticID.ToString());
            lst.Add(Schoolid);
            lst.Add(IUDFlag);
            DAL.Execute(sql, lst);
            lst.Clear();
            //MessageBox.Show("Data Saved Successfully");
        }

        private bool CanRemoveStaff()
        {
            return true;
        }

        private void RemoveStaff(object o)
        {
            StaffModel s = o as StaffModel;
            AddedStaff.Remove(s);
            IUDFlag = "D";
            StaffID = s.StaffID.Trim();
            IUD();
            //counter--;
        }

        private bool canAddStaff()
        {
            return true;
        }
        public StaffClassMappingViewModel()
        {
             GetClassRoom();
            GetStaff();
            AddedStaff = new ObservableCollection<ViewModels.StaffModel>();
        }
        public new DataTable GetClassRoom()
        {
            DataTable dt = Common.GetClassRoom();
            lstClassRoom = new ObservableCollection<StaticDataModel>();
            foreach (DataRow dr in dt.Rows)
            {
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID =int.Parse(dr[0].ToString());
                obj.StaticName= dr[1].ToString();
                lstClassRoom.Add(obj);
            }
            SelectedClassRoom = lstClassRoom.First();
            return dt;
        }

        public new void GetStaff()
        {
            Common.GetStaff();
        }
        private ObservableCollection<StaffModel> _AddedStaff;
        public ObservableCollection<StaffModel> AddedStaff
        {
            get { return _AddedStaff; }
            set
            {
                if (value != _AddedStaff)
                {
                    _AddedStaff = value;
                    RaisePropertyChanged(() => AddedStaff);
                }
            }
        }
        int counter = 0;
        private void AddStaff()
        {
            if (!string.IsNullOrEmpty(this.SelectedStaff))
            {
                string[] arr = this.SelectedStaff.Split(':');
                if (arr.Length > 1)
                {

                    string userid = arr[1];
                    string staffname = arr[0];
                    StaffModel obj = new StaffModel();
                    obj.StaffName = staffname;
                    obj.StaffID = userid;
                    obj.Command = new DelegateCommand(RemoveStaff);
                    obj.Parameter = obj;
                    AddedStaff.Add(obj);
                    this.SelectedStaff = string.Empty;
                    counter++;
                    IUDFlag = "I";
                    this.StaffID = obj.StaffID.Trim();
                    IUD();
                }
            }

        }
    }

    public class SelectedStaff
    {
        public string StaffID { get; set; }
        public string StaffName { get; set; }
    }
}
