namespace Grocery.Admin.Reports
{
    partial class Frm_Report_InventoryTransactionReport
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
            this.gb_InventoryTransactionReport_TransactionDate = new System.Windows.Forms.GroupBox();
            this.dt_InventoryTransactionReport_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_InventoryTransactionReport_DateTo = new System.Windows.Forms.Label();
            this.dt_InventoryTransactionReport_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_InventoryTransactionReport_DateFrom = new System.Windows.Forms.Label();
            this.gb_InventoryTransactionReport_TransactionName = new System.Windows.Forms.GroupBox();
            this.cb_InventoryTransactionReport_WastageDisposal = new System.Windows.Forms.CheckBox();
            this.cb_InventoryTransactionReport_PurchaseReturn = new System.Windows.Forms.CheckBox();
            this.cb_InventoryTransactionReport_SalesReturn = new System.Windows.Forms.CheckBox();
            this.cb_InventoryTransactionReport_BTIn = new System.Windows.Forms.CheckBox();
            this.cb_InventoryTransactionReport_BTOut = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cb_InventoryTransactionReport_Purchase = new System.Windows.Forms.CheckBox();
            this.cb_InventoryTransactionReport_Sales = new System.Windows.Forms.CheckBox();
            this.gb_InventoryTransactionReport_TransactionType = new System.Windows.Forms.GroupBox();
            this.cb_InventoryTransactionReport_Cash = new System.Windows.Forms.CheckBox();
            this.cb_InventoryTransactionReport_PettyCash = new System.Windows.Forms.CheckBox();
            this.cb_InventoryTransactionReport_CreditCard = new System.Windows.Forms.CheckBox();
            this.cb_InventoryTransactionReport_Credit = new System.Windows.Forms.CheckBox();
            this.gb_InventoryTransactionReport_TransactionParty = new System.Windows.Forms.GroupBox();
            this.rb_InventoryTransactionReport_Supplier = new System.Windows.Forms.RadioButton();
            this.rb_InventoryTransactionReport_Customer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_InventoryTransactionReport_ItemIssueOrProducts = new System.Windows.Forms.Panel();
            this.rb_InventoryTransactionReport_Name = new System.Windows.Forms.RadioButton();
            this.rb_InventoryTransactionReport_Address = new System.Windows.Forms.RadioButton();
            this.btn_InventoryTransactionReport_SearchTransactionParty = new System.Windows.Forms.Button();
            this.txt_InventoryTransactionReport_SearchTransactonParty = new System.Windows.Forms.TextBox();
            this.gb_InventoryTransactionReport_Salesman = new System.Windows.Forms.GroupBox();
            this.cob_InventoryTransactionReport_Salesman = new System.Windows.Forms.ComboBox();
            this.cb_InventoryTransactionReport_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_InventoryTransactionReport_CostCenter = new System.Windows.Forms.ComboBox();
            this.btn_InventoryTransactionReport_Show = new System.Windows.Forms.Button();
            this.btn_InventoryTransactionReport_Print = new System.Windows.Forms.Button();
            this.btn_InventoryTransactionReport_Clear = new System.Windows.Forms.Button();
            this.GV_InventoryTransactionReport_TransactionDetails = new System.Windows.Forms.DataGridView();
            this.lbl_InventoryTransactionReport_PressF11ToView = new System.Windows.Forms.Label();
            this.gb_InventoryTransactionReport_TransactionDate.SuspendLayout();
            this.gb_InventoryTransactionReport_TransactionName.SuspendLayout();
            this.gb_InventoryTransactionReport_TransactionType.SuspendLayout();
            this.gb_InventoryTransactionReport_TransactionParty.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.SuspendLayout();
            this.gb_InventoryTransactionReport_Salesman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_InventoryTransactionReport_TransactionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_InventoryTransactionReport_TransactionDate
            // 
            this.gb_InventoryTransactionReport_TransactionDate.Controls.Add(this.dt_InventoryTransactionReport_DateTo);
            this.gb_InventoryTransactionReport_TransactionDate.Controls.Add(this.lbl_InventoryTransactionReport_DateTo);
            this.gb_InventoryTransactionReport_TransactionDate.Controls.Add(this.dt_InventoryTransactionReport_DateFrom);
            this.gb_InventoryTransactionReport_TransactionDate.Controls.Add(this.lbl_InventoryTransactionReport_DateFrom);
            this.gb_InventoryTransactionReport_TransactionDate.Location = new System.Drawing.Point(12, 12);
            this.gb_InventoryTransactionReport_TransactionDate.Name = "gb_InventoryTransactionReport_TransactionDate";
            this.gb_InventoryTransactionReport_TransactionDate.Size = new System.Drawing.Size(156, 100);
            this.gb_InventoryTransactionReport_TransactionDate.TabIndex = 0;
            this.gb_InventoryTransactionReport_TransactionDate.TabStop = false;
            this.gb_InventoryTransactionReport_TransactionDate.Text = "Transaction Date";
            // 
            // dt_InventoryTransactionReport_DateTo
            // 
            this.dt_InventoryTransactionReport_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_InventoryTransactionReport_DateTo.Location = new System.Drawing.Point(46, 58);
            this.dt_InventoryTransactionReport_DateTo.Name = "dt_InventoryTransactionReport_DateTo";
            this.dt_InventoryTransactionReport_DateTo.Size = new System.Drawing.Size(101, 22);
            this.dt_InventoryTransactionReport_DateTo.TabIndex = 3;
            // 
            // lbl_InventoryTransactionReport_DateTo
            // 
            this.lbl_InventoryTransactionReport_DateTo.AutoSize = true;
            this.lbl_InventoryTransactionReport_DateTo.Location = new System.Drawing.Point(6, 65);
            this.lbl_InventoryTransactionReport_DateTo.Name = "lbl_InventoryTransactionReport_DateTo";
            this.lbl_InventoryTransactionReport_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_InventoryTransactionReport_DateTo.TabIndex = 2;
            this.lbl_InventoryTransactionReport_DateTo.Text = "To";
            // 
            // dt_InventoryTransactionReport_DateFrom
            // 
            this.dt_InventoryTransactionReport_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_InventoryTransactionReport_DateFrom.Location = new System.Drawing.Point(46, 22);
            this.dt_InventoryTransactionReport_DateFrom.Name = "dt_InventoryTransactionReport_DateFrom";
            this.dt_InventoryTransactionReport_DateFrom.Size = new System.Drawing.Size(101, 22);
            this.dt_InventoryTransactionReport_DateFrom.TabIndex = 1;
            // 
            // lbl_InventoryTransactionReport_DateFrom
            // 
            this.lbl_InventoryTransactionReport_DateFrom.AutoSize = true;
            this.lbl_InventoryTransactionReport_DateFrom.Location = new System.Drawing.Point(6, 23);
            this.lbl_InventoryTransactionReport_DateFrom.Name = "lbl_InventoryTransactionReport_DateFrom";
            this.lbl_InventoryTransactionReport_DateFrom.Size = new System.Drawing.Size(34, 15);
            this.lbl_InventoryTransactionReport_DateFrom.TabIndex = 0;
            this.lbl_InventoryTransactionReport_DateFrom.Text = "From";
            // 
            // gb_InventoryTransactionReport_TransactionName
            // 
            this.gb_InventoryTransactionReport_TransactionName.Controls.Add(this.cb_InventoryTransactionReport_WastageDisposal);
            this.gb_InventoryTransactionReport_TransactionName.Controls.Add(this.cb_InventoryTransactionReport_PurchaseReturn);
            this.gb_InventoryTransactionReport_TransactionName.Controls.Add(this.cb_InventoryTransactionReport_SalesReturn);
            this.gb_InventoryTransactionReport_TransactionName.Controls.Add(this.cb_InventoryTransactionReport_BTIn);
            this.gb_InventoryTransactionReport_TransactionName.Controls.Add(this.cb_InventoryTransactionReport_BTOut);
            this.gb_InventoryTransactionReport_TransactionName.Controls.Add(this.checkBox3);
            this.gb_InventoryTransactionReport_TransactionName.Controls.Add(this.cb_InventoryTransactionReport_Purchase);
            this.gb_InventoryTransactionReport_TransactionName.Controls.Add(this.cb_InventoryTransactionReport_Sales);
            this.gb_InventoryTransactionReport_TransactionName.Location = new System.Drawing.Point(174, 12);
            this.gb_InventoryTransactionReport_TransactionName.Name = "gb_InventoryTransactionReport_TransactionName";
            this.gb_InventoryTransactionReport_TransactionName.Size = new System.Drawing.Size(327, 100);
            this.gb_InventoryTransactionReport_TransactionName.TabIndex = 1;
            this.gb_InventoryTransactionReport_TransactionName.TabStop = false;
            this.gb_InventoryTransactionReport_TransactionName.Text = "Transaction Name";
            // 
            // cb_InventoryTransactionReport_WastageDisposal
            // 
            this.cb_InventoryTransactionReport_WastageDisposal.AutoSize = true;
            this.cb_InventoryTransactionReport_WastageDisposal.Location = new System.Drawing.Point(204, 68);
            this.cb_InventoryTransactionReport_WastageDisposal.Name = "cb_InventoryTransactionReport_WastageDisposal";
            this.cb_InventoryTransactionReport_WastageDisposal.Size = new System.Drawing.Size(123, 19);
            this.cb_InventoryTransactionReport_WastageDisposal.TabIndex = 7;
            this.cb_InventoryTransactionReport_WastageDisposal.Text = "Wastage Disposal";
            this.cb_InventoryTransactionReport_WastageDisposal.UseVisualStyleBackColor = true;
            // 
            // cb_InventoryTransactionReport_PurchaseReturn
            // 
            this.cb_InventoryTransactionReport_PurchaseReturn.AutoSize = true;
            this.cb_InventoryTransactionReport_PurchaseReturn.Location = new System.Drawing.Point(204, 43);
            this.cb_InventoryTransactionReport_PurchaseReturn.Name = "cb_InventoryTransactionReport_PurchaseReturn";
            this.cb_InventoryTransactionReport_PurchaseReturn.Size = new System.Drawing.Size(114, 19);
            this.cb_InventoryTransactionReport_PurchaseReturn.TabIndex = 6;
            this.cb_InventoryTransactionReport_PurchaseReturn.Text = "Purchase Return";
            this.cb_InventoryTransactionReport_PurchaseReturn.UseVisualStyleBackColor = true;
            // 
            // cb_InventoryTransactionReport_SalesReturn
            // 
            this.cb_InventoryTransactionReport_SalesReturn.AutoSize = true;
            this.cb_InventoryTransactionReport_SalesReturn.Location = new System.Drawing.Point(204, 18);
            this.cb_InventoryTransactionReport_SalesReturn.Name = "cb_InventoryTransactionReport_SalesReturn";
            this.cb_InventoryTransactionReport_SalesReturn.Size = new System.Drawing.Size(93, 19);
            this.cb_InventoryTransactionReport_SalesReturn.TabIndex = 5;
            this.cb_InventoryTransactionReport_SalesReturn.Text = "Sales Return";
            this.cb_InventoryTransactionReport_SalesReturn.UseVisualStyleBackColor = true;
            // 
            // cb_InventoryTransactionReport_BTIn
            // 
            this.cb_InventoryTransactionReport_BTIn.AutoSize = true;
            this.cb_InventoryTransactionReport_BTIn.Location = new System.Drawing.Point(119, 43);
            this.cb_InventoryTransactionReport_BTIn.Name = "cb_InventoryTransactionReport_BTIn";
            this.cb_InventoryTransactionReport_BTIn.Size = new System.Drawing.Size(66, 19);
            this.cb_InventoryTransactionReport_BTIn.TabIndex = 4;
            this.cb_InventoryTransactionReport_BTIn.Text = "BT (IN)";
            this.cb_InventoryTransactionReport_BTIn.UseVisualStyleBackColor = true;
            // 
            // cb_InventoryTransactionReport_BTOut
            // 
            this.cb_InventoryTransactionReport_BTOut.AutoSize = true;
            this.cb_InventoryTransactionReport_BTOut.Location = new System.Drawing.Point(119, 18);
            this.cb_InventoryTransactionReport_BTOut.Name = "cb_InventoryTransactionReport_BTOut";
            this.cb_InventoryTransactionReport_BTOut.Size = new System.Drawing.Size(79, 19);
            this.cb_InventoryTransactionReport_BTOut.TabIndex = 3;
            this.cb_InventoryTransactionReport_BTOut.Text = "BT (OUT)";
            this.cb_InventoryTransactionReport_BTOut.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 69);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(139, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Item Issue / Products";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cb_InventoryTransactionReport_Purchase
            // 
            this.cb_InventoryTransactionReport_Purchase.AutoSize = true;
            this.cb_InventoryTransactionReport_Purchase.Location = new System.Drawing.Point(7, 44);
            this.cb_InventoryTransactionReport_Purchase.Name = "cb_InventoryTransactionReport_Purchase";
            this.cb_InventoryTransactionReport_Purchase.Size = new System.Drawing.Size(75, 19);
            this.cb_InventoryTransactionReport_Purchase.TabIndex = 1;
            this.cb_InventoryTransactionReport_Purchase.Text = "Purchase";
            this.cb_InventoryTransactionReport_Purchase.UseVisualStyleBackColor = true;
            // 
            // cb_InventoryTransactionReport_Sales
            // 
            this.cb_InventoryTransactionReport_Sales.AutoSize = true;
            this.cb_InventoryTransactionReport_Sales.Location = new System.Drawing.Point(7, 19);
            this.cb_InventoryTransactionReport_Sales.Name = "cb_InventoryTransactionReport_Sales";
            this.cb_InventoryTransactionReport_Sales.Size = new System.Drawing.Size(54, 19);
            this.cb_InventoryTransactionReport_Sales.TabIndex = 0;
            this.cb_InventoryTransactionReport_Sales.Text = "Sales";
            this.cb_InventoryTransactionReport_Sales.UseVisualStyleBackColor = true;
            // 
            // gb_InventoryTransactionReport_TransactionType
            // 
            this.gb_InventoryTransactionReport_TransactionType.Controls.Add(this.cb_InventoryTransactionReport_Credit);
            this.gb_InventoryTransactionReport_TransactionType.Controls.Add(this.cb_InventoryTransactionReport_CreditCard);
            this.gb_InventoryTransactionReport_TransactionType.Controls.Add(this.cb_InventoryTransactionReport_PettyCash);
            this.gb_InventoryTransactionReport_TransactionType.Controls.Add(this.cb_InventoryTransactionReport_Cash);
            this.gb_InventoryTransactionReport_TransactionType.Location = new System.Drawing.Point(507, 13);
            this.gb_InventoryTransactionReport_TransactionType.Name = "gb_InventoryTransactionReport_TransactionType";
            this.gb_InventoryTransactionReport_TransactionType.Size = new System.Drawing.Size(160, 100);
            this.gb_InventoryTransactionReport_TransactionType.TabIndex = 2;
            this.gb_InventoryTransactionReport_TransactionType.TabStop = false;
            this.gb_InventoryTransactionReport_TransactionType.Text = "Transaction Type";
            // 
            // cb_InventoryTransactionReport_Cash
            // 
            this.cb_InventoryTransactionReport_Cash.AutoSize = true;
            this.cb_InventoryTransactionReport_Cash.Location = new System.Drawing.Point(7, 17);
            this.cb_InventoryTransactionReport_Cash.Name = "cb_InventoryTransactionReport_Cash";
            this.cb_InventoryTransactionReport_Cash.Size = new System.Drawing.Size(53, 19);
            this.cb_InventoryTransactionReport_Cash.TabIndex = 0;
            this.cb_InventoryTransactionReport_Cash.Text = "Cash";
            this.cb_InventoryTransactionReport_Cash.UseVisualStyleBackColor = true;
            // 
            // cb_InventoryTransactionReport_PettyCash
            // 
            this.cb_InventoryTransactionReport_PettyCash.AutoSize = true;
            this.cb_InventoryTransactionReport_PettyCash.Location = new System.Drawing.Point(7, 43);
            this.cb_InventoryTransactionReport_PettyCash.Name = "cb_InventoryTransactionReport_PettyCash";
            this.cb_InventoryTransactionReport_PettyCash.Size = new System.Drawing.Size(84, 19);
            this.cb_InventoryTransactionReport_PettyCash.TabIndex = 1;
            this.cb_InventoryTransactionReport_PettyCash.Text = "Petty Cash";
            this.cb_InventoryTransactionReport_PettyCash.UseVisualStyleBackColor = true;
            // 
            // cb_InventoryTransactionReport_CreditCard
            // 
            this.cb_InventoryTransactionReport_CreditCard.AutoSize = true;
            this.cb_InventoryTransactionReport_CreditCard.Location = new System.Drawing.Point(7, 68);
            this.cb_InventoryTransactionReport_CreditCard.Name = "cb_InventoryTransactionReport_CreditCard";
            this.cb_InventoryTransactionReport_CreditCard.Size = new System.Drawing.Size(86, 19);
            this.cb_InventoryTransactionReport_CreditCard.TabIndex = 2;
            this.cb_InventoryTransactionReport_CreditCard.Text = "Credit Card";
            this.cb_InventoryTransactionReport_CreditCard.UseVisualStyleBackColor = true;
            // 
            // cb_InventoryTransactionReport_Credit
            // 
            this.cb_InventoryTransactionReport_Credit.AutoSize = true;
            this.cb_InventoryTransactionReport_Credit.Location = new System.Drawing.Point(100, 17);
            this.cb_InventoryTransactionReport_Credit.Name = "cb_InventoryTransactionReport_Credit";
            this.cb_InventoryTransactionReport_Credit.Size = new System.Drawing.Size(58, 19);
            this.cb_InventoryTransactionReport_Credit.TabIndex = 3;
            this.cb_InventoryTransactionReport_Credit.Text = "Credit";
            this.cb_InventoryTransactionReport_Credit.UseVisualStyleBackColor = true;
            // 
            // gb_InventoryTransactionReport_TransactionParty
            // 
            this.gb_InventoryTransactionReport_TransactionParty.Controls.Add(this.txt_InventoryTransactionReport_SearchTransactonParty);
            this.gb_InventoryTransactionReport_TransactionParty.Controls.Add(this.btn_InventoryTransactionReport_SearchTransactionParty);
            this.gb_InventoryTransactionReport_TransactionParty.Controls.Add(this.cb_InventoryTransactionReport_ItemIssueOrProducts);
            this.gb_InventoryTransactionReport_TransactionParty.Controls.Add(this.panel1);
            this.gb_InventoryTransactionReport_TransactionParty.Location = new System.Drawing.Point(673, 13);
            this.gb_InventoryTransactionReport_TransactionParty.Name = "gb_InventoryTransactionReport_TransactionParty";
            this.gb_InventoryTransactionReport_TransactionParty.Size = new System.Drawing.Size(355, 100);
            this.gb_InventoryTransactionReport_TransactionParty.TabIndex = 3;
            this.gb_InventoryTransactionReport_TransactionParty.TabStop = false;
            this.gb_InventoryTransactionReport_TransactionParty.Text = "Transaction Party";
            // 
            // rb_InventoryTransactionReport_Supplier
            // 
            this.rb_InventoryTransactionReport_Supplier.AutoSize = true;
            this.rb_InventoryTransactionReport_Supplier.Location = new System.Drawing.Point(3, 3);
            this.rb_InventoryTransactionReport_Supplier.Name = "rb_InventoryTransactionReport_Supplier";
            this.rb_InventoryTransactionReport_Supplier.Size = new System.Drawing.Size(69, 19);
            this.rb_InventoryTransactionReport_Supplier.TabIndex = 0;
            this.rb_InventoryTransactionReport_Supplier.TabStop = true;
            this.rb_InventoryTransactionReport_Supplier.Text = "Supplier";
            this.rb_InventoryTransactionReport_Supplier.UseVisualStyleBackColor = true;
            // 
            // rb_InventoryTransactionReport_Customer
            // 
            this.rb_InventoryTransactionReport_Customer.AutoSize = true;
            this.rb_InventoryTransactionReport_Customer.Location = new System.Drawing.Point(78, 3);
            this.rb_InventoryTransactionReport_Customer.Name = "rb_InventoryTransactionReport_Customer";
            this.rb_InventoryTransactionReport_Customer.Size = new System.Drawing.Size(76, 19);
            this.rb_InventoryTransactionReport_Customer.TabIndex = 1;
            this.rb_InventoryTransactionReport_Customer.TabStop = true;
            this.rb_InventoryTransactionReport_Customer.Text = "Customer";
            this.rb_InventoryTransactionReport_Customer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rb_InventoryTransactionReport_Supplier);
            this.panel1.Controls.Add(this.rb_InventoryTransactionReport_Customer);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 37);
            this.panel1.TabIndex = 2;
            // 
            // cb_InventoryTransactionReport_ItemIssueOrProducts
            // 
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.Controls.Add(this.rb_InventoryTransactionReport_Name);
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.Controls.Add(this.rb_InventoryTransactionReport_Address);
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.Location = new System.Drawing.Point(173, 21);
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.Name = "cb_InventoryTransactionReport_ItemIssueOrProducts";
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.Size = new System.Drawing.Size(139, 37);
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.TabIndex = 3;
            // 
            // rb_InventoryTransactionReport_Name
            // 
            this.rb_InventoryTransactionReport_Name.AutoSize = true;
            this.rb_InventoryTransactionReport_Name.Location = new System.Drawing.Point(3, 3);
            this.rb_InventoryTransactionReport_Name.Name = "rb_InventoryTransactionReport_Name";
            this.rb_InventoryTransactionReport_Name.Size = new System.Drawing.Size(55, 19);
            this.rb_InventoryTransactionReport_Name.TabIndex = 0;
            this.rb_InventoryTransactionReport_Name.TabStop = true;
            this.rb_InventoryTransactionReport_Name.Text = "Name";
            this.rb_InventoryTransactionReport_Name.UseVisualStyleBackColor = true;
            // 
            // rb_InventoryTransactionReport_Address
            // 
            this.rb_InventoryTransactionReport_Address.AutoSize = true;
            this.rb_InventoryTransactionReport_Address.Location = new System.Drawing.Point(64, 3);
            this.rb_InventoryTransactionReport_Address.Name = "rb_InventoryTransactionReport_Address";
            this.rb_InventoryTransactionReport_Address.Size = new System.Drawing.Size(71, 19);
            this.rb_InventoryTransactionReport_Address.TabIndex = 1;
            this.rb_InventoryTransactionReport_Address.TabStop = true;
            this.rb_InventoryTransactionReport_Address.Text = "Address";
            this.rb_InventoryTransactionReport_Address.UseVisualStyleBackColor = true;
            // 
            // btn_InventoryTransactionReport_SearchTransactionParty
            // 
            this.btn_InventoryTransactionReport_SearchTransactionParty.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_InventoryTransactionReport_SearchTransactionParty.Location = new System.Drawing.Point(318, 20);
            this.btn_InventoryTransactionReport_SearchTransactionParty.Name = "btn_InventoryTransactionReport_SearchTransactionParty";
            this.btn_InventoryTransactionReport_SearchTransactionParty.Size = new System.Drawing.Size(32, 38);
            this.btn_InventoryTransactionReport_SearchTransactionParty.TabIndex = 4;
            this.btn_InventoryTransactionReport_SearchTransactionParty.UseVisualStyleBackColor = true;
            // 
            // txt_InventoryTransactionReport_SearchTransactonParty
            // 
            this.txt_InventoryTransactionReport_SearchTransactonParty.Location = new System.Drawing.Point(7, 64);
            this.txt_InventoryTransactionReport_SearchTransactonParty.Name = "txt_InventoryTransactionReport_SearchTransactonParty";
            this.txt_InventoryTransactionReport_SearchTransactonParty.Size = new System.Drawing.Size(343, 22);
            this.txt_InventoryTransactionReport_SearchTransactonParty.TabIndex = 5;
            // 
            // gb_InventoryTransactionReport_Salesman
            // 
            this.gb_InventoryTransactionReport_Salesman.Controls.Add(this.cob_InventoryTransactionReport_Salesman);
            this.gb_InventoryTransactionReport_Salesman.Location = new System.Drawing.Point(1034, 68);
            this.gb_InventoryTransactionReport_Salesman.Name = "gb_InventoryTransactionReport_Salesman";
            this.gb_InventoryTransactionReport_Salesman.Size = new System.Drawing.Size(134, 44);
            this.gb_InventoryTransactionReport_Salesman.TabIndex = 4;
            this.gb_InventoryTransactionReport_Salesman.TabStop = false;
            this.gb_InventoryTransactionReport_Salesman.Text = "Salesman";
            // 
            // cob_InventoryTransactionReport_Salesman
            // 
            this.cob_InventoryTransactionReport_Salesman.FormattingEnabled = true;
            this.cob_InventoryTransactionReport_Salesman.Location = new System.Drawing.Point(6, 15);
            this.cob_InventoryTransactionReport_Salesman.Name = "cob_InventoryTransactionReport_Salesman";
            this.cob_InventoryTransactionReport_Salesman.Size = new System.Drawing.Size(121, 23);
            this.cob_InventoryTransactionReport_Salesman.TabIndex = 0;
            // 
            // cb_InventoryTransactionReport_CostCenter
            // 
            this.cb_InventoryTransactionReport_CostCenter.AutoSize = true;
            this.cb_InventoryTransactionReport_CostCenter.Location = new System.Drawing.Point(1139, 44);
            this.cb_InventoryTransactionReport_CostCenter.Name = "cb_InventoryTransactionReport_CostCenter";
            this.cb_InventoryTransactionReport_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_InventoryTransactionReport_CostCenter.TabIndex = 5;
            this.cb_InventoryTransactionReport_CostCenter.Text = "Cost Center";
            this.cb_InventoryTransactionReport_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_InventoryTransactionReport_CostCenter
            // 
            this.cob_InventoryTransactionReport_CostCenter.FormattingEnabled = true;
            this.cob_InventoryTransactionReport_CostCenter.Location = new System.Drawing.Point(1233, 42);
            this.cob_InventoryTransactionReport_CostCenter.Name = "cob_InventoryTransactionReport_CostCenter";
            this.cob_InventoryTransactionReport_CostCenter.Size = new System.Drawing.Size(115, 23);
            this.cob_InventoryTransactionReport_CostCenter.TabIndex = 6;
            // 
            // btn_InventoryTransactionReport_Show
            // 
            this.btn_InventoryTransactionReport_Show.Location = new System.Drawing.Point(1174, 69);
            this.btn_InventoryTransactionReport_Show.Name = "btn_InventoryTransactionReport_Show";
            this.btn_InventoryTransactionReport_Show.Size = new System.Drawing.Size(54, 44);
            this.btn_InventoryTransactionReport_Show.TabIndex = 7;
            this.btn_InventoryTransactionReport_Show.Text = "Show";
            this.btn_InventoryTransactionReport_Show.UseVisualStyleBackColor = true;
            // 
            // btn_InventoryTransactionReport_Print
            // 
            this.btn_InventoryTransactionReport_Print.Location = new System.Drawing.Point(1234, 68);
            this.btn_InventoryTransactionReport_Print.Name = "btn_InventoryTransactionReport_Print";
            this.btn_InventoryTransactionReport_Print.Size = new System.Drawing.Size(54, 44);
            this.btn_InventoryTransactionReport_Print.TabIndex = 8;
            this.btn_InventoryTransactionReport_Print.Text = "Print";
            this.btn_InventoryTransactionReport_Print.UseVisualStyleBackColor = true;
            // 
            // btn_InventoryTransactionReport_Clear
            // 
            this.btn_InventoryTransactionReport_Clear.Location = new System.Drawing.Point(1294, 68);
            this.btn_InventoryTransactionReport_Clear.Name = "btn_InventoryTransactionReport_Clear";
            this.btn_InventoryTransactionReport_Clear.Size = new System.Drawing.Size(54, 44);
            this.btn_InventoryTransactionReport_Clear.TabIndex = 9;
            this.btn_InventoryTransactionReport_Clear.Text = "Clear";
            this.btn_InventoryTransactionReport_Clear.UseVisualStyleBackColor = true;
            // 
            // GV_InventoryTransactionReport_TransactionDetails
            // 
            this.GV_InventoryTransactionReport_TransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_InventoryTransactionReport_TransactionDetails.Location = new System.Drawing.Point(12, 119);
            this.GV_InventoryTransactionReport_TransactionDetails.Name = "GV_InventoryTransactionReport_TransactionDetails";
            this.GV_InventoryTransactionReport_TransactionDetails.Size = new System.Drawing.Size(1336, 350);
            this.GV_InventoryTransactionReport_TransactionDetails.TabIndex = 10;
            // 
            // lbl_InventoryTransactionReport_PressF11ToView
            // 
            this.lbl_InventoryTransactionReport_PressF11ToView.AutoSize = true;
            this.lbl_InventoryTransactionReport_PressF11ToView.ForeColor = System.Drawing.Color.Red;
            this.lbl_InventoryTransactionReport_PressF11ToView.Location = new System.Drawing.Point(12, 476);
            this.lbl_InventoryTransactionReport_PressF11ToView.Name = "lbl_InventoryTransactionReport_PressF11ToView";
            this.lbl_InventoryTransactionReport_PressF11ToView.Size = new System.Drawing.Size(430, 15);
            this.lbl_InventoryTransactionReport_PressF11ToView.TabIndex = 11;
            this.lbl_InventoryTransactionReport_PressF11ToView.Text = "Press F11 To View Transaction Type Wise Total Or Exit From Total Sub Window";
            // 
            // Frm_Report_InventoryTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 519);
            this.Controls.Add(this.lbl_InventoryTransactionReport_PressF11ToView);
            this.Controls.Add(this.GV_InventoryTransactionReport_TransactionDetails);
            this.Controls.Add(this.btn_InventoryTransactionReport_Clear);
            this.Controls.Add(this.btn_InventoryTransactionReport_Print);
            this.Controls.Add(this.btn_InventoryTransactionReport_Show);
            this.Controls.Add(this.cob_InventoryTransactionReport_CostCenter);
            this.Controls.Add(this.cb_InventoryTransactionReport_CostCenter);
            this.Controls.Add(this.gb_InventoryTransactionReport_Salesman);
            this.Controls.Add(this.gb_InventoryTransactionReport_TransactionParty);
            this.Controls.Add(this.gb_InventoryTransactionReport_TransactionType);
            this.Controls.Add(this.gb_InventoryTransactionReport_TransactionName);
            this.Controls.Add(this.gb_InventoryTransactionReport_TransactionDate);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Report_InventoryTransactionReport";
            this.Text = "Frm_Report_InventoryTransactionReport";
            this.gb_InventoryTransactionReport_TransactionDate.ResumeLayout(false);
            this.gb_InventoryTransactionReport_TransactionDate.PerformLayout();
            this.gb_InventoryTransactionReport_TransactionName.ResumeLayout(false);
            this.gb_InventoryTransactionReport_TransactionName.PerformLayout();
            this.gb_InventoryTransactionReport_TransactionType.ResumeLayout(false);
            this.gb_InventoryTransactionReport_TransactionType.PerformLayout();
            this.gb_InventoryTransactionReport_TransactionParty.ResumeLayout(false);
            this.gb_InventoryTransactionReport_TransactionParty.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.ResumeLayout(false);
            this.cb_InventoryTransactionReport_ItemIssueOrProducts.PerformLayout();
            this.gb_InventoryTransactionReport_Salesman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_InventoryTransactionReport_TransactionDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_InventoryTransactionReport_TransactionDate;
        private System.Windows.Forms.DateTimePicker dt_InventoryTransactionReport_DateTo;
        private System.Windows.Forms.Label lbl_InventoryTransactionReport_DateTo;
        private System.Windows.Forms.DateTimePicker dt_InventoryTransactionReport_DateFrom;
        private System.Windows.Forms.Label lbl_InventoryTransactionReport_DateFrom;
        private System.Windows.Forms.GroupBox gb_InventoryTransactionReport_TransactionName;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_WastageDisposal;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_PurchaseReturn;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_SalesReturn;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_BTIn;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_BTOut;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_Purchase;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_Sales;
        private System.Windows.Forms.GroupBox gb_InventoryTransactionReport_TransactionType;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_Credit;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_CreditCard;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_PettyCash;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_Cash;
        private System.Windows.Forms.GroupBox gb_InventoryTransactionReport_TransactionParty;
        private System.Windows.Forms.TextBox txt_InventoryTransactionReport_SearchTransactonParty;
        private System.Windows.Forms.Button btn_InventoryTransactionReport_SearchTransactionParty;
        private System.Windows.Forms.Panel cb_InventoryTransactionReport_ItemIssueOrProducts;
        private System.Windows.Forms.RadioButton rb_InventoryTransactionReport_Name;
        private System.Windows.Forms.RadioButton rb_InventoryTransactionReport_Address;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_InventoryTransactionReport_Supplier;
        private System.Windows.Forms.RadioButton rb_InventoryTransactionReport_Customer;
        private System.Windows.Forms.GroupBox gb_InventoryTransactionReport_Salesman;
        private System.Windows.Forms.ComboBox cob_InventoryTransactionReport_Salesman;
        private System.Windows.Forms.CheckBox cb_InventoryTransactionReport_CostCenter;
        private System.Windows.Forms.ComboBox cob_InventoryTransactionReport_CostCenter;
        private System.Windows.Forms.Button btn_InventoryTransactionReport_Show;
        private System.Windows.Forms.Button btn_InventoryTransactionReport_Print;
        private System.Windows.Forms.Button btn_InventoryTransactionReport_Clear;
        private System.Windows.Forms.DataGridView GV_InventoryTransactionReport_TransactionDetails;
        private System.Windows.Forms.Label lbl_InventoryTransactionReport_PressF11ToView;
    }
}