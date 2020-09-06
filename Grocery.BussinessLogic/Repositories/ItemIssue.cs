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
    public class ItemIssue
    {
        SqlConnection con = GroceryDML.Connection;

        public static DataSet Get(string type, string issueId)
        {
            DataSet ds = new DataSet();

            using (SqlCommand cmd = new SqlCommand("Sp_ItemIssue_Get_win", GroceryDML.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                cmd.Parameters.Add("@issueId", SqlDbType.VarChar).Value = issueId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
        public static string Set(issue_master objHeader, List<issue_details> objLine)
        {
            SqlConnection con = GroceryDML.Connection;
            SqlTransaction transaction = null;
            string msg = "SUCCESS";
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("Sp_ItemIssue_Set_win", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 4;
                    cmd.Parameters.Add("@issueId", SqlDbType.VarChar).Value = objHeader.issueId;
                    cmd.Parameters.Add("@IssueDate", SqlDbType.Date).Value = objHeader.IssueDate;
                    cmd.Parameters.Add("@IssueType", SqlDbType.VarChar).Value = objHeader.IssueType;
                    cmd.Parameters.Add("@refNo", SqlDbType.VarChar).Value = objHeader.refNo;


                    cmd.Parameters.Add("@netAmount", SqlDbType.Decimal).Value = objHeader.netAmount;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = objHeader.Description;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = objHeader.Quantity;


                    cmd.Parameters.Add("@UserId", SqlDbType.VarChar).Value = objHeader.UserId;
                    cmd.Parameters.Add("@branchid", SqlDbType.VarChar).Value = objHeader.branchid;
                    cmd.Parameters.Add("@FinancialYear", SqlDbType.VarChar).Value = objHeader.FinancialYear;

                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand("Sp_ItemIssue_Set_win", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 3;
                    cmd.Parameters.Add("@issueId", SqlDbType.VarChar).Value = objHeader.issueId;
                    cmd.ExecuteNonQuery();
                }

                int i = 1;
                foreach (var item in objLine)
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_ItemIssue_Set_win", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = transaction;

                        cmd.Parameters.Add("@ACTION", SqlDbType.Int).Value = 2;

                        cmd.Parameters.Add("@issueId", SqlDbType.VarChar).Value = item.issueId;
                        cmd.Parameters.Add("@itemID", SqlDbType.VarChar).Value = item.itemID;
                        cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = item.Barcode;
                        cmd.Parameters.Add("@Unit", SqlDbType.VarChar).Value = item.Unit;
                        cmd.Parameters.Add("@salesQty", SqlDbType.Decimal).Value = item.salesQty;
                        cmd.Parameters.Add("@unitPrice", SqlDbType.Decimal).Value = item.unitPrice;
                        cmd.Parameters.Add("@totalAmount", SqlDbType.Decimal).Value = item.totalAmount;
                        cmd.Parameters.Add("@baseQty", SqlDbType.Decimal).Value = item.baseQty;
                        cmd.Parameters.Add("@transid", SqlDbType.VarChar).Value = item.issueId + "_" + i.ToString();

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
    public class issue_master
    {
        public string issueId { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string IssueType { get; set; }
        public decimal Quantity { get; set; }
        public decimal netAmount { get; set; }
        public string refNo { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string branchid { get; set; }
        public string UserId { get; set; }
        public string FinancialYear { get; set; }

    }

    [Serializable]
    public class issue_details
    {
        public string issueId { get; set; }
        public string itemID { get; set; }
        public decimal Unit { get; set; }
        public decimal salesQty { get; set; }
        public decimal unitPrice { get; set; }
        public decimal totalAmount { get; set; }
        public decimal baseQty { get; set; }
        public string Barcode { get; set; }
        public string transid { get; set; }

    }

}
