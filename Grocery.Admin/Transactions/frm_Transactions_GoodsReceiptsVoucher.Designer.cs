namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_GoodsReceiptsVoucher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_GoodsReceiptVoucher_SupplierName = new Grocery.Admin.UControl.ucComboBox();
            this.lbl_GoodsReceiptVoucher_ReplicateItem = new System.Windows.Forms.Label();
            this.rb_GoodsReceiptVoucher_Credit = new System.Windows.Forms.RadioButton();
            this.txt_GoodsReceiptVoucher_Discount = new System.Windows.Forms.TextBox();
            this.rb_GoodsReceiptVoucher_Cash = new System.Windows.Forms.RadioButton();
            this.txt_GoodsReceiptVoucher_OtherCharges = new System.Windows.Forms.TextBox();
            this.txt_GoodsReceiptVoucher_TotalAmt = new System.Windows.Forms.TextBox();
            this.lbl_GoodsReceiptVoucher_Discount = new System.Windows.Forms.Label();
            this.lbl_GoodsReceiptVoucher_OtherCharges = new System.Windows.Forms.Label();
            this.lbl_GoodsReceiptVoucher_TotalAmt = new System.Windows.Forms.Label();
            this.txt_GoodsReceiptVoucher_TotalVAT = new System.Windows.Forms.TextBox();
            this.txt_GoodsReceiptVoucher_TotalQty = new System.Windows.Forms.TextBox();
            this.lbl_GoodsReceiptVoucher_TotalVAT = new System.Windows.Forms.Label();
            this.lbl_GoodsReceiptVoucher_TotalQty = new System.Windows.Forms.Label();
            this.btn_GoodsReceiptVoucher_LoadPDT = new System.Windows.Forms.Button();
            this.txt_GoodsReceiptVoucher_NetAmt = new System.Windows.Forms.TextBox();
            this.lbl_GoodsReceiptVoucher_TotalAmtOC = new System.Windows.Forms.Label();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SubMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_GoodsReceiptVoucher_OneItem = new System.Windows.Forms.CheckBox();
            this.cb_GoodsReceiptVoucher_AllItem = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_GoodsReceiptVoucher_ScanImage = new System.Windows.Forms.Button();
            this.btn_GoodsReceiptVoucher_Browse = new System.Windows.Forms.Button();
            this.cob_GoodsReceiptVoucher_SelectDevice = new System.Windows.Forms.ComboBox();
            this.lbl_GoodsReceiptVoucher_SelectDevice = new System.Windows.Forms.Label();
            this.txt_GoodsReceiptVoucher_LPO = new System.Windows.Forms.TextBox();
            this.lbl_GoodsReceiptVoucher_LPO = new System.Windows.Forms.Label();
            this.cob_CostCenter = new System.Windows.Forms.ComboBox();
            this.txtSuppid = new System.Windows.Forms.TextBox();
            this.lbl_GoodsReceiptVoucher_CostCenter = new System.Windows.Forms.Label();
            this.lbl_GoodsReceiptVoucher_PaymentMode = new System.Windows.Forms.Label();
            this.lbl_GoodsReceiptVoucher_SupplierID = new System.Windows.Forms.Label();
            this.txt_GoodsReceiptVoucher_CurRate = new System.Windows.Forms.TextBox();
            this.lbl_GoodsReceiptVoucher_CurRate = new System.Windows.Forms.Label();
            this.cob_GoodsReceiptVoucher_Currency = new System.Windows.Forms.ComboBox();
            this.lbl_GoodsReceiptVoucher_Currency = new System.Windows.Forms.Label();
            this.txt_GoodsReceiptVoucher_Desc = new System.Windows.Forms.TextBox();
            this.lbl_GoodsReceiptVoucher_Desc = new System.Windows.Forms.Label();
            this.txt_GoodsReceiptVoucher_SupplierRef = new System.Windows.Forms.TextBox();
            this.lbl_GoodsReceiptVoucher_SupplierRef = new System.Windows.Forms.Label();
            this.lbl_GoodsReceiptVoucher_SupplierName = new System.Windows.Forms.Label();
            this.dt_GoodsReceiptVoucher_GRVDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_GoodsReceiptVoucher_GRVDate = new System.Windows.Forms.Label();
            this.txt_GoodsReceiptVoucher_InvoiceID = new System.Windows.Forms.TextBox();
            this.lbl_GoodsReceiptVoucher_InvoiceID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucFirstPreNextLast1 = new Grocery.Admin.UControl.ucFirstPreNextLast();
            this.ucTransactionLPO = new Grocery.Admin.UControl.ucTransaction();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_SupplierName);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_ReplicateItem);
            this.panel1.Controls.Add(this.rb_GoodsReceiptVoucher_Credit);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_Discount);
            this.panel1.Controls.Add(this.rb_GoodsReceiptVoucher_Cash);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_OtherCharges);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_TotalAmt);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_Discount);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_OtherCharges);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_TotalAmt);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_TotalVAT);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_TotalQty);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_TotalVAT);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_TotalQty);
            this.panel1.Controls.Add(this.btn_GoodsReceiptVoucher_LoadPDT);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_NetAmt);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_TotalAmtOC);
            this.panel1.Controls.Add(this.dgv_item);
            this.panel1.Controls.Add(this.cb_GoodsReceiptVoucher_OneItem);
            this.panel1.Controls.Add(this.cb_GoodsReceiptVoucher_AllItem);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_LPO);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_LPO);
            this.panel1.Controls.Add(this.cob_CostCenter);
            this.panel1.Controls.Add(this.txtSuppid);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_CostCenter);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_PaymentMode);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_SupplierID);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_CurRate);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_CurRate);
            this.panel1.Controls.Add(this.cob_GoodsReceiptVoucher_Currency);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_Currency);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_Desc);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_Desc);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_SupplierRef);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_SupplierRef);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_SupplierName);
            this.panel1.Controls.Add(this.dt_GoodsReceiptVoucher_GRVDate);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_GRVDate);
            this.panel1.Controls.Add(this.txt_GoodsReceiptVoucher_InvoiceID);
            this.panel1.Controls.Add(this.lbl_GoodsReceiptVoucher_InvoiceID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 488);
            this.panel1.TabIndex = 1;
            // 
            // txt_GoodsReceiptVoucher_SupplierName
            // 
            this.txt_GoodsReceiptVoucher_SupplierName.Location = new System.Drawing.Point(93, 33);
            this.txt_GoodsReceiptVoucher_SupplierName.Name = "txt_GoodsReceiptVoucher_SupplierName";
            this.txt_GoodsReceiptVoucher_SupplierName.Size = new System.Drawing.Size(317, 22);
            this.txt_GoodsReceiptVoucher_SupplierName.TabIndex = 43;
            this.txt_GoodsReceiptVoucher_SupplierName.Tag = "SUPPLIER_LIST";
            // 
            // lbl_GoodsReceiptVoucher_ReplicateItem
            // 
            this.lbl_GoodsReceiptVoucher_ReplicateItem.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_ReplicateItem.Location = new System.Drawing.Point(773, 136);
            this.lbl_GoodsReceiptVoucher_ReplicateItem.Name = "lbl_GoodsReceiptVoucher_ReplicateItem";
            this.lbl_GoodsReceiptVoucher_ReplicateItem.Size = new System.Drawing.Size(75, 13);
            this.lbl_GoodsReceiptVoucher_ReplicateItem.TabIndex = 42;
            this.lbl_GoodsReceiptVoucher_ReplicateItem.Text = "Replicate Item";
            // 
            // rb_GoodsReceiptVoucher_Credit
            // 
            this.rb_GoodsReceiptVoucher_Credit.AutoSize = true;
            this.rb_GoodsReceiptVoucher_Credit.Location = new System.Drawing.Point(690, 107);
            this.rb_GoodsReceiptVoucher_Credit.Name = "rb_GoodsReceiptVoucher_Credit";
            this.rb_GoodsReceiptVoucher_Credit.Size = new System.Drawing.Size(52, 17);
            this.rb_GoodsReceiptVoucher_Credit.TabIndex = 1;
            this.rb_GoodsReceiptVoucher_Credit.TabStop = true;
            this.rb_GoodsReceiptVoucher_Credit.Text = "Credit";
            this.rb_GoodsReceiptVoucher_Credit.UseVisualStyleBackColor = true;
            // 
            // txt_GoodsReceiptVoucher_Discount
            // 
            this.txt_GoodsReceiptVoucher_Discount.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_GoodsReceiptVoucher_Discount.Location = new System.Drawing.Point(690, 462);
            this.txt_GoodsReceiptVoucher_Discount.Name = "txt_GoodsReceiptVoucher_Discount";
            this.txt_GoodsReceiptVoucher_Discount.Size = new System.Drawing.Size(158, 20);
            this.txt_GoodsReceiptVoucher_Discount.TabIndex = 41;
            // 
            // rb_GoodsReceiptVoucher_Cash
            // 
            this.rb_GoodsReceiptVoucher_Cash.AutoSize = true;
            this.rb_GoodsReceiptVoucher_Cash.Location = new System.Drawing.Point(633, 107);
            this.rb_GoodsReceiptVoucher_Cash.Name = "rb_GoodsReceiptVoucher_Cash";
            this.rb_GoodsReceiptVoucher_Cash.Size = new System.Drawing.Size(49, 17);
            this.rb_GoodsReceiptVoucher_Cash.TabIndex = 0;
            this.rb_GoodsReceiptVoucher_Cash.TabStop = true;
            this.rb_GoodsReceiptVoucher_Cash.Text = "Cash";
            this.rb_GoodsReceiptVoucher_Cash.UseVisualStyleBackColor = true;
            // 
            // txt_GoodsReceiptVoucher_OtherCharges
            // 
            this.txt_GoodsReceiptVoucher_OtherCharges.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_GoodsReceiptVoucher_OtherCharges.Location = new System.Drawing.Point(690, 436);
            this.txt_GoodsReceiptVoucher_OtherCharges.Name = "txt_GoodsReceiptVoucher_OtherCharges";
            this.txt_GoodsReceiptVoucher_OtherCharges.Size = new System.Drawing.Size(158, 20);
            this.txt_GoodsReceiptVoucher_OtherCharges.TabIndex = 40;
            // 
            // txt_GoodsReceiptVoucher_TotalAmt
            // 
            this.txt_GoodsReceiptVoucher_TotalAmt.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_GoodsReceiptVoucher_TotalAmt.Enabled = false;
            this.txt_GoodsReceiptVoucher_TotalAmt.Location = new System.Drawing.Point(690, 410);
            this.txt_GoodsReceiptVoucher_TotalAmt.Name = "txt_GoodsReceiptVoucher_TotalAmt";
            this.txt_GoodsReceiptVoucher_TotalAmt.Size = new System.Drawing.Size(158, 20);
            this.txt_GoodsReceiptVoucher_TotalAmt.TabIndex = 39;
            // 
            // lbl_GoodsReceiptVoucher_Discount
            // 
            this.lbl_GoodsReceiptVoucher_Discount.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_Discount.Location = new System.Drawing.Point(604, 465);
            this.lbl_GoodsReceiptVoucher_Discount.Name = "lbl_GoodsReceiptVoucher_Discount";
            this.lbl_GoodsReceiptVoucher_Discount.Size = new System.Drawing.Size(49, 13);
            this.lbl_GoodsReceiptVoucher_Discount.TabIndex = 38;
            this.lbl_GoodsReceiptVoucher_Discount.Text = "Discount";
            // 
            // lbl_GoodsReceiptVoucher_OtherCharges
            // 
            this.lbl_GoodsReceiptVoucher_OtherCharges.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_OtherCharges.Location = new System.Drawing.Point(604, 439);
            this.lbl_GoodsReceiptVoucher_OtherCharges.Name = "lbl_GoodsReceiptVoucher_OtherCharges";
            this.lbl_GoodsReceiptVoucher_OtherCharges.Size = new System.Drawing.Size(75, 13);
            this.lbl_GoodsReceiptVoucher_OtherCharges.TabIndex = 37;
            this.lbl_GoodsReceiptVoucher_OtherCharges.Text = "Other Charges";
            // 
            // lbl_GoodsReceiptVoucher_TotalAmt
            // 
            this.lbl_GoodsReceiptVoucher_TotalAmt.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_TotalAmt.Location = new System.Drawing.Point(604, 413);
            this.lbl_GoodsReceiptVoucher_TotalAmt.Name = "lbl_GoodsReceiptVoucher_TotalAmt";
            this.lbl_GoodsReceiptVoucher_TotalAmt.Size = new System.Drawing.Size(70, 13);
            this.lbl_GoodsReceiptVoucher_TotalAmt.TabIndex = 36;
            this.lbl_GoodsReceiptVoucher_TotalAmt.Text = "Total Amount";
            // 
            // txt_GoodsReceiptVoucher_TotalVAT
            // 
            this.txt_GoodsReceiptVoucher_TotalVAT.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_GoodsReceiptVoucher_TotalVAT.Enabled = false;
            this.txt_GoodsReceiptVoucher_TotalVAT.Location = new System.Drawing.Point(426, 436);
            this.txt_GoodsReceiptVoucher_TotalVAT.Name = "txt_GoodsReceiptVoucher_TotalVAT";
            this.txt_GoodsReceiptVoucher_TotalVAT.Size = new System.Drawing.Size(158, 20);
            this.txt_GoodsReceiptVoucher_TotalVAT.TabIndex = 35;
            // 
            // txt_GoodsReceiptVoucher_TotalQty
            // 
            this.txt_GoodsReceiptVoucher_TotalQty.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_GoodsReceiptVoucher_TotalQty.Enabled = false;
            this.txt_GoodsReceiptVoucher_TotalQty.Location = new System.Drawing.Point(426, 410);
            this.txt_GoodsReceiptVoucher_TotalQty.Name = "txt_GoodsReceiptVoucher_TotalQty";
            this.txt_GoodsReceiptVoucher_TotalQty.Size = new System.Drawing.Size(158, 20);
            this.txt_GoodsReceiptVoucher_TotalQty.TabIndex = 34;
            // 
            // lbl_GoodsReceiptVoucher_TotalVAT
            // 
            this.lbl_GoodsReceiptVoucher_TotalVAT.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_TotalVAT.Location = new System.Drawing.Point(320, 439);
            this.lbl_GoodsReceiptVoucher_TotalVAT.Name = "lbl_GoodsReceiptVoucher_TotalVAT";
            this.lbl_GoodsReceiptVoucher_TotalVAT.Size = new System.Drawing.Size(55, 13);
            this.lbl_GoodsReceiptVoucher_TotalVAT.TabIndex = 33;
            this.lbl_GoodsReceiptVoucher_TotalVAT.Text = "Total VAT";
            // 
            // lbl_GoodsReceiptVoucher_TotalQty
            // 
            this.lbl_GoodsReceiptVoucher_TotalQty.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_TotalQty.Location = new System.Drawing.Point(320, 413);
            this.lbl_GoodsReceiptVoucher_TotalQty.Name = "lbl_GoodsReceiptVoucher_TotalQty";
            this.lbl_GoodsReceiptVoucher_TotalQty.Size = new System.Drawing.Size(50, 13);
            this.lbl_GoodsReceiptVoucher_TotalQty.TabIndex = 32;
            this.lbl_GoodsReceiptVoucher_TotalQty.Text = "Total Qty";
            // 
            // btn_GoodsReceiptVoucher_LoadPDT
            // 
            this.btn_GoodsReceiptVoucher_LoadPDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GoodsReceiptVoucher_LoadPDT.Location = new System.Drawing.Point(8, 428);
            this.btn_GoodsReceiptVoucher_LoadPDT.Name = "btn_GoodsReceiptVoucher_LoadPDT";
            this.btn_GoodsReceiptVoucher_LoadPDT.Size = new System.Drawing.Size(75, 50);
            this.btn_GoodsReceiptVoucher_LoadPDT.TabIndex = 31;
            this.btn_GoodsReceiptVoucher_LoadPDT.Text = "Load PDT";
            this.btn_GoodsReceiptVoucher_LoadPDT.UseVisualStyleBackColor = true;
            // 
            // txt_GoodsReceiptVoucher_NetAmt
            // 
            this.txt_GoodsReceiptVoucher_NetAmt.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_GoodsReceiptVoucher_NetAmt.Enabled = false;
            this.txt_GoodsReceiptVoucher_NetAmt.Location = new System.Drawing.Point(426, 463);
            this.txt_GoodsReceiptVoucher_NetAmt.Name = "txt_GoodsReceiptVoucher_NetAmt";
            this.txt_GoodsReceiptVoucher_NetAmt.Size = new System.Drawing.Size(157, 20);
            this.txt_GoodsReceiptVoucher_NetAmt.TabIndex = 30;
            // 
            // lbl_GoodsReceiptVoucher_TotalAmtOC
            // 
            this.lbl_GoodsReceiptVoucher_TotalAmtOC.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_TotalAmtOC.Location = new System.Drawing.Point(320, 469);
            this.lbl_GoodsReceiptVoucher_TotalAmtOC.Name = "lbl_GoodsReceiptVoucher_TotalAmtOC";
            this.lbl_GoodsReceiptVoucher_TotalAmtOC.Size = new System.Drawing.Size(91, 13);
            this.lbl_GoodsReceiptVoucher_TotalAmtOC.TabIndex = 29;
            this.lbl_GoodsReceiptVoucher_TotalAmtOC.Text = "Total Amount O.C";
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_item.Location = new System.Drawing.Point(6, 152);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.Size = new System.Drawing.Size(842, 252);
            this.dgv_item.TabIndex = 28;
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
            // cb_GoodsReceiptVoucher_OneItem
            // 
            this.cb_GoodsReceiptVoucher_OneItem.AutoSize = true;
            this.cb_GoodsReceiptVoucher_OneItem.Location = new System.Drawing.Point(690, 10);
            this.cb_GoodsReceiptVoucher_OneItem.Name = "cb_GoodsReceiptVoucher_OneItem";
            this.cb_GoodsReceiptVoucher_OneItem.Size = new System.Drawing.Size(110, 17);
            this.cb_GoodsReceiptVoucher_OneItem.TabIndex = 27;
            this.cb_GoodsReceiptVoucher_OneItem.Text = "List Only one Item";
            this.cb_GoodsReceiptVoucher_OneItem.UseVisualStyleBackColor = true;
            // 
            // cb_GoodsReceiptVoucher_AllItem
            // 
            this.cb_GoodsReceiptVoucher_AllItem.AutoSize = true;
            this.cb_GoodsReceiptVoucher_AllItem.Location = new System.Drawing.Point(600, 10);
            this.cb_GoodsReceiptVoucher_AllItem.Name = "cb_GoodsReceiptVoucher_AllItem";
            this.cb_GoodsReceiptVoucher_AllItem.Size = new System.Drawing.Size(84, 17);
            this.cb_GoodsReceiptVoucher_AllItem.TabIndex = 26;
            this.cb_GoodsReceiptVoucher_AllItem.Text = "List All Items";
            this.cb_GoodsReceiptVoucher_AllItem.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_GoodsReceiptVoucher_ScanImage);
            this.panel3.Controls.Add(this.btn_GoodsReceiptVoucher_Browse);
            this.panel3.Controls.Add(this.cob_GoodsReceiptVoucher_SelectDevice);
            this.panel3.Controls.Add(this.lbl_GoodsReceiptVoucher_SelectDevice);
            this.panel3.Location = new System.Drawing.Point(854, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 447);
            this.panel3.TabIndex = 24;
            // 
            // btn_GoodsReceiptVoucher_ScanImage
            // 
            this.btn_GoodsReceiptVoucher_ScanImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GoodsReceiptVoucher_ScanImage.Location = new System.Drawing.Point(100, 406);
            this.btn_GoodsReceiptVoucher_ScanImage.Name = "btn_GoodsReceiptVoucher_ScanImage";
            this.btn_GoodsReceiptVoucher_ScanImage.Size = new System.Drawing.Size(92, 29);
            this.btn_GoodsReceiptVoucher_ScanImage.TabIndex = 40;
            this.btn_GoodsReceiptVoucher_ScanImage.Text = "Scan Image";
            this.btn_GoodsReceiptVoucher_ScanImage.UseVisualStyleBackColor = true;
            // 
            // btn_GoodsReceiptVoucher_Browse
            // 
            this.btn_GoodsReceiptVoucher_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GoodsReceiptVoucher_Browse.Location = new System.Drawing.Point(6, 406);
            this.btn_GoodsReceiptVoucher_Browse.Name = "btn_GoodsReceiptVoucher_Browse";
            this.btn_GoodsReceiptVoucher_Browse.Size = new System.Drawing.Size(92, 29);
            this.btn_GoodsReceiptVoucher_Browse.TabIndex = 39;
            this.btn_GoodsReceiptVoucher_Browse.Text = "Browser";
            this.btn_GoodsReceiptVoucher_Browse.UseVisualStyleBackColor = true;
            // 
            // cob_GoodsReceiptVoucher_SelectDevice
            // 
            this.cob_GoodsReceiptVoucher_SelectDevice.FormattingEnabled = true;
            this.cob_GoodsReceiptVoucher_SelectDevice.Location = new System.Drawing.Point(6, 375);
            this.cob_GoodsReceiptVoucher_SelectDevice.Name = "cob_GoodsReceiptVoucher_SelectDevice";
            this.cob_GoodsReceiptVoucher_SelectDevice.Size = new System.Drawing.Size(186, 21);
            this.cob_GoodsReceiptVoucher_SelectDevice.TabIndex = 38;
            // 
            // lbl_GoodsReceiptVoucher_SelectDevice
            // 
            this.lbl_GoodsReceiptVoucher_SelectDevice.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_SelectDevice.Location = new System.Drawing.Point(3, 357);
            this.lbl_GoodsReceiptVoucher_SelectDevice.Name = "lbl_GoodsReceiptVoucher_SelectDevice";
            this.lbl_GoodsReceiptVoucher_SelectDevice.Size = new System.Drawing.Size(74, 13);
            this.lbl_GoodsReceiptVoucher_SelectDevice.TabIndex = 37;
            this.lbl_GoodsReceiptVoucher_SelectDevice.Text = "Select Device";
            // 
            // txt_GoodsReceiptVoucher_LPO
            // 
            this.txt_GoodsReceiptVoucher_LPO.Enabled = false;
            this.txt_GoodsReceiptVoucher_LPO.Location = new System.Drawing.Point(636, 54);
            this.txt_GoodsReceiptVoucher_LPO.Name = "txt_GoodsReceiptVoucher_LPO";
            this.txt_GoodsReceiptVoucher_LPO.Size = new System.Drawing.Size(112, 20);
            this.txt_GoodsReceiptVoucher_LPO.TabIndex = 21;
            // 
            // lbl_GoodsReceiptVoucher_LPO
            // 
            this.lbl_GoodsReceiptVoucher_LPO.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_LPO.Location = new System.Drawing.Point(549, 57);
            this.lbl_GoodsReceiptVoucher_LPO.Name = "lbl_GoodsReceiptVoucher_LPO";
            this.lbl_GoodsReceiptVoucher_LPO.Size = new System.Drawing.Size(34, 13);
            this.lbl_GoodsReceiptVoucher_LPO.TabIndex = 20;
            this.lbl_GoodsReceiptVoucher_LPO.Text = "L P O";
            // 
            // cob_CostCenter
            // 
            this.cob_CostCenter.FormattingEnabled = true;
            this.cob_CostCenter.Location = new System.Drawing.Point(636, 80);
            this.cob_CostCenter.Name = "cob_CostCenter";
            this.cob_CostCenter.Size = new System.Drawing.Size(110, 21);
            this.cob_CostCenter.TabIndex = 19;
            // 
            // txtSuppid
            // 
            this.txtSuppid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSuppid.Enabled = false;
            this.txtSuppid.Location = new System.Drawing.Point(636, 31);
            this.txtSuppid.Name = "txtSuppid";
            this.txtSuppid.Size = new System.Drawing.Size(112, 20);
            this.txtSuppid.TabIndex = 17;
            // 
            // lbl_GoodsReceiptVoucher_CostCenter
            // 
            this.lbl_GoodsReceiptVoucher_CostCenter.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_CostCenter.Location = new System.Drawing.Point(549, 84);
            this.lbl_GoodsReceiptVoucher_CostCenter.Name = "lbl_GoodsReceiptVoucher_CostCenter";
            this.lbl_GoodsReceiptVoucher_CostCenter.Size = new System.Drawing.Size(62, 13);
            this.lbl_GoodsReceiptVoucher_CostCenter.TabIndex = 16;
            this.lbl_GoodsReceiptVoucher_CostCenter.Text = "Cost Center";
            // 
            // lbl_GoodsReceiptVoucher_PaymentMode
            // 
            this.lbl_GoodsReceiptVoucher_PaymentMode.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_PaymentMode.Location = new System.Drawing.Point(549, 109);
            this.lbl_GoodsReceiptVoucher_PaymentMode.Name = "lbl_GoodsReceiptVoucher_PaymentMode";
            this.lbl_GoodsReceiptVoucher_PaymentMode.Size = new System.Drawing.Size(78, 13);
            this.lbl_GoodsReceiptVoucher_PaymentMode.TabIndex = 15;
            this.lbl_GoodsReceiptVoucher_PaymentMode.Text = "Payment Mode";
            // 
            // lbl_GoodsReceiptVoucher_SupplierID
            // 
            this.lbl_GoodsReceiptVoucher_SupplierID.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_SupplierID.Location = new System.Drawing.Point(549, 34);
            this.lbl_GoodsReceiptVoucher_SupplierID.Name = "lbl_GoodsReceiptVoucher_SupplierID";
            this.lbl_GoodsReceiptVoucher_SupplierID.Size = new System.Drawing.Size(59, 13);
            this.lbl_GoodsReceiptVoucher_SupplierID.TabIndex = 14;
            this.lbl_GoodsReceiptVoucher_SupplierID.Text = "Supplier ID";
            // 
            // txt_GoodsReceiptVoucher_CurRate
            // 
            this.txt_GoodsReceiptVoucher_CurRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_GoodsReceiptVoucher_CurRate.Enabled = false;
            this.txt_GoodsReceiptVoucher_CurRate.Location = new System.Drawing.Point(304, 117);
            this.txt_GoodsReceiptVoucher_CurRate.Name = "txt_GoodsReceiptVoucher_CurRate";
            this.txt_GoodsReceiptVoucher_CurRate.Size = new System.Drawing.Size(106, 20);
            this.txt_GoodsReceiptVoucher_CurRate.TabIndex = 13;
            // 
            // lbl_GoodsReceiptVoucher_CurRate
            // 
            this.lbl_GoodsReceiptVoucher_CurRate.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_CurRate.Location = new System.Drawing.Point(246, 120);
            this.lbl_GoodsReceiptVoucher_CurRate.Name = "lbl_GoodsReceiptVoucher_CurRate";
            this.lbl_GoodsReceiptVoucher_CurRate.Size = new System.Drawing.Size(49, 13);
            this.lbl_GoodsReceiptVoucher_CurRate.TabIndex = 12;
            this.lbl_GoodsReceiptVoucher_CurRate.Text = "Cur.Rate";
            // 
            // cob_GoodsReceiptVoucher_Currency
            // 
            this.cob_GoodsReceiptVoucher_Currency.FormattingEnabled = true;
            this.cob_GoodsReceiptVoucher_Currency.Location = new System.Drawing.Point(93, 117);
            this.cob_GoodsReceiptVoucher_Currency.Name = "cob_GoodsReceiptVoucher_Currency";
            this.cob_GoodsReceiptVoucher_Currency.Size = new System.Drawing.Size(147, 21);
            this.cob_GoodsReceiptVoucher_Currency.TabIndex = 11;
            this.cob_GoodsReceiptVoucher_Currency.SelectedIndexChanged += new System.EventHandler(this.cob_GoodsReceiptVoucher_Currency_SelectedIndexChanged);
            // 
            // lbl_GoodsReceiptVoucher_Currency
            // 
            this.lbl_GoodsReceiptVoucher_Currency.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_Currency.Location = new System.Drawing.Point(3, 120);
            this.lbl_GoodsReceiptVoucher_Currency.Name = "lbl_GoodsReceiptVoucher_Currency";
            this.lbl_GoodsReceiptVoucher_Currency.Size = new System.Drawing.Size(49, 13);
            this.lbl_GoodsReceiptVoucher_Currency.TabIndex = 10;
            this.lbl_GoodsReceiptVoucher_Currency.Text = "Currency";
            // 
            // txt_GoodsReceiptVoucher_Desc
            // 
            this.txt_GoodsReceiptVoucher_Desc.Location = new System.Drawing.Point(93, 90);
            this.txt_GoodsReceiptVoucher_Desc.Name = "txt_GoodsReceiptVoucher_Desc";
            this.txt_GoodsReceiptVoucher_Desc.Size = new System.Drawing.Size(317, 20);
            this.txt_GoodsReceiptVoucher_Desc.TabIndex = 9;
            // 
            // lbl_GoodsReceiptVoucher_Desc
            // 
            this.lbl_GoodsReceiptVoucher_Desc.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_Desc.Location = new System.Drawing.Point(3, 93);
            this.lbl_GoodsReceiptVoucher_Desc.Name = "lbl_GoodsReceiptVoucher_Desc";
            this.lbl_GoodsReceiptVoucher_Desc.Size = new System.Drawing.Size(32, 13);
            this.lbl_GoodsReceiptVoucher_Desc.TabIndex = 8;
            this.lbl_GoodsReceiptVoucher_Desc.Text = "Desc";
            // 
            // txt_GoodsReceiptVoucher_SupplierRef
            // 
            this.txt_GoodsReceiptVoucher_SupplierRef.Location = new System.Drawing.Point(93, 62);
            this.txt_GoodsReceiptVoucher_SupplierRef.Name = "txt_GoodsReceiptVoucher_SupplierRef";
            this.txt_GoodsReceiptVoucher_SupplierRef.Size = new System.Drawing.Size(317, 20);
            this.txt_GoodsReceiptVoucher_SupplierRef.TabIndex = 7;
            // 
            // lbl_GoodsReceiptVoucher_SupplierRef
            // 
            this.lbl_GoodsReceiptVoucher_SupplierRef.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_SupplierRef.Location = new System.Drawing.Point(3, 65);
            this.lbl_GoodsReceiptVoucher_SupplierRef.Name = "lbl_GoodsReceiptVoucher_SupplierRef";
            this.lbl_GoodsReceiptVoucher_SupplierRef.Size = new System.Drawing.Size(65, 13);
            this.lbl_GoodsReceiptVoucher_SupplierRef.TabIndex = 6;
            this.lbl_GoodsReceiptVoucher_SupplierRef.Text = "Supplier Ref";
            // 
            // lbl_GoodsReceiptVoucher_SupplierName
            // 
            this.lbl_GoodsReceiptVoucher_SupplierName.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_SupplierName.Location = new System.Drawing.Point(3, 38);
            this.lbl_GoodsReceiptVoucher_SupplierName.Name = "lbl_GoodsReceiptVoucher_SupplierName";
            this.lbl_GoodsReceiptVoucher_SupplierName.Size = new System.Drawing.Size(76, 13);
            this.lbl_GoodsReceiptVoucher_SupplierName.TabIndex = 4;
            this.lbl_GoodsReceiptVoucher_SupplierName.Text = "Supplier Name";
            // 
            // dt_GoodsReceiptVoucher_GRVDate
            // 
            this.dt_GoodsReceiptVoucher_GRVDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_GoodsReceiptVoucher_GRVDate.Location = new System.Drawing.Point(308, 8);
            this.dt_GoodsReceiptVoucher_GRVDate.Name = "dt_GoodsReceiptVoucher_GRVDate";
            this.dt_GoodsReceiptVoucher_GRVDate.Size = new System.Drawing.Size(102, 20);
            this.dt_GoodsReceiptVoucher_GRVDate.TabIndex = 3;
            // 
            // lbl_GoodsReceiptVoucher_GRVDate
            // 
            this.lbl_GoodsReceiptVoucher_GRVDate.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_GRVDate.Location = new System.Drawing.Point(240, 11);
            this.lbl_GoodsReceiptVoucher_GRVDate.Name = "lbl_GoodsReceiptVoucher_GRVDate";
            this.lbl_GoodsReceiptVoucher_GRVDate.Size = new System.Drawing.Size(62, 13);
            this.lbl_GoodsReceiptVoucher_GRVDate.TabIndex = 2;
            this.lbl_GoodsReceiptVoucher_GRVDate.Text = "G R V Date";
            // 
            // txt_GoodsReceiptVoucher_InvoiceID
            // 
            this.txt_GoodsReceiptVoucher_InvoiceID.Enabled = false;
            this.txt_GoodsReceiptVoucher_InvoiceID.Location = new System.Drawing.Point(94, 7);
            this.txt_GoodsReceiptVoucher_InvoiceID.Name = "txt_GoodsReceiptVoucher_InvoiceID";
            this.txt_GoodsReceiptVoucher_InvoiceID.Size = new System.Drawing.Size(140, 20);
            this.txt_GoodsReceiptVoucher_InvoiceID.TabIndex = 1;
            // 
            // lbl_GoodsReceiptVoucher_InvoiceID
            // 
            this.lbl_GoodsReceiptVoucher_InvoiceID.AutoSize = true;
            this.lbl_GoodsReceiptVoucher_InvoiceID.Location = new System.Drawing.Point(3, 11);
            this.lbl_GoodsReceiptVoucher_InvoiceID.Name = "lbl_GoodsReceiptVoucher_InvoiceID";
            this.lbl_GoodsReceiptVoucher_InvoiceID.Size = new System.Drawing.Size(56, 13);
            this.lbl_GoodsReceiptVoucher_InvoiceID.TabIndex = 0;
            this.lbl_GoodsReceiptVoucher_InvoiceID.Text = "Invoice ID";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ucFirstPreNextLast1);
            this.panel4.Controls.Add(this.ucTransactionLPO);
            this.panel4.Location = new System.Drawing.Point(12, 507);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1062, 49);
            this.panel4.TabIndex = 42;
            // 
            // ucFirstPreNextLast1
            // 
            this.ucFirstPreNextLast1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucFirstPreNextLast1.Location = new System.Drawing.Point(784, 7);
            this.ucFirstPreNextLast1.Name = "ucFirstPreNextLast1";
            this.ucFirstPreNextLast1.Size = new System.Drawing.Size(267, 31);
            this.ucFirstPreNextLast1.TabIndex = 5;
            // 
            // ucTransactionLPO
            // 
            this.ucTransactionLPO.Location = new System.Drawing.Point(8, 5);
            this.ucTransactionLPO.Name = "ucTransactionLPO";
            this.ucTransactionLPO.Size = new System.Drawing.Size(526, 36);
            this.ucTransactionLPO.TabIndex = 4;
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgv_list);
            this.pnlItem.Location = new System.Drawing.Point(176, 168);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(894, 328);
            this.pnlItem.TabIndex = 45;
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
            this.dgv_list.Size = new System.Drawing.Size(894, 328);
            this.dgv_list.TabIndex = 39;
            // 
            // frm_Transactions_GoodsReceiptsVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 558);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Transactions_GoodsReceiptsVoucher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions Goods ReceiptsVoucher";
            this.Load += new System.EventHandler(this.frm_Transactions_GoodsReceiptsVoucher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_Discount;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_OtherCharges;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_TotalAmt;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_Discount;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_OtherCharges;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_TotalAmt;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_TotalVAT;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_TotalQty;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_TotalVAT;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_TotalQty;
        private System.Windows.Forms.Button btn_GoodsReceiptVoucher_LoadPDT;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_NetAmt;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_TotalAmtOC;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.CheckBox cb_GoodsReceiptVoucher_OneItem;
        private System.Windows.Forms.CheckBox cb_GoodsReceiptVoucher_AllItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_GoodsReceiptVoucher_ScanImage;
        private System.Windows.Forms.Button btn_GoodsReceiptVoucher_Browse;
        private System.Windows.Forms.ComboBox cob_GoodsReceiptVoucher_SelectDevice;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_SelectDevice;
        private System.Windows.Forms.RadioButton rb_GoodsReceiptVoucher_Credit;
        private System.Windows.Forms.RadioButton rb_GoodsReceiptVoucher_Cash;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_LPO;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_LPO;
        private System.Windows.Forms.ComboBox cob_CostCenter;
        private System.Windows.Forms.TextBox txtSuppid;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_CostCenter;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_PaymentMode;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_SupplierID;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_CurRate;
        private System.Windows.Forms.ComboBox cob_GoodsReceiptVoucher_Currency;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_Currency;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_Desc;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_Desc;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_SupplierRef;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_SupplierRef;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_SupplierName;
        private System.Windows.Forms.DateTimePicker dt_GoodsReceiptVoucher_GRVDate;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_GRVDate;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_InvoiceID;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_InvoiceID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_GoodsReceiptVoucher_ReplicateItem;
        private UControl.ucComboBox txt_GoodsReceiptVoucher_SupplierName;
        private UControl.ucFirstPreNextLast ucFirstPreNextLast1;
        private UControl.ucTransaction ucTransactionLPO;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Add;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Delete;
        private System.Windows.Forms.TextBox txt_GoodsReceiptVoucher_CurRate;
        private System.Windows.Forms.Panel pnlItem;
        public System.Windows.Forms.DataGridView dgv_list;
    }
}