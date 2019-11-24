using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace HospitalManagementSystem.ViewModels
{
    public class StudentClassMappingViewModelEntity : BaseViewModel
    {
        private string _STUCMID; public string STUCMID { get { return _STUCMID; } set { if (value != _STUCMID) { _STUCMID = value; RaisePropertyChanged(() => STUCMID); } } }
        private string _StudentID; public string StudentID { get { return _StudentID; } set { if (value != _StudentID) { _StudentID = value; RaisePropertyChanged(() => StudentID); } } }
        private string _ClassRoomID; public string ClassRoomID { get { return _ClassRoomID; } set { if (value != _ClassRoomID) { _ClassRoomID = value; RaisePropertyChanged(() => ClassRoomID); } } }
        private string _SchoolID; public string SchoolID { get { return _SchoolID; } set { if (value != _SchoolID) { _SchoolID = value; RaisePropertyChanged(() => SchoolID); } } }
        

    }
    public class StudentClassMappingViewModel : StudentClassMappingViewModelEntity
    {
        public StudentClassMappingViewModel()
        {
           Common.GetStudents();
           GetClassRoom();
        }
        public ICommand cmdsave { get { return new DelegateCommand(IUD, canSaveData); } }

        private void IUD()
        {

        }

       
        private bool canSaveData()
        {
            return true;
        }
        public new  DataTable GetClassRoom()
        {
            DataTable dt= Common.GetClassRoom();
            //lstClassRoom = new ObservableCollection<StaticDataModel>();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    lstClassRoom.Add(dr[0].ToString());
            //}
            //SelectedClassRoom = "--Select--";
            return dt;
        }
        
    }
}
