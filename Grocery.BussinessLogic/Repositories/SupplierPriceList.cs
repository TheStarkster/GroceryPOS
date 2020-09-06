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
    public class SupplierPriceList
    {
        SqlConnection con = GroceryDML.Connection;

        public static DataSet Get(string type, string item, string category,string Subcategory,string Barcode,string suppId)
        {
            DataSet ds = new DataSet();

            using (SqlCommand cmd = new SqlCommand("SP_supp_Pricelist_Get_win", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@item", SqlDbType.VarChar).Value = item;
                cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = category;
                cmd.Parameters.Add("@Subcategory", SqlDbType.VarChar).Value = Subcategory;
                cmd.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = Barcode;
                cmd.Parameters.Add("@suppId", SqlDbType.VarChar).Value = suppId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
        public static string Set(int ACTION, List<supp_Pricelist>   objLine)
        {

            SqlConnection con = GroceryDML.Connection;
            SqlTransaction transaction = null;
            string msg = "SUCCESS";
            try
            {
                con.Open();
                transaction = con.BeginTransaction();

                foreach (var item in objLine)
                {
                    using (SqlCommand cmd = new SqlCommand("SP_supp_Pricelist_set_win", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = transaction;

                        cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = ACTION;

                        cmd.Parameters.Add("@suppId", SqlDbType.VarChar).Value = item.suppId;
                        cmd.Parameters.Add("@itemID", SqlDbType.VarChar).Value = item.itemID;
                        cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = item.Barcode;
                        cmd.Parameters.Add("@itemCost", SqlDbType.Decimal).Value = item.itemCost;

                        cmd.Parameters.Add("@UserId", SqlDbType.VarChar).Value = item.UserId;
                        cmd.Parameters.Add("@branchid", SqlDbType.VarChar).Value = item.branchid;
                        cmd.Parameters.Add("@FinancialYear", SqlDbType.VarChar).Value = item.FinancialYear;

                        cmd.ExecuteNonQuery();
                    }
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
    public class supp_Pricelist
    {
        public string suppId { get; set; }
        public string itemID { get; set; }
        public string Barcode { get; set; }
        public decimal itemCost { get; set; }

        public string UserId { get; set; }
        public string branchid { get; set; }
        public string FinancialYear { get; set; }


    }


}
