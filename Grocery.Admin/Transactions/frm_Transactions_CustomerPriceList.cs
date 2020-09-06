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
    public partial class frm_Transactions_CustomerPriceList : Form
    {
        string msg = "";
        int Action = 0;
        public DataTable ODataTable;
        public DataTable ODataTableSearch;

        public frm_Transactions_CustomerPriceList()
        {
            InitializeComponent();
            forminitialization();
        }

        #region "Form Level Activity" 
        private void forminitialization()
        {

            try
            {
                GridDesign();
                DataBindWithControl("LOAD");
                Enable_Disable_Form(false);
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
                DialogResult dialogResult = MessageBox.Show("Exiting Form This Form will discard all changes", GolobalItems.MessageCaption, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return true;
                }

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frm_Transactions_CustomerPriceList_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region "Data Grid View & Function Key Activity" 
        string PopupForm_Flag = "";
        private void PopulatePopGrid(string mode)
        {
            frm_Common_List objForm = new frm_Common_List();
            DataTable oTable = new DataTable();
            PopupForm_Flag = mode;
            try
            {

                if (mode == "CUSTOMER_LIST") { oTable = CommonFunction.GetListItem(mode); }
                else if (mode == "ITEM_LIST") { oTable = CommonFunction.GetListItem(mode); objForm.formWidth = 800; }

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
                if (PopupForm_Flag == "CUSTOMER_LIST")
                {
                    txt_CustomerPriceList_CustName.txtList.Text = GolobalItems.glbListItem.Items[0].ToString();
                    txtCustomerid.Text = GolobalItems.glbListItem.Items[1].ToString();
                }
                else if (PopupForm_Flag == "ITEM_LIST")
                {
                    txt_CustomerPriceList_ItemName.txtList.Text = GolobalItems.glbListItem.Items[0].ToString();
                    txtItemCode.Text = GolobalItems.glbListItem.Items[1].ToString();
                    txt_CustomerPriceList_Barcode.Text = GolobalItems.glbListItem.Items[2].ToString();
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
            dgv_item.Columns.Add("ItemName", "Item Name");
            dgv_item.Columns.Add("CustomerName", "Customer Name");
            dgv_item.Columns.Add("itemCost", "Cost");

            dgv_item.Columns.Add("Barcode", "Barcode");
            dgv_item.Columns.Add("custId", "custId");
            dgv_item.Columns.Add("itemID", "Item ID");
            dgv_item.Columns.Add("updatedDate", "updatedDate");

            dgv_item.ReadOnly = true;

            dgv_item.Columns["Barcode"].Visible = false;
            dgv_item.Columns["custId"].Visible = false;
            dgv_item.Columns["itemID"].Visible = false;
            dgv_item.Columns["updatedDate"].Visible = false;
        }

        private void DataBindWithControl(string Mode)
        {
            try
            {
                DataSet ds = new DataSet();
                if (Mode == "LOAD")
                {
                    ds = CustomerPriceList.Get("ALL", "", "");
                    ODataTableSearch = ds.Tables[0];
                    ODataTable = ds.Tables[0];
                }


                if (dgv_item.Rows.Count > 0) { dgv_item.Rows.Clear(); }
                foreach (DataRow row in ODataTableSearch.Rows)
                {
                    dgv_item.Rows.Add();
                    int i = dgv_item.Rows.Count - 1;
                    dgv_item.Rows[i].Cells["custId"].Value = row["custId"];
                    dgv_item.Rows[i].Cells["CustomerName"].Value = row["CustomerName"];
                    dgv_item.Rows[i].Cells["itemID"].Value = row["itemID"];
                    dgv_item.Rows[i].Cells["ItemName"].Value = row["ItemName"];

                    dgv_item.Rows[i].Cells["Barcode"].Value = row["Barcode"];
                    dgv_item.Rows[i].Cells["updatedDate"].Value = row["updatedDate"];
                    dgv_item.Rows[i].Cells["itemCost"].Value = row["itemCost"];

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }


        private void Save()
        {
            try
            {
                cust_Pricelist objMaster = new cust_Pricelist();

                objMaster.itemID = txtItemCode.Text;
                objMaster.custId = txtCustomerid.Text;
                objMaster.itemCost = GolobalItems.NullToNumber(txt_CustomerPriceList_SellingPrice.Text);
                objMaster.updatedDate = dt_CustomerPriceList_BalanceDate.Value;

                objMaster.Barcode = txt_CustomerPriceList_Barcode.Text;

                msg = CustomerPriceList.Set(Action, objMaster);
                if (msg == "SUCCESS")
                {
                    MessageBox.Show("Record Successfully Updated", GolobalItems.MessageCaption); Enable_Disable_Form(false);
                    btn_CustomerPriceList_Edit.Enabled = true;
                    btn_CustomerPriceList_New.Enabled = true;
                    btn_CustomerPriceList_Save.Enabled = false;
                    btn_CustomerPriceList_Delete.Enabled = false;
                    DataBindWithControl("LOAD");
                }
                else { MessageBox.Show(msg, GolobalItems.MessageCaption); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }

        private void Clear_Form()
        {
            foreach (Control con in this.Controls)
            {

                if (con is Panel)
                {
                    foreach (Control con1 in con.Controls)
                    {
                        if (con1 is TextBox)
                        {
                            ((TextBox)con1).Text = "";
                        }
                        if (con1 is ComboBox)
                        {
                            ((ComboBox)con1).Text = "";
                        }
                        if (con1 is DateTimePicker)
                        {
                            ((DateTimePicker)con1).Value = DateTime.Today;
                        }
                        if (con1 is ucComboBox)
                        {
                            ((ucComboBox)con1).txtList.Text = "";
                        }
                    }
                }
            }
        }

        private void Enable_Disable_Form(bool mode)
        {
            foreach (Control con in this.Controls)
            {

                if (con is Panel)
                {
                    foreach (Control con1 in con.Controls)
                    {
                        if (con1.BackColor != Color.Gainsboro)
                        {
                            if (con1 is TextBox)
                            {
                                ((TextBox)con1).Enabled = mode;
                            }
                            if (con1 is ComboBox)
                            {
                                ((ComboBox)con1).Enabled = mode;
                            }
                            if (con1 is DateTimePicker)
                            {
                                ((DateTimePicker)con1).Enabled = mode;
                            }
                            if (con1 is CheckBox)
                            {
                                ((CheckBox)con1).Enabled = mode;
                            }
                            if (con1 is ucComboBox)
                            {
                                ((ucComboBox)con1).Enabled = mode;

                            }
                        }
                    }
                }
            }
            txt_CustomerPriceList_SrchItemName.Enabled = true;
            txt_CustomerPriceList_SrchCustName.Enabled = true;
            txt_CustomerPriceList_SrchCost.Enabled = true;

        }

        #endregion

        #region "Events"

        private void btn_CustomerPriceList_New_Click(object sender, EventArgs e)
        {
            Action = 1;
            Clear_Form();
            Enable_Disable_Form(true);
            btn_CustomerPriceList_New.Enabled = false;
            btn_CustomerPriceList_Save.Enabled = true;
            btn_CustomerPriceList_Delete.Enabled = false;
        }

        private void btn_CustomerPriceList_Edit_Click(object sender, EventArgs e)
        {
            Action = 2;
            Enable_Disable_Form(true);
            btn_CustomerPriceList_Edit.Enabled = false;
            btn_CustomerPriceList_Save.Enabled = true;
            btn_CustomerPriceList_Delete.Enabled = false;
        }

        private void btn_CustomerPriceList_Delete_Click(object sender, EventArgs e)
        {
            Action = 3;
            Save();
        }

        private void btn_CustomerPriceList_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btn_CustomerPriceList_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgv_item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txt_CustomerPriceList_ItemName.txtList.Text = GolobalItems.NullToString(dgv_item.CurrentRow.Cells["ItemName"].Value.ToString());
                txtItemCode.Text = GolobalItems.NullToString(dgv_item.CurrentRow.Cells["itemID"].Value.ToString());
                txt_CustomerPriceList_CustName.txtList.Text = GolobalItems.NullToString(dgv_item.CurrentRow.Cells["CustomerName"].Value.ToString());
                txtCustomerid.Text = GolobalItems.NullToString(dgv_item.CurrentRow.Cells["custId"].Value.ToString());

                txt_CustomerPriceList_Barcode.Text = GolobalItems.NullToString(dgv_item.CurrentRow.Cells["Barcode"].Value.ToString());
                txt_CustomerPriceList_SellingPrice.Text = GolobalItems.NullToString(dgv_item.CurrentRow.Cells["itemCost"].Value.ToString());
                dt_CustomerPriceList_BalanceDate.Text = GolobalItems.NullToString(dgv_item.CurrentRow.Cells["updatedDate"].Value.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, GolobalItems.MessageCaption); }
        }

        private void txt_CustomerPriceList_SrchItemName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView firstView = new DataView(ODataTable);
                firstView.RowFilter = "Convert([" + dgv_item.Columns["ItemName"].Name + "], System.String)" + "  like '*" + txt_CustomerPriceList_SrchItemName.Text + "*'";
                ODataTableSearch = firstView.ToTable();
                DataBindWithControl("SEARCH");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, GolobalItems.MessageCaption); }
        }

        private void txt_CustomerPriceList_SrchCustName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView firstView = new DataView(ODataTable);
                firstView.RowFilter = "Convert([" + dgv_item.Columns["CustomerName"].Name + "], System.String)" + "  like '*" + txt_CustomerPriceList_SrchCustName.Text + "*'";
                ODataTableSearch = firstView.ToTable();
                DataBindWithControl("SEARCH");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, GolobalItems.MessageCaption); }
        }

        private void txt_CustomerPriceList_SrchCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView firstView = new DataView(ODataTable);
                firstView.RowFilter = "Convert([" + dgv_item.Columns["itemCost"].Name + "], System.String)" + "  like '*" + txt_CustomerPriceList_SrchCost.Text + "*'";
                ODataTableSearch = firstView.ToTable();
                DataBindWithControl("SEARCH");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, GolobalItems.MessageCaption); }
        }
        #endregion


    }
}
