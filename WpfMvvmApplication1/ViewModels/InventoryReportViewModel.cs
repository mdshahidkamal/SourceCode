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
    public class InventoryReportViewModel : FormEntity
    {
        public ICommand cmdRefresh { get { return new DelegateCommand(Refresh, () => true); } }
        public InventoryReportViewModel()
        {
            GetInventoryDetails();
        }
        private ObservableCollection<FormEntity> _lstInventoryDetails;
        public ObservableCollection<FormEntity> lstInventoryDetails
        {
            get { return _lstInventoryDetails; }
            set
            {
                if (value != _lstInventoryDetails)
                {
                    _lstInventoryDetails = value;
                    RaisePropertyChanged(() => lstInventoryDetails);
                }
            }
        }
        private bool CanRefresh()
        {
            return true;
        }
        private void Refresh()
        {
            GetInventoryDetails();
        }
        private void GetInventoryDetails()
        {
            lstInventoryDetails = new ObservableCollection<FormEntity>();
            string sql = "[IMS].[GetInventoryReport] " + Common.Clientid;
            DataTable dt = DAL.Select(sql);

            //
            foreach (DataRow dr in dt.Rows)
            {

                FormEntity obj = new FormEntity();
                obj.ProductId = dr["ProductID"].ToString();
                obj.ProductName = dr["ProductName"].ToString();
                obj.Quantity = dr["Quantity"] == DBNull.Value ? "0.00" : Convert.ToDouble(dr["Quantity"]).ToString();
                obj.PerName = dr["PerName"].ToString();

                lstInventoryDetails.Add(obj);
            }
        }


    }
}
