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
    public class Stocklocation
    {
        public static Int32 SP_StockLocation(Nullable<int> ACTION, string StockId, string StockLocation, string StockDesc, string UserID)
        {
            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "SP_Stocklocation";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@ACTION", ACTION);
            mCmd.Parameters.AddWithValue("@StockId", StockId);
            mCmd.Parameters.AddWithValue("@StockLocation", StockLocation);
            mCmd.Parameters.AddWithValue("@StockDesc", StockDesc);
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

        public static List<stocklocation_master> Get()
        {
            List<stocklocation_master> mList = new List<stocklocation_master>();

            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "Sp_Stocklocation_Get_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new stocklocation_master
                    {
                        StockId = mDr["StockId"].ToString(),
                        StockLocation = mDr["StockLocation"].ToString(),
                        StockDesc = mDr["StockDesc"].ToString(),
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

            using (SqlCommand cmd = new SqlCommand("SP_NoSeries_StocklocationMaster_WinApp", GroceryDML.Connection))
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
    }
    [Serializable]
    public class stocklocation_master
    {
        public string StockId { get; set; }
        public string StockLocation { get; set; }
        public string StockDesc { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string UserID { get; set; }
        public string LastUpdatedUserID { get; set; }
    }
}
