using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data;
using System.Collections.ObjectModel;

namespace HospitalManagementSystem.ViewModels
{
    public class ChartsViewModelEntity : BaseViewModel
    {
        private string _SchoolID;
        public string SchoolID
        {
            get { return _SchoolID; }
            set
            {
                if (value != _SchoolID)
                {
                    _SchoolID = value;
                    RaisePropertyChanged(() => SchoolID);
                }
            }
        }
        private string _AcademicYear;
        public string AcademicYear
        {
            get { return _AcademicYear; }
            set
            {
                if (value != _AcademicYear)
                {
                    _AcademicYear = value;
                    RaisePropertyChanged(() => AcademicYear);
                }
            }
        }

        private ObservableCollection<KeyValuePair<string, int>> _lstIncome;
        public ObservableCollection<KeyValuePair<string, int>> lstIncome
        {
            get { return _lstIncome; }
            set
            {
                if (value != _lstIncome)
                {
                    _lstIncome = value;
                    RaisePropertyChanged(() => lstIncome);
                }
            }
        }

        private ObservableCollection<KeyValuePair<string, int>> _lstExpense;
        public ObservableCollection<KeyValuePair<string, int>> lstExpense
        {
            get { return _lstExpense; }
            set
            {
                if (value != _lstExpense)
                {
                    _lstExpense = value;
                    RaisePropertyChanged(() => lstExpense);
                }
            }
        }
        private ObservableCollection<ObservableCollection<KeyValuePair<string, int>>> _dataSourceObservableCollection;
        public ObservableCollection<ObservableCollection<KeyValuePair<string, int>>> dataSourceObservableCollection
        {
            get { return _dataSourceObservableCollection; }
            set
            {
                if (value != _dataSourceObservableCollection)
                {
                    _dataSourceObservableCollection = value;
                    RaisePropertyChanged(() => dataSourceObservableCollection);
                }
            }
        }
        private string _ChartOneName;
        public string ChartOneName
        {
            get { return _ChartOneName; }
            set
            {
                if (value != _ChartOneName)
                {
                    _ChartOneName = value;
                    RaisePropertyChanged(() => ChartOneName);
                }
            }
        }
        private string _ChartTwoName;
        public string ChartTwoName
        {
            get { return _ChartTwoName; }
            set
            {
                if (value != _ChartTwoName)
                {
                    _ChartTwoName = value;
                    RaisePropertyChanged(() => ChartTwoName);
                }
            }
        }

        private ObservableCollection<StaticDataModel> _lstAcademicYear;
        public ObservableCollection<StaticDataModel> lstAcademicYear
        {
            get { return _lstAcademicYear; }
            set
            {
                if (value != _lstAcademicYear)
                {
                    _lstAcademicYear = value;
                    RaisePropertyChanged(() => lstAcademicYear);
                }
            }
        }
        private StaticDataModel _SelectedAcademicYear;
        public StaticDataModel SelectedAcademicYear
        {
            get { return _SelectedAcademicYear; }
            set
            {
                if (value != _SelectedAcademicYear)
                {
                    _SelectedAcademicYear = value;
                    RaisePropertyChanged(() => SelectedAcademicYear);
                }
            }
        }
        private ObservableCollection<KeyValuePair<string, int>> _lstExpenseData;
        public ObservableCollection<KeyValuePair<string, int>> lstExpenseData
        {
            get { return _lstExpenseData; }
            set
            {
                if (value != _lstExpenseData)
                {
                    _lstExpenseData = value;
                    RaisePropertyChanged(() => lstExpenseData);
                }
            }
        }


    }
    public class ChartViewModel : ChartsViewModelEntity
    {
        public ICommand cmdSearch { get { return new DelegateCommand(Search, canSearch); } }

        private bool canSearch()
        {
            return true;
        }

        public void Search()
        {
            dataSourceObservableCollection = new ObservableCollection<ObservableCollection<KeyValuePair<string, int>>>();
            DataTable dtResult = DataAccess.DAL.Select(string.Format("exec GetPNLChart '{0}',{1}", this.SelectedAcademicYear.StaticName, base.Schoolid));
            string Month = string.Empty;
            int Amount = 0;
            string transtype = string.Empty;
            lstIncome = new ObservableCollection<KeyValuePair<string, int>>();
            lstExpense = new ObservableCollection<KeyValuePair<string, int>>();
            this.ChartOneName = "Income";
            this.ChartTwoName = "Expense";
            foreach (DataRow dr in dtResult.Rows)
            {
                transtype = dr[3].ToString();
                if (transtype == "C")
                {
                    Month = dr[1].ToString();
                    Amount = Convert.ToInt32(dr[0]);
                    lstIncome.Add(new KeyValuePair<string, int>(Month, Amount));
                }
                if (transtype == "D")
                {
                    Month = dr[1].ToString();
                    Amount = Convert.ToInt32(dr[0]);
                    lstExpense.Add(new KeyValuePair<string, int>(Month, Amount));
                }

            }

            dtResult = DataAccess.DAL.Select(string.Format("exec  sms.ExpenseChart '{0}',{1}", this.SelectedAcademicYear.StaticName, base.Schoolid));
            lstExpenseData = new ObservableCollection<KeyValuePair<string, int>>();
            Amount = 0;
            string paymenttype = string.Empty;
            foreach (DataRow dr in dtResult.Rows)
            {

                paymenttype = dr[3].ToString();
                Amount = Convert.ToInt32(dr[0]);
                lstExpenseData.Add(new KeyValuePair<string, int>(paymenttype, Amount));

            }

        }
        void GetAcademicYear()
        {
            DataTable dt = Common.GetAcademicYear();
            lstAcademicYear = new ObservableCollection<StaticDataModel>();
            foreach (DataRow dr in dt.Rows)
            {
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID = int.Parse(dr[0].ToString());
                obj.StaticName = dr[1].ToString();
                lstAcademicYear.Add(obj);
            }

            this.SelectedAcademicYear = lstAcademicYear.FirstOrDefault();

        }
        public ChartViewModel()
        {
            GetAcademicYear();
        }
    }
}
