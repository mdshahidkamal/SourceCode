using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.ViewModels;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Input;
using HospitalManagementSystem.Helpers;
namespace HospitalManagementSystem.ViewModels
{
    public class FormEntity : BaseViewModel
    {
        public string InvoiceDetailID { get; set; }
        public string PaymentId { get; set; }

        private string _InvoiceID;
        public string InvoiceID { get { return _InvoiceID; } set { if (value != _InvoiceID) { _InvoiceID = value; RaisePropertyChanged(() => InvoiceID); } } }

        private string _IUDFlag;
        public string IUDFlag { get { return _IUDFlag; } set { if (value != _IUDFlag) { _IUDFlag = value; RaisePropertyChanged(() => IUDFlag); } } }


        private string _InvoiceNo;
        public string InvoiceNo { get { return _InvoiceNo; } set { if (value != _InvoiceNo) { _InvoiceNo = value; RaisePropertyChanged(() => InvoiceNo); } } }

        private DateTime _InvoiceDate;
        public DateTime InvoiceDate { get { return _InvoiceDate; } set { if (value != _InvoiceDate) { _InvoiceDate = value; RaisePropertyChanged(() => InvoiceDate); } } }

        private ObservableCollection<StaticDataModel> _lstSuppliers;
        public ObservableCollection<StaticDataModel> lstSuppliers { get { return _lstSuppliers; } set { if (value != _lstSuppliers) { _lstSuppliers = value; RaisePropertyChanged(() => lstSuppliers); } } }

        private StaticDataModel _SelectedSuppliers;
        public StaticDataModel SelectedSuppliers { get { return _SelectedSuppliers; } set { if (value != _SelectedSuppliers) { _SelectedSuppliers = value; RaisePropertyChanged(() => SelectedSuppliers); } } }

        private string _SupplierName;
        public string SupplierName { get { return _SupplierName; } set { if (value != _SupplierName) { _SupplierName = value; RaisePropertyChanged(() => SupplierName); } } }

        private string _SupplierID;
        public string SupplierID
        {
            get { return _SupplierID; }
            set
            {
                if (value != _SupplierID)
                {
                    _SupplierID = value;
                    RaisePropertyChanged(() => SupplierID);
                }
            }
        }


        //private ProductEntity _SelectedProduct;
        //public ProductEntity SelectedProduct { get { return _SelectedProduct; } set { if (value != _SelectedProduct) { _SelectedProduct = value; RaisePropertyChanged(() => SelectedProduct); FillProductDetails(_SelectedProduct.ProductId); } } }
      
        private string _Quantity;
        public string Quantity { get { return _Quantity; } set { if (value != _Quantity) { _Quantity = value; RaisePropertyChanged(() => Quantity); CalculatAmount(); } } }

        private string _Rate;
        public string Rate { get { return _Rate; } set { if (value != _Rate) { _Rate = value; RaisePropertyChanged(() => Rate); CalculatAmount();  } } }

        private ObservableCollection<StaticDataModel> _lstPer;
        public ObservableCollection<StaticDataModel> lstPer { get { return _lstPer; } set { if (value != _lstPer) { _lstPer = value; RaisePropertyChanged(() => lstPer); } } }
        
        //private ObservableCollection<FormEntity> _lstParticulars;
        //public ObservableCollection<FormEntity> lstParticulars { get { return _lstParticulars; } set { if (value != _lstParticulars) { _lstParticulars = value; RaisePropertyChanged(() => lstParticulars); } } }
        private ObservableCollection<FormEntity> _lstParticulars;
        public ObservableCollection<FormEntity> lstParticulars
        {
            get { return _lstParticulars; }
            set
            {
                if (value != _lstParticulars)
                {
                    _lstParticulars = value;
                    RaisePropertyChanged(() => lstParticulars);
                   
                }
            }
        }
        


        private StaticDataModel _SelectedPer;
        public StaticDataModel SelectedPer { get { return _SelectedPer; } set { if (value != _SelectedPer) { _SelectedPer = value; RaisePropertyChanged(() => SelectedPer); } } }

        private string _Per;
        public string Per { get { return _Per; } set { if (value != _Per) { _Per = value; RaisePropertyChanged(() => Per); } } }

        private string _PerName;
        public string PerName { get { return _PerName; } set { if (value != _PerName) { _PerName = value; RaisePropertyChanged(() => PerName); } } }


