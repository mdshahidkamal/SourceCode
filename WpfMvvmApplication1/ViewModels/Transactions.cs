using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.ViewModels;
using HospitalManagementSystem.Helpers;
using System.Data;
using HospitalManagementSystem.DataAccess;
using System.Windows.Forms;
namespace IMS.ViewModels
{
    public class Transactions:TransactionsModel
    {
        public void IUDTransactions()
        {
            string sql = "exec  [IMS].[IUDTransactions]";
            List<string> lst = new List<string>();
            lst.Add(ID);
            lst.Add(IUDFlag);
            lst.Add(TransactionID);
            lst.Add(TransactionType);
            lst.Add(ProductID);
            lst.Add(Quantity);
            lst.Add(Amount);
            lst.Add(AccountEntry);
            lst.Add(ClientId);
            lst.Add(Common.LoggedInUserID);
            DataTable dtResult = DAL.Select(sql, lst, DAL.transaction);
            if (dtResult != null && dtResult.Rows.Count > 0)
            {
                this.ID = dtResult.Rows[0][0].ToString();
            }

        }

        public Transactions()
        {

        }
    }
    public class TransactionsModel : BaseViewModel
    {
        public string IUDFlag { get; set; }
        public string ID { get; set; }
        public string TransactionID { get; set; }
        public string TransactionType { get; set; }
        public string ProductID { get; set; }
        public string Quantity { get; set; }
        public string Amount { get; set; }
        public string AccountEntry { get; set; }
        public string ClientID { get; set; }
    }
}
