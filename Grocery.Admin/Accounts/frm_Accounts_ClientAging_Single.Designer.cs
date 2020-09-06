namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_ClientAging_Single
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ClientAgingSingle_CustSupName = new System.Windows.Forms.Label();
            this.lbl_ClientAgingSingle_Customer = new System.Windows.Forms.RadioButton();
            this.lbl_ClientAgingSingle_Supplier = new System.Windows.Forms.RadioButton();
            this.lbl_ClientAgingSingle_CustSupID = new System.Windows.Forms.Label();
            this.txt_ClientAgingSingle_CustSupName = new System.Windows.Forms.TextBox();
            this.txt_ClientAgingSingle_CustSupID = new System.Windows.Forms.TextBox();
            this.lbl_ClientAgingSingle_LedgerCode = new System.Windows.Forms.Label();
            this.txt_ClientAgingSingle_LedgerCode = new System.Windows.Forms.TextBox();
            this.cob_ClientAgingSingle_CostCenter = new System.Windows.Forms.ComboBox();
            this.cb_ClientAgingSingle_CostCenter = new System.Windows.Forms.CheckBox();
            this.cb_ClientAgingSingle_DateRange = new System.Windows.Forms.CheckBox();
            this.dt_ClientAgingSingle_DateRange = new System.Windows.Forms.DateTimePicker();
            this.cb_ClientAgingSingle_SearchBy = new System.Windows.Forms.CheckBox();
            this.btn_ClientAgingSingle_Search = new System.Windows.Forms.Button();
            this.btn_ClientAgingSingle_Print = new System.Windows.Forms.Button();
            this.GV_ClientAgingSingle_ClientAgingDetails = new System.Windows.Forms.DataGridView();
            this.txt_ClientAgingSingle_Debit = new System.Windows.Forms.TextBox();
            this.txt_ClientAgingSingle_Credit = new System.Windows.Forms.TextBox();
            this.txt_ClientAgingSingle_Balance = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ClientAgingSingle_ClientAgingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GV_ClientAgingSingle_ClientAgingDetails);
            this.panel1.Controls.Add(this.btn_ClientAgingSingle_Print);
            this.panel1.Controls.Add(this.btn_ClientAgingSingle_Search);
            this.panel1.Controls.Add(this.cb_ClientAgingSingle_SearchBy);
            this.panel1.Controls.Add(this.dt_ClientAgingSingle_DateRange);
            this.panel1.Controls.Add(this.cb_ClientAgingSingle_DateRange);
            this.panel1.Controls.Add(this.cb_ClientAgingSingle_CostCenter);
            this.panel1.Controls.Add(this.cob_ClientAgingSingle_CostCenter);
            this.panel1.Controls.Add(this.txt_ClientAgingSingle_LedgerCode);
            this.panel1.Controls.Add(this.lbl_ClientAgingSingle_LedgerCode);
            this.panel1.Controls.Add(this.txt_ClientAgingSingle_CustSupID);
            this.panel1.Controls.Add(this.txt_ClientAgingSingle_CustSupName);
            this.panel1.Controls.Add(this.lbl_ClientAgingSingle_CustSupID);
            this.panel1.Controls.Add(this.lbl_ClientAgingSingle_Supplier);
            this.panel1.Controls.Add(this.lbl_ClientAgingSingle_Customer);
            this.panel1.Controls.Add(this.lbl_ClientAgingSingle_CustSupName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 359);
            this.panel1.TabIndex = 0;
            // 
            // lbl_ClientAgingSingle_CustSupName
            // 
            this.lbl_ClientAgingSingle_CustSupName.AutoSize = true;
            this.lbl_ClientAgingSingle_CustSupName.Location = new System.Drawing.Point(85, 15);
            this.lbl_ClientAgingSingle_CustSupName.Name = "lbl_ClientAgingSingle_CustSupName";
            this.lbl_ClientAgingSingle_CustSupName.Size = new System.Drawing.Size(144, 15);
            this.lbl_ClientAgingSingle_CustSupName.TabIndex = 0;
            this.lbl_ClientAgingSingle_CustSupName.Text = "Customer : Supplier Name";
            // 
            // lbl_ClientAgingSingle_Customer
            // 
            this.lbl_ClientAgingSingle_Customer.AutoSize = true;
            this.lbl_ClientAgingSingle_Customer.Location = new System.Drawing.Point(3, 12);
            this.lbl_ClientAgingSingle_Customer.Name = "lbl_ClientAgingSingle_Customer";
            this.lbl_ClientAgingSingle_Customer.Size = new System.Drawing.Size(76, 19);
            this.lbl_ClientAgingSingle_Customer.TabIndex = 1;
            this.lbl_ClientAgingSingle_Customer.TabStop = true;
            this.lbl_ClientAgingSingle_Customer.Text = "Customer";
            this.lbl_ClientAgingSingle_Customer.UseVisualStyleBackColor = true;
            // 
            // lbl_ClientAgingSingle_Supplier
            // 
            this.lbl_ClientAgingSingle_Supplier.AutoSize = true;
            this.lbl_ClientAgingSingle_Supplier.Location = new System.Drawing.Point(3, 37);
            this.lbl_ClientAgingSingle_Supplier.Name = "lbl_ClientAgingSingle_Supplier";
            this.lbl_ClientAgingSingle_Supplier.Size = new System.Drawing.Size(69, 19);
            this.lbl_ClientAgingSingle_Supplier.TabIndex = 2;
            this.lbl_ClientAgingSingle_Supplier.TabStop = true;
            this.lbl_ClientAgingSingle_Supplier.Text = "Supplier";
            this.lbl_ClientAgingSingle_Supplier.UseVisualStyleBackColor = true;
            // 
            // lbl_ClientAgingSingle_CustSupID
            // 
            this.lbl_ClientAgingSingle_CustSupID.AutoSize = true;
            this.lbl_ClientAgingSingle_CustSupID.Location = new System.Drawing.Point(85, 42);
            this.lbl_ClientAgingSingle_CustSupID.Name = "lbl_ClientAgingSingle_CustSupID";
            this.lbl_ClientAgingSingle_CustSupID.Size = new System.Drawing.Size(127, 15);
            this.lbl_ClientAgingSingle_CustSupID.TabIndex = 3;
            this.lbl_ClientAgingSingle_CustSupID.Text = "Customer : Supplier ID";
            // 
            // txt_ClientAgingSingle_CustSupName
            // 
            this.txt_ClientAgingSingle_CustSupName.Location = new System.Drawing.Point(235, 14);
            this.txt_ClientAgingSingle_CustSupName.Name = "txt_ClientAgingSingle_CustSupName";
            this.txt_ClientAgingSingle_CustSupName.Size = new System.Drawing.Size(265, 22);
            this.txt_ClientAgingSingle_CustSupName.TabIndex = 4;
            // 
            // txt_ClientAgingSingle_CustSupID
            // 
            this.txt_ClientAgingSingle_CustSupID.Location = new System.Drawing.Point(235, 40);
            this.txt_ClientAgingSingle_CustSupID.Name = "txt_ClientAgingSingle_CustSupID";
            this.txt_ClientAgingSingle_CustSupID.Size = new System.Drawing.Size(89, 22);
            this.txt_ClientAgingSingle_CustSupID.TabIndex = 5;
            // 
            // lbl_ClientAgingSingle_LedgerCode
            // 
            this.lbl_ClientAgingSingle_LedgerCode.AutoSize = true;
            this.lbl_ClientAgingSingle_LedgerCode.Location = new System.Drawing.Point(330, 43);
            this.lbl_ClientAgingSingle_LedgerCode.Name = "lbl_ClientAgingSingle_LedgerCode";
            this.lbl_ClientAgingSingle_LedgerCode.Size = new System.Drawing.Size(75, 15);
            this.lbl_ClientAgingSingle_LedgerCode.TabIndex = 6;
            this.lbl_ClientAgingSingle_LedgerCode.Text = "Ledger Code";
            // 
            // txt_ClientAgingSingle_LedgerCode
            // 
            this.txt_ClientAgingSingle_LedgerCode.Location = new System.Drawing.Point(411, 40);
            this.txt_ClientAgingSingle_LedgerCode.Name = "txt_ClientAgingSingle_LedgerCode";
            this.txt_ClientAgingSingle_LedgerCode.Size = new System.Drawing.Size(89, 22);
            this.txt_ClientAgingSingle_LedgerCode.TabIndex = 7;
            // 
            // cob_ClientAgingSingle_CostCenter
            // 
            this.cob_ClientAgingSingle_CostCenter.FormattingEnabled = true;
            this.cob_ClientAgingSingle_CostCenter.Location = new System.Drawing.Point(506, 40);
            this.cob_ClientAgingSingle_CostCenter.Name = "cob_ClientAgingSingle_CostCenter";
            this.cob_ClientAgingSingle_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_ClientAgingSingle_CostCenter.TabIndex = 8;
            // 
            // cb_ClientAgingSingle_CostCenter
            // 
            this.cb_ClientAgingSingle_CostCenter.AutoSize = true;
            this.cb_ClientAgingSingle_CostCenter.Location = new System.Drawing.Point(506, 15);
            this.cb_ClientAgingSingle_CostCenter.Name = "cb_ClientAgingSingle_CostCenter";
            this.cb_ClientAgingSingle_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_ClientAgingSingle_CostCenter.TabIndex = 9;
            this.cb_ClientAgingSingle_CostCenter.Text = "Cost Center";
            this.cb_ClientAgingSingle_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cb_ClientAgingSingle_DateRange
            // 
            this.cb_ClientAgingSingle_DateRange.AutoSize = true;
            this.cb_ClientAgingSingle_DateRange.Location = new System.Drawing.Point(601, 16);
            this.cb_ClientAgingSingle_DateRange.Name = "cb_ClientAgingSingle_DateRange";
            this.cb_ClientAgingSingle_DateRange.Size = new System.Drawing.Size(88, 19);
            this.cb_ClientAgingSingle_DateRange.TabIndex = 10;
            this.cb_ClientAgingSingle_DateRange.Text = "Date Range";
            this.cb_ClientAgingSingle_DateRange.UseVisualStyleBackColor = true;
            // 
            // dt_ClientAgingSingle_DateRange
            // 
            this.dt_ClientAgingSingle_DateRange.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ClientAgingSingle_DateRange.Location = new System.Drawing.Point(695, 13);
            this.dt_ClientAgingSingle_DateRange.Name = "dt_ClientAgingSingle_DateRange";
            this.dt_ClientAgingSingle_DateRange.Size = new System.Drawing.Size(96, 22);
            this.dt_ClientAgingSingle_DateRange.TabIndex = 11;
            // 
            // cb_ClientAgingSingle_SearchBy
            // 
            this.cb_ClientAgingSingle_SearchBy.AutoSize = true;
            this.cb_ClientAgingSingle_SearchBy.Location = new System.Drawing.Point(652, 42);
            this.cb_ClientAgingSingle_SearchBy.Name = "cb_ClientAgingSingle_SearchBy";
            this.cb_ClientAgingSingle_SearchBy.Size = new System.Drawing.Size(117, 19);
            this.cb_ClientAgingSingle_SearchBy.TabIndex = 12;
            this.cb_ClientAgingSingle_SearchBy.Text = "Search By As On";
            this.cb_ClientAgingSingle_SearchBy.UseVisualStyleBackColor = true;
            // 
            // btn_ClientAgingSingle_Search
            // 
            this.btn_ClientAgingSingle_Search.Location = new System.Drawing.Point(797, 10);
            this.btn_ClientAgingSingle_Search.Name = "btn_ClientAgingSingle_Search";
            this.btn_ClientAgingSingle_Search.Size = new System.Drawing.Size(107, 27);
            this.btn_ClientAgingSingle_Search.TabIndex = 38;
            this.btn_ClientAgingSingle_Search.Text = "Search";
            this.btn_ClientAgingSingle_Search.UseVisualStyleBackColor = true;
            // 
            // btn_ClientAgingSingle_Print
            // 
            this.btn_ClientAgingSingle_Print.Location = new System.Drawing.Point(797, 40);
            this.btn_ClientAgingSingle_Print.Name = "btn_ClientAgingSingle_Print";
            this.btn_ClientAgingSingle_Print.Size = new System.Drawing.Size(107, 27);
            this.btn_ClientAgingSingle_Print.TabIndex = 39;
            this.btn_ClientAgingSingle_Print.Text = "Print";
            this.btn_ClientAgingSingle_Print.UseVisualStyleBackColor = true;
            // 
            // GV_ClientAgingSingle_ClientAgingDetails
            // 
            this.GV_ClientAgingSingle_ClientAgingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ClientAgingSingle_ClientAgingDetails.Location = new System.Drawing.Point(4, 73);
            this.GV_ClientAgingSingle_ClientAgingDetails.Name = "GV_ClientAgingSingle_ClientAgingDetails";
            this.GV_ClientAgingSingle_ClientAgingDetails.Size = new System.Drawing.Size(900, 281);
            this.GV_ClientAgingSingle_ClientAgingDetails.TabIndex = 40;
            // 
            // txt_ClientAgingSingle_Debit
            // 
            this.txt_ClientAgingSingle_Debit.Location = new System.Drawing.Point(466, 387);
            this.txt_ClientAgingSingle_Debit.Name = "txt_ClientAgingSingle_Debit";
            this.txt_ClientAgingSingle_Debit.Size = new System.Drawing.Size(124, 22);
            this.txt_ClientAgingSingle_Debit.TabIndex = 41;
            // 
            // txt_ClientAgingSingle_Credit
            // 
            this.txt_ClientAgingSingle_Credit.Location = new System.Drawing.Point(596, 387);
            this.txt_ClientAgingSingle_Credit.Name = "txt_ClientAgingSingle_Credit";
            this.txt_ClientAgingSingle_Credit.Size = new System.Drawing.Size(124, 22);
            this.txt_ClientAgingSingle_Credit.TabIndex = 42;
            // 
            // txt_ClientAgingSingle_Balance
            // 
            this.txt_ClientAgingSingle_Balance.Location = new System.Drawing.Point(726, 387);
            this.txt_ClientAgingSingle_Balance.Name = "txt_ClientAgingSingle_Balance";
            this.txt_ClientAgingSingle_Balance.Size = new System.Drawing.Size(124, 22);
            this.txt_ClientAgingSingle_Balance.TabIndex = 43;
            // 
            // frm_Accounts_ClientAging_Single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 421);
            this.Controls.Add(this.txt_ClientAgingSingle_Balance);
            this.Controls.Add(this.txt_ClientAgingSingle_Credit);
            this.Controls.Add(this.txt_ClientAgingSingle_Debit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Accounts_ClientAging_Single";
            this.Text = "frm_Accounts_ClientAging_Single";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ClientAgingSingle_ClientAgingDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_ClientAgingSingle_SearchBy;
        private System.Windows.Forms.DateTimePicker dt_ClientAgingSingle_DateRange;
        private System.Windows.Forms.CheckBox cb_ClientAgingSingle_DateRange;
        private System.Windows.Forms.CheckBox cb_ClientAgingSingle_CostCenter;
        private System.Windows.Forms.ComboBox cob_ClientAgingSingle_CostCenter;
        private System.Windows.Forms.TextBox txt_ClientAgingSingle_LedgerCode;
        private System.Windows.Forms.Label lbl_ClientAgingSingle_LedgerCode;
        private System.Windows.Forms.TextBox txt_ClientAgingSingle_CustSupID;
        private System.Windows.Forms.TextBox txt_ClientAgingSingle_CustSupName;
        private System.Windows.Forms.Label lbl_ClientAgingSingle_CustSupID;
        private System.Windows.Forms.RadioButton lbl_ClientAgingSingle_Supplier;
        private System.Windows.Forms.RadioButton lbl_ClientAgingSingle_Customer;
        private System.Windows.Forms.Label lbl_ClientAgingSingle_CustSupName;
        private System.Windows.Forms.DataGridView GV_ClientAgingSingle_ClientAgingDetails;
        private System.Windows.Forms.Button btn_ClientAgingSingle_Print;
        private System.Windows.Forms.Button btn_ClientAgingSingle_Search;
        private System.Windows.Forms.TextBox txt_ClientAgingSingle_Debit;
        private System.Windows.Forms.TextBox txt_ClientAgingSingle_Credit;
        private System.Windows.Forms.TextBox txt_ClientAgingSingle_Balance;
    }
}