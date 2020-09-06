using Grocery.Admin.Common;
using Grocery.Admin.UControl;
using Grocery.BussinessLogic.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery.Admin.Transactions
{
    public partial class frm_Transactions_SupplierPriceList : Form
    {
        string msg = "";
        int Action = 0;

        public frm_Transactions_SupplierPriceList()
        {
            InitializeComponent();
            forminitialization();
        }

        private void forminitialization()
        {

            try
            {
                GridDesign();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F6)
            {
                if (this.ActiveControl is ucComboBox)
                {
                    PopulatePopGrid(((Grocery.Admin.UControl.ucComboBox)this.ActiveControl).Tag.ToString());
                    return true;
                }
            }
            else if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void frm_Transactions_SupplierPriceList_Load(object sender, EventArgs e)
        {


        }

        #region "Data Grid View & Function Key Activity" 
        string PopupForm_Flag = "";
        private void PopulatePopGrid(string mode)
        {
            frm_Common_List objForm = new frm_Common_List();
            DataTable oTable = new DataTable();
            PopupForm_Flag = mode;
            try
            {

                if (mode == "SUPPLIER_LIST") { oTable = CommonFunction.GetListItem(mode); }

                if (oTable.Rows.Count > 0)
                {
                    objForm.dgv_list.KeyPress += PopupForm_KeyPress;
                    objForm.dgv_list.DoubleClick += PopupForm_DoubleClick;
                    objForm.ODataTable = oTable;
                    objForm.ShowDialog();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, GolobalItems.MessageCaption); }
        }

        private void PopupForm_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PopupForm_DateSet();
            }
        }
        private void PopupForm_DoubleClick(object sender, EventArgs e)
        {
            PopupForm_DateSet();
        }
        private void PopupForm_DateSet()
        {
            try
            {
                if (PopupForm_Flag == "SUPPLIER_LIST")
                {
                    txt_SupplierName.txtList.Text = GolobalItems.glbListItem.Items[0].ToString();
                    txtSuppid.Text = GolobalItems.glbListItem.Items[1].ToString();
                }

                frm_Common_List f2 = (frm_Common_List)Application.OpenForms["frm_Common_List"];
                f2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }

        #endregion

        #region " Private Fuction"
        private void GridDesign()
        {
            dgv_item.Columns.Add("Barcode", "Barcode");
            dgv_item.Columns.Add("itemID", "Item ID");
            dgv_item.Columns.Add("ItemName", "Item Name");
            dgv_item.Columns.Add("Uom", "UOM");
            dgv_item.Columns.Add("SupplierPrice", "Supplier Price");
            dgv_item.Columns.Add("Stock", "Stock");

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.Name = "G";
            col.HeaderText = "G";
            dgv_item.Columns.Add(col);

            dgv_item.Columns["Barcode"].ReadOnly = true;
            dgv_item.Columns["itemID"].ReadOnly = true;
            dgv_item.Columns["ItemName"].ReadOnly = true;
            dgv_item.Columns["Uom"].ReadOnly = true;
            dgv_item.Columns["Stock"].ReadOnly = true;

        }



        private void Save(int mode)
        {
            try
            {
                List<supp_Pricelist> listDetail = new List<supp_Pricelist>();

                foreach (DataGridViewRow row in dgv_item.Rows)
                {
                    supp_Pricelist objLine = new supp_Pricelist();

                    objLine.suppId = txtSuppid.Text;
                    objLine.itemID = GolobalItems.NullToString(row.Cells["itemID"].Value);
                    objLine.Barcode = GolobalItems.NullToString(row.Cells["Barcode"].Value);
                    objLine.itemCost = GolobalItems.NullToNumber(row.Cells["SupplierPrice"].Value);

                    objLine.UserId = GolobalItems.UserId;
                    objLine.branchid = GolobalItems.BranchCode;
                    objLine.FinancialYear = GolobalItems.FinancialYear;

                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["G"];
                    if (chk.Selected == true)
                    {
                        listDetail.Add(objLine);
                    }

                }

                msg = SupplierPriceList.Set(Action, listDetail);
                if (msg == "SUCCESS")
                {
                    MessageBox.Show("Record Successfully Updated", GolobalItems.MessageCaption);
                }
                else { MessageBox.Show(msg, GolobalItems.MessageCaption); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }


        #endregion

        #region "Events"

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Save(1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Save(2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btn_SupplierPriceList_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string item = null;
                string category = null;
                string Subcategory = null;
                string Barcode = null;

                if (rb_SupplierPriceList_ItemName.Checked)
                    item = txt_SupplierPriceList_ItemDetails.Text;
                if (rb_SupplierPriceList_Category.Checked)
                    category = txt_SupplierPriceList_ItemDetails.Text;
                if (rb_SupplierPriceList_SubCategory.Checked)
                    Subcategory = txt_SupplierPriceList_ItemDetails.Text;
                if (rb_SupplierPriceList_Barcode.Checked)
                    item = txt_SupplierPriceList_ItemDetails.Text;

                DataSet ds = SupplierPriceList.Get("SEARCH", item, category, Subcategory, Barcode, txtSuppid.Text);

                if (dgv_item.Rows.Count > 0) { dgv_item.Rows.Clear(); }
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dgv_item.Rows.Add();
                    int i = dgv_item.Rows.Count - 1;

                    dgv_item.Rows[i].Cells["Barcode"].Value = row["Barcode"];
                    dgv_item.Rows[i].Cells["itemID"].Value = row["itemID"];
                    dgv_item.Rows[i].Cells["ItemName"].Value = row["ItemName"];
                    dgv_item.Rows[i].Cells["Uom"].Value = row["Uom"];
                    dgv_item.Rows[i].Cells["SupplierPrice"].Value = row["SupplierPrice"];
                    dgv_item.Rows[i].Cells["Stock"].Value = row["Stock"];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }
    }
}
