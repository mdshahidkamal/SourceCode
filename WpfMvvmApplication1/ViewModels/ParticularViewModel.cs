using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.ViewModels;
using System.Data;
using HospitalManagementSystem.Helpers;
using System.Collections.ObjectModel;
using System.Windows.Input;
using HospitalManagementSystem.DataAccess;
using System.Windows.Forms;
namespace IMS.ViewModels
{
    public delegate void delOnAddedItem(FormEntity o);
    public class ParticularViewModel : FormEntity
    {
        public event delOnAddedItem OnAddedItem;

        public override ICommand cmdAddNewParticular { get { return new DelegateCommand(AddNewParticular, ValidateBeforeAdd); } }

        private FormEntity _FormEntityModel;
        public FormEntity FormEntityModel
        {
            get { return _FormEntityModel; }
            set
            {
                if (value != _FormEntityModel)
                {
                    _FormEntityModel = value;
                    RaisePropertyChanged(() => FormEntityModel);
                }
            }
        }

        public string Model { get; set; }

        public ParticularViewModel(string model)
        {
            this.Model = model;
            if (model == "Invoice")
            {
                GetProduct();
            }
            else if (model == "Bill")
            {
                GetProductAvailable();
            }


            GetPer();

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

        private void GetProductAvailable()
        {


            lstProducts = new ObservableCollection<FormEntity>();
            string sql = "[IMS].[GetAvailableProductDetails] " + Common.Clientid;
            DataTable dt = DAL.Select(sql);

            //
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
        public override void AddNewParticular()
        {
            int count = 0;
            FormEntity obj = new FormEntity();
            //obj.InvoiceNo = this.InvoiceNo;
            //obj.InvoiceDate = this.InvoiceDate;
            //obj.SupplierID = this.SelectedSuppliers.StaticID.ToString();
            obj.ProductName = this.SelectedProduct.ProductName;
            obj.ProductId = this.SelectedProduct.ProductId;
            obj.Quantity = this.Quantity;
            obj.Rate = this.Rate;
            obj.Per = this.SelectedPer.StaticID.ToString();
            obj.PerName = this.SelectedPer.StaticName;
            obj.Amount = this.Amount;
            obj.OtherCharges = this.OtherCharges;

            obj.TaxableAmount = this.TaxableAmount;
            obj.Comment = this.Comment;
            obj.HSNCode = this.HSNCode;
            obj.CGST = this.CGST;
            obj.IGST = this.IGST;
            obj.SGST = this.SGST;
            obj.TotalTax = this.TotalTax;
            obj.TotalAmount = this.TotalAmount;


            OnAddedItem(obj);
            ClearAddedItems();


            //FormEntityModel.lstParticulars.Add(obj);
            //CalculateTotalofTotal();



        }


        private ObservableCollection<FormEntity> _lstProducts;
        public ObservableCollection<FormEntity> lstProducts { get { return _lstProducts; } set { if (value != _lstProducts) { _lstProducts = value; RaisePropertyChanged(() => lstProducts); } } }


        public override void CalculatAmount()
        {
            double quantity = GetDoubleValue(this.Quantity);
            double rate = GetDoubleValue(this.Rate);

            double amount = quantity * rate;
            this.Amount = amount;

        }
        public override void CalculateTotalTax()
        {
            this.TotalTax = 0;
            double? cgst = (this.CGST) / 100;
            double? sgst = (this.SGST) / 100;
            double? igst = (this.IGST) / 100;
            double? tax = null;
            if (cgst == null)
            {
                cgst = 0;
            }
            if (sgst == null)
            {
                sgst = 0;
            }
            if (igst == null)
            {
                igst = 0;
            }

            tax = cgst + sgst + igst;
            double? totaltax = 0;
            if (this.Model == "Bill")
            {
                double? cp = 0;
                cp = this.Amount / (1 + tax);
                totaltax = this.Amount - cp;
                
            }
            else
            {
                totaltax = (this.TaxableAmount) * tax;// +(GetDoubleValue(this.Amount) * (1 + sgst)) + (GetDoubleValue(this.Amount) * (1 + igst));
            }
            this.TotalTax = totaltax;

        }
        public override void CalculateTaxableAmount()
        {
            double? othercharges = this.OtherCharges;
            if (OtherCharges == null)
            {
                othercharges = 0;
            }
            if (this.Model == "Bill")
            {
                CalculateTotalTax();
                this.TaxableAmount = this.Amount - this.TotalTax;
            }
            else
            {
                
                this.TaxableAmount = this.Amount + othercharges;
            }
        }
        public override void CalCulateTotalAmount()
        {
            if (this.Model == "Bill")
            {
                this.TotalAmount = (this.TaxableAmount + this.TotalTax);
            }
            else if (this.Model == "Invoice")
            {
                this.TotalAmount = (this.TaxableAmount + this.TotalTax);
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
        public override bool ValidateBeforeAdd()
        {



            if (this.SelectedProduct == null)
                return false;

            else if (string.IsNullOrEmpty(this.HSNCode))
                return false;

            else if (string.IsNullOrEmpty(this.Quantity))
                return false;

            else if (string.IsNullOrEmpty(this.Rate))
                return false;

            else if (this.SelectedPer == null || this.SelectedPer.StaticName == "--Select--")
                return false;

            else if (this.Amount == null || this.Amount == 0)
                return false;

            //else if (this.OtherCharges == null)
            //    return false;

            //else if (this.CGST == null)
            //    return false;


            //else if (this.SGST == null)
            //    return false;

            //else if (this.IGST == null)
            //    return false;

            else if (this.TotalTax == null)
                return false;

            else if (this.TotalAmount == null)
                return false;




            return true;
        }
        void ClearAddedItems()
        {
            this.SelectedProduct = null;
            this.HSNCode = string.Empty;
            this.Quantity = string.Empty;
            this.Rate = string.Empty;
            this.SelectedPer = null;
            this.Amount = 0;
            this.OtherCharges = null;
            this.CGST = null;
            this.SGST = null;
            this.IGST = null;


        }
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



    }
}