        private double? _Amount = null;
        public double? Amount
        {
            get { return _Amount; }
            set
            {
                if (value != _Amount)
                {
                    _Amount = value;
                    RaisePropertyChanged(() => Amount);
                    CalculateTaxableAmount();
                    CalculateTotalTax();
                    CalCulateTotalAmount();

                }
            }
        }

        private double? _TotalAmount = null;
        public double? TotalAmount
        {
            get { return _TotalAmount; }
            set
            {
                if (value != _TotalAmount)
                {
                    _TotalAmount = value;
                    RaisePropertyChanged(() => TotalAmount);

                }
            }
        }

        private string _Comment;
        public string Comment { get { return _Comment; } set { if (value != _Comment) { _Comment = value; RaisePropertyChanged(() => Comment); } } }

        private string _Comment1;
        public string Comment1
        {
            get { return _Comment1; }
            set
            {
                if (value != _Comment1)
                {
                    _Comment1 = value;
                    RaisePropertyChanged(() => Comment1);
                }
            }
        }


        private DateTime _dtFromDate;
        public DateTime dtFromDate { get { return _dtFromDate; } set { if (value != _dtFromDate) { _dtFromDate = value; RaisePropertyChanged(() => dtFromDate); } } }

        private DateTime _dtToDate;
        public DateTime dtToDate { get { return _dtToDate; } set { if (value != _dtToDate) { _dtToDate = value; RaisePropertyChanged(() => dtToDate); } } }

        private bool _ShowHideInvoiceDetails;
        public bool ShowHideInvoiceDetails { get { return _ShowHideInvoiceDetails; } set { if (value != _ShowHideInvoiceDetails) { _ShowHideInvoiceDetails = value; RaisePropertyChanged(() => ShowHideInvoiceDetails); } } }




        private double? _Discount;
        public double? Discount
        {
            get { return _Discount; }
            set
            {
                if (value != _Discount)
                {
                    _Discount = value;
                    RaisePropertyChanged(() => Discount);
                    CalculateTotalofTotal();
                }
            }
        }


        private double? _TotalTax;
        public double? TotalTax
        {
            get { return _TotalTax; }
            set
            {
                if (value != _TotalTax)
                {
                    _TotalTax = value;
                    RaisePropertyChanged(() => TotalTax);
                    CalCulateTotalAmount();
                }
            }
        }

        private double? _OtherCharges;
        public double? OtherCharges
        {
            get { return _OtherCharges; }
            set
            {
                if (value != _OtherCharges)
                {
                    _OtherCharges = value;
                    RaisePropertyChanged(() => OtherCharges);
                    CalculateTaxableAmount();
                }
            }
        }

        private double? _TaxableAmount;
        public double? TaxableAmount
        {
            get { return _TaxableAmount; }
            set
            {
                if (value != _TaxableAmount)
                {
                    _TaxableAmount = value;
                    RaisePropertyChanged(() => TaxableAmount);
                }
            }
        }

        private double? _TotalInvoiceAmount;
        public double? TotalInvoiceAmount
        {
            get { return _TotalInvoiceAmount; }
            set
            {
                if (value != _TotalInvoiceAmount)
                {
                    _TotalInvoiceAmount = value;
                    RaisePropertyChanged(() => TotalInvoiceAmount);
                }
            }
        }

        private double? _TotalInvoiceTax;
        public double? TotalInvoiceTax
        {
            get { return _TotalInvoiceTax; }
            set
            {
                if (value != _TotalInvoiceTax)
                {
                    _TotalInvoiceTax = value;
                    RaisePropertyChanged(() => TotalInvoiceTax);
                }
            }
        }

        private double? _TotalInvoiceTaxableAmount;
        public double? TotalInvoiceTaxableAmount
        {
            get { return _TotalInvoiceTaxableAmount; }
            set
            {
                if (value != _TotalInvoiceTaxableAmount)
                {
                    _TotalInvoiceTaxableAmount = value;
                    RaisePropertyChanged(() => TotalInvoiceTaxableAmount);
                }
            }
        }
        
        private double? _TotalofTotalAmount = 0;
        public double? TotalofTotalAmount
        {
            get { return _TotalofTotalAmount; }
            set
            {
                if (value != _TotalofTotalAmount)
                {
                    _TotalofTotalAmount = value;
                    RaisePropertyChanged(() => TotalofTotalAmount);
                }
            }
        }

