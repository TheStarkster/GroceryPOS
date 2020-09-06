namespace Grocery.Admin.Vat_Tax
{
    partial class Frm_VatTax_VatReturnReport
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
            this.lbl_VatReturnReport_VatReturnFromDate = new System.Windows.Forms.Label();
            this.dt_VatReturnReport_VatReturnFromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_VatReturnReport_VatReturnToDate = new System.Windows.Forms.Label();
            this.dt_VatReturnReport_VatReturnToDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_VatReturnReport_TaxYear = new System.Windows.Forms.Label();
            this.dt_VatReturnReport_TaxYear = new System.Windows.Forms.DateTimePicker();
            this.lbl_VatReturnReport_VatReturnRefNo = new System.Windows.Forms.Label();
            this.txt_VatReturnReport_VatReturnRefNo = new System.Windows.Forms.TextBox();
            this.cb_VatReturnReport_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_VatReturnReport_CostCenter = new System.Windows.Forms.ComboBox();
            this.btn_VatReturnReport_Search = new System.Windows.Forms.Button();
            this.btn_VatReturnReport_SaveAndPrint = new System.Windows.Forms.Button();
            this.lbl_VatReturnReport_VatOnSales = new System.Windows.Forms.Label();
            this.GV_VatReturnReport_VatOnSalesDetails = new System.Windows.Forms.DataGridView();
            this.lbl_VatReturnReport_VatOnExpenses = new System.Windows.Forms.Label();
            this.GV_VatReturnReport_VATonExpenses = new System.Windows.Forms.DataGridView();
            this.lbl_VatReturnReport_NetVatDue = new System.Windows.Forms.Label();
            this.GV_VatReturnReport_NetVATDueDetails = new System.Windows.Forms.DataGridView();
            this.gb_VatReturnReport_SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.dt_VatReturnReport_Searchgb_TaxYear = new System.Windows.Forms.DateTimePicker();
            this.lbl_VatReturnReport_Searchgb_TaxYear = new System.Windows.Forms.Label();
            this.txt_VatReturnReport_Searchgb_VatReturnRefNo = new System.Windows.Forms.TextBox();
            this.lbl_VatReturnReport_Searchgb_VatReturnRefNo = new System.Windows.Forms.Label();
            this.GV_VatReturnReport_VatDetails = new System.Windows.Forms.DataGridView();
            this.lbl_VatReturnReport_VATLocking = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatReturnReport_VatOnSalesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatReturnReport_VATonExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatReturnReport_NetVATDueDetails)).BeginInit();
            this.gb_VatReturnReport_SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatReturnReport_VatDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_VatReturnReport_VatReturnFromDate
            // 
            this.lbl_VatReturnReport_VatReturnFromDate.AutoSize = true;
            this.lbl_VatReturnReport_VatReturnFromDate.Location = new System.Drawing.Point(12, 9);
            this.lbl_VatReturnReport_VatReturnFromDate.Name = "lbl_VatReturnReport_VatReturnFromDate";
            this.lbl_VatReturnReport_VatReturnFromDate.Size = new System.Drawing.Size(130, 15);
            this.lbl_VatReturnReport_VatReturnFromDate.TabIndex = 0;
            this.lbl_VatReturnReport_VatReturnFromDate.Text = "Vat Return Period From";
            // 
            // dt_VatReturnReport_VatReturnFromDate
            // 
            this.dt_VatReturnReport_VatReturnFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VatReturnReport_VatReturnFromDate.Location = new System.Drawing.Point(160, 9);
            this.dt_VatReturnReport_VatReturnFromDate.Name = "dt_VatReturnReport_VatReturnFromDate";
            this.dt_VatReturnReport_VatReturnFromDate.Size = new System.Drawing.Size(100, 22);
            this.dt_VatReturnReport_VatReturnFromDate.TabIndex = 1;
            // 
            // lbl_VatReturnReport_VatReturnToDate
            // 
            this.lbl_VatReturnReport_VatReturnToDate.AutoSize = true;
            this.lbl_VatReturnReport_VatReturnToDate.Location = new System.Drawing.Point(121, 37);
            this.lbl_VatReturnReport_VatReturnToDate.Name = "lbl_VatReturnReport_VatReturnToDate";
            this.lbl_VatReturnReport_VatReturnToDate.Size = new System.Drawing.Size(21, 15);
            this.lbl_VatReturnReport_VatReturnToDate.TabIndex = 2;
            this.lbl_VatReturnReport_VatReturnToDate.Text = "To";
            // 
            // dt_VatReturnReport_VatReturnToDate
            // 
            this.dt_VatReturnReport_VatReturnToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VatReturnReport_VatReturnToDate.Location = new System.Drawing.Point(160, 37);
            this.dt_VatReturnReport_VatReturnToDate.Name = "dt_VatReturnReport_VatReturnToDate";
            this.dt_VatReturnReport_VatReturnToDate.Size = new System.Drawing.Size(100, 22);
            this.dt_VatReturnReport_VatReturnToDate.TabIndex = 3;
            // 
            // lbl_VatReturnReport_TaxYear
            // 
            this.lbl_VatReturnReport_TaxYear.AutoSize = true;
            this.lbl_VatReturnReport_TaxYear.Location = new System.Drawing.Point(276, 9);
            this.lbl_VatReturnReport_TaxYear.Name = "lbl_VatReturnReport_TaxYear";
            this.lbl_VatReturnReport_TaxYear.Size = new System.Drawing.Size(51, 15);
            this.lbl_VatReturnReport_TaxYear.TabIndex = 4;
            this.lbl_VatReturnReport_TaxYear.Text = "Tax Year";
            // 
            // dt_VatReturnReport_TaxYear
            // 
            this.dt_VatReturnReport_TaxYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VatReturnReport_TaxYear.Location = new System.Drawing.Point(279, 29);
            this.dt_VatReturnReport_TaxYear.Name = "dt_VatReturnReport_TaxYear";
            this.dt_VatReturnReport_TaxYear.Size = new System.Drawing.Size(95, 22);
            this.dt_VatReturnReport_TaxYear.TabIndex = 5;
            // 
            // lbl_VatReturnReport_VatReturnRefNo
            // 
            this.lbl_VatReturnReport_VatReturnRefNo.AutoSize = true;
            this.lbl_VatReturnReport_VatReturnRefNo.Location = new System.Drawing.Point(377, 9);
            this.lbl_VatReturnReport_VatReturnRefNo.Name = "lbl_VatReturnReport_VatReturnRefNo";
            this.lbl_VatReturnReport_VatReturnRefNo.Size = new System.Drawing.Size(140, 15);
            this.lbl_VatReturnReport_VatReturnRefNo.TabIndex = 6;
            this.lbl_VatReturnReport_VatReturnRefNo.Text = "Vat Return Period Ref No";
            // 
            // txt_VatReturnReport_VatReturnRefNo
            // 
            this.txt_VatReturnReport_VatReturnRefNo.Location = new System.Drawing.Point(380, 29);
            this.txt_VatReturnReport_VatReturnRefNo.Name = "txt_VatReturnReport_VatReturnRefNo";
            this.txt_VatReturnReport_VatReturnRefNo.Size = new System.Drawing.Size(201, 22);
            this.txt_VatReturnReport_VatReturnRefNo.TabIndex = 7;
            // 
            // cb_VatReturnReport_CostCenter
            // 
            this.cb_VatReturnReport_CostCenter.AutoSize = true;
            this.cb_VatReturnReport_CostCenter.Location = new System.Drawing.Point(587, 6);
            this.cb_VatReturnReport_CostCenter.Name = "cb_VatReturnReport_CostCenter";
            this.cb_VatReturnReport_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_VatReturnReport_CostCenter.TabIndex = 8;
            this.cb_VatReturnReport_CostCenter.Text = "Cost Center";
            this.cb_VatReturnReport_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_VatReturnReport_CostCenter
            // 
            this.cob_VatReturnReport_CostCenter.FormattingEnabled = true;
            this.cob_VatReturnReport_CostCenter.Location = new System.Drawing.Point(587, 28);
            this.cob_VatReturnReport_CostCenter.Name = "cob_VatReturnReport_CostCenter";
            this.cob_VatReturnReport_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_VatReturnReport_CostCenter.TabIndex = 9;
            // 
            // btn_VatReturnReport_Search
            // 
            this.btn_VatReturnReport_Search.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_VatReturnReport_Search.Location = new System.Drawing.Point(714, 17);
            this.btn_VatReturnReport_Search.Name = "btn_VatReturnReport_Search";
            this.btn_VatReturnReport_Search.Size = new System.Drawing.Size(40, 34);
            this.btn_VatReturnReport_Search.TabIndex = 10;
            this.btn_VatReturnReport_Search.UseVisualStyleBackColor = true;
            // 
            // btn_VatReturnReport_SaveAndPrint
            // 
            this.btn_VatReturnReport_SaveAndPrint.Location = new System.Drawing.Point(755, 17);
            this.btn_VatReturnReport_SaveAndPrint.Name = "btn_VatReturnReport_SaveAndPrint";
            this.btn_VatReturnReport_SaveAndPrint.Size = new System.Drawing.Size(97, 34);
            this.btn_VatReturnReport_SaveAndPrint.TabIndex = 11;
            this.btn_VatReturnReport_SaveAndPrint.Text = "Save  &&  Print";
            this.btn_VatReturnReport_SaveAndPrint.UseVisualStyleBackColor = true;
            // 
            // lbl_VatReturnReport_VatOnSales
            // 
            this.lbl_VatReturnReport_VatOnSales.AutoSize = true;
            this.lbl_VatReturnReport_VatOnSales.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VatReturnReport_VatOnSales.Location = new System.Drawing.Point(15, 80);
            this.lbl_VatReturnReport_VatOnSales.Name = "lbl_VatReturnReport_VatOnSales";
            this.lbl_VatReturnReport_VatOnSales.Size = new System.Drawing.Size(236, 17);
            this.lbl_VatReturnReport_VatOnSales.TabIndex = 12;
            this.lbl_VatReturnReport_VatOnSales.Text = "VAT on Sales and all other Outputs";
            // 
            // GV_VatReturnReport_VatOnSalesDetails
            // 
            this.GV_VatReturnReport_VatOnSalesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_VatReturnReport_VatOnSalesDetails.Location = new System.Drawing.Point(18, 100);
            this.GV_VatReturnReport_VatOnSalesDetails.Name = "GV_VatReturnReport_VatOnSalesDetails";
            this.GV_VatReturnReport_VatOnSalesDetails.Size = new System.Drawing.Size(563, 254);
            this.GV_VatReturnReport_VatOnSalesDetails.TabIndex = 13;
            // 
            // lbl_VatReturnReport_VatOnExpenses
            // 
            this.lbl_VatReturnReport_VatOnExpenses.AutoSize = true;
            this.lbl_VatReturnReport_VatOnExpenses.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VatReturnReport_VatOnExpenses.Location = new System.Drawing.Point(585, 80);
            this.lbl_VatReturnReport_VatOnExpenses.Name = "lbl_VatReturnReport_VatOnExpenses";
            this.lbl_VatReturnReport_VatOnExpenses.Size = new System.Drawing.Size(255, 17);
            this.lbl_VatReturnReport_VatOnExpenses.TabIndex = 14;
            this.lbl_VatReturnReport_VatOnExpenses.Text = "VAT on Expenses and all other Inputs";
            // 
            // GV_VatReturnReport_VATonExpenses
            // 
            this.GV_VatReturnReport_VATonExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_VatReturnReport_VATonExpenses.Location = new System.Drawing.Point(588, 100);
            this.GV_VatReturnReport_VATonExpenses.Name = "GV_VatReturnReport_VATonExpenses";
            this.GV_VatReturnReport_VATonExpenses.Size = new System.Drawing.Size(507, 156);
            this.GV_VatReturnReport_VATonExpenses.TabIndex = 15;
            // 
            // lbl_VatReturnReport_NetVatDue
            // 
            this.lbl_VatReturnReport_NetVatDue.AutoSize = true;
            this.lbl_VatReturnReport_NetVatDue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VatReturnReport_NetVatDue.Location = new System.Drawing.Point(15, 371);
            this.lbl_VatReturnReport_NetVatDue.Name = "lbl_VatReturnReport_NetVatDue";
            this.lbl_VatReturnReport_NetVatDue.Size = new System.Drawing.Size(95, 17);
            this.lbl_VatReturnReport_NetVatDue.TabIndex = 16;
            this.lbl_VatReturnReport_NetVatDue.Text = "Net VAT Due";
            // 
            // GV_VatReturnReport_NetVATDueDetails
            // 
            this.GV_VatReturnReport_NetVATDueDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_VatReturnReport_NetVATDueDetails.Location = new System.Drawing.Point(18, 400);
            this.GV_VatReturnReport_NetVATDueDetails.Name = "GV_VatReturnReport_NetVATDueDetails";
            this.GV_VatReturnReport_NetVATDueDetails.Size = new System.Drawing.Size(563, 191);
            this.GV_VatReturnReport_NetVATDueDetails.TabIndex = 17;
            // 
            // gb_VatReturnReport_SearchGroupBox
            // 
            this.gb_VatReturnReport_SearchGroupBox.Controls.Add(this.GV_VatReturnReport_VatDetails);
            this.gb_VatReturnReport_SearchGroupBox.Controls.Add(this.txt_VatReturnReport_Searchgb_VatReturnRefNo);
            this.gb_VatReturnReport_SearchGroupBox.Controls.Add(this.lbl_VatReturnReport_Searchgb_VatReturnRefNo);
            this.gb_VatReturnReport_SearchGroupBox.Controls.Add(this.dt_VatReturnReport_Searchgb_TaxYear);
            this.gb_VatReturnReport_SearchGroupBox.Controls.Add(this.lbl_VatReturnReport_Searchgb_TaxYear);
            this.gb_VatReturnReport_SearchGroupBox.Location = new System.Drawing.Point(587, 262);
            this.gb_VatReturnReport_SearchGroupBox.Name = "gb_VatReturnReport_SearchGroupBox";
            this.gb_VatReturnReport_SearchGroupBox.Size = new System.Drawing.Size(506, 338);
            this.gb_VatReturnReport_SearchGroupBox.TabIndex = 18;
            this.gb_VatReturnReport_SearchGroupBox.TabStop = false;
            this.gb_VatReturnReport_SearchGroupBox.Text = "Search";
            // 
            // dt_VatReturnReport_Searchgb_TaxYear
            // 
            this.dt_VatReturnReport_Searchgb_TaxYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VatReturnReport_Searchgb_TaxYear.Location = new System.Drawing.Point(63, 24);
            this.dt_VatReturnReport_Searchgb_TaxYear.Name = "dt_VatReturnReport_Searchgb_TaxYear";
            this.dt_VatReturnReport_Searchgb_TaxYear.Size = new System.Drawing.Size(95, 22);
            this.dt_VatReturnReport_Searchgb_TaxYear.TabIndex = 7;
            // 
            // lbl_VatReturnReport_Searchgb_TaxYear
            // 
            this.lbl_VatReturnReport_Searchgb_TaxYear.AutoSize = true;
            this.lbl_VatReturnReport_Searchgb_TaxYear.Location = new System.Drawing.Point(6, 27);
            this.lbl_VatReturnReport_Searchgb_TaxYear.Name = "lbl_VatReturnReport_Searchgb_TaxYear";
            this.lbl_VatReturnReport_Searchgb_TaxYear.Size = new System.Drawing.Size(51, 15);
            this.lbl_VatReturnReport_Searchgb_TaxYear.TabIndex = 6;
            this.lbl_VatReturnReport_Searchgb_TaxYear.Text = "Tax Year";
            // 
            // txt_VatReturnReport_Searchgb_VatReturnRefNo
            // 
            this.txt_VatReturnReport_Searchgb_VatReturnRefNo.Location = new System.Drawing.Point(310, 24);
            this.txt_VatReturnReport_Searchgb_VatReturnRefNo.Name = "txt_VatReturnReport_Searchgb_VatReturnRefNo";
            this.txt_VatReturnReport_Searchgb_VatReturnRefNo.Size = new System.Drawing.Size(188, 22);
            this.txt_VatReturnReport_Searchgb_VatReturnRefNo.TabIndex = 9;
            // 
            // lbl_VatReturnReport_Searchgb_VatReturnRefNo
            // 
            this.lbl_VatReturnReport_Searchgb_VatReturnRefNo.AutoSize = true;
            this.lbl_VatReturnReport_Searchgb_VatReturnRefNo.Location = new System.Drawing.Point(165, 27);
            this.lbl_VatReturnReport_Searchgb_VatReturnRefNo.Name = "lbl_VatReturnReport_Searchgb_VatReturnRefNo";
            this.lbl_VatReturnReport_Searchgb_VatReturnRefNo.Size = new System.Drawing.Size(140, 15);
            this.lbl_VatReturnReport_Searchgb_VatReturnRefNo.TabIndex = 8;
            this.lbl_VatReturnReport_Searchgb_VatReturnRefNo.Text = "Vat Return Period Ref No";
            // 
            // GV_VatReturnReport_VatDetails
            // 
            this.GV_VatReturnReport_VatDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_VatReturnReport_VatDetails.Location = new System.Drawing.Point(9, 52);
            this.GV_VatReturnReport_VatDetails.Name = "GV_VatReturnReport_VatDetails";
            this.GV_VatReturnReport_VatDetails.Size = new System.Drawing.Size(489, 267);
            this.GV_VatReturnReport_VatDetails.TabIndex = 16;
            // 
            // lbl_VatReturnReport_VATLocking
            // 
            this.lbl_VatReturnReport_VATLocking.AutoSize = true;
            this.lbl_VatReturnReport_VATLocking.Location = new System.Drawing.Point(914, 28);
            this.lbl_VatReturnReport_VATLocking.Name = "lbl_VatReturnReport_VATLocking";
            this.lbl_VatReturnReport_VATLocking.Size = new System.Drawing.Size(76, 15);
            this.lbl_VatReturnReport_VATLocking.TabIndex = 19;
            this.lbl_VatReturnReport_VATLocking.TabStop = true;
            this.lbl_VatReturnReport_VATLocking.Text = "VAT Locking";
            // 
            // Frm_VatTax_VatReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 610);
            this.Controls.Add(this.lbl_VatReturnReport_VATLocking);
            this.Controls.Add(this.gb_VatReturnReport_SearchGroupBox);
            this.Controls.Add(this.GV_VatReturnReport_NetVATDueDetails);
            this.Controls.Add(this.lbl_VatReturnReport_NetVatDue);
            this.Controls.Add(this.GV_VatReturnReport_VATonExpenses);
            this.Controls.Add(this.lbl_VatReturnReport_VatOnExpenses);
            this.Controls.Add(this.GV_VatReturnReport_VatOnSalesDetails);
            this.Controls.Add(this.lbl_VatReturnReport_VatOnSales);
            this.Controls.Add(this.btn_VatReturnReport_SaveAndPrint);
            this.Controls.Add(this.btn_VatReturnReport_Search);
            this.Controls.Add(this.cob_VatReturnReport_CostCenter);
            this.Controls.Add(this.cb_VatReturnReport_CostCenter);
            this.Controls.Add(this.txt_VatReturnReport_VatReturnRefNo);
            this.Controls.Add(this.lbl_VatReturnReport_VatReturnRefNo);
            this.Controls.Add(this.dt_VatReturnReport_TaxYear);
            this.Controls.Add(this.lbl_VatReturnReport_TaxYear);
            this.Controls.Add(this.dt_VatReturnReport_VatReturnToDate);
            this.Controls.Add(this.lbl_VatReturnReport_VatReturnToDate);
            this.Controls.Add(this.dt_VatReturnReport_VatReturnFromDate);
            this.Controls.Add(this.lbl_VatReturnReport_VatReturnFromDate);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_VatTax_VatReturnReport";
            this.Text = "Frm_VatTax_VatReturnReport";
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatReturnReport_VatOnSalesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatReturnReport_VATonExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatReturnReport_NetVATDueDetails)).EndInit();
            this.gb_VatReturnReport_SearchGroupBox.ResumeLayout(false);
            this.gb_VatReturnReport_SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatReturnReport_VatDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_VatReturnReport_VatReturnFromDate;
        private System.Windows.Forms.DateTimePicker dt_VatReturnReport_VatReturnFromDate;
        private System.Windows.Forms.Label lbl_VatReturnReport_VatReturnToDate;
        private System.Windows.Forms.DateTimePicker dt_VatReturnReport_VatReturnToDate;
        private System.Windows.Forms.Label lbl_VatReturnReport_TaxYear;
        private System.Windows.Forms.DateTimePicker dt_VatReturnReport_TaxYear;
        private System.Windows.Forms.Label lbl_VatReturnReport_VatReturnRefNo;
        private System.Windows.Forms.TextBox txt_VatReturnReport_VatReturnRefNo;
        private System.Windows.Forms.CheckBox cb_VatReturnReport_CostCenter;
        private System.Windows.Forms.ComboBox cob_VatReturnReport_CostCenter;
        private System.Windows.Forms.Button btn_VatReturnReport_Search;
        private System.Windows.Forms.Button btn_VatReturnReport_SaveAndPrint;
        private System.Windows.Forms.Label lbl_VatReturnReport_VatOnSales;
        private System.Windows.Forms.DataGridView GV_VatReturnReport_VatOnSalesDetails;
        private System.Windows.Forms.Label lbl_VatReturnReport_VatOnExpenses;
        private System.Windows.Forms.DataGridView GV_VatReturnReport_VATonExpenses;
        private System.Windows.Forms.Label lbl_VatReturnReport_NetVatDue;
        private System.Windows.Forms.DataGridView GV_VatReturnReport_NetVATDueDetails;
        private System.Windows.Forms.GroupBox gb_VatReturnReport_SearchGroupBox;
        private System.Windows.Forms.DataGridView GV_VatReturnReport_VatDetails;
        private System.Windows.Forms.TextBox txt_VatReturnReport_Searchgb_VatReturnRefNo;
        private System.Windows.Forms.Label lbl_VatReturnReport_Searchgb_VatReturnRefNo;
        private System.Windows.Forms.DateTimePicker dt_VatReturnReport_Searchgb_TaxYear;
        private System.Windows.Forms.Label lbl_VatReturnReport_Searchgb_TaxYear;
        private System.Windows.Forms.LinkLabel lbl_VatReturnReport_VATLocking;
    }
}