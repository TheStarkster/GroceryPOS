namespace Grocery.Admin.Administration
{
    partial class Frm_Administration_StockedSearch
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
            this.cb_StockedSearch_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_StockedSearch_CostCenter = new System.Windows.Forms.ComboBox();
            this.lbl_StockedSearch_DateFrom = new System.Windows.Forms.Label();
            this.dt_StockedSearch_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.dt_StockedSearch_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_StockedSearch_DateTo = new System.Windows.Forms.Label();
            this.btn_StockedSearch_Search = new System.Windows.Forms.Button();
            this.GV_StockedSearch_AdjEntries = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_StockedSearch_ItemName = new System.Windows.Forms.RadioButton();
            this.rb_StockedSearch_Department = new System.Windows.Forms.RadioButton();
            this.rb_StockedSearch_SubCategory = new System.Windows.Forms.RadioButton();
            this.rb_StockedSearch_Category = new System.Windows.Forms.RadioButton();
            this.rb_StockedSearch_Barcode = new System.Windows.Forms.RadioButton();
            this.lbl_StockedSearch_Keyword = new System.Windows.Forms.Label();
            this.txt_StockedSearch_Keyword = new System.Windows.Forms.TextBox();
            this.btn_StockedSearch_KeywordSearch = new System.Windows.Forms.Button();
            this.GV_StockedSearch_ItemDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV_StockedSearch_AdjEntries)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_StockedSearch_ItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_StockedSearch_CostCenter
            // 
            this.cb_StockedSearch_CostCenter.AutoSize = true;
            this.cb_StockedSearch_CostCenter.Location = new System.Drawing.Point(13, 13);
            this.cb_StockedSearch_CostCenter.Name = "cb_StockedSearch_CostCenter";
            this.cb_StockedSearch_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_StockedSearch_CostCenter.TabIndex = 0;
            this.cb_StockedSearch_CostCenter.Text = "Cost Center";
            this.cb_StockedSearch_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_StockedSearch_CostCenter
            // 
            this.cob_StockedSearch_CostCenter.FormattingEnabled = true;
            this.cob_StockedSearch_CostCenter.Location = new System.Drawing.Point(109, 13);
            this.cob_StockedSearch_CostCenter.Name = "cob_StockedSearch_CostCenter";
            this.cob_StockedSearch_CostCenter.Size = new System.Drawing.Size(146, 23);
            this.cob_StockedSearch_CostCenter.TabIndex = 1;
            // 
            // lbl_StockedSearch_DateFrom
            // 
            this.lbl_StockedSearch_DateFrom.AutoSize = true;
            this.lbl_StockedSearch_DateFrom.Location = new System.Drawing.Point(10, 48);
            this.lbl_StockedSearch_DateFrom.Name = "lbl_StockedSearch_DateFrom";
            this.lbl_StockedSearch_DateFrom.Size = new System.Drawing.Size(34, 15);
            this.lbl_StockedSearch_DateFrom.TabIndex = 2;
            this.lbl_StockedSearch_DateFrom.Text = "From";
            // 
            // dt_StockedSearch_DateFrom
            // 
            this.dt_StockedSearch_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_StockedSearch_DateFrom.Location = new System.Drawing.Point(64, 42);
            this.dt_StockedSearch_DateFrom.Name = "dt_StockedSearch_DateFrom";
            this.dt_StockedSearch_DateFrom.Size = new System.Drawing.Size(103, 22);
            this.dt_StockedSearch_DateFrom.TabIndex = 3;
            // 
            // dt_StockedSearch_DateTo
            // 
            this.dt_StockedSearch_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_StockedSearch_DateTo.Location = new System.Drawing.Point(64, 70);
            this.dt_StockedSearch_DateTo.Name = "dt_StockedSearch_DateTo";
            this.dt_StockedSearch_DateTo.Size = new System.Drawing.Size(103, 22);
            this.dt_StockedSearch_DateTo.TabIndex = 5;
            // 
            // lbl_StockedSearch_DateTo
            // 
            this.lbl_StockedSearch_DateTo.AutoSize = true;
            this.lbl_StockedSearch_DateTo.Location = new System.Drawing.Point(10, 76);
            this.lbl_StockedSearch_DateTo.Name = "lbl_StockedSearch_DateTo";
            this.lbl_StockedSearch_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_StockedSearch_DateTo.TabIndex = 4;
            this.lbl_StockedSearch_DateTo.Text = "To";
            // 
            // btn_StockedSearch_Search
            // 
            this.btn_StockedSearch_Search.Location = new System.Drawing.Point(174, 42);
            this.btn_StockedSearch_Search.Name = "btn_StockedSearch_Search";
            this.btn_StockedSearch_Search.Size = new System.Drawing.Size(75, 50);
            this.btn_StockedSearch_Search.TabIndex = 6;
            this.btn_StockedSearch_Search.Text = "Search";
            this.btn_StockedSearch_Search.UseVisualStyleBackColor = true;
            // 
            // GV_StockedSearch_AdjEntries
            // 
            this.GV_StockedSearch_AdjEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_StockedSearch_AdjEntries.Location = new System.Drawing.Point(13, 98);
            this.GV_StockedSearch_AdjEntries.Name = "GV_StockedSearch_AdjEntries";
            this.GV_StockedSearch_AdjEntries.Size = new System.Drawing.Size(240, 343);
            this.GV_StockedSearch_AdjEntries.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_StockedSearch_KeywordSearch);
            this.panel1.Controls.Add(this.txt_StockedSearch_Keyword);
            this.panel1.Controls.Add(this.lbl_StockedSearch_Keyword);
            this.panel1.Controls.Add(this.rb_StockedSearch_Barcode);
            this.panel1.Controls.Add(this.rb_StockedSearch_Category);
            this.panel1.Controls.Add(this.rb_StockedSearch_SubCategory);
            this.panel1.Controls.Add(this.rb_StockedSearch_Department);
            this.panel1.Controls.Add(this.rb_StockedSearch_ItemName);
            this.panel1.Location = new System.Drawing.Point(261, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 67);
            this.panel1.TabIndex = 8;
            // 
            // rb_StockedSearch_ItemName
            // 
            this.rb_StockedSearch_ItemName.AutoSize = true;
            this.rb_StockedSearch_ItemName.Location = new System.Drawing.Point(13, 16);
            this.rb_StockedSearch_ItemName.Name = "rb_StockedSearch_ItemName";
            this.rb_StockedSearch_ItemName.Size = new System.Drawing.Size(81, 19);
            this.rb_StockedSearch_ItemName.TabIndex = 0;
            this.rb_StockedSearch_ItemName.TabStop = true;
            this.rb_StockedSearch_ItemName.Text = "Item Name";
            this.rb_StockedSearch_ItemName.UseVisualStyleBackColor = true;
            // 
            // rb_StockedSearch_Department
            // 
            this.rb_StockedSearch_Department.AutoSize = true;
            this.rb_StockedSearch_Department.Location = new System.Drawing.Point(114, 16);
            this.rb_StockedSearch_Department.Name = "rb_StockedSearch_Department";
            this.rb_StockedSearch_Department.Size = new System.Drawing.Size(87, 19);
            this.rb_StockedSearch_Department.TabIndex = 1;
            this.rb_StockedSearch_Department.TabStop = true;
            this.rb_StockedSearch_Department.Text = "Department";
            this.rb_StockedSearch_Department.UseVisualStyleBackColor = true;
            // 
            // rb_StockedSearch_SubCategory
            // 
            this.rb_StockedSearch_SubCategory.AutoSize = true;
            this.rb_StockedSearch_SubCategory.Location = new System.Drawing.Point(224, 16);
            this.rb_StockedSearch_SubCategory.Name = "rb_StockedSearch_SubCategory";
            this.rb_StockedSearch_SubCategory.Size = new System.Drawing.Size(98, 19);
            this.rb_StockedSearch_SubCategory.TabIndex = 2;
            this.rb_StockedSearch_SubCategory.TabStop = true;
            this.rb_StockedSearch_SubCategory.Text = "Sub Category";
            this.rb_StockedSearch_SubCategory.UseVisualStyleBackColor = true;
            // 
            // rb_StockedSearch_Category
            // 
            this.rb_StockedSearch_Category.AutoSize = true;
            this.rb_StockedSearch_Category.Location = new System.Drawing.Point(353, 16);
            this.rb_StockedSearch_Category.Name = "rb_StockedSearch_Category";
            this.rb_StockedSearch_Category.Size = new System.Drawing.Size(74, 19);
            this.rb_StockedSearch_Category.TabIndex = 3;
            this.rb_StockedSearch_Category.TabStop = true;
            this.rb_StockedSearch_Category.Text = "Category";
            this.rb_StockedSearch_Category.UseVisualStyleBackColor = true;
            // 
            // rb_StockedSearch_Barcode
            // 
            this.rb_StockedSearch_Barcode.AutoSize = true;
            this.rb_StockedSearch_Barcode.Location = new System.Drawing.Point(454, 16);
            this.rb_StockedSearch_Barcode.Name = "rb_StockedSearch_Barcode";
            this.rb_StockedSearch_Barcode.Size = new System.Drawing.Size(69, 19);
            this.rb_StockedSearch_Barcode.TabIndex = 4;
            this.rb_StockedSearch_Barcode.TabStop = true;
            this.rb_StockedSearch_Barcode.Text = "Barcode";
            this.rb_StockedSearch_Barcode.UseVisualStyleBackColor = true;
            // 
            // lbl_StockedSearch_Keyword
            // 
            this.lbl_StockedSearch_Keyword.AutoSize = true;
            this.lbl_StockedSearch_Keyword.Location = new System.Drawing.Point(13, 42);
            this.lbl_StockedSearch_Keyword.Name = "lbl_StockedSearch_Keyword";
            this.lbl_StockedSearch_Keyword.Size = new System.Drawing.Size(56, 15);
            this.lbl_StockedSearch_Keyword.TabIndex = 5;
            this.lbl_StockedSearch_Keyword.Text = "Keyword";
            // 
            // txt_StockedSearch_Keyword
            // 
            this.txt_StockedSearch_Keyword.Location = new System.Drawing.Point(75, 39);
            this.txt_StockedSearch_Keyword.Name = "txt_StockedSearch_Keyword";
            this.txt_StockedSearch_Keyword.Size = new System.Drawing.Size(503, 22);
            this.txt_StockedSearch_Keyword.TabIndex = 6;
            // 
            // btn_StockedSearch_KeywordSearch
            // 
            this.btn_StockedSearch_KeywordSearch.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_StockedSearch_KeywordSearch.Location = new System.Drawing.Point(585, 16);
            this.btn_StockedSearch_KeywordSearch.Name = "btn_StockedSearch_KeywordSearch";
            this.btn_StockedSearch_KeywordSearch.Size = new System.Drawing.Size(35, 45);
            this.btn_StockedSearch_KeywordSearch.TabIndex = 7;
            this.btn_StockedSearch_KeywordSearch.UseVisualStyleBackColor = true;
            // 
            // GV_StockedSearch_ItemDetails
            // 
            this.GV_StockedSearch_ItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_StockedSearch_ItemDetails.Location = new System.Drawing.Point(261, 87);
            this.GV_StockedSearch_ItemDetails.Name = "GV_StockedSearch_ItemDetails";
            this.GV_StockedSearch_ItemDetails.Size = new System.Drawing.Size(631, 354);
            this.GV_StockedSearch_ItemDetails.TabIndex = 9;
            // 
            // Frm_Administration_StockedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 453);
            this.Controls.Add(this.GV_StockedSearch_ItemDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GV_StockedSearch_AdjEntries);
            this.Controls.Add(this.btn_StockedSearch_Search);
            this.Controls.Add(this.dt_StockedSearch_DateTo);
            this.Controls.Add(this.lbl_StockedSearch_DateTo);
            this.Controls.Add(this.dt_StockedSearch_DateFrom);
            this.Controls.Add(this.lbl_StockedSearch_DateFrom);
            this.Controls.Add(this.cob_StockedSearch_CostCenter);
            this.Controls.Add(this.cb_StockedSearch_CostCenter);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Administration_StockedSearch";
            this.Text = "Frm_Administration_StockedSearch";
            ((System.ComponentModel.ISupportInitialize)(this.GV_StockedSearch_AdjEntries)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_StockedSearch_ItemDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_StockedSearch_CostCenter;
        private System.Windows.Forms.ComboBox cob_StockedSearch_CostCenter;
        private System.Windows.Forms.Label lbl_StockedSearch_DateFrom;
        private System.Windows.Forms.DateTimePicker dt_StockedSearch_DateFrom;
        private System.Windows.Forms.DateTimePicker dt_StockedSearch_DateTo;
        private System.Windows.Forms.Label lbl_StockedSearch_DateTo;
        private System.Windows.Forms.Button btn_StockedSearch_Search;
        private System.Windows.Forms.DataGridView GV_StockedSearch_AdjEntries;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_StockedSearch_KeywordSearch;
        private System.Windows.Forms.TextBox txt_StockedSearch_Keyword;
        private System.Windows.Forms.Label lbl_StockedSearch_Keyword;
        private System.Windows.Forms.RadioButton rb_StockedSearch_Barcode;
        private System.Windows.Forms.RadioButton rb_StockedSearch_Category;
        private System.Windows.Forms.RadioButton rb_StockedSearch_SubCategory;
        private System.Windows.Forms.RadioButton rb_StockedSearch_Department;
        private System.Windows.Forms.RadioButton rb_StockedSearch_ItemName;
        private System.Windows.Forms.DataGridView GV_StockedSearch_ItemDetails;
    }
}