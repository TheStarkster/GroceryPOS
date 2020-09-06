using Grocery.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.BussinessLogic.Repositories
{
    public class SupplierDetails
    {
        public static Int32 SP_Supplier(Nullable<int> ACTION, string suppID, string suppName, string suppAdd1, string suppAdd2, string suppTele, string suppFax,
            string suppMob, string suppEmail, string accountName, int creditLimit, string paymentMode, int nofOfdays, int OpeningBalance, DateTime OpeningBalanceDate,
            string emirates, string BranchId)
        {
            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "SP_Supplier";
            mCmd.CommandType = CommandType.StoredProcedure;

            mCmd.Parameters.AddWithValue("@ACTION", ACTION);
            mCmd.Parameters.AddWithValue("@suppID", suppID);
            mCmd.Parameters.AddWithValue("@suppName", suppName);
            mCmd.Parameters.AddWithValue("@suppAdd1", suppAdd1);
            mCmd.Parameters.AddWithValue("@suppAdd2", suppAdd2);
            mCmd.Parameters.AddWithValue("@suppTele", suppTele);
            mCmd.Parameters.AddWithValue("@suppFax", suppFax);
            mCmd.Parameters.AddWithValue("@suppMob", suppMob);
            mCmd.Parameters.AddWithValue("@suppEmail", suppEmail);
            mCmd.Parameters.AddWithValue("@accountName", accountName);
            mCmd.Parameters.AddWithValue("@creditLimit", creditLimit);
            mCmd.Parameters.AddWithValue("@paymentMode", paymentMode);
            mCmd.Parameters.AddWithValue("@nofOfdays", nofOfdays);
            mCmd.Parameters.AddWithValue("@OpeningBalance", OpeningBalance);
            mCmd.Parameters.AddWithValue("@OpeningBalanceDate", OpeningBalanceDate);
            mCmd.Parameters.AddWithValue("@emirates", emirates);
            mCmd.Parameters.AddWithValue("@BranchId", BranchId);

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

        public static List<supplier_master> Get()
        {
            List<supplier_master> mList = new List<supplier_master>();

            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "Sp_Supplier_Get_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;

            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new supplier_master
                    {
                        suppID = mDr["suppID"].ToString(),
                        suppName=mDr["suppName"].ToString(),
                        suppAdd1=mDr["suppAdd1"].ToString(),
                        suppAdd2=mDr["suppAdd2"].ToString(),
                        suppTele=mDr["suppTele"].ToString(),
                        suppFax=mDr["suppFax"].ToString(),
                        suppMob=mDr["suppMob"].ToString(),
                        suppEmail=mDr["suppEmail"].ToString(),
                        accountName=mDr["accountName"].ToString(),
                        creditLimit=Convert.ToInt32(mDr["creditLimit"]),
                        paymentMode=mDr["paymentMode"].ToString(),
                        nofOfdays=Convert.ToInt32(mDr["nofOfdays"]),
                        OpeningBalance=Convert.ToInt32(mDr["OpeningBalance"]),
                        OpeningBalanceDate=Convert.ToDateTime(mDr["OpeningBalanceDate"]),
                        emirates=mDr["emirates"].ToString(),
                        BranchId=mDr["BranchId"].ToString()
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

        public static string GetNextIDValue()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SP_NoSeries_Supplier_WinApp", GroceryDML.Connection))
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

        public static List<supplier_master> GetCostCenter()
        {
            List<supplier_master> mList = new List<supplier_master>();

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
                    mList.Add(new supplier_master
                    {
                        BranchId = mDr["branchid"].ToString(),
                        BranchName = mDr["branchname"].ToString()
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


        [Serializable]
        public class supplier_master
        {
            public string suppID { get; set; }
            public string suppName { get; set; }
            public string suppAdd1 { get; set; }
            public string suppAdd2 { get; set; }
            public string suppTele { get; set; }
            public string suppFax { get; set; }
            public string suppMob { get; set; }
            public string suppEmail { get; set; }
            public string accountName { get; set; }
            public int creditLimit { get; set; }
            public string paymentMode { get; set; }
            public int nofOfdays { get; set; }
            public int OpeningBalance { get; set; }
            public DateTime OpeningBalanceDate { get; set; }
            public string emirates { get; set; }
            public string BranchId { get; set; }
            public string BranchName { get; set; }
            public Nullable<System.DateTime> createdate { get; set; }
            public Nullable<System.DateTime> LastUpdateDate { get; set; }

        }

    }
}
