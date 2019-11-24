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
using HospitalManagementSystem.Views;

namespace IMS.ViewModels
{
    public class BillingViewModel : FormEntity
    {

        public override ICommand cmdSearch
        {
            get
            {
                return base.cmdSearch;
            }
        }

        public override ICommand cmdsave
        {
            get
            {
                return base.cmdsave;
            }
        }

        public override ICommand cmdOpenPopWindow
        {
            get
            {
                return base.cmdOpenPopWindow;
            }
        }
        public override void OpenPopWindow(object param)
        {

            ParticularViewModel objv = new ParticularViewModel("Bill");
            ParticularDetails objpart = new ParticularDetails(objv);
            objv.OnAddedItem += objv_OnAddedItem;
            objpart.ShowDialog();
            base.OpenPopWindow(param);
        }
        public override bool CanOpenPopWindow()
        {

            return base.CanOpenPopWindow();
        }
        void objv_OnAddedItem(FormEntity o)
        {
            if (lstParticulars == null)
                lstParticulars = new ObservableCollection<FormEntity>();

            double count = 0;
            double AddedCount = 0;

            count = GetAvailableProductCount(o.ProductId);

            

           
                foreach (FormEntity f in lstParticulars)
                {
                    //AddedCount += Convert.ToDouble(f.Quantity);
                }
                var cnt = lstParticulars.Count(x => x.ProductId == o.ProductId);
                AddedCount = Convert.ToDouble(o.Quantity);
                if (cnt > 0)
                {
                    AddedCount = AddedCount + cnt;
                }
                
            

            

            if ((count - AddedCount) < 0)
            {
                MessageBox.Show("Added Count " + AddedCount + " exceed the Total Count " + count.ToString());
            }
            else
            {
                lstParticulars.Add(o);
                CalculateTotalofTotal();

            }


        }
        private double GetAvailableProductCount(string productid)
        {
            double count = 0;
            string sql = " [IMS].[GetAvailableProductCount] " + productid + "," + Common.Clientid;
            DataTable dt = DAL.Select(sql);
            count = Convert.ToDouble(dt.Rows[0]["Quantity"]);
            return count;
        }

        public BillingViewModel()
        {

            IUDFlag = "I";
            GetProduct();
            GetPer();
            dtFromDate = DateTime.Now;
            dtToDate = DateTime.Now;
        }
        private void GetProduct()
        {


            lstProducts = new ObservableCollection<FormEntity>();
            DataTable dt = Common.GetProducts();
            foreach (DataRow dr in dt.Rows)
            {
                FormEntity obj = new FormEntity();
                obj.ClientId = dr["clientid"].ToString();
                obj.ProductName = dr["ProductDetail"].ToString();
                obj.ProductId = dr["productid"].ToString();
                obj.HSNCode = dr["HSNCode"].ToString();
                obj.CGST = dr["CGST"] == DBNull.Value ? 0.00 : Convert.ToDouble(dr["CGST"]);
                obj.IGST = dr["IGST"] == DBNull.Value ? 0.00 : Convert.ToDouble(dr["IGST"]);
                obj.SGST = dr["SGST"] == DBNull.Value ? 0.00 : Convert.ToDouble(dr["SGST"]);
                obj.Per = dr["Per"].ToString();
                lstProducts.Add(obj);
            }

        }
        private void GetPer()
        {
            DataTable dt = Common.GetPer();
            lstPer = new ObservableCollection<StaticDataModel>();
            foreach (DataRow dr in dt.Rows)
            {
                StaticDataModel obj = new StaticDataModel();
                obj.StaticID = int.Parse(dr[0].ToString());
                obj.StaticName = dr[1].ToString();
                lstPer.Add(obj);
            }
        }
        public override void FillProductDetails()
        {
            if (this.SelectedProduct != null)
            {
                this.HSNCode = this.SelectedProduct.HSNCode;
                this.CGST = this.SelectedProduct.CGST;
                this.SGST = this.SelectedProduct.SGST;
                this.IGST = this.SelectedProduct.IGST;
                string result = (this.SelectedProduct.Per.Trim());
                //int.TryParse(SearchResult.Rows[0]["SupplierID"].ToString(), out result);
                this.SelectedPer = lstPer.First(x => x.StaticName.ToLower() == result.ToLower());
            }

        }
        private DataTable _SearchResult;
        public DataTable SearchResult { get { return _SearchResult; } set { if (value != _SearchResult) { _SearchResult = value; RaisePropertyChanged(() => SearchResult); } } }


