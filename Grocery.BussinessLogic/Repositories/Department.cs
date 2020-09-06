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
    public class Department
    {
        public static Int32 SP_Department(Nullable<int> ACTION, string Dpt_Id, string Dtp_Name, string DepartmentDesc, string arabicname, string UserID)
        {
            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "SP_Department";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@ACTION", ACTION);
            mCmd.Parameters.AddWithValue("@Dpt_Id", Dpt_Id);
            mCmd.Parameters.AddWithValue("@Dtp_Name", Dtp_Name);
            mCmd.Parameters.AddWithValue("@DepartmentDesc", DepartmentDesc);
            mCmd.Parameters.AddWithValue("@arabicname", arabicname);
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

        public static List<department_master> Get()
        {
            List<department_master> mList = new List<department_master>();

            SqlConnection mCon = GroceryDML.Connection;
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "Sp_Department_Get_WinApp";
            mCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new department_master
                    {
                        Dpt_Id = mDr["Dpt_Id"].ToString(),
                        Dtp_Name = mDr["Dtp_Name"].ToString(),
                        DepartmentDesc = mDr["DepartmentDesc"].ToString(),
                        arabicname = mDr["arabicname"].ToString(),
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

            using (SqlCommand cmd = new SqlCommand("SP_NoSeries_DepartmentMaster_WinApp", GroceryDML.Connection))
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
    public class department_master
    {
        public string Dpt_Id { get; set; }
        public string Dtp_Name { get; set; }
        public string DepartmentDesc { get; set; }
        public string arabicname { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string UserID { get; set; }
        public string LastUpdatedUserID { get; set; }
    }
}
