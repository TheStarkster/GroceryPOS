namespace Grocery.Admin.Transactions
{
    partial class Frm_Transactions_SearchTransaction
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
            this.cb_SearchTransaction_CostCenter = new System.Windows.Forms.CheckBox();
            this.cbox_SearchTransaction_CostCenter = new System.Windows.Forms.ComboBox();
            this.rb_SearchTransaction_InvoiceID = new System.Windows.Forms.RadioButton();
            this.rb_SearchTransaction_CustomerID = new System.Windows.Forms.RadioButton();
            this.rb_SearchTransaction_CustomerName = new System.Windows.Forms.RadioButton();
            this.rb_SearchTransaction_DateFrom = new System.Windows.Forms.RadioButton();
            this.dt_SearchTransaction_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_SearchTransaction_DateTo = new System.Windows.Forms.Label();
            this.dt_SearchTransaction_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_SearchTransaction_Keyword = new System.Windows.Forms.Label();
            this.txt_SearchTransaction_Keyword = new System.Windows.Forms.TextBox();
            this.btn_SearchTransaction_SearchKeyword = new System.Windows.Forms.Button();
            this.GV_SearchTransaction_TransactionDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SearchTransaction_Close = new System.Windows.Forms.Button();
            this.btn_SearchTransaction_Select = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SearchTransaction_TransactionDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GV_SearchTransaction_TransactionDetails);
            this.panel1.Controls.Add(this.btn_SearchTransaction_SearchKeyword);
            this.panel1.Controls.Add(this.txt_SearchTransaction_Keyword);
            this.panel1.Controls.Add(this.lbl_SearchTransaction_Keyword);
            this.panel1.Controls.Add(this.dt_SearchTransaction_DateTo);
            this.panel1.Controls.Add(this.lbl_SearchTransaction_DateTo);
            this.panel1.Controls.Add(this.dt_SearchTransaction_DateFrom);
            this.panel1.Controls.Add(this.rb_SearchTransaction_DateFrom);
            this.panel1.Controls.Add(this.rb_SearchTransaction_CustomerName);
            this.panel1.Controls.Add(this.rb_SearchTransaction_CustomerID);
            this.panel1.Controls.Add(this.rb_SearchTransaction_InvoiceID);
            this.panel1.Controls.Add(this.cb_SearchTransaction_CostCenter);
            this.panel1.Controls.Add(this.cbox_SearchTransaction_CostCenter);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 304);
            this.panel1.TabIndex = 49;
            // 
            // cb_SearchTransaction_CostCenter
            // 
            this.cb_SearchTransaction_CostCenter.AutoSize = true;
            this.cb_SearchTransaction_CostCenter.Location = new System.Drawing.Point(14, 12);
            this.cb_SearchTransaction_CostCenter.Name = "cb_SearchTransaction_CostCenter";
            this.cb_SearchTransaction_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_SearchTransaction_CostCenter.TabIndex = 50;
            this.cb_SearchTransaction_CostCenter.Text = "Cost Center";
            this.cb_SearchTransaction_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cbox_SearchTransaction_CostCenter
            // 
            this.cbox_SearchTransaction_CostCenter.FormattingEnabled = true;
            this.cbox_SearchTransaction_CostCenter.Location = new System.Drawing.Point(14, 40);
            this.cbox_SearchTransaction_CostCenter.Name = "cbox_SearchTransaction_CostCenter";
            this.cbox_SearchTransaction_CostCenter.Size = new System.Drawing.Size(114, 23);
            this.cbox_SearchTransaction_CostCenter.TabIndex = 49;
            // 
            // rb_SearchTransaction_InvoiceID
            // 
            this.rb_SearchTransaction_InvoiceID.AutoSize = true;
            this.rb_SearchTransaction_InvoiceID.Location = new System.Drawing.Point(118, 11);
            this.rb_SearchTransaction_InvoiceID.Name = "rb_SearchTransaction_InvoiceID";
            this.rb_SearchTransaction_InvoiceID.Size = new System.Drawing.Size(81, 19);
            this.rb_SearchTransaction_InvoiceID.TabIndex = 51;
            this.rb_SearchTransaction_InvoiceID.TabStop = true;
            this.rb_SearchTransaction_InvoiceID.Text = "Invoice ID";
            this.rb_SearchTransaction_InvoiceID.UseVisualStyleBackColor = true;
            // 
            // rb_SearchTransaction_CustomerID
            // 
            this.rb_SearchTransaction_CustomerID.AutoSize = true;
            this.rb_SearchTransaction_CustomerID.Location = new System.Drawing.Point(205, 11);
            this.rb_SearchTransaction_CustomerID.Name = "rb_SearchTransaction_CustomerID";
            this.rb_SearchTransaction_CustomerID.Size = new System.Drawing.Size(92, 19);
            this.rb_SearchTransaction_CustomerID.TabIndex = 52;
            this.rb_SearchTransaction_CustomerID.TabStop = true;
            this.rb_SearchTransaction_CustomerID.Text = "Customer ID";
            this.rb_SearchTransaction_CustomerID.UseVisualStyleBackColor = true;
            // 
            // rb_SearchTransaction_CustomerName
            // 
            this.rb_SearchTransaction_CustomerName.AutoSize = true;
            this.rb_SearchTransaction_CustomerName.Location = new System.Drawing.Point(303, 11);
            this.rb_SearchTransaction_CustomerName.Name = "rb_SearchTransaction_CustomerName";
            this.rb_SearchTransaction_CustomerName.Size = new System.Drawing.Size(109, 19);
            this.rb_SearchTransaction_CustomerName.TabIndex = 53;
            this.rb_SearchTransaction_CustomerName.TabStop = true;
            this.rb_SearchTransaction_CustomerName.Text = "Customer Name";
            this.rb_SearchTransaction_CustomerName.UseVisualStyleBackColor = true;
            // 
            // rb_SearchTransaction_DateFrom
            // 
            this.rb_SearchTransaction_DateFrom.AutoSize = true;
            this.rb_SearchTransaction_DateFrom.Location = new System.Drawing.Point(418, 11);
            this.rb_SearchTransaction_DateFrom.Name = "rb_SearchTransaction_DateFrom";
            this.rb_SearchTransaction_DateFrom.Size = new System.Drawing.Size(80, 19);
            this.rb_SearchTransaction_DateFrom.TabIndex = 54;
            this.rb_SearchTransaction_DateFrom.TabStop = true;
            this.rb_SearchTransaction_DateFrom.Text = "Date From";
            this.rb_SearchTransaction_DateFrom.UseVisualStyleBackColor = true;
            // 
            // dt_SearchTransaction_DateFrom
            // 
            this.dt_SearchTransaction_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_SearchTransaction_DateFrom.Location = new System.Drawing.Point(505, 12);
            this.dt_SearchTransaction_DateFrom.Name = "dt_SearchTransaction_DateFrom";
            this.dt_SearchTransaction_DateFrom.Size = new System.Drawing.Size(101, 22);
            this.dt_SearchTransaction_DateFrom.TabIndex = 55;
            // 
            // lbl_SearchTransaction_DateTo
            // 
            this.lbl_SearchTransaction_DateTo.AutoSize = true;
            this.lbl_SearchTransaction_DateTo.Location = new System.Drawing.Point(612, 15);
            this.lbl_SearchTransaction_DateTo.Name = "lbl_SearchTransaction_DateTo";
            this.lbl_SearchTransaction_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_SearchTransaction_DateTo.TabIndex = 56;
            this.lbl_SearchTransaction_DateTo.Text = "To";
            // 
            // dt_SearchTransaction_DateTo
            // 
            this.dt_SearchTransaction_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_SearchTransaction_DateTo.Location = new System.Drawing.Point(639, 12);
            this.dt_SearchTransaction_DateTo.Name = "dt_SearchTransaction_DateTo";
            this.dt_SearchTransaction_DateTo.Size = new System.Drawing.Size(101, 22);
            this.dt_SearchTransaction_DateTo.TabIndex = 57;
            // 
            // lbl_SearchTransaction_Keyword
            // 
            this.lbl_SearchTransaction_Keyword.AutoSize = true;
            this.lbl_SearchTransaction_Keyword.Location = new System.Drawing.Point(143, 43);
            this.lbl_SearchTransaction_Keyword.Name = "lbl_SearchTransaction_Keyword";
            this.lbl_SearchTransaction_Keyword.Size = new System.Drawing.Size(56, 15);
            this.lbl_SearchTransaction_Keyword.TabIndex = 58;
            this.lbl_SearchTransaction_Keyword.Text = "Keyword";
            // 
            // txt_SearchTransaction_Keyword
            // 
            this.txt_SearchTransaction_Keyword.Location = new System.Drawing.Point(206, 40);
            this.txt_SearchTransaction_Keyword.Name = "txt_SearchTransaction_Keyword";
            this.txt_SearchTransaction_Keyword.Size = new System.Drawing.Size(493, 22);
            this.txt_SearchTransaction_Keyword.TabIndex = 59;
            // 
            // btn_SearchTransaction_SearchKeyword
            // 
            this.btn_SearchTransaction_SearchKeyword.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_SearchTransaction_SearchKeyword.Location = new System.Drawing.Point(705, 40);
            this.btn_SearchTransaction_SearchKeyword.Name = "btn_SearchTransaction_SearchKeyword";
            this.btn_SearchTransaction_SearchKeyword.Size = new System.Drawing.Size(35, 32);
            this.btn_SearchTransaction_SearchKeyword.TabIndex = 60;
            this.btn_SearchTransaction_SearchKeyword.UseVisualStyleBackColor = true;
            // 
            // GV_SearchTransaction_TransactionDetails
            // 
            this.GV_SearchTransaction_TransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_SearchTransaction_TransactionDetails.Location = new System.Drawing.Point(14, 78);
            this.GV_SearchTransaction_TransactionDetails.Name = "GV_SearchTransaction_TransactionDetails";
            this.GV_SearchTransaction_TransactionDetails.Size = new System.Drawing.Size(726, 216);
            this.GV_SearchTransaction_TransactionDetails.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_SearchTransaction_Close);
            this.panel2.Controls.Add(this.btn_SearchTransaction_Select);
            this.panel2.Location = new System.Drawing.Point(13, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 44);
            this.panel2.TabIndex = 50;
            // 
            // btn_SearchTransaction_Close
            // 
            this.btn_SearchTransaction_Close.Location = new System.Drawing.Point(649, 4);
            this.btn_SearchTransaction_Close.Name = "btn_SearchTransaction_Close";
            this.btn_SearchTransaction_Close.Size = new System.Drawing.Size(91, 35);
            this.btn_SearchTransaction_Close.TabIndex = 48;
            this.btn_SearchTransaction_Close.Text = "Close";
            this.btn_SearchTransaction_Close.UseVisualStyleBackColor = true;
            // 
            // btn_SearchTransaction_Select
            // 
            this.btn_SearchTransaction_Select.Location = new System.Drawing.Point(552, 4);
            this.btn_SearchTransaction_Select.Name = "btn_SearchTransaction_Select";
            this.btn_SearchTransaction_Select.Size = new System.Drawing.Size(91, 35);
            this.btn_SearchTransaction_Select.TabIndex = 47;
            this.btn_SearchTransaction_Select.Text = "Select";
            this.btn_SearchTransaction_Select.UseVisualStyleBackColor = true;
            // 
            // Frm_Transactions_SearchTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 373);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Transactions_SearchTransaction";
            this.Text = "Frm_Transactions_SearchTransaction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SearchTransaction_TransactionDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GV_SearchTransaction_TransactionDetails;
        private System.Windows.Forms.Button btn_SearchTransaction_SearchKeyword;
        private System.Windows.Forms.TextBox txt_SearchTransaction_Keyword;
        private System.Windows.Forms.Label lbl_SearchTransaction_Keyword;
        private System.Windows.Forms.DateTimePicker dt_SearchTransaction_DateTo;
        private System.Windows.Forms.Label lbl_SearchTransaction_DateTo;
        private System.Windows.Forms.DateTimePicker dt_SearchTransaction_DateFrom;
        private System.Windows.Forms.RadioButton rb_SearchTransaction_DateFrom;
        private System.Windows.Forms.RadioButton rb_SearchTransaction_CustomerName;
        private System.Windows.Forms.RadioButton rb_SearchTransaction_CustomerID;
        private System.Windows.Forms.RadioButton rb_SearchTransaction_InvoiceID;
        private System.Windows.Forms.CheckBox cb_SearchTransaction_CostCenter;
        private System.Windows.Forms.ComboBox cbox_SearchTransaction_CostCenter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SearchTransaction_Close;
        private System.Windows.Forms.Button btn_SearchTransaction_Select;
    }
}