        private double? _TotalofTotalPaidAmount;
        public double? TotalofTotalPaidAmount
        {
            get { return _TotalofTotalPaidAmount; }
            set
            {
                if (value != _TotalofTotalPaidAmount)
                {
                    _TotalofTotalPaidAmount = value;
                    RaisePropertyChanged(() => TotalofTotalPaidAmount);
                }
            }
        }

        private double? _TotalOutStandingAmount;
        public double? TotalOutStandingAmount
        {
            get { return _TotalOutStandingAmount; }
            set
            {
                if (value != _TotalOutStandingAmount)
                {
                    _TotalOutStandingAmount = value;
                    RaisePropertyChanged(() => TotalOutStandingAmount);
                }
            }
        }
     

        private DateTime _PaymentDate;
        public DateTime PaymentDate
        {
            get { return _PaymentDate; }
            set
            {
                if (value != _PaymentDate)
                {
                    _PaymentDate = value;
                    RaisePropertyChanged(() => PaymentDate);
                }
            }
        }

        private double? _PaymentAmount;
        public double? PaymentAmount
        {
            get { return _PaymentAmount; }
            set
            {
                if (value != _PaymentAmount)
                {
                    _PaymentAmount = value;
                    RaisePropertyChanged(() => PaymentAmount);
                }
            }
        }

        private ObservableCollection<StaticDataModel> _lstPaymentType;
        public ObservableCollection<StaticDataModel> lstPaymentType
        {
            get { return _lstPaymentType; }
            set
            {
                if (value != _lstPaymentType)
                {
                    _lstPaymentType = value;
                    RaisePropertyChanged(() => lstPaymentType);
                }
            }
        }

        private StaticDataModel _SelectedPaymentType;
        public StaticDataModel SelectedPaymentType
        {
            get { return _SelectedPaymentType; }
            set
            {
                if (value != _SelectedPaymentType)
                {
                    _SelectedPaymentType = value;
                    RaisePropertyChanged(() => SelectedPaymentType);
                }
            }
        }

        private string _PaymentType;
        public string PaymentType
        {
            get { return _PaymentType; }
            set
            {
                if (value != _PaymentType)
                {
                    _PaymentType = value;
                    RaisePropertyChanged(() => PaymentType);
                }
            }
        }

        private string _PaymentTypeId;
        public string PaymentTypeId
        {
            get { return _PaymentTypeId; }
            set
            {
                if (value != _PaymentTypeId)
                {
                    _PaymentTypeId = value;
                    RaisePropertyChanged(() => PaymentTypeId);
                }
            }
        }

        private ObservableCollection<StaticDataModel> _lstPaymentMode;
        public ObservableCollection<StaticDataModel> lstPaymentMode
        {
            get { return _lstPaymentMode; }
            set
            {
                if (value != _lstPaymentMode)
                {
                    _lstPaymentMode = value;
                    RaisePropertyChanged(() => lstPaymentMode);
                }
            }
        }

        private StaticDataModel _SelectedPaymentMode;
        public StaticDataModel SelectedPaymentMode
        {
            get { return _SelectedPaymentMode; }
            set
            {
                if (value != _SelectedPaymentMode)
                {
                    _SelectedPaymentMode = value;
                    RaisePropertyChanged(() => SelectedPaymentMode);
                }
            }
        }

        private string _PaymentMode;
        public string PaymentMode
        {
            get { return _PaymentMode; }
            set
            {
                if (value != _PaymentMode)
                {
                    _PaymentMode = value;
                    RaisePropertyChanged(() => PaymentMode);
                }
            }
        }

        private string _PaymentModeId;
        public string PaymentModeId
        {
            get { return _PaymentModeId; }
            set
            {
                if (value != _PaymentModeId)
                {
                    _PaymentModeId = value;
                    RaisePropertyChanged(() => PaymentModeId);
                }
            }
        }

      
        private string _ProductId;
        public string ProductId { get { return _ProductId; } set { if (value != _ProductId) { _ProductId = value; RaisePropertyChanged(() => ProductId); } } }

        private string _ProductName;
        public string ProductName { get { return _ProductName; } set { if (value != _ProductName) { _ProductName = value; RaisePropertyChanged(() => ProductName); } } }


