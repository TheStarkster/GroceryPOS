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
    public class Creditcard
    {
        public static Int32 SP_Creditcard(Nullable<int> ACTION, string ID, string Name, string Bank, string comisonrate, string UserID)
        {
            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "SP_Creditcard";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@ACTION", ACTION);
            mCmd.Parameters.AddWithValue("@ID", ID);
            mCmd.Parameters.AddWithValue("@Name", Name);
            mCmd.Parameters.AddWithValue("@Bank", Bank);
            mCmd.Parameters.AddWithValue("@comisonrate", comisonrate);
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

        public static List<creditcard_master> Get()
        {
            List<creditcard_master> mList = new List<creditcard_master>();

            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "Sp_Creditcard_Get_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new creditcard_master
                    {
                        ID = mDr["ID"].ToString(),
                        Name = mDr["Name"].ToString(),
                        Bank = mDr["Bank"].ToString(),
                        CommissionRate = mDr["CommissionRate"].ToString(),
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

            using (SqlCommand cmd = new SqlCommand("SP_NoSeries_CreditcardMaster_WinApp", GroceryDML.Connection))
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
    public class creditcard_master
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Bank { get; set; }
        public string CommissionRate { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string UserID { get; set; }
        public string LastUpdatedUserID { get; set; }
    }
}
