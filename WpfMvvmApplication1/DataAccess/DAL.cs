using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HospitalManagementSystem.Helpers;
using System.Configuration;
using System.Reflection;
namespace HospitalManagementSystem.DataAccess
{
    public static class DAL
    {
        public static Helpers.Logger logger;
        public static SqlConnection oConn;
        public static SqlTransaction transaction;
        static DAL()
        {
            logger = Helpers.Logger.IntializeLogger();
            GetConnectionString();
        }
        static void GetConnectionString()
        {
            try
            {
                //                string dbpath = ConfigurationSettings.AppSettings["db"].ToString();

                //string strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbpath + ";Persist Security Info=False;";
                //string strConnectionString= "Data Source = moskit.database.windows.net; Initial Catalog = moskitdb; Persist Security Info = True; User ID=moskitadmin@moskit;Password=pwdsql@4712;";
                //string strConnectionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=moskitdb;Integrated Security=True;";
                string strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
                //string strConnectionString = "Server=tcp:moskit.database.windows.net,1433;Database=moskitdb;User ID=moskitadmin@moskit;Password=pwdsql@4712;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;";
                oConn = new SqlConnection(strConnectionString);
                logger.Log("Connecting Server :" + oConn.DataSource, MessageType.Debug);
                logger.Log("Connecting Database :" + oConn.Database, MessageType.Debug);
            }
            catch (Exception ex)
            {
                logger.Log(((SqlException)(ex)).Message, MessageType.Error);

            }
            finally
            {
                //oConn.Close();
            }
        }

        public static DataTable Select(string sql)
        {
            logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);
            logger.Log(sql, MessageType.Debug);
            DataTable dtResult = new DataTable();
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Connection = oConn;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter oDA = new SqlDataAdapter(cmd);

            try
            {
                oConn.Open();
                oDA.Fill(dtResult);
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message, MessageType.Error);
            }
            finally
            {
                oConn.Close();
            }

            return dtResult;
        }
        public static DataTable Select(string sql, List<string> parameters)
        {
            logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);
            logger.Log(sql, MessageType.Debug);
            DataTable dtResult = new DataTable();

            if (parameters.Count > 0)
            {
                foreach (string str in parameters)
                {

                    sql += " '" + str + "',";
                }
            }
            sql = sql.TrimEnd(',');
            logger.Log(sql, MessageType.Debug);

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Connection = oConn;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter oDA = new SqlDataAdapter(cmd);

            try
            {
                oConn.Open();
                oDA.Fill(dtResult);
            }
            catch (Exception ex)
            {
                logger.Log(((SqlException)(ex)).Message, MessageType.Error);
            }
            finally
            {
                oConn.Close();
            }

            return dtResult;
        }

        public static void StartTransaction()
        {
            if (ConnectionState.Closed == oConn.State) 
            {
                oConn.Open();
            }
            transaction= oConn.BeginTransaction();
        }
        public static void EndTransaction()
        {
            if (ConnectionState.Open == oConn.State)
            {
                transaction.Commit();
            }
            oConn.Close();
         
        }

        public static DataTable Select(string sql, List<string> parameters, SqlTransaction mytransaction)
        {
            

            logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);
            logger.Log(sql, MessageType.Debug);
            DataTable dtResult = new DataTable();

            if (parameters.Count > 0)
            {
                foreach (string str in parameters)
                {

                    sql += " '" + str + "',";
                }
            }
            sql = sql.TrimEnd(',');
            logger.Log(sql, MessageType.Debug);

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Connection = oConn;
            cmd.CommandType = CommandType.Text;
            cmd.Transaction = mytransaction;
            SqlDataAdapter oDA = new SqlDataAdapter(cmd);
            
            try
            {
                
                oDA.Fill(dtResult);
            }
            catch (Exception ex)
            {
                logger.Log(((SqlException)(ex)).Message, MessageType.Error);
            }

            return dtResult;
        }
        public static int Execute(string sql)
        {
            int result = 0;
            logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);
            logger.Log(sql, MessageType.Debug);

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = oConn;
            cmd.CommandType = CommandType.Text;

            try
            {
                oConn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                logger.Log(((SqlException)(ex)).Message, MessageType.Error);
            }
            finally
            {
                oConn.Close();
            }

            return result;
        }
        public static int Execute(string sql, List<string> parameters)
        {
            int result = 0;
            logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);

            if (parameters.Count > 0)
            {
                foreach (string str in parameters)
                {

                    sql += " '" + str + "',";
                }
            }
            sql = sql.TrimEnd(',');
            logger.Log(sql, MessageType.Debug);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = oConn;
            cmd.CommandType = CommandType.Text;

            try
            {
                oConn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                logger.Log(((SqlException)(ex)).Message, MessageType.Error);
            }
            finally
            {
                oConn.Close();
            }

            return result;
        }
        public static int Execute(string sql, Dictionary<string, string> parameters)
        {
            int result = 0;
            string _sql = sql;
            logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);

            if (parameters.Count > 0)
            {
                foreach (var str in parameters)
                {

                    _sql += "@" + str.Key + "='" + str.Value + "',";
                }
            }
            _sql = _sql.TrimEnd(',');
            logger.Log(_sql, MessageType.Debug);
            SqlCommand cmd = new SqlCommand(_sql);
            cmd.Connection = oConn;
            cmd.CommandType = CommandType.Text;

            try
            {
                oConn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                logger.Log(((SqlException)(ex)).Message, MessageType.Error);
            }
            finally
            {
                oConn.Close();
            }

            return result;
        }
        public static int ExecuteScalar(string sql)
        {
            int result = 0;
            logger.Log(System.Reflection.MethodBase.GetCurrentMethod().Name, MessageType.Debug);
            logger.Log(sql, MessageType.Debug);

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = oConn;
            cmd.CommandType = CommandType.Text;

            try
            {
                oConn.Open();
                result = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                logger.Log(((SqlException)(ex)).Message, MessageType.Error);
            }
            finally
            {
                oConn.Close();
            }

            return result;
        }
    }
}
