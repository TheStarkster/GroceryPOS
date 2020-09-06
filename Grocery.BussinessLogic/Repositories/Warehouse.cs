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
    public class Warehouse
    {
        public static Int32 SP_Warehouse(Nullable<int> ACTION, string WhID, string WhName, string EmpID, string UserID)
        {
            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "SP_Warehouse_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@ACTION", ACTION);
            mCmd.Parameters.AddWithValue("@WhID", WhID);
            mCmd.Parameters.AddWithValue("@WhName", WhName);
            mCmd.Parameters.AddWithValue("@EmpID", EmpID);
            mCmd.Parameters.AddWithValue("@UserID", UserID);
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

        public static List<warehouse_master> Get()
        {
            List<warehouse_master> mList = new List<warehouse_master>();

            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "Sp_Warehouse_Get_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new warehouse_master
                    {
                        WhID = mDr["WhID"].ToString(),
                        WhName = mDr["WhName"].ToString(),
                        EmpID = mDr["EmpID"].ToString(),
                        Salesman = mDr["Salesman"].ToString(),
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

            using (SqlCommand cmd = new SqlCommand("SP_NoSeries_Warehouse_WinApp", GroceryDML.Connection))
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

        public static List<warehouse_master> GetSalesman()
        {
            List<warehouse_master> mList = new List<warehouse_master>();

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
                    mList.Add(new warehouse_master
                    {
                        EmpID = mDr["StaffId"].ToString(),
                        Salesman = mDr["FirstName"].ToString(),
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
    public class warehouse_master
    {
        public string WhID { get; set; }
        public string WhName { get; set; }
        public string EmpID { get; set; }
        public string Salesman { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string UserID { get; set; }
        public string LastUpdatedUserID { get; set; }
    }
}
