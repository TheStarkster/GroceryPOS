namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_PaymentReceiptReport
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
            this.dt_PaymentReceiptReport_DateTo = new System.Windows.Forms.DateTimePicker();
            this.dt_PaymentReceiptReport_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_PaymentReceiptReport_DateTo = new System.Windows.Forms.Label();
            this.lbl_PaymentReceiptReport_DateFrom = new System.Windows.Forms.Label();
            this.rb_PaymentReceiptReport_Receipt = new System.Windows.Forms.RadioButton();
            this.rb_PaymentReceiptReport_Payment = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_PaymentReceiptReport_PaymentID = new System.Windows.Forms.TextBox();
            this.rb_PaymentReceiptReport_InvoiceID = new System.Windows.Forms.RadioButton();
            this.rb_PaymentReceiptReport_PartyName = new System.Windows.Forms.RadioButton();
            this.rb_PaymentReceiptReport_PaymentID = new System.Windows.Forms.RadioButton();
            this.btn_PaymentReceiptReport_Search = new System.Windows.Forms.Button();
            this.cb_PaymentReceiptReport_FilterBySalesman = new System.Windows.Forms.CheckBox();
            this.cb_PaymentReceiptReport_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_PaymentReceiptReport_FilterBySalesman = new System.Windows.Forms.ComboBox();
            this.cob_PaymentReceiptReport_CostCenter = new System.Windows.Forms.ComboBox();
            this.btn_PaymentReceiptReport_Print = new System.Windows.Forms.Button();
            this.lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices = new System.Windows.Forms.Label();
            this.GV_PaymentReceiptReport_PaymentReceiptDetails = new System.Windows.Forms.DataGridView();
            this.lbl_PaymentReceiptReport_OtherPaymentReceipts = new System.Windows.Forms.Label();
            this.GV_PaymentReceiptReport_OtherPaymentReceiptDetails = new System.Windows.Forms.DataGridView();
            this.lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt = new System.Windows.Forms.Label();
            this.txt_PaymentReceiptReport_InvoicePaymentReceiptTotalAmount = new System.Windows.Forms.TextBox();
            this.txt_PaymentReceiptReport_OtherPaymentReceiptTotalAmount = new System.Windows.Forms.TextBox();
            this.lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PaymentReceiptReport_PaymentReceiptDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PaymentReceiptReport_OtherPaymentReceiptDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dt_PaymentReceiptReport_DateTo);
            this.panel1.Controls.Add(this.dt_PaymentReceiptReport_DateFrom);
            this.panel1.Controls.Add(this.lbl_PaymentReceiptReport_DateTo);
            this.panel1.Controls.Add(this.lbl_PaymentReceiptReport_DateFrom);
            this.panel1.Controls.Add(this.rb_PaymentReceiptReport_Receipt);
            this.panel1.Controls.Add(this.rb_PaymentReceiptReport_Payment);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 71);
            this.panel1.TabIndex = 0;
            // 
            // dt_PaymentReceiptReport_DateTo
            // 
            this.dt_PaymentReceiptReport_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_PaymentReceiptReport_DateTo.Location = new System.Drawing.Point(148, 44);
            this.dt_PaymentReceiptReport_DateTo.Name = "dt_PaymentReceiptReport_DateTo";
            this.dt_PaymentReceiptReport_DateTo.Size = new System.Drawing.Size(95, 22);
            this.dt_PaymentReceiptReport_DateTo.TabIndex = 5;
            // 
            // dt_PaymentReceiptReport_DateFrom
            // 
            this.dt_PaymentReceiptReport_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_PaymentReceiptReport_DateFrom.Location = new System.Drawing.Point(148, 20);
            this.dt_PaymentReceiptReport_DateFrom.Name = "dt_PaymentReceiptReport_DateFrom";
            this.dt_PaymentReceiptReport_DateFrom.Size = new System.Drawing.Size(95, 22);
            this.dt_PaymentReceiptReport_DateFrom.TabIndex = 4;
            // 
            // lbl_PaymentReceiptReport_DateTo
            // 
            this.lbl_PaymentReceiptReport_DateTo.AutoSize = true;
            this.lbl_PaymentReceiptReport_DateTo.Location = new System.Drawing.Point(107, 44);
            this.lbl_PaymentReceiptReport_DateTo.Name = "lbl_PaymentReceiptReport_DateTo";
            this.lbl_PaymentReceiptReport_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_PaymentReceiptReport_DateTo.TabIndex = 3;
            this.lbl_PaymentReceiptReport_DateTo.Text = "To";
            // 
            // lbl_PaymentReceiptReport_DateFrom
            // 
            this.lbl_PaymentReceiptReport_DateFrom.AutoSize = true;
            this.lbl_PaymentReceiptReport_DateFrom.Location = new System.Drawing.Point(107, 20);
            this.lbl_PaymentReceiptReport_DateFrom.Name = "lbl_PaymentReceiptReport_DateFrom";
            this.lbl_PaymentReceiptReport_DateFrom.Size = new System.Drawing.Size(34, 15);
            this.lbl_PaymentReceiptReport_DateFrom.TabIndex = 2;
            this.lbl_PaymentReceiptReport_DateFrom.Text = "From";
            // 
            // rb_PaymentReceiptReport_Receipt
            // 
            this.rb_PaymentReceiptReport_Receipt.AutoSize = true;
            this.rb_PaymentReceiptReport_Receipt.Location = new System.Drawing.Point(17, 40);
            this.rb_PaymentReceiptReport_Receipt.Name = "rb_PaymentReceiptReport_Receipt";
            this.rb_PaymentReceiptReport_Receipt.Size = new System.Drawing.Size(65, 19);
            this.rb_PaymentReceiptReport_Receipt.TabIndex = 1;
            this.rb_PaymentReceiptReport_Receipt.TabStop = true;
            this.rb_PaymentReceiptReport_Receipt.Text = "Receipt";
            this.rb_PaymentReceiptReport_Receipt.UseVisualStyleBackColor = true;
            // 
            // rb_PaymentReceiptReport_Payment
            // 
            this.rb_PaymentReceiptReport_Payment.AutoSize = true;
            this.rb_PaymentReceiptReport_Payment.Location = new System.Drawing.Point(17, 15);
            this.rb_PaymentReceiptReport_Payment.Name = "rb_PaymentReceiptReport_Payment";
            this.rb_PaymentReceiptReport_Payment.Size = new System.Drawing.Size(71, 19);
            this.rb_PaymentReceiptReport_Payment.TabIndex = 0;
            this.rb_PaymentReceiptReport_Payment.TabStop = true;
            this.rb_PaymentReceiptReport_Payment.Text = "Payment";
            this.rb_PaymentReceiptReport_Payment.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_PaymentReceiptReport_PaymentID);
            this.panel2.Controls.Add(this.rb_PaymentReceiptReport_InvoiceID);
            this.panel2.Controls.Add(this.rb_PaymentReceiptReport_PartyName);
            this.panel2.Controls.Add(this.rb_PaymentReceiptReport_PaymentID);
            this.panel2.Location = new System.Drawing.Point(272, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 42);
            this.panel2.TabIndex = 1;
            // 
            // txt_PaymentReceiptReport_PaymentID
            // 
            this.txt_PaymentReceiptReport_PaymentID.Location = new System.Drawing.Point(287, 12);
            this.txt_PaymentReceiptReport_PaymentID.Name = "txt_PaymentReceiptReport_PaymentID";
            this.txt_PaymentReceiptReport_PaymentID.Size = new System.Drawing.Size(225, 22);
            this.txt_PaymentReceiptReport_PaymentID.TabIndex = 3;
            // 
            // rb_PaymentReceiptReport_InvoiceID
            // 
            this.rb_PaymentReceiptReport_InvoiceID.AutoSize = true;
            this.rb_PaymentReceiptReport_InvoiceID.Location = new System.Drawing.Point(200, 16);
            this.rb_PaymentReceiptReport_InvoiceID.Name = "rb_PaymentReceiptReport_InvoiceID";
            this.rb_PaymentReceiptReport_InvoiceID.Size = new System.Drawing.Size(81, 19);
            this.rb_PaymentReceiptReport_InvoiceID.TabIndex = 2;
            this.rb_PaymentReceiptReport_InvoiceID.TabStop = true;
            this.rb_PaymentReceiptReport_InvoiceID.Text = "Invoice ID";
            this.rb_PaymentReceiptReport_InvoiceID.UseVisualStyleBackColor = true;
            // 
            // rb_PaymentReceiptReport_PartyName
            // 
            this.rb_PaymentReceiptReport_PartyName.AutoSize = true;
            this.rb_PaymentReceiptReport_PartyName.Location = new System.Drawing.Point(108, 15);
            this.rb_PaymentReceiptReport_PartyName.Name = "rb_PaymentReceiptReport_PartyName";
            this.rb_PaymentReceiptReport_PartyName.Size = new System.Drawing.Size(86, 19);
            this.rb_PaymentReceiptReport_PartyName.TabIndex = 1;
            this.rb_PaymentReceiptReport_PartyName.TabStop = true;
            this.rb_PaymentReceiptReport_PartyName.Text = "Party Name";
            this.rb_PaymentReceiptReport_PartyName.UseVisualStyleBackColor = true;
            // 
            // rb_PaymentReceiptReport_PaymentID
            // 
            this.rb_PaymentReceiptReport_PaymentID.AutoSize = true;
            this.rb_PaymentReceiptReport_PaymentID.Location = new System.Drawing.Point(15, 15);
            this.rb_PaymentReceiptReport_PaymentID.Name = "rb_PaymentReceiptReport_PaymentID";
            this.rb_PaymentReceiptReport_PaymentID.Size = new System.Drawing.Size(87, 19);
            this.rb_PaymentReceiptReport_PaymentID.TabIndex = 0;
            this.rb_PaymentReceiptReport_PaymentID.TabStop = true;
            this.rb_PaymentReceiptReport_PaymentID.Text = "Payment ID";
            this.rb_PaymentReceiptReport_PaymentID.UseVisualStyleBackColor = true;
            // 
            // btn_PaymentReceiptReport_Search
            // 
            this.btn_PaymentReceiptReport_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PaymentReceiptReport_Search.Location = new System.Drawing.Point(803, 13);
            this.btn_PaymentReceiptReport_Search.Name = "btn_PaymentReceiptReport_Search";
            this.btn_PaymentReceiptReport_Search.Size = new System.Drawing.Size(75, 42);
            this.btn_PaymentReceiptReport_Search.TabIndex = 2;
            this.btn_PaymentReceiptReport_Search.Text = "Search";
            this.btn_PaymentReceiptReport_Search.UseVisualStyleBackColor = true;
            // 
            // cb_PaymentReceiptReport_FilterBySalesman
            // 
            this.cb_PaymentReceiptReport_FilterBySalesman.AutoSize = true;
            this.cb_PaymentReceiptReport_FilterBySalesman.Location = new System.Drawing.Point(271, 61);
            this.cb_PaymentReceiptReport_FilterBySalesman.Name = "cb_PaymentReceiptReport_FilterBySalesman";
            this.cb_PaymentReceiptReport_FilterBySalesman.Size = new System.Drawing.Size(124, 19);
            this.cb_PaymentReceiptReport_FilterBySalesman.TabIndex = 3;
            this.cb_PaymentReceiptReport_FilterBySalesman.Text = "Filter By Salesman";
            this.cb_PaymentReceiptReport_FilterBySalesman.UseVisualStyleBackColor = true;
            // 
            // cb_PaymentReceiptReport_CostCenter
            // 
            this.cb_PaymentReceiptReport_CostCenter.AutoSize = true;
            this.cb_PaymentReceiptReport_CostCenter.Location = new System.Drawing.Point(272, 88);
            this.cb_PaymentReceiptReport_CostCenter.Name = "cb_PaymentReceiptReport_CostCenter";
            this.cb_PaymentReceiptReport_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_PaymentReceiptReport_CostCenter.TabIndex = 4;
            this.cb_PaymentReceiptReport_CostCenter.Text = "Cost Center";
            this.cb_PaymentReceiptReport_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_PaymentReceiptReport_FilterBySalesman
            // 
            this.cob_PaymentReceiptReport_FilterBySalesman.FormattingEnabled = true;
            this.cob_PaymentReceiptReport_FilterBySalesman.Location = new System.Drawing.Point(403, 57);
            this.cob_PaymentReceiptReport_FilterBySalesman.Name = "cob_PaymentReceiptReport_FilterBySalesman";
            this.cob_PaymentReceiptReport_FilterBySalesman.Size = new System.Drawing.Size(196, 23);
            this.cob_PaymentReceiptReport_FilterBySalesman.TabIndex = 5;
            // 
            // cob_PaymentReceiptReport_CostCenter
            // 
            this.cob_PaymentReceiptReport_CostCenter.FormattingEnabled = true;
            this.cob_PaymentReceiptReport_CostCenter.Location = new System.Drawing.Point(403, 86);
            this.cob_PaymentReceiptReport_CostCenter.Name = "cob_PaymentReceiptReport_CostCenter";
            this.cob_PaymentReceiptReport_CostCenter.Size = new System.Drawing.Size(196, 23);
            this.cob_PaymentReceiptReport_CostCenter.TabIndex = 6;
            // 
            // btn_PaymentReceiptReport_Print
            // 
            this.btn_PaymentReceiptReport_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PaymentReceiptReport_Print.Location = new System.Drawing.Point(803, 59);
            this.btn_PaymentReceiptReport_Print.Name = "btn_PaymentReceiptReport_Print";
            this.btn_PaymentReceiptReport_Print.Size = new System.Drawing.Size(75, 42);
            this.btn_PaymentReceiptReport_Print.TabIndex = 7;
            this.btn_PaymentReceiptReport_Print.Text = "Print";
            this.btn_PaymentReceiptReport_Print.UseVisualStyleBackColor = true;
            // 
            // lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices
            // 
            this.lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices.AutoSize = true;
            this.lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices.Location = new System.Drawing.Point(13, 95);
            this.lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices.Name = "lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices";
            this.lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices.Size = new System.Drawing.Size(193, 15);
            this.lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices.TabIndex = 8;
            this.lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices.Text = "Payment Receipt against Invoicess";
            // 
            // GV_PaymentReceiptReport_PaymentReceiptDetails
            // 
            this.GV_PaymentReceiptReport_PaymentReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_PaymentReceiptReport_PaymentReceiptDetails.Location = new System.Drawing.Point(16, 127);
            this.GV_PaymentReceiptReport_PaymentReceiptDetails.Name = "GV_PaymentReceiptReport_PaymentReceiptDetails";
            this.GV_PaymentReceiptReport_PaymentReceiptDetails.Size = new System.Drawing.Size(862, 196);
            this.GV_PaymentReceiptReport_PaymentReceiptDetails.TabIndex = 9;
            // 
            // lbl_PaymentReceiptReport_OtherPaymentReceipts
            // 
            this.lbl_PaymentReceiptReport_OtherPaymentReceipts.AutoSize = true;
            this.lbl_PaymentReceiptReport_OtherPaymentReceipts.Location = new System.Drawing.Point(13, 337);
            this.lbl_PaymentReceiptReport_OtherPaymentReceipts.Name = "lbl_PaymentReceiptReport_OtherPaymentReceipts";
            this.lbl_PaymentReceiptReport_OtherPaymentReceipts.Size = new System.Drawing.Size(135, 15);
            this.lbl_PaymentReceiptReport_OtherPaymentReceipts.TabIndex = 10;
            this.lbl_PaymentReceiptReport_OtherPaymentReceipts.Text = "Other Payment Receipts";
            // 
            // GV_PaymentReceiptReport_OtherPaymentReceiptDetails
            // 
            this.GV_PaymentReceiptReport_OtherPaymentReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_PaymentReceiptReport_OtherPaymentReceiptDetails.Location = new System.Drawing.Point(16, 356);
            this.GV_PaymentReceiptReport_OtherPaymentReceiptDetails.Name = "GV_PaymentReceiptReport_OtherPaymentReceiptDetails";
            this.GV_PaymentReceiptReport_OtherPaymentReceiptDetails.Size = new System.Drawing.Size(714, 150);
            this.GV_PaymentReceiptReport_OtherPaymentReceiptDetails.TabIndex = 11;
            // 
            // lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt
            // 
            this.lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt.AutoSize = true;
            this.lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt.Location = new System.Drawing.Point(644, 334);
            this.lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt.Name = "lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt";
            this.lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt.Size = new System.Drawing.Size(80, 15);
            this.lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt.TabIndex = 12;
            this.lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt.Text = "Total Amount";
            // 
            // txt_PaymentReceiptReport_InvoicePaymentReceiptTotalAmount
            // 
            this.txt_PaymentReceiptReport_InvoicePaymentReceiptTotalAmount.Location = new System.Drawing.Point(739, 331);
            this.txt_PaymentReceiptReport_InvoicePaymentReceiptTotalAmount.Name = "txt_PaymentReceiptReport_InvoicePaymentReceiptTotalAmount";
            this.txt_PaymentReceiptReport_InvoicePaymentReceiptTotalAmount.Size = new System.Drawing.Size(139, 22);
            this.txt_PaymentReceiptReport_InvoicePaymentReceiptTotalAmount.TabIndex = 13;
            // 
            // txt_PaymentReceiptReport_OtherPaymentReceiptTotalAmount
            // 
            this.txt_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.Location = new System.Drawing.Point(739, 484);
            this.txt_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.Name = "txt_PaymentReceiptReport_OtherPaymentReceiptTotalAmount";
            this.txt_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.Size = new System.Drawing.Size(139, 22);
            this.txt_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.TabIndex = 15;
            // 
            // lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount
            // 
            this.lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.AutoSize = true;
            this.lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.Location = new System.Drawing.Point(736, 466);
            this.lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.Name = "lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount";
            this.lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.Size = new System.Drawing.Size(80, 15);
            this.lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.TabIndex = 14;
            this.lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount.Text = "Total Amount";
            // 
            // frm_Accounts_PaymentReceiptReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 519);
            this.Controls.Add(this.txt_PaymentReceiptReport_OtherPaymentReceiptTotalAmount);
            this.Controls.Add(this.lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount);
            this.Controls.Add(this.txt_PaymentReceiptReport_InvoicePaymentReceiptTotalAmount);
            this.Controls.Add(this.lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt);
            this.Controls.Add(this.GV_PaymentReceiptReport_OtherPaymentReceiptDetails);
            this.Controls.Add(this.lbl_PaymentReceiptReport_OtherPaymentReceipts);
            this.Controls.Add(this.GV_PaymentReceiptReport_PaymentReceiptDetails);
            this.Controls.Add(this.lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices);
            this.Controls.Add(this.btn_PaymentReceiptReport_Print);
            this.Controls.Add(this.cob_PaymentReceiptReport_CostCenter);
            this.Controls.Add(this.cob_PaymentReceiptReport_FilterBySalesman);
            this.Controls.Add(this.cb_PaymentReceiptReport_CostCenter);
            this.Controls.Add(this.cb_PaymentReceiptReport_FilterBySalesman);
            this.Controls.Add(this.btn_PaymentReceiptReport_Search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Accounts_PaymentReceiptReport";
            this.Text = "frm_Accounts_PaymentReceiptReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PaymentReceiptReport_PaymentReceiptDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PaymentReceiptReport_OtherPaymentReceiptDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dt_PaymentReceiptReport_DateTo;
        private System.Windows.Forms.DateTimePicker dt_PaymentReceiptReport_DateFrom;
        private System.Windows.Forms.Label lbl_PaymentReceiptReport_DateTo;
        private System.Windows.Forms.Label lbl_PaymentReceiptReport_DateFrom;
        private System.Windows.Forms.RadioButton rb_PaymentReceiptReport_Receipt;
        private System.Windows.Forms.RadioButton rb_PaymentReceiptReport_Payment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_PaymentReceiptReport_PaymentID;
        private System.Windows.Forms.TextBox txt_PaymentReceiptReport_PaymentID;
        private System.Windows.Forms.RadioButton rb_PaymentReceiptReport_InvoiceID;
        private System.Windows.Forms.RadioButton rb_PaymentReceiptReport_PartyName;
        private System.Windows.Forms.Button btn_PaymentReceiptReport_Search;
        private System.Windows.Forms.CheckBox cb_PaymentReceiptReport_FilterBySalesman;
        private System.Windows.Forms.CheckBox cb_PaymentReceiptReport_CostCenter;
        private System.Windows.Forms.ComboBox cob_PaymentReceiptReport_FilterBySalesman;
        private System.Windows.Forms.ComboBox cob_PaymentReceiptReport_CostCenter;
        private System.Windows.Forms.Button btn_PaymentReceiptReport_Print;
        private System.Windows.Forms.Label lbl_PaymentReceiptReport_PaymentReceiptAgainstInvoices;
        private System.Windows.Forms.DataGridView GV_PaymentReceiptReport_PaymentReceiptDetails;
        private System.Windows.Forms.Label lbl_PaymentReceiptReport_OtherPaymentReceipts;
        private System.Windows.Forms.DataGridView GV_PaymentReceiptReport_OtherPaymentReceiptDetails;
        private System.Windows.Forms.Label lbl_PaymentReceiptReport_TotalAmountInvoicePaymentReceipt;
        private System.Windows.Forms.TextBox txt_PaymentReceiptReport_InvoicePaymentReceiptTotalAmount;
        private System.Windows.Forms.TextBox txt_PaymentReceiptReport_OtherPaymentReceiptTotalAmount;
        private System.Windows.Forms.Label lbl_PaymentReceiptReport_OtherPaymentReceiptTotalAmount;
    }
}