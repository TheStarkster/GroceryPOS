namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_ChequeInformation
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
            this.cb_ChequeInformation_DateFrom = new System.Windows.Forms.CheckBox();
            this.dt_ChequeInformation_To = new System.Windows.Forms.DateTimePicker();
            this.dt_ChequeInformation_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.cb_ChequeInformation_LedgerName = new System.Windows.Forms.CheckBox();
            this.lbl_ChequeInformation_To = new System.Windows.Forms.Label();
            this.cb_ChequeInformation_TransType = new System.Windows.Forms.CheckBox();
            this.cob_ChequeInformation_LedgerName = new System.Windows.Forms.ComboBox();
            this.cob_ChequeInformation_TransType = new System.Windows.Forms.ComboBox();
            this.cb_ChequeInformation_BankName = new System.Windows.Forms.CheckBox();
            this.cb_ChequeInformation_ChequeNo = new System.Windows.Forms.CheckBox();
            this.cob_ChequeInformation_BankName = new System.Windows.Forms.ComboBox();
            this.cob_ChequeInformation_ChequeNo = new System.Windows.Forms.ComboBox();
            this.cb_ChequeInformation_Aging = new System.Windows.Forms.CheckBox();
            this.txt_ChequeInformation_Aging = new System.Windows.Forms.TextBox();
            this.cob_ChequeInformation_CostCenter = new System.Windows.Forms.ComboBox();
            this.cb_ChequeInformation_CostCenter = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_ChequeInformation_All = new System.Windows.Forms.RadioButton();
            this.rb_ChequeInformation_Cleared = new System.Windows.Forms.RadioButton();
            this.rb_ChequeInformation_Pending = new System.Windows.Forms.RadioButton();
            this.btn_ChequeInformation_Search = new System.Windows.Forms.Button();
            this.btn_ChequeInformation_Print = new System.Windows.Forms.Button();
            this.GV_ChequeInformation_ChequeDetails = new System.Windows.Forms.DataGridView();
            this.lbl_ChequeInformation_PressF1ForChequePrinting = new System.Windows.Forms.Label();
            this.lbl_ChequeInformation_TotalBillPayment = new System.Windows.Forms.Label();
            this.txt_ChequeInformation_TotalBillPayment = new System.Windows.Forms.TextBox();
            this.txt_ChequeInformation_TotalBillReceipt = new System.Windows.Forms.TextBox();
            this.lbl_ChequeInformation_TotalBillReceipt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ChequeInformation_ChequeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ChequeInformation_Print);
            this.panel1.Controls.Add(this.btn_ChequeInformation_Search);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cob_ChequeInformation_CostCenter);
            this.panel1.Controls.Add(this.cb_ChequeInformation_CostCenter);
            this.panel1.Controls.Add(this.txt_ChequeInformation_Aging);
            this.panel1.Controls.Add(this.cb_ChequeInformation_Aging);
            this.panel1.Controls.Add(this.cob_ChequeInformation_ChequeNo);
            this.panel1.Controls.Add(this.cob_ChequeInformation_BankName);
            this.panel1.Controls.Add(this.cb_ChequeInformation_ChequeNo);
            this.panel1.Controls.Add(this.cb_ChequeInformation_BankName);
            this.panel1.Controls.Add(this.cob_ChequeInformation_TransType);
            this.panel1.Controls.Add(this.cob_ChequeInformation_LedgerName);
            this.panel1.Controls.Add(this.cb_ChequeInformation_TransType);
            this.panel1.Controls.Add(this.lbl_ChequeInformation_To);
            this.panel1.Controls.Add(this.dt_ChequeInformation_To);
            this.panel1.Controls.Add(this.dt_ChequeInformation_DateFrom);
            this.panel1.Controls.Add(this.cb_ChequeInformation_LedgerName);
            this.panel1.Controls.Add(this.cb_ChequeInformation_DateFrom);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 85);
            this.panel1.TabIndex = 0;
            // 
            // cb_ChequeInformation_DateFrom
            // 
            this.cb_ChequeInformation_DateFrom.AutoSize = true;
            this.cb_ChequeInformation_DateFrom.Location = new System.Drawing.Point(3, 15);
            this.cb_ChequeInformation_DateFrom.Name = "cb_ChequeInformation_DateFrom";
            this.cb_ChequeInformation_DateFrom.Size = new System.Drawing.Size(81, 19);
            this.cb_ChequeInformation_DateFrom.TabIndex = 11;
            this.cb_ChequeInformation_DateFrom.Text = "Date From";
            this.cb_ChequeInformation_DateFrom.UseVisualStyleBackColor = true;
            // 
            // dt_ChequeInformation_To
            // 
            this.dt_ChequeInformation_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ChequeInformation_To.Location = new System.Drawing.Point(81, 42);
            this.dt_ChequeInformation_To.Name = "dt_ChequeInformation_To";
            this.dt_ChequeInformation_To.Size = new System.Drawing.Size(101, 22);
            this.dt_ChequeInformation_To.TabIndex = 13;
            // 
            // dt_ChequeInformation_DateFrom
            // 
            this.dt_ChequeInformation_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ChequeInformation_DateFrom.Location = new System.Drawing.Point(81, 15);
            this.dt_ChequeInformation_DateFrom.Name = "dt_ChequeInformation_DateFrom";
            this.dt_ChequeInformation_DateFrom.Size = new System.Drawing.Size(101, 22);
            this.dt_ChequeInformation_DateFrom.TabIndex = 12;
            // 
            // cb_ChequeInformation_LedgerName
            // 
            this.cb_ChequeInformation_LedgerName.AutoSize = true;
            this.cb_ChequeInformation_LedgerName.Location = new System.Drawing.Point(188, 17);
            this.cb_ChequeInformation_LedgerName.Name = "cb_ChequeInformation_LedgerName";
            this.cb_ChequeInformation_LedgerName.Size = new System.Drawing.Size(96, 19);
            this.cb_ChequeInformation_LedgerName.TabIndex = 14;
            this.cb_ChequeInformation_LedgerName.Text = "Ledger Name";
            this.cb_ChequeInformation_LedgerName.UseVisualStyleBackColor = true;
            // 
            // lbl_ChequeInformation_To
            // 
            this.lbl_ChequeInformation_To.AutoSize = true;
            this.lbl_ChequeInformation_To.Location = new System.Drawing.Point(3, 46);
            this.lbl_ChequeInformation_To.Name = "lbl_ChequeInformation_To";
            this.lbl_ChequeInformation_To.Size = new System.Drawing.Size(21, 15);
            this.lbl_ChequeInformation_To.TabIndex = 15;
            this.lbl_ChequeInformation_To.Text = "To";
            // 
            // cb_ChequeInformation_TransType
            // 
            this.cb_ChequeInformation_TransType.AutoSize = true;
            this.cb_ChequeInformation_TransType.Location = new System.Drawing.Point(188, 45);
            this.cb_ChequeInformation_TransType.Name = "cb_ChequeInformation_TransType";
            this.cb_ChequeInformation_TransType.Size = new System.Drawing.Size(87, 19);
            this.cb_ChequeInformation_TransType.TabIndex = 16;
            this.cb_ChequeInformation_TransType.Text = "Trans Type";
            this.cb_ChequeInformation_TransType.UseVisualStyleBackColor = true;
            // 
            // cob_ChequeInformation_LedgerName
            // 
            this.cob_ChequeInformation_LedgerName.FormattingEnabled = true;
            this.cob_ChequeInformation_LedgerName.Location = new System.Drawing.Point(290, 17);
            this.cob_ChequeInformation_LedgerName.Name = "cob_ChequeInformation_LedgerName";
            this.cob_ChequeInformation_LedgerName.Size = new System.Drawing.Size(185, 23);
            this.cob_ChequeInformation_LedgerName.TabIndex = 17;
            // 
            // cob_ChequeInformation_TransType
            // 
            this.cob_ChequeInformation_TransType.FormattingEnabled = true;
            this.cob_ChequeInformation_TransType.Location = new System.Drawing.Point(290, 44);
            this.cob_ChequeInformation_TransType.Name = "cob_ChequeInformation_TransType";
            this.cob_ChequeInformation_TransType.Size = new System.Drawing.Size(150, 23);
            this.cob_ChequeInformation_TransType.TabIndex = 18;
            // 
            // cb_ChequeInformation_BankName
            // 
            this.cb_ChequeInformation_BankName.AutoSize = true;
            this.cb_ChequeInformation_BankName.Location = new System.Drawing.Point(481, 19);
            this.cb_ChequeInformation_BankName.Name = "cb_ChequeInformation_BankName";
            this.cb_ChequeInformation_BankName.Size = new System.Drawing.Size(86, 19);
            this.cb_ChequeInformation_BankName.TabIndex = 19;
            this.cb_ChequeInformation_BankName.Text = "Bank Name";
            this.cb_ChequeInformation_BankName.UseVisualStyleBackColor = true;
            // 
            // cb_ChequeInformation_ChequeNo
            // 
            this.cb_ChequeInformation_ChequeNo.AutoSize = true;
            this.cb_ChequeInformation_ChequeNo.Location = new System.Drawing.Point(446, 48);
            this.cb_ChequeInformation_ChequeNo.Name = "cb_ChequeInformation_ChequeNo";
            this.cb_ChequeInformation_ChequeNo.Size = new System.Drawing.Size(86, 19);
            this.cb_ChequeInformation_ChequeNo.TabIndex = 20;
            this.cb_ChequeInformation_ChequeNo.Text = "Cheque No";
            this.cb_ChequeInformation_ChequeNo.UseVisualStyleBackColor = true;
            // 
            // cob_ChequeInformation_BankName
            // 
            this.cob_ChequeInformation_BankName.FormattingEnabled = true;
            this.cob_ChequeInformation_BankName.Location = new System.Drawing.Point(573, 15);
            this.cob_ChequeInformation_BankName.Name = "cob_ChequeInformation_BankName";
            this.cob_ChequeInformation_BankName.Size = new System.Drawing.Size(205, 23);
            this.cob_ChequeInformation_BankName.TabIndex = 21;
            // 
            // cob_ChequeInformation_ChequeNo
            // 
            this.cob_ChequeInformation_ChequeNo.FormattingEnabled = true;
            this.cob_ChequeInformation_ChequeNo.Location = new System.Drawing.Point(538, 44);
            this.cob_ChequeInformation_ChequeNo.Name = "cob_ChequeInformation_ChequeNo";
            this.cob_ChequeInformation_ChequeNo.Size = new System.Drawing.Size(87, 23);
            this.cob_ChequeInformation_ChequeNo.TabIndex = 22;
            // 
            // cb_ChequeInformation_Aging
            // 
            this.cb_ChequeInformation_Aging.AutoSize = true;
            this.cb_ChequeInformation_Aging.Location = new System.Drawing.Point(631, 46);
            this.cb_ChequeInformation_Aging.Name = "cb_ChequeInformation_Aging";
            this.cb_ChequeInformation_Aging.Size = new System.Drawing.Size(60, 19);
            this.cb_ChequeInformation_Aging.TabIndex = 23;
            this.cb_ChequeInformation_Aging.Text = "Aging";
            this.cb_ChequeInformation_Aging.UseVisualStyleBackColor = true;
            // 
            // txt_ChequeInformation_Aging
            // 
            this.txt_ChequeInformation_Aging.Location = new System.Drawing.Point(700, 43);
            this.txt_ChequeInformation_Aging.Name = "txt_ChequeInformation_Aging";
            this.txt_ChequeInformation_Aging.Size = new System.Drawing.Size(78, 22);
            this.txt_ChequeInformation_Aging.TabIndex = 24;
            // 
            // cob_ChequeInformation_CostCenter
            // 
            this.cob_ChequeInformation_CostCenter.FormattingEnabled = true;
            this.cob_ChequeInformation_CostCenter.Location = new System.Drawing.Point(784, 42);
            this.cob_ChequeInformation_CostCenter.Name = "cob_ChequeInformation_CostCenter";
            this.cob_ChequeInformation_CostCenter.Size = new System.Drawing.Size(89, 23);
            this.cob_ChequeInformation_CostCenter.TabIndex = 26;
            // 
            // cb_ChequeInformation_CostCenter
            // 
            this.cb_ChequeInformation_CostCenter.AutoSize = true;
            this.cb_ChequeInformation_CostCenter.Location = new System.Drawing.Point(784, 19);
            this.cb_ChequeInformation_CostCenter.Name = "cb_ChequeInformation_CostCenter";
            this.cb_ChequeInformation_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_ChequeInformation_CostCenter.TabIndex = 25;
            this.cb_ChequeInformation_CostCenter.Text = "Cost Center";
            this.cb_ChequeInformation_CostCenter.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_ChequeInformation_Pending);
            this.panel2.Controls.Add(this.rb_ChequeInformation_Cleared);
            this.panel2.Controls.Add(this.rb_ChequeInformation_All);
            this.panel2.Location = new System.Drawing.Point(879, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 63);
            this.panel2.TabIndex = 27;
            // 
            // rb_ChequeInformation_All
            // 
            this.rb_ChequeInformation_All.AutoSize = true;
            this.rb_ChequeInformation_All.Location = new System.Drawing.Point(4, 6);
            this.rb_ChequeInformation_All.Name = "rb_ChequeInformation_All";
            this.rb_ChequeInformation_All.Size = new System.Drawing.Size(41, 19);
            this.rb_ChequeInformation_All.TabIndex = 0;
            this.rb_ChequeInformation_All.TabStop = true;
            this.rb_ChequeInformation_All.Text = "All";
            this.rb_ChequeInformation_All.UseVisualStyleBackColor = true;
            // 
            // rb_ChequeInformation_Cleared
            // 
            this.rb_ChequeInformation_Cleared.AutoSize = true;
            this.rb_ChequeInformation_Cleared.Location = new System.Drawing.Point(66, 6);
            this.rb_ChequeInformation_Cleared.Name = "rb_ChequeInformation_Cleared";
            this.rb_ChequeInformation_Cleared.Size = new System.Drawing.Size(65, 19);
            this.rb_ChequeInformation_Cleared.TabIndex = 1;
            this.rb_ChequeInformation_Cleared.TabStop = true;
            this.rb_ChequeInformation_Cleared.Text = "Cleared";
            this.rb_ChequeInformation_Cleared.UseVisualStyleBackColor = true;
            // 
            // rb_ChequeInformation_Pending
            // 
            this.rb_ChequeInformation_Pending.AutoSize = true;
            this.rb_ChequeInformation_Pending.Location = new System.Drawing.Point(4, 32);
            this.rb_ChequeInformation_Pending.Name = "rb_ChequeInformation_Pending";
            this.rb_ChequeInformation_Pending.Size = new System.Drawing.Size(69, 19);
            this.rb_ChequeInformation_Pending.TabIndex = 2;
            this.rb_ChequeInformation_Pending.TabStop = true;
            this.rb_ChequeInformation_Pending.Text = "Pending";
            this.rb_ChequeInformation_Pending.UseVisualStyleBackColor = true;
            // 
            // btn_ChequeInformation_Search
            // 
            this.btn_ChequeInformation_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChequeInformation_Search.Location = new System.Drawing.Point(1019, 19);
            this.btn_ChequeInformation_Search.Name = "btn_ChequeInformation_Search";
            this.btn_ChequeInformation_Search.Size = new System.Drawing.Size(64, 48);
            this.btn_ChequeInformation_Search.TabIndex = 28;
            this.btn_ChequeInformation_Search.Text = "Search";
            this.btn_ChequeInformation_Search.UseVisualStyleBackColor = true;
            // 
            // btn_ChequeInformation_Print
            // 
            this.btn_ChequeInformation_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChequeInformation_Print.Location = new System.Drawing.Point(1089, 18);
            this.btn_ChequeInformation_Print.Name = "btn_ChequeInformation_Print";
            this.btn_ChequeInformation_Print.Size = new System.Drawing.Size(64, 48);
            this.btn_ChequeInformation_Print.TabIndex = 29;
            this.btn_ChequeInformation_Print.Text = "Print";
            this.btn_ChequeInformation_Print.UseVisualStyleBackColor = true;
            // 
            // GV_ChequeInformation_ChequeDetails
            // 
            this.GV_ChequeInformation_ChequeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ChequeInformation_ChequeDetails.Location = new System.Drawing.Point(13, 105);
            this.GV_ChequeInformation_ChequeDetails.Name = "GV_ChequeInformation_ChequeDetails";
            this.GV_ChequeInformation_ChequeDetails.Size = new System.Drawing.Size(1160, 286);
            this.GV_ChequeInformation_ChequeDetails.TabIndex = 1;
            // 
            // lbl_ChequeInformation_PressF1ForChequePrinting
            // 
            this.lbl_ChequeInformation_PressF1ForChequePrinting.AutoSize = true;
            this.lbl_ChequeInformation_PressF1ForChequePrinting.Location = new System.Drawing.Point(13, 398);
            this.lbl_ChequeInformation_PressF1ForChequePrinting.Name = "lbl_ChequeInformation_PressF1ForChequePrinting";
            this.lbl_ChequeInformation_PressF1ForChequePrinting.Size = new System.Drawing.Size(162, 15);
            this.lbl_ChequeInformation_PressF1ForChequePrinting.TabIndex = 2;
            this.lbl_ChequeInformation_PressF1ForChequePrinting.Text = "Press F1 For Cheque Printing";
            // 
            // lbl_ChequeInformation_TotalBillPayment
            // 
            this.lbl_ChequeInformation_TotalBillPayment.AutoSize = true;
            this.lbl_ChequeInformation_TotalBillPayment.Location = new System.Drawing.Point(877, 400);
            this.lbl_ChequeInformation_TotalBillPayment.Name = "lbl_ChequeInformation_TotalBillPayment";
            this.lbl_ChequeInformation_TotalBillPayment.Size = new System.Drawing.Size(103, 15);
            this.lbl_ChequeInformation_TotalBillPayment.TabIndex = 3;
            this.lbl_ChequeInformation_TotalBillPayment.Text = "Total Bill Payment";
            // 
            // txt_ChequeInformation_TotalBillPayment
            // 
            this.txt_ChequeInformation_TotalBillPayment.Location = new System.Drawing.Point(986, 397);
            this.txt_ChequeInformation_TotalBillPayment.Name = "txt_ChequeInformation_TotalBillPayment";
            this.txt_ChequeInformation_TotalBillPayment.Size = new System.Drawing.Size(187, 22);
            this.txt_ChequeInformation_TotalBillPayment.TabIndex = 4;
            // 
            // txt_ChequeInformation_TotalBillReceipt
            // 
            this.txt_ChequeInformation_TotalBillReceipt.Location = new System.Drawing.Point(986, 425);
            this.txt_ChequeInformation_TotalBillReceipt.Name = "txt_ChequeInformation_TotalBillReceipt";
            this.txt_ChequeInformation_TotalBillReceipt.Size = new System.Drawing.Size(187, 22);
            this.txt_ChequeInformation_TotalBillReceipt.TabIndex = 6;
            // 
            // lbl_ChequeInformation_TotalBillReceipt
            // 
            this.lbl_ChequeInformation_TotalBillReceipt.AutoSize = true;
            this.lbl_ChequeInformation_TotalBillReceipt.Location = new System.Drawing.Point(877, 428);
            this.lbl_ChequeInformation_TotalBillReceipt.Name = "lbl_ChequeInformation_TotalBillReceipt";
            this.lbl_ChequeInformation_TotalBillReceipt.Size = new System.Drawing.Size(97, 15);
            this.lbl_ChequeInformation_TotalBillReceipt.TabIndex = 5;
            this.lbl_ChequeInformation_TotalBillReceipt.Text = "Total Bill Receipt";
            // 
            // frm_Accounts_ChequeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 457);
            this.Controls.Add(this.txt_ChequeInformation_TotalBillReceipt);
            this.Controls.Add(this.lbl_ChequeInformation_TotalBillReceipt);
            this.Controls.Add(this.txt_ChequeInformation_TotalBillPayment);
            this.Controls.Add(this.lbl_ChequeInformation_TotalBillPayment);
            this.Controls.Add(this.lbl_ChequeInformation_PressF1ForChequePrinting);
            this.Controls.Add(this.GV_ChequeInformation_ChequeDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Accounts_ChequeInformation";
            this.Text = "frm_Accounts_ChequeInformation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ChequeInformation_ChequeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_ChequeInformation_DateFrom;
        private System.Windows.Forms.DateTimePicker dt_ChequeInformation_To;
        private System.Windows.Forms.DateTimePicker dt_ChequeInformation_DateFrom;
        private System.Windows.Forms.CheckBox cb_ChequeInformation_LedgerName;
        private System.Windows.Forms.CheckBox cb_ChequeInformation_TransType;
        private System.Windows.Forms.Label lbl_ChequeInformation_To;
        private System.Windows.Forms.TextBox txt_ChequeInformation_Aging;
        private System.Windows.Forms.CheckBox cb_ChequeInformation_Aging;
        private System.Windows.Forms.ComboBox cob_ChequeInformation_ChequeNo;
        private System.Windows.Forms.ComboBox cob_ChequeInformation_BankName;
        private System.Windows.Forms.CheckBox cb_ChequeInformation_ChequeNo;
        private System.Windows.Forms.CheckBox cb_ChequeInformation_BankName;
        private System.Windows.Forms.ComboBox cob_ChequeInformation_TransType;
        private System.Windows.Forms.ComboBox cob_ChequeInformation_LedgerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_ChequeInformation_Pending;
        private System.Windows.Forms.RadioButton rb_ChequeInformation_Cleared;
        private System.Windows.Forms.RadioButton rb_ChequeInformation_All;
        private System.Windows.Forms.ComboBox cob_ChequeInformation_CostCenter;
        private System.Windows.Forms.CheckBox cb_ChequeInformation_CostCenter;
        private System.Windows.Forms.Button btn_ChequeInformation_Print;
        private System.Windows.Forms.Button btn_ChequeInformation_Search;
        private System.Windows.Forms.DataGridView GV_ChequeInformation_ChequeDetails;
        private System.Windows.Forms.Label lbl_ChequeInformation_PressF1ForChequePrinting;
        private System.Windows.Forms.Label lbl_ChequeInformation_TotalBillPayment;
        private System.Windows.Forms.TextBox txt_ChequeInformation_TotalBillPayment;
        private System.Windows.Forms.TextBox txt_ChequeInformation_TotalBillReceipt;
        private System.Windows.Forms.Label lbl_ChequeInformation_TotalBillReceipt;
    }
}