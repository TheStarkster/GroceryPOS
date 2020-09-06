namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_SalesSummary
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
            this.lbl_SalesSummary_Type = new System.Windows.Forms.Label();
            this.cob_SalesSummary_Type = new System.Windows.Forms.ComboBox();
            this.cob_SalesSummary_Courier = new System.Windows.Forms.ComboBox();
            this.lbl_SalesSummary_Courier = new System.Windows.Forms.Label();
            this.rb_SalesSummary_DateFrom = new System.Windows.Forms.RadioButton();
            this.dt_SalesSummary_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_SalesSummary_DateTo = new System.Windows.Forms.Label();
            this.dt_SalesSummary_DateTo = new System.Windows.Forms.DateTimePicker();
            this.cb_SalesSummary_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_SalesSummary_CostCenter = new System.Windows.Forms.ComboBox();
            this.btn_SalesSummary_Process = new System.Windows.Forms.Button();
            this.btn_SalesSummary_Close = new System.Windows.Forms.Button();
            this.GV_SalesSummary_InvoiceDetails = new System.Windows.Forms.DataGridView();
            this.GV_SalesSummary_ParticularsDetails = new System.Windows.Forms.DataGridView();
            this.txt_SalesSummary_NetAmt = new System.Windows.Forms.TextBox();
            this.txt_SalesSummary_DiscAmount = new System.Windows.Forms.TextBox();
            this.txt_SalesSummary_OtherCharges = new System.Windows.Forms.TextBox();
            this.txt_SalesSummary_TotalAmount = new System.Windows.Forms.TextBox();
            this.lbl_SalesSummary_Total = new System.Windows.Forms.Label();
            this.lbl_SalesSummary_TotalAmount = new System.Windows.Forms.Label();
            this.txt_SalesSummary_Amount = new System.Windows.Forms.TextBox();
            this.GV_SalesSummary_QuantityDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SalesSummary_InvoiceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SalesSummary_ParticularsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SalesSummary_QuantityDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_SalesSummary_Close);
            this.panel1.Controls.Add(this.btn_SalesSummary_Process);
            this.panel1.Controls.Add(this.cob_SalesSummary_CostCenter);
            this.panel1.Controls.Add(this.cb_SalesSummary_CostCenter);
            this.panel1.Controls.Add(this.dt_SalesSummary_DateTo);
            this.panel1.Controls.Add(this.lbl_SalesSummary_DateTo);
            this.panel1.Controls.Add(this.dt_SalesSummary_DateFrom);
            this.panel1.Controls.Add(this.rb_SalesSummary_DateFrom);
            this.panel1.Controls.Add(this.cob_SalesSummary_Courier);
            this.panel1.Controls.Add(this.lbl_SalesSummary_Courier);
            this.panel1.Controls.Add(this.cob_SalesSummary_Type);
            this.panel1.Controls.Add(this.lbl_SalesSummary_Type);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 50);
            this.panel1.TabIndex = 0;
            // 
            // lbl_SalesSummary_Type
            // 
            this.lbl_SalesSummary_Type.AutoSize = true;
            this.lbl_SalesSummary_Type.Location = new System.Drawing.Point(22, 21);
            this.lbl_SalesSummary_Type.Name = "lbl_SalesSummary_Type";
            this.lbl_SalesSummary_Type.Size = new System.Drawing.Size(34, 15);
            this.lbl_SalesSummary_Type.TabIndex = 0;
            this.lbl_SalesSummary_Type.Text = "Type";
            // 
            // cob_SalesSummary_Type
            // 
            this.cob_SalesSummary_Type.FormattingEnabled = true;
            this.cob_SalesSummary_Type.Location = new System.Drawing.Point(62, 18);
            this.cob_SalesSummary_Type.Name = "cob_SalesSummary_Type";
            this.cob_SalesSummary_Type.Size = new System.Drawing.Size(121, 23);
            this.cob_SalesSummary_Type.TabIndex = 1;
            // 
            // cob_SalesSummary_Courier
            // 
            this.cob_SalesSummary_Courier.FormattingEnabled = true;
            this.cob_SalesSummary_Courier.Location = new System.Drawing.Point(249, 18);
            this.cob_SalesSummary_Courier.Name = "cob_SalesSummary_Courier";
            this.cob_SalesSummary_Courier.Size = new System.Drawing.Size(121, 23);
            this.cob_SalesSummary_Courier.TabIndex = 3;
            // 
            // lbl_SalesSummary_Courier
            // 
            this.lbl_SalesSummary_Courier.AutoSize = true;
            this.lbl_SalesSummary_Courier.Location = new System.Drawing.Point(197, 24);
            this.lbl_SalesSummary_Courier.Name = "lbl_SalesSummary_Courier";
            this.lbl_SalesSummary_Courier.Size = new System.Drawing.Size(46, 15);
            this.lbl_SalesSummary_Courier.TabIndex = 2;
            this.lbl_SalesSummary_Courier.Text = "Courier";
            // 
            // rb_SalesSummary_DateFrom
            // 
            this.rb_SalesSummary_DateFrom.AutoSize = true;
            this.rb_SalesSummary_DateFrom.Location = new System.Drawing.Point(376, 20);
            this.rb_SalesSummary_DateFrom.Name = "rb_SalesSummary_DateFrom";
            this.rb_SalesSummary_DateFrom.Size = new System.Drawing.Size(80, 19);
            this.rb_SalesSummary_DateFrom.TabIndex = 4;
            this.rb_SalesSummary_DateFrom.TabStop = true;
            this.rb_SalesSummary_DateFrom.Text = "Date From";
            this.rb_SalesSummary_DateFrom.UseVisualStyleBackColor = true;
            // 
            // dt_SalesSummary_DateFrom
            // 
            this.dt_SalesSummary_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_SalesSummary_DateFrom.Location = new System.Drawing.Point(463, 20);
            this.dt_SalesSummary_DateFrom.Name = "dt_SalesSummary_DateFrom";
            this.dt_SalesSummary_DateFrom.Size = new System.Drawing.Size(101, 22);
            this.dt_SalesSummary_DateFrom.TabIndex = 5;
            // 
            // lbl_SalesSummary_DateTo
            // 
            this.lbl_SalesSummary_DateTo.AutoSize = true;
            this.lbl_SalesSummary_DateTo.Location = new System.Drawing.Point(570, 24);
            this.lbl_SalesSummary_DateTo.Name = "lbl_SalesSummary_DateTo";
            this.lbl_SalesSummary_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_SalesSummary_DateTo.TabIndex = 6;
            this.lbl_SalesSummary_DateTo.Text = "To";
            // 
            // dt_SalesSummary_DateTo
            // 
            this.dt_SalesSummary_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_SalesSummary_DateTo.Location = new System.Drawing.Point(597, 19);
            this.dt_SalesSummary_DateTo.Name = "dt_SalesSummary_DateTo";
            this.dt_SalesSummary_DateTo.Size = new System.Drawing.Size(101, 22);
            this.dt_SalesSummary_DateTo.TabIndex = 7;
            // 
            // cb_SalesSummary_CostCenter
            // 
            this.cb_SalesSummary_CostCenter.AutoSize = true;
            this.cb_SalesSummary_CostCenter.Location = new System.Drawing.Point(704, 3);
            this.cb_SalesSummary_CostCenter.Name = "cb_SalesSummary_CostCenter";
            this.cb_SalesSummary_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_SalesSummary_CostCenter.TabIndex = 8;
            this.cb_SalesSummary_CostCenter.Text = "Cost Center";
            this.cb_SalesSummary_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_SalesSummary_CostCenter
            // 
            this.cob_SalesSummary_CostCenter.FormattingEnabled = true;
            this.cob_SalesSummary_CostCenter.Location = new System.Drawing.Point(704, 18);
            this.cob_SalesSummary_CostCenter.Name = "cob_SalesSummary_CostCenter";
            this.cob_SalesSummary_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_SalesSummary_CostCenter.TabIndex = 9;
            // 
            // btn_SalesSummary_Process
            // 
            this.btn_SalesSummary_Process.Location = new System.Drawing.Point(831, 7);
            this.btn_SalesSummary_Process.Name = "btn_SalesSummary_Process";
            this.btn_SalesSummary_Process.Size = new System.Drawing.Size(78, 35);
            this.btn_SalesSummary_Process.TabIndex = 10;
            this.btn_SalesSummary_Process.Text = "Process";
            this.btn_SalesSummary_Process.UseVisualStyleBackColor = true;
            // 
            // btn_SalesSummary_Close
            // 
            this.btn_SalesSummary_Close.Location = new System.Drawing.Point(910, 7);
            this.btn_SalesSummary_Close.Name = "btn_SalesSummary_Close";
            this.btn_SalesSummary_Close.Size = new System.Drawing.Size(78, 34);
            this.btn_SalesSummary_Close.TabIndex = 11;
            this.btn_SalesSummary_Close.Text = "Close";
            this.btn_SalesSummary_Close.UseVisualStyleBackColor = true;
            // 
            // GV_SalesSummary_InvoiceDetails
            // 
            this.GV_SalesSummary_InvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_SalesSummary_InvoiceDetails.Location = new System.Drawing.Point(12, 68);
            this.GV_SalesSummary_InvoiceDetails.Name = "GV_SalesSummary_InvoiceDetails";
            this.GV_SalesSummary_InvoiceDetails.Size = new System.Drawing.Size(592, 160);
            this.GV_SalesSummary_InvoiceDetails.TabIndex = 1;
            // 
            // GV_SalesSummary_ParticularsDetails
            // 
            this.GV_SalesSummary_ParticularsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_SalesSummary_ParticularsDetails.Location = new System.Drawing.Point(610, 68);
            this.GV_SalesSummary_ParticularsDetails.Name = "GV_SalesSummary_ParticularsDetails";
            this.GV_SalesSummary_ParticularsDetails.Size = new System.Drawing.Size(395, 160);
            this.GV_SalesSummary_ParticularsDetails.TabIndex = 2;
            // 
            // txt_SalesSummary_NetAmt
            // 
            this.txt_SalesSummary_NetAmt.Location = new System.Drawing.Point(498, 235);
            this.txt_SalesSummary_NetAmt.Name = "txt_SalesSummary_NetAmt";
            this.txt_SalesSummary_NetAmt.Size = new System.Drawing.Size(100, 22);
            this.txt_SalesSummary_NetAmt.TabIndex = 3;
            // 
            // txt_SalesSummary_DiscAmount
            // 
            this.txt_SalesSummary_DiscAmount.Location = new System.Drawing.Point(392, 235);
            this.txt_SalesSummary_DiscAmount.Name = "txt_SalesSummary_DiscAmount";
            this.txt_SalesSummary_DiscAmount.Size = new System.Drawing.Size(100, 22);
            this.txt_SalesSummary_DiscAmount.TabIndex = 4;
            // 
            // txt_SalesSummary_OtherCharges
            // 
            this.txt_SalesSummary_OtherCharges.Location = new System.Drawing.Point(286, 235);
            this.txt_SalesSummary_OtherCharges.Name = "txt_SalesSummary_OtherCharges";
            this.txt_SalesSummary_OtherCharges.Size = new System.Drawing.Size(100, 22);
            this.txt_SalesSummary_OtherCharges.TabIndex = 5;
            // 
            // txt_SalesSummary_TotalAmount
            // 
            this.txt_SalesSummary_TotalAmount.Location = new System.Drawing.Point(180, 235);
            this.txt_SalesSummary_TotalAmount.Name = "txt_SalesSummary_TotalAmount";
            this.txt_SalesSummary_TotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txt_SalesSummary_TotalAmount.TabIndex = 6;
            // 
            // lbl_SalesSummary_Total
            // 
            this.lbl_SalesSummary_Total.AutoSize = true;
            this.lbl_SalesSummary_Total.Location = new System.Drawing.Point(128, 238);
            this.lbl_SalesSummary_Total.Name = "lbl_SalesSummary_Total";
            this.lbl_SalesSummary_Total.Size = new System.Drawing.Size(34, 15);
            this.lbl_SalesSummary_Total.TabIndex = 7;
            this.lbl_SalesSummary_Total.Text = "Total";
            // 
            // lbl_SalesSummary_TotalAmount
            // 
            this.lbl_SalesSummary_TotalAmount.AutoSize = true;
            this.lbl_SalesSummary_TotalAmount.Location = new System.Drawing.Point(832, 242);
            this.lbl_SalesSummary_TotalAmount.Name = "lbl_SalesSummary_TotalAmount";
            this.lbl_SalesSummary_TotalAmount.Size = new System.Drawing.Size(34, 15);
            this.lbl_SalesSummary_TotalAmount.TabIndex = 9;
            this.lbl_SalesSummary_TotalAmount.Text = "Total";
            // 
            // txt_SalesSummary_Amount
            // 
            this.txt_SalesSummary_Amount.Location = new System.Drawing.Point(872, 238);
            this.txt_SalesSummary_Amount.Name = "txt_SalesSummary_Amount";
            this.txt_SalesSummary_Amount.Size = new System.Drawing.Size(133, 22);
            this.txt_SalesSummary_Amount.TabIndex = 8;
            // 
            // GV_SalesSummary_QuantityDetails
            // 
            this.GV_SalesSummary_QuantityDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_SalesSummary_QuantityDetails.Location = new System.Drawing.Point(16, 263);
            this.GV_SalesSummary_QuantityDetails.Name = "GV_SalesSummary_QuantityDetails";
            this.GV_SalesSummary_QuantityDetails.Size = new System.Drawing.Size(367, 244);
            this.GV_SalesSummary_QuantityDetails.TabIndex = 10;
            // 
            // Frm_Reports_SalesSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 519);
            this.Controls.Add(this.GV_SalesSummary_QuantityDetails);
            this.Controls.Add(this.lbl_SalesSummary_TotalAmount);
            this.Controls.Add(this.txt_SalesSummary_Amount);
            this.Controls.Add(this.lbl_SalesSummary_Total);
            this.Controls.Add(this.txt_SalesSummary_TotalAmount);
            this.Controls.Add(this.txt_SalesSummary_OtherCharges);
            this.Controls.Add(this.txt_SalesSummary_DiscAmount);
            this.Controls.Add(this.txt_SalesSummary_NetAmt);
            this.Controls.Add(this.GV_SalesSummary_ParticularsDetails);
            this.Controls.Add(this.GV_SalesSummary_InvoiceDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_SalesSummary";
            this.Text = "Frm_Reports_SalesSummary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SalesSummary_InvoiceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SalesSummary_ParticularsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SalesSummary_QuantityDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SalesSummary_Close;
        private System.Windows.Forms.Button btn_SalesSummary_Process;
        private System.Windows.Forms.ComboBox cob_SalesSummary_CostCenter;
        private System.Windows.Forms.CheckBox cb_SalesSummary_CostCenter;
        private System.Windows.Forms.DateTimePicker dt_SalesSummary_DateTo;
        private System.Windows.Forms.Label lbl_SalesSummary_DateTo;
        private System.Windows.Forms.DateTimePicker dt_SalesSummary_DateFrom;
        private System.Windows.Forms.RadioButton rb_SalesSummary_DateFrom;
        private System.Windows.Forms.ComboBox cob_SalesSummary_Courier;
        private System.Windows.Forms.Label lbl_SalesSummary_Courier;
        private System.Windows.Forms.ComboBox cob_SalesSummary_Type;
        private System.Windows.Forms.Label lbl_SalesSummary_Type;
        private System.Windows.Forms.DataGridView GV_SalesSummary_InvoiceDetails;
        private System.Windows.Forms.DataGridView GV_SalesSummary_ParticularsDetails;
        private System.Windows.Forms.TextBox txt_SalesSummary_NetAmt;
        private System.Windows.Forms.TextBox txt_SalesSummary_DiscAmount;
        private System.Windows.Forms.TextBox txt_SalesSummary_OtherCharges;
        private System.Windows.Forms.TextBox txt_SalesSummary_TotalAmount;
        private System.Windows.Forms.Label lbl_SalesSummary_Total;
        private System.Windows.Forms.Label lbl_SalesSummary_TotalAmount;
        private System.Windows.Forms.TextBox txt_SalesSummary_Amount;
        private System.Windows.Forms.DataGridView GV_SalesSummary_QuantityDetails;
    }
}