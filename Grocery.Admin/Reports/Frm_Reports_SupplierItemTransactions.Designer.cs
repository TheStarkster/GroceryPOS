namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_SupplierItemTransactions
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
            this.lbl_SupplierItemTransactions_DateFrom = new System.Windows.Forms.Label();
            this.dt_SupplierItemTransactions_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.dt_SupplierItemTransactions_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_SupplierItemTransactions_DateTo = new System.Windows.Forms.Label();
            this.lbl_SupplierItemTransactions_SupplierName = new System.Windows.Forms.Label();
            this.cob_SupplierItemTransactions_SupplierName = new System.Windows.Forms.ComboBox();
            this.cb_SupplierItemTransactions_FilterByCategory = new System.Windows.Forms.CheckBox();
            this.cob_SupplierItemTransactions_Category = new System.Windows.Forms.ComboBox();
            this.cb_SupplierItemTransactions_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_SupplierItemTransactions_CostCenter = new System.Windows.Forms.ComboBox();
            this.btn_SupplierItemTransactions_Search = new System.Windows.Forms.Button();
            this.btn_SupplierItemTransactions_Print = new System.Windows.Forms.Button();
            this.cb_SupplierItemTransactions_NewZeroStockQtys = new System.Windows.Forms.CheckBox();
            this.btn_SupplierItemTransactions_SalesOnlyPrint = new System.Windows.Forms.Button();
            this.lbl_SupplierItemTransactions_DocumentWiseSales = new System.Windows.Forms.LinkLabel();
            this.GV_SupplierItemTransactions_ItemDetails = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SupplierItemTransactions_ItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_SupplierItemTransactions_DocumentWiseSales);
            this.panel1.Controls.Add(this.btn_SupplierItemTransactions_SalesOnlyPrint);
            this.panel1.Controls.Add(this.cb_SupplierItemTransactions_NewZeroStockQtys);
            this.panel1.Controls.Add(this.btn_SupplierItemTransactions_Print);
            this.panel1.Controls.Add(this.btn_SupplierItemTransactions_Search);
            this.panel1.Controls.Add(this.cob_SupplierItemTransactions_CostCenter);
            this.panel1.Controls.Add(this.cb_SupplierItemTransactions_CostCenter);
            this.panel1.Controls.Add(this.cob_SupplierItemTransactions_Category);
            this.panel1.Controls.Add(this.cb_SupplierItemTransactions_FilterByCategory);
            this.panel1.Controls.Add(this.cob_SupplierItemTransactions_SupplierName);
            this.panel1.Controls.Add(this.lbl_SupplierItemTransactions_SupplierName);
            this.panel1.Controls.Add(this.dt_SupplierItemTransactions_DateTo);
            this.panel1.Controls.Add(this.lbl_SupplierItemTransactions_DateTo);
            this.panel1.Controls.Add(this.dt_SupplierItemTransactions_DateFrom);
            this.panel1.Controls.Add(this.lbl_SupplierItemTransactions_DateFrom);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbl_SupplierItemTransactions_DateFrom
            // 
            this.lbl_SupplierItemTransactions_DateFrom.AutoSize = true;
            this.lbl_SupplierItemTransactions_DateFrom.Location = new System.Drawing.Point(14, 19);
            this.lbl_SupplierItemTransactions_DateFrom.Name = "lbl_SupplierItemTransactions_DateFrom";
            this.lbl_SupplierItemTransactions_DateFrom.Size = new System.Drawing.Size(62, 15);
            this.lbl_SupplierItemTransactions_DateFrom.TabIndex = 0;
            this.lbl_SupplierItemTransactions_DateFrom.Text = "Date From";
            // 
            // dt_SupplierItemTransactions_DateFrom
            // 
            this.dt_SupplierItemTransactions_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_SupplierItemTransactions_DateFrom.Location = new System.Drawing.Point(146, 13);
            this.dt_SupplierItemTransactions_DateFrom.Name = "dt_SupplierItemTransactions_DateFrom";
            this.dt_SupplierItemTransactions_DateFrom.Size = new System.Drawing.Size(102, 22);
            this.dt_SupplierItemTransactions_DateFrom.TabIndex = 1;
            // 
            // dt_SupplierItemTransactions_DateTo
            // 
            this.dt_SupplierItemTransactions_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_SupplierItemTransactions_DateTo.Location = new System.Drawing.Point(327, 13);
            this.dt_SupplierItemTransactions_DateTo.Name = "dt_SupplierItemTransactions_DateTo";
            this.dt_SupplierItemTransactions_DateTo.Size = new System.Drawing.Size(102, 22);
            this.dt_SupplierItemTransactions_DateTo.TabIndex = 3;
            // 
            // lbl_SupplierItemTransactions_DateTo
            // 
            this.lbl_SupplierItemTransactions_DateTo.AutoSize = true;
            this.lbl_SupplierItemTransactions_DateTo.Location = new System.Drawing.Point(272, 19);
            this.lbl_SupplierItemTransactions_DateTo.Name = "lbl_SupplierItemTransactions_DateTo";
            this.lbl_SupplierItemTransactions_DateTo.Size = new System.Drawing.Size(49, 15);
            this.lbl_SupplierItemTransactions_DateTo.TabIndex = 2;
            this.lbl_SupplierItemTransactions_DateTo.Text = "Date To";
            // 
            // lbl_SupplierItemTransactions_SupplierName
            // 
            this.lbl_SupplierItemTransactions_SupplierName.AutoSize = true;
            this.lbl_SupplierItemTransactions_SupplierName.Location = new System.Drawing.Point(14, 41);
            this.lbl_SupplierItemTransactions_SupplierName.Name = "lbl_SupplierItemTransactions_SupplierName";
            this.lbl_SupplierItemTransactions_SupplierName.Size = new System.Drawing.Size(84, 15);
            this.lbl_SupplierItemTransactions_SupplierName.TabIndex = 4;
            this.lbl_SupplierItemTransactions_SupplierName.Text = "Supplier Name";
            // 
            // cob_SupplierItemTransactions_SupplierName
            // 
            this.cob_SupplierItemTransactions_SupplierName.FormattingEnabled = true;
            this.cob_SupplierItemTransactions_SupplierName.Location = new System.Drawing.Point(146, 38);
            this.cob_SupplierItemTransactions_SupplierName.Name = "cob_SupplierItemTransactions_SupplierName";
            this.cob_SupplierItemTransactions_SupplierName.Size = new System.Drawing.Size(283, 23);
            this.cob_SupplierItemTransactions_SupplierName.TabIndex = 5;
            // 
            // cb_SupplierItemTransactions_FilterByCategory
            // 
            this.cb_SupplierItemTransactions_FilterByCategory.AutoSize = true;
            this.cb_SupplierItemTransactions_FilterByCategory.Location = new System.Drawing.Point(17, 69);
            this.cb_SupplierItemTransactions_FilterByCategory.Name = "cb_SupplierItemTransactions_FilterByCategory";
            this.cb_SupplierItemTransactions_FilterByCategory.Size = new System.Drawing.Size(123, 19);
            this.cb_SupplierItemTransactions_FilterByCategory.TabIndex = 6;
            this.cb_SupplierItemTransactions_FilterByCategory.Text = "Filter By Category";
            this.cb_SupplierItemTransactions_FilterByCategory.UseVisualStyleBackColor = true;
            // 
            // cob_SupplierItemTransactions_Category
            // 
            this.cob_SupplierItemTransactions_Category.FormattingEnabled = true;
            this.cob_SupplierItemTransactions_Category.Location = new System.Drawing.Point(146, 67);
            this.cob_SupplierItemTransactions_Category.Name = "cob_SupplierItemTransactions_Category";
            this.cob_SupplierItemTransactions_Category.Size = new System.Drawing.Size(283, 23);
            this.cob_SupplierItemTransactions_Category.TabIndex = 7;
            // 
            // cb_SupplierItemTransactions_CostCenter
            // 
            this.cb_SupplierItemTransactions_CostCenter.AutoSize = true;
            this.cb_SupplierItemTransactions_CostCenter.Location = new System.Drawing.Point(436, 43);
            this.cb_SupplierItemTransactions_CostCenter.Name = "cb_SupplierItemTransactions_CostCenter";
            this.cb_SupplierItemTransactions_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_SupplierItemTransactions_CostCenter.TabIndex = 8;
            this.cb_SupplierItemTransactions_CostCenter.Text = "Cost Center";
            this.cb_SupplierItemTransactions_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_SupplierItemTransactions_CostCenter
            // 
            this.cob_SupplierItemTransactions_CostCenter.FormattingEnabled = true;
            this.cob_SupplierItemTransactions_CostCenter.Location = new System.Drawing.Point(435, 67);
            this.cob_SupplierItemTransactions_CostCenter.Name = "cob_SupplierItemTransactions_CostCenter";
            this.cob_SupplierItemTransactions_CostCenter.Size = new System.Drawing.Size(106, 23);
            this.cob_SupplierItemTransactions_CostCenter.TabIndex = 9;
            // 
            // btn_SupplierItemTransactions_Search
            // 
            this.btn_SupplierItemTransactions_Search.Location = new System.Drawing.Point(553, 15);
            this.btn_SupplierItemTransactions_Search.Name = "btn_SupplierItemTransactions_Search";
            this.btn_SupplierItemTransactions_Search.Size = new System.Drawing.Size(85, 36);
            this.btn_SupplierItemTransactions_Search.TabIndex = 10;
            this.btn_SupplierItemTransactions_Search.Text = "Search";
            this.btn_SupplierItemTransactions_Search.UseVisualStyleBackColor = true;
            // 
            // btn_SupplierItemTransactions_Print
            // 
            this.btn_SupplierItemTransactions_Print.Location = new System.Drawing.Point(553, 57);
            this.btn_SupplierItemTransactions_Print.Name = "btn_SupplierItemTransactions_Print";
            this.btn_SupplierItemTransactions_Print.Size = new System.Drawing.Size(85, 33);
            this.btn_SupplierItemTransactions_Print.TabIndex = 11;
            this.btn_SupplierItemTransactions_Print.Text = "Print";
            this.btn_SupplierItemTransactions_Print.UseVisualStyleBackColor = true;
            // 
            // cb_SupplierItemTransactions_NewZeroStockQtys
            // 
            this.cb_SupplierItemTransactions_NewZeroStockQtys.AutoSize = true;
            this.cb_SupplierItemTransactions_NewZeroStockQtys.Location = new System.Drawing.Point(644, 25);
            this.cb_SupplierItemTransactions_NewZeroStockQtys.Name = "cb_SupplierItemTransactions_NewZeroStockQtys";
            this.cb_SupplierItemTransactions_NewZeroStockQtys.Size = new System.Drawing.Size(140, 19);
            this.cb_SupplierItemTransactions_NewZeroStockQtys.TabIndex = 12;
            this.cb_SupplierItemTransactions_NewZeroStockQtys.Text = "New Zero Stock Qtys";
            this.cb_SupplierItemTransactions_NewZeroStockQtys.UseVisualStyleBackColor = true;
            // 
            // btn_SupplierItemTransactions_SalesOnlyPrint
            // 
            this.btn_SupplierItemTransactions_SalesOnlyPrint.Location = new System.Drawing.Point(644, 50);
            this.btn_SupplierItemTransactions_SalesOnlyPrint.Name = "btn_SupplierItemTransactions_SalesOnlyPrint";
            this.btn_SupplierItemTransactions_SalesOnlyPrint.Size = new System.Drawing.Size(85, 40);
            this.btn_SupplierItemTransactions_SalesOnlyPrint.TabIndex = 13;
            this.btn_SupplierItemTransactions_SalesOnlyPrint.Text = "Sales Only Print";
            this.btn_SupplierItemTransactions_SalesOnlyPrint.UseVisualStyleBackColor = true;
            // 
            // lbl_SupplierItemTransactions_DocumentWiseSales
            // 
            this.lbl_SupplierItemTransactions_DocumentWiseSales.AutoSize = true;
            this.lbl_SupplierItemTransactions_DocumentWiseSales.Location = new System.Drawing.Point(803, 75);
            this.lbl_SupplierItemTransactions_DocumentWiseSales.Name = "lbl_SupplierItemTransactions_DocumentWiseSales";
            this.lbl_SupplierItemTransactions_DocumentWiseSales.Size = new System.Drawing.Size(123, 15);
            this.lbl_SupplierItemTransactions_DocumentWiseSales.TabIndex = 14;
            this.lbl_SupplierItemTransactions_DocumentWiseSales.TabStop = true;
            this.lbl_SupplierItemTransactions_DocumentWiseSales.Text = "Document Wise Sales";
            // 
            // GV_SupplierItemTransactions_ItemDetails
            // 
            this.GV_SupplierItemTransactions_ItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_SupplierItemTransactions_ItemDetails.Location = new System.Drawing.Point(13, 119);
            this.GV_SupplierItemTransactions_ItemDetails.Name = "GV_SupplierItemTransactions_ItemDetails";
            this.GV_SupplierItemTransactions_ItemDetails.Size = new System.Drawing.Size(940, 315);
            this.GV_SupplierItemTransactions_ItemDetails.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 40);
            this.button4.TabIndex = 14;
            this.button4.Text = "Process";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(105, 440);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(599, 40);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(722, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(762, 447);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(868, 437);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 40);
            this.button5.TabIndex = 18;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Frm_Reports_SupplierItemTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 491);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GV_SupplierItemTransactions_ItemDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_SupplierItemTransactions";
            this.Text = "Frm_Reports_SupplierItemTransactions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SupplierItemTransactions_ItemDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_SupplierItemTransactions_DocumentWiseSales;
        private System.Windows.Forms.Button btn_SupplierItemTransactions_SalesOnlyPrint;
        private System.Windows.Forms.CheckBox cb_SupplierItemTransactions_NewZeroStockQtys;
        private System.Windows.Forms.Button btn_SupplierItemTransactions_Print;
        private System.Windows.Forms.Button btn_SupplierItemTransactions_Search;
        private System.Windows.Forms.ComboBox cob_SupplierItemTransactions_CostCenter;
        private System.Windows.Forms.CheckBox cb_SupplierItemTransactions_CostCenter;
        private System.Windows.Forms.ComboBox cob_SupplierItemTransactions_Category;
        private System.Windows.Forms.CheckBox cb_SupplierItemTransactions_FilterByCategory;
        private System.Windows.Forms.ComboBox cob_SupplierItemTransactions_SupplierName;
        private System.Windows.Forms.Label lbl_SupplierItemTransactions_SupplierName;
        private System.Windows.Forms.DateTimePicker dt_SupplierItemTransactions_DateTo;
        private System.Windows.Forms.Label lbl_SupplierItemTransactions_DateTo;
        private System.Windows.Forms.DateTimePicker dt_SupplierItemTransactions_DateFrom;
        private System.Windows.Forms.Label lbl_SupplierItemTransactions_DateFrom;
        private System.Windows.Forms.DataGridView GV_SupplierItemTransactions_ItemDetails;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
    }
}