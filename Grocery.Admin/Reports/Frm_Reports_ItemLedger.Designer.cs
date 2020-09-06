namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_ItemLedger
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
            this.gb_ItemLedger_SelectDatePeriod = new System.Windows.Forms.GroupBox();
            this.dt_ItemLedger_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_ItemLedger_DateTo = new System.Windows.Forms.Label();
            this.dt_ItemLedger_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_ItemLedger_DateFrom = new System.Windows.Forms.Label();
            this.cb_ItemLedger_CostCenter = new System.Windows.Forms.CheckBox();
            this.lbl_ItemLedger_Barcode = new System.Windows.Forms.Label();
            this.txt_ItemLedger_Barcode = new System.Windows.Forms.TextBox();
            this.cob_ItemLedger_CostCenter = new System.Windows.Forms.ComboBox();
            this.lbl_ItemLedger_ItemName = new System.Windows.Forms.Label();
            this.txt_ItemLedger_ItemName = new System.Windows.Forms.TextBox();
            this.btn_ItemLedger_Process = new System.Windows.Forms.Button();
            this.lbl_ItemLedger_ItemSerielNoWiseReport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ItemLedger_Filter = new System.Windows.Forms.Button();
            this.cob_ItemLedger_FilterByTransactions = new System.Windows.Forms.ComboBox();
            this.lbl_ItemLedger_FilterByTransactions = new System.Windows.Forms.Label();
            this.txt_ItemLedger_ClosingStock = new System.Windows.Forms.TextBox();
            this.lbl_ItemLedger_ClosingStock = new System.Windows.Forms.Label();
            this.txt_ItemLedger_OpeningStock = new System.Windows.Forms.TextBox();
            this.lbl_ItemLedger_OpeningStock = new System.Windows.Forms.Label();
            this.GV_ItemLedger_ItemDetails = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gb_ItemLedger_SelectDatePeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_ItemLedger_ItemSerielNoWiseReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemLedger_ItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ItemLedger_SelectDatePeriod
            // 
            this.gb_ItemLedger_SelectDatePeriod.Controls.Add(this.dt_ItemLedger_DateTo);
            this.gb_ItemLedger_SelectDatePeriod.Controls.Add(this.lbl_ItemLedger_DateTo);
            this.gb_ItemLedger_SelectDatePeriod.Controls.Add(this.dt_ItemLedger_DateFrom);
            this.gb_ItemLedger_SelectDatePeriod.Controls.Add(this.lbl_ItemLedger_DateFrom);
            this.gb_ItemLedger_SelectDatePeriod.Location = new System.Drawing.Point(12, 12);
            this.gb_ItemLedger_SelectDatePeriod.Name = "gb_ItemLedger_SelectDatePeriod";
            this.gb_ItemLedger_SelectDatePeriod.Size = new System.Drawing.Size(306, 58);
            this.gb_ItemLedger_SelectDatePeriod.TabIndex = 0;
            this.gb_ItemLedger_SelectDatePeriod.TabStop = false;
            this.gb_ItemLedger_SelectDatePeriod.Text = "Select Date Period";
            // 
            // dt_ItemLedger_DateTo
            // 
            this.dt_ItemLedger_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ItemLedger_DateTo.Location = new System.Drawing.Point(189, 29);
            this.dt_ItemLedger_DateTo.Name = "dt_ItemLedger_DateTo";
            this.dt_ItemLedger_DateTo.Size = new System.Drawing.Size(109, 22);
            this.dt_ItemLedger_DateTo.TabIndex = 3;
            // 
            // lbl_ItemLedger_DateTo
            // 
            this.lbl_ItemLedger_DateTo.AutoSize = true;
            this.lbl_ItemLedger_DateTo.Location = new System.Drawing.Point(162, 30);
            this.lbl_ItemLedger_DateTo.Name = "lbl_ItemLedger_DateTo";
            this.lbl_ItemLedger_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_ItemLedger_DateTo.TabIndex = 2;
            this.lbl_ItemLedger_DateTo.Text = "To";
            // 
            // dt_ItemLedger_DateFrom
            // 
            this.dt_ItemLedger_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ItemLedger_DateFrom.Location = new System.Drawing.Point(47, 30);
            this.dt_ItemLedger_DateFrom.Name = "dt_ItemLedger_DateFrom";
            this.dt_ItemLedger_DateFrom.Size = new System.Drawing.Size(109, 22);
            this.dt_ItemLedger_DateFrom.TabIndex = 1;
            // 
            // lbl_ItemLedger_DateFrom
            // 
            this.lbl_ItemLedger_DateFrom.AutoSize = true;
            this.lbl_ItemLedger_DateFrom.Location = new System.Drawing.Point(6, 30);
            this.lbl_ItemLedger_DateFrom.Name = "lbl_ItemLedger_DateFrom";
            this.lbl_ItemLedger_DateFrom.Size = new System.Drawing.Size(34, 15);
            this.lbl_ItemLedger_DateFrom.TabIndex = 0;
            this.lbl_ItemLedger_DateFrom.Text = "From";
            // 
            // cb_ItemLedger_CostCenter
            // 
            this.cb_ItemLedger_CostCenter.AutoSize = true;
            this.cb_ItemLedger_CostCenter.Location = new System.Drawing.Point(324, 51);
            this.cb_ItemLedger_CostCenter.Name = "cb_ItemLedger_CostCenter";
            this.cb_ItemLedger_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_ItemLedger_CostCenter.TabIndex = 1;
            this.cb_ItemLedger_CostCenter.Text = "Cost Center";
            this.cb_ItemLedger_CostCenter.UseVisualStyleBackColor = true;
            // 
            // lbl_ItemLedger_Barcode
            // 
            this.lbl_ItemLedger_Barcode.AutoSize = true;
            this.lbl_ItemLedger_Barcode.Location = new System.Drawing.Point(9, 79);
            this.lbl_ItemLedger_Barcode.Name = "lbl_ItemLedger_Barcode";
            this.lbl_ItemLedger_Barcode.Size = new System.Drawing.Size(51, 15);
            this.lbl_ItemLedger_Barcode.TabIndex = 2;
            this.lbl_ItemLedger_Barcode.Text = "Barcode";
            // 
            // txt_ItemLedger_Barcode
            // 
            this.txt_ItemLedger_Barcode.Location = new System.Drawing.Point(90, 76);
            this.txt_ItemLedger_Barcode.Name = "txt_ItemLedger_Barcode";
            this.txt_ItemLedger_Barcode.Size = new System.Drawing.Size(228, 22);
            this.txt_ItemLedger_Barcode.TabIndex = 3;
            // 
            // cob_ItemLedger_CostCenter
            // 
            this.cob_ItemLedger_CostCenter.FormattingEnabled = true;
            this.cob_ItemLedger_CostCenter.Location = new System.Drawing.Point(333, 76);
            this.cob_ItemLedger_CostCenter.Name = "cob_ItemLedger_CostCenter";
            this.cob_ItemLedger_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_ItemLedger_CostCenter.TabIndex = 4;
            // 
            // lbl_ItemLedger_ItemName
            // 
            this.lbl_ItemLedger_ItemName.AutoSize = true;
            this.lbl_ItemLedger_ItemName.Location = new System.Drawing.Point(9, 101);
            this.lbl_ItemLedger_ItemName.Name = "lbl_ItemLedger_ItemName";
            this.lbl_ItemLedger_ItemName.Size = new System.Drawing.Size(63, 15);
            this.lbl_ItemLedger_ItemName.TabIndex = 5;
            this.lbl_ItemLedger_ItemName.Text = "Item Name";
            // 
            // txt_ItemLedger_ItemName
            // 
            this.txt_ItemLedger_ItemName.Location = new System.Drawing.Point(90, 103);
            this.txt_ItemLedger_ItemName.Name = "txt_ItemLedger_ItemName";
            this.txt_ItemLedger_ItemName.Size = new System.Drawing.Size(364, 22);
            this.txt_ItemLedger_ItemName.TabIndex = 6;
            // 
            // btn_ItemLedger_Process
            // 
            this.btn_ItemLedger_Process.Location = new System.Drawing.Point(460, 74);
            this.btn_ItemLedger_Process.Name = "btn_ItemLedger_Process";
            this.btn_ItemLedger_Process.Size = new System.Drawing.Size(67, 51);
            this.btn_ItemLedger_Process.TabIndex = 7;
            this.btn_ItemLedger_Process.Text = "&Process";
            this.btn_ItemLedger_Process.UseVisualStyleBackColor = true;
            // 
            // lbl_ItemLedger_ItemSerielNoWiseReport
            // 
            this.lbl_ItemLedger_ItemSerielNoWiseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lbl_ItemLedger_ItemSerielNoWiseReport.Location = new System.Drawing.Point(757, 12);
            this.lbl_ItemLedger_ItemSerielNoWiseReport.Name = "lbl_ItemLedger_ItemSerielNoWiseReport";
            this.lbl_ItemLedger_ItemSerielNoWiseReport.Size = new System.Drawing.Size(267, 136);
            this.lbl_ItemLedger_ItemSerielNoWiseReport.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btn_ItemLedger_Filter);
            this.panel1.Controls.Add(this.cob_ItemLedger_FilterByTransactions);
            this.panel1.Controls.Add(this.lbl_ItemLedger_FilterByTransactions);
            this.panel1.Controls.Add(this.txt_ItemLedger_ClosingStock);
            this.panel1.Controls.Add(this.lbl_ItemLedger_ClosingStock);
            this.panel1.Controls.Add(this.txt_ItemLedger_OpeningStock);
            this.panel1.Controls.Add(this.lbl_ItemLedger_OpeningStock);
            this.panel1.Controls.Add(this.gb_ItemLedger_SelectDatePeriod);
            this.panel1.Controls.Add(this.lbl_ItemLedger_Barcode);
            this.panel1.Controls.Add(this.txt_ItemLedger_Barcode);
            this.panel1.Controls.Add(this.lbl_ItemLedger_ItemName);
            this.panel1.Controls.Add(this.txt_ItemLedger_ItemName);
            this.panel1.Controls.Add(this.cb_ItemLedger_CostCenter);
            this.panel1.Controls.Add(this.cob_ItemLedger_CostCenter);
            this.panel1.Controls.Add(this.btn_ItemLedger_Process);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 136);
            this.panel1.TabIndex = 16;
            // 
            // btn_ItemLedger_Filter
            // 
            this.btn_ItemLedger_Filter.Location = new System.Drawing.Point(660, 83);
            this.btn_ItemLedger_Filter.Name = "btn_ItemLedger_Filter";
            this.btn_ItemLedger_Filter.Size = new System.Drawing.Size(67, 41);
            this.btn_ItemLedger_Filter.TabIndex = 21;
            this.btn_ItemLedger_Filter.Text = "&Filter";
            this.btn_ItemLedger_Filter.UseVisualStyleBackColor = true;
            // 
            // cob_ItemLedger_FilterByTransactions
            // 
            this.cob_ItemLedger_FilterByTransactions.FormattingEnabled = true;
            this.cob_ItemLedger_FilterByTransactions.Location = new System.Drawing.Point(532, 101);
            this.cob_ItemLedger_FilterByTransactions.Name = "cob_ItemLedger_FilterByTransactions";
            this.cob_ItemLedger_FilterByTransactions.Size = new System.Drawing.Size(121, 23);
            this.cob_ItemLedger_FilterByTransactions.TabIndex = 20;
            // 
            // lbl_ItemLedger_FilterByTransactions
            // 
            this.lbl_ItemLedger_FilterByTransactions.AutoSize = true;
            this.lbl_ItemLedger_FilterByTransactions.Location = new System.Drawing.Point(529, 83);
            this.lbl_ItemLedger_FilterByTransactions.Name = "lbl_ItemLedger_FilterByTransactions";
            this.lbl_ItemLedger_FilterByTransactions.Size = new System.Drawing.Size(125, 15);
            this.lbl_ItemLedger_FilterByTransactions.TabIndex = 19;
            this.lbl_ItemLedger_FilterByTransactions.Text = "Filter By Transactions";
            // 
            // txt_ItemLedger_ClosingStock
            // 
            this.txt_ItemLedger_ClosingStock.Location = new System.Drawing.Point(630, 48);
            this.txt_ItemLedger_ClosingStock.Name = "txt_ItemLedger_ClosingStock";
            this.txt_ItemLedger_ClosingStock.Size = new System.Drawing.Size(96, 22);
            this.txt_ItemLedger_ClosingStock.TabIndex = 18;
            // 
            // lbl_ItemLedger_ClosingStock
            // 
            this.lbl_ItemLedger_ClosingStock.AutoSize = true;
            this.lbl_ItemLedger_ClosingStock.Location = new System.Drawing.Point(627, 30);
            this.lbl_ItemLedger_ClosingStock.Name = "lbl_ItemLedger_ClosingStock";
            this.lbl_ItemLedger_ClosingStock.Size = new System.Drawing.Size(81, 15);
            this.lbl_ItemLedger_ClosingStock.TabIndex = 17;
            this.lbl_ItemLedger_ClosingStock.Text = "Closing Stock";
            // 
            // txt_ItemLedger_OpeningStock
            // 
            this.txt_ItemLedger_OpeningStock.Location = new System.Drawing.Point(524, 48);
            this.txt_ItemLedger_OpeningStock.Name = "txt_ItemLedger_OpeningStock";
            this.txt_ItemLedger_OpeningStock.Size = new System.Drawing.Size(96, 22);
            this.txt_ItemLedger_OpeningStock.TabIndex = 16;
            // 
            // lbl_ItemLedger_OpeningStock
            // 
            this.lbl_ItemLedger_OpeningStock.AutoSize = true;
            this.lbl_ItemLedger_OpeningStock.Location = new System.Drawing.Point(521, 30);
            this.lbl_ItemLedger_OpeningStock.Name = "lbl_ItemLedger_OpeningStock";
            this.lbl_ItemLedger_OpeningStock.Size = new System.Drawing.Size(86, 15);
            this.lbl_ItemLedger_OpeningStock.TabIndex = 15;
            this.lbl_ItemLedger_OpeningStock.Text = "Opening Stock";
            // 
            // GV_ItemLedger_ItemDetails
            // 
            this.GV_ItemLedger_ItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ItemLedger_ItemDetails.Location = new System.Drawing.Point(12, 155);
            this.GV_ItemLedger_ItemDetails.Name = "GV_ItemLedger_ItemDetails";
            this.GV_ItemLedger_ItemDetails.Size = new System.Drawing.Size(1012, 352);
            this.GV_ItemLedger_ItemDetails.TabIndex = 17;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(333, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 15);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Item Seriel No Wise Report";
            // 
            // Frm_Reports_ItemLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 519);
            this.Controls.Add(this.GV_ItemLedger_ItemDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_ItemLedger_ItemSerielNoWiseReport);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_ItemLedger";
            this.Text = "Frm_Reports_ItemLedger";
            this.gb_ItemLedger_SelectDatePeriod.ResumeLayout(false);
            this.gb_ItemLedger_SelectDatePeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_ItemLedger_ItemSerielNoWiseReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemLedger_ItemDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ItemLedger_SelectDatePeriod;
        private System.Windows.Forms.DateTimePicker dt_ItemLedger_DateTo;
        private System.Windows.Forms.Label lbl_ItemLedger_DateTo;
        private System.Windows.Forms.DateTimePicker dt_ItemLedger_DateFrom;
        private System.Windows.Forms.Label lbl_ItemLedger_DateFrom;
        private System.Windows.Forms.CheckBox cb_ItemLedger_CostCenter;
        private System.Windows.Forms.Label lbl_ItemLedger_Barcode;
        private System.Windows.Forms.TextBox txt_ItemLedger_Barcode;
        private System.Windows.Forms.ComboBox cob_ItemLedger_CostCenter;
        private System.Windows.Forms.Label lbl_ItemLedger_ItemName;
        private System.Windows.Forms.TextBox txt_ItemLedger_ItemName;
        private System.Windows.Forms.Button btn_ItemLedger_Process;
        private System.Windows.Forms.DataGridView lbl_ItemLedger_ItemSerielNoWiseReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ItemLedger_Filter;
        private System.Windows.Forms.ComboBox cob_ItemLedger_FilterByTransactions;
        private System.Windows.Forms.Label lbl_ItemLedger_FilterByTransactions;
        private System.Windows.Forms.TextBox txt_ItemLedger_ClosingStock;
        private System.Windows.Forms.Label lbl_ItemLedger_ClosingStock;
        private System.Windows.Forms.TextBox txt_ItemLedger_OpeningStock;
        private System.Windows.Forms.Label lbl_ItemLedger_OpeningStock;
        private System.Windows.Forms.DataGridView GV_ItemLedger_ItemDetails;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}