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
    public class Uom
    {
        public static Int32 SP_Uom(Nullable<int> ACTION, string UOMId, string UOM_Name, string UOM_Printas, string UserID)
        {
            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "SP_Uom";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@ACTION", ACTION);
            mCmd.Parameters.AddWithValue("@UOMId", UOMId);
            mCmd.Parameters.AddWithValue("@UOM_Name", UOM_Name);
            mCmd.Parameters.AddWithValue("@UOM_Printas", UOM_Printas);
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

        public static List<uom_master> Get()
        {
            List<uom_master> mList = new List<uom_master>();

            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "Sp_Uom_Get_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new uom_master
                    {
                        UOMId = Convert.ToInt32(mDr["UOMId"].ToString()),
                        UOM_Name = mDr["UOM_Name"].ToString(),
                        UOM_Printas = mDr["UOM_Printas"].ToString(),
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

            using (SqlCommand cmd = new SqlCommand("SP_NoSeries_UomMaster_WinApp", GroceryDML.Connection))
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
    public class uom_master
    {
        public int UOMId { get; set; }
        public string UOM_Name { get; set; }
        public string UOM_Printas { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string UserID { get; set; }
        public string LastUpdatedUserID { get; set; }
    }
}
