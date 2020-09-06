namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_ClientOutstanding_Group
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
            this.gb_ClientOutstandingGroup_TransParty = new System.Windows.Forms.GroupBox();
            this.rb_ClientOutstandingGroup_Customer = new System.Windows.Forms.RadioButton();
            this.rb_ClientOutstandingGroup_Supplier = new System.Windows.Forms.RadioButton();
            this.lbl_ClientOutstandingGroup_PartyName = new System.Windows.Forms.Label();
            this.txt_ClientOutstandingGroup_PartyName = new System.Windows.Forms.TextBox();
            this.lbl_ClientOutstandingGroup_PartyID = new System.Windows.Forms.Label();
            this.txt_ClientOutstandingGroup_PartyID = new System.Windows.Forms.TextBox();
            this.lbl_ClientOutstandingGroup_CreditLimit = new System.Windows.Forms.Label();
            this.txt_ClientOutstandingGroup_CreditLimit = new System.Windows.Forms.TextBox();
            this.txt_ClientOutstandingGroup_NoOfDays = new System.Windows.Forms.TextBox();
            this.lbl_ClientOutstandingGroup_NoOfDays = new System.Windows.Forms.Label();
            this.cb_ClientOutstandingGroup_AsOnDate = new System.Windows.Forms.CheckBox();
            this.lbl_ClientOutstandingGroup_LedgerCode = new System.Windows.Forms.Label();
            this.txt_ClientOutstandingGroup_LedgerCode = new System.Windows.Forms.TextBox();
            this.lbl_ClientOutstandingGroup_PaymentTerms = new System.Windows.Forms.Label();
            this.txt_ClientOutstandingGroup_PaymentTerms = new System.Windows.Forms.TextBox();
            this.dt_ClientOutstandingGroup_AsOnDate = new System.Windows.Forms.DateTimePicker();
            this.btn_ClientOutstandingGroup_Search = new System.Windows.Forms.Button();
            this.btn_ClientOutstandingGroup_OutstandingStatement = new System.Windows.Forms.Button();
            this.cb_ClientOutstandingGroup_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_ClientOutstandingGroup_CostCenter = new System.Windows.Forms.ComboBox();
            this.GV_ClientOutstandingGroup_PartyDetails = new System.Windows.Forms.DataGridView();
            this.GV_ClientOutstandingGroup_InvoiceDetails = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_ClientOutstandingGroup_TransParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ClientOutstandingGroup_PartyDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ClientOutstandingGroup_InvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ClientOutstandingGroup_TransParty
            // 
            this.gb_ClientOutstandingGroup_TransParty.Controls.Add(this.rb_ClientOutstandingGroup_Supplier);
            this.gb_ClientOutstandingGroup_TransParty.Controls.Add(this.rb_ClientOutstandingGroup_Customer);
            this.gb_ClientOutstandingGroup_TransParty.Location = new System.Drawing.Point(13, 13);
            this.gb_ClientOutstandingGroup_TransParty.Name = "gb_ClientOutstandingGroup_TransParty";
            this.gb_ClientOutstandingGroup_TransParty.Size = new System.Drawing.Size(114, 86);
            this.gb_ClientOutstandingGroup_TransParty.TabIndex = 0;
            this.gb_ClientOutstandingGroup_TransParty.TabStop = false;
            this.gb_ClientOutstandingGroup_TransParty.Text = "Trans. Party";
            // 
            // rb_ClientOutstandingGroup_Customer
            // 
            this.rb_ClientOutstandingGroup_Customer.AutoSize = true;
            this.rb_ClientOutstandingGroup_Customer.Location = new System.Drawing.Point(7, 22);
            this.rb_ClientOutstandingGroup_Customer.Name = "rb_ClientOutstandingGroup_Customer";
            this.rb_ClientOutstandingGroup_Customer.Size = new System.Drawing.Size(76, 19);
            this.rb_ClientOutstandingGroup_Customer.TabIndex = 0;
            this.rb_ClientOutstandingGroup_Customer.TabStop = true;
            this.rb_ClientOutstandingGroup_Customer.Text = "Customer";
            this.rb_ClientOutstandingGroup_Customer.UseVisualStyleBackColor = true;
            // 
            // rb_ClientOutstandingGroup_Supplier
            // 
            this.rb_ClientOutstandingGroup_Supplier.AutoSize = true;
            this.rb_ClientOutstandingGroup_Supplier.Location = new System.Drawing.Point(7, 47);
            this.rb_ClientOutstandingGroup_Supplier.Name = "rb_ClientOutstandingGroup_Supplier";
            this.rb_ClientOutstandingGroup_Supplier.Size = new System.Drawing.Size(69, 19);
            this.rb_ClientOutstandingGroup_Supplier.TabIndex = 1;
            this.rb_ClientOutstandingGroup_Supplier.TabStop = true;
            this.rb_ClientOutstandingGroup_Supplier.Text = "Supplier";
            this.rb_ClientOutstandingGroup_Supplier.UseVisualStyleBackColor = true;
            // 
            // lbl_ClientOutstandingGroup_PartyName
            // 
            this.lbl_ClientOutstandingGroup_PartyName.AutoSize = true;
            this.lbl_ClientOutstandingGroup_PartyName.Location = new System.Drawing.Point(134, 23);
            this.lbl_ClientOutstandingGroup_PartyName.Name = "lbl_ClientOutstandingGroup_PartyName";
            this.lbl_ClientOutstandingGroup_PartyName.Size = new System.Drawing.Size(112, 15);
            this.lbl_ClientOutstandingGroup_PartyName.TabIndex = 1;
            this.lbl_ClientOutstandingGroup_PartyName.Text = "Party (Group) Name";
            // 
            // txt_ClientOutstandingGroup_PartyName
            // 
            this.txt_ClientOutstandingGroup_PartyName.Location = new System.Drawing.Point(252, 20);
            this.txt_ClientOutstandingGroup_PartyName.Name = "txt_ClientOutstandingGroup_PartyName";
            this.txt_ClientOutstandingGroup_PartyName.Size = new System.Drawing.Size(296, 22);
            this.txt_ClientOutstandingGroup_PartyName.TabIndex = 2;
            // 
            // lbl_ClientOutstandingGroup_PartyID
            // 
            this.lbl_ClientOutstandingGroup_PartyID.AutoSize = true;
            this.lbl_ClientOutstandingGroup_PartyID.Location = new System.Drawing.Point(134, 52);
            this.lbl_ClientOutstandingGroup_PartyID.Name = "lbl_ClientOutstandingGroup_PartyID";
            this.lbl_ClientOutstandingGroup_PartyID.Size = new System.Drawing.Size(95, 15);
            this.lbl_ClientOutstandingGroup_PartyID.TabIndex = 3;
            this.lbl_ClientOutstandingGroup_PartyID.Text = "Party (Group) ID";
            // 
            // txt_ClientOutstandingGroup_PartyID
            // 
            this.txt_ClientOutstandingGroup_PartyID.Location = new System.Drawing.Point(252, 48);
            this.txt_ClientOutstandingGroup_PartyID.Name = "txt_ClientOutstandingGroup_PartyID";
            this.txt_ClientOutstandingGroup_PartyID.Size = new System.Drawing.Size(100, 22);
            this.txt_ClientOutstandingGroup_PartyID.TabIndex = 4;
            // 
            // lbl_ClientOutstandingGroup_CreditLimit
            // 
            this.lbl_ClientOutstandingGroup_CreditLimit.AutoSize = true;
            this.lbl_ClientOutstandingGroup_CreditLimit.Location = new System.Drawing.Point(134, 79);
            this.lbl_ClientOutstandingGroup_CreditLimit.Name = "lbl_ClientOutstandingGroup_CreditLimit";
            this.lbl_ClientOutstandingGroup_CreditLimit.Size = new System.Drawing.Size(68, 15);
            this.lbl_ClientOutstandingGroup_CreditLimit.TabIndex = 5;
            this.lbl_ClientOutstandingGroup_CreditLimit.Text = "Credit Limit";
            // 
            // txt_ClientOutstandingGroup_CreditLimit
            // 
            this.txt_ClientOutstandingGroup_CreditLimit.Location = new System.Drawing.Point(252, 76);
            this.txt_ClientOutstandingGroup_CreditLimit.Name = "txt_ClientOutstandingGroup_CreditLimit";
            this.txt_ClientOutstandingGroup_CreditLimit.Size = new System.Drawing.Size(100, 22);
            this.txt_ClientOutstandingGroup_CreditLimit.TabIndex = 6;
            // 
            // txt_ClientOutstandingGroup_NoOfDays
            // 
            this.txt_ClientOutstandingGroup_NoOfDays.Location = new System.Drawing.Point(252, 104);
            this.txt_ClientOutstandingGroup_NoOfDays.Name = "txt_ClientOutstandingGroup_NoOfDays";
            this.txt_ClientOutstandingGroup_NoOfDays.Size = new System.Drawing.Size(100, 22);
            this.txt_ClientOutstandingGroup_NoOfDays.TabIndex = 7;
            // 
            // lbl_ClientOutstandingGroup_NoOfDays
            // 
            this.lbl_ClientOutstandingGroup_NoOfDays.AutoSize = true;
            this.lbl_ClientOutstandingGroup_NoOfDays.Location = new System.Drawing.Point(134, 107);
            this.lbl_ClientOutstandingGroup_NoOfDays.Name = "lbl_ClientOutstandingGroup_NoOfDays";
            this.lbl_ClientOutstandingGroup_NoOfDays.Size = new System.Drawing.Size(68, 15);
            this.lbl_ClientOutstandingGroup_NoOfDays.TabIndex = 8;
            this.lbl_ClientOutstandingGroup_NoOfDays.Text = "No.of Days";
            // 
            // cb_ClientOutstandingGroup_AsOnDate
            // 
            this.cb_ClientOutstandingGroup_AsOnDate.AutoSize = true;
            this.cb_ClientOutstandingGroup_AsOnDate.Location = new System.Drawing.Point(359, 49);
            this.cb_ClientOutstandingGroup_AsOnDate.Name = "cb_ClientOutstandingGroup_AsOnDate";
            this.cb_ClientOutstandingGroup_AsOnDate.Size = new System.Drawing.Size(87, 19);
            this.cb_ClientOutstandingGroup_AsOnDate.TabIndex = 9;
            this.cb_ClientOutstandingGroup_AsOnDate.Text = "As on Date";
            this.cb_ClientOutstandingGroup_AsOnDate.UseVisualStyleBackColor = true;
            // 
            // lbl_ClientOutstandingGroup_LedgerCode
            // 
            this.lbl_ClientOutstandingGroup_LedgerCode.AutoSize = true;
            this.lbl_ClientOutstandingGroup_LedgerCode.Location = new System.Drawing.Point(358, 79);
            this.lbl_ClientOutstandingGroup_LedgerCode.Name = "lbl_ClientOutstandingGroup_LedgerCode";
            this.lbl_ClientOutstandingGroup_LedgerCode.Size = new System.Drawing.Size(75, 15);
            this.lbl_ClientOutstandingGroup_LedgerCode.TabIndex = 10;
            this.lbl_ClientOutstandingGroup_LedgerCode.Text = "Ledger Code";
            // 
            // txt_ClientOutstandingGroup_LedgerCode
            // 
            this.txt_ClientOutstandingGroup_LedgerCode.Location = new System.Drawing.Point(455, 77);
            this.txt_ClientOutstandingGroup_LedgerCode.Name = "txt_ClientOutstandingGroup_LedgerCode";
            this.txt_ClientOutstandingGroup_LedgerCode.Size = new System.Drawing.Size(244, 22);
            this.txt_ClientOutstandingGroup_LedgerCode.TabIndex = 11;
            // 
            // lbl_ClientOutstandingGroup_PaymentTerms
            // 
            this.lbl_ClientOutstandingGroup_PaymentTerms.AutoSize = true;
            this.lbl_ClientOutstandingGroup_PaymentTerms.Location = new System.Drawing.Point(358, 107);
            this.lbl_ClientOutstandingGroup_PaymentTerms.Name = "lbl_ClientOutstandingGroup_PaymentTerms";
            this.lbl_ClientOutstandingGroup_PaymentTerms.Size = new System.Drawing.Size(88, 15);
            this.lbl_ClientOutstandingGroup_PaymentTerms.TabIndex = 12;
            this.lbl_ClientOutstandingGroup_PaymentTerms.Text = "Payment Terms";
            // 
            // txt_ClientOutstandingGroup_PaymentTerms
            // 
            this.txt_ClientOutstandingGroup_PaymentTerms.Location = new System.Drawing.Point(455, 105);
            this.txt_ClientOutstandingGroup_PaymentTerms.Name = "txt_ClientOutstandingGroup_PaymentTerms";
            this.txt_ClientOutstandingGroup_PaymentTerms.Size = new System.Drawing.Size(244, 22);
            this.txt_ClientOutstandingGroup_PaymentTerms.TabIndex = 13;
            // 
            // dt_ClientOutstandingGroup_AsOnDate
            // 
            this.dt_ClientOutstandingGroup_AsOnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ClientOutstandingGroup_AsOnDate.Location = new System.Drawing.Point(455, 49);
            this.dt_ClientOutstandingGroup_AsOnDate.Name = "dt_ClientOutstandingGroup_AsOnDate";
            this.dt_ClientOutstandingGroup_AsOnDate.Size = new System.Drawing.Size(93, 22);
            this.dt_ClientOutstandingGroup_AsOnDate.TabIndex = 14;
            // 
            // btn_ClientOutstandingGroup_Search
            // 
            this.btn_ClientOutstandingGroup_Search.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_ClientOutstandingGroup_Search.Location = new System.Drawing.Point(555, 20);
            this.btn_ClientOutstandingGroup_Search.Name = "btn_ClientOutstandingGroup_Search";
            this.btn_ClientOutstandingGroup_Search.Size = new System.Drawing.Size(52, 51);
            this.btn_ClientOutstandingGroup_Search.TabIndex = 15;
            this.btn_ClientOutstandingGroup_Search.UseVisualStyleBackColor = true;
            // 
            // btn_ClientOutstandingGroup_OutstandingStatement
            // 
            this.btn_ClientOutstandingGroup_OutstandingStatement.Location = new System.Drawing.Point(614, 20);
            this.btn_ClientOutstandingGroup_OutstandingStatement.Name = "btn_ClientOutstandingGroup_OutstandingStatement";
            this.btn_ClientOutstandingGroup_OutstandingStatement.Size = new System.Drawing.Size(85, 50);
            this.btn_ClientOutstandingGroup_OutstandingStatement.TabIndex = 16;
            this.btn_ClientOutstandingGroup_OutstandingStatement.Text = "Outstanding Statement";
            this.btn_ClientOutstandingGroup_OutstandingStatement.UseVisualStyleBackColor = true;
            // 
            // cb_ClientOutstandingGroup_CostCenter
            // 
            this.cb_ClientOutstandingGroup_CostCenter.AutoSize = true;
            this.cb_ClientOutstandingGroup_CostCenter.Location = new System.Drawing.Point(489, 133);
            this.cb_ClientOutstandingGroup_CostCenter.Name = "cb_ClientOutstandingGroup_CostCenter";
            this.cb_ClientOutstandingGroup_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_ClientOutstandingGroup_CostCenter.TabIndex = 17;
            this.cb_ClientOutstandingGroup_CostCenter.Text = "Cost Center";
            this.cb_ClientOutstandingGroup_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_ClientOutstandingGroup_CostCenter
            // 
            this.cob_ClientOutstandingGroup_CostCenter.FormattingEnabled = true;
            this.cob_ClientOutstandingGroup_CostCenter.Location = new System.Drawing.Point(585, 134);
            this.cob_ClientOutstandingGroup_CostCenter.Name = "cob_ClientOutstandingGroup_CostCenter";
            this.cob_ClientOutstandingGroup_CostCenter.Size = new System.Drawing.Size(114, 23);
            this.cob_ClientOutstandingGroup_CostCenter.TabIndex = 18;
            // 
            // GV_ClientOutstandingGroup_PartyDetails
            // 
            this.GV_ClientOutstandingGroup_PartyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ClientOutstandingGroup_PartyDetails.Location = new System.Drawing.Point(706, 20);
            this.GV_ClientOutstandingGroup_PartyDetails.Name = "GV_ClientOutstandingGroup_PartyDetails";
            this.GV_ClientOutstandingGroup_PartyDetails.Size = new System.Drawing.Size(349, 137);
            this.GV_ClientOutstandingGroup_PartyDetails.TabIndex = 19;
            // 
            // GV_ClientOutstandingGroup_InvoiceDetails
            // 
            this.GV_ClientOutstandingGroup_InvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ClientOutstandingGroup_InvoiceDetails.Location = new System.Drawing.Point(12, 173);
            this.GV_ClientOutstandingGroup_InvoiceDetails.Name = "GV_ClientOutstandingGroup_InvoiceDetails";
            this.GV_ClientOutstandingGroup_InvoiceDetails.Size = new System.Drawing.Size(1043, 314);
            this.GV_ClientOutstandingGroup_InvoiceDetails.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(955, 493);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(895, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Focus On Invoice No Press F11 To Get Payment Details";
            // 
            // frm_Accounts_ClientOutstanding_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 529);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GV_ClientOutstandingGroup_InvoiceDetails);
            this.Controls.Add(this.GV_ClientOutstandingGroup_PartyDetails);
            this.Controls.Add(this.cob_ClientOutstandingGroup_CostCenter);
            this.Controls.Add(this.cb_ClientOutstandingGroup_CostCenter);
            this.Controls.Add(this.btn_ClientOutstandingGroup_OutstandingStatement);
            this.Controls.Add(this.btn_ClientOutstandingGroup_Search);
            this.Controls.Add(this.dt_ClientOutstandingGroup_AsOnDate);
            this.Controls.Add(this.txt_ClientOutstandingGroup_PaymentTerms);
            this.Controls.Add(this.lbl_ClientOutstandingGroup_PaymentTerms);
            this.Controls.Add(this.txt_ClientOutstandingGroup_LedgerCode);
            this.Controls.Add(this.lbl_ClientOutstandingGroup_LedgerCode);
            this.Controls.Add(this.cb_ClientOutstandingGroup_AsOnDate);
            this.Controls.Add(this.lbl_ClientOutstandingGroup_NoOfDays);
            this.Controls.Add(this.txt_ClientOutstandingGroup_NoOfDays);
            this.Controls.Add(this.txt_ClientOutstandingGroup_CreditLimit);
            this.Controls.Add(this.lbl_ClientOutstandingGroup_CreditLimit);
            this.Controls.Add(this.txt_ClientOutstandingGroup_PartyID);
            this.Controls.Add(this.lbl_ClientOutstandingGroup_PartyID);
            this.Controls.Add(this.txt_ClientOutstandingGroup_PartyName);
            this.Controls.Add(this.lbl_ClientOutstandingGroup_PartyName);
            this.Controls.Add(this.gb_ClientOutstandingGroup_TransParty);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Accounts_ClientOutstanding_Group";
            this.Text = "frm_Accounts_ClientOutstanding_Group";
            this.gb_ClientOutstandingGroup_TransParty.ResumeLayout(false);
            this.gb_ClientOutstandingGroup_TransParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ClientOutstandingGroup_PartyDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ClientOutstandingGroup_InvoiceDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ClientOutstandingGroup_TransParty;
        private System.Windows.Forms.RadioButton rb_ClientOutstandingGroup_Supplier;
        private System.Windows.Forms.RadioButton rb_ClientOutstandingGroup_Customer;
        private System.Windows.Forms.Label lbl_ClientOutstandingGroup_PartyName;
        private System.Windows.Forms.TextBox txt_ClientOutstandingGroup_PartyName;
        private System.Windows.Forms.Label lbl_ClientOutstandingGroup_PartyID;
        private System.Windows.Forms.TextBox txt_ClientOutstandingGroup_PartyID;
        private System.Windows.Forms.Label lbl_ClientOutstandingGroup_CreditLimit;
        private System.Windows.Forms.TextBox txt_ClientOutstandingGroup_CreditLimit;
        private System.Windows.Forms.TextBox txt_ClientOutstandingGroup_NoOfDays;
        private System.Windows.Forms.Label lbl_ClientOutstandingGroup_NoOfDays;
        private System.Windows.Forms.CheckBox cb_ClientOutstandingGroup_AsOnDate;
        private System.Windows.Forms.Label lbl_ClientOutstandingGroup_LedgerCode;
        private System.Windows.Forms.TextBox txt_ClientOutstandingGroup_LedgerCode;
        private System.Windows.Forms.Label lbl_ClientOutstandingGroup_PaymentTerms;
        private System.Windows.Forms.TextBox txt_ClientOutstandingGroup_PaymentTerms;
        private System.Windows.Forms.DateTimePicker dt_ClientOutstandingGroup_AsOnDate;
        private System.Windows.Forms.Button btn_ClientOutstandingGroup_Search;
        private System.Windows.Forms.Button btn_ClientOutstandingGroup_OutstandingStatement;
        private System.Windows.Forms.CheckBox cb_ClientOutstandingGroup_CostCenter;
        private System.Windows.Forms.ComboBox cob_ClientOutstandingGroup_CostCenter;
        private System.Windows.Forms.DataGridView GV_ClientOutstandingGroup_PartyDetails;
        private System.Windows.Forms.DataGridView GV_ClientOutstandingGroup_InvoiceDetails;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}