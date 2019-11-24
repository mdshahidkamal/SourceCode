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
    public class StaffSubjectMappingViewModelEntity : BaseViewModel
    {
        private string _SSMID; public string SSMID { get { return _SSMID; } set { if (value != _SSMID) { _SSMID = value; RaisePropertyChanged(() => SSMID); } } }
        private string _SubjectID; public string SubjectID { get { return _SubjectID; } set { if (value != _SubjectID) { _SubjectID = value; RaisePropertyChanged(() => SubjectID); } } }
        private string _StaffID; public string StaffID { get { return _StaffID; } set { if (value != _StaffID) { _StaffID = value; RaisePropertyChanged(() => StaffID); } } }
        private string _IUDFlag; public string IUDFlag { get { return _IUDFlag; } set { if (value != _IUDFlag) { _IUDFlag = value; RaisePropertyChanged(() => IUDFlag); } } }
        private ObservableCollection<SubjectModel> _AddedSubject;
        public ObservableCollection<SubjectModel> AddedSubject
        {
            get { return _AddedSubject; }
            set
            {
                if (value != _AddedSubject)
                {
                    _AddedSubject = value;
                    RaisePropertyChanged(() => AddedSubject);
                }
            }
        }
        private string _SelectedStaff;
        public  string SelectedStaff
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
        private string _SelectedSubject; public virtual string SelectedSubject { get { return _SelectedSubject; } set { if (value != _SelectedSubject) { _SelectedSubject = value; RaisePropertyChanged(() => _SelectedSubject); } } }
    }
    public class StaffSubjectMappingViewModel : StaffSubjectMappingViewModelEntity
    {
        public ICommand cmdAddSubject { get { return new DelegateCommand(AddSubject, canAddSubject); } }

        public StaffSubjectMappingViewModel()
        {
            Common.GetStaff();
            Common.GetSubjects();
            AddedSubject = new ObservableCollection<SubjectModel>();
        }
        private bool canAddSubject()
        {
            return true;
            //throw new NotImplementedException();
        }

        private void AddSubject()
        {
            //if (!string.IsNullOrEmpty(this.SelectedSubject))
            {

                SubjectModel obj = new SubjectModel();
                obj.SubjectName = this.SelectedSubject;
                obj.Command = new DelegateCommand(RemoveSubject);
                obj.Parameter = obj;
                AddedSubject.Add(obj);
                // this.SelectedStaff = string.Empty;
                IUDFlag = "I";
                IUD();

            }
        }
        public ICommand cmdRemove { get { return new DelegateCommand(RemoveSubject, CanRemoveSubject); } }

        private bool CanRemoveSubject()
        {
            return true;
        }

        private void RemoveSubject()
        {
            return;
        }
        public ICommand cmdsave { get { return new DelegateCommand(IUD, canSave); } }

        private bool canSave()
        {
            return true;
        }
     
        private void IUD()
        {
            string sql = "exec [SMS].[IUDStaffSubjectMapping]";
            List<string> lst = new List<string>();
            string[] arr = this.SelectedStaff.Split(':');
            if (arr.Length > 1)
            {

                string userid = arr[1];
                string staffname = arr[0];
                lst.Add(userid);
                lst.Add(this.SelectedSubject);
                lst.Add(Schoolid);
                lst.Add(IUDFlag);
                DAL.Execute(sql, lst);
                lst.Clear();
            }

        }

    }
}
