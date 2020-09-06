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
    public class CommonFunction
    {
        public static string GenerateNoSeries(string BranchCode, string FormSeriesCode)
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("sp_NoSeries_Generate", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@BranchCode", SqlDbType.VarChar).Value = BranchCode;
                cmd.Parameters.Add("@FormSeriesCode", SqlDbType.VarChar).Value = FormSeriesCode;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                    return dt.Rows[0][0].ToString();
                else
                    return "";
            }

        }

        public static DataTable GetListView(string FormSeriesCode)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetListView", GroceryDML.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FormSeriesCode", SqlDbType.VarChar).Value = FormSeriesCode;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                }
            }
            catch (Exception ex) { }
            if (dt.Rows.Count > 0)
                return dt;
            else
                return null;
        }

        public static DataTable GetListItem(string type, string Code = "")
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetListItem", GroceryDML.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = @type;
                    cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = Code;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex) { }
            if (dt.Rows.Count > 0)
                return dt;
            else
                return null;
        }

        public static DataTable GetComboBoxData(string type, string condition = "")
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_Dropdown_Bind", GroceryDML.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                    cmd.Parameters.Add("@condition", SqlDbType.VarChar).Value = condition;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                }

            }
            catch (Exception ex) { }
            if (dt.Rows.Count > 0)
                return dt;
            else
                return null;

        }

    }
}
