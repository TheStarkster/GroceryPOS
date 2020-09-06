using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grocery.DataAccess.Model;
using System.Data.SqlClient;
using System.Data;

namespace Grocery.BussinessLogic.Repositories
{
    public class CustomerDetails
    {
        public static Int32 SP_CustomerDetails(Nullable<int> ACTION, string custID,string custName, string cusAdd1, string custRef,
                           string custNameArabic, string DeviceName,string cusAdd2,string creditLimit,string cusTele, string cusMob,string cusFax,
                           string cusEmail, string AccountName, string salesman, string emirates, string paymentMode,  string nofOfdays, double OpeningBalance,
                           DateTime OpeningBalanceDate, double CustMargin, string CustStatus, string CostCentre)
        {
            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "SP_CustomerDetails_Win";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@ACTION", ACTION);
            mCmd.Parameters.AddWithValue("@custID", custID);
            mCmd.Parameters.AddWithValue("@custName", custName);
            mCmd.Parameters.AddWithValue("@cusAdd1", cusAdd1);
            mCmd.Parameters.AddWithValue("@custRef", custRef);
            mCmd.Parameters.AddWithValue("@custNameArabic", custNameArabic);
            mCmd.Parameters.AddWithValue("@DeviceName", DeviceName);
            mCmd.Parameters.AddWithValue("@cusAdd2", cusAdd2);
            mCmd.Parameters.AddWithValue("@creditLimit", creditLimit);
            mCmd.Parameters.AddWithValue("@cusTele", cusTele);
            mCmd.Parameters.AddWithValue("@cusMob", cusMob);
            mCmd.Parameters.AddWithValue("@cusFax", cusFax);
            mCmd.Parameters.AddWithValue("@cusEmail", cusEmail);
            mCmd.Parameters.AddWithValue("@AccountName", AccountName);
            mCmd.Parameters.AddWithValue("@salesman", salesman);
            mCmd.Parameters.AddWithValue("@emirates", emirates);
            mCmd.Parameters.AddWithValue("@paymentMode", paymentMode);
            mCmd.Parameters.AddWithValue("@nofOfdays", nofOfdays);
            mCmd.Parameters.AddWithValue("@OpeningBalance", OpeningBalance);
            mCmd.Parameters.AddWithValue("@OpeningBalanceDate", OpeningBalanceDate);
            mCmd.Parameters.AddWithValue("@CustMargin", CustMargin);
            mCmd.Parameters.AddWithValue("@CustStatus", CustStatus);
            mCmd.Parameters.AddWithValue("@CostCentre", CostCentre);
           

            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            int ReturnVal = 0;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.ExecuteNonQuery();
                ReturnVal = Convert.ToInt32(mCmd.Parameters["@ReturnValue"].Value.ToString());
            }
            catch (Exception ex)
            {

            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return ReturnVal;
        }

        //Get the Customer Details and populate it in the datagridview
        public static List<cusotomerDetails_master> Get()
        {
            List<cusotomerDetails_master> mList = new List<cusotomerDetails_master>();

            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "Sp_Customer_Get_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new cusotomerDetails_master
                    {
                        custID = mDr["custID"].ToString(),
                        custName = mDr["custName"].ToString(),
                        cusMob = mDr["cusMob"].ToString(),
                        cusAdd1 = mDr["cusAdd1"].ToString(),
                        cusEmail= mDr["cusEmail"].ToString(),
                        CostCentre= mDr["CostCentre"].ToString(),
                        DeviceName=mDr["DeviceName"].ToString(),
                        custRef=mDr["custRef"].ToString(),
                        custNameArabic = mDr["custNameArabic"].ToString(),
                        cusAdd2 = mDr["cusAdd2"].ToString(),
                        cusTele = mDr["cusTele"].ToString(),
                        creditLimit = mDr["creditLimit"].ToString(),
                        cusFax = mDr["cusFax"].ToString(),
                        AccountName = mDr["AccountName"].ToString(),
                        salesman = mDr["salesman"].ToString(),
                        emirates = mDr["emirates"].ToString(),
                        paymentMode = mDr["paymentMode"].ToString(),
                        nofOfdays = (mDr["nofOfdays"]).ToString(),
                        OpeningBalance = mDr["OpeningBalance"] == DBNull.Value ? 0: Convert.ToDouble(mDr["OpeningBalance"]),
                        OpeningBalanceDate = mDr["OpeningBalanceDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(mDr["OpeningBalanceDate"]),
                        CustMargin = mDr["CustMargin"] == DBNull.Value ? 0 : Convert.ToDouble(mDr["CustMargin"]),
                        CustStatus = mDr["CustStatus"].ToString()


                    });
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mList;
        }

        //Getting next customer id 
        public static string GetNextIDValue()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SP_NoSeries_Customer_WinApp", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                    return dt.Rows[0][0].ToString();
                else
                    return "";
            }

        }

        public static List<cusotomerDetails_master> GetSalesman()
        {
            List<cusotomerDetails_master> mList = new List<cusotomerDetails_master>();

            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "Sp_Staffdetails_Get_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new cusotomerDetails_master
                    {

                        salesman = mDr["FirstName"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mList;
        }

        public static List<cusotomerDetails_master> GetCostCenter()
        {
            List<cusotomerDetails_master> mList = new List<cusotomerDetails_master>();

            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "Sp_Branch_Get_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new cusotomerDetails_master
                    {
                        CostCentre = mDr["branchname"].ToString(),                      
                    });
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mList;
        }


    
    }


    [Serializable]
    public class cusotomerDetails_master
    {
        public string custID { get; set; }
        public string custName { get; set; }
        public string cusAdd1 { get; set; }
        public string custRef { get; set; }
        public string custNameArabic { get; set; }
        public string DeviceName { get; set; }
        public string cusAdd2 { get; set; }
        public string creditLimit { get; set; }
        public string cusTele { get; set; }
        public string cusMob { get; set; }
        public string cusFax { get; set; }
        public string cusEmail { get; set; }
        public string AccountName { get; set; }
        public string salesman { get; set; }
        public string emirates { get; set; }
        public string paymentMode { get; set; }
        public string nofOfdays { get; set; }
        public double OpeningBalance { get; set; }
        public DateTime OpeningBalanceDate { get; set; }
        public double CustMargin { get; set; }
        public string CustStatus { get; set; }
        public string CostCentre { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string UserID { get; set; }
    }
}