        private ObservableCollection<FormEntity> _lstProducts;
        public ObservableCollection<FormEntity> lstProducts { get { return _lstProducts; } set { if (value != _lstProducts) { _lstProducts = value; RaisePropertyChanged(() => lstProducts); } } }

        private FormEntity _SelectedProduct;
        public FormEntity SelectedProduct
        {
            get
            {

                return _SelectedProduct;

            }
            set
            {
                if (value != _SelectedProduct)
                {
                    _SelectedProduct = value;
                    RaisePropertyChanged(() => SelectedProduct);
                    FillProductDetails();
                }
            }
        }

        private ParticularViewModel _ParticularViewModel;
        public ParticularViewModel ParticularViewModel
        {
            get { return _ParticularViewModel; }
            set
            {
                if (value != _ParticularViewModel)
                {
                    _ParticularViewModel = value;
                    RaisePropertyChanged(() => ParticularViewModel);
                }
            }
        }



        public override bool canSaveData()
        {
            if (lstParticulars == null || lstParticulars.Count == 0)
            {
                return false;
            }
            else if (string.IsNullOrEmpty(this.CustomerName))
            {
                return false;
            }
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
        public override void Search()
        {
            try
            {

                {


                    List<string> lst = new List<string>();
                    lst.Add(string.Empty);
                    lst.Add(this.BillNo);
                    lst.Add(this.dtFromDate.ToString("yyyyMMdd"));
                    lst.Add(this.dtToDate.ToString("yyyyMMdd"));
                    string sql = "exec  [IMS].[GetBillDetails]";
                    SearchResult = DAL.Select(sql, lst);
                    if (SearchResult == null || SearchResult.Rows.Count == 0)
                    {
                        return;
                    }
                    lstBillDetailEntity = new ObservableCollection<FormEntity>();
                    foreach (DataRow dr in SearchResult.Rows)
                    {
                        FormEntity obj = new FormEntity();
                        obj.BillId = dr["BillID"].ToString();
                        obj.BillNo = dr["BillNumber"].ToString();
                        obj.BillDate = Convert.ToDateTime(dr["BillDate"]);
                        obj.CustomerName = dr["CustomerDetail"].ToString();

                        obj.TotalAmount = Convert.ToDouble(dr["TotalAmount"]);
                        obj.Discount = Convert.ToDouble(dr["Discount"]);
                        obj.TotalofTotalAmount = Convert.ToDouble(dr["AmountPayable"]);
                        lstBillDetailEntity.Add(obj);
                    }
                }

            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);
            }

        }
        public override bool canSearch()
        {

            return base.canSearch();
        }

        public override void Search(string invoiceID)
        {

            List<string> lst = new List<string>();
            lst.Add(invoiceID);
            lst.Add(string.Empty);
            lst.Add(string.Empty);
            lst.Add(string.Empty);
            string sql = "exec [IMS].[GetBillDetails]";
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
            this.BillId = SearchResult.Rows[0]["BillID"].ToString();
            this.BillNo = SearchResult.Rows[0]["BillNo"].ToString();
            this.BillDate = Convert.ToDateTime(SearchResult.Rows[0]["BillDate"]);
            this.Discount = Convert.ToDouble(SearchResult.Rows[0]["Discount"]);
            this.CustomerName = SearchResult.Rows[0]["CustomerDetail"].ToString();

            foreach (DataRow dr in SearchResult.Rows)
            {


                FormEntity obj = new FormEntity();

                obj.ProductName = dr["Product"].ToString(); ;
                obj.ProductId = dr["ProductId"].ToString(); ;

                obj.Quantity = dr["Quantity"].ToString();
                obj.Rate = dr["Rate"].ToString();

                obj.Per = dr["Per"].ToString();
                obj.PerName = dr["PerName"].ToString();

                obj.Amount = Convert.ToDouble(dr["Amount"]);
                obj.OtherCharges = Convert.ToDouble(dr["OtherCharges"]);

                obj.TaxableAmount = Convert.ToDouble(dr["TaxableAmount"]);
                //                obj.Comment = (dr["Comments"].ToString());
                obj.HSNCode = (dr["HSNCode"].ToString());
                obj.CGST = Convert.ToDouble(dr["CGST"]);
                obj.IGST = Convert.ToDouble(dr["IGST"]);
                obj.SGST = Convert.ToDouble(dr["SGST"]);
                obj.TotalTax = Convert.ToDouble(dr["TotalTax"]);
                obj.TotalAmount = Convert.ToDouble(dr["TotalAmount"]);

                lstParticulars.Add(obj);
                CalculateTotalofTotal();

            }
            //            SearchPayments(this.InvoiceID);
        }

