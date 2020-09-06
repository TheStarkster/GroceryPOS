using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grocery.BusinessLogic.Repositories;
using Grocery.DataAccess.IRepositories;
using Grocery.DataAccess.Model;
using System.Data.SqlClient;
using System.Data;

namespace Grocery.BussinessLogic.Repositories
{
    public class CustomerProjects
    {
        SqlConnection con = GroceryDML.Connection;

        public static DataSet Get(string type, string ProjectID)
        {
            DataSet ds = new DataSet();

            using (SqlCommand cmd = new SqlCommand("SP_ProjectMaster_Get_win", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@ProjectID", SqlDbType.VarChar).Value = ProjectID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
        public static string Set( project_Master objHeader)
        {
            SqlConnection con = GroceryDML.Connection;
            SqlTransaction transaction = null;
            string msg = "SUCCESS";
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("SP_ProjectMaster_set_win", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 2;
                    cmd.Parameters.Add("@ProjectID", SqlDbType.VarChar).Value = objHeader.ProjectID;
                    cmd.Parameters.Add("@prjct_projectName", SqlDbType.VarChar).Value = objHeader.prjct_projectName;
                    cmd.Parameters.Add("@Prjct_clientID", SqlDbType.VarChar).Value = objHeader.Prjct_clientID;
                    cmd.Parameters.Add("@prjct_Area", SqlDbType.VarChar).Value = objHeader.prjct_Area;
                    cmd.Parameters.Add("@prjct_Location", SqlDbType.VarChar).Value = objHeader.prjct_Location;
                    cmd.Parameters.Add("@prjct_startDate", SqlDbType.Date).Value = objHeader.prjct_startDate;
                    cmd.Parameters.Add("@prjct_endDate", SqlDbType.Date).Value = objHeader.prjct_endDate;

                    cmd.Parameters.Add("@prjct_currentStatus", SqlDbType.VarChar).Value = objHeader.prjct_currentStatus;
                    cmd.Parameters.Add("@prjct_description", SqlDbType.VarChar).Value = objHeader.prjct_description;
                    cmd.Parameters.Add("@prjct_ref", SqlDbType.VarChar).Value = objHeader.prjct_ref;
                    cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = objHeader.Status;
                    cmd.Parameters.Add("@projectnote", SqlDbType.VarChar).Value = objHeader.projectnote;

                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex) { msg = ex.Message; transaction.Rollback(); }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return msg;
        }
    }

    [Serializable]
    public class project_Master
    {
        public string ProjectID { get; set; }
        public string prjct_projectName { get; set; }
        public string Prjct_clientID { get; set; }
        public string prjct_Area { get; set; }
        public string prjct_Location { get; set; }
        public Nullable<System.DateTime> prjct_startDate { get; set; }
        public Nullable<System.DateTime> prjct_endDate { get; set; }
        public string prjct_currentStatus { get; set; }
        public string prjct_description { get; set; }
        public string prjct_ref { get; set; }
        public string Status { get; set; }
        public string projectnote { get; set; }

    }


}
