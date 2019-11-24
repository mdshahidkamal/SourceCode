using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.Models;

using System.Data;
namespace HospitalManagementSystem.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {



        #region Properties

        #region MyDateTime

        private DateTime _myDateTime;
        public DateTime MyDateTime
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

        #endregion

        #region PersonsCollection

        private ObservableCollection<Person> _personsCollection;
        public ObservableCollection<Person> PersonsCollection
        {
            get { return _personsCollection; }
            set
            {
                if (_personsCollection != value)
                {
                    _personsCollection = value;
                    RaisePropertyChanged(() => PersonsCollection);
                }
            }
        }

        private DataTable _dsresult;
        public DataTable dsResult
        {
            get { return _dsresult; }
            set
            {
                if (_dsresult != value)
                {
                    _dsresult = value;
                    RaisePropertyChanged(() => dsResult);
                }
            }
        }

        #endregion

        #endregion

        #region Commands

        public ICommand RefreshDateCommand { get { return new DelegateCommand(OnRefreshDate); } }
        public ICommand RefreshPersonsCommand { get { return new DelegateCommand(OnRefreshPersons); } }
        public ICommand DoNothingCommand { get { return new DelegateCommand(OnDoNothing, CanExecuteDoNothing); } }

        #endregion

        #region Ctor
        Helpers.Logger logger;
        public MainWindowViewModel()
        {
            logger = Helpers.Logger.IntializeLogger();
            RandomizeData();

        }
        #endregion

        #region Command Handlers

        private void OnRefreshDate()
        {
            MyDateTime = DateTime.Now;
        }

        private void OnRefreshPersons()
        {
            RandomizeData();
        }

        private void OnDoNothing()
        {
        }

        private bool CanExecuteDoNothing()
        {
            return false;
        }

        #endregion
        

        private void RandomizeData()
        {

            dsResult = DataAccess.DAL.Select("select * from Patients");


            PersonsCollection = new ObservableCollection<Person>();

            //for (var i = 0; i < 10; i++)
            foreach (DataRow dr in dsResult.Rows)
            {
                PersonsCollection.Add(new Person(
                    //RandomHelper.RandomString(10, true),
                    Convert.ToString(dr["PatientName"]),
                    RandomHelper.RandomInt(1, 43),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomNumber(50, 180, 1),
                    RandomHelper.RandomDate(new DateTime(1980, 1, 1), DateTime.Now),
                    RandomHelper.RandomColor()
                    ));
            }
        }
    }
}