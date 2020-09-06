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
    public class OfferCreation
    {
        SqlConnection con = GroceryDML.Connection;

        public static DataSet Get(string type, string offerID, string item, string category, string Subcategory, string Barcode)
        {
            DataSet ds = new DataSet();

            using (SqlCommand cmd = new SqlCommand("Sp_OfferCreation_Get_win", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@item", SqlDbType.VarChar).Value = item;
                cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = category;
                cmd.Parameters.Add("@Subcategory", SqlDbType.VarChar).Value = Subcategory;
                cmd.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = Barcode;
                cmd.Parameters.Add("@offerID", SqlDbType.VarChar).Value = offerID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
        public static string Set(offer_master objHeader, List<offer_details> objLine)
        {
            SqlConnection con = GroceryDML.Connection;
            SqlTransaction transaction = null;
            string msg = "SUCCESS";
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("Sp_offerCreate_Set_win", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 4;
                    cmd.Parameters.Add("@offerID", SqlDbType.VarChar).Value = objHeader.offerID;
                    cmd.Parameters.Add("@offerName", SqlDbType.VarChar).Value = objHeader.offerName;
                    cmd.Parameters.Add("@offerDesc", SqlDbType.VarChar).Value = objHeader.offerDesc;

                    cmd.Parameters.Add("@createdate", SqlDbType.Date).Value = objHeader.createdate;
                    cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = objHeader.StartDate;
                    cmd.Parameters.Add("@endDate", SqlDbType.Date).Value = objHeader.endDate;

                    cmd.Parameters.Add("@UserId", SqlDbType.VarChar).Value = objHeader.UserId;
                    cmd.Parameters.Add("@branchid", SqlDbType.VarChar).Value = objHeader.branchid;
                    cmd.Parameters.Add("@FinancialYear", SqlDbType.VarChar).Value = objHeader.FinancialYear;

                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand("Sp_offerCreate_Set_win", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 3;
                    cmd.Parameters.Add("@offerID", SqlDbType.VarChar).Value = objHeader.offerID;
                    cmd.ExecuteNonQuery();
                }

                int i = 1;
                foreach (var item in objLine)
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_offerCreate_Set_win", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = transaction;

                        cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 2;

                        cmd.Parameters.Add("@offerID", SqlDbType.VarChar).Value = item.offerID;
                        cmd.Parameters.Add("@itemID", SqlDbType.VarChar).Value = item.itemID;
                        cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = item.Barcode;
                        cmd.Parameters.Add("@Discount", SqlDbType.VarChar).Value = item.Discount;
                        cmd.Parameters.Add("@fixedPrice", SqlDbType.Decimal).Value = item.fixedPrice;
                        cmd.Parameters.Add("@transid", SqlDbType.VarChar).Value = item.offerID + "_" + i.ToString();

                        cmd.ExecuteNonQuery();
                        i++;
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
    public class offer_master
    {
        public string offerID { get; set; }
        public string offerName { get; set; }
        public string offerDesc { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public string branchid { get; set; }
        public string UserId { get; set; }
        public string FinancialYear { get; set; }
    }

    [Serializable]
    public class offer_details
    {
        public string offerID { get; set; }
        public string itemID { get; set; }
        public string Barcode { get; set; }
        public decimal Discount { get; set; }
        public decimal fixedPrice { get; set; }
        public string transid { get; set; }

    }

}
