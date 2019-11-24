using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using HospitalManagementSystem.DataAccess;
using HospitalManagementSystem.Helpers;

namespace HospitalManagementSystem.Helpers
{
    public static class Common
    {
        public static string Clientid = string.Empty;
        public static string ClientName = string.Empty;
        public static string ClientAddress = string.Empty;
        public static string AcademicYear = string.Empty;
        public static string AcademicYearID = string.Empty;
        public static string ClientLogo = string.Empty;
        public static DataTable DownloadFile;
        public static string LoggedInUserID = string.Empty;
        public static void SetStaicData()
        {
            //ConfigurationSettings.AppSettings["ClientID"].ToString();
            DataTable dtAcademicYear = GetAcademicYear();
            var resultAcademicYear = dtAcademicYear.AsEnumerable().OrderByDescending(x => x["StaticID"]).FirstOrDefault();
            //AcademicYear = result["StaticName"].ToString();
            //AcademicYearID = result["StaticID"].ToString();

            try
            {

                DataTable dt = GetClientDetails();

                ClientName = dt.Rows[0]["ClientName"].ToString();
                ClientAddress = dt.Rows[0]["ClientAddress"].ToString();



                EnumerableRowCollection<DataRow> query = from contact in dt.AsEnumerable()
                                                         where contact.Field<string>("ISDOWNLOAD") == "Y"
                                                         select contact;

                DataView view = query.AsDataView();
                DownloadFile = view.ToTable();



                query = from contact in dt.AsEnumerable()
                        where contact.Field<string>("KEY") == "LOGO"
                               && contact.Field<string>("ISDOWNLOAD") == "Y"
                        select contact;

                view = query.AsDataView();
                ClientLogo = view[0]["VALUE"].ToString();



                query = from contact in dt.AsEnumerable()
                        where contact.Field<string>("KEY") == "AcademicYear"
                        select contact;
                view = query.AsDataView();
                AcademicYear = view[0]["VALUE"].ToString();


                query = from contact in dtAcademicYear.AsEnumerable()
                        where contact.Field<string>("StaticName") == AcademicYear
                        select contact;
                view = query.AsDataView();
                //AcademicYearID = view[0]["StaticID"].ToString();
            }
            catch (Exception ex)
            {
                DAL.logger.Log(ex.Message + Environment.NewLine + ex.StackTrace, MessageType.Error);

            }

        }
        static Common()
        {


        }
        public static DataTable GetClientDetails()
        {
            string sql = "exec IMS.GetClientDetails " + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }
        public static DataTable GetSuppliers()
        {
            string sql = "exec IMS.getstaticdata 0,'SupplierName'," + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }
        public static DataTable GetPaymentMode()
        {
            string sql = "exec IMS.getstaticdata 0,'PaymentMode'," + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }
        public static DataTable GetPaymentType()
        {
            string sql = "exec IMS.getstaticdata 0,'PaymentType'," + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }
        
        public static DataTable GetPer()
        {
            string sql = "exec IMS.getstaticdata 0,'Per'," + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }

        public static DataTable GetAcademicYear()
        {
            string sql = "exec IMS.getstaticdata 0,'Academic Year'," + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }
        public static DataTable GetClassRoom()
        {

            string sql = "exec sms.getstaticdata 0,'ClassRoom'," + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }
        public static DataTable GetExpenseMaster()
        {

            string sql = "exec sms.getstaticdata 0,'Expense'," + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }
        public static DataTable GetStudents()
        {

            string sql = "exec sms.GetAllStudents " + Clientid;
            return DAL.Select(sql);
        }

        public static DataTable GetProducts()
        {
            string sql = "exec [IMS].[GetAllProductDetails] " + Clientid;
            return DAL.Select(sql);
        }
        public static DataTable GetStaff()
        {
            string sql = "exec sms.GetAllStaff " + Clientid;
            return DAL.Select(sql);

        }
        public static DataTable GetDocumentType()
        {

            string sql = "exec sms.getstaticdata 0,'Documents'," + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }
        public static DataTable GetSubjects()
        {
            string sql = "exec sms.GetAllSubjects " + Clientid;
            DataTable dt = DAL.Select(sql);
            return dt;
        }

    }
}
