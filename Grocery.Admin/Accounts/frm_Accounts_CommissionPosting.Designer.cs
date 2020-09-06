namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_CommissionPosting
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
            this.gb_CommissionPosting_ApplyVAT = new System.Windows.Forms.GroupBox();
            this.cob_CommissionPosting_Emirates = new System.Windows.Forms.ComboBox();
            this.lbl_CommissionPosting_Emirates = new System.Windows.Forms.Label();
            this.txt_CommissionPosting_BillNo = new System.Windows.Forms.TextBox();
            this.lbl_CommissionPosting_BillNo = new System.Windows.Forms.Label();
            this.txt_CommissionPosting_VATRegNo = new System.Windows.Forms.TextBox();
            this.lbl_CommissionPosting_VATRegNo = new System.Windows.Forms.Label();
            this.cob_CommissionPosting_CostCenter = new System.Windows.Forms.ComboBox();
            this.lbl_CommissionPosting_CostCenter = new System.Windows.Forms.Label();
            this.gb_CommissionPosting_PostingMethod = new System.Windows.Forms.GroupBox();
            this.rb_CommissionPosting_InvoiceWise = new System.Windows.Forms.RadioButton();
            this.rb_CommissionPosting_DayWise = new System.Windows.Forms.RadioButton();
            this.btn_CommissionPosting_Search = new System.Windows.Forms.Button();
            this.txt_CommissionPosting_CCRate = new System.Windows.Forms.TextBox();
            this.lbl_CommissionPosting_CCRate = new System.Windows.Forms.Label();
            this.txt_CommissionPosting_CCName = new System.Windows.Forms.TextBox();
            this.lbl_CommissionPosting_CCName = new System.Windows.Forms.Label();
            this.dt_CommissionPosting_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_CommissionPosting_Date = new System.Windows.Forms.Label();
            this.GV_CommissionPosting_CommissionDetails = new System.Windows.Forms.DataGridView();
            this.txt_CommissionPosting_CCAmt = new System.Windows.Forms.TextBox();
            this.txt_CommissionPosting_Commission = new System.Windows.Forms.TextBox();
            this.txt_CommissionPosting_VAT = new System.Windows.Forms.TextBox();
            this.txt_CommissionPosting_BankAmt = new System.Windows.Forms.TextBox();
            this.lbl_CommissionPosting_Total = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CommissionPosting_PostToAccounts = new System.Windows.Forms.Button();
            this.btn_CommissionPosting_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gb_CommissionPosting_ApplyVAT.SuspendLayout();
            this.gb_CommissionPosting_PostingMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_CommissionPosting_CommissionDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gb_CommissionPosting_ApplyVAT);
            this.panel1.Controls.Add(this.cob_CommissionPosting_CostCenter);
            this.panel1.Controls.Add(this.lbl_CommissionPosting_CostCenter);
            this.panel1.Controls.Add(this.gb_CommissionPosting_PostingMethod);
            this.panel1.Controls.Add(this.btn_CommissionPosting_Search);
            this.panel1.Controls.Add(this.txt_CommissionPosting_CCRate);
            this.panel1.Controls.Add(this.lbl_CommissionPosting_CCRate);
            this.panel1.Controls.Add(this.txt_CommissionPosting_CCName);
            this.panel1.Controls.Add(this.lbl_CommissionPosting_CCName);
            this.panel1.Controls.Add(this.dt_CommissionPosting_Date);
            this.panel1.Controls.Add(this.lbl_CommissionPosting_Date);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 164);
            this.panel1.TabIndex = 0;
            // 
            // gb_CommissionPosting_ApplyVAT
            // 
            this.gb_CommissionPosting_ApplyVAT.Controls.Add(this.cob_CommissionPosting_Emirates);
            this.gb_CommissionPosting_ApplyVAT.Controls.Add(this.lbl_CommissionPosting_Emirates);
            this.gb_CommissionPosting_ApplyVAT.Controls.Add(this.txt_CommissionPosting_BillNo);
            this.gb_CommissionPosting_ApplyVAT.Controls.Add(this.lbl_CommissionPosting_BillNo);
            this.gb_CommissionPosting_ApplyVAT.Controls.Add(this.txt_CommissionPosting_VATRegNo);
            this.gb_CommissionPosting_ApplyVAT.Controls.Add(this.lbl_CommissionPosting_VATRegNo);
            this.gb_CommissionPosting_ApplyVAT.Location = new System.Drawing.Point(394, 34);
            this.gb_CommissionPosting_ApplyVAT.Name = "gb_CommissionPosting_ApplyVAT";
            this.gb_CommissionPosting_ApplyVAT.Size = new System.Drawing.Size(262, 109);
            this.gb_CommissionPosting_ApplyVAT.TabIndex = 10;
            this.gb_CommissionPosting_ApplyVAT.TabStop = false;
            this.gb_CommissionPosting_ApplyVAT.Text = "Apply VAT";
            // 
            // cob_CommissionPosting_Emirates
            // 
            this.cob_CommissionPosting_Emirates.FormattingEnabled = true;
            this.cob_CommissionPosting_Emirates.Location = new System.Drawing.Point(84, 78);
            this.cob_CommissionPosting_Emirates.Name = "cob_CommissionPosting_Emirates";
            this.cob_CommissionPosting_Emirates.Size = new System.Drawing.Size(166, 23);
            this.cob_CommissionPosting_Emirates.TabIndex = 11;
            // 
            // lbl_CommissionPosting_Emirates
            // 
            this.lbl_CommissionPosting_Emirates.AutoSize = true;
            this.lbl_CommissionPosting_Emirates.Location = new System.Drawing.Point(5, 81);
            this.lbl_CommissionPosting_Emirates.Name = "lbl_CommissionPosting_Emirates";
            this.lbl_CommissionPosting_Emirates.Size = new System.Drawing.Size(52, 15);
            this.lbl_CommissionPosting_Emirates.TabIndex = 10;
            this.lbl_CommissionPosting_Emirates.Text = "Emirates";
            // 
            // txt_CommissionPosting_BillNo
            // 
            this.txt_CommissionPosting_BillNo.Location = new System.Drawing.Point(84, 50);
            this.txt_CommissionPosting_BillNo.Name = "txt_CommissionPosting_BillNo";
            this.txt_CommissionPosting_BillNo.Size = new System.Drawing.Size(166, 22);
            this.txt_CommissionPosting_BillNo.TabIndex = 7;
            // 
            // lbl_CommissionPosting_BillNo
            // 
            this.lbl_CommissionPosting_BillNo.AutoSize = true;
            this.lbl_CommissionPosting_BillNo.Location = new System.Drawing.Point(5, 52);
            this.lbl_CommissionPosting_BillNo.Name = "lbl_CommissionPosting_BillNo";
            this.lbl_CommissionPosting_BillNo.Size = new System.Drawing.Size(43, 15);
            this.lbl_CommissionPosting_BillNo.TabIndex = 6;
            this.lbl_CommissionPosting_BillNo.Text = "Bill No";
            // 
            // txt_CommissionPosting_VATRegNo
            // 
            this.txt_CommissionPosting_VATRegNo.Location = new System.Drawing.Point(84, 22);
            this.txt_CommissionPosting_VATRegNo.Name = "txt_CommissionPosting_VATRegNo";
            this.txt_CommissionPosting_VATRegNo.Size = new System.Drawing.Size(166, 22);
            this.txt_CommissionPosting_VATRegNo.TabIndex = 5;
            // 
            // lbl_CommissionPosting_VATRegNo
            // 
            this.lbl_CommissionPosting_VATRegNo.AutoSize = true;
            this.lbl_CommissionPosting_VATRegNo.Location = new System.Drawing.Point(5, 24);
            this.lbl_CommissionPosting_VATRegNo.Name = "lbl_CommissionPosting_VATRegNo";
            this.lbl_CommissionPosting_VATRegNo.Size = new System.Drawing.Size(73, 15);
            this.lbl_CommissionPosting_VATRegNo.TabIndex = 4;
            this.lbl_CommissionPosting_VATRegNo.Text = "VAT Reg No";
            // 
            // cob_CommissionPosting_CostCenter
            // 
            this.cob_CommissionPosting_CostCenter.FormattingEnabled = true;
            this.cob_CommissionPosting_CostCenter.Location = new System.Drawing.Point(467, 6);
            this.cob_CommissionPosting_CostCenter.Name = "cob_CommissionPosting_CostCenter";
            this.cob_CommissionPosting_CostCenter.Size = new System.Drawing.Size(189, 23);
            this.cob_CommissionPosting_CostCenter.TabIndex = 9;
            // 
            // lbl_CommissionPosting_CostCenter
            // 
            this.lbl_CommissionPosting_CostCenter.AutoSize = true;
            this.lbl_CommissionPosting_CostCenter.Location = new System.Drawing.Point(391, 9);
            this.lbl_CommissionPosting_CostCenter.Name = "lbl_CommissionPosting_CostCenter";
            this.lbl_CommissionPosting_CostCenter.Size = new System.Drawing.Size(70, 15);
            this.lbl_CommissionPosting_CostCenter.TabIndex = 8;
            this.lbl_CommissionPosting_CostCenter.Text = "Cost Center";
            // 
            // gb_CommissionPosting_PostingMethod
            // 
            this.gb_CommissionPosting_PostingMethod.Controls.Add(this.rb_CommissionPosting_InvoiceWise);
            this.gb_CommissionPosting_PostingMethod.Controls.Add(this.rb_CommissionPosting_DayWise);
            this.gb_CommissionPosting_PostingMethod.Location = new System.Drawing.Point(76, 89);
            this.gb_CommissionPosting_PostingMethod.Name = "gb_CommissionPosting_PostingMethod";
            this.gb_CommissionPosting_PostingMethod.Size = new System.Drawing.Size(292, 54);
            this.gb_CommissionPosting_PostingMethod.TabIndex = 7;
            this.gb_CommissionPosting_PostingMethod.TabStop = false;
            this.gb_CommissionPosting_PostingMethod.Text = "Posting Method";
            // 
            // rb_CommissionPosting_InvoiceWise
            // 
            this.rb_CommissionPosting_InvoiceWise.AutoSize = true;
            this.rb_CommissionPosting_InvoiceWise.Location = new System.Drawing.Point(166, 22);
            this.rb_CommissionPosting_InvoiceWise.Name = "rb_CommissionPosting_InvoiceWise";
            this.rb_CommissionPosting_InvoiceWise.Size = new System.Drawing.Size(95, 19);
            this.rb_CommissionPosting_InvoiceWise.TabIndex = 1;
            this.rb_CommissionPosting_InvoiceWise.TabStop = true;
            this.rb_CommissionPosting_InvoiceWise.Text = "Invoice Wise";
            this.rb_CommissionPosting_InvoiceWise.UseVisualStyleBackColor = true;
            // 
            // rb_CommissionPosting_DayWise
            // 
            this.rb_CommissionPosting_DayWise.AutoSize = true;
            this.rb_CommissionPosting_DayWise.Location = new System.Drawing.Point(38, 22);
            this.rb_CommissionPosting_DayWise.Name = "rb_CommissionPosting_DayWise";
            this.rb_CommissionPosting_DayWise.Size = new System.Drawing.Size(77, 19);
            this.rb_CommissionPosting_DayWise.TabIndex = 0;
            this.rb_CommissionPosting_DayWise.TabStop = true;
            this.rb_CommissionPosting_DayWise.Text = "Day Wise";
            this.rb_CommissionPosting_DayWise.UseVisualStyleBackColor = true;
            // 
            // btn_CommissionPosting_Search
            // 
            this.btn_CommissionPosting_Search.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_CommissionPosting_Search.Location = new System.Drawing.Point(326, 29);
            this.btn_CommissionPosting_Search.Name = "btn_CommissionPosting_Search";
            this.btn_CommissionPosting_Search.Size = new System.Drawing.Size(42, 53);
            this.btn_CommissionPosting_Search.TabIndex = 6;
            this.btn_CommissionPosting_Search.UseVisualStyleBackColor = true;
            // 
            // txt_CommissionPosting_CCRate
            // 
            this.txt_CommissionPosting_CCRate.Location = new System.Drawing.Point(76, 60);
            this.txt_CommissionPosting_CCRate.Name = "txt_CommissionPosting_CCRate";
            this.txt_CommissionPosting_CCRate.Size = new System.Drawing.Size(244, 22);
            this.txt_CommissionPosting_CCRate.TabIndex = 5;
            // 
            // lbl_CommissionPosting_CCRate
            // 
            this.lbl_CommissionPosting_CCRate.AutoSize = true;
            this.lbl_CommissionPosting_CCRate.Location = new System.Drawing.Point(13, 63);
            this.lbl_CommissionPosting_CCRate.Name = "lbl_CommissionPosting_CCRate";
            this.lbl_CommissionPosting_CCRate.Size = new System.Drawing.Size(50, 15);
            this.lbl_CommissionPosting_CCRate.TabIndex = 4;
            this.lbl_CommissionPosting_CCRate.Text = "CC Rate";
            // 
            // txt_CommissionPosting_CCName
            // 
            this.txt_CommissionPosting_CCName.Location = new System.Drawing.Point(76, 34);
            this.txt_CommissionPosting_CCName.Name = "txt_CommissionPosting_CCName";
            this.txt_CommissionPosting_CCName.Size = new System.Drawing.Size(244, 22);
            this.txt_CommissionPosting_CCName.TabIndex = 3;
            // 
            // lbl_CommissionPosting_CCName
            // 
            this.lbl_CommissionPosting_CCName.AutoSize = true;
            this.lbl_CommissionPosting_CCName.Location = new System.Drawing.Point(13, 37);
            this.lbl_CommissionPosting_CCName.Name = "lbl_CommissionPosting_CCName";
            this.lbl_CommissionPosting_CCName.Size = new System.Drawing.Size(56, 15);
            this.lbl_CommissionPosting_CCName.TabIndex = 2;
            this.lbl_CommissionPosting_CCName.Text = "CC Name";
            // 
            // dt_CommissionPosting_Date
            // 
            this.dt_CommissionPosting_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_CommissionPosting_Date.Location = new System.Drawing.Point(76, 6);
            this.dt_CommissionPosting_Date.Name = "dt_CommissionPosting_Date";
            this.dt_CommissionPosting_Date.Size = new System.Drawing.Size(115, 22);
            this.dt_CommissionPosting_Date.TabIndex = 1;
            // 
            // lbl_CommissionPosting_Date
            // 
            this.lbl_CommissionPosting_Date.AutoSize = true;
            this.lbl_CommissionPosting_Date.Location = new System.Drawing.Point(13, 6);
            this.lbl_CommissionPosting_Date.Name = "lbl_CommissionPosting_Date";
            this.lbl_CommissionPosting_Date.Size = new System.Drawing.Size(32, 15);
            this.lbl_CommissionPosting_Date.TabIndex = 0;
            this.lbl_CommissionPosting_Date.Text = "Date";
            // 
            // GV_CommissionPosting_CommissionDetails
            // 
            this.GV_CommissionPosting_CommissionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_CommissionPosting_CommissionDetails.Location = new System.Drawing.Point(12, 183);
            this.GV_CommissionPosting_CommissionDetails.Name = "GV_CommissionPosting_CommissionDetails";
            this.GV_CommissionPosting_CommissionDetails.Size = new System.Drawing.Size(676, 279);
            this.GV_CommissionPosting_CommissionDetails.TabIndex = 1;
            // 
            // txt_CommissionPosting_CCAmt
            // 
            this.txt_CommissionPosting_CCAmt.Location = new System.Drawing.Point(302, 468);
            this.txt_CommissionPosting_CCAmt.Name = "txt_CommissionPosting_CCAmt";
            this.txt_CommissionPosting_CCAmt.Size = new System.Drawing.Size(92, 22);
            this.txt_CommissionPosting_CCAmt.TabIndex = 6;
            // 
            // txt_CommissionPosting_Commission
            // 
            this.txt_CommissionPosting_Commission.Location = new System.Drawing.Point(400, 468);
            this.txt_CommissionPosting_Commission.Name = "txt_CommissionPosting_Commission";
            this.txt_CommissionPosting_Commission.Size = new System.Drawing.Size(92, 22);
            this.txt_CommissionPosting_Commission.TabIndex = 7;
            // 
            // txt_CommissionPosting_VAT
            // 
            this.txt_CommissionPosting_VAT.Location = new System.Drawing.Point(498, 468);
            this.txt_CommissionPosting_VAT.Name = "txt_CommissionPosting_VAT";
            this.txt_CommissionPosting_VAT.Size = new System.Drawing.Size(92, 22);
            this.txt_CommissionPosting_VAT.TabIndex = 8;
            // 
            // txt_CommissionPosting_BankAmt
            // 
            this.txt_CommissionPosting_BankAmt.Location = new System.Drawing.Point(596, 468);
            this.txt_CommissionPosting_BankAmt.Name = "txt_CommissionPosting_BankAmt";
            this.txt_CommissionPosting_BankAmt.Size = new System.Drawing.Size(92, 22);
            this.txt_CommissionPosting_BankAmt.TabIndex = 9;
            // 
            // lbl_CommissionPosting_Total
            // 
            this.lbl_CommissionPosting_Total.AutoSize = true;
            this.lbl_CommissionPosting_Total.Location = new System.Drawing.Point(252, 471);
            this.lbl_CommissionPosting_Total.Name = "lbl_CommissionPosting_Total";
            this.lbl_CommissionPosting_Total.Size = new System.Drawing.Size(34, 15);
            this.lbl_CommissionPosting_Total.TabIndex = 10;
            this.lbl_CommissionPosting_Total.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_CommissionPosting_Cancel);
            this.panel2.Controls.Add(this.btn_CommissionPosting_PostToAccounts);
            this.panel2.Location = new System.Drawing.Point(12, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 53);
            this.panel2.TabIndex = 11;
            // 
            // btn_CommissionPosting_PostToAccounts
            // 
            this.btn_CommissionPosting_PostToAccounts.Location = new System.Drawing.Point(517, 3);
            this.btn_CommissionPosting_PostToAccounts.Name = "btn_CommissionPosting_PostToAccounts";
            this.btn_CommissionPosting_PostToAccounts.Size = new System.Drawing.Size(75, 46);
            this.btn_CommissionPosting_PostToAccounts.TabIndex = 0;
            this.btn_CommissionPosting_PostToAccounts.Text = "Post To Accounts";
            this.btn_CommissionPosting_PostToAccounts.UseVisualStyleBackColor = true;
            // 
            // btn_CommissionPosting_Cancel
            // 
            this.btn_CommissionPosting_Cancel.Location = new System.Drawing.Point(596, 3);
            this.btn_CommissionPosting_Cancel.Name = "btn_CommissionPosting_Cancel";
            this.btn_CommissionPosting_Cancel.Size = new System.Drawing.Size(75, 46);
            this.btn_CommissionPosting_Cancel.TabIndex = 1;
            this.btn_CommissionPosting_Cancel.Text = "Cancel";
            this.btn_CommissionPosting_Cancel.UseVisualStyleBackColor = true;
            // 
            // frm_Accounts_CommissionPosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_CommissionPosting_Total);
            this.Controls.Add(this.txt_CommissionPosting_BankAmt);
            this.Controls.Add(this.txt_CommissionPosting_VAT);
            this.Controls.Add(this.txt_CommissionPosting_Commission);
            this.Controls.Add(this.txt_CommissionPosting_CCAmt);
            this.Controls.Add(this.GV_CommissionPosting_CommissionDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Accounts_CommissionPosting";
            this.Text = "frm_Accounts_CommissionPosting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_CommissionPosting_ApplyVAT.ResumeLayout(false);
            this.gb_CommissionPosting_ApplyVAT.PerformLayout();
            this.gb_CommissionPosting_PostingMethod.ResumeLayout(false);
            this.gb_CommissionPosting_PostingMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_CommissionPosting_CommissionDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_CommissionPosting_Search;
        private System.Windows.Forms.TextBox txt_CommissionPosting_CCRate;
        private System.Windows.Forms.Label lbl_CommissionPosting_CCRate;
        private System.Windows.Forms.TextBox txt_CommissionPosting_CCName;
        private System.Windows.Forms.Label lbl_CommissionPosting_CCName;
        private System.Windows.Forms.DateTimePicker dt_CommissionPosting_Date;
        private System.Windows.Forms.Label lbl_CommissionPosting_Date;
        private System.Windows.Forms.GroupBox gb_CommissionPosting_ApplyVAT;
        private System.Windows.Forms.ComboBox cob_CommissionPosting_Emirates;
        private System.Windows.Forms.Label lbl_CommissionPosting_Emirates;
        private System.Windows.Forms.TextBox txt_CommissionPosting_BillNo;
        private System.Windows.Forms.Label lbl_CommissionPosting_BillNo;
        private System.Windows.Forms.TextBox txt_CommissionPosting_VATRegNo;
        private System.Windows.Forms.Label lbl_CommissionPosting_VATRegNo;
        private System.Windows.Forms.ComboBox cob_CommissionPosting_CostCenter;
        private System.Windows.Forms.Label lbl_CommissionPosting_CostCenter;
        private System.Windows.Forms.GroupBox gb_CommissionPosting_PostingMethod;
        private System.Windows.Forms.RadioButton rb_CommissionPosting_InvoiceWise;
        private System.Windows.Forms.RadioButton rb_CommissionPosting_DayWise;
        private System.Windows.Forms.DataGridView GV_CommissionPosting_CommissionDetails;
        private System.Windows.Forms.TextBox txt_CommissionPosting_CCAmt;
        private System.Windows.Forms.TextBox txt_CommissionPosting_Commission;
        private System.Windows.Forms.TextBox txt_CommissionPosting_VAT;
        private System.Windows.Forms.TextBox txt_CommissionPosting_BankAmt;
        private System.Windows.Forms.Label lbl_CommissionPosting_Total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_CommissionPosting_Cancel;
        private System.Windows.Forms.Button btn_CommissionPosting_PostToAccounts;
    }
}