namespace Grocery.Admin.Transactions
{
    partial class frm_Transaction_Purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_Purchase_Invoice = new System.Windows.Forms.Panel();
            this.txt_Purchase_GRV = new Grocery.Admin.UControl.ucComboBoxSmall();
            this.txt_Purchase_LPO = new Grocery.Admin.UControl.ucComboBoxSmall();
            this.lbl_SupplierID = new System.Windows.Forms.Label();
            this.txtSuppid = new System.Windows.Forms.TextBox();
            this.txt_Purchase_SupplierName = new Grocery.Admin.UControl.ucComboBox();
            this.cb_Purchase_ListItems = new System.Windows.Forms.CheckBox();
            this.cb_Purchase_VAT = new System.Windows.Forms.CheckBox();
            this.cb_Purchase_SupplierPriceList = new System.Windows.Forms.CheckBox();
            this.lbl_Purchase_ReplicableItem = new System.Windows.Forms.Label();
            this.cb_Purchase_ListOneItem = new System.Windows.Forms.CheckBox();
            this.lbl_Purchase_GRV = new System.Windows.Forms.Label();
            this.lbl_Purchase_LPO = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Purchase_BookTransfer = new System.Windows.Forms.RadioButton();
            this.rb_Purchase_PettyCash = new System.Windows.Forms.RadioButton();
            this.rb_Purchase_Credit = new System.Windows.Forms.RadioButton();
            this.rb_Purchase_Cash = new System.Windows.Forms.RadioButton();
            this.cob_Purchase_Emirates = new System.Windows.Forms.ComboBox();
            this.lbl_Purchase_Emirates = new System.Windows.Forms.Label();
            this.cob_CostCenter = new System.Windows.Forms.ComboBox();
            this.lbl_Purchase_CostCenter = new System.Windows.Forms.Label();
            this.txt_Purchase_CustTRN = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_CustTRN = new System.Windows.Forms.Label();
            this.txt_Purchase_Description = new System.Windows.Forms.RichTextBox();
            this.lbl_Purchase_Description = new System.Windows.Forms.Label();
            this.dt_Purchase_DueDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Purchase_DueDate = new System.Windows.Forms.Label();
            this.lbl_Purchase_ItemSearch = new System.Windows.Forms.Label();
            this.txt_Purchase_SupplierInvNo = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_SupplierInvNo = new System.Windows.Forms.Label();
            this.txt_Purchase_CurrentRate = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_CurrentRate = new System.Windows.Forms.Label();
            this.cob_Purchase_Currency = new System.Windows.Forms.ComboBox();
            this.lbl_Purchase_Currency = new System.Windows.Forms.Label();
            this.lbl_Purchase_SupplierName = new System.Windows.Forms.Label();
            this.txt_Purchase_PurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Purchase_PurchaseDate = new System.Windows.Forms.Label();
            this.txt_Purchase_InvoiceID = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_InvoiceID = new System.Windows.Forms.Label();
            this.pnl_Purchase_DeviceSelect = new System.Windows.Forms.Panel();
            this.btn_Purchase_Browser = new System.Windows.Forms.Button();
            this.btn_Purchase_ScanImage = new System.Windows.Forms.Button();
            this.cob_Purchase_SelectDevice = new System.Windows.Forms.ComboBox();
            this.lbl_Purchase_SelectDevice = new System.Windows.Forms.Label();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SubMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Purchase_ResetFDC = new System.Windows.Forms.Button();
            this.GV_Purchase_FDCDetails = new System.Windows.Forms.DataGridView();
            this.btn_Purchase_LoadPDT = new System.Windows.Forms.Button();
            this.btn_Purchase_LostFile = new System.Windows.Forms.Button();
            this.lbl_Purchase_TotalQty = new System.Windows.Forms.Label();
            this.txt_Purchase_TotalQty = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_TotalBillAmt = new System.Windows.Forms.Label();
            this.txt_Purchase_TotalBillAmt = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_NetAmt = new System.Windows.Forms.Label();
            this.txt_Purchase_NetAmt = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_TotalAmt = new System.Windows.Forms.Label();
            this.lbl_Purchase_OtherCharges = new System.Windows.Forms.Label();
            this.lbl_Purchase_Discount = new System.Windows.Forms.Label();
            this.lbl_Purchase_TotalVAT = new System.Windows.Forms.Label();
            this.txt_Purchase_TotalAmt = new System.Windows.Forms.TextBox();
            this.txt_Purchase_OtherCharges = new System.Windows.Forms.TextBox();
            this.txt_Purchase_Discount = new System.Windows.Forms.TextBox();
            this.txt_Purchase_TotalVAT = new System.Windows.Forms.TextBox();
            this.pnl_Purchase_Footer = new System.Windows.Forms.Panel();
            this.ucFirstPreNextLast1 = new Grocery.Admin.UControl.ucFirstPreNextLast();
            this.ucTransactionLPO = new Grocery.Admin.UControl.ucTransaction();
            this.lbl_Purchase_FDCDetails = new System.Windows.Forms.Label();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.pnl_Purchase_Invoice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_Purchase_DeviceSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Purchase_FDCDetails)).BeginInit();
            this.pnl_Purchase_Footer.SuspendLayout();
            this.pnlItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Purchase_Invoice
            // 
            this.pnl_Purchase_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Purchase_Invoice.Controls.Add(this.txt_Purchase_GRV);
            this.pnl_Purchase_Invoice.Controls.Add(this.txt_Purchase_LPO);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_SupplierID);
            this.pnl_Purchase_Invoice.Controls.Add(this.txtSuppid);
            this.pnl_Purchase_Invoice.Controls.Add(this.txt_Purchase_SupplierName);
            this.pnl_Purchase_Invoice.Controls.Add(this.cb_Purchase_ListItems);
            this.pnl_Purchase_Invoice.Controls.Add(this.cb_Purchase_VAT);
            this.pnl_Purchase_Invoice.Controls.Add(this.cb_Purchase_SupplierPriceList);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_ReplicableItem);
            this.pnl_Purchase_Invoice.Controls.Add(this.cb_Purchase_ListOneItem);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_GRV);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_LPO);
            this.pnl_Purchase_Invoice.Controls.Add(this.groupBox1);
            this.pnl_Purchase_Invoice.Controls.Add(this.cob_Purchase_Emirates);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_Emirates);
            this.pnl_Purchase_Invoice.Controls.Add(this.cob_CostCenter);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_CostCenter);
            this.pnl_Purchase_Invoice.Controls.Add(this.txt_Purchase_CustTRN);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_CustTRN);
            this.pnl_Purchase_Invoice.Controls.Add(this.txt_Purchase_Description);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_Description);
            this.pnl_Purchase_Invoice.Controls.Add(this.dt_Purchase_DueDate);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_DueDate);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_ItemSearch);
            this.pnl_Purchase_Invoice.Controls.Add(this.txt_Purchase_SupplierInvNo);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_SupplierInvNo);
            this.pnl_Purchase_Invoice.Controls.Add(this.txt_Purchase_CurrentRate);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_CurrentRate);
            this.pnl_Purchase_Invoice.Controls.Add(this.cob_Purchase_Currency);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_Currency);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_SupplierName);
            this.pnl_Purchase_Invoice.Controls.Add(this.txt_Purchase_PurchaseDate);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_PurchaseDate);
            this.pnl_Purchase_Invoice.Controls.Add(this.txt_Purchase_InvoiceID);
            this.pnl_Purchase_Invoice.Controls.Add(this.lbl_Purchase_InvoiceID);
            this.pnl_Purchase_Invoice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Purchase_Invoice.Location = new System.Drawing.Point(5, 3);
            this.pnl_Purchase_Invoice.Name = "pnl_Purchase_Invoice";
            this.pnl_Purchase_Invoice.Size = new System.Drawing.Size(1146, 209);
            this.pnl_Purchase_Invoice.TabIndex = 0;
            // 
            // txt_Purchase_GRV
            // 
            this.txt_Purchase_GRV.Location = new System.Drawing.Point(845, 88);
            this.txt_Purchase_GRV.Name = "txt_Purchase_GRV";
            this.txt_Purchase_GRV.Size = new System.Drawing.Size(160, 22);
            this.txt_Purchase_GRV.TabIndex = 37;
            // 
            // txt_Purchase_LPO
            // 
            this.txt_Purchase_LPO.Location = new System.Drawing.Point(845, 60);
            this.txt_Purchase_LPO.Name = "txt_Purchase_LPO";
            this.txt_Purchase_LPO.Size = new System.Drawing.Size(160, 21);
            this.txt_Purchase_LPO.TabIndex = 36;
            // 
            // lbl_SupplierID
            // 
            this.lbl_SupplierID.AutoSize = true;
            this.lbl_SupplierID.Location = new System.Drawing.Point(561, 38);
            this.lbl_SupplierID.Name = "lbl_SupplierID";
            this.lbl_SupplierID.Size = new System.Drawing.Size(73, 15);
            this.lbl_SupplierID.TabIndex = 35;
            this.lbl_SupplierID.Text = "Supplier ID :";
            // 
            // txtSuppid
            // 
            this.txtSuppid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSuppid.Location = new System.Drawing.Point(634, 37);
            this.txtSuppid.Name = "txtSuppid";
            this.txtSuppid.ReadOnly = true;
            this.txtSuppid.Size = new System.Drawing.Size(117, 22);
            this.txtSuppid.TabIndex = 34;
            // 
            // txt_Purchase_SupplierName
            // 
            this.txt_Purchase_SupplierName.Location = new System.Drawing.Point(98, 37);
            this.txt_Purchase_SupplierName.Name = "txt_Purchase_SupplierName";
            this.txt_Purchase_SupplierName.Size = new System.Drawing.Size(377, 22);
            this.txt_Purchase_SupplierName.TabIndex = 33;
            this.txt_Purchase_SupplierName.Tag = "SUPPLIER_LIST";
            // 
            // cb_Purchase_ListItems
            // 
            this.cb_Purchase_ListItems.AutoSize = true;
            this.cb_Purchase_ListItems.Location = new System.Drawing.Point(792, 185);
            this.cb_Purchase_ListItems.Name = "cb_Purchase_ListItems";
            this.cb_Purchase_ListItems.Size = new System.Drawing.Size(96, 19);
            this.cb_Purchase_ListItems.TabIndex = 32;
            this.cb_Purchase_ListItems.Text = "List All Items";
            this.cb_Purchase_ListItems.UseVisualStyleBackColor = true;
            // 
            // cb_Purchase_VAT
            // 
            this.cb_Purchase_VAT.AutoSize = true;
            this.cb_Purchase_VAT.Location = new System.Drawing.Point(792, 160);
            this.cb_Purchase_VAT.Name = "cb_Purchase_VAT";
            this.cb_Purchase_VAT.Size = new System.Drawing.Size(126, 19);
            this.cb_Purchase_VAT.TabIndex = 31;
            this.cb_Purchase_VAT.Text = "VAT APPLICABLE";
            this.cb_Purchase_VAT.UseVisualStyleBackColor = true;
            // 
            // cb_Purchase_SupplierPriceList
            // 
            this.cb_Purchase_SupplierPriceList.AutoSize = true;
            this.cb_Purchase_SupplierPriceList.Location = new System.Drawing.Point(792, 135);
            this.cb_Purchase_SupplierPriceList.Name = "cb_Purchase_SupplierPriceList";
            this.cb_Purchase_SupplierPriceList.Size = new System.Drawing.Size(122, 19);
            this.cb_Purchase_SupplierPriceList.TabIndex = 30;
            this.cb_Purchase_SupplierPriceList.Text = "Supplier Price List";
            this.cb_Purchase_SupplierPriceList.UseVisualStyleBackColor = true;
            // 
            // lbl_Purchase_ReplicableItem
            // 
            this.lbl_Purchase_ReplicableItem.AutoSize = true;
            this.lbl_Purchase_ReplicableItem.Location = new System.Drawing.Point(792, 117);
            this.lbl_Purchase_ReplicableItem.Name = "lbl_Purchase_ReplicableItem";
            this.lbl_Purchase_ReplicableItem.Size = new System.Drawing.Size(88, 15);
            this.lbl_Purchase_ReplicableItem.TabIndex = 29;
            this.lbl_Purchase_ReplicableItem.Text = "Replicable Item";
            // 
            // cb_Purchase_ListOneItem
            // 
            this.cb_Purchase_ListOneItem.AutoSize = true;
            this.cb_Purchase_ListOneItem.Location = new System.Drawing.Point(563, 179);
            this.cb_Purchase_ListOneItem.Name = "cb_Purchase_ListOneItem";
            this.cb_Purchase_ListOneItem.Size = new System.Drawing.Size(122, 19);
            this.cb_Purchase_ListOneItem.TabIndex = 28;
            this.cb_Purchase_ListOneItem.Text = "List only one Item";
            this.cb_Purchase_ListOneItem.UseVisualStyleBackColor = true;
            // 
            // lbl_Purchase_GRV
            // 
            this.lbl_Purchase_GRV.AutoSize = true;
            this.lbl_Purchase_GRV.Location = new System.Drawing.Point(789, 94);
            this.lbl_Purchase_GRV.Name = "lbl_Purchase_GRV";
            this.lbl_Purchase_GRV.Size = new System.Drawing.Size(30, 15);
            this.lbl_Purchase_GRV.TabIndex = 24;
            this.lbl_Purchase_GRV.Text = "GRV";
            // 
            // lbl_Purchase_LPO
            // 
            this.lbl_Purchase_LPO.AutoSize = true;
            this.lbl_Purchase_LPO.Location = new System.Drawing.Point(789, 66);
            this.lbl_Purchase_LPO.Name = "lbl_Purchase_LPO";
            this.lbl_Purchase_LPO.Size = new System.Drawing.Size(30, 15);
            this.lbl_Purchase_LPO.TabIndex = 22;
            this.lbl_Purchase_LPO.Text = "LPO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Purchase_BookTransfer);
            this.groupBox1.Controls.Add(this.rb_Purchase_PettyCash);
            this.groupBox1.Controls.Add(this.rb_Purchase_Credit);
            this.groupBox1.Controls.Add(this.rb_Purchase_Cash);
            this.groupBox1.Location = new System.Drawing.Point(555, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 105);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Mode";
            // 
            // rb_Purchase_BookTransfer
            // 
            this.rb_Purchase_BookTransfer.AutoSize = true;
            this.rb_Purchase_BookTransfer.Location = new System.Drawing.Point(8, 78);
            this.rb_Purchase_BookTransfer.Name = "rb_Purchase_BookTransfer";
            this.rb_Purchase_BookTransfer.Size = new System.Drawing.Size(100, 19);
            this.rb_Purchase_BookTransfer.TabIndex = 3;
            this.rb_Purchase_BookTransfer.TabStop = true;
            this.rb_Purchase_BookTransfer.Text = "Bank Transfer";
            this.rb_Purchase_BookTransfer.UseVisualStyleBackColor = true;
            // 
            // rb_Purchase_PettyCash
            // 
            this.rb_Purchase_PettyCash.AutoSize = true;
            this.rb_Purchase_PettyCash.Location = new System.Drawing.Point(8, 51);
            this.rb_Purchase_PettyCash.Name = "rb_Purchase_PettyCash";
            this.rb_Purchase_PettyCash.Size = new System.Drawing.Size(83, 19);
            this.rb_Purchase_PettyCash.TabIndex = 2;
            this.rb_Purchase_PettyCash.TabStop = true;
            this.rb_Purchase_PettyCash.Text = "Petty Cash";
            this.rb_Purchase_PettyCash.UseVisualStyleBackColor = true;
            // 
            // rb_Purchase_Credit
            // 
            this.rb_Purchase_Credit.AutoSize = true;
            this.rb_Purchase_Credit.Location = new System.Drawing.Point(85, 23);
            this.rb_Purchase_Credit.Name = "rb_Purchase_Credit";
            this.rb_Purchase_Credit.Size = new System.Drawing.Size(57, 19);
            this.rb_Purchase_Credit.TabIndex = 1;
            this.rb_Purchase_Credit.TabStop = true;
            this.rb_Purchase_Credit.Text = "Credit";
            this.rb_Purchase_Credit.UseVisualStyleBackColor = true;
            // 
            // rb_Purchase_Cash
            // 
            this.rb_Purchase_Cash.AutoSize = true;
            this.rb_Purchase_Cash.Location = new System.Drawing.Point(8, 23);
            this.rb_Purchase_Cash.Name = "rb_Purchase_Cash";
            this.rb_Purchase_Cash.Size = new System.Drawing.Size(52, 19);
            this.rb_Purchase_Cash.TabIndex = 0;
            this.rb_Purchase_Cash.TabStop = true;
            this.rb_Purchase_Cash.Text = "Cash";
            this.rb_Purchase_Cash.UseVisualStyleBackColor = true;
            // 
            // cob_Purchase_Emirates
            // 
            this.cob_Purchase_Emirates.FormattingEnabled = true;
            this.cob_Purchase_Emirates.Location = new System.Drawing.Point(845, 31);
            this.cob_Purchase_Emirates.Name = "cob_Purchase_Emirates";
            this.cob_Purchase_Emirates.Size = new System.Drawing.Size(150, 23);
            this.cob_Purchase_Emirates.TabIndex = 20;
            // 
            // lbl_Purchase_Emirates
            // 
            this.lbl_Purchase_Emirates.AutoSize = true;
            this.lbl_Purchase_Emirates.Location = new System.Drawing.Point(787, 35);
            this.lbl_Purchase_Emirates.Name = "lbl_Purchase_Emirates";
            this.lbl_Purchase_Emirates.Size = new System.Drawing.Size(52, 15);
            this.lbl_Purchase_Emirates.TabIndex = 19;
            this.lbl_Purchase_Emirates.Text = "Emirates";
            // 
            // cob_CostCenter
            // 
            this.cob_CostCenter.FormattingEnabled = true;
            this.cob_CostCenter.Location = new System.Drawing.Point(374, 177);
            this.cob_CostCenter.Name = "cob_CostCenter";
            this.cob_CostCenter.Size = new System.Drawing.Size(101, 23);
            this.cob_CostCenter.TabIndex = 18;
            // 
            // lbl_Purchase_CostCenter
            // 
            this.lbl_Purchase_CostCenter.AutoSize = true;
            this.lbl_Purchase_CostCenter.Location = new System.Drawing.Point(298, 180);
            this.lbl_Purchase_CostCenter.Name = "lbl_Purchase_CostCenter";
            this.lbl_Purchase_CostCenter.Size = new System.Drawing.Size(70, 15);
            this.lbl_Purchase_CostCenter.TabIndex = 17;
            this.lbl_Purchase_CostCenter.Text = "Cost Center";
            // 
            // txt_Purchase_CustTRN
            // 
            this.txt_Purchase_CustTRN.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Purchase_CustTRN.Location = new System.Drawing.Point(98, 176);
            this.txt_Purchase_CustTRN.Name = "txt_Purchase_CustTRN";
            this.txt_Purchase_CustTRN.Size = new System.Drawing.Size(194, 22);
            this.txt_Purchase_CustTRN.TabIndex = 16;
            // 
            // lbl_Purchase_CustTRN
            // 
            this.lbl_Purchase_CustTRN.Location = new System.Drawing.Point(5, 179);
            this.lbl_Purchase_CustTRN.Name = "lbl_Purchase_CustTRN";
            this.lbl_Purchase_CustTRN.Size = new System.Drawing.Size(70, 15);
            this.lbl_Purchase_CustTRN.TabIndex = 0;
            this.lbl_Purchase_CustTRN.Text = "Cust TRN";
            // 
            // txt_Purchase_Description
            // 
            this.txt_Purchase_Description.Location = new System.Drawing.Point(98, 122);
            this.txt_Purchase_Description.Name = "txt_Purchase_Description";
            this.txt_Purchase_Description.Size = new System.Drawing.Size(378, 48);
            this.txt_Purchase_Description.TabIndex = 15;
            this.txt_Purchase_Description.Text = "";
            // 
            // lbl_Purchase_Description
            // 
            this.lbl_Purchase_Description.AutoSize = true;
            this.lbl_Purchase_Description.Location = new System.Drawing.Point(5, 122);
            this.lbl_Purchase_Description.Name = "lbl_Purchase_Description";
            this.lbl_Purchase_Description.Size = new System.Drawing.Size(69, 15);
            this.lbl_Purchase_Description.TabIndex = 14;
            this.lbl_Purchase_Description.Text = "Description";
            // 
            // dt_Purchase_DueDate
            // 
            this.dt_Purchase_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Purchase_DueDate.Location = new System.Drawing.Point(360, 93);
            this.dt_Purchase_DueDate.Name = "dt_Purchase_DueDate";
            this.dt_Purchase_DueDate.Size = new System.Drawing.Size(116, 22);
            this.dt_Purchase_DueDate.TabIndex = 13;
            // 
            // lbl_Purchase_DueDate
            // 
            this.lbl_Purchase_DueDate.AutoSize = true;
            this.lbl_Purchase_DueDate.Location = new System.Drawing.Point(280, 97);
            this.lbl_Purchase_DueDate.Name = "lbl_Purchase_DueDate";
            this.lbl_Purchase_DueDate.Size = new System.Drawing.Size(57, 15);
            this.lbl_Purchase_DueDate.TabIndex = 12;
            this.lbl_Purchase_DueDate.Text = "Due Date";
            // 
            // lbl_Purchase_ItemSearch
            // 
            this.lbl_Purchase_ItemSearch.AutoSize = true;
            this.lbl_Purchase_ItemSearch.Location = new System.Drawing.Point(795, 0);
            this.lbl_Purchase_ItemSearch.Name = "lbl_Purchase_ItemSearch";
            this.lbl_Purchase_ItemSearch.Size = new System.Drawing.Size(155, 15);
            this.lbl_Purchase_ItemSearch.TabIndex = 2;
            this.lbl_Purchase_ItemSearch.Text = "Item Search Using Serial No";
            // 
            // txt_Purchase_SupplierInvNo
            // 
            this.txt_Purchase_SupplierInvNo.Location = new System.Drawing.Point(98, 94);
            this.txt_Purchase_SupplierInvNo.Name = "txt_Purchase_SupplierInvNo";
            this.txt_Purchase_SupplierInvNo.Size = new System.Drawing.Size(116, 22);
            this.txt_Purchase_SupplierInvNo.TabIndex = 11;
            // 
            // lbl_Purchase_SupplierInvNo
            // 
            this.lbl_Purchase_SupplierInvNo.AutoSize = true;
            this.lbl_Purchase_SupplierInvNo.Location = new System.Drawing.Point(5, 96);
            this.lbl_Purchase_SupplierInvNo.Name = "lbl_Purchase_SupplierInvNo";
            this.lbl_Purchase_SupplierInvNo.Size = new System.Drawing.Size(91, 15);
            this.lbl_Purchase_SupplierInvNo.TabIndex = 10;
            this.lbl_Purchase_SupplierInvNo.Text = "Supplier Inv No";
            // 
            // txt_Purchase_CurrentRate
            // 
            this.txt_Purchase_CurrentRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Purchase_CurrentRate.Location = new System.Drawing.Point(360, 65);
            this.txt_Purchase_CurrentRate.Name = "txt_Purchase_CurrentRate";
            this.txt_Purchase_CurrentRate.Size = new System.Drawing.Size(116, 22);
            this.txt_Purchase_CurrentRate.TabIndex = 9;
            // 
            // lbl_Purchase_CurrentRate
            // 
            this.lbl_Purchase_CurrentRate.AutoSize = true;
            this.lbl_Purchase_CurrentRate.Location = new System.Drawing.Point(280, 69);
            this.lbl_Purchase_CurrentRate.Name = "lbl_Purchase_CurrentRate";
            this.lbl_Purchase_CurrentRate.Size = new System.Drawing.Size(74, 15);
            this.lbl_Purchase_CurrentRate.TabIndex = 8;
            this.lbl_Purchase_CurrentRate.Text = "Current Rate";
            // 
            // cob_Purchase_Currency
            // 
            this.cob_Purchase_Currency.FormattingEnabled = true;
            this.cob_Purchase_Currency.Location = new System.Drawing.Point(98, 65);
            this.cob_Purchase_Currency.Name = "cob_Purchase_Currency";
            this.cob_Purchase_Currency.Size = new System.Drawing.Size(173, 23);
            this.cob_Purchase_Currency.TabIndex = 7;
            this.cob_Purchase_Currency.SelectedIndexChanged += new System.EventHandler(this.cbox_Currency_SelectedIndexChanged);
            // 
            // lbl_Purchase_Currency
            // 
            this.lbl_Purchase_Currency.AutoSize = true;
            this.lbl_Purchase_Currency.Location = new System.Drawing.Point(5, 68);
            this.lbl_Purchase_Currency.Name = "lbl_Purchase_Currency";
            this.lbl_Purchase_Currency.Size = new System.Drawing.Size(56, 15);
            this.lbl_Purchase_Currency.TabIndex = 6;
            this.lbl_Purchase_Currency.Text = "Currency";
            // 
            // lbl_Purchase_SupplierName
            // 
            this.lbl_Purchase_SupplierName.AutoSize = true;
            this.lbl_Purchase_SupplierName.Location = new System.Drawing.Point(5, 40);
            this.lbl_Purchase_SupplierName.Name = "lbl_Purchase_SupplierName";
            this.lbl_Purchase_SupplierName.Size = new System.Drawing.Size(84, 15);
            this.lbl_Purchase_SupplierName.TabIndex = 4;
            this.lbl_Purchase_SupplierName.Text = "Supplier Name";
            // 
            // txt_Purchase_PurchaseDate
            // 
            this.txt_Purchase_PurchaseDate.CustomFormat = "";
            this.txt_Purchase_PurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Purchase_PurchaseDate.Location = new System.Drawing.Point(364, 9);
            this.txt_Purchase_PurchaseDate.Name = "txt_Purchase_PurchaseDate";
            this.txt_Purchase_PurchaseDate.Size = new System.Drawing.Size(112, 22);
            this.txt_Purchase_PurchaseDate.TabIndex = 3;
            this.txt_Purchase_PurchaseDate.Value = new System.DateTime(2020, 7, 21, 0, 0, 0, 0);
            // 
            // lbl_Purchase_PurchaseDate
            // 
            this.lbl_Purchase_PurchaseDate.AutoSize = true;
            this.lbl_Purchase_PurchaseDate.Location = new System.Drawing.Point(280, 13);
            this.lbl_Purchase_PurchaseDate.Name = "lbl_Purchase_PurchaseDate";
            this.lbl_Purchase_PurchaseDate.Size = new System.Drawing.Size(84, 15);
            this.lbl_Purchase_PurchaseDate.TabIndex = 2;
            this.lbl_Purchase_PurchaseDate.Text = "Purchase Date";
            // 
            // txt_Purchase_InvoiceID
            // 
            this.txt_Purchase_InvoiceID.Location = new System.Drawing.Point(98, 9);
            this.txt_Purchase_InvoiceID.Name = "txt_Purchase_InvoiceID";
            this.txt_Purchase_InvoiceID.Size = new System.Drawing.Size(176, 22);
            this.txt_Purchase_InvoiceID.TabIndex = 1;
            // 
            // lbl_Purchase_InvoiceID
            // 
            this.lbl_Purchase_InvoiceID.AutoSize = true;
            this.lbl_Purchase_InvoiceID.Location = new System.Drawing.Point(5, 13);
            this.lbl_Purchase_InvoiceID.Name = "lbl_Purchase_InvoiceID";
            this.lbl_Purchase_InvoiceID.Size = new System.Drawing.Size(63, 15);
            this.lbl_Purchase_InvoiceID.TabIndex = 0;
            this.lbl_Purchase_InvoiceID.Text = "Invoice ID";
            // 
            // pnl_Purchase_DeviceSelect
            // 
            this.pnl_Purchase_DeviceSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Purchase_DeviceSelect.Controls.Add(this.btn_Purchase_Browser);
            this.pnl_Purchase_DeviceSelect.Controls.Add(this.btn_Purchase_ScanImage);
            this.pnl_Purchase_DeviceSelect.Controls.Add(this.cob_Purchase_SelectDevice);
            this.pnl_Purchase_DeviceSelect.Controls.Add(this.lbl_Purchase_SelectDevice);
            this.pnl_Purchase_DeviceSelect.Location = new System.Drawing.Point(1161, 3);
            this.pnl_Purchase_DeviceSelect.Name = "pnl_Purchase_DeviceSelect";
            this.pnl_Purchase_DeviceSelect.Size = new System.Drawing.Size(178, 555);
            this.pnl_Purchase_DeviceSelect.TabIndex = 3;
            // 
            // btn_Purchase_Browser
            // 
            this.btn_Purchase_Browser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Purchase_Browser.Location = new System.Drawing.Point(92, 512);
            this.btn_Purchase_Browser.Name = "btn_Purchase_Browser";
            this.btn_Purchase_Browser.Size = new System.Drawing.Size(76, 35);
            this.btn_Purchase_Browser.TabIndex = 3;
            this.btn_Purchase_Browser.Text = "Browser";
            this.btn_Purchase_Browser.UseVisualStyleBackColor = true;
            // 
            // btn_Purchase_ScanImage
            // 
            this.btn_Purchase_ScanImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Purchase_ScanImage.Location = new System.Drawing.Point(10, 512);
            this.btn_Purchase_ScanImage.Name = "btn_Purchase_ScanImage";
            this.btn_Purchase_ScanImage.Size = new System.Drawing.Size(76, 35);
            this.btn_Purchase_ScanImage.TabIndex = 2;
            this.btn_Purchase_ScanImage.Text = "Scan Image";
            this.btn_Purchase_ScanImage.UseVisualStyleBackColor = true;
            // 
            // cob_Purchase_SelectDevice
            // 
            this.cob_Purchase_SelectDevice.FormattingEnabled = true;
            this.cob_Purchase_SelectDevice.Location = new System.Drawing.Point(8, 483);
            this.cob_Purchase_SelectDevice.Name = "cob_Purchase_SelectDevice";
            this.cob_Purchase_SelectDevice.Size = new System.Drawing.Size(160, 23);
            this.cob_Purchase_SelectDevice.TabIndex = 1;
            // 
            // lbl_Purchase_SelectDevice
            // 
            this.lbl_Purchase_SelectDevice.AutoSize = true;
            this.lbl_Purchase_SelectDevice.Location = new System.Drawing.Point(5, 462);
            this.lbl_Purchase_SelectDevice.Name = "lbl_Purchase_SelectDevice";
            this.lbl_Purchase_SelectDevice.Size = new System.Drawing.Size(79, 15);
            this.lbl_Purchase_SelectDevice.TabIndex = 0;
            this.lbl_Purchase_SelectDevice.Text = "Select Device";
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_item.Location = new System.Drawing.Point(5, 218);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.Size = new System.Drawing.Size(1146, 227);
            this.dgv_item.TabIndex = 4;
            this.dgv_item.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_item_EditingControlShowing);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenu_Add,
            this.SubMenu_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 48);
            // 
            // SubMenu_Add
            // 
            this.SubMenu_Add.Name = "SubMenu_Add";
            this.SubMenu_Add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SubMenu_Add.Size = new System.Drawing.Size(149, 22);
            this.SubMenu_Add.Text = "Add";
            this.SubMenu_Add.Click += new System.EventHandler(this.SubMenu_Add_Click);
            // 
            // SubMenu_Delete
            // 
            this.SubMenu_Delete.Name = "SubMenu_Delete";
            this.SubMenu_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.SubMenu_Delete.Size = new System.Drawing.Size(149, 22);
            this.SubMenu_Delete.Text = "Delete";
            this.SubMenu_Delete.Click += new System.EventHandler(this.SubMenu_Delete_Click);
            // 
            // btn_Purchase_ResetFDC
            // 
            this.btn_Purchase_ResetFDC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Purchase_ResetFDC.Location = new System.Drawing.Point(5, 451);
            this.btn_Purchase_ResetFDC.Name = "btn_Purchase_ResetFDC";
            this.btn_Purchase_ResetFDC.Size = new System.Drawing.Size(87, 36);
            this.btn_Purchase_ResetFDC.TabIndex = 5;
            this.btn_Purchase_ResetFDC.Text = "Reset FDC";
            this.btn_Purchase_ResetFDC.UseVisualStyleBackColor = true;
            // 
            // GV_Purchase_FDCDetails
            // 
            this.GV_Purchase_FDCDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Purchase_FDCDetails.Location = new System.Drawing.Point(98, 451);
            this.GV_Purchase_FDCDetails.Name = "GV_Purchase_FDCDetails";
            this.GV_Purchase_FDCDetails.Size = new System.Drawing.Size(415, 98);
            this.GV_Purchase_FDCDetails.TabIndex = 6;
            // 
            // btn_Purchase_LoadPDT
            // 
            this.btn_Purchase_LoadPDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Purchase_LoadPDT.Location = new System.Drawing.Point(519, 451);
            this.btn_Purchase_LoadPDT.Name = "btn_Purchase_LoadPDT";
            this.btn_Purchase_LoadPDT.Size = new System.Drawing.Size(87, 53);
            this.btn_Purchase_LoadPDT.TabIndex = 7;
            this.btn_Purchase_LoadPDT.Text = "Load PDT";
            this.btn_Purchase_LoadPDT.UseVisualStyleBackColor = true;
            // 
            // btn_Purchase_LostFile
            // 
            this.btn_Purchase_LostFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Purchase_LostFile.Location = new System.Drawing.Point(519, 510);
            this.btn_Purchase_LostFile.Name = "btn_Purchase_LostFile";
            this.btn_Purchase_LostFile.Size = new System.Drawing.Size(87, 53);
            this.btn_Purchase_LostFile.TabIndex = 8;
            this.btn_Purchase_LostFile.Text = "Lost File";
            this.btn_Purchase_LostFile.UseVisualStyleBackColor = true;
            // 
            // lbl_Purchase_TotalQty
            // 
            this.lbl_Purchase_TotalQty.AutoSize = true;
            this.lbl_Purchase_TotalQty.Location = new System.Drawing.Point(611, 454);
            this.lbl_Purchase_TotalQty.Name = "lbl_Purchase_TotalQty";
            this.lbl_Purchase_TotalQty.Size = new System.Drawing.Size(57, 15);
            this.lbl_Purchase_TotalQty.TabIndex = 9;
            this.lbl_Purchase_TotalQty.Text = "Total Qty";
            // 
            // txt_Purchase_TotalQty
            // 
            this.txt_Purchase_TotalQty.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Purchase_TotalQty.Location = new System.Drawing.Point(687, 451);
            this.txt_Purchase_TotalQty.Name = "txt_Purchase_TotalQty";
            this.txt_Purchase_TotalQty.Size = new System.Drawing.Size(137, 22);
            this.txt_Purchase_TotalQty.TabIndex = 10;
            // 
            // lbl_Purchase_TotalBillAmt
            // 
            this.lbl_Purchase_TotalBillAmt.AutoSize = true;
            this.lbl_Purchase_TotalBillAmt.Location = new System.Drawing.Point(611, 485);
            this.lbl_Purchase_TotalBillAmt.Name = "lbl_Purchase_TotalBillAmt";
            this.lbl_Purchase_TotalBillAmt.Size = new System.Drawing.Size(79, 15);
            this.lbl_Purchase_TotalBillAmt.TabIndex = 11;
            this.lbl_Purchase_TotalBillAmt.Text = "Total Bill Amt";
            // 
            // txt_Purchase_TotalBillAmt
            // 
            this.txt_Purchase_TotalBillAmt.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Purchase_TotalBillAmt.Location = new System.Drawing.Point(687, 482);
            this.txt_Purchase_TotalBillAmt.Name = "txt_Purchase_TotalBillAmt";
            this.txt_Purchase_TotalBillAmt.Size = new System.Drawing.Size(137, 22);
            this.txt_Purchase_TotalBillAmt.TabIndex = 12;
            // 
            // lbl_Purchase_NetAmt
            // 
            this.lbl_Purchase_NetAmt.AutoSize = true;
            this.lbl_Purchase_NetAmt.Location = new System.Drawing.Point(612, 513);
            this.lbl_Purchase_NetAmt.Name = "lbl_Purchase_NetAmt";
            this.lbl_Purchase_NetAmt.Size = new System.Drawing.Size(72, 15);
            this.lbl_Purchase_NetAmt.TabIndex = 13;
            this.lbl_Purchase_NetAmt.Text = "Net Amount";
            // 
            // txt_Purchase_NetAmt
            // 
            this.txt_Purchase_NetAmt.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Purchase_NetAmt.Location = new System.Drawing.Point(687, 510);
            this.txt_Purchase_NetAmt.Name = "txt_Purchase_NetAmt";
            this.txt_Purchase_NetAmt.Size = new System.Drawing.Size(137, 22);
            this.txt_Purchase_NetAmt.TabIndex = 14;
            // 
            // lbl_Purchase_TotalAmt
            // 
            this.lbl_Purchase_TotalAmt.AutoSize = true;
            this.lbl_Purchase_TotalAmt.Location = new System.Drawing.Point(830, 454);
            this.lbl_Purchase_TotalAmt.Name = "lbl_Purchase_TotalAmt";
            this.lbl_Purchase_TotalAmt.Size = new System.Drawing.Size(80, 15);
            this.lbl_Purchase_TotalAmt.TabIndex = 15;
            this.lbl_Purchase_TotalAmt.Text = "Total Amount";
            // 
            // lbl_Purchase_OtherCharges
            // 
            this.lbl_Purchase_OtherCharges.AutoSize = true;
            this.lbl_Purchase_OtherCharges.Location = new System.Drawing.Point(830, 482);
            this.lbl_Purchase_OtherCharges.Name = "lbl_Purchase_OtherCharges";
            this.lbl_Purchase_OtherCharges.Size = new System.Drawing.Size(84, 15);
            this.lbl_Purchase_OtherCharges.TabIndex = 16;
            this.lbl_Purchase_OtherCharges.Text = "Other Charges";
            // 
            // lbl_Purchase_Discount
            // 
            this.lbl_Purchase_Discount.AutoSize = true;
            this.lbl_Purchase_Discount.Location = new System.Drawing.Point(830, 509);
            this.lbl_Purchase_Discount.Name = "lbl_Purchase_Discount";
            this.lbl_Purchase_Discount.Size = new System.Drawing.Size(56, 15);
            this.lbl_Purchase_Discount.TabIndex = 17;
            this.lbl_Purchase_Discount.Text = "Discount";
            // 
            // lbl_Purchase_TotalVAT
            // 
            this.lbl_Purchase_TotalVAT.AutoSize = true;
            this.lbl_Purchase_TotalVAT.Location = new System.Drawing.Point(830, 537);
            this.lbl_Purchase_TotalVAT.Name = "lbl_Purchase_TotalVAT";
            this.lbl_Purchase_TotalVAT.Size = new System.Drawing.Size(60, 15);
            this.lbl_Purchase_TotalVAT.TabIndex = 18;
            this.lbl_Purchase_TotalVAT.Text = "Total VAT";
            // 
            // txt_Purchase_TotalAmt
            // 
            this.txt_Purchase_TotalAmt.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Purchase_TotalAmt.Location = new System.Drawing.Point(916, 451);
            this.txt_Purchase_TotalAmt.Name = "txt_Purchase_TotalAmt";
            this.txt_Purchase_TotalAmt.Size = new System.Drawing.Size(116, 22);
            this.txt_Purchase_TotalAmt.TabIndex = 19;
            // 
            // txt_Purchase_OtherCharges
            // 
            this.txt_Purchase_OtherCharges.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Purchase_OtherCharges.Location = new System.Drawing.Point(916, 479);
            this.txt_Purchase_OtherCharges.Name = "txt_Purchase_OtherCharges";
            this.txt_Purchase_OtherCharges.Size = new System.Drawing.Size(116, 22);
            this.txt_Purchase_OtherCharges.TabIndex = 20;
            // 
            // txt_Purchase_Discount
            // 
            this.txt_Purchase_Discount.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Purchase_Discount.Location = new System.Drawing.Point(916, 506);
            this.txt_Purchase_Discount.Name = "txt_Purchase_Discount";
            this.txt_Purchase_Discount.Size = new System.Drawing.Size(116, 22);
            this.txt_Purchase_Discount.TabIndex = 21;
            // 
            // txt_Purchase_TotalVAT
            // 
            this.txt_Purchase_TotalVAT.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Purchase_TotalVAT.Location = new System.Drawing.Point(916, 534);
            this.txt_Purchase_TotalVAT.Name = "txt_Purchase_TotalVAT";
            this.txt_Purchase_TotalVAT.Size = new System.Drawing.Size(116, 22);
            this.txt_Purchase_TotalVAT.TabIndex = 22;
            // 
            // pnl_Purchase_Footer
            // 
            this.pnl_Purchase_Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Purchase_Footer.Controls.Add(this.ucFirstPreNextLast1);
            this.pnl_Purchase_Footer.Controls.Add(this.ucTransactionLPO);
            this.pnl_Purchase_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Purchase_Footer.Location = new System.Drawing.Point(0, 577);
            this.pnl_Purchase_Footer.Name = "pnl_Purchase_Footer";
            this.pnl_Purchase_Footer.Size = new System.Drawing.Size(1347, 49);
            this.pnl_Purchase_Footer.TabIndex = 23;
            // 
            // ucFirstPreNextLast1
            // 
            this.ucFirstPreNextLast1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucFirstPreNextLast1.Location = new System.Drawing.Point(1027, 7);
            this.ucFirstPreNextLast1.Name = "ucFirstPreNextLast1";
            this.ucFirstPreNextLast1.Size = new System.Drawing.Size(308, 37);
            this.ucFirstPreNextLast1.TabIndex = 3;
            // 
            // ucTransactionLPO
            // 
            this.ucTransactionLPO.Location = new System.Drawing.Point(0, 7);
            this.ucTransactionLPO.Name = "ucTransactionLPO";
            this.ucTransactionLPO.Size = new System.Drawing.Size(602, 36);
            this.ucTransactionLPO.TabIndex = 2;
            // 
            // lbl_Purchase_FDCDetails
            // 
            this.lbl_Purchase_FDCDetails.AutoSize = true;
            this.lbl_Purchase_FDCDetails.Location = new System.Drawing.Point(9, 499);
            this.lbl_Purchase_FDCDetails.Name = "lbl_Purchase_FDCDetails";
            this.lbl_Purchase_FDCDetails.Size = new System.Drawing.Size(71, 15);
            this.lbl_Purchase_FDCDetails.TabIndex = 24;
            this.lbl_Purchase_FDCDetails.Text = "FDC Details";
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgv_list);
            this.pnlItem.Location = new System.Drawing.Point(353, 220);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(994, 359);
            this.pnlItem.TabIndex = 43;
            this.pnlItem.Visible = false;
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_list.Location = new System.Drawing.Point(0, 0);
            this.dgv_list.MultiSelect = false;
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_list.RowTemplate.ReadOnly = true;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(994, 359);
            this.dgv_list.TabIndex = 39;
            this.dgv_list.DoubleClick += new System.EventHandler(this.dgv_list_DoubleClick);
            this.dgv_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_list_KeyDown);
            // 
            // frm_Transaction_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1347, 626);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.lbl_Purchase_FDCDetails);
            this.Controls.Add(this.pnl_Purchase_Footer);
            this.Controls.Add(this.txt_Purchase_TotalVAT);
            this.Controls.Add(this.txt_Purchase_Discount);
            this.Controls.Add(this.txt_Purchase_OtherCharges);
            this.Controls.Add(this.txt_Purchase_TotalAmt);
            this.Controls.Add(this.lbl_Purchase_TotalVAT);
            this.Controls.Add(this.lbl_Purchase_Discount);
            this.Controls.Add(this.lbl_Purchase_OtherCharges);
            this.Controls.Add(this.lbl_Purchase_TotalAmt);
            this.Controls.Add(this.txt_Purchase_NetAmt);
            this.Controls.Add(this.lbl_Purchase_NetAmt);
            this.Controls.Add(this.txt_Purchase_TotalBillAmt);
            this.Controls.Add(this.lbl_Purchase_TotalBillAmt);
            this.Controls.Add(this.txt_Purchase_TotalQty);
            this.Controls.Add(this.lbl_Purchase_TotalQty);
            this.Controls.Add(this.btn_Purchase_LostFile);
            this.Controls.Add(this.btn_Purchase_LoadPDT);
            this.Controls.Add(this.GV_Purchase_FDCDetails);
            this.Controls.Add(this.btn_Purchase_ResetFDC);
            this.Controls.Add(this.dgv_item);
            this.Controls.Add(this.pnl_Purchase_DeviceSelect);
            this.Controls.Add(this.pnl_Purchase_Invoice);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transaction_Purchase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Purchase";
            this.Load += new System.EventHandler(this.frm_Transaction_Purchase_Load);
            this.pnl_Purchase_Invoice.ResumeLayout(false);
            this.pnl_Purchase_Invoice.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_Purchase_DeviceSelect.ResumeLayout(false);
            this.pnl_Purchase_DeviceSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_Purchase_FDCDetails)).EndInit();
            this.pnl_Purchase_Footer.ResumeLayout(false);
            this.pnlItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Purchase_Invoice;
        private System.Windows.Forms.CheckBox cb_Purchase_ListItems;
        private System.Windows.Forms.CheckBox cb_Purchase_VAT;
        private System.Windows.Forms.CheckBox cb_Purchase_SupplierPriceList;
        private System.Windows.Forms.Label lbl_Purchase_ReplicableItem;
        private System.Windows.Forms.CheckBox cb_Purchase_ListOneItem;
        private System.Windows.Forms.Label lbl_Purchase_GRV;
        private System.Windows.Forms.Label lbl_Purchase_LPO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Purchase_BookTransfer;
        private System.Windows.Forms.RadioButton rb_Purchase_PettyCash;
        private System.Windows.Forms.RadioButton rb_Purchase_Credit;
        private System.Windows.Forms.RadioButton rb_Purchase_Cash;
        private System.Windows.Forms.ComboBox cob_Purchase_Emirates;
        private System.Windows.Forms.Label lbl_Purchase_Emirates;
        private System.Windows.Forms.ComboBox cob_CostCenter;
        private System.Windows.Forms.Label lbl_Purchase_CostCenter;
        private System.Windows.Forms.TextBox txt_Purchase_CustTRN;
        private System.Windows.Forms.Label lbl_Purchase_CustTRN;
        private System.Windows.Forms.RichTextBox txt_Purchase_Description;
        private System.Windows.Forms.Label lbl_Purchase_Description;
        private System.Windows.Forms.DateTimePicker dt_Purchase_DueDate;
        private System.Windows.Forms.Label lbl_Purchase_DueDate;
        private System.Windows.Forms.TextBox txt_Purchase_SupplierInvNo;
        private System.Windows.Forms.Label lbl_Purchase_SupplierInvNo;
        private System.Windows.Forms.TextBox txt_Purchase_CurrentRate;
        private System.Windows.Forms.Label lbl_Purchase_CurrentRate;
        private System.Windows.Forms.ComboBox cob_Purchase_Currency;
        private System.Windows.Forms.Label lbl_Purchase_Currency;
        private System.Windows.Forms.Label lbl_Purchase_SupplierName;
        private System.Windows.Forms.DateTimePicker txt_Purchase_PurchaseDate;
        private System.Windows.Forms.Label lbl_Purchase_PurchaseDate;
        private System.Windows.Forms.TextBox txt_Purchase_InvoiceID;
        private System.Windows.Forms.Label lbl_Purchase_InvoiceID;
        private System.Windows.Forms.Label lbl_Purchase_ItemSearch;
        private System.Windows.Forms.Panel pnl_Purchase_DeviceSelect;
        private System.Windows.Forms.Button btn_Purchase_Browser;
        private System.Windows.Forms.Button btn_Purchase_ScanImage;
        private System.Windows.Forms.ComboBox cob_Purchase_SelectDevice;
        private System.Windows.Forms.Label lbl_Purchase_SelectDevice;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.Button btn_Purchase_ResetFDC;
        private System.Windows.Forms.DataGridView GV_Purchase_FDCDetails;
        private System.Windows.Forms.Button btn_Purchase_LoadPDT;
        private System.Windows.Forms.Button btn_Purchase_LostFile;
        private System.Windows.Forms.Label lbl_Purchase_TotalQty;
        private System.Windows.Forms.TextBox txt_Purchase_TotalQty;
        private System.Windows.Forms.Label lbl_Purchase_TotalBillAmt;
        private System.Windows.Forms.TextBox txt_Purchase_TotalBillAmt;
        private System.Windows.Forms.Label lbl_Purchase_NetAmt;
        private System.Windows.Forms.TextBox txt_Purchase_NetAmt;
        private System.Windows.Forms.Label lbl_Purchase_TotalAmt;
        private System.Windows.Forms.Label lbl_Purchase_OtherCharges;
        private System.Windows.Forms.Label lbl_Purchase_Discount;
        private System.Windows.Forms.Label lbl_Purchase_TotalVAT;
        private System.Windows.Forms.TextBox txt_Purchase_TotalAmt;
        private System.Windows.Forms.TextBox txt_Purchase_OtherCharges;
        private System.Windows.Forms.TextBox txt_Purchase_Discount;
        private System.Windows.Forms.TextBox txt_Purchase_TotalVAT;
        private System.Windows.Forms.Panel pnl_Purchase_Footer;
        private System.Windows.Forms.Label lbl_Purchase_FDCDetails;
        private UControl.ucFirstPreNextLast ucFirstPreNextLast1;
        private UControl.ucTransaction ucTransactionLPO;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Add;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Delete;
        private UControl.ucComboBox txt_Purchase_SupplierName;
        private System.Windows.Forms.Label lbl_SupplierID;
        private System.Windows.Forms.TextBox txtSuppid;
        private UControl.ucComboBoxSmall txt_Purchase_GRV;
        private UControl.ucComboBoxSmall txt_Purchase_LPO;
        private System.Windows.Forms.Panel pnlItem;
        public System.Windows.Forms.DataGridView dgv_list;
    }
}