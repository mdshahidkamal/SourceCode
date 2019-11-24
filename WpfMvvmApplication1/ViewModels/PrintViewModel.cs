using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.ViewModels
{
    public class PrintViewModel : BaseViewModel
    {
        PatientDetailsViewModel obj = null;
        public PrintViewModel()
        {

        }
        public PrintViewModel(PatientDetailsViewModel objviewmodel)
        {
            obj = objviewmodel;
            this.PatientName = obj.PatientName;
            this.Age = obj.Age;
            this.Gender = obj.Gender;
            this.ContactNumber = obj.ContactDetails;
            this.Address = obj.Address;
            this.DoctorsName = obj.DoctorName;
            this.Amount = obj.Amount;
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
        private string _Gender;
        public string Gender
        {
            get { return _Gender; }
            set
            {
                if (value != _Gender)
                {
                    _Gender = value;
                    RaisePropertyChanged(() => Gender);
                }
            }
        }
        private string _ContactNumber;
        public string ContactNumber
        {
            get { return _ContactNumber; }
            set
            {
                if (value != _ContactNumber)
                {
                    _ContactNumber = value;
                    RaisePropertyChanged(() => ContactNumber);
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
        private string _DoctorsName;
        public string DoctorsName
        {
            get { return _DoctorsName; }
            set
            {
                if (value != _DoctorsName)
                {
                    _DoctorsName = value;
                    RaisePropertyChanged(() => DoctorsName);
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
        
        
        
        

    }
}