        public override void IUD()
        {
            try
            {

                string sql = "exec [IMS].[IUDBills]";
                List<string> lst = new List<string>();

                lst.Add(this.BillId);
                lst.Add(this.IUDFlag);
                lst.Add(this.CustomerName);
                lst.Add(Convert.ToString(this.Discount));
                lst.Add(Common.LoggedInUserID);

                DAL.StartTransaction();
                DataTable dtResult = DAL.Select(sql, lst, DAL.transaction);

                if (dtResult != null && dtResult.Rows.Count > 0)
                {
                    this.BillId = Convert.ToString(dtResult.Rows[0][0]);


                    if (lstParticulars != null && lstParticulars.Count > 0)
                    {

                        sql = "exec [IMS].[DeleteBillDetails]";
                        lst = new List<string>();
                        lst.Add(this.BillId);
                        dtResult = DAL.Select(sql, lst, DAL.transaction);// Delete Invoice Details

                        foreach (FormEntity en in lstParticulars)
                        {
                            sql = "exec [IMS].[IUDBillDetails]";
                            lst = new List<string>();
                            lst.Add(string.Empty);
                            lst.Add(this.BillId);
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

                        }


                    }

                    sql = "exec ims.DeleteTransaction";
                    lst = new List<string>();
                    lst.Add(this.BillId);
                    dtResult = DAL.Select(sql, lst, DAL.transaction);// Delete Invoice Details


                    Transactions objTransaction = new Transactions();
                    //foreach (InvoiceDetailsEntity en in lstParticulars)
                    {
                        objTransaction.IUDFlag = IUDFlag;
                        objTransaction.TransactionID = this.BillId;
                        objTransaction.TransactionType = "BD";
                        objTransaction.ProductID = string.Empty; ;
                        objTransaction.Quantity = string.Empty;
                        objTransaction.Amount = TotalofTotalAmount.ToString();
                        objTransaction.AccountEntry = "C";
                        objTransaction.IUDTransactions();
                    }

                    if (Convert.ToInt32(objTransaction.ID) > 0)
                    {

                        MessageBox.Show("Data Saved Successfully");
                        if (MessageBoxResult.Yes == MessageBox.Show("Do you want to print the Bill ?", "Print Bill", MessageBoxButton.YesNo))
                        {
                            ReportsHostingForm obj = new ReportsHostingForm("Bill");
                            obj.ShowDialog();
                        }
                        ClearFormFields();
                    }


                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL.EndTransaction();
            }
        }
        void ClearFormFields()
        {
            lstParticulars.Clear();
            IUDFlag = "I";
            this.CustomerName = string.Empty;
            this.Discount = null;
        }

        private ObservableCollection<FormEntity> _lstBillDetailEntity;
        public ObservableCollection<FormEntity> lstBillDetailEntity
        {
            get { return _lstBillDetailEntity; }
            set
            {
                if (value != _lstBillDetailEntity)
                {
                    _lstBillDetailEntity = value;
                    RaisePropertyChanged(() => lstBillDetailEntity);
                }
            }
        }


        public override bool ValidateBeforeAdd()
        {
            return false;
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

                    //TotalInvoiceAmount += en.Amount;
                    TotalInvoiceAmount += en.TaxableAmount;//Changed after bill logic introduces
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


    }

}
