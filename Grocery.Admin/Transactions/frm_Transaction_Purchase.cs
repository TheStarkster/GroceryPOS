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
    public partial class frm_Transaction_Purchase : Form
    {
        string FormName = "PURCHASE_INVOICE";
        string msg = "";

        #region "Form Level Activity" 
        public frm_Transaction_Purchase()
        {
            InitializeComponent();
            forminitialization();
        }
        private void forminitialization()
        {
            // Bind Event of action button
            foreach (Control x in ucTransactionLPO.Controls)
            {
                if (x is Panel)
                {
                    foreach (Control y in x.Controls)
                    {
                        if (y is Button)
                        {
                            ((Button)y).Click += new EventHandler(btnTransaction_Click);
                        }
                    }
                }
            }

            // Bind Event of First next last previous button
            foreach (Control x in ucFirstPreNextLast1.Controls)
            {
                if (x is Panel)
                {
                    foreach (Control y in x.Controls)
                    {
                        if (y is Button)
                        {
                            ((Button)y).Click += new EventHandler(btnFirstPreNextLast_Click);
                        }
                    }
                }
            }
            try
            {
                GridDesign();
                ucTransactionLPO.Enable_Disable("Default");
                Enable_Disable_Form(false);
                DataTabel_FirstPreNextLast = PurchaseInvoice.Get("MASTER", "").Tables[0];
                GolobalItems.ComboBoxBind(cob_Purchase_Currency, "CURRENCY");
                GolobalItems.ComboBoxBind(cob_CostCenter, "BRANCH");
                cob_CostCenter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                string mode = ((System.Windows.Forms.ButtonBase)sender).Text;
                if (mode == "Add")
                {
                    Clear_Form();
                    Enable_Disable_Form(true);
                    txt_Purchase_InvoiceID.Text = CommonFunction.GenerateNoSeries(GolobalItems.BranchCode, FormName);
                    cob_Purchase_Currency.SelectedIndex = 0; cob_CostCenter.SelectedIndex = 0;
                    dgv_item.Rows.Add();
                    dgv_item.Rows[dgv_item.Rows.Count - 1].Cells["UnitPriceAED"].Value = txt_Purchase_CurrentRate.Text;
                }
                else if (mode == "Edit")
                {
                    Enable_Disable_Form(true);
                }
                else if (mode == "Save")
                {
                    Save();
                }
                else if (mode == "Delete")
                {

                }
                else if (mode == "View")
                {
                    frm_Common_View obj = new frm_Common_View();
                    obj.Parameter = FormName;
                    obj.ShowDialog();
                    txt_Purchase_InvoiceID.Text = GolobalItems.UniqueId;
                    DataBindWithControl();
                    Enable_Disable_Form(false);
                }
                else if (mode == "Print")
                {

                }
                else if (mode == "Cancel")
                {
                    DialogResult dialogResult = MessageBox.Show("Exiting Form This Form will discard all changes", GolobalItems.MessageCaption, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Clear_Form();
                        Enable_Disable_Form(false);
                    }

                }
                else if (mode == "Close")
                { this.Close(); }

                ucTransactionLPO.Enable_Disable(((System.Windows.Forms.ButtonBase)sender).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }


        private void frm_Transaction_Purchase_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region "First Pre Next Last" 

        DataTable DataTabel_FirstPreNextLast = new DataTable();
        int index = 0;
        private void PopulateData()
        {
            try
            {
                if (DataTabel_FirstPreNextLast.Rows.Count > 0)
                {
                    DataRow row = DataTabel_FirstPreNextLast.Rows[index];
                    txt_Purchase_InvoiceID.Text = row["invoiceId"].ToString();
                    DataBindWithControl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }

        }

        private void btnFirstPreNextLast_Click(object sender, EventArgs e)
        {
            string mode = ((System.Windows.Forms.ButtonBase)sender).Text;
            if (mode == "First")
            {
                index = 0;
                PopulateData();
            }
            else if (mode == "Previous")
            {
                if (index == DataTabel_FirstPreNextLast.Rows.Count - 1 || index != 0)
                {
                    index--;
                    PopulateData();
                }
            }

            else if (mode == "Next")
            {
                if (index < DataTabel_FirstPreNextLast.Rows.Count - 1)
                {
                    index++;
                    PopulateData();
                }
            }
            else if (mode == "Last")
            {
                index = DataTabel_FirstPreNextLast.Rows.Count - 1;
                PopulateData();
            }

        }

        #endregion

        #region "Context Menu "
        private void SubMenu_Add_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_item.Rows.Add();
                dgv_item.CurrentCell = dgv_item.Rows[dgv_item.Rows.Count - 1].Cells[0];
                dgv_item.Rows[dgv_item.Rows.Count - 1].Cells["salesQty"].Value = 0;
                dgv_item.Rows[dgv_item.Rows.Count - 1].Cells["UnitPriceAED"].Value = txt_Purchase_CurrentRate.Text;
                dgv_item.BeginEdit(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }

        private void SubMenu_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_item.Rows.Count > 0)
                {
                    dgv_item.Rows.Remove(dgv_item.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }
        #endregion

        #region "Data Grid View & Function Key Activity" 
        string PopupForm_Flag = "";

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
            else if (keyData == (Keys.Enter))
            {
                if (dgv_item.IsCurrentCellInEditMode && keyData == Keys.Enter)
                {
                    GridCellMovement(dgv_item);
                }
                else if (dgv_list.CanFocus && keyData == Keys.Enter)
                {
                    SetItemSelectedValueInGrid();
                    return true;
                }
                else
                {
                    SendKeys.Send("{TAB}");
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
                    txt_Purchase_SupplierName.txtList.Text = GolobalItems.glbListItem.Items[0].ToString();
                    txtSuppid.Text = GolobalItems.glbListItem.Items[1].ToString();
                    //txtSupplierTRN.Text = GolobalItems.glbListItem.Items[2].ToString();
                }


                frm_Common_List f2 = (frm_Common_List)Application.OpenForms["frm_Common_List"];
                f2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }


        public void GridCellMovement(DataGridView dgv)
        {
            DataGridViewCell CurrentCell = dgv.CurrentCell;
            try
            {
                if ((CurrentCell != null))
                {
                    int nextRow = CurrentCell.RowIndex;
                    int nextCol = CurrentCell.ColumnIndex;
                    string colName = "";

                    if (dgv.EditingControl is TextBox)
                    {
                        colName = ((System.Windows.Forms.DataGridViewTextBoxColumn)CurrentCell.OwningColumn).Name.ToString();
                        PopulatePopGrid(colName);
                    }

                    if (CurrentCell.ColumnIndex == 0 || CurrentCell.ColumnIndex == 1)
                    { dgv_list.Focus(); return; }

                    if (CurrentCell.ColumnIndex == dgv.ColumnCount - 1)
                    {
                        nextCol = 0;
                        nextRow += 1;
                    }

                    if (nextRow >= dgv.RowCount)
                    {
                        nextRow = dgv.RowCount - 1;
                        return;
                    }

                    // cursor move
                    DataGridViewCell nextCell = null;
                    if (CurrentCell.ColumnIndex == dgv.ColumnCount - 1)
                        nextCell = dgv.Rows[nextRow].Cells[nextCol];
                    else
                        nextCell = dgv.Rows[nextRow].Cells[nextCol + 1];

                    if (nextCell != null && nextCell.Visible)
                    {
                        if ((CurrentCell != null) && (CurrentCell.IsInEditMode))
                            dgv.EndEdit();
                        try
                        {
                            dgv.CurrentCell = nextCell;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void dgv_item_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.CellStyle.BackColor = Color.White;

                TextBox txt = e.Control as TextBox;
                DataGridViewTextBoxCell cell = dgv_item.CurrentCell as DataGridViewTextBoxCell;

                if (e.Control.GetType() == typeof(DataGridViewTextBoxEditingControl))
                {
                    if (cell.OwningColumn.Name == "itemDesc" || cell.OwningColumn.Name == "Barcode")
                    {
                        txt.TextChanged -= new EventHandler(ItemSearch_TextChanged);
                        txt.TextChanged += new EventHandler(ItemSearch_TextChanged);
                    }
                }

                if ((cell.OwningColumn == dgv_item.Columns["salesQty"] || cell.OwningColumn == dgv_item.Columns["unitPrice"]))
                {
                    txt.TextChanged -= new EventHandler(Calculation_TextChanged);
                    txt.TextChanged += new EventHandler(Calculation_TextChanged);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }



        private void Calculation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal TotalAmount = 0;
                foreach (DataGridViewRow row in dgv_item.Rows)
                {
                    row.Cells["totalAmount"].Value = GolobalItems.NullToNumber(row.Cells["salesQty"].EditedFormattedValue) * GolobalItems.NullToNumber(row.Cells["unitPrice"].EditedFormattedValue);
                    TotalAmount = TotalAmount + GolobalItems.NullToNumber(row.Cells["totalAmount"].Value);
                }
                txt_Purchase_TotalAmt.Text = TotalAmount.ToString();
                txt_Purchase_NetAmt.Text = TotalAmount.ToString();
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
            dgv_item.Columns.Add("itemDesc", "Item Name");

            dgv_item.Columns.Add("Barcode", "Barcode");
            dgv_item.Columns.Add("UOM_Name", "Unit");

            dgv_item.Columns.Add("salesQty", "Qty");
            dgv_item.Columns.Add("unitPrice", "U.Price");
            dgv_item.Columns.Add("UnitPriceAED", "U.Price AED");
            dgv_item.Columns.Add("totalAmount", "Total Cost");
            dgv_item.Columns.Add("DiscPerc", "Disc %");
            dgv_item.Columns.Add("Discount", "Disc Amt");
            dgv_item.Columns.Add("netamount", "Net Amt");
            dgv_item.Columns.Add("vat", "VAT");
            dgv_item.Columns.Add("BonusQty", "Bonus");
            dgv_item.Columns.Add("netQty", "Net Qty");
            dgv_item.Columns.Add("itemID", "Item ID");
            dgv_item.Columns.Add("Unit", "Unit Id");

            dgv_item.Columns["itemID"].ReadOnly = true;
            //dgv_item.Columns["Barcode"].ReadOnly = true;
            dgv_item.Columns["UOM_Name"].ReadOnly = true;
            dgv_item.Columns["totalAmount"].ReadOnly = true;

            dgv_item.Columns["Unit"].Visible = false;

        }

        private void DataBindWithControl()
        {
            try
            {
                DataSet ds = PurchaseInvoice.Get("SINGLE", txt_Purchase_InvoiceID.Text);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    txt_Purchase_InvoiceID.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["invoiceId"]);
                    txtSuppid.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["custid"]);
                    txt_Purchase_SupplierName.txtList.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["suppname"]);

                    txt_Purchase_PurchaseDate.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["salesDate"]);
                    if (GolobalItems.NullToString(ds.Tables[0].Rows[0]["salesType"]) == "Cash")
                        rb_Purchase_Cash.Checked = true;
                    else if (GolobalItems.NullToString(ds.Tables[0].Rows[0]["salesType"]) == "Credit")
                        rb_Purchase_Credit.Checked = true;
                    else if (GolobalItems.NullToString(ds.Tables[0].Rows[0]["salesType"]) == "Petty Cash")
                        rb_Purchase_PettyCash.Checked = true;
                    else if (GolobalItems.NullToString(ds.Tables[0].Rows[0]["salesType"]) == "Book Transfer")
                        rb_Purchase_BookTransfer.Checked = true;

                    txt_Purchase_TotalAmt.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["totalAmount"]);
                    txt_Purchase_Discount.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["discAmount"]);
                    txt_Purchase_NetAmt.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["netAmount"]);

                    cob_Purchase_Currency.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["purcurrency"]);
                    txt_Purchase_CurrentRate.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["currate"]);
                    dt_Purchase_DueDate.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["activityDate"]);

                    txt_Purchase_TotalVAT.Text = GolobalItems.NullToString(ds.Tables[0].Rows[0]["TotalVAT"]);

                }

                if (dgv_item.Rows.Count > 0) { dgv_item.Rows.Clear(); }
                foreach (DataRow row in ds.Tables[1].Rows)
                {
                    dgv_item.Rows.Add();
                    int i = dgv_item.Rows.Count - 1;
                    dgv_item.Rows[i].Cells["itemDesc"].Value = row["itemDesc"];
                    dgv_item.Rows[i].Cells["itemID"].Value = row["itemID"];
                    dgv_item.Rows[i].Cells["Barcode"].Value = row["Barcode"];
                    dgv_item.Rows[i].Cells["Unit"].Value = row["Unit"];
                    dgv_item.Rows[i].Cells["UOM_Name"].Value = row["UOM_Name"];
                    dgv_item.Rows[i].Cells["salesQty"].Value = row["salesQty"];
                    dgv_item.Rows[i].Cells["unitPrice"].Value = row["unitPrice"];
                    dgv_item.Rows[i].Cells["totalAmount"].Value = row["totalAmount"];
                    dgv_item.Rows[i].Cells["DiscPerc"].Value = row["DiscPerc"];
                    dgv_item.Rows[i].Cells["Discount"].Value = row["Discount"];
                    dgv_item.Rows[i].Cells["netamount"].Value = row["netamount"];
                    dgv_item.Rows[i].Cells["vat"].Value = row["vat"];
                    dgv_item.Rows[i].Cells["BonusQty"].Value = row["BonusQty"];
                    dgv_item.Rows[i].Cells["netQty"].Value = row["netQty"];

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
                purchase_master objMaster = new purchase_master();
                List<purchase_details> listDetail = new List<purchase_details>();

                objMaster.invoiceId = txt_Purchase_InvoiceID.Text;
                objMaster.custId = txtSuppid.Text;
                objMaster.salesDate = txt_Purchase_PurchaseDate.Value;

                if (rb_Purchase_Cash.Checked)
                    objMaster.salesType = "Cash";
                else if (rb_Purchase_Credit.Checked)
                    objMaster.salesType = "Credit";
                else if (rb_Purchase_PettyCash.Checked)
                    objMaster.salesType = "Petty Cash";
                else if (rb_Purchase_BookTransfer.Checked)
                    objMaster.salesType = "Book Transfer";

                objMaster.totalAmount = GolobalItems.NullToNumber(txt_Purchase_TotalAmt.Text);
                objMaster.discAmount = GolobalItems.NullToNumber(txt_Purchase_Discount.Text);
                objMaster.netAmount = GolobalItems.NullToNumber(txt_Purchase_NetAmt.Text);
                objMaster.Description = txt_Purchase_Description.Text;
                objMaster.purcurrency = cob_Purchase_Currency.Text;
                objMaster.currate = txt_Purchase_CurrentRate.Text;
                //objMaster.deldate = dt_Purchase_DueDate.Value;

                objMaster.TotalVAT = GolobalItems.NullToNumber(txt_Purchase_TotalVAT.Text);

                objMaster.UserId = GolobalItems.UserId;
                objMaster.branchid = GolobalItems.BranchCode;
                objMaster.FinancialYear = GolobalItems.FinancialYear;


                foreach (DataGridViewRow row in dgv_item.Rows)
                {
                    purchase_details objLine = new purchase_details();
                    objLine.invoiceId = txt_Purchase_InvoiceID.Text;
                    objLine.itemDesc = GolobalItems.NullToString(row.Cells["itemDesc"].Value);
                    objLine.itemID = GolobalItems.NullToString(row.Cells["itemID"].Value);
                    objLine.Barcode = GolobalItems.NullToString(row.Cells["Barcode"].Value);
                    objLine.Unit = GolobalItems.NullToNumber(row.Cells["Unit"].Value);
                    objLine.salesQty = GolobalItems.NullToNumber(row.Cells["salesQty"].Value);
                    objLine.unitPrice = GolobalItems.NullToNumber(row.Cells["unitPrice"].Value);
                    //objLine.UnitPriceAED = decimal.Parse(GolobalItems.NullToString(row.Cells["UnitPriceAED"].Value));
                    objLine.totalAmount = GolobalItems.NullToNumber(row.Cells["totalAmount"].Value);
                    objLine.DiscPerc = GolobalItems.NullToNumber(row.Cells["DiscPerc"].Value);
                    objLine.Discount = GolobalItems.NullToNumber(row.Cells["Discount"].Value);
                    objLine.netamount = GolobalItems.NullToNumber(row.Cells["netamount"].Value);
                    //objLine.vat = GolobalItems.NullToNumber(row.Cells["vat"].Value);
                    objLine.BonusQty = GolobalItems.NullToNumber(row.Cells["BonusQty"].Value);
                    objLine.netQty = GolobalItems.NullToNumber(row.Cells["netQty"].Value);

                    listDetail.Add(objLine);
                }
                msg = PurchaseInvoice.Set(objMaster, listDetail);
                if (msg == "SUCCESS") { MessageBox.Show("Record Successfully Updated", GolobalItems.MessageCaption); Enable_Disable_Form(false); }
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

                if (con is GroupBox)
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
                        if (con1 is CheckBox)
                        {
                            ((CheckBox)con1).Checked = false;
                        }
                        if (con1 is ucComboBox)
                        {
                            ((ucComboBox)con1).txtList.Text = "";
                        }
                    }
                }
            }
            if (dgv_item.Rows.Count > 0) { dgv_item.Rows.Clear(); }
        }

        private void Enable_Disable_Form(bool mode)
        {
            foreach (Control con in this.Controls)
            {

                if (con is GroupBox)
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

                                //((ucComboBox)con1).MouseClick += new EventHandler(txtSuppid_MouseClick);
                            }
                        }
                    }
                }
            }

            dgv_item.Enabled = mode;
        }


        #endregion

        #region "Event-------------"

        private void cbox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { txt_Purchase_CurrentRate.Text = (string)(cob_Purchase_Currency.SelectedValue.ToString().Split('^')).GetValue(1).ToString(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }




        #endregion
        #region "Item Search"
        DataTable objDataTableItemSearch = new DataTable();

        private void ItemSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = dgv_item.CurrentCell.ColumnIndex;
                if (columnIndex == 0 || columnIndex == 1)
                {
                    if (dgv_item.CurrentRow.Cells["itemDesc"].EditedFormattedValue.ToString().Length > 1 || dgv_item.CurrentRow.Cells["Barcode"].EditedFormattedValue.ToString().Length > 1)
                    {
                        pnlItem.Visible = true;
                        if (objDataTableItemSearch.Rows.Count == 0)
                        {
                            objDataTableItemSearch = CommonFunction.GetListItem("itemDesc");
                            dgv_list.DataSource = objDataTableItemSearch;
                        }
                        if (objDataTableItemSearch.Rows.Count > 0)
                        {
                            if (columnIndex == 0)
                            {
                                DataView firstView = new DataView(objDataTableItemSearch);
                                firstView.RowFilter = "Convert([" + dgv_list.Columns[0].Name + "], System.String)" + "  like '*" + dgv_item.CurrentRow.Cells["itemDesc"].EditedFormattedValue.ToString() + "*'";
                                dgv_list.DataSource = firstView;
                            }
                            else if (columnIndex == 1)
                            {
                                DataView firstView = new DataView(objDataTableItemSearch);
                                firstView.RowFilter = "Convert([" + dgv_list.Columns[1].Name + "], System.String)" + "  like '*" + dgv_item.CurrentRow.Cells["Barcode"].EditedFormattedValue.ToString() + "*'";
                                dgv_list.DataSource = firstView;
                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }

        private void dgv_list_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void dgv_list_DoubleClick(object sender, EventArgs e)
        {
            SetItemSelectedValueInGrid();
        }

        private void SetItemSelectedValueInGrid()
        {
            try
            {
                //check duplicate
                int found = 0;
                for (int row = 0; row < dgv_item.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv_item.Columns.Count; col++)
                    {
                        if (dgv_item.Rows[row].Cells[col].Value != null && dgv_item.Rows[row].Cells[col].Value.Equals(dgv_list.CurrentRow.Cells["Item Id"].Value.ToString().Trim()))
                        {
                            found = 1;
                            pnlItem.Visible = false;
                            MessageBox.Show("Duplicate Item found :-> " + dgv_list.CurrentRow.Cells["Item Name"].Value.ToString(), GolobalItems.MessageCaption);
                            dgv_item.CurrentCell = dgv_item.Rows[dgv_item.CurrentCell.RowIndex].Cells[0];
                            dgv_item.BeginEdit(true);
                        }
                    }
                }
                //add new item
                if (found == 0)
                {
                    pnlItem.Visible = false;
                    dgv_item.CurrentRow.Cells["itemDesc"].Value = dgv_list.CurrentRow.Cells["Item Name"].Value;
                    dgv_item.CurrentRow.Cells["Barcode"].Value = dgv_list.CurrentRow.Cells["BarCode"].Value;
                    dgv_item.CurrentRow.Cells["itemID"].Value = dgv_list.CurrentRow.Cells["Item Id"].Value;
                    dgv_item.CurrentRow.Cells["UOM_Name"].Value = dgv_list.CurrentRow.Cells["Unit"].Value;
                    dgv_item.CurrentRow.Cells["unitPrice"].Value = dgv_list.CurrentRow.Cells["Cost"].Value;
                    dgv_item.CurrentRow.Cells["Unit"].Value = dgv_list.CurrentRow.Cells["Unit Id"].Value;

                    dgv_item.CurrentCell = dgv_item.Rows[dgv_item.CurrentCell.RowIndex].Cells[3];
                    dgv_item.BeginEdit(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }
        #endregion
    }
}
