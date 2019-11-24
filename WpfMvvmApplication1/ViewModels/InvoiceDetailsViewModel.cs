using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Controls;
using System.Configuration;
using HospitalManagementSystem.ViewModels;
using IMS.Views;


namespace IMS.ViewModels
{
    public class InvoiceDetailsViewModel : FormEntity
    {
        public override ICommand cmdSearch { get { return new DelegateCommand(Search, canSearch); } }
        public override ICommand cmdsave { get { return new DelegateCommand(IUD, canSaveData); } }
        public override ICommand cmdAddNew { get { return new DelegateCommand(AddNew, ValidateBeforeAdd); } }
        
        public override ICommand cmdAddNewPayment { get { return new DelegateCommand(AddNewPayment, ValidateBeforeAddPayment); } }

        public override ICommand cmdOpenPopWindow
        {
            get
            {
                return base.cmdOpenPopWindow;
            }
        }
        public override void OpenPopWindow(object param)
        {
            
            if ((string)param == "Particular")
            {
                ParticularViewModel objv = new ParticularViewModel("Invoice");
                ParticularDetails objpart = new ParticularDetails(objv);
                objv.OnAddedItem += objv_OnAddedItem;
                objpart.ShowDialog();
            }
            else if ((string)param == "Payment")
            {
                PaymentDetailsViewModel objv = new PaymentDetailsViewModel();
                PaymentDetails objpart = new PaymentDetails(objv);
                objv.OnAddedItem += OnPaymentAddedItem;
                objpart.ShowDialog();
            }
            base.OpenPopWindow(param);
        }

        private void OnPaymentAddedItem(FormEntity o)
        {
            if (lstPaymentDetail == null)
                lstPaymentDetail = new ObservableCollection<FormEntity>();
            lstPaymentDetail.Add(o);
            CalculateTotalPaidAmount();
        }
        public override bool CanOpenPopWindow()
        {
            if (string.IsNullOrEmpty(this.InvoiceNo))
                return false;
            else if (this.SelectedSuppliers == null)
                return false;
            else if (this.InvoiceDate > DateTime.Now)
                return false;

            return base.CanOpenPopWindow();
        }

        void objv_OnAddedItem(FormEntity o)
        {
            if (lstParticulars == null)
                lstParticulars = new ObservableCollection<FormEntity>();
            lstParticulars.Add(o);
            CalculateTotalofTotal();
        }
       
       
        public void RemovePayment(FormEntity o)
        {
            lstPaymentDetail.Remove(o);
            CalculateTotalPaidAmount();
        }
        public void SearchPayments(string invoiceID)
        {
            List<string> lst = new List<string>();
            lst.Add(invoiceID);
            string sql = "exec IMS.GetPaymentDetails";
            SearchResult = DAL.Select(sql, lst);
            if (SearchResult == null || SearchResult.Rows.Count == 0)
            {
                return;
            }
            if (lstPaymentDetail == null)
            {
                lstPaymentDetail = new ObservableCollection<FormEntity>();
            }
            lstPaymentDetail.Clear();
            foreach (DataRow dr in SearchResult.Rows)
            {
                FormEntity obj = new FormEntity();

                obj.PaymentAmount = Convert.ToDouble(dr["PaymentAmount"]);
                obj.PaymentDate = Convert.ToDateTime(dr["PaymentDate"]);
                obj.PaymentMode = dr["PaymentMode"].ToString();
                obj.PaymentModeId = dr["PaymentModeId"].ToString();
                obj.PaymentType = dr["PaymentType"].ToString();
                obj.PaymentTypeId = dr["PaymentTypeId"].ToString();
                obj.Comment1 = dr["Comment1"].ToString();
                lstPaymentDetail.Add(obj);
                CalculateTotalPaidAmount();
            }
        }


        public override void AddNew()
        {
            ClearFormField();
            this.ShowHideInvoiceDetails = true;
        }

