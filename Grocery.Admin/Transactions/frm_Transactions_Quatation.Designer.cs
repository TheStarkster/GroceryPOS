namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_Quatation
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
            this.lbl_Quotation_InvoiceNo = new System.Windows.Forms.Label();
            this.txt_Quotation_InvoiceNo = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_CustName = new System.Windows.Forms.Label();
            this.lbl_Quotation_Date = new System.Windows.Forms.Label();
            this.dt_Quotation_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Quotation_CustRef = new System.Windows.Forms.Label();
            this.txt_Quotation_CustRef = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_Desc = new System.Windows.Forms.Label();
            this.txt_Quotation_Desc = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_Currency = new System.Windows.Forms.Label();
            this.cob_Quotation_Currency = new System.Windows.Forms.ComboBox();
            this.lbl_Quotation_CurRate = new System.Windows.Forms.Label();
            this.txt_Quotation_CurRate = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_CostCenter = new System.Windows.Forms.Label();
            this.cob_Quotation_CostCenter = new System.Windows.Forms.ComboBox();
            this.lbl_Quotation_CustID = new System.Windows.Forms.Label();
            this.gb_Quotation_PaymentMode = new System.Windows.Forms.GroupBox();
            this.rb_Quotation_Credit = new System.Windows.Forms.RadioButton();
            this.rb_Quotation_Cash = new System.Windows.Forms.RadioButton();
            this.lbl_Quotation_CustTRN = new System.Windows.Forms.Label();
            this.txt_Quotation_CustID = new System.Windows.Forms.TextBox();
            this.cb_Quotation_VATApplicable = new System.Windows.Forms.CheckBox();
            this.txt_Quotation_CustTRN = new System.Windows.Forms.TextBox();
            this.cb_Quotation_ListAllItem = new System.Windows.Forms.CheckBox();
            this.cb_Quotation_ListOneItem = new System.Windows.Forms.CheckBox();
            this.lbl_Quotation_Attn = new System.Windows.Forms.Label();
            this.txt_Quotation_Attn = new System.Windows.Forms.RichTextBox();
            this.lbl_Quotation_Remarks = new System.Windows.Forms.Label();
            this.txt_Quotation_Remarks = new System.Windows.Forms.RichTextBox();
            this.lbl_Quotation_TotalQty = new System.Windows.Forms.Label();
            this.txt_Quotation_TotalQty = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_TotalVAT = new System.Windows.Forms.Label();
            this.txt_Quotation_TotalVAT = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_TotalAmt = new System.Windows.Forms.Label();
            this.txt_Quotation_TotalAmt = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_OtherCharges = new System.Windows.Forms.Label();
            this.txt_Quotation_OtherCharges = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_Discount = new System.Windows.Forms.Label();
            this.txt_Quotation_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_NetAmt = new System.Windows.Forms.Label();
            this.txt_Quotation_NetAmt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_Quotation_PrintWithoutItemPrice = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Quotation_ScanImage = new System.Windows.Forms.Button();
            this.btn_Quotation_Browser = new System.Windows.Forms.Button();
            this.cob_Quotation_SelectDevice = new System.Windows.Forms.ComboBox();
            this.lbl_Quotation_SelectDevice = new System.Windows.Forms.Label();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SubMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.txt_CustName = new Grocery.Admin.UControl.ucComboBox();
            this.ucFirstPreNextLast1 = new Grocery.Admin.UControl.ucFirstPreNextLast();
            this.ucTransactionLPO = new Grocery.Admin.UControl.ucTransaction();
            this.gb_Quotation_PaymentMode.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Quotation_InvoiceNo
            // 
            this.lbl_Quotation_InvoiceNo.AutoSize = true;
            this.lbl_Quotation_InvoiceNo.Location = new System.Drawing.Point(14, 20);
            this.lbl_Quotation_InvoiceNo.Name = "lbl_Quotation_InvoiceNo";
            this.lbl_Quotation_InvoiceNo.Size = new System.Drawing.Size(66, 15);
            this.lbl_Quotation_InvoiceNo.TabIndex = 0;
            this.lbl_Quotation_InvoiceNo.Text = "Invoice No";
            // 
            // txt_Quotation_InvoiceNo
            // 
            this.txt_Quotation_InvoiceNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_InvoiceNo.Location = new System.Drawing.Point(111, 17);
            this.txt_Quotation_InvoiceNo.Name = "txt_Quotation_InvoiceNo";
            this.txt_Quotation_InvoiceNo.Size = new System.Drawing.Size(130, 22);
            this.txt_Quotation_InvoiceNo.TabIndex = 1;
            // 
            // lbl_Quotation_CustName
            // 
            this.lbl_Quotation_CustName.AutoSize = true;
            this.lbl_Quotation_CustName.Location = new System.Drawing.Point(14, 48);
            this.lbl_Quotation_CustName.Name = "lbl_Quotation_CustName";
            this.lbl_Quotation_CustName.Size = new System.Drawing.Size(91, 15);
            this.lbl_Quotation_CustName.TabIndex = 2;
            this.lbl_Quotation_CustName.Text = "Customer Name";
            // 
            // lbl_Quotation_Date
            // 
            this.lbl_Quotation_Date.AutoSize = true;
            this.lbl_Quotation_Date.Location = new System.Drawing.Point(337, 20);
            this.lbl_Quotation_Date.Name = "lbl_Quotation_Date";
            this.lbl_Quotation_Date.Size = new System.Drawing.Size(32, 15);
            this.lbl_Quotation_Date.TabIndex = 4;
            this.lbl_Quotation_Date.Text = "Date";
            // 
            // dt_Quotation_Date
            // 
            this.dt_Quotation_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Quotation_Date.Location = new System.Drawing.Point(375, 17);
            this.dt_Quotation_Date.Name = "dt_Quotation_Date";
            this.dt_Quotation_Date.Size = new System.Drawing.Size(98, 22);
            this.dt_Quotation_Date.TabIndex = 5;
            // 
            // lbl_Quotation_CustRef
            // 
            this.lbl_Quotation_CustRef.AutoSize = true;
            this.lbl_Quotation_CustRef.Location = new System.Drawing.Point(14, 76);
            this.lbl_Quotation_CustRef.Name = "lbl_Quotation_CustRef";
            this.lbl_Quotation_CustRef.Size = new System.Drawing.Size(79, 15);
            this.lbl_Quotation_CustRef.TabIndex = 6;
            this.lbl_Quotation_CustRef.Text = "Customer Ref";
            // 
            // txt_Quotation_CustRef
            // 
            this.txt_Quotation_CustRef.Location = new System.Drawing.Point(111, 73);
            this.txt_Quotation_CustRef.Name = "txt_Quotation_CustRef";
            this.txt_Quotation_CustRef.Size = new System.Drawing.Size(362, 22);
            this.txt_Quotation_CustRef.TabIndex = 7;
            // 
            // lbl_Quotation_Desc
            // 
            this.lbl_Quotation_Desc.AutoSize = true;
            this.lbl_Quotation_Desc.Location = new System.Drawing.Point(15, 104);
            this.lbl_Quotation_Desc.Name = "lbl_Quotation_Desc";
            this.lbl_Quotation_Desc.Size = new System.Drawing.Size(34, 15);
            this.lbl_Quotation_Desc.TabIndex = 8;
            this.lbl_Quotation_Desc.Text = "Desc";
            // 
            // txt_Quotation_Desc
            // 
            this.txt_Quotation_Desc.Location = new System.Drawing.Point(111, 101);
            this.txt_Quotation_Desc.Name = "txt_Quotation_Desc";
            this.txt_Quotation_Desc.Size = new System.Drawing.Size(362, 22);
            this.txt_Quotation_Desc.TabIndex = 9;
            // 
            // lbl_Quotation_Currency
            // 
            this.lbl_Quotation_Currency.AutoSize = true;
            this.lbl_Quotation_Currency.Location = new System.Drawing.Point(10, 172);
            this.lbl_Quotation_Currency.Name = "lbl_Quotation_Currency";
            this.lbl_Quotation_Currency.Size = new System.Drawing.Size(56, 15);
            this.lbl_Quotation_Currency.TabIndex = 10;
            this.lbl_Quotation_Currency.Text = "Currency";
            // 
            // cob_Quotation_Currency
            // 
            this.cob_Quotation_Currency.FormattingEnabled = true;
            this.cob_Quotation_Currency.Location = new System.Drawing.Point(111, 169);
            this.cob_Quotation_Currency.Name = "cob_Quotation_Currency";
            this.cob_Quotation_Currency.Size = new System.Drawing.Size(121, 23);
            this.cob_Quotation_Currency.TabIndex = 11;
            this.cob_Quotation_Currency.SelectedIndexChanged += new System.EventHandler(this.cbox_Currency_SelectedIndexChanged);
            // 
            // lbl_Quotation_CurRate
            // 
            this.lbl_Quotation_CurRate.AutoSize = true;
            this.lbl_Quotation_CurRate.Location = new System.Drawing.Point(258, 173);
            this.lbl_Quotation_CurRate.Name = "lbl_Quotation_CurRate";
            this.lbl_Quotation_CurRate.Size = new System.Drawing.Size(53, 15);
            this.lbl_Quotation_CurRate.TabIndex = 12;
            this.lbl_Quotation_CurRate.Text = "Cur Rate";
            // 
            // txt_Quotation_CurRate
            // 
            this.txt_Quotation_CurRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_CurRate.Location = new System.Drawing.Point(317, 170);
            this.txt_Quotation_CurRate.Name = "txt_Quotation_CurRate";
            this.txt_Quotation_CurRate.Size = new System.Drawing.Size(79, 22);
            this.txt_Quotation_CurRate.TabIndex = 13;
            // 
            // lbl_Quotation_CostCenter
            // 
            this.lbl_Quotation_CostCenter.AutoSize = true;
            this.lbl_Quotation_CostCenter.Location = new System.Drawing.Point(504, 22);
            this.lbl_Quotation_CostCenter.Name = "lbl_Quotation_CostCenter";
            this.lbl_Quotation_CostCenter.Size = new System.Drawing.Size(70, 15);
            this.lbl_Quotation_CostCenter.TabIndex = 14;
            this.lbl_Quotation_CostCenter.Text = "Cost Center";
            // 
            // cob_Quotation_CostCenter
            // 
            this.cob_Quotation_CostCenter.FormattingEnabled = true;
            this.cob_Quotation_CostCenter.Location = new System.Drawing.Point(583, 16);
            this.cob_Quotation_CostCenter.Name = "cob_Quotation_CostCenter";
            this.cob_Quotation_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_Quotation_CostCenter.TabIndex = 15;
            // 
            // lbl_Quotation_CustID
            // 
            this.lbl_Quotation_CustID.AutoSize = true;
            this.lbl_Quotation_CustID.Location = new System.Drawing.Point(504, 52);
            this.lbl_Quotation_CustID.Name = "lbl_Quotation_CustID";
            this.lbl_Quotation_CustID.Size = new System.Drawing.Size(74, 15);
            this.lbl_Quotation_CustID.TabIndex = 16;
            this.lbl_Quotation_CustID.Text = "Customer ID";
            // 
            // gb_Quotation_PaymentMode
            // 
            this.gb_Quotation_PaymentMode.Controls.Add(this.rb_Quotation_Credit);
            this.gb_Quotation_PaymentMode.Controls.Add(this.rb_Quotation_Cash);
            this.gb_Quotation_PaymentMode.Location = new System.Drawing.Point(580, 82);
            this.gb_Quotation_PaymentMode.Name = "gb_Quotation_PaymentMode";
            this.gb_Quotation_PaymentMode.Size = new System.Drawing.Size(172, 41);
            this.gb_Quotation_PaymentMode.TabIndex = 17;
            this.gb_Quotation_PaymentMode.TabStop = false;
            this.gb_Quotation_PaymentMode.Text = "Payment Mode";
            // 
            // rb_Quotation_Credit
            // 
            this.rb_Quotation_Credit.AutoSize = true;
            this.rb_Quotation_Credit.Location = new System.Drawing.Point(104, 16);
            this.rb_Quotation_Credit.Name = "rb_Quotation_Credit";
            this.rb_Quotation_Credit.Size = new System.Drawing.Size(57, 19);
            this.rb_Quotation_Credit.TabIndex = 1;
            this.rb_Quotation_Credit.Text = "Credit";
            this.rb_Quotation_Credit.UseVisualStyleBackColor = true;
            // 
            // rb_Quotation_Cash
            // 
            this.rb_Quotation_Cash.AutoSize = true;
            this.rb_Quotation_Cash.Checked = true;
            this.rb_Quotation_Cash.Location = new System.Drawing.Point(13, 16);
            this.rb_Quotation_Cash.Name = "rb_Quotation_Cash";
            this.rb_Quotation_Cash.Size = new System.Drawing.Size(52, 19);
            this.rb_Quotation_Cash.TabIndex = 0;
            this.rb_Quotation_Cash.TabStop = true;
            this.rb_Quotation_Cash.Text = "Cash";
            this.rb_Quotation_Cash.UseVisualStyleBackColor = true;
            // 
            // lbl_Quotation_CustTRN
            // 
            this.lbl_Quotation_CustTRN.AutoSize = true;
            this.lbl_Quotation_CustTRN.Location = new System.Drawing.Point(713, 50);
            this.lbl_Quotation_CustTRN.Name = "lbl_Quotation_CustTRN";
            this.lbl_Quotation_CustTRN.Size = new System.Drawing.Size(60, 15);
            this.lbl_Quotation_CustTRN.TabIndex = 18;
            this.lbl_Quotation_CustTRN.Text = "Cust TRN";
            // 
            // txt_Quotation_CustID
            // 
            this.txt_Quotation_CustID.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_CustID.Location = new System.Drawing.Point(583, 45);
            this.txt_Quotation_CustID.Name = "txt_Quotation_CustID";
            this.txt_Quotation_CustID.Size = new System.Drawing.Size(121, 22);
            this.txt_Quotation_CustID.TabIndex = 19;
            // 
            // cb_Quotation_VATApplicable
            // 
            this.cb_Quotation_VATApplicable.AutoSize = true;
            this.cb_Quotation_VATApplicable.Location = new System.Drawing.Point(825, 12);
            this.cb_Quotation_VATApplicable.Name = "cb_Quotation_VATApplicable";
            this.cb_Quotation_VATApplicable.Size = new System.Drawing.Size(126, 19);
            this.cb_Quotation_VATApplicable.TabIndex = 20;
            this.cb_Quotation_VATApplicable.Text = "VAT APPLICABLE";
            this.cb_Quotation_VATApplicable.UseVisualStyleBackColor = true;
            // 
            // txt_Quotation_CustTRN
            // 
            this.txt_Quotation_CustTRN.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_CustTRN.Location = new System.Drawing.Point(779, 45);
            this.txt_Quotation_CustTRN.Name = "txt_Quotation_CustTRN";
            this.txt_Quotation_CustTRN.Size = new System.Drawing.Size(172, 22);
            this.txt_Quotation_CustTRN.TabIndex = 21;
            // 
            // cb_Quotation_ListAllItem
            // 
            this.cb_Quotation_ListAllItem.AutoSize = true;
            this.cb_Quotation_ListAllItem.Location = new System.Drawing.Point(723, 172);
            this.cb_Quotation_ListAllItem.Name = "cb_Quotation_ListAllItem";
            this.cb_Quotation_ListAllItem.Size = new System.Drawing.Size(96, 19);
            this.cb_Quotation_ListAllItem.TabIndex = 22;
            this.cb_Quotation_ListAllItem.Text = "List All Items";
            this.cb_Quotation_ListAllItem.UseVisualStyleBackColor = true;
            // 
            // cb_Quotation_ListOneItem
            // 
            this.cb_Quotation_ListOneItem.AutoSize = true;
            this.cb_Quotation_ListOneItem.Location = new System.Drawing.Point(825, 172);
            this.cb_Quotation_ListOneItem.Name = "cb_Quotation_ListOneItem";
            this.cb_Quotation_ListOneItem.Size = new System.Drawing.Size(126, 19);
            this.cb_Quotation_ListOneItem.TabIndex = 23;
            this.cb_Quotation_ListOneItem.Text = "List Only One Item";
            this.cb_Quotation_ListOneItem.UseVisualStyleBackColor = true;
            // 
            // lbl_Quotation_Attn
            // 
            this.lbl_Quotation_Attn.AutoSize = true;
            this.lbl_Quotation_Attn.Location = new System.Drawing.Point(15, 135);
            this.lbl_Quotation_Attn.Name = "lbl_Quotation_Attn";
            this.lbl_Quotation_Attn.Size = new System.Drawing.Size(35, 15);
            this.lbl_Quotation_Attn.TabIndex = 24;
            this.lbl_Quotation_Attn.Text = "Attn:";
            // 
            // txt_Quotation_Attn
            // 
            this.txt_Quotation_Attn.Location = new System.Drawing.Point(111, 129);
            this.txt_Quotation_Attn.Name = "txt_Quotation_Attn";
            this.txt_Quotation_Attn.Size = new System.Drawing.Size(840, 36);
            this.txt_Quotation_Attn.TabIndex = 25;
            this.txt_Quotation_Attn.Text = "";
            // 
            // lbl_Quotation_Remarks
            // 
            this.lbl_Quotation_Remarks.AutoSize = true;
            this.lbl_Quotation_Remarks.Location = new System.Drawing.Point(9, 414);
            this.lbl_Quotation_Remarks.Name = "lbl_Quotation_Remarks";
            this.lbl_Quotation_Remarks.Size = new System.Drawing.Size(52, 15);
            this.lbl_Quotation_Remarks.TabIndex = 28;
            this.lbl_Quotation_Remarks.Text = "Remarks";
            // 
            // txt_Quotation_Remarks
            // 
            this.txt_Quotation_Remarks.Location = new System.Drawing.Point(67, 411);
            this.txt_Quotation_Remarks.Name = "txt_Quotation_Remarks";
            this.txt_Quotation_Remarks.Size = new System.Drawing.Size(455, 102);
            this.txt_Quotation_Remarks.TabIndex = 29;
            this.txt_Quotation_Remarks.Text = "";
            // 
            // lbl_Quotation_TotalQty
            // 
            this.lbl_Quotation_TotalQty.AutoSize = true;
            this.lbl_Quotation_TotalQty.Location = new System.Drawing.Point(528, 414);
            this.lbl_Quotation_TotalQty.Name = "lbl_Quotation_TotalQty";
            this.lbl_Quotation_TotalQty.Size = new System.Drawing.Size(57, 15);
            this.lbl_Quotation_TotalQty.TabIndex = 30;
            this.lbl_Quotation_TotalQty.Text = "Total Qty";
            // 
            // txt_Quotation_TotalQty
            // 
            this.txt_Quotation_TotalQty.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_TotalQty.Location = new System.Drawing.Point(531, 439);
            this.txt_Quotation_TotalQty.Name = "txt_Quotation_TotalQty";
            this.txt_Quotation_TotalQty.Size = new System.Drawing.Size(135, 22);
            this.txt_Quotation_TotalQty.TabIndex = 31;
            // 
            // lbl_Quotation_TotalVAT
            // 
            this.lbl_Quotation_TotalVAT.AutoSize = true;
            this.lbl_Quotation_TotalVAT.Location = new System.Drawing.Point(528, 467);
            this.lbl_Quotation_TotalVAT.Name = "lbl_Quotation_TotalVAT";
            this.lbl_Quotation_TotalVAT.Size = new System.Drawing.Size(60, 15);
            this.lbl_Quotation_TotalVAT.TabIndex = 32;
            this.lbl_Quotation_TotalVAT.Text = "Total VAT";
            // 
            // txt_Quotation_TotalVAT
            // 
            this.txt_Quotation_TotalVAT.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_TotalVAT.Location = new System.Drawing.Point(531, 491);
            this.txt_Quotation_TotalVAT.Name = "txt_Quotation_TotalVAT";
            this.txt_Quotation_TotalVAT.Size = new System.Drawing.Size(135, 22);
            this.txt_Quotation_TotalVAT.TabIndex = 33;
            // 
            // lbl_Quotation_TotalAmt
            // 
            this.lbl_Quotation_TotalAmt.AutoSize = true;
            this.lbl_Quotation_TotalAmt.Location = new System.Drawing.Point(693, 414);
            this.lbl_Quotation_TotalAmt.Name = "lbl_Quotation_TotalAmt";
            this.lbl_Quotation_TotalAmt.Size = new System.Drawing.Size(80, 15);
            this.lbl_Quotation_TotalAmt.TabIndex = 34;
            this.lbl_Quotation_TotalAmt.Text = "Total Amount";
            // 
            // txt_Quotation_TotalAmt
            // 
            this.txt_Quotation_TotalAmt.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_TotalAmt.Location = new System.Drawing.Point(783, 411);
            this.txt_Quotation_TotalAmt.Name = "txt_Quotation_TotalAmt";
            this.txt_Quotation_TotalAmt.Size = new System.Drawing.Size(168, 22);
            this.txt_Quotation_TotalAmt.TabIndex = 35;
            // 
            // lbl_Quotation_OtherCharges
            // 
            this.lbl_Quotation_OtherCharges.AutoSize = true;
            this.lbl_Quotation_OtherCharges.Location = new System.Drawing.Point(693, 442);
            this.lbl_Quotation_OtherCharges.Name = "lbl_Quotation_OtherCharges";
            this.lbl_Quotation_OtherCharges.Size = new System.Drawing.Size(84, 15);
            this.lbl_Quotation_OtherCharges.TabIndex = 36;
            this.lbl_Quotation_OtherCharges.Text = "Other Charges";
            // 
            // txt_Quotation_OtherCharges
            // 
            this.txt_Quotation_OtherCharges.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_OtherCharges.Location = new System.Drawing.Point(783, 439);
            this.txt_Quotation_OtherCharges.Name = "txt_Quotation_OtherCharges";
            this.txt_Quotation_OtherCharges.Size = new System.Drawing.Size(168, 22);
            this.txt_Quotation_OtherCharges.TabIndex = 37;
            // 
            // lbl_Quotation_Discount
            // 
            this.lbl_Quotation_Discount.AutoSize = true;
            this.lbl_Quotation_Discount.Location = new System.Drawing.Point(693, 470);
            this.lbl_Quotation_Discount.Name = "lbl_Quotation_Discount";
            this.lbl_Quotation_Discount.Size = new System.Drawing.Size(56, 15);
            this.lbl_Quotation_Discount.TabIndex = 38;
            this.lbl_Quotation_Discount.Text = "Discount";
            // 
            // txt_Quotation_Discount
            // 
            this.txt_Quotation_Discount.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_Discount.Location = new System.Drawing.Point(783, 467);
            this.txt_Quotation_Discount.Name = "txt_Quotation_Discount";
            this.txt_Quotation_Discount.Size = new System.Drawing.Size(168, 22);
            this.txt_Quotation_Discount.TabIndex = 39;
            // 
            // lbl_Quotation_NetAmt
            // 
            this.lbl_Quotation_NetAmt.AutoSize = true;
            this.lbl_Quotation_NetAmt.Location = new System.Drawing.Point(693, 498);
            this.lbl_Quotation_NetAmt.Name = "lbl_Quotation_NetAmt";
            this.lbl_Quotation_NetAmt.Size = new System.Drawing.Size(72, 15);
            this.lbl_Quotation_NetAmt.TabIndex = 40;
            this.lbl_Quotation_NetAmt.Text = "Net Amount";
            // 
            // txt_Quotation_NetAmt
            // 
            this.txt_Quotation_NetAmt.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Quotation_NetAmt.Location = new System.Drawing.Point(783, 495);
            this.txt_Quotation_NetAmt.Name = "txt_Quotation_NetAmt";
            this.txt_Quotation_NetAmt.Size = new System.Drawing.Size(168, 22);
            this.txt_Quotation_NetAmt.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ucFirstPreNextLast1);
            this.panel2.Controls.Add(this.ucTransactionLPO);
            this.panel2.Controls.Add(this.cb_Quotation_PrintWithoutItemPrice);
            this.panel2.Location = new System.Drawing.Point(12, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 52);
            this.panel2.TabIndex = 42;
            // 
            // cb_Quotation_PrintWithoutItemPrice
            // 
            this.cb_Quotation_PrintWithoutItemPrice.AutoSize = true;
            this.cb_Quotation_PrintWithoutItemPrice.Location = new System.Drawing.Point(657, 15);
            this.cb_Quotation_PrintWithoutItemPrice.Name = "cb_Quotation_PrintWithoutItemPrice";
            this.cb_Quotation_PrintWithoutItemPrice.Size = new System.Drawing.Size(153, 19);
            this.cb_Quotation_PrintWithoutItemPrice.TabIndex = 0;
            this.cb_Quotation_PrintWithoutItemPrice.Text = "Print Without Item Price";
            this.cb_Quotation_PrintWithoutItemPrice.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Quotation_ScanImage);
            this.panel3.Controls.Add(this.btn_Quotation_Browser);
            this.panel3.Controls.Add(this.cob_Quotation_SelectDevice);
            this.panel3.Controls.Add(this.lbl_Quotation_SelectDevice);
            this.panel3.Location = new System.Drawing.Point(974, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 463);
            this.panel3.TabIndex = 43;
            // 
            // btn_Quotation_ScanImage
            // 
            this.btn_Quotation_ScanImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Quotation_ScanImage.Location = new System.Drawing.Point(103, 421);
            this.btn_Quotation_ScanImage.Name = "btn_Quotation_ScanImage";
            this.btn_Quotation_ScanImage.Size = new System.Drawing.Size(93, 33);
            this.btn_Quotation_ScanImage.TabIndex = 38;
            this.btn_Quotation_ScanImage.Text = "Scan Image";
            this.btn_Quotation_ScanImage.UseVisualStyleBackColor = true;
            // 
            // btn_Quotation_Browser
            // 
            this.btn_Quotation_Browser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Quotation_Browser.Location = new System.Drawing.Point(6, 421);
            this.btn_Quotation_Browser.Name = "btn_Quotation_Browser";
            this.btn_Quotation_Browser.Size = new System.Drawing.Size(91, 33);
            this.btn_Quotation_Browser.TabIndex = 37;
            this.btn_Quotation_Browser.Text = "Browser";
            this.btn_Quotation_Browser.UseVisualStyleBackColor = true;
            // 
            // cob_Quotation_SelectDevice
            // 
            this.cob_Quotation_SelectDevice.FormattingEnabled = true;
            this.cob_Quotation_SelectDevice.Location = new System.Drawing.Point(6, 395);
            this.cob_Quotation_SelectDevice.Name = "cob_Quotation_SelectDevice";
            this.cob_Quotation_SelectDevice.Size = new System.Drawing.Size(190, 23);
            this.cob_Quotation_SelectDevice.TabIndex = 36;
            // 
            // lbl_Quotation_SelectDevice
            // 
            this.lbl_Quotation_SelectDevice.AutoSize = true;
            this.lbl_Quotation_SelectDevice.Location = new System.Drawing.Point(3, 376);
            this.lbl_Quotation_SelectDevice.Name = "lbl_Quotation_SelectDevice";
            this.lbl_Quotation_SelectDevice.Size = new System.Drawing.Size(79, 15);
            this.lbl_Quotation_SelectDevice.TabIndex = 35;
            this.lbl_Quotation_SelectDevice.Text = "Select Device";
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_item.Location = new System.Drawing.Point(13, 194);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.Size = new System.Drawing.Size(938, 210);
            this.dgv_item.TabIndex = 44;
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
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgv_list);
            this.pnlItem.Location = new System.Drawing.Point(279, 196);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(894, 315);
            this.pnlItem.TabIndex = 46;
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
            this.dgv_list.Size = new System.Drawing.Size(894, 315);
            this.dgv_list.TabIndex = 39;
            // 
            // txt_CustName
            // 
            this.txt_CustName.Location = new System.Drawing.Point(111, 45);
            this.txt_CustName.Name = "txt_CustName";
            this.txt_CustName.Size = new System.Drawing.Size(362, 22);
            this.txt_CustName.TabIndex = 45;
            this.txt_CustName.Tag = "CUSTOMER_LIST";
            // 
            // ucFirstPreNextLast1
            // 
            this.ucFirstPreNextLast1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucFirstPreNextLast1.Location = new System.Drawing.Point(850, 9);
            this.ucFirstPreNextLast1.Name = "ucFirstPreNextLast1";
            this.ucFirstPreNextLast1.Size = new System.Drawing.Size(307, 33);
            this.ucFirstPreNextLast1.TabIndex = 7;
            // 
            // ucTransactionLPO
            // 
            this.ucTransactionLPO.Location = new System.Drawing.Point(4, 6);
            this.ucTransactionLPO.Name = "ucTransactionLPO";
            this.ucTransactionLPO.Size = new System.Drawing.Size(605, 38);
            this.ucTransactionLPO.TabIndex = 6;
            // 
            // frm_Transactions_Quatation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1185, 579);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.txt_CustName);
            this.Controls.Add(this.dgv_item);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Quotation_NetAmt);
            this.Controls.Add(this.lbl_Quotation_NetAmt);
            this.Controls.Add(this.txt_Quotation_Discount);
            this.Controls.Add(this.lbl_Quotation_Discount);
            this.Controls.Add(this.txt_Quotation_OtherCharges);
            this.Controls.Add(this.lbl_Quotation_OtherCharges);
            this.Controls.Add(this.txt_Quotation_TotalAmt);
            this.Controls.Add(this.lbl_Quotation_TotalAmt);
            this.Controls.Add(this.txt_Quotation_TotalVAT);
            this.Controls.Add(this.lbl_Quotation_TotalVAT);
            this.Controls.Add(this.txt_Quotation_TotalQty);
            this.Controls.Add(this.lbl_Quotation_TotalQty);
            this.Controls.Add(this.txt_Quotation_Remarks);
            this.Controls.Add(this.lbl_Quotation_Remarks);
            this.Controls.Add(this.txt_Quotation_Attn);
            this.Controls.Add(this.lbl_Quotation_Attn);
            this.Controls.Add(this.cb_Quotation_ListOneItem);
            this.Controls.Add(this.cb_Quotation_ListAllItem);
            this.Controls.Add(this.txt_Quotation_CustTRN);
            this.Controls.Add(this.cb_Quotation_VATApplicable);
            this.Controls.Add(this.txt_Quotation_CustID);
            this.Controls.Add(this.lbl_Quotation_CustTRN);
            this.Controls.Add(this.gb_Quotation_PaymentMode);
            this.Controls.Add(this.lbl_Quotation_CustID);
            this.Controls.Add(this.cob_Quotation_CostCenter);
            this.Controls.Add(this.lbl_Quotation_CostCenter);
            this.Controls.Add(this.txt_Quotation_CurRate);
            this.Controls.Add(this.lbl_Quotation_CurRate);
            this.Controls.Add(this.cob_Quotation_Currency);
            this.Controls.Add(this.lbl_Quotation_Currency);
            this.Controls.Add(this.txt_Quotation_Desc);
            this.Controls.Add(this.lbl_Quotation_Desc);
            this.Controls.Add(this.txt_Quotation_CustRef);
            this.Controls.Add(this.lbl_Quotation_CustRef);
            this.Controls.Add(this.dt_Quotation_Date);
            this.Controls.Add(this.lbl_Quotation_Date);
            this.Controls.Add(this.lbl_Quotation_CustName);
            this.Controls.Add(this.txt_Quotation_InvoiceNo);
            this.Controls.Add(this.lbl_Quotation_InvoiceNo);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_Quatation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions Quatation";
            this.Load += new System.EventHandler(this.frm_Transactions_Quatation_Load);
            this.gb_Quotation_PaymentMode.ResumeLayout(false);
            this.gb_Quotation_PaymentMode.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Quotation_InvoiceNo;
        private System.Windows.Forms.TextBox txt_Quotation_InvoiceNo;
        private System.Windows.Forms.Label lbl_Quotation_CustName;
        private System.Windows.Forms.Label lbl_Quotation_Date;
        private System.Windows.Forms.DateTimePicker dt_Quotation_Date;
        private System.Windows.Forms.Label lbl_Quotation_CustRef;
        private System.Windows.Forms.TextBox txt_Quotation_CustRef;
        private System.Windows.Forms.Label lbl_Quotation_Desc;
        private System.Windows.Forms.TextBox txt_Quotation_Desc;
        private System.Windows.Forms.Label lbl_Quotation_Currency;
        private System.Windows.Forms.ComboBox cob_Quotation_Currency;
        private System.Windows.Forms.Label lbl_Quotation_CurRate;
        private System.Windows.Forms.TextBox txt_Quotation_CurRate;
        private System.Windows.Forms.Label lbl_Quotation_CostCenter;
        private System.Windows.Forms.ComboBox cob_Quotation_CostCenter;
        private System.Windows.Forms.Label lbl_Quotation_CustID;
        private System.Windows.Forms.GroupBox gb_Quotation_PaymentMode;
        private System.Windows.Forms.RadioButton rb_Quotation_Credit;
        private System.Windows.Forms.RadioButton rb_Quotation_Cash;
        private System.Windows.Forms.Label lbl_Quotation_CustTRN;
        private System.Windows.Forms.TextBox txt_Quotation_CustID;
        private System.Windows.Forms.CheckBox cb_Quotation_VATApplicable;
        private System.Windows.Forms.TextBox txt_Quotation_CustTRN;
        private System.Windows.Forms.CheckBox cb_Quotation_ListAllItem;
        private System.Windows.Forms.CheckBox cb_Quotation_ListOneItem;
        private System.Windows.Forms.Label lbl_Quotation_Attn;
        private System.Windows.Forms.RichTextBox txt_Quotation_Attn;
        private System.Windows.Forms.Label lbl_Quotation_Remarks;
        private System.Windows.Forms.RichTextBox txt_Quotation_Remarks;
        private System.Windows.Forms.Label lbl_Quotation_TotalQty;
        private System.Windows.Forms.TextBox txt_Quotation_TotalQty;
        private System.Windows.Forms.Label lbl_Quotation_TotalVAT;
        private System.Windows.Forms.TextBox txt_Quotation_TotalVAT;
        private System.Windows.Forms.Label lbl_Quotation_TotalAmt;
        private System.Windows.Forms.TextBox txt_Quotation_TotalAmt;
        private System.Windows.Forms.Label lbl_Quotation_OtherCharges;
        private System.Windows.Forms.TextBox txt_Quotation_OtherCharges;
        private System.Windows.Forms.Label lbl_Quotation_Discount;
        private System.Windows.Forms.TextBox txt_Quotation_Discount;
        private System.Windows.Forms.Label lbl_Quotation_NetAmt;
        private System.Windows.Forms.TextBox txt_Quotation_NetAmt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_Quotation_PrintWithoutItemPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Quotation_ScanImage;
        private System.Windows.Forms.Button btn_Quotation_Browser;
        private System.Windows.Forms.ComboBox cob_Quotation_SelectDevice;
        private System.Windows.Forms.Label lbl_Quotation_SelectDevice;
        private System.Windows.Forms.DataGridView dgv_item;
        private UControl.ucFirstPreNextLast ucFirstPreNextLast1;
        private UControl.ucTransaction ucTransactionLPO;
        private UControl.ucComboBox txt_CustName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Add;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_Delete;
        private System.Windows.Forms.Panel pnlItem;
        public System.Windows.Forms.DataGridView dgv_list;
    }
}