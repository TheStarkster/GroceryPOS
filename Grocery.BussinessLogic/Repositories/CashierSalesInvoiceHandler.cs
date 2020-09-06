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
    class CashierSalesInvoiceHandler
    {
        SqlConnection Connection = GroceryDML.Connection;
        ///This Method Allows To Put Product's Details By Scanning/Manually Putting BarCode Number...
        public DataTable PutItemInGrid(String barCode)
        {
            DataTable ds = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SP_GetItemDetails_win", Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BarCode", barCode);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
    }
}
