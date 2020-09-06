namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_Search
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
            this.Panel_Search_4Buttons = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gv_Search_Data = new System.Windows.Forms.DataGridView();
            this.lbl_Search_Keyword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtp_Search_SalesDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_SalesDate = new System.Windows.Forms.Label();
            this.lbl_Search_CostCenter = new System.Windows.Forms.Label();
            this.cbox_Search_SearchON = new System.Windows.Forms.ComboBox();
            this.cb_Search_CostCenter = new System.Windows.Forms.CheckBox();
            this.cbox_Search_CostCenter = new System.Windows.Forms.ComboBox();
            this.btn_Search_Select = new System.Windows.Forms.Button();
            this.btn_Search_Close = new System.Windows.Forms.Button();
            this.Panel_Search_4Buttons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Search_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Search_4Buttons
            // 
            this.Panel_Search_4Buttons.Controls.Add(this.btn_Search_Close);
            this.Panel_Search_4Buttons.Controls.Add(this.btn_Search_Select);
            this.Panel_Search_4Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Search_4Buttons.Location = new System.Drawing.Point(0, 396);
            this.Panel_Search_4Buttons.Name = "Panel_Search_4Buttons";
            this.Panel_Search_4Buttons.Size = new System.Drawing.Size(825, 54);
            this.Panel_Search_4Buttons.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Search_Keyword);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dtp_Search_SalesDate);
            this.panel1.Controls.Add(this.lbl_SalesDate);
            this.panel1.Controls.Add(this.lbl_Search_CostCenter);
            this.panel1.Controls.Add(this.cbox_Search_SearchON);
            this.panel1.Controls.Add(this.cb_Search_CostCenter);
            this.panel1.Controls.Add(this.cbox_Search_CostCenter);
            this.panel1.Controls.Add(this.gv_Search_Data);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 396);
            this.panel1.TabIndex = 44;
            // 
            // gv_Search_Data
            // 
            this.gv_Search_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Search_Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_Search_Data.Location = new System.Drawing.Point(0, 77);
            this.gv_Search_Data.Name = "gv_Search_Data";
            this.gv_Search_Data.Size = new System.Drawing.Size(825, 319);
            this.gv_Search_Data.TabIndex = 44;
            // 
            // lbl_Search_Keyword
            // 
            this.lbl_Search_Keyword.AutoSize = true;
            this.lbl_Search_Keyword.Location = new System.Drawing.Point(538, 4);
            this.lbl_Search_Keyword.Name = "lbl_Search_Keyword";
            this.lbl_Search_Keyword.Size = new System.Drawing.Size(54, 13);
            this.lbl_Search_Keyword.TabIndex = 52;
            this.lbl_Search_Keyword.Text = "Keyword :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 51;
            // 
            // dtp_Search_SalesDate
            // 
            this.dtp_Search_SalesDate.Location = new System.Drawing.Point(317, 27);
            this.dtp_Search_SalesDate.Name = "dtp_Search_SalesDate";
            this.dtp_Search_SalesDate.Size = new System.Drawing.Size(210, 20);
            this.dtp_Search_SalesDate.TabIndex = 50;
            // 
            // lbl_SalesDate
            // 
            this.lbl_SalesDate.AutoSize = true;
            this.lbl_SalesDate.Location = new System.Drawing.Point(314, 7);
            this.lbl_SalesDate.Name = "lbl_SalesDate";
            this.lbl_SalesDate.Size = new System.Drawing.Size(65, 13);
            this.lbl_SalesDate.TabIndex = 49;
            this.lbl_SalesDate.Text = "Sales Date :";
            // 
            // lbl_Search_CostCenter
            // 
            this.lbl_Search_CostCenter.AutoSize = true;
            this.lbl_Search_CostCenter.Location = new System.Drawing.Point(164, 7);
            this.lbl_Search_CostCenter.Name = "lbl_Search_CostCenter";
            this.lbl_Search_CostCenter.Size = new System.Drawing.Size(64, 13);
            this.lbl_Search_CostCenter.TabIndex = 48;
            this.lbl_Search_CostCenter.Text = "Search On :";
            // 
            // cbox_Search_SearchON
            // 
            this.cbox_Search_SearchON.FormattingEnabled = true;
            this.cbox_Search_SearchON.Location = new System.Drawing.Point(167, 26);
            this.cbox_Search_SearchON.Name = "cbox_Search_SearchON";
            this.cbox_Search_SearchON.Size = new System.Drawing.Size(140, 21);
            this.cbox_Search_SearchON.TabIndex = 47;
            // 
            // cb_Search_CostCenter
            // 
            this.cb_Search_CostCenter.AutoSize = true;
            this.cb_Search_CostCenter.Location = new System.Drawing.Point(15, 3);
            this.cb_Search_CostCenter.Name = "cb_Search_CostCenter";
            this.cb_Search_CostCenter.Size = new System.Drawing.Size(81, 17);
            this.cb_Search_CostCenter.TabIndex = 46;
            this.cb_Search_CostCenter.Text = "Cost Center";
            this.cb_Search_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cbox_Search_CostCenter
            // 
            this.cbox_Search_CostCenter.FormattingEnabled = true;
            this.cbox_Search_CostCenter.Location = new System.Drawing.Point(15, 26);
            this.cbox_Search_CostCenter.Name = "cbox_Search_CostCenter";
            this.cbox_Search_CostCenter.Size = new System.Drawing.Size(140, 21);
            this.cbox_Search_CostCenter.TabIndex = 45;
            // 
            // btn_Search_Select
            // 
            this.btn_Search_Select.Location = new System.Drawing.Point(595, 7);
            this.btn_Search_Select.Name = "btn_Search_Select";
            this.btn_Search_Select.Size = new System.Drawing.Size(91, 35);
            this.btn_Search_Select.TabIndex = 0;
            this.btn_Search_Select.Text = "Select";
            this.btn_Search_Select.UseVisualStyleBackColor = true;
            // 
            // btn_Search_Close
            // 
            this.btn_Search_Close.Location = new System.Drawing.Point(692, 7);
            this.btn_Search_Close.Name = "btn_Search_Close";
            this.btn_Search_Close.Size = new System.Drawing.Size(91, 35);
            this.btn_Search_Close.TabIndex = 1;
            this.btn_Search_Close.Text = "Close";
            this.btn_Search_Close.UseVisualStyleBackColor = true;
            // 
            // frm_Transactions_LPOSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Search_4Buttons);
            this.Name = "frm_Transactions_LPOSearch";
            this.Text = "frm_Transactions_LPOSearch";
            this.Panel_Search_4Buttons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Search_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Search_4Buttons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Search_Keyword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtp_Search_SalesDate;
        private System.Windows.Forms.Label lbl_SalesDate;
        private System.Windows.Forms.Label lbl_Search_CostCenter;
        private System.Windows.Forms.ComboBox cbox_Search_SearchON;
        private System.Windows.Forms.CheckBox cb_Search_CostCenter;
        private System.Windows.Forms.ComboBox cbox_Search_CostCenter;
        private System.Windows.Forms.DataGridView gv_Search_Data;
        private System.Windows.Forms.Button btn_Search_Close;
        private System.Windows.Forms.Button btn_Search_Select;
    }
}