        private string _Description;
        public string Description { get { return _Description; } set { if (value != _Description) { _Description = value; RaisePropertyChanged(() => Description); } } }

        private string _HSNCode;
        public string HSNCode
        {
            get { return _HSNCode; }
            set
            {
                if (value != _HSNCode)
                {
                    _HSNCode = value;
                    RaisePropertyChanged(() => HSNCode);
                }
            }
        }
        private double? _CGST = null;
        public double? CGST
        {
            get { return _CGST; }
            set
            {
                if (value != _CGST)
                {
                    _CGST = value;
                    RaisePropertyChanged(() => CGST);
                    CalCulateTotalAmount();
                    CalculateTotalTax();
                    CalculateTaxableAmount();
                }
            }
        }

        private double? _SGST;
        public double? SGST
        {
            get { return _SGST; }
            set
            {
                if (value != _SGST)
                {
                    _SGST = value;
                    RaisePropertyChanged(() => SGST);
                    CalCulateTotalAmount();
                    CalculateTotalTax();
                    CalculateTaxableAmount();
                }
            }
        }


        private double? _IGST;
        public double? IGST
        {
            get { return _IGST; }
            set
            {
                if (value != _IGST)
                {
                    _IGST = value;
                    RaisePropertyChanged(() => IGST);
                    CalCulateTotalAmount();
                    CalculateTotalTax();
                    CalculateTaxableAmount();
                }
            }
        }


        private string _BillId;
        public string BillId { get { return _BillId; } set { if (value != _BillId) { _BillId = value; RaisePropertyChanged(() => BillId); } } }


        private string _BillNo;
        public string BillNo { get { return _BillNo; } set { if (value != _BillNo) { _BillNo = value; RaisePropertyChanged(() => BillNo); } } }

        private DateTime _BillDate;
        public DateTime BillDate
        {
            get { return _BillDate; }
            set
            {
                if (value != _BillDate)
                {
                    _BillDate = value;
                    RaisePropertyChanged(() => BillDate);
                }
            }
        }

        private string _CustomerName;
        public string CustomerName { get { return _CustomerName; } set { if (value != _CustomerName) { _CustomerName = value; RaisePropertyChanged(() => CustomerName); } } }


    


        public virtual ICommand cmdSearch { get { return new DelegateCommand(Search, canSearch); } }
        public virtual ICommand cmdsave { get { return new DelegateCommand(IUD, canSaveData); } }
        public virtual ICommand cmdAddNew { get { return new DelegateCommand(AddNew, ValidateBeforeAdd); } }
        public virtual ICommand cmdAddNewParticular { get { return new DelegateCommand(AddNewParticular, ValidateBeforeAdd); } }
        public virtual ICommand cmdAddNewPayment { get { return new DelegateCommand(AddNewPayment, ValidateBeforeAddPayment); } }

        public virtual ICommand cmdOpenPopWindow { get { return new DelegateCommand(OpenPopWindow, CanOpenPopWindow); } }

        



        public virtual void CalculatAmount()
        {
            

        }
        public virtual void CalculateTotalTax()
        {
           

        }
        public virtual void CalculateTaxableAmount()
        {
               
        }
        public virtual void CalCulateTotalAmount()
        {



        }
        public virtual double GetDoubleValue(string v)
        {
            double d = 0;
            double.TryParse(v, out d);
            return d;
        }
        public virtual void CalculateTotalofTotal()
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
        public virtual void CalculateTotalPaidAmount()
        {
            
        }
        public virtual void RemoveParticular(FormEntity o)
        {
 
        }

        public virtual void Search()
        {
 
        }
        public virtual void Search(string id)
        {
 
        }
        public virtual void IUD()
        {
 
        }
        public virtual void AddNew()
        {
 
        }
        public virtual void AddNewParticular()
        {
 
        }
        public virtual void AddNewPayment()
        {
 
        }
        public virtual void FillProductDetails()
        {
 
        }
        
        public virtual bool canSearch()
        {
            return true;
        }
        public virtual bool canSaveData()
        {
            return false;
        }
        public virtual bool ValidateBeforeAdd()
        {
            return false;
        }
        public virtual bool ValidateBeforeAddPayment()
        {
            return false;
        }

        public virtual void OpenPopWindow(object param)
        { 
        }
        public virtual bool CanOpenPopWindow()
        {
            

            return true;
        }
            
    }
}