        public InvoiceDetailsViewModel()
        {
            GetSuppliers();
            this.InvoiceDate = DateTime.Now;
            this.dtFromDate = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));
            this.dtToDate = DateTime.Now;
            this.PaymentDate = DateTime.Now;
            this.IUDFlag = "I";
        }
        private void GetSuppliers()
        {
            DataTable dt = Common.GetSuppliers();
            lstSuppliers = new ObservableCollection<StaticDataModel>();
            foreach (DataRow dr in dt.Rows)
            {
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID = int.Parse(dr[0].ToString());
                obj.StaticName = dr[1].ToString();
                lstSuppliers.Add(obj);
            }
        }






        public AutoCompleteFilterPredicate<object> ProductFilter
        {
            get
            {
                return (searchText, obj) =>
                    (obj as FormEntity).ProductName.ToUpper().Contains(searchText);
            }
        }
        public override bool canSearch()
        {
            return true;
        }
        public override void Search(string invoiceID)
        {

            List<string> lst = new List<string>();
            lst.Add(invoiceID);
            lst.Add(string.Empty);
            lst.Add(string.Empty);
            lst.Add(string.Empty);
            string sql = "exec [IMS].[GetInvoiceDetails]";
            SearchResult = DAL.Select(sql, lst);
            if (SearchResult == null || SearchResult.Rows.Count == 0)
            {
                return;
            }
            if (lstParticulars == null)
            {
                lstParticulars = new ObservableCollection<FormEntity>();
            }
            lstParticulars.Clear();

            this.IUDFlag = "U";
            int result = 0;
            this.InvoiceID = SearchResult.Rows[0]["invoiceID"].ToString();
            this.InvoiceNo = SearchResult.Rows[0]["InvoiceNo"].ToString();
            this.InvoiceDate = Convert.ToDateTime(SearchResult.Rows[0]["InvoiceDate"]);
            this.Discount = Convert.ToDouble(SearchResult.Rows[0]["Discount"]);


            //obj.InvoiceID = dr["invoiceID"].ToString();
            //obj.InvoiceNo = dr["InvoiceNo"].ToString();
            //obj.InvoiceDate = Convert.ToDateTime(dr["InvoiceDate"]);

            int.TryParse(SearchResult.Rows[0]["SupplierID"].ToString(), out result);
            this.SelectedSuppliers = lstSuppliers.First(x => x.StaticID == result);

            //obj.SupplierID = dr["SupplierID"].ToString();
            //obj.SupplierName = dr["Supplier"].ToString();

            foreach (DataRow dr in SearchResult.Rows)
            {

                FormEntity obj = new FormEntity();

                //int.TryParse(dr["ProductId"].ToString(), out result);
                //this.SelectedProduct = lstProducts.First(x => x.ProductId == result.ToString());

                obj.ProductName = dr["Product"].ToString(); ;
                obj.ProductId = dr["ProductId"].ToString(); ;

                obj.Quantity = dr["Quantity"].ToString();
                obj.Rate = dr["Rate"].ToString();

                //int.TryParse(dr["Per"].ToString(), out result);
                //this.SelectedPer = lstPer.First(x => x.StaticID == result);

                obj.Per = dr["Per"].ToString();
                obj.PerName = dr["PerName"].ToString();

                obj.Amount = Convert.ToDouble(dr["Amount"]);
                obj.OtherCharges = Convert.ToDouble(dr["OtherCharges"]);

                obj.TaxableAmount = Convert.ToDouble(dr["TaxableAmount"]);
                obj.Comment = (dr["Comments"].ToString());
                obj.HSNCode = (dr["HSNCode"].ToString());
                obj.CGST = Convert.ToDouble(dr["CGST"]);
                obj.IGST = Convert.ToDouble(dr["IGST"]);
                obj.SGST = Convert.ToDouble(dr["SGST"]);
                obj.TotalTax = Convert.ToDouble(dr["TotalTax"]);
                obj.TotalAmount = Convert.ToDouble(dr["TotalAmount"]);

                lstParticulars.Add(obj);
                CalculateTotalofTotal();

            }
            SearchPayments(this.InvoiceID);
        }
        public override void Search()
        {
            try
            {

                {


                    List<string> lst = new List<string>();
                    lst.Add(string.Empty);
                    lst.Add(this.InvoiceNo);
                    lst.Add(this.dtFromDate.ToString("yyyyMMdd"));
                    lst.Add(this.dtToDate.ToString("yyyyMMdd"));
                    string sql = "exec [IMS].[GetInvoiceDetails]";
                    SearchResult = DAL.Select(sql, lst);
                    if (SearchResult == null || SearchResult.Rows.Count == 0)
                    {
                        return;
                    }
                    lstInvoiceDetails = new ObservableCollection<FormEntity>();
                    foreach (DataRow dr in SearchResult.Rows)
                    {
                        FormEntity obj = new FormEntity();
                        obj.InvoiceID = dr["invoiceID"].ToString();
                        obj.InvoiceNo = dr["InvoiceNo"].ToString();
                        obj.InvoiceDate = Convert.ToDateTime(dr["InvoiceDate"]);
                        obj.SupplierName = dr["Supplier"].ToString();

                        obj.TotalAmount = Convert.ToDouble(dr["TotalAmount"]);
                        obj.Discount = Convert.ToDouble(dr["Discount"]);
                        obj.TotalofTotalAmount = Convert.ToDouble(dr["AmountPayable"]);
                        obj.TotalofTotalPaidAmount = Convert.ToDouble(dr["AmountPaid"]);
                        obj.TotalOutStandingAmount = Convert.ToDouble(dr["OutStandingAmount"]);
                        lstInvoiceDetails.Add(obj);
                    }
                }

            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }

        }



        public override bool canSaveData()
        {
            if (string.IsNullOrEmpty(this.InvoiceNo))
                return false;
            if (this.InvoiceDate > DateTime.Now)
                return false;

            if (this.SelectedSuppliers == null)
                return false;
            if (this.lstParticulars == null || this.lstParticulars.Count == 0)
                return false;
            return true;
        }

        public override void RemoveParticular(FormEntity o)
        {
            if (lstParticulars == null)
            {
                return;
            }
            lstParticulars.Remove(o);
            CalculateTotalofTotal();
        }
       
      

        public override void IUD()
        {


            string sql = "exec [IMS].[IUDInvoice]";
            List<string> lst = new List<string>();
            lst.Add(this.InvoiceID);
            lst.Add(this.IUDFlag);
            lst.Add(this.InvoiceNo);
            lst.Add(this.InvoiceDate.ToString("yyyyMMdd"));
            lst.Add(this.SelectedSuppliers.StaticID.ToString());
            lst.Add(this.Comment);
            lst.Add(this.Discount.ToString());
            lst.Add(Common.LoggedInUserID);
            DAL.StartTransaction();
            DataTable dtResult = DAL.Select(sql, lst, DAL.transaction);//INsert Invoice
            if (dtResult != null && dtResult.Rows.Count > 0)
            {
                this.InvoiceID = dtResult.Rows[0][0].ToString();


                if (lstParticulars != null && lstParticulars.Count > 0)
                {
                    sql = "exec IMS.DeleteInvoiceDetails";
                    lst = new List<string>();
                    lst.Add(this.InvoiceID);
                    dtResult = DAL.Select(sql, lst, DAL.transaction);// Delete Invoice Details

                    foreach (FormEntity en in lstParticulars)
                    {
                        sql = "exec [IMS].[IUDInvoiceDetails]";
                        lst = new List<string>();
                        lst.Add(this.InvoiceDetailID);
                        lst.Add(this.InvoiceID);
                        lst.Add(this.IUDFlag);
                        lst.Add(en.ProductId);
                        lst.Add(en.Quantity);
                        lst.Add(en.Rate);
                        lst.Add(en.Per);
                        lst.Add(en.Amount.ToString());
                        lst.Add(en.OtherCharges.ToString());
                        lst.Add(en.HSNCode);
                        lst.Add(en.CGST.ToString());
                        lst.Add(en.SGST.ToString());
                        lst.Add(en.IGST.ToString());
                        lst.Add(en.TotalTax.ToString());
                        lst.Add(en.TaxableAmount.ToString());
                        lst.Add(en.TotalAmount.ToString());
                        lst.Add(Common.LoggedInUserID);

                        dtResult = DAL.Select(sql, lst, DAL.transaction);// Invoice Details

                        if (dtResult != null && dtResult.Rows.Count > 0)
                        {
                            this.InvoiceDetailID = dtResult.Rows[0][0].ToString();

                        }
                    }


                }


                sql = "exec [IMS].[DeletePayment]";
                lst = new List<string>();
                lst.Add(this.InvoiceID);
                dtResult = DAL.Select(sql, lst, DAL.transaction);// Delete Invoice Details

                sql = "exec ims.DeleteTransaction";
                lst = new List<string>();
                lst.Add(this.InvoiceID);
                dtResult = DAL.Select(sql, lst, DAL.transaction);// Delete Invoice Details

                if (lstPaymentDetail != null && lstPaymentDetail.Count > 0)
                {
                    foreach (FormEntity en in lstPaymentDetail)
                    {
                        sql = "exec [IMS].[IUDPayment]";
                        lst = new List<string>();
                        lst.Add(this.IUDFlag);
                        lst.Add(this.InvoiceID);
                        lst.Add(en.PaymentTypeId);
                        lst.Add(en.PaymentModeId);
                        lst.Add(en.PaymentDate.ToString("yyyyMMdd"));
                        lst.Add(en.PaymentAmount.ToString());
                        lst.Add(en.Comment1);
                        lst.Add(Common.LoggedInUserID);

                        dtResult = DAL.Select(sql, lst, DAL.transaction);// Invoice Details
                        if (dtResult != null && dtResult.Rows.Count > 0)
                        {

                            this.PaymentId = dtResult.Rows[0][0].ToString();

                            Transactions objTransaction = new Transactions();
                            objTransaction.IUDFlag = this.IUDFlag;
                            objTransaction.TransactionID = this.InvoiceID;
                            objTransaction.TransactionType = "PD";
                            objTransaction.ProductID = string.Empty;
                            objTransaction.Quantity = string.Empty;
                            objTransaction.Amount = en.PaymentAmount.ToString();
                            objTransaction.AccountEntry = "D";
                            objTransaction.IUDTransactions();// Transaction.
                            if (Convert.ToInt32(objTransaction.ID) > 0)
                            {
                                //MessageBox.Show("Data Saved Successfully");
                                //this.ShowHideInvoiceDetails = false;
                                //ClearFormField();
                                //Search();
                            }

                        }
                    }




                }

                MessageBox.Show("Data Saved Successfully");

                ClearFormField();

            }
            DAL.EndTransaction();


        }
      
       
        void ClearFormField()
        {

            this.IUDFlag = "I";
            this.InvoiceNo = string.Empty;
            this.InvoiceDate = DateTime.Now;
            this.SelectedSuppliers = null;
            this.Discount = 0;
            this.lstParticulars = null;
            this.Comment = string.Empty;
            this.TotalofTotalAmount = 0;
            this.lstPaymentDetail = null;
            this.Comment1 = string.Empty;
            this.TotalofTotalPaidAmount = 0;
            this.TotalOutStandingAmount = 0;
        }


        private DataTable _SearchResult;
        public DataTable SearchResult { get { return _SearchResult; } set { if (value != _SearchResult) { _SearchResult = value; RaisePropertyChanged(() => SearchResult); } } }

        private ObservableCollection<FormEntity> _lstInvoiceDetails;
        public ObservableCollection<FormEntity> lstInvoiceDetails { get { return _lstInvoiceDetails; } set { if (value != _lstInvoiceDetails) { _lstInvoiceDetails = value; RaisePropertyChanged(() => lstInvoiceDetails); } } }

     
        private ObservableCollection<FormEntity> _lstPaymentDetail;
        public ObservableCollection<FormEntity> lstPaymentDetail
        {
            get { return _lstPaymentDetail; }
            set
            {
                if (value != _lstPaymentDetail)
                {
                    _lstPaymentDetail = value;
                    RaisePropertyChanged(() => lstPaymentDetail);
                }
            }
        }




        public override double GetDoubleValue(string v)
        {
            double d = 0;
            double.TryParse(v, out d);
            return d;
        }
        public override void CalculateTotalofTotal()
        {
            TotalofTotalAmount = 0;
            TotalInvoiceAmount = 0;
            TotalInvoiceTax = 0;
            TotalInvoiceTaxableAmount = 0;
            if (lstParticulars != null && lstParticulars.Count > 0)
            {
                foreach (FormEntity en in lstParticulars)
                {

                    TotalInvoiceAmount += en.Amount;
                    TotalInvoiceTax += en.TotalTax;
                }

                double? discount = this.Discount;
                if (this.Discount == null)
                    discount = 0;
                TotalInvoiceTaxableAmount = TotalInvoiceAmount - discount; ;
                TotalofTotalAmount = TotalInvoiceTaxableAmount + TotalInvoiceTax;

                CalculateTotalPaidAmount();
            }
        }
        public override void CalculateTotalPaidAmount()
        {
            TotalofTotalPaidAmount = 0;
            if (lstPaymentDetail != null && lstPaymentDetail.Count > 0)
            {
                foreach (FormEntity en in lstPaymentDetail)
                {
                    TotalofTotalPaidAmount += en.PaymentAmount;
                }
            }

            TotalOutStandingAmount = TotalofTotalAmount - TotalofTotalPaidAmount;
        }



    }


}
