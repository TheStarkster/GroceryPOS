namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_ItemLedger
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
            this.btn_ItemLedger_Filter = new System.Windows.Forms.Button();
            this.txt_ItemLedger_ItemName = new System.Windows.Forms.TextBox();
            this.lbl_ItemLedger_ItemName = new System.Windows.Forms.Label();
            this.cob_ItemLedger_Transactions = new System.Windows.Forms.ComboBox();
            this.lbl_ItemLedger_FilterByTransactions = new System.Windows.Forms.Label();
            this.txt_ItemLedger_ClosingStock = new System.Windows.Forms.TextBox();
            this.lbl_ItemLedger_ClosingStock = new System.Windows.Forms.Label();
            this.txt_ItemLedger_OpeningStock = new System.Windows.Forms.TextBox();
            this.lbl_ItemLedger_OpeningStock = new System.Windows.Forms.Label();
            this.btn_ItemLedger_Process = new System.Windows.Forms.Button();
            this.lbl_ItemLedger_ItemSerielNoWiseReport = new System.Windows.Forms.LinkLabel();
            this.cb_ItemLedger_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_ItemLedger_CostCenter = new System.Windows.Forms.ComboBox();
            this.txt_ItemLedger_Barcode = new System.Windows.Forms.TextBox();
            this.lbl_ItemLedger_Barcode = new System.Windows.Forms.Label();
            this.gb_ItemLedger_SelectDatePeriod = new System.Windows.Forms.GroupBox();
            this.dt_ItemLedger_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_ItemLedger_DateTo = new System.Windows.Forms.Label();
            this.dt_ItemLedger_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_ItemLedger_DateFrom = new System.Windows.Forms.Label();
            this.GV_ItemLedger_TransactionDetails = new System.Windows.Forms.DataGridView();
            this.GV_ItemLedger_ItemDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gb_ItemLedger_SelectDatePeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemLedger_TransactionDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemLedger_ItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ItemLedger_Filter);
            this.panel1.Controls.Add(this.txt_ItemLedger_ItemName);
            this.panel1.Controls.Add(this.lbl_ItemLedger_ItemName);
            this.panel1.Controls.Add(this.cob_ItemLedger_Transactions);
            this.panel1.Controls.Add(this.lbl_ItemLedger_FilterByTransactions);
            this.panel1.Controls.Add(this.txt_ItemLedger_ClosingStock);
            this.panel1.Controls.Add(this.lbl_ItemLedger_ClosingStock);
            this.panel1.Controls.Add(this.txt_ItemLedger_OpeningStock);
            this.panel1.Controls.Add(this.lbl_ItemLedger_OpeningStock);
            this.panel1.Controls.Add(this.btn_ItemLedger_Process);
            this.panel1.Controls.Add(this.lbl_ItemLedger_ItemSerielNoWiseReport);
            this.panel1.Controls.Add(this.cb_ItemLedger_CostCenter);
            this.panel1.Controls.Add(this.cob_ItemLedger_CostCenter);
            this.panel1.Controls.Add(this.txt_ItemLedger_Barcode);
            this.panel1.Controls.Add(this.lbl_ItemLedger_Barcode);
            this.panel1.Controls.Add(this.gb_ItemLedger_SelectDatePeriod);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 163);
            this.panel1.TabIndex = 16;
            // 
            // btn_ItemLedger_Filter
            // 
            this.btn_ItemLedger_Filter.Location = new System.Drawing.Point(692, 69);
            this.btn_ItemLedger_Filter.Name = "btn_ItemLedger_Filter";
            this.btn_ItemLedger_Filter.Size = new System.Drawing.Size(82, 50);
            this.btn_ItemLedger_Filter.TabIndex = 31;
            this.btn_ItemLedger_Filter.Text = "Filter";
            this.btn_ItemLedger_Filter.UseVisualStyleBackColor = true;
            // 
            // txt_ItemLedger_ItemName
            // 
            this.txt_ItemLedger_ItemName.Location = new System.Drawing.Point(89, 97);
            this.txt_ItemLedger_ItemName.Name = "txt_ItemLedger_ItemName";
            this.txt_ItemLedger_ItemName.Size = new System.Drawing.Size(378, 22);
            this.txt_ItemLedger_ItemName.TabIndex = 30;
            // 
            // lbl_ItemLedger_ItemName
            // 
            this.lbl_ItemLedger_ItemName.AutoSize = true;
            this.lbl_ItemLedger_ItemName.Location = new System.Drawing.Point(10, 100);
            this.lbl_ItemLedger_ItemName.Name = "lbl_ItemLedger_ItemName";
            this.lbl_ItemLedger_ItemName.Size = new System.Drawing.Size(63, 15);
            this.lbl_ItemLedger_ItemName.TabIndex = 29;
            this.lbl_ItemLedger_ItemName.Text = "Item Name";
            // 
            // cob_ItemLedger_Transactions
            // 
            this.cob_ItemLedger_Transactions.FormattingEnabled = true;
            this.cob_ItemLedger_Transactions.Location = new System.Drawing.Point(561, 96);
            this.cob_ItemLedger_Transactions.Name = "cob_ItemLedger_Transactions";
            this.cob_ItemLedger_Transactions.Size = new System.Drawing.Size(125, 23);
            this.cob_ItemLedger_Transactions.TabIndex = 28;
            // 
            // lbl_ItemLedger_FilterByTransactions
            // 
            this.lbl_ItemLedger_FilterByTransactions.AutoSize = true;
            this.lbl_ItemLedger_FilterByTransactions.Location = new System.Drawing.Point(561, 72);
            this.lbl_ItemLedger_FilterByTransactions.Name = "lbl_ItemLedger_FilterByTransactions";
            this.lbl_ItemLedger_FilterByTransactions.Size = new System.Drawing.Size(125, 15);
            this.lbl_ItemLedger_FilterByTransactions.TabIndex = 27;
            this.lbl_ItemLedger_FilterByTransactions.Text = "Filter By Transactions";
            // 
            // txt_ItemLedger_ClosingStock
            // 
            this.txt_ItemLedger_ClosingStock.Location = new System.Drawing.Point(670, 31);
            this.txt_ItemLedger_ClosingStock.Name = "txt_ItemLedger_ClosingStock";
            this.txt_ItemLedger_ClosingStock.Size = new System.Drawing.Size(103, 22);
            this.txt_ItemLedger_ClosingStock.TabIndex = 26;
            // 
            // lbl_ItemLedger_ClosingStock
            // 
            this.lbl_ItemLedger_ClosingStock.AutoSize = true;
            this.lbl_ItemLedger_ClosingStock.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemLedger_ClosingStock.Location = new System.Drawing.Point(667, 12);
            this.lbl_ItemLedger_ClosingStock.Name = "lbl_ItemLedger_ClosingStock";
            this.lbl_ItemLedger_ClosingStock.Size = new System.Drawing.Size(85, 15);
            this.lbl_ItemLedger_ClosingStock.TabIndex = 25;
            this.lbl_ItemLedger_ClosingStock.Text = "Closing Stock";
            // 
            // txt_ItemLedger_OpeningStock
            // 
            this.txt_ItemLedger_OpeningStock.Location = new System.Drawing.Point(561, 30);
            this.txt_ItemLedger_OpeningStock.Name = "txt_ItemLedger_OpeningStock";
            this.txt_ItemLedger_OpeningStock.Size = new System.Drawing.Size(103, 22);
            this.txt_ItemLedger_OpeningStock.TabIndex = 24;
            // 
            // lbl_ItemLedger_OpeningStock
            // 
            this.lbl_ItemLedger_OpeningStock.AutoSize = true;
            this.lbl_ItemLedger_OpeningStock.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemLedger_OpeningStock.Location = new System.Drawing.Point(558, 12);
            this.lbl_ItemLedger_OpeningStock.Name = "lbl_ItemLedger_OpeningStock";
            this.lbl_ItemLedger_OpeningStock.Size = new System.Drawing.Size(89, 15);
            this.lbl_ItemLedger_OpeningStock.TabIndex = 23;
            this.lbl_ItemLedger_OpeningStock.Text = "Opening Stock";
            // 
            // btn_ItemLedger_Process
            // 
            this.btn_ItemLedger_Process.Location = new System.Drawing.Point(473, 69);
            this.btn_ItemLedger_Process.Name = "btn_ItemLedger_Process";
            this.btn_ItemLedger_Process.Size = new System.Drawing.Size(82, 50);
            this.btn_ItemLedger_Process.TabIndex = 22;
            this.btn_ItemLedger_Process.Text = "Process";
            this.btn_ItemLedger_Process.UseVisualStyleBackColor = true;
            // 
            // lbl_ItemLedger_ItemSerielNoWiseReport
            // 
            this.lbl_ItemLedger_ItemSerielNoWiseReport.AutoSize = true;
            this.lbl_ItemLedger_ItemSerielNoWiseReport.Location = new System.Drawing.Point(311, 27);
            this.lbl_ItemLedger_ItemSerielNoWiseReport.Name = "lbl_ItemLedger_ItemSerielNoWiseReport";
            this.lbl_ItemLedger_ItemSerielNoWiseReport.Size = new System.Drawing.Size(153, 15);
            this.lbl_ItemLedger_ItemSerielNoWiseReport.TabIndex = 21;
            this.lbl_ItemLedger_ItemSerielNoWiseReport.TabStop = true;
            this.lbl_ItemLedger_ItemSerielNoWiseReport.Text = "Item Seriel No. Wise Report";
            // 
            // cb_ItemLedger_CostCenter
            // 
            this.cb_ItemLedger_CostCenter.AutoSize = true;
            this.cb_ItemLedger_CostCenter.Location = new System.Drawing.Point(312, 45);
            this.cb_ItemLedger_CostCenter.Name = "cb_ItemLedger_CostCenter";
            this.cb_ItemLedger_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_ItemLedger_CostCenter.TabIndex = 20;
            this.cb_ItemLedger_CostCenter.Text = "Cost Center";
            this.cb_ItemLedger_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_ItemLedger_CostCenter
            // 
            this.cob_ItemLedger_CostCenter.FormattingEnabled = true;
            this.cob_ItemLedger_CostCenter.Location = new System.Drawing.Point(302, 69);
            this.cob_ItemLedger_CostCenter.Name = "cob_ItemLedger_CostCenter";
            this.cob_ItemLedger_CostCenter.Size = new System.Drawing.Size(165, 23);
            this.cob_ItemLedger_CostCenter.TabIndex = 19;
            // 
            // txt_ItemLedger_Barcode
            // 
            this.txt_ItemLedger_Barcode.Location = new System.Drawing.Point(89, 69);
            this.txt_ItemLedger_Barcode.Name = "txt_ItemLedger_Barcode";
            this.txt_ItemLedger_Barcode.Size = new System.Drawing.Size(207, 22);
            this.txt_ItemLedger_Barcode.TabIndex = 18;
            // 
            // lbl_ItemLedger_Barcode
            // 
            this.lbl_ItemLedger_Barcode.AutoSize = true;
            this.lbl_ItemLedger_Barcode.Location = new System.Drawing.Point(10, 72);
            this.lbl_ItemLedger_Barcode.Name = "lbl_ItemLedger_Barcode";
            this.lbl_ItemLedger_Barcode.Size = new System.Drawing.Size(51, 15);
            this.lbl_ItemLedger_Barcode.TabIndex = 17;
            this.lbl_ItemLedger_Barcode.Text = "Barcode";
            // 
            // gb_ItemLedger_SelectDatePeriod
            // 
            this.gb_ItemLedger_SelectDatePeriod.Controls.Add(this.dt_ItemLedger_DateTo);
            this.gb_ItemLedger_SelectDatePeriod.Controls.Add(this.lbl_ItemLedger_DateTo);
            this.gb_ItemLedger_SelectDatePeriod.Controls.Add(this.dt_ItemLedger_DateFrom);
            this.gb_ItemLedger_SelectDatePeriod.Controls.Add(this.lbl_ItemLedger_DateFrom);
            this.gb_ItemLedger_SelectDatePeriod.Location = new System.Drawing.Point(13, 12);
            this.gb_ItemLedger_SelectDatePeriod.Name = "gb_ItemLedger_SelectDatePeriod";
            this.gb_ItemLedger_SelectDatePeriod.Size = new System.Drawing.Size(292, 51);
            this.gb_ItemLedger_SelectDatePeriod.TabIndex = 16;
            this.gb_ItemLedger_SelectDatePeriod.TabStop = false;
            this.gb_ItemLedger_SelectDatePeriod.Text = "Select Date Period";
            // 
            // dt_ItemLedger_DateTo
            // 
            this.dt_ItemLedger_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ItemLedger_DateTo.Location = new System.Drawing.Point(182, 21);
            this.dt_ItemLedger_DateTo.Name = "dt_ItemLedger_DateTo";
            this.dt_ItemLedger_DateTo.Size = new System.Drawing.Size(101, 22);
            this.dt_ItemLedger_DateTo.TabIndex = 3;
            // 
            // lbl_ItemLedger_DateTo
            // 
            this.lbl_ItemLedger_DateTo.AutoSize = true;
            this.lbl_ItemLedger_DateTo.Location = new System.Drawing.Point(155, 22);
            this.lbl_ItemLedger_DateTo.Name = "lbl_ItemLedger_DateTo";
            this.lbl_ItemLedger_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_ItemLedger_DateTo.TabIndex = 2;
            this.lbl_ItemLedger_DateTo.Text = "To";
            // 
            // dt_ItemLedger_DateFrom
            // 
            this.dt_ItemLedger_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ItemLedger_DateFrom.Location = new System.Drawing.Point(48, 22);
            this.dt_ItemLedger_DateFrom.Name = "dt_ItemLedger_DateFrom";
            this.dt_ItemLedger_DateFrom.Size = new System.Drawing.Size(101, 22);
            this.dt_ItemLedger_DateFrom.TabIndex = 1;
            // 
            // lbl_ItemLedger_DateFrom
            // 
            this.lbl_ItemLedger_DateFrom.AutoSize = true;
            this.lbl_ItemLedger_DateFrom.Location = new System.Drawing.Point(7, 22);
            this.lbl_ItemLedger_DateFrom.Name = "lbl_ItemLedger_DateFrom";
            this.lbl_ItemLedger_DateFrom.Size = new System.Drawing.Size(34, 15);
            this.lbl_ItemLedger_DateFrom.TabIndex = 0;
            this.lbl_ItemLedger_DateFrom.Text = "From";
            // 
            // GV_ItemLedger_TransactionDetails
            // 
            this.GV_ItemLedger_TransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ItemLedger_TransactionDetails.Location = new System.Drawing.Point(801, 13);
            this.GV_ItemLedger_TransactionDetails.Name = "GV_ItemLedger_TransactionDetails";
            this.GV_ItemLedger_TransactionDetails.Size = new System.Drawing.Size(276, 162);
            this.GV_ItemLedger_TransactionDetails.TabIndex = 17;
            // 
            // GV_ItemLedger_ItemDetails
            // 
            this.GV_ItemLedger_ItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ItemLedger_ItemDetails.Location = new System.Drawing.Point(13, 182);
            this.GV_ItemLedger_ItemDetails.Name = "GV_ItemLedger_ItemDetails";
            this.GV_ItemLedger_ItemDetails.Size = new System.Drawing.Size(1064, 325);
            this.GV_ItemLedger_ItemDetails.TabIndex = 18;
            // 
            // frm_Transactions_ItemLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 519);
            this.Controls.Add(this.GV_ItemLedger_ItemDetails);
            this.Controls.Add(this.GV_ItemLedger_TransactionDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_ItemLedger";
            this.Text = "frm_Transactions_ItemLedger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_ItemLedger_SelectDatePeriod.ResumeLayout(false);
            this.gb_ItemLedger_SelectDatePeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemLedger_TransactionDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemLedger_ItemDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ItemLedger_Filter;
        private System.Windows.Forms.TextBox txt_ItemLedger_ItemName;
        private System.Windows.Forms.Label lbl_ItemLedger_ItemName;
        private System.Windows.Forms.ComboBox cob_ItemLedger_Transactions;
        private System.Windows.Forms.Label lbl_ItemLedger_FilterByTransactions;
        private System.Windows.Forms.TextBox txt_ItemLedger_ClosingStock;
        private System.Windows.Forms.Label lbl_ItemLedger_ClosingStock;
        private System.Windows.Forms.TextBox txt_ItemLedger_OpeningStock;
        private System.Windows.Forms.Label lbl_ItemLedger_OpeningStock;
        private System.Windows.Forms.Button btn_ItemLedger_Process;
        private System.Windows.Forms.LinkLabel lbl_ItemLedger_ItemSerielNoWiseReport;
        private System.Windows.Forms.CheckBox cb_ItemLedger_CostCenter;
        private System.Windows.Forms.ComboBox cob_ItemLedger_CostCenter;
        private System.Windows.Forms.TextBox txt_ItemLedger_Barcode;
        private System.Windows.Forms.Label lbl_ItemLedger_Barcode;
        private System.Windows.Forms.GroupBox gb_ItemLedger_SelectDatePeriod;
        private System.Windows.Forms.DateTimePicker dt_ItemLedger_DateTo;
        private System.Windows.Forms.Label lbl_ItemLedger_DateTo;
        private System.Windows.Forms.DateTimePicker dt_ItemLedger_DateFrom;
        private System.Windows.Forms.Label lbl_ItemLedger_DateFrom;
        private System.Windows.Forms.DataGridView GV_ItemLedger_TransactionDetails;
        private System.Windows.Forms.DataGridView GV_ItemLedger_ItemDetails;
    }
}