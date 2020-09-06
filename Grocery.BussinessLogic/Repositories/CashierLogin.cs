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
    public class CashierLogin
    {
        
        public DataTable GetBranches()
        {
            DataTable ds = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SP_GetAllBranches", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
        public DataTable GetUsers(String branchId)
        {
            DataTable ds = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SP_GetUsers", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BranchId", branchId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
    }
}
