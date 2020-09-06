using Grocery.BussinessLogic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery.Admin.Common
{
    public static class GolobalItems
    {
        public static string UserId = "kaleem";
        public static string BranchCode = "B01";
        public static string BranchName = "ZAHER";
        public static string FinancialYear = "1920-21";
        public static string MessageCaption = "Grocery System";
        public static string UniqueId;
        public static ListBox glbListItem = new ListBox();


        public static string NullToString(object Value)
        {
            return Value == null ? "" : Value.ToString();
        }
        public static decimal NullToNumber(object stringVal)
        {
            decimal decimalVal = 0;

            try
            {
                decimalVal = System.Convert.ToDecimal(stringVal);

            }
            catch (System.OverflowException)
            {
                decimalVal = 0;
            }
            catch (System.FormatException)
            {
                decimalVal = 0;
            }
            catch (System.ArgumentNullException)
            {
                decimalVal = 0;
            }

            return decimalVal;
        }


        public static void ComboBoxBind(ComboBox cob, string type, string condition = "")
        {
            try
            {
                cob.ValueMember = "Code";
                cob.DisplayMember = "Description";
                cob.DataSource = CommonFunction.GetComboBoxData(type, condition);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }
    }
}
