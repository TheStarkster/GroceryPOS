namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_PurchaseReturn
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
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SubMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_SupplierID = new System.Windows.Forms.Label();
            this.txtSuppid = new System.Windows.Forms.TextBox();
            this.txt_Purchase_SupplierName = new Grocery.Admin.UControl.ucComboBox();
            this.txt_PurchaseReturn_Discount = new System.Windows.Forms.TextBox();
            this.txt_PurchaseReturn_OtherCharges = new System.Windows.Forms.TextBox();
            this.txt_PurchaseReturn_TotalAmt = new System.Windows.Forms.TextBox();
            this.lbl_PurchaseReturn_Discount = new System.Windows.Forms.Label();
            this.lbl_PurchaseReturn_OtherCharges = new System.Windows.Forms.Label();
            this.lbl_PurchaseReturn_TotalAmt = new System.Windows.Forms.Label();
            this.txt_PurchaseReturn_TotalVAT = new System.Windows.Forms.TextBox();
            this.txt_PurchaseReturn_TotalQty = new System.Windows.Forms.TextBox();
            this.lbl_PurchaseReturn_TotalVAT = new System.Windows.Forms.Label();
            this.lbl_PurchaseReturn_TotalQty = new System.Windows.Forms.Label();
            this.btn_PurchaseReturn_LoadPDT = new System.Windows.Forms.Button();
            this.txt_PurchaseReturn_NetAmt = new System.Windows.Forms.TextBox();
            this.lbl_PurchaseReturn_NetAmt = new System.Windows.Forms.Label();
            this.cb_PurchaseReturn_OneItem = new System.Windows.Forms.CheckBox();
            this.cb_PurchaseReturn_AllItem = new System.Windows.Forms.CheckBox();
            this.cb_PurchaseReturn_ApplicableVAT = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_PurchaseReturn_ScanImage = new System.Windows.Forms.Button();
            this.btn_PurchaseReturn_Browse = new System.Windows.Forms.Button();
            this.cob_PurchaseReturn_SelectDevice = new System.Windows.Forms.ComboBox();
            this.lbl_PurchaseReturn_SelectDevice = new System.Windows.Forms.Label();
            this.gb_PurchaseReturn_Payment = new System.Windows.Forms.GroupBox();
            this.rb_PurchaseReturn_Credit = new System.Windows.Forms.RadioButton();
            this.rb_PurchaseReturn_Cash = new System.Windows.Forms.RadioButton();
            this.txt_PurchaseReturn_SuppTRN = new System.Windows.Forms.TextBox();
            this.lbl_PurchaseReturn_SuppTRN = new System.Windows.Forms.Label();
            this.cob_PurchaseReturn_CostCenter = new System.Windows.Forms.ComboBox();
            this.cob_PurchaseReturn_Emirates = new System.Windows.Forms.ComboBox();
            this.txt_PurchaseReturn_SupplierID = new System.Windows.Forms.TextBox();
            this.lbl_PurchaseReturn_CostCenter = new System.Windows.Forms.Label();
            this.lbl_PurchaseReturn_Emirates = new System.Windows.Forms.Label();
            this.lbl_PurchaseReturn_SupplierID = new System.Windows.Forms.Label();
            this.txt_PurchaseReturn_CurRate = new System.Windows.Forms.TextBox();
            this.lbl_PurchaseReturn_CurRate = new System.Windows.Forms.Label();
            this.cob_PurchaseReturn_Currency = new System.Windows.Forms.ComboBox();
            this.lbl_PurchaseReturn_Currency = new System.Windows.Forms.Label();
            this.txt_PurchaseReturn_Desc = new System.Windows.Forms.TextBox();
            this.lbl_PurchaseReturn_Desc = new System.Windows.Forms.Label();
            this.txt_PurchaseReturn_RefNo = new System.Windows.Forms.TextBox();
            this.lbl_PurchaseReturn_RefNo = new System.Windows.Forms.Label();
            this.lbl_PurchaseReturn_SupplierName = new System.Windows.Forms.Label();
            this.dt_PurchaseReturn_PRDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_PurchaseReturn_PRDate = new System.Windows.Forms.Label();
            this.txt_PurchaseReturn_PRNo = new System.Windows.Forms.TextBox();
            this.lbl_PurchaseReturn_PRNo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucFirstPreNextLast1 = new Grocery.Admin.UControl.ucFirstPreNextLast();
            this.ucTransactionLPO = new Grocery.Admin.UControl.ucTransaction();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_PurchaseReturn_Payment.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_item);
            this.panel1.Controls.Add(this.lbl_SupplierID);
            this.panel1.Controls.Add(this.txtSuppid);
            this.panel1.Controls.Add(this.txt_Purchase_SupplierName);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_Discount);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_OtherCharges);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_TotalAmt);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_Discount);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_OtherCharges);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_TotalAmt);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_TotalVAT);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_TotalQty);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_TotalVAT);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_TotalQty);
            this.panel1.Controls.Add(this.btn_PurchaseReturn_LoadPDT);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_NetAmt);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_NetAmt);
            this.panel1.Controls.Add(this.cb_PurchaseReturn_OneItem);
            this.panel1.Controls.Add(this.cb_PurchaseReturn_AllItem);
            this.panel1.Controls.Add(this.cb_PurchaseReturn_ApplicableVAT);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gb_PurchaseReturn_Payment);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_SuppTRN);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_SuppTRN);
            this.panel1.Controls.Add(this.cob_PurchaseReturn_CostCenter);
            this.panel1.Controls.Add(this.cob_PurchaseReturn_Emirates);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_SupplierID);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_CostCenter);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_Emirates);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_SupplierID);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_CurRate);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_CurRate);
            this.panel1.Controls.Add(this.cob_PurchaseReturn_Currency);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_Currency);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_Desc);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_Desc);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_RefNo);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_RefNo);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_SupplierName);
            this.panel1.Controls.Add(this.dt_PurchaseReturn_PRDate);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_PRDate);
            this.panel1.Controls.Add(this.txt_PurchaseReturn_PRNo);
            this.panel1.Controls.Add(this.lbl_PurchaseReturn_PRNo);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 476);
            this.panel1.TabIndex = 0;
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_item.Location = new System.Drawing.Point(5, 149);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.Size = new System.Drawing.Size(929, 243);
            this.dgv_item.TabIndex = 45;
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
            // lbl_SupplierID
            // 
            this.lbl_SupplierID.AutoSize = true;
            this.lbl_SupplierID.Location = new System.Drawing.Point(491, 33);
            this.lbl_SupplierID.Name = "lbl_SupplierID";
            this.lbl_SupplierID.Size = new System.Drawing.Size(73, 15);
            this.lbl_SupplierID.TabIndex = 44;
            this.lbl_SupplierID.Text = "Supplier ID :";
            // 
            // txtSuppid
            // 
            this.txtSuppid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSuppid.Location = new System.Drawing.Point(568, 32);
            this.txtSuppid.Name = "txtSuppid";
            this.txtSuppid.ReadOnly = true;
            this.txtSuppid.Size = new System.Drawing.Size(131, 22);
            this.txtSuppid.TabIndex = 43;
            // 
            // txt_Purchase_SupplierName
            // 
            this.txt_Purchase_SupplierName.Location = new System.Drawing.Point(94, 33);
            this.txt_Purchase_SupplierName.Name = "txt_Purchase_SupplierName";
            this.txt_Purchase_SupplierName.Size = new System.Drawing.Size(371, 25);
            this.txt_Purchase_SupplierName.TabIndex = 42;
            this.txt_Purchase_SupplierName.Tag = "SUPPLIER_LIST";
            // 
            // txt_PurchaseReturn_Discount
            // 
            this.txt_PurchaseReturn_Discount.Location = new System.Drawing.Point(442, 435);
            this.txt_PurchaseReturn_Discount.Name = "txt_PurchaseReturn_Discount";
            this.txt_PurchaseReturn_Discount.Size = new System.Drawing.Size(158, 22);
            this.txt_PurchaseReturn_Discount.TabIndex = 41;
            // 
            // txt_PurchaseReturn_OtherCharges
            // 
            this.txt_PurchaseReturn_OtherCharges.Location = new System.Drawing.Point(442, 407);
            this.txt_PurchaseReturn_OtherCharges.Name = "txt_PurchaseReturn_OtherCharges";
            this.txt_PurchaseReturn_OtherCharges.Size = new System.Drawing.Size(158, 22);
            this.txt_PurchaseReturn_OtherCharges.TabIndex = 40;
            // 
            // txt_PurchaseReturn_TotalAmt
            // 
            this.txt_PurchaseReturn_TotalAmt.Enabled = false;
            this.txt_PurchaseReturn_TotalAmt.Location = new System.Drawing.Point(768, 403);
            this.txt_PurchaseReturn_TotalAmt.Name = "txt_PurchaseReturn_TotalAmt";
            this.txt_PurchaseReturn_TotalAmt.Size = new System.Drawing.Size(158, 22);
            this.txt_PurchaseReturn_TotalAmt.TabIndex = 39;
            // 
            // lbl_PurchaseReturn_Discount
            // 
            this.lbl_PurchaseReturn_Discount.AutoSize = true;
            this.lbl_PurchaseReturn_Discount.Location = new System.Drawing.Point(352, 438);
            this.lbl_PurchaseReturn_Discount.Name = "lbl_PurchaseReturn_Discount";
            this.lbl_PurchaseReturn_Discount.Size = new System.Drawing.Size(56, 15);
            this.lbl_PurchaseReturn_Discount.TabIndex = 38;
            this.lbl_PurchaseReturn_Discount.Text = "Discount";
            // 
            // lbl_PurchaseReturn_OtherCharges
            // 
            this.lbl_PurchaseReturn_OtherCharges.AutoSize = true;
            this.lbl_PurchaseReturn_OtherCharges.Location = new System.Drawing.Point(352, 410);
            this.lbl_PurchaseReturn_OtherCharges.Name = "lbl_PurchaseReturn_OtherCharges";
            this.lbl_PurchaseReturn_OtherCharges.Size = new System.Drawing.Size(84, 15);
            this.lbl_PurchaseReturn_OtherCharges.TabIndex = 37;
            this.lbl_PurchaseReturn_OtherCharges.Text = "Other Charges";
            // 
            // lbl_PurchaseReturn_TotalAmt
            // 
            this.lbl_PurchaseReturn_TotalAmt.AutoSize = true;
            this.lbl_PurchaseReturn_TotalAmt.Location = new System.Drawing.Point(678, 406);
            this.lbl_PurchaseReturn_TotalAmt.Name = "lbl_PurchaseReturn_TotalAmt";
            this.lbl_PurchaseReturn_TotalAmt.Size = new System.Drawing.Size(80, 15);
            this.lbl_PurchaseReturn_TotalAmt.TabIndex = 36;
            this.lbl_PurchaseReturn_TotalAmt.Text = "Total Amount";
            // 
            // txt_PurchaseReturn_TotalVAT
            // 
            this.txt_PurchaseReturn_TotalVAT.Enabled = false;
            this.txt_PurchaseReturn_TotalVAT.Location = new System.Drawing.Point(187, 432);
            this.txt_PurchaseReturn_TotalVAT.Name = "txt_PurchaseReturn_TotalVAT";
            this.txt_PurchaseReturn_TotalVAT.Size = new System.Drawing.Size(158, 22);
            this.txt_PurchaseReturn_TotalVAT.TabIndex = 35;
            // 
            // txt_PurchaseReturn_TotalQty
            // 
            this.txt_PurchaseReturn_TotalQty.Enabled = false;
            this.txt_PurchaseReturn_TotalQty.Location = new System.Drawing.Point(187, 404);
            this.txt_PurchaseReturn_TotalQty.Name = "txt_PurchaseReturn_TotalQty";
            this.txt_PurchaseReturn_TotalQty.Size = new System.Drawing.Size(158, 22);
            this.txt_PurchaseReturn_TotalQty.TabIndex = 34;
            // 
            // lbl_PurchaseReturn_TotalVAT
            // 
            this.lbl_PurchaseReturn_TotalVAT.AutoSize = true;
            this.lbl_PurchaseReturn_TotalVAT.Location = new System.Drawing.Point(124, 435);
            this.lbl_PurchaseReturn_TotalVAT.Name = "lbl_PurchaseReturn_TotalVAT";
            this.lbl_PurchaseReturn_TotalVAT.Size = new System.Drawing.Size(60, 15);
            this.lbl_PurchaseReturn_TotalVAT.TabIndex = 33;
            this.lbl_PurchaseReturn_TotalVAT.Text = "Total VAT";
            // 
            // lbl_PurchaseReturn_TotalQty
            // 
            this.lbl_PurchaseReturn_TotalQty.AutoSize = true;
            this.lbl_PurchaseReturn_TotalQty.Location = new System.Drawing.Point(124, 407);
            this.lbl_PurchaseReturn_TotalQty.Name = "lbl_PurchaseReturn_TotalQty";
            this.lbl_PurchaseReturn_TotalQty.Size = new System.Drawing.Size(57, 15);
            this.lbl_PurchaseReturn_TotalQty.TabIndex = 32;
            this.lbl_PurchaseReturn_TotalQty.Text = "Total Qty";
            // 
            // btn_PurchaseReturn_LoadPDT
            // 
            this.btn_PurchaseReturn_LoadPDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PurchaseReturn_LoadPDT.Location = new System.Drawing.Point(6, 407);
            this.btn_PurchaseReturn_LoadPDT.Name = "btn_PurchaseReturn_LoadPDT";
            this.btn_PurchaseReturn_LoadPDT.Size = new System.Drawing.Size(75, 50);
            this.btn_PurchaseReturn_LoadPDT.TabIndex = 31;
            this.btn_PurchaseReturn_LoadPDT.Text = "Load PDT";
            this.btn_PurchaseReturn_LoadPDT.UseVisualStyleBackColor = true;
            // 
            // txt_PurchaseReturn_NetAmt
            // 
            this.txt_PurchaseReturn_NetAmt.Enabled = false;
            this.txt_PurchaseReturn_NetAmt.Location = new System.Drawing.Point(768, 432);
            this.txt_PurchaseReturn_NetAmt.Name = "txt_PurchaseReturn_NetAmt";
            this.txt_PurchaseReturn_NetAmt.Size = new System.Drawing.Size(158, 22);
            this.txt_PurchaseReturn_NetAmt.TabIndex = 30;
            // 
            // lbl_PurchaseReturn_NetAmt
            // 
            this.lbl_PurchaseReturn_NetAmt.AutoSize = true;
            this.lbl_PurchaseReturn_NetAmt.Location = new System.Drawing.Point(681, 435);
            this.lbl_PurchaseReturn_NetAmt.Name = "lbl_PurchaseReturn_NetAmt";
            this.lbl_PurchaseReturn_NetAmt.Size = new System.Drawing.Size(72, 15);
            this.lbl_PurchaseReturn_NetAmt.TabIndex = 29;
            this.lbl_PurchaseReturn_NetAmt.Text = "Net Amount";
            // 
            // cb_PurchaseReturn_OneItem
            // 
            this.cb_PurchaseReturn_OneItem.AutoSize = true;
            this.cb_PurchaseReturn_OneItem.Location = new System.Drawing.Point(766, 115);
            this.cb_PurchaseReturn_OneItem.Name = "cb_PurchaseReturn_OneItem";
            this.cb_PurchaseReturn_OneItem.Size = new System.Drawing.Size(124, 19);
            this.cb_PurchaseReturn_OneItem.TabIndex = 27;
            this.cb_PurchaseReturn_OneItem.Text = "List Only one Item";
            this.cb_PurchaseReturn_OneItem.UseVisualStyleBackColor = true;
            // 
            // cb_PurchaseReturn_AllItem
            // 
            this.cb_PurchaseReturn_AllItem.AutoSize = true;
            this.cb_PurchaseReturn_AllItem.Location = new System.Drawing.Point(764, 90);
            this.cb_PurchaseReturn_AllItem.Name = "cb_PurchaseReturn_AllItem";
            this.cb_PurchaseReturn_AllItem.Size = new System.Drawing.Size(96, 19);
            this.cb_PurchaseReturn_AllItem.TabIndex = 26;
            this.cb_PurchaseReturn_AllItem.Text = "List All Items";
            this.cb_PurchaseReturn_AllItem.UseVisualStyleBackColor = true;
            // 
            // cb_PurchaseReturn_ApplicableVAT
            // 
            this.cb_PurchaseReturn_ApplicableVAT.AutoSize = true;
            this.cb_PurchaseReturn_ApplicableVAT.Location = new System.Drawing.Point(764, 68);
            this.cb_PurchaseReturn_ApplicableVAT.Name = "cb_PurchaseReturn_ApplicableVAT";
            this.cb_PurchaseReturn_ApplicableVAT.Size = new System.Drawing.Size(126, 19);
            this.cb_PurchaseReturn_ApplicableVAT.TabIndex = 25;
            this.cb_PurchaseReturn_ApplicableVAT.Text = "VAT APPLICABLE";
            this.cb_PurchaseReturn_ApplicableVAT.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_PurchaseReturn_ScanImage);
            this.panel3.Controls.Add(this.btn_PurchaseReturn_Browse);
            this.panel3.Controls.Add(this.cob_PurchaseReturn_SelectDevice);
            this.panel3.Controls.Add(this.lbl_PurchaseReturn_SelectDevice);
            this.panel3.Location = new System.Drawing.Point(940, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 447);
            this.panel3.TabIndex = 24;
            // 
            // btn_PurchaseReturn_ScanImage
            // 
            this.btn_PurchaseReturn_ScanImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PurchaseReturn_ScanImage.Location = new System.Drawing.Point(100, 406);
            this.btn_PurchaseReturn_ScanImage.Name = "btn_PurchaseReturn_ScanImage";
            this.btn_PurchaseReturn_ScanImage.Size = new System.Drawing.Size(92, 29);
            this.btn_PurchaseReturn_ScanImage.TabIndex = 40;
            this.btn_PurchaseReturn_ScanImage.Text = "Scan Image";
            this.btn_PurchaseReturn_ScanImage.UseVisualStyleBackColor = true;
            // 
            // btn_PurchaseReturn_Browse
            // 
            this.btn_PurchaseReturn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PurchaseReturn_Browse.Location = new System.Drawing.Point(6, 406);
            this.btn_PurchaseReturn_Browse.Name = "btn_PurchaseReturn_Browse";
            this.btn_PurchaseReturn_Browse.Size = new System.Drawing.Size(92, 29);
            this.btn_PurchaseReturn_Browse.TabIndex = 39;
            this.btn_PurchaseReturn_Browse.Text = "Browser";
            this.btn_PurchaseReturn_Browse.UseVisualStyleBackColor = true;
            // 
            // cob_PurchaseReturn_SelectDevice
            // 
            this.cob_PurchaseReturn_SelectDevice.FormattingEnabled = true;
            this.cob_PurchaseReturn_SelectDevice.Location = new System.Drawing.Point(6, 375);
            this.cob_PurchaseReturn_SelectDevice.Name = "cob_PurchaseReturn_SelectDevice";
            this.cob_PurchaseReturn_SelectDevice.Size = new System.Drawing.Size(186, 23);
            this.cob_PurchaseReturn_SelectDevice.TabIndex = 38;
            // 
            // lbl_PurchaseReturn_SelectDevice
            // 
            this.lbl_PurchaseReturn_SelectDevice.AutoSize = true;
            this.lbl_PurchaseReturn_SelectDevice.Location = new System.Drawing.Point(3, 357);
            this.lbl_PurchaseReturn_SelectDevice.Name = "lbl_PurchaseReturn_SelectDevice";
            this.lbl_PurchaseReturn_SelectDevice.Size = new System.Drawing.Size(79, 15);
            this.lbl_PurchaseReturn_SelectDevice.TabIndex = 37;
            this.lbl_PurchaseReturn_SelectDevice.Text = "Select Device";
            // 
            // gb_PurchaseReturn_Payment
            // 
            this.gb_PurchaseReturn_Payment.Controls.Add(this.rb_PurchaseReturn_Credit);
            this.gb_PurchaseReturn_Payment.Controls.Add(this.rb_PurchaseReturn_Cash);
            this.gb_PurchaseReturn_Payment.Location = new System.Drawing.Point(764, 11);
            this.gb_PurchaseReturn_Payment.Name = "gb_PurchaseReturn_Payment";
            this.gb_PurchaseReturn_Payment.Size = new System.Drawing.Size(155, 49);
            this.gb_PurchaseReturn_Payment.TabIndex = 22;
            this.gb_PurchaseReturn_Payment.TabStop = false;
            this.gb_PurchaseReturn_Payment.Text = "Payment";
            // 
            // rb_PurchaseReturn_Credit
            // 
            this.rb_PurchaseReturn_Credit.AutoSize = true;
            this.rb_PurchaseReturn_Credit.Location = new System.Drawing.Point(74, 20);
            this.rb_PurchaseReturn_Credit.Name = "rb_PurchaseReturn_Credit";
            this.rb_PurchaseReturn_Credit.Size = new System.Drawing.Size(57, 19);
            this.rb_PurchaseReturn_Credit.TabIndex = 1;
            this.rb_PurchaseReturn_Credit.TabStop = true;
            this.rb_PurchaseReturn_Credit.Text = "Credit";
            this.rb_PurchaseReturn_Credit.UseVisualStyleBackColor = true;
            // 
            // rb_PurchaseReturn_Cash
            // 
            this.rb_PurchaseReturn_Cash.AutoSize = true;
            this.rb_PurchaseReturn_Cash.Location = new System.Drawing.Point(7, 22);
            this.rb_PurchaseReturn_Cash.Name = "rb_PurchaseReturn_Cash";
            this.rb_PurchaseReturn_Cash.Size = new System.Drawing.Size(52, 19);
            this.rb_PurchaseReturn_Cash.TabIndex = 0;
            this.rb_PurchaseReturn_Cash.TabStop = true;
            this.rb_PurchaseReturn_Cash.Text = "Cash";
            this.rb_PurchaseReturn_Cash.UseVisualStyleBackColor = true;
            // 
            // txt_PurchaseReturn_SuppTRN
            // 
            this.txt_PurchaseReturn_SuppTRN.Enabled = false;
            this.txt_PurchaseReturn_SuppTRN.Location = new System.Drawing.Point(568, 117);
            this.txt_PurchaseReturn_SuppTRN.Name = "txt_PurchaseReturn_SuppTRN";
            this.txt_PurchaseReturn_SuppTRN.Size = new System.Drawing.Size(89, 22);
            this.txt_PurchaseReturn_SuppTRN.TabIndex = 21;
            // 
            // lbl_PurchaseReturn_SuppTRN
            // 
            this.lbl_PurchaseReturn_SuppTRN.AutoSize = true;
            this.lbl_PurchaseReturn_SuppTRN.Location = new System.Drawing.Point(491, 121);
            this.lbl_PurchaseReturn_SuppTRN.Name = "lbl_PurchaseReturn_SuppTRN";
            this.lbl_PurchaseReturn_SuppTRN.Size = new System.Drawing.Size(63, 15);
            this.lbl_PurchaseReturn_SuppTRN.TabIndex = 20;
            this.lbl_PurchaseReturn_SuppTRN.Text = "Supp TRN";
            // 
            // cob_PurchaseReturn_CostCenter
            // 
            this.cob_PurchaseReturn_CostCenter.FormattingEnabled = true;
            this.cob_PurchaseReturn_CostCenter.Location = new System.Drawing.Point(568, 85);
            this.cob_PurchaseReturn_CostCenter.Name = "cob_PurchaseReturn_CostCenter";
            this.cob_PurchaseReturn_CostCenter.Size = new System.Drawing.Size(131, 23);
            this.cob_PurchaseReturn_CostCenter.TabIndex = 19;
            // 
            // cob_PurchaseReturn_Emirates
            // 
            this.cob_PurchaseReturn_Emirates.FormattingEnabled = true;
            this.cob_PurchaseReturn_Emirates.Location = new System.Drawing.Point(568, 59);
            this.cob_PurchaseReturn_Emirates.Name = "cob_PurchaseReturn_Emirates";
            this.cob_PurchaseReturn_Emirates.Size = new System.Drawing.Size(131, 23);
            this.cob_PurchaseReturn_Emirates.TabIndex = 18;
            // 
            // txt_PurchaseReturn_SupplierID
            // 
            this.txt_PurchaseReturn_SupplierID.Enabled = false;
            this.txt_PurchaseReturn_SupplierID.Location = new System.Drawing.Point(568, 8);
            this.txt_PurchaseReturn_SupplierID.Name = "txt_PurchaseReturn_SupplierID";
            this.txt_PurchaseReturn_SupplierID.Size = new System.Drawing.Size(131, 22);
            this.txt_PurchaseReturn_SupplierID.TabIndex = 17;
            // 
            // lbl_PurchaseReturn_CostCenter
            // 
            this.lbl_PurchaseReturn_CostCenter.AutoSize = true;
            this.lbl_PurchaseReturn_CostCenter.Location = new System.Drawing.Point(491, 88);
            this.lbl_PurchaseReturn_CostCenter.Name = "lbl_PurchaseReturn_CostCenter";
            this.lbl_PurchaseReturn_CostCenter.Size = new System.Drawing.Size(70, 15);
            this.lbl_PurchaseReturn_CostCenter.TabIndex = 16;
            this.lbl_PurchaseReturn_CostCenter.Text = "Cost Center";
            // 
            // lbl_PurchaseReturn_Emirates
            // 
            this.lbl_PurchaseReturn_Emirates.AutoSize = true;
            this.lbl_PurchaseReturn_Emirates.Location = new System.Drawing.Point(491, 62);
            this.lbl_PurchaseReturn_Emirates.Name = "lbl_PurchaseReturn_Emirates";
            this.lbl_PurchaseReturn_Emirates.Size = new System.Drawing.Size(52, 15);
            this.lbl_PurchaseReturn_Emirates.TabIndex = 15;
            this.lbl_PurchaseReturn_Emirates.Text = "Emirates";
            // 
            // lbl_PurchaseReturn_SupplierID
            // 
            this.lbl_PurchaseReturn_SupplierID.AutoSize = true;
            this.lbl_PurchaseReturn_SupplierID.Location = new System.Drawing.Point(491, 10);
            this.lbl_PurchaseReturn_SupplierID.Name = "lbl_PurchaseReturn_SupplierID";
            this.lbl_PurchaseReturn_SupplierID.Size = new System.Drawing.Size(67, 15);
            this.lbl_PurchaseReturn_SupplierID.TabIndex = 14;
            this.lbl_PurchaseReturn_SupplierID.Text = "Supplier ID";
            // 
            // txt_PurchaseReturn_CurRate
            // 
            this.txt_PurchaseReturn_CurRate.Enabled = false;
            this.txt_PurchaseReturn_CurRate.Location = new System.Drawing.Point(385, 117);
            this.txt_PurchaseReturn_CurRate.Name = "txt_PurchaseReturn_CurRate";
            this.txt_PurchaseReturn_CurRate.Size = new System.Drawing.Size(80, 22);
            this.txt_PurchaseReturn_CurRate.TabIndex = 13;
            // 
            // lbl_PurchaseReturn_CurRate
            // 
            this.lbl_PurchaseReturn_CurRate.AutoSize = true;
            this.lbl_PurchaseReturn_CurRate.Location = new System.Drawing.Point(327, 120);
            this.lbl_PurchaseReturn_CurRate.Name = "lbl_PurchaseReturn_CurRate";
            this.lbl_PurchaseReturn_CurRate.Size = new System.Drawing.Size(52, 15);
            this.lbl_PurchaseReturn_CurRate.TabIndex = 12;
            this.lbl_PurchaseReturn_CurRate.Text = "Cur.Rate";
            // 
            // cob_PurchaseReturn_Currency
            // 
            this.cob_PurchaseReturn_Currency.FormattingEnabled = true;
            this.cob_PurchaseReturn_Currency.Location = new System.Drawing.Point(93, 117);
            this.cob_PurchaseReturn_Currency.Name = "cob_PurchaseReturn_Currency";
            this.cob_PurchaseReturn_Currency.Size = new System.Drawing.Size(147, 23);
            this.cob_PurchaseReturn_Currency.TabIndex = 11;
            this.cob_PurchaseReturn_Currency.SelectedIndexChanged += new System.EventHandler(this.cob_PurchaseReturn_Currency_SelectedIndexChanged);
            // 
            // lbl_PurchaseReturn_Currency
            // 
            this.lbl_PurchaseReturn_Currency.AutoSize = true;
            this.lbl_PurchaseReturn_Currency.Location = new System.Drawing.Point(3, 120);
            this.lbl_PurchaseReturn_Currency.Name = "lbl_PurchaseReturn_Currency";
            this.lbl_PurchaseReturn_Currency.Size = new System.Drawing.Size(56, 15);
            this.lbl_PurchaseReturn_Currency.TabIndex = 10;
            this.lbl_PurchaseReturn_Currency.Text = "Currency";
            // 
            // txt_PurchaseReturn_Desc
            // 
            this.txt_PurchaseReturn_Desc.Location = new System.Drawing.Point(93, 90);
            this.txt_PurchaseReturn_Desc.Name = "txt_PurchaseReturn_Desc";
            this.txt_PurchaseReturn_Desc.Size = new System.Drawing.Size(372, 22);
            this.txt_PurchaseReturn_Desc.TabIndex = 9;
            // 
            // lbl_PurchaseReturn_Desc
            // 
            this.lbl_PurchaseReturn_Desc.AutoSize = true;
            this.lbl_PurchaseReturn_Desc.Location = new System.Drawing.Point(3, 93);
            this.lbl_PurchaseReturn_Desc.Name = "lbl_PurchaseReturn_Desc";
            this.lbl_PurchaseReturn_Desc.Size = new System.Drawing.Size(34, 15);
            this.lbl_PurchaseReturn_Desc.TabIndex = 8;
            this.lbl_PurchaseReturn_Desc.Text = "Desc";
            // 
            // txt_PurchaseReturn_RefNo
            // 
            this.txt_PurchaseReturn_RefNo.Location = new System.Drawing.Point(93, 62);
            this.txt_PurchaseReturn_RefNo.Name = "txt_PurchaseReturn_RefNo";
            this.txt_PurchaseReturn_RefNo.Size = new System.Drawing.Size(372, 22);
            this.txt_PurchaseReturn_RefNo.TabIndex = 7;
            // 
            // lbl_PurchaseReturn_RefNo
            // 
            this.lbl_PurchaseReturn_RefNo.AutoSize = true;
            this.lbl_PurchaseReturn_RefNo.Location = new System.Drawing.Point(3, 65);
            this.lbl_PurchaseReturn_RefNo.Name = "lbl_PurchaseReturn_RefNo";
            this.lbl_PurchaseReturn_RefNo.Size = new System.Drawing.Size(79, 15);
            this.lbl_PurchaseReturn_RefNo.TabIndex = 6;
            this.lbl_PurchaseReturn_RefNo.Text = "Reference No";
            // 
            // lbl_PurchaseReturn_SupplierName
            // 
            this.lbl_PurchaseReturn_SupplierName.AutoSize = true;
            this.lbl_PurchaseReturn_SupplierName.Location = new System.Drawing.Point(3, 38);
            this.lbl_PurchaseReturn_SupplierName.Name = "lbl_PurchaseReturn_SupplierName";
            this.lbl_PurchaseReturn_SupplierName.Size = new System.Drawing.Size(84, 15);
            this.lbl_PurchaseReturn_SupplierName.TabIndex = 4;
            this.lbl_PurchaseReturn_SupplierName.Text = "Supplier Name";
            // 
            // dt_PurchaseReturn_PRDate
            // 
            this.dt_PurchaseReturn_PRDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_PurchaseReturn_PRDate.Location = new System.Drawing.Point(363, 8);
            this.dt_PurchaseReturn_PRDate.Name = "dt_PurchaseReturn_PRDate";
            this.dt_PurchaseReturn_PRDate.Size = new System.Drawing.Size(102, 22);
            this.dt_PurchaseReturn_PRDate.TabIndex = 3;
            // 
            // lbl_PurchaseReturn_PRDate
            // 
            this.lbl_PurchaseReturn_PRDate.AutoSize = true;
            this.lbl_PurchaseReturn_PRDate.Location = new System.Drawing.Point(307, 11);
            this.lbl_PurchaseReturn_PRDate.Name = "lbl_PurchaseReturn_PRDate";
            this.lbl_PurchaseReturn_PRDate.Size = new System.Drawing.Size(50, 15);
            this.lbl_PurchaseReturn_PRDate.TabIndex = 2;
            this.lbl_PurchaseReturn_PRDate.Text = "PR Date";
            // 
            // txt_PurchaseReturn_PRNo
            // 
            this.txt_PurchaseReturn_PRNo.Enabled = false;
            this.txt_PurchaseReturn_PRNo.Location = new System.Drawing.Point(94, 7);
            this.txt_PurchaseReturn_PRNo.Name = "txt_PurchaseReturn_PRNo";
            this.txt_PurchaseReturn_PRNo.Size = new System.Drawing.Size(207, 22);
            this.txt_PurchaseReturn_PRNo.TabIndex = 1;
            // 
            // lbl_PurchaseReturn_PRNo
            // 
            this.lbl_PurchaseReturn_PRNo.AutoSize = true;
            this.lbl_PurchaseReturn_PRNo.Location = new System.Drawing.Point(3, 11);
            this.lbl_PurchaseReturn_PRNo.Name = "lbl_PurchaseReturn_PRNo";
            this.lbl_PurchaseReturn_PRNo.Size = new System.Drawing.Size(41, 15);
            this.lbl_PurchaseReturn_PRNo.TabIndex = 0;
            this.lbl_PurchaseReturn_PRNo.Text = "PR No";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ucFirstPreNextLast1);
            this.panel4.Controls.Add(this.ucTransactionLPO);
            this.panel4.Location = new System.Drawing.Point(13, 499);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1141, 52);
            this.panel4.TabIndex = 1;
            // 
            // ucFirstPreNextLast1
            // 
            this.ucFirstPreNextLast1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucFirstPreNextLast1.Location = new System.Drawing.Point(826, 4);
            this.ucFirstPreNextLast1.Name = "ucFirstPreNextLast1";
            this.ucFirstPreNextLast1.Size = new System.Drawing.Size(306, 34);
            this.ucFirstPreNextLast1.TabIndex = 5;
            // 
            // ucTransactionLPO
            // 
            this.ucTransactionLPO.Location = new System.Drawing.Point(7, 4);
            this.ucTransactionLPO.Name = "ucTransactionLPO";
            this.ucTransactionLPO.Size = new System.Drawing.Size(605, 42);
            this.ucTransactionLPO.TabIndex = 4;
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgv_list);
            this.pnlItem.Location = new System.Drawing.Point(255, 165);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(894, 328);
            this.pnlItem.TabIndex = 44;
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
            // frm_Transactions_PurchaseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1166, 554);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_PurchaseReturn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions PurchaseReturn";
            this.Load += new System.EventHandler(this.frm_Transactions_PurchaseReturn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gb_PurchaseReturn_Payment.ResumeLayout(false);
            this.gb_PurchaseReturn_Payment.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_Discount;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_OtherCharges;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_TotalAmt;
        private System.Windows.Forms.Label lbl_PurchaseReturn_Discount;
        private System.Windows.Forms.Label lbl_PurchaseReturn_OtherCharges;
        private System.Windows.Forms.Label lbl_PurchaseReturn_TotalAmt;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_TotalVAT;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_TotalQty;
        private System.Windows.Forms.Label lbl_PurchaseReturn_TotalVAT;
        private System.Windows.Forms.Label lbl_PurchaseReturn_TotalQty;
        private System.Windows.Forms.Button btn_PurchaseReturn_LoadPDT;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_NetAmt;
        private System.Windows.Forms.Label lbl_PurchaseReturn_NetAmt;
        private System.Windows.Forms.CheckBox cb_PurchaseReturn_OneItem;
        private System.Windows.Forms.CheckBox cb_PurchaseReturn_AllItem;
        private System.Windows.Forms.CheckBox cb_PurchaseReturn_ApplicableVAT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gb_PurchaseReturn_Payment;
        private System.Windows.Forms.RadioButton rb_PurchaseReturn_Credit;
        private System.Windows.Forms.RadioButton rb_PurchaseReturn_Cash;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_SuppTRN;
        private System.Windows.Forms.Label lbl_PurchaseReturn_SuppTRN;
        private System.Windows.Forms.ComboBox cob_PurchaseReturn_CostCenter;
        private System.Windows.Forms.ComboBox cob_PurchaseReturn_Emirates;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_SupplierID;
        private System.Windows.Forms.Label lbl_PurchaseReturn_CostCenter;
        private System.Windows.Forms.Label lbl_PurchaseReturn_Emirates;
        private System.Windows.Forms.Label lbl_PurchaseReturn_SupplierID;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_CurRate;
        private System.Windows.Forms.Label lbl_PurchaseReturn_CurRate;
        private System.Windows.Forms.ComboBox cob_PurchaseReturn_Currency;
        private System.Windows.Forms.Label lbl_PurchaseReturn_Currency;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_Desc;
        private System.Windows.Forms.Label lbl_PurchaseReturn_Desc;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_RefNo;
        private System.Windows.Forms.Label lbl_PurchaseReturn_RefNo;
        private System.Windows.Forms.Label lbl_PurchaseReturn_SupplierName;
        private System.Windows.Forms.DateTimePicker dt_PurchaseReturn_PRDate;
        private System.Windows.Forms.Label lbl_PurchaseReturn_PRDate;
        private System.Windows.Forms.TextBox txt_PurchaseReturn_PRNo;
        private System.Windows.Forms.Label lbl_PurchaseReturn_PRNo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_PurchaseReturn_SelectDevice;
        private System.Windows.Forms.Button btn_PurchaseReturn_ScanImage;
        private System.Windows.Forms.Button btn_PurchaseReturn_Browse;
        private System.Windows.Forms.ComboBox cob_PurchaseReturn_SelectDevice;
        private UControl.ucFirstPreNextLast ucFirstPreNextLast1;
        private UControl.ucTransaction ucTransactionLPO;
        private System.Windows.Forms.Label lbl_SupplierID;
        private System.Windows.Forms.TextBox txtSuppid;
        private UControl.ucComboBox txt_Purchase_SupplierName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Add;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Delete;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.Panel pnlItem;
        public System.Windows.Forms.DataGridView dgv_list;
    }
}