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
    public class PurchaseInvoice
    {
        SqlConnection con = GroceryDML.Connection;

        public static DataSet Get(string type, string invoiceId)
        {
            DataSet ds = new DataSet();

            using (SqlCommand cmd = new SqlCommand("Sp_purchase_Get_win", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@invoiceId", SqlDbType.VarChar).Value = invoiceId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
        public static string Set(purchase_master objHeader, List<purchase_details> objLine)
        {
            SqlConnection con = GroceryDML.Connection;
            SqlTransaction transaction = null;
            string msg = "SUCCESS";
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("Sp_purchase_Set_win", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 4;
                    cmd.Parameters.Add("@invoiceId", SqlDbType.VarChar).Value = objHeader.invoiceId;
                    cmd.Parameters.Add("@custId", SqlDbType.VarChar).Value = objHeader.custId;
                    cmd.Parameters.Add("@salesDate", SqlDbType.Date).Value = objHeader.salesDate;
                    cmd.Parameters.Add("@salesType", SqlDbType.VarChar).Value = objHeader.salesType;

                    cmd.Parameters.Add("@totalAmount", SqlDbType.Decimal).Value = objHeader.totalAmount;
                    cmd.Parameters.Add("@discAmount", SqlDbType.Decimal).Value = objHeader.discAmount;
                    cmd.Parameters.Add("@netAmount", SqlDbType.Decimal).Value = objHeader.netAmount;

                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = objHeader.Description;
                    cmd.Parameters.Add("@purcurrency", SqlDbType.VarChar).Value = objHeader.purcurrency;
                    cmd.Parameters.Add("@currate", SqlDbType.VarChar).Value = objHeader.currate;
                    cmd.Parameters.Add("@activityDate", SqlDbType.Date).Value = objHeader.activityDate;
                    //cmd.Parameters.Add("@delterms", SqlDbType.VarChar).Value = objHeader.delterms;
                    //cmd.Parameters.Add("@priceterms", SqlDbType.VarChar).Value = objHeader.priceterms;
                    //cmd.Parameters.Add("@paymentterms", SqlDbType.VarChar).Value = objHeader.paymentterms;
                    ////cmd.Parameters.Add("@TotalVAT", SqlDbType.Decimal).Value = objHeader.TotalVAT;
                    //cmd.Parameters.Add("@LpoType", SqlDbType.VarChar).Value = objHeader.LpoType;

                    cmd.Parameters.Add("@UserId", SqlDbType.VarChar).Value = objHeader.UserId;
                    cmd.Parameters.Add("@branchid", SqlDbType.VarChar).Value = objHeader.branchid;
                    cmd.Parameters.Add("@FinancialYear", SqlDbType.VarChar).Value = objHeader.FinancialYear;

                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand("Sp_purchase_Set_win", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 3;
                    cmd.Parameters.Add("@invoiceId", SqlDbType.VarChar).Value = objHeader.invoiceId;
                    cmd.ExecuteNonQuery();
                }

                int i = 1;
                foreach (var item in objLine)
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_purchase_Set_win", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = transaction;

                        cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 2;

                        cmd.Parameters.Add("@invoiceId", SqlDbType.VarChar).Value = item.invoiceId;
                        cmd.Parameters.Add("@itemID", SqlDbType.VarChar).Value = item.itemID;
                        //cmd.Parameters.Add("@itemDesc", SqlDbType.VarChar).Value = item.itemDesc;
                        cmd.Parameters.Add("@Unit", SqlDbType.VarChar).Value = item.Unit;
                        cmd.Parameters.Add("@salesQty", SqlDbType.Decimal).Value = item.salesQty;
                        cmd.Parameters.Add("@unitPrice", SqlDbType.Decimal).Value = item.unitPrice;
                        cmd.Parameters.Add("@totalAmount", SqlDbType.Decimal).Value = item.totalAmount;
                        cmd.Parameters.Add("@DiscPerc", SqlDbType.Decimal).Value = item.DiscPerc;
                        cmd.Parameters.Add("@Discount", SqlDbType.Decimal).Value = item.Discount;
                        cmd.Parameters.Add("@netamount", SqlDbType.Decimal).Value = item.netamount;
                        cmd.Parameters.Add("@BaseQty", SqlDbType.Decimal).Value = item.BaseQty;
                        cmd.Parameters.Add("@BonusQty", SqlDbType.Decimal).Value = item.BonusQty;
                        cmd.Parameters.Add("@netQty", SqlDbType.Decimal).Value = item.netQty;
                        cmd.Parameters.Add("@transid", SqlDbType.VarChar).Value = item.invoiceId + "_" + i.ToString();

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
    public class purchase_master
    {
        public string invoiceId { get; set; }
        public string custId { get; set; }
        public Nullable<System.DateTime> salesDate { get; set; }
        public string salesType { get; set; }
        public decimal totalAmount { get; set; }
        public string custRefe { get; set; }
        public decimal fixingCharge { get; set; }
        public decimal discAmount { get; set; }
        public decimal netAmount { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> activityDate { get; set; }
        public string Description { get; set; }
        public string lpoNumber { get; set; }
        public string purcurrency { get; set; }
        public string currate { get; set; }
        public Nullable<System.DateTime> duedate { get; set; }
        public int advance { get; set; }
        public decimal TotalVAT { get; set; }
        public string emirates { get; set; }
        public string salesinvoice { get; set; }
        public string branchid { get; set; }
        public string UserId { get; set; }
        public string FinancialYear { get; set; }
    }

    [Serializable]
    public class purchase_details
    {
        public string invoiceId { get; set; }
        public string itemID { get; set; }
        public decimal Unit { get; set; }
        public string UOM_Name { get; set; }
        public decimal salesQty { get; set; }
        public decimal unitPrice { get; set; }
        public decimal totalAmount { get; set; }
        public decimal DiscPerc { get; set; }
        public decimal Discount { get; set; }
        public decimal netamount { get; set; }
        public decimal BonusQty { get; set; }
        public decimal netQty { get; set; }
        public string Barcode { get; set; }
        public string itemDesc { get; set; }
        public decimal BaseQty { get; set; }
        public string whid { get; set; }
        public decimal unitratepurcur { get; set; }
        public decimal FOCAmount { get; set; }
        public decimal taxperc { get; set; }
        public decimal taxamount { get; set; }
        public string transid { get; set; }


    }

}
