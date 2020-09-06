namespace Grocery.Admin.Accounts
{
    partial class Frm_Accounts_AccountSearch
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
            this.cb_AccountSearch_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_AccountSearch_CostCenter = new System.Windows.Forms.ComboBox();
            this.lbl_AccountSearch_DateFrom = new System.Windows.Forms.Label();
            this.dt_AccountSearch_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.dt_AccountSearch_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_AccountSearch_DateTo = new System.Windows.Forms.Label();
            this.lbl_AccountSearch_SearchOn = new System.Windows.Forms.Label();
            this.cob_AccountSearch_SearchOn = new System.Windows.Forms.ComboBox();
            this.lbl_AccountSearch_Keyword = new System.Windows.Forms.Label();
            this.txt_AccountSearch_Keyword = new System.Windows.Forms.TextBox();
            this.btn_AccountSearch_Search = new System.Windows.Forms.Button();
            this.GV_AccountSearch_AccountDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AccountSearch_Print = new System.Windows.Forms.Button();
            this.btn_AccountSearch_Select = new System.Windows.Forms.Button();
            this.btn_AccountSearch_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_AccountSearch_AccountDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_AccountSearch_Search);
            this.panel1.Controls.Add(this.txt_AccountSearch_Keyword);
            this.panel1.Controls.Add(this.lbl_AccountSearch_Keyword);
            this.panel1.Controls.Add(this.cob_AccountSearch_SearchOn);
            this.panel1.Controls.Add(this.lbl_AccountSearch_SearchOn);
            this.panel1.Controls.Add(this.dt_AccountSearch_DateTo);
            this.panel1.Controls.Add(this.lbl_AccountSearch_DateTo);
            this.panel1.Controls.Add(this.dt_AccountSearch_DateFrom);
            this.panel1.Controls.Add(this.lbl_AccountSearch_DateFrom);
            this.panel1.Controls.Add(this.cob_AccountSearch_CostCenter);
            this.panel1.Controls.Add(this.cb_AccountSearch_CostCenter);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 73);
            this.panel1.TabIndex = 0;
            // 
            // cb_AccountSearch_CostCenter
            // 
            this.cb_AccountSearch_CostCenter.AutoSize = true;
            this.cb_AccountSearch_CostCenter.Location = new System.Drawing.Point(13, 13);
            this.cb_AccountSearch_CostCenter.Name = "cb_AccountSearch_CostCenter";
            this.cb_AccountSearch_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_AccountSearch_CostCenter.TabIndex = 0;
            this.cb_AccountSearch_CostCenter.Text = "Cost Center";
            this.cb_AccountSearch_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_AccountSearch_CostCenter
            // 
            this.cob_AccountSearch_CostCenter.FormattingEnabled = true;
            this.cob_AccountSearch_CostCenter.Location = new System.Drawing.Point(13, 39);
            this.cob_AccountSearch_CostCenter.Name = "cob_AccountSearch_CostCenter";
            this.cob_AccountSearch_CostCenter.Size = new System.Drawing.Size(106, 23);
            this.cob_AccountSearch_CostCenter.TabIndex = 1;
            // 
            // lbl_AccountSearch_DateFrom
            // 
            this.lbl_AccountSearch_DateFrom.AutoSize = true;
            this.lbl_AccountSearch_DateFrom.Location = new System.Drawing.Point(125, 42);
            this.lbl_AccountSearch_DateFrom.Name = "lbl_AccountSearch_DateFrom";
            this.lbl_AccountSearch_DateFrom.Size = new System.Drawing.Size(62, 15);
            this.lbl_AccountSearch_DateFrom.TabIndex = 2;
            this.lbl_AccountSearch_DateFrom.Text = "Date From";
            // 
            // dt_AccountSearch_DateFrom
            // 
            this.dt_AccountSearch_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_AccountSearch_DateFrom.Location = new System.Drawing.Point(193, 39);
            this.dt_AccountSearch_DateFrom.Name = "dt_AccountSearch_DateFrom";
            this.dt_AccountSearch_DateFrom.Size = new System.Drawing.Size(102, 22);
            this.dt_AccountSearch_DateFrom.TabIndex = 3;
            // 
            // dt_AccountSearch_DateTo
            // 
            this.dt_AccountSearch_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_AccountSearch_DateTo.Location = new System.Drawing.Point(344, 39);
            this.dt_AccountSearch_DateTo.Name = "dt_AccountSearch_DateTo";
            this.dt_AccountSearch_DateTo.Size = new System.Drawing.Size(102, 22);
            this.dt_AccountSearch_DateTo.TabIndex = 5;
            // 
            // lbl_AccountSearch_DateTo
            // 
            this.lbl_AccountSearch_DateTo.AutoSize = true;
            this.lbl_AccountSearch_DateTo.Location = new System.Drawing.Point(317, 42);
            this.lbl_AccountSearch_DateTo.Name = "lbl_AccountSearch_DateTo";
            this.lbl_AccountSearch_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_AccountSearch_DateTo.TabIndex = 4;
            this.lbl_AccountSearch_DateTo.Text = "To";
            // 
            // lbl_AccountSearch_SearchOn
            // 
            this.lbl_AccountSearch_SearchOn.AutoSize = true;
            this.lbl_AccountSearch_SearchOn.Location = new System.Drawing.Point(460, 18);
            this.lbl_AccountSearch_SearchOn.Name = "lbl_AccountSearch_SearchOn";
            this.lbl_AccountSearch_SearchOn.Size = new System.Drawing.Size(65, 15);
            this.lbl_AccountSearch_SearchOn.TabIndex = 6;
            this.lbl_AccountSearch_SearchOn.Text = "Search On:";
            // 
            // cob_AccountSearch_SearchOn
            // 
            this.cob_AccountSearch_SearchOn.FormattingEnabled = true;
            this.cob_AccountSearch_SearchOn.Location = new System.Drawing.Point(463, 38);
            this.cob_AccountSearch_SearchOn.Name = "cob_AccountSearch_SearchOn";
            this.cob_AccountSearch_SearchOn.Size = new System.Drawing.Size(121, 23);
            this.cob_AccountSearch_SearchOn.TabIndex = 7;
            // 
            // lbl_AccountSearch_Keyword
            // 
            this.lbl_AccountSearch_Keyword.AutoSize = true;
            this.lbl_AccountSearch_Keyword.Location = new System.Drawing.Point(604, 18);
            this.lbl_AccountSearch_Keyword.Name = "lbl_AccountSearch_Keyword";
            this.lbl_AccountSearch_Keyword.Size = new System.Drawing.Size(59, 15);
            this.lbl_AccountSearch_Keyword.TabIndex = 8;
            this.lbl_AccountSearch_Keyword.Text = "Keyword:";
            // 
            // txt_AccountSearch_Keyword
            // 
            this.txt_AccountSearch_Keyword.Location = new System.Drawing.Point(607, 37);
            this.txt_AccountSearch_Keyword.Name = "txt_AccountSearch_Keyword";
            this.txt_AccountSearch_Keyword.Size = new System.Drawing.Size(227, 22);
            this.txt_AccountSearch_Keyword.TabIndex = 9;
            // 
            // btn_AccountSearch_Search
            // 
            this.btn_AccountSearch_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountSearch_Search.Location = new System.Drawing.Point(850, 26);
            this.btn_AccountSearch_Search.Name = "btn_AccountSearch_Search";
            this.btn_AccountSearch_Search.Size = new System.Drawing.Size(67, 42);
            this.btn_AccountSearch_Search.TabIndex = 10;
            this.btn_AccountSearch_Search.Text = "Search";
            this.btn_AccountSearch_Search.UseVisualStyleBackColor = true;
            // 
            // GV_AccountSearch_AccountDetails
            // 
            this.GV_AccountSearch_AccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_AccountSearch_AccountDetails.Location = new System.Drawing.Point(13, 95);
            this.GV_AccountSearch_AccountDetails.Name = "GV_AccountSearch_AccountDetails";
            this.GV_AccountSearch_AccountDetails.Size = new System.Drawing.Size(922, 257);
            this.GV_AccountSearch_AccountDetails.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_AccountSearch_Close);
            this.panel2.Controls.Add(this.btn_AccountSearch_Select);
            this.panel2.Controls.Add(this.btn_AccountSearch_Print);
            this.panel2.Location = new System.Drawing.Point(13, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 62);
            this.panel2.TabIndex = 2;
            // 
            // btn_AccountSearch_Print
            // 
            this.btn_AccountSearch_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountSearch_Print.Location = new System.Drawing.Point(579, 13);
            this.btn_AccountSearch_Print.Name = "btn_AccountSearch_Print";
            this.btn_AccountSearch_Print.Size = new System.Drawing.Size(109, 39);
            this.btn_AccountSearch_Print.TabIndex = 0;
            this.btn_AccountSearch_Print.Text = "Print";
            this.btn_AccountSearch_Print.UseVisualStyleBackColor = true;
            // 
            // btn_AccountSearch_Select
            // 
            this.btn_AccountSearch_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountSearch_Select.Location = new System.Drawing.Point(694, 13);
            this.btn_AccountSearch_Select.Name = "btn_AccountSearch_Select";
            this.btn_AccountSearch_Select.Size = new System.Drawing.Size(109, 39);
            this.btn_AccountSearch_Select.TabIndex = 1;
            this.btn_AccountSearch_Select.Text = "Select";
            this.btn_AccountSearch_Select.UseVisualStyleBackColor = true;
            // 
            // btn_AccountSearch_Close
            // 
            this.btn_AccountSearch_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountSearch_Close.Location = new System.Drawing.Point(809, 13);
            this.btn_AccountSearch_Close.Name = "btn_AccountSearch_Close";
            this.btn_AccountSearch_Close.Size = new System.Drawing.Size(109, 39);
            this.btn_AccountSearch_Close.TabIndex = 2;
            this.btn_AccountSearch_Close.Text = "Close";
            this.btn_AccountSearch_Close.UseVisualStyleBackColor = true;
            // 
            // Frm_Master_AccountSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GV_AccountSearch_AccountDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Master_AccountSearch";
            this.Text = "Frm_Master_AccountSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_AccountSearch_AccountDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AccountSearch_Search;
        private System.Windows.Forms.TextBox txt_AccountSearch_Keyword;
        private System.Windows.Forms.Label lbl_AccountSearch_Keyword;
        private System.Windows.Forms.ComboBox cob_AccountSearch_SearchOn;
        private System.Windows.Forms.Label lbl_AccountSearch_SearchOn;
        private System.Windows.Forms.DateTimePicker dt_AccountSearch_DateTo;
        private System.Windows.Forms.Label lbl_AccountSearch_DateTo;
        private System.Windows.Forms.DateTimePicker dt_AccountSearch_DateFrom;
        private System.Windows.Forms.Label lbl_AccountSearch_DateFrom;
        private System.Windows.Forms.ComboBox cob_AccountSearch_CostCenter;
        private System.Windows.Forms.CheckBox cb_AccountSearch_CostCenter;
        private System.Windows.Forms.DataGridView GV_AccountSearch_AccountDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_AccountSearch_Close;
        private System.Windows.Forms.Button btn_AccountSearch_Select;
        private System.Windows.Forms.Button btn_AccountSearch_Print;
    }
}