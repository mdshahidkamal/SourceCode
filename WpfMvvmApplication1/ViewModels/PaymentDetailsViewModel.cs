using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.ViewModels
{
    public class PaymentDetailsViewModel : FormEntity
    {
        public PaymentDetailsViewModel()
        {
            GetPaymentMode();
            GetPaymentType();
            this.PaymentDate = DateTime.Now;
        }
        public event delOnAddedItem OnAddedItem;

        public override System.Windows.Input.ICommand cmdAddNewPayment
        {
            get
            {
                return base.cmdAddNewPayment;
            }
        }
        private void GetPaymentType()
        {
            DataTable dt = Common.GetPaymentType();
            lstPaymentType = new ObservableCollection<StaticDataModel>();
            foreach (DataRow dr in dt.Rows)
            {
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID = int.Parse(dr[0].ToString());
                obj.StaticName = dr[1].ToString();
                lstPaymentType.Add(obj);
            }
        }
        private void GetPaymentMode()
        {
            DataTable dt = Common.GetPaymentMode();
            lstPaymentMode = new ObservableCollection<StaticDataModel>();
            foreach (DataRow dr in dt.Rows)
            {
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID = int.Parse(dr[0].ToString());
                obj.StaticName = dr[1].ToString();
                lstPaymentMode.Add(obj);
            }
        }


        public override bool ValidateBeforeAddPayment()
        {
            if (this.SelectedPaymentType == null)
                return false;
            if (this.SelectedPaymentMode == null)
                return false;
            if (this.PaymentDate > DateTime.Now)
                return false;
            if (this.PaymentAmount == null || this.PaymentAmount <= 0)
                return false;

            return true;
        }
        public override void AddNewPayment()
        {
            
            FormEntity obj = new FormEntity();
            obj.PaymentType = this.SelectedPaymentType.StaticName;
            obj.PaymentTypeId = this.SelectedPaymentType.StaticID.ToString();
            obj.PaymentMode = this.SelectedPaymentMode.StaticName;
            obj.PaymentModeId = this.SelectedPaymentMode.StaticID.ToString();
            obj.PaymentDate = this.PaymentDate;
            obj.PaymentAmount = this.PaymentAmount;
            obj.Comment1 = this.Comment1;
            OnAddedItem(obj);
            //lstPaymentDetail.Add(obj);
            //CalculateTotalPaidAmount();
            ClearPaymentItems();
        }
        void ClearPaymentItems()
        {
            this.SelectedPaymentType = null;
            this.SelectedPaymentMode = null;
            this.PaymentDate = DateTime.Now;
            this.PaymentAmount = 0;
            this.Comment = string.Empty;
        }
    }
}
