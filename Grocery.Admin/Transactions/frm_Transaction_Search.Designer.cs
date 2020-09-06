namespace Grocery.Admin.Transactions
{
    partial class frm_Transaction_Search
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
            this.cb_Search_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_Search_CostCenter = new System.Windows.Forms.ComboBox();
            this.lbl_Search_SearchOn = new System.Windows.Forms.Label();
            this.cob_Search_SearchOn = new System.Windows.Forms.ComboBox();
            this.lbl_Search_SalesDate = new System.Windows.Forms.Label();
            this.dt_Search_SalesDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Search_Keyword = new System.Windows.Forms.Label();
            this.txt_Search_Keyword = new System.Windows.Forms.TextBox();
            this.btn_Search_KeywordSearch = new System.Windows.Forms.Button();
            this.GV_Search_Supplier = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Search_Select = new System.Windows.Forms.Button();
            this.btn_Search_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search_Supplier)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Search_KeywordSearch);
            this.panel1.Controls.Add(this.txt_Search_Keyword);
            this.panel1.Controls.Add(this.lbl_Search_Keyword);
            this.panel1.Controls.Add(this.dt_Search_SalesDate);
            this.panel1.Controls.Add(this.lbl_Search_SalesDate);
            this.panel1.Controls.Add(this.cob_Search_SearchOn);
            this.panel1.Controls.Add(this.lbl_Search_SearchOn);
            this.panel1.Controls.Add(this.cob_Search_CostCenter);
            this.panel1.Controls.Add(this.cb_Search_CostCenter);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 77);
            this.panel1.TabIndex = 0;
            // 
            // cb_Search_CostCenter
            // 
            this.cb_Search_CostCenter.AutoSize = true;
            this.cb_Search_CostCenter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Search_CostCenter.Location = new System.Drawing.Point(10, 9);
            this.cb_Search_CostCenter.Name = "cb_Search_CostCenter";
            this.cb_Search_CostCenter.Size = new System.Drawing.Size(92, 19);
            this.cb_Search_CostCenter.TabIndex = 0;
            this.cb_Search_CostCenter.Text = "Cost Center";
            this.cb_Search_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_Search_CostCenter
            // 
            this.cob_Search_CostCenter.FormattingEnabled = true;
            this.cob_Search_CostCenter.Location = new System.Drawing.Point(10, 29);
            this.cob_Search_CostCenter.Name = "cob_Search_CostCenter";
            this.cob_Search_CostCenter.Size = new System.Drawing.Size(128, 23);
            this.cob_Search_CostCenter.TabIndex = 1;
            // 
            // lbl_Search_SearchOn
            // 
            this.lbl_Search_SearchOn.AutoSize = true;
            this.lbl_Search_SearchOn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_SearchOn.Location = new System.Drawing.Point(141, 11);
            this.lbl_Search_SearchOn.Name = "lbl_Search_SearchOn";
            this.lbl_Search_SearchOn.Size = new System.Drawing.Size(70, 15);
            this.lbl_Search_SearchOn.TabIndex = 2;
            this.lbl_Search_SearchOn.Text = "Search On:";
            // 
            // cob_Search_SearchOn
            // 
            this.cob_Search_SearchOn.FormattingEnabled = true;
            this.cob_Search_SearchOn.Location = new System.Drawing.Point(144, 29);
            this.cob_Search_SearchOn.Name = "cob_Search_SearchOn";
            this.cob_Search_SearchOn.Size = new System.Drawing.Size(140, 23);
            this.cob_Search_SearchOn.TabIndex = 3;
            // 
            // lbl_Search_SalesDate
            // 
            this.lbl_Search_SalesDate.AutoSize = true;
            this.lbl_Search_SalesDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_SalesDate.Location = new System.Drawing.Point(291, 10);
            this.lbl_Search_SalesDate.Name = "lbl_Search_SalesDate";
            this.lbl_Search_SalesDate.Size = new System.Drawing.Size(65, 15);
            this.lbl_Search_SalesDate.TabIndex = 4;
            this.lbl_Search_SalesDate.Text = "Sales Date";
            // 
            // dt_Search_SalesDate
            // 
            this.dt_Search_SalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Search_SalesDate.Location = new System.Drawing.Point(290, 29);
            this.dt_Search_SalesDate.Name = "dt_Search_SalesDate";
            this.dt_Search_SalesDate.Size = new System.Drawing.Size(119, 22);
            this.dt_Search_SalesDate.TabIndex = 5;
            // 
            // lbl_Search_Keyword
            // 
            this.lbl_Search_Keyword.AutoSize = true;
            this.lbl_Search_Keyword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Keyword.Location = new System.Drawing.Point(537, 48);
            this.lbl_Search_Keyword.Name = "lbl_Search_Keyword";
            this.lbl_Search_Keyword.Size = new System.Drawing.Size(58, 15);
            this.lbl_Search_Keyword.TabIndex = 6;
            this.lbl_Search_Keyword.Text = "Keyword:";
            // 
            // txt_Search_Keyword
            // 
            this.txt_Search_Keyword.Location = new System.Drawing.Point(602, 45);
            this.txt_Search_Keyword.Name = "txt_Search_Keyword";
            this.txt_Search_Keyword.Size = new System.Drawing.Size(151, 22);
            this.txt_Search_Keyword.TabIndex = 7;
            // 
            // btn_Search_KeywordSearch
            // 
            this.btn_Search_KeywordSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search_KeywordSearch.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_Search_KeywordSearch.Location = new System.Drawing.Point(759, 29);
            this.btn_Search_KeywordSearch.Name = "btn_Search_KeywordSearch";
            this.btn_Search_KeywordSearch.Size = new System.Drawing.Size(32, 40);
            this.btn_Search_KeywordSearch.TabIndex = 8;
            this.btn_Search_KeywordSearch.UseVisualStyleBackColor = true;
            // 
            // GV_Search_Supplier
            // 
            this.GV_Search_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Search_Supplier.Location = new System.Drawing.Point(2, 95);
            this.GV_Search_Supplier.Name = "GV_Search_Supplier";
            this.GV_Search_Supplier.Size = new System.Drawing.Size(822, 215);
            this.GV_Search_Supplier.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Search_Close);
            this.panel2.Controls.Add(this.btn_Search_Select);
            this.panel2.Location = new System.Drawing.Point(2, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 66);
            this.panel2.TabIndex = 2;
            // 
            // btn_Search_Select
            // 
            this.btn_Search_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search_Select.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Select.Location = new System.Drawing.Point(558, 16);
            this.btn_Search_Select.Name = "btn_Search_Select";
            this.btn_Search_Select.Size = new System.Drawing.Size(120, 40);
            this.btn_Search_Select.TabIndex = 0;
            this.btn_Search_Select.Text = "&Select";
            this.btn_Search_Select.UseVisualStyleBackColor = true;
            // 
            // btn_Search_Close
            // 
            this.btn_Search_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search_Close.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Close.Location = new System.Drawing.Point(692, 16);
            this.btn_Search_Close.Name = "btn_Search_Close";
            this.btn_Search_Close.Size = new System.Drawing.Size(120, 40);
            this.btn_Search_Close.TabIndex = 1;
            this.btn_Search_Close.Text = "&Close";
            this.btn_Search_Close.UseVisualStyleBackColor = true;
            // 
            // frm_Transaction_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 391);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GV_Search_Supplier);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transaction_Search";
            this.Text = "frm_Transaction_Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search_Supplier)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search_KeywordSearch;
        private System.Windows.Forms.TextBox txt_Search_Keyword;
        private System.Windows.Forms.Label lbl_Search_Keyword;
        private System.Windows.Forms.DateTimePicker dt_Search_SalesDate;
        private System.Windows.Forms.Label lbl_Search_SalesDate;
        private System.Windows.Forms.ComboBox cob_Search_SearchOn;
        private System.Windows.Forms.Label lbl_Search_SearchOn;
        private System.Windows.Forms.ComboBox cob_Search_CostCenter;
        private System.Windows.Forms.CheckBox cb_Search_CostCenter;
        private System.Windows.Forms.DataGridView GV_Search_Supplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Search_Close;
        private System.Windows.Forms.Button btn_Search_Select;
    }
}