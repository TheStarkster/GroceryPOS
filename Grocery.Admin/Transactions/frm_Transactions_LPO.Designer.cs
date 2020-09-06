namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_LPO
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
            this.GBox_LPODetail = new System.Windows.Forms.GroupBox();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.txtTotalVAT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiscAmount = new System.Windows.Forms.TextBox();
            this.txtNETQTY = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblNetQTY = new System.Windows.Forms.Label();
            this.txttotalAmount = new System.Windows.Forms.TextBox();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOtherCharges = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lblSelectDevice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SubMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_CostCenter = new System.Windows.Forms.Label();
            this.cbox_CostCenter = new System.Windows.Forms.ComboBox();
            this.gbox_LPO4 = new System.Windows.Forms.GroupBox();
            this.rb_LPO4Branches = new System.Windows.Forms.RadioButton();
            this.rb_LPO4Supplier = new System.Windows.Forms.RadioButton();
            this.gbox_PaymentMode = new System.Windows.Forms.GroupBox();
            this.rb_PaymentMode_Credit = new System.Windows.Forms.RadioButton();
            this.rb_PaymentMode_Cash = new System.Windows.Forms.RadioButton();
            this.cb_ListOnlyOneItems = new System.Windows.Forms.CheckBox();
            this.cb_ListAllitems = new System.Windows.Forms.CheckBox();
            this.cb_VatApplicable = new System.Windows.Forms.CheckBox();
            this.txtpriceterms = new System.Windows.Forms.TextBox();
            this.txtdelterms = new System.Windows.Forms.TextBox();
            this.txtSupplierTRN = new System.Windows.Forms.TextBox();
            this.txtpaymentterms = new System.Windows.Forms.TextBox();
            this.dtpdeldate = new System.Windows.Forms.DateTimePicker();
            this.lbl_PriceTerms = new System.Windows.Forms.Label();
            this.lblDelTerms = new System.Windows.Forms.Label();
            this.lblSuppTRN = new System.Windows.Forms.Label();
            this.lbl_SupplierID = new System.Windows.Forms.Label();
            this.lblPaymentTerms = new System.Windows.Forms.Label();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.dtp_DateOfInvoice = new System.Windows.Forms.DateTimePicker();
            this.txt_CurrencyRate = new System.Windows.Forms.TextBox();
            this.cbox_Currency = new System.Windows.Forms.ComboBox();
            this.lbl_CurrencyRate = new System.Windows.Forms.Label();
            this.lbl_InvoiceDate = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.txt_SupplierRef = new System.Windows.Forms.TextBox();
            this.txtSuppid = new System.Windows.Forms.TextBox();
            this.txt_InvoiceID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Supplier_Ref = new System.Windows.Forms.Label();
            this.lbl_SupplierName = new System.Windows.Forms.Label();
            this.lbl_Currency = new System.Windows.Forms.Label();
            this.lbl_InvoiceID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucFirstPreNextLast1 = new Grocery.Admin.UControl.ucFirstPreNextLast();
            this.ucTransactionLPO = new Grocery.Admin.UControl.ucTransaction();
            this.txt_SupplierName = new Grocery.Admin.UControl.ucComboBox();
            this.GBox_LPODetail.SuspendLayout();
            this.pnlItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbox_LPO4.SuspendLayout();
            this.gbox_PaymentMode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox_LPODetail
            // 
            this.GBox_LPODetail.Controls.Add(this.pnlItem);
            this.GBox_LPODetail.Controls.Add(this.txtTotalVAT);
            this.GBox_LPODetail.Controls.Add(this.label3);
            this.GBox_LPODetail.Controls.Add(this.txtdiscAmount);
            this.GBox_LPODetail.Controls.Add(this.txtNETQTY);
            this.GBox_LPODetail.Controls.Add(this.textBox7);
            this.GBox_LPODetail.Controls.Add(this.lblNetQTY);
            this.GBox_LPODetail.Controls.Add(this.txttotalAmount);
            this.GBox_LPODetail.Controls.Add(this.txtNetAmount);
            this.GBox_LPODetail.Controls.Add(this.label1);
            this.GBox_LPODetail.Controls.Add(this.lblOtherCharges);
            this.GBox_LPODetail.Controls.Add(this.lblNetAmount);
            this.GBox_LPODetail.Controls.Add(this.lblPurchase);
            this.GBox_LPODetail.Controls.Add(this.txt_SupplierName);
            this.GBox_LPODetail.Controls.Add(this.panel2);
            this.GBox_LPODetail.Controls.Add(this.dgv_item);
            this.GBox_LPODetail.Controls.Add(this.lbl_CostCenter);
            this.GBox_LPODetail.Controls.Add(this.cbox_CostCenter);
            this.GBox_LPODetail.Controls.Add(this.gbox_LPO4);
            this.GBox_LPODetail.Controls.Add(this.gbox_PaymentMode);
            this.GBox_LPODetail.Controls.Add(this.cb_ListOnlyOneItems);
            this.GBox_LPODetail.Controls.Add(this.cb_ListAllitems);
            this.GBox_LPODetail.Controls.Add(this.cb_VatApplicable);
            this.GBox_LPODetail.Controls.Add(this.txtpriceterms);
            this.GBox_LPODetail.Controls.Add(this.txtdelterms);
            this.GBox_LPODetail.Controls.Add(this.txtSupplierTRN);
            this.GBox_LPODetail.Controls.Add(this.txtpaymentterms);
            this.GBox_LPODetail.Controls.Add(this.dtpdeldate);
            this.GBox_LPODetail.Controls.Add(this.lbl_PriceTerms);
            this.GBox_LPODetail.Controls.Add(this.lblDelTerms);
            this.GBox_LPODetail.Controls.Add(this.lblSuppTRN);
            this.GBox_LPODetail.Controls.Add(this.lbl_SupplierID);
            this.GBox_LPODetail.Controls.Add(this.lblPaymentTerms);
            this.GBox_LPODetail.Controls.Add(this.lbl_DueDate);
            this.GBox_LPODetail.Controls.Add(this.dtp_DateOfInvoice);
            this.GBox_LPODetail.Controls.Add(this.txt_CurrencyRate);
            this.GBox_LPODetail.Controls.Add(this.cbox_Currency);
            this.GBox_LPODetail.Controls.Add(this.lbl_CurrencyRate);
            this.GBox_LPODetail.Controls.Add(this.lbl_InvoiceDate);
            this.GBox_LPODetail.Controls.Add(this.txt_Desc);
            this.GBox_LPODetail.Controls.Add(this.txt_SupplierRef);
            this.GBox_LPODetail.Controls.Add(this.txtSuppid);
            this.GBox_LPODetail.Controls.Add(this.txt_InvoiceID);
            this.GBox_LPODetail.Controls.Add(this.label5);
            this.GBox_LPODetail.Controls.Add(this.lbl_Supplier_Ref);
            this.GBox_LPODetail.Controls.Add(this.lbl_SupplierName);
            this.GBox_LPODetail.Controls.Add(this.lbl_Currency);
            this.GBox_LPODetail.Controls.Add(this.lbl_InvoiceID);
            this.GBox_LPODetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBox_LPODetail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GBox_LPODetail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_LPODetail.Location = new System.Drawing.Point(0, 0);
            this.GBox_LPODetail.Name = "GBox_LPODetail";
            this.GBox_LPODetail.Size = new System.Drawing.Size(1534, 535);
            this.GBox_LPODetail.TabIndex = 1;
            this.GBox_LPODetail.TabStop = false;
            this.GBox_LPODetail.Text = "LPO Details";
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgv_list);
            this.pnlItem.Location = new System.Drawing.Point(458, 151);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(1067, 348);
            this.pnlItem.TabIndex = 42;
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
            this.dgv_list.Size = new System.Drawing.Size(1067, 348);
            this.dgv_list.TabIndex = 39;
            this.dgv_list.DoubleClick += new System.EventHandler(this.dgv_list_DoubleClick);
            this.dgv_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_list_KeyDown);
            // 
            // txtTotalVAT
            // 
            this.txtTotalVAT.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTotalVAT.Location = new System.Drawing.Point(909, 507);
            this.txtTotalVAT.Name = "txtTotalVAT";
            this.txtTotalVAT.ReadOnly = true;
            this.txtTotalVAT.Size = new System.Drawing.Size(130, 22);
            this.txtTotalVAT.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(847, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total VAT";
            // 
            // txtdiscAmount
            // 
            this.txtdiscAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdiscAmount.Location = new System.Drawing.Point(508, 507);
            this.txtdiscAmount.Name = "txtdiscAmount";
            this.txtdiscAmount.ReadOnly = true;
            this.txtdiscAmount.Size = new System.Drawing.Size(130, 22);
            this.txtdiscAmount.TabIndex = 39;
            // 
            // txtNETQTY
            // 
            this.txtNETQTY.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNETQTY.Location = new System.Drawing.Point(712, 507);
            this.txtNETQTY.Name = "txtNETQTY";
            this.txtNETQTY.ReadOnly = true;
            this.txtNETQTY.Size = new System.Drawing.Size(130, 22);
            this.txtNETQTY.TabIndex = 41;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox7.Location = new System.Drawing.Point(303, 507);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(130, 22);
            this.textBox7.TabIndex = 16;
            // 
            // lblNetQTY
            // 
            this.lblNetQTY.AutoSize = true;
            this.lblNetQTY.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetQTY.Location = new System.Drawing.Point(644, 511);
            this.lblNetQTY.Name = "lblNetQTY";
            this.lblNetQTY.Size = new System.Drawing.Size(62, 15);
            this.lblNetQTY.TabIndex = 40;
            this.lblNetQTY.Text = "Net QTY :";
            // 
            // txttotalAmount
            // 
            this.txttotalAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txttotalAmount.Location = new System.Drawing.Point(69, 507);
            this.txttotalAmount.Name = "txttotalAmount";
            this.txttotalAmount.ReadOnly = true;
            this.txttotalAmount.Size = new System.Drawing.Size(130, 22);
            this.txttotalAmount.TabIndex = 15;
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNetAmount.Location = new System.Drawing.Point(1158, 507);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(130, 22);
            this.txtNetAmount.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Discount :";
            // 
            // lblOtherCharges
            // 
            this.lblOtherCharges.AutoSize = true;
            this.lblOtherCharges.Location = new System.Drawing.Point(208, 511);
            this.lblOtherCharges.Name = "lblOtherCharges";
            this.lblOtherCharges.Size = new System.Drawing.Size(90, 15);
            this.lblOtherCharges.TabIndex = 37;
            this.lblOtherCharges.Text = "Other Charges :";
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.Location = new System.Drawing.Point(1048, 511);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(78, 15);
            this.lblNetAmount.TabIndex = 44;
            this.lblNetAmount.Text = "Net Amount :";
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Location = new System.Drawing.Point(6, 511);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(62, 15);
            this.lblPurchase.TabIndex = 36;
            this.lblPurchase.Text = "Purchase :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnScan);
            this.panel2.Controls.Add(this.btnBrowser);
            this.panel2.Controls.Add(this.lblSelectDevice);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1299, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 514);
            this.panel2.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scan Document should show here";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(6, 446);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(107, 27);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(119, 446);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(107, 27);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // lblSelectDevice
            // 
            this.lblSelectDevice.AutoSize = true;
            this.lblSelectDevice.Location = new System.Drawing.Point(3, 392);
            this.lblSelectDevice.Name = "lblSelectDevice";
            this.lblSelectDevice.Size = new System.Drawing.Size(85, 15);
            this.lblSelectDevice.TabIndex = 3;
            this.lblSelectDevice.Text = "Select Device :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 417);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_item.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_item.Location = new System.Drawing.Point(3, 151);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv_item.Size = new System.Drawing.Size(1285, 348);
            this.dgv_item.TabIndex = 10;
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
            // lbl_CostCenter
            // 
            this.lbl_CostCenter.AutoSize = true;
            this.lbl_CostCenter.Location = new System.Drawing.Point(735, 26);
            this.lbl_CostCenter.Name = "lbl_CostCenter";
            this.lbl_CostCenter.Size = new System.Drawing.Size(76, 15);
            this.lbl_CostCenter.TabIndex = 29;
            this.lbl_CostCenter.Text = "Cost Center :";
            // 
            // cbox_CostCenter
            // 
            this.cbox_CostCenter.FormattingEnabled = true;
            this.cbox_CostCenter.Location = new System.Drawing.Point(811, 22);
            this.cbox_CostCenter.Name = "cbox_CostCenter";
            this.cbox_CostCenter.Size = new System.Drawing.Size(101, 23);
            this.cbox_CostCenter.TabIndex = 2;
            // 
            // gbox_LPO4
            // 
            this.gbox_LPO4.Controls.Add(this.rb_LPO4Branches);
            this.gbox_LPO4.Controls.Add(this.rb_LPO4Supplier);
            this.gbox_LPO4.Location = new System.Drawing.Point(1107, 50);
            this.gbox_LPO4.Name = "gbox_LPO4";
            this.gbox_LPO4.Size = new System.Drawing.Size(177, 66);
            this.gbox_LPO4.TabIndex = 34;
            this.gbox_LPO4.TabStop = false;
            this.gbox_LPO4.Text = "LPO for?";
            // 
            // rb_LPO4Branches
            // 
            this.rb_LPO4Branches.AutoSize = true;
            this.rb_LPO4Branches.Location = new System.Drawing.Point(13, 40);
            this.rb_LPO4Branches.Name = "rb_LPO4Branches";
            this.rb_LPO4Branches.Size = new System.Drawing.Size(75, 19);
            this.rb_LPO4Branches.TabIndex = 1;
            this.rb_LPO4Branches.TabStop = true;
            this.rb_LPO4Branches.Text = "Branches";
            this.rb_LPO4Branches.UseVisualStyleBackColor = true;
            // 
            // rb_LPO4Supplier
            // 
            this.rb_LPO4Supplier.AutoSize = true;
            this.rb_LPO4Supplier.Checked = true;
            this.rb_LPO4Supplier.Location = new System.Drawing.Point(13, 17);
            this.rb_LPO4Supplier.Name = "rb_LPO4Supplier";
            this.rb_LPO4Supplier.Size = new System.Drawing.Size(69, 19);
            this.rb_LPO4Supplier.TabIndex = 0;
            this.rb_LPO4Supplier.TabStop = true;
            this.rb_LPO4Supplier.Text = "Supplier";
            this.rb_LPO4Supplier.UseVisualStyleBackColor = true;
            // 
            // gbox_PaymentMode
            // 
            this.gbox_PaymentMode.Controls.Add(this.rb_PaymentMode_Credit);
            this.gbox_PaymentMode.Controls.Add(this.rb_PaymentMode_Cash);
            this.gbox_PaymentMode.Location = new System.Drawing.Point(923, 64);
            this.gbox_PaymentMode.Name = "gbox_PaymentMode";
            this.gbox_PaymentMode.Size = new System.Drawing.Size(177, 52);
            this.gbox_PaymentMode.TabIndex = 35;
            this.gbox_PaymentMode.TabStop = false;
            this.gbox_PaymentMode.Text = "Payment Mode";
            // 
            // rb_PaymentMode_Credit
            // 
            this.rb_PaymentMode_Credit.AutoSize = true;
            this.rb_PaymentMode_Credit.Location = new System.Drawing.Point(96, 21);
            this.rb_PaymentMode_Credit.Name = "rb_PaymentMode_Credit";
            this.rb_PaymentMode_Credit.Size = new System.Drawing.Size(57, 19);
            this.rb_PaymentMode_Credit.TabIndex = 1;
            this.rb_PaymentMode_Credit.TabStop = true;
            this.rb_PaymentMode_Credit.Text = "Credit";
            this.rb_PaymentMode_Credit.UseVisualStyleBackColor = true;
            // 
            // rb_PaymentMode_Cash
            // 
            this.rb_PaymentMode_Cash.AutoSize = true;
            this.rb_PaymentMode_Cash.Checked = true;
            this.rb_PaymentMode_Cash.Location = new System.Drawing.Point(13, 21);
            this.rb_PaymentMode_Cash.Name = "rb_PaymentMode_Cash";
            this.rb_PaymentMode_Cash.Size = new System.Drawing.Size(52, 19);
            this.rb_PaymentMode_Cash.TabIndex = 0;
            this.rb_PaymentMode_Cash.TabStop = true;
            this.rb_PaymentMode_Cash.Text = "Cash";
            this.rb_PaymentMode_Cash.UseVisualStyleBackColor = true;
            // 
            // cb_ListOnlyOneItems
            // 
            this.cb_ListOnlyOneItems.AutoSize = true;
            this.cb_ListOnlyOneItems.Location = new System.Drawing.Point(1167, 25);
            this.cb_ListOnlyOneItems.Name = "cb_ListOnlyOneItems";
            this.cb_ListOnlyOneItems.Size = new System.Drawing.Size(121, 19);
            this.cb_ListOnlyOneItems.TabIndex = 33;
            this.cb_ListOnlyOneItems.Text = "List only one item";
            this.cb_ListOnlyOneItems.UseVisualStyleBackColor = true;
            // 
            // cb_ListAllitems
            // 
            this.cb_ListAllitems.AutoSize = true;
            this.cb_ListAllitems.Checked = true;
            this.cb_ListAllitems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ListAllitems.Location = new System.Drawing.Point(1055, 25);
            this.cb_ListAllitems.Name = "cb_ListAllitems";
            this.cb_ListAllitems.Size = new System.Drawing.Size(96, 19);
            this.cb_ListAllitems.TabIndex = 32;
            this.cb_ListAllitems.Text = "List All Items";
            this.cb_ListAllitems.UseVisualStyleBackColor = true;
            // 
            // cb_VatApplicable
            // 
            this.cb_VatApplicable.AutoSize = true;
            this.cb_VatApplicable.Location = new System.Drawing.Point(923, 26);
            this.cb_VatApplicable.Name = "cb_VatApplicable";
            this.cb_VatApplicable.Size = new System.Drawing.Size(126, 19);
            this.cb_VatApplicable.TabIndex = 31;
            this.cb_VatApplicable.Text = "VAT APPLICABLE";
            this.cb_VatApplicable.UseVisualStyleBackColor = true;
            // 
            // txtpriceterms
            // 
            this.txtpriceterms.Location = new System.Drawing.Point(815, 123);
            this.txtpriceterms.Name = "txtpriceterms";
            this.txtpriceterms.Size = new System.Drawing.Size(101, 22);
            this.txtpriceterms.TabIndex = 9;
            // 
            // txtdelterms
            // 
            this.txtdelterms.Location = new System.Drawing.Point(599, 123);
            this.txtdelterms.Name = "txtdelterms";
            this.txtdelterms.Size = new System.Drawing.Size(99, 22);
            this.txtdelterms.TabIndex = 8;
            // 
            // txtSupplierTRN
            // 
            this.txtSupplierTRN.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSupplierTRN.Location = new System.Drawing.Point(599, 98);
            this.txtSupplierTRN.Name = "txtSupplierTRN";
            this.txtSupplierTRN.ReadOnly = true;
            this.txtSupplierTRN.Size = new System.Drawing.Size(316, 22);
            this.txtSupplierTRN.TabIndex = 14;
            // 
            // txtpaymentterms
            // 
            this.txtpaymentterms.Location = new System.Drawing.Point(599, 48);
            this.txtpaymentterms.Name = "txtpaymentterms";
            this.txtpaymentterms.Size = new System.Drawing.Size(316, 22);
            this.txtpaymentterms.TabIndex = 4;
            // 
            // dtpdeldate
            // 
            this.dtpdeldate.CustomFormat = "";
            this.dtpdeldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdeldate.Location = new System.Drawing.Point(599, 23);
            this.dtpdeldate.Name = "dtpdeldate";
            this.dtpdeldate.Size = new System.Drawing.Size(106, 22);
            this.dtpdeldate.TabIndex = 1;
            // 
            // lbl_PriceTerms
            // 
            this.lbl_PriceTerms.AutoSize = true;
            this.lbl_PriceTerms.Location = new System.Drawing.Point(735, 125);
            this.lbl_PriceTerms.Name = "lbl_PriceTerms";
            this.lbl_PriceTerms.Size = new System.Drawing.Size(74, 15);
            this.lbl_PriceTerms.TabIndex = 30;
            this.lbl_PriceTerms.Text = "Price Terms :";
            // 
            // lblDelTerms
            // 
            this.lblDelTerms.AutoSize = true;
            this.lblDelTerms.Location = new System.Drawing.Point(497, 125);
            this.lblDelTerms.Name = "lblDelTerms";
            this.lblDelTerms.Size = new System.Drawing.Size(69, 15);
            this.lblDelTerms.TabIndex = 28;
            this.lblDelTerms.Text = "Del. Terms :";
            // 
            // lblSuppTRN
            // 
            this.lblSuppTRN.AutoSize = true;
            this.lblSuppTRN.Location = new System.Drawing.Point(497, 102);
            this.lblSuppTRN.Name = "lblSuppTRN";
            this.lblSuppTRN.Size = new System.Drawing.Size(85, 15);
            this.lblSuppTRN.TabIndex = 27;
            this.lblSuppTRN.Text = "Supplier TRN :";
            // 
            // lbl_SupplierID
            // 
            this.lbl_SupplierID.AutoSize = true;
            this.lbl_SupplierID.Location = new System.Drawing.Point(497, 74);
            this.lbl_SupplierID.Name = "lbl_SupplierID";
            this.lbl_SupplierID.Size = new System.Drawing.Size(73, 15);
            this.lbl_SupplierID.TabIndex = 26;
            this.lbl_SupplierID.Text = "Supplier ID :";
            // 
            // lblPaymentTerms
            // 
            this.lblPaymentTerms.AutoSize = true;
            this.lblPaymentTerms.Location = new System.Drawing.Point(497, 50);
            this.lblPaymentTerms.Name = "lblPaymentTerms";
            this.lblPaymentTerms.Size = new System.Drawing.Size(94, 15);
            this.lblPaymentTerms.TabIndex = 25;
            this.lblPaymentTerms.Text = "Payment Terms :";
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Location = new System.Drawing.Point(497, 26);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(63, 15);
            this.lbl_DueDate.TabIndex = 24;
            this.lbl_DueDate.Text = "Due Date :";
            // 
            // dtp_DateOfInvoice
            // 
            this.dtp_DateOfInvoice.CustomFormat = "";
            this.dtp_DateOfInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateOfInvoice.Location = new System.Drawing.Point(373, 20);
            this.dtp_DateOfInvoice.Name = "dtp_DateOfInvoice";
            this.dtp_DateOfInvoice.Size = new System.Drawing.Size(106, 22);
            this.dtp_DateOfInvoice.TabIndex = 0;
            this.dtp_DateOfInvoice.Value = new System.DateTime(2020, 7, 22, 0, 0, 0, 0);
            // 
            // txt_CurrencyRate
            // 
            this.txt_CurrencyRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_CurrencyRate.Location = new System.Drawing.Point(373, 45);
            this.txt_CurrencyRate.Name = "txt_CurrencyRate";
            this.txt_CurrencyRate.ReadOnly = true;
            this.txt_CurrencyRate.Size = new System.Drawing.Size(106, 22);
            this.txt_CurrencyRate.TabIndex = 12;
            // 
            // cbox_Currency
            // 
            this.cbox_Currency.FormattingEnabled = true;
            this.cbox_Currency.Location = new System.Drawing.Point(114, 45);
            this.cbox_Currency.Name = "cbox_Currency";
            this.cbox_Currency.Size = new System.Drawing.Size(140, 23);
            this.cbox_Currency.TabIndex = 3;
            this.cbox_Currency.SelectedIndexChanged += new System.EventHandler(this.cbox_Currency_SelectedIndexChanged);
            // 
            // lbl_CurrencyRate
            // 
            this.lbl_CurrencyRate.AutoSize = true;
            this.lbl_CurrencyRate.Location = new System.Drawing.Point(263, 48);
            this.lbl_CurrencyRate.Name = "lbl_CurrencyRate";
            this.lbl_CurrencyRate.Size = new System.Drawing.Size(89, 15);
            this.lbl_CurrencyRate.TabIndex = 23;
            this.lbl_CurrencyRate.Text = "Currency Rate :";
            // 
            // lbl_InvoiceDate
            // 
            this.lbl_InvoiceDate.AutoSize = true;
            this.lbl_InvoiceDate.Location = new System.Drawing.Point(263, 21);
            this.lbl_InvoiceDate.Name = "lbl_InvoiceDate";
            this.lbl_InvoiceDate.Size = new System.Drawing.Size(38, 15);
            this.lbl_InvoiceDate.TabIndex = 22;
            this.lbl_InvoiceDate.Text = "Date :";
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(114, 123);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(365, 22);
            this.txt_Desc.TabIndex = 7;
            // 
            // txt_SupplierRef
            // 
            this.txt_SupplierRef.Location = new System.Drawing.Point(114, 97);
            this.txt_SupplierRef.Name = "txt_SupplierRef";
            this.txt_SupplierRef.Size = new System.Drawing.Size(365, 22);
            this.txt_SupplierRef.TabIndex = 6;
            // 
            // txtSuppid
            // 
            this.txtSuppid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSuppid.Location = new System.Drawing.Point(599, 73);
            this.txtSuppid.Name = "txtSuppid";
            this.txtSuppid.ReadOnly = true;
            this.txtSuppid.Size = new System.Drawing.Size(316, 22);
            this.txtSuppid.TabIndex = 13;
            // 
            // txt_InvoiceID
            // 
            this.txt_InvoiceID.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_InvoiceID.Location = new System.Drawing.Point(114, 20);
            this.txt_InvoiceID.Name = "txt_InvoiceID";
            this.txt_InvoiceID.ReadOnly = true;
            this.txt_InvoiceID.Size = new System.Drawing.Size(140, 22);
            this.txt_InvoiceID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Desc :";
            // 
            // lbl_Supplier_Ref
            // 
            this.lbl_Supplier_Ref.AutoSize = true;
            this.lbl_Supplier_Ref.Location = new System.Drawing.Point(14, 96);
            this.lbl_Supplier_Ref.Name = "lbl_Supplier_Ref";
            this.lbl_Supplier_Ref.Size = new System.Drawing.Size(78, 15);
            this.lbl_Supplier_Ref.TabIndex = 20;
            this.lbl_Supplier_Ref.Text = "Supplier Ref :";
            // 
            // lbl_SupplierName
            // 
            this.lbl_SupplierName.AutoSize = true;
            this.lbl_SupplierName.Location = new System.Drawing.Point(14, 76);
            this.lbl_SupplierName.Name = "lbl_SupplierName";
            this.lbl_SupplierName.Size = new System.Drawing.Size(90, 15);
            this.lbl_SupplierName.TabIndex = 19;
            this.lbl_SupplierName.Text = "Supplier Name :";
            // 
            // lbl_Currency
            // 
            this.lbl_Currency.AutoSize = true;
            this.lbl_Currency.Location = new System.Drawing.Point(14, 50);
            this.lbl_Currency.Name = "lbl_Currency";
            this.lbl_Currency.Size = new System.Drawing.Size(62, 15);
            this.lbl_Currency.TabIndex = 18;
            this.lbl_Currency.Text = "Currency :";
            // 
            // lbl_InvoiceID
            // 
            this.lbl_InvoiceID.AutoSize = true;
            this.lbl_InvoiceID.Location = new System.Drawing.Point(14, 27);
            this.lbl_InvoiceID.Name = "lbl_InvoiceID";
            this.lbl_InvoiceID.Size = new System.Drawing.Size(69, 15);
            this.lbl_InvoiceID.TabIndex = 17;
            this.lbl_InvoiceID.Text = "Invoice ID :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ucFirstPreNextLast1);
            this.panel1.Controls.Add(this.ucTransactionLPO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 44);
            this.panel1.TabIndex = 41;
            // 
            // ucFirstPreNextLast1
            // 
            this.ucFirstPreNextLast1.Location = new System.Drawing.Point(1216, 5);
            this.ucFirstPreNextLast1.Name = "ucFirstPreNextLast1";
            this.ucFirstPreNextLast1.Size = new System.Drawing.Size(304, 32);
            this.ucFirstPreNextLast1.TabIndex = 1;
            // 
            // ucTransactionLPO
            // 
            this.ucTransactionLPO.Location = new System.Drawing.Point(3, 1);
            this.ucTransactionLPO.Name = "ucTransactionLPO";
            this.ucTransactionLPO.Size = new System.Drawing.Size(604, 37);
            this.ucTransactionLPO.TabIndex = 0;
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.Location = new System.Drawing.Point(114, 71);
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.Size = new System.Drawing.Size(365, 23);
            this.txt_SupplierName.TabIndex = 5;
            this.txt_SupplierName.Tag = "SUPPLIER_LIST";
            this.txt_SupplierName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSuppid_MouseClick);
            // 
            // frm_Transactions_LPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1534, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GBox_LPODetail);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_LPO";
            this.ShowIcon = false;
            this.Text = "LPO";
            this.Load += new System.EventHandler(this.frm_Transactions_LPO_Load);
            this.GBox_LPODetail.ResumeLayout(false);
            this.GBox_LPODetail.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbox_LPO4.ResumeLayout(false);
            this.gbox_LPO4.PerformLayout();
            this.gbox_PaymentMode.ResumeLayout(false);
            this.gbox_PaymentMode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_LPODetail;
        private System.Windows.Forms.DateTimePicker dtp_DateOfInvoice;
        private System.Windows.Forms.TextBox txt_CurrencyRate;
        private System.Windows.Forms.ComboBox cbox_Currency;
        private System.Windows.Forms.Label lbl_CurrencyRate;
        private System.Windows.Forms.Label lbl_InvoiceDate;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.TextBox txt_SupplierRef;
        private System.Windows.Forms.TextBox txtSuppid;
        private System.Windows.Forms.TextBox txt_InvoiceID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Supplier_Ref;
        private System.Windows.Forms.Label lbl_SupplierName;
        private System.Windows.Forms.Label lbl_Currency;
        private System.Windows.Forms.Label lbl_InvoiceID;
        private System.Windows.Forms.Label lblDelTerms;
        private System.Windows.Forms.Label lblSuppTRN;
        private System.Windows.Forms.Label lbl_SupplierID;
        private System.Windows.Forms.Label lblPaymentTerms;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.Label lbl_PriceTerms;
        private System.Windows.Forms.DateTimePicker dtpdeldate;
        private System.Windows.Forms.TextBox txtSupplierTRN;
        private System.Windows.Forms.TextBox txtpaymentterms;
        private System.Windows.Forms.TextBox txtpriceterms;
        private System.Windows.Forms.TextBox txtdelterms;
        private System.Windows.Forms.CheckBox cb_VatApplicable;
        private System.Windows.Forms.CheckBox cb_ListOnlyOneItems;
        private System.Windows.Forms.CheckBox cb_ListAllitems;
        private System.Windows.Forms.GroupBox gbox_PaymentMode;
        private System.Windows.Forms.RadioButton rb_PaymentMode_Credit;
        private System.Windows.Forms.RadioButton rb_PaymentMode_Cash;
        private System.Windows.Forms.GroupBox gbox_LPO4;
        private System.Windows.Forms.RadioButton rb_LPO4Branches;
        private System.Windows.Forms.RadioButton rb_LPO4Supplier;
        private System.Windows.Forms.Label lbl_CostCenter;
        private System.Windows.Forms.ComboBox cbox_CostCenter;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSelectDevice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label label2;
        private UControl.ucTransaction ucTransactionLPO;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Add;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Delete;
        private UControl.ucFirstPreNextLast ucFirstPreNextLast1;
        private UControl.ucComboBox txt_SupplierName;
        private System.Windows.Forms.TextBox txtTotalVAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiscAmount;
        private System.Windows.Forms.TextBox txtNETQTY;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblNetQTY;
        private System.Windows.Forms.TextBox txttotalAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOtherCharges;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Panel pnlItem;
        public System.Windows.Forms.DataGridView dgv_list;
    }
}