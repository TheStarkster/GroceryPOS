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
    public class CustomerPriceList
    {
        SqlConnection con = GroceryDML.Connection;

        public static DataSet Get(string type, string itemID, string custId)
        {
            DataSet ds = new DataSet();

            using (SqlCommand cmd = new SqlCommand("SP_Customer_PriceList_Get_win", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@itemID", SqlDbType.VarChar).Value = itemID;
                cmd.Parameters.Add("@custId", SqlDbType.VarChar).Value = custId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
        public static string Set(int ACTION,cust_Pricelist objHeader)
        {
            SqlConnection con = GroceryDML.Connection;
            SqlTransaction transaction = null;
            string msg = "SUCCESS";
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("SP_Customer_PriceList_set_win", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = ACTION;
                    cmd.Parameters.Add("@custId", SqlDbType.VarChar).Value = objHeader.custId;
                    cmd.Parameters.Add("@itemID", SqlDbType.VarChar).Value = objHeader.itemID;
                    cmd.Parameters.Add("@updatedDate", SqlDbType.Date).Value = objHeader.updatedDate;
                    cmd.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = objHeader.Barcode;
                    cmd.Parameters.Add("@itemCost", SqlDbType.Decimal).Value = objHeader.itemCost;

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
    public class cust_Pricelist
    {
        public string custId { get; set; }
        public string itemID { get; set; }
        public string Barcode { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public decimal itemCost { get; set; }

    }


}
