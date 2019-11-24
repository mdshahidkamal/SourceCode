using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HospitalManagementSystem.Helpers;
using System.Windows.Input;
using HospitalManagementSystem.DataAccess;

namespace HospitalManagementSystem.ViewModels
{
    public class SchoolExpenseViewModelEntity : StudentPaymentViewModelEntity
    {
        private ObservableCollection<StaticDataModel> _lstExpenses;
        public ObservableCollection<StaticDataModel> lstExpenses
        {
            get { return _lstExpenses; }
            set
            {
                if (value != _lstExpenses)
                {
                    _lstExpenses = value;
                    RaisePropertyChanged(() => lstExpenses);
                }
            }
        }
        private StaticDataModel _SelectedExpense;
        public StaticDataModel SelectedExpense
        {
            get { return _SelectedExpense; }
            set
            {
                if (value != _SelectedExpense)
                {
                    _SelectedExpense = value;
                    RaisePropertyChanged(() => SelectedExpense);
                }
            }
        }
        private DateTime _ExpenseDate;
        public DateTime ExpenseDate
        {
            get { return _ExpenseDate; }
            set
            {
                if (value != _ExpenseDate)
                {
                    _ExpenseDate = value;
                    RaisePropertyChanged(() => ExpenseDate);
                }
            }
        }
        private DateTime _ExpenseDateSearch;
        public DateTime ExpenseDateSearch
        {
            get { return _ExpenseDateSearch; }
            set
            {
                if (value != _ExpenseDateSearch)
                {
                    _ExpenseDateSearch = value;
                    RaisePropertyChanged(() => ExpenseDateSearch);
                }
            }
        }
        private ObservableCollection<SchoolExpenseViewModelEntity> _lstExpenseDetails;
        public ObservableCollection<SchoolExpenseViewModelEntity> lstExpenseDetails
        {
            get { return _lstExpenseDetails; }
            set
            {
                if (value != _lstExpenseDetails)
                {
                    _lstExpenseDetails = value;
                    RaisePropertyChanged(() => lstExpenseDetails);
                }
            }
        }

        private string _ExpenseDateStr;
        public string ExpenseDateStr
        {
            get { return _ExpenseDateStr; }
            set
            {
                if (value != _ExpenseDateStr)
                {
                    _ExpenseDateStr = value;
                    RaisePropertyChanged(() => ExpenseDateStr);
                }
            }
        }



    }
    public class SchoolExpenseModel : SchoolExpenseViewModelEntity
    {
        public ICommand cmdsave { get { return new DelegateCommand(IUD, canSaveData); } }
        public ICommand cmdSearch { get { return new DelegateCommand(Search, CanSearch); } }

        private bool CanSearch()
        {
            return true;
        }

        private void Search()
        {
            ExpenseDateStr = ExpenseDateSearch.ToString("yyyy-MM-dd");
            GetExpenseDetails();
        }

        private void IUD()
        {

            string sql = "exec [SMS].[IUDPaymentDetails]";
            List<string> lst = new List<string>();
            this.EntityID = SelectedExpense.StaticID.ToString();
            this.EntityType = "Expense";
            this.PaymentType = SelectedExpense.StaticName.ToString();
            //SelectedFees.StaticID.ToString();
            this.TransType = "D";
            //this.PaymentExpenseDate = ExpenseDate;
            ExpenseDateStr = ExpenseDate.ToString("yyyy-MM-dd");
            lst.Add(ID);
            lst.Add(EntityID);
            lst.Add(EntityType);
            lst.Add(PaymentType);
            lst.Add(TransType);
            lst.Add(Amount);
            lst.Add(Comments);
            lst.Add(IUDFlag);
            lst.Add(Schoolid);
            lst.Add(AcademicYear);
            lst.Add(ModeofPayment);
            lst.Add(ChequeNo);
            lst.Add(BankBranchDetails);
            lst.Add(ExpenseDateStr);
            lst.Add(string.Empty);

            DataTable dtResult = DAL.Select(sql, lst);
            
            GetExpenseDetails();
            //GeneratePaymentReciept();
        }
        void GetExpenseDetails()
        {
            
            string sql = "exec [SMS].[GetExpensePaymentDetails] '" + ExpenseDateStr + "'," + this.Schoolid;
            DataTable SearchResult = DAL.Select(sql);
            FormFields();
            lstExpenseDetails = new ObservableCollection<SchoolExpenseViewModelEntity>();

            foreach (DataRow dr in SearchResult.Rows)
            {
                SchoolExpenseViewModelEntity obj = new SchoolExpenseViewModelEntity();
                obj.ID = dr["ID"].ToString();
                obj.EntityID = dr["EntityID"].ToString();
                obj.EntityType = dr["EntityType"].ToString();
                obj.PaymentType = dr["PaymentType"].ToString();
                obj.TransType = dr["TransType"].ToString();
                obj.Amount = dr["Amount"].ToString();
                obj.Comments = dr["Comments"].ToString();
                obj.AcademicYear = dr["AcademicYear"].ToString();
                obj.ExpenseDateStr= Convert.ToString(dr["ExpenseDate"]);
                //obj.ModeofPayment = dr["ModeofPayment"].ToString();
                //obj.ChequeNo = dr["chequeno"].ToString();
                //obj.BankBranchDetails = dr["BankBranchDetails"].ToString();
                lstExpenseDetails.Add(obj);
            }


        }


        void FormFields()
        {
            this.SelectedExpense = lstExpenses.FirstOrDefault();
            this.Amount = string.Empty;
            this.Comments = string.Empty;
            this.ExpenseDate = DateTime.Now;

        }

        private bool canSaveData()
        {
            return true;
        }

        public SchoolExpenseModel()
        {
            GetExpenseMaster();
            this.ExpenseDate = DateTime.Now;
            this.ExpenseDateSearch = DateTime.Now;
            AcademicYear = Common.AcademicYear;
        }
        public void GetExpenseMaster()
        {

            lstExpenses = new ObservableCollection<StaticDataModel>();
            DataTable dt = Common.GetExpenseMaster();

            foreach (DataRow dr in dt.Rows)
            {
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID = Convert.ToInt32(dr[0]);
                obj.StaticName = dr[1].ToString();

                lstExpenses.Add(obj);
            }
            SelectedExpense = lstExpenses.FirstOrDefault();
        }
    }
}
