namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_InvoiceOutstanding
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
            this.rb_InvoiceOutstanding_Customer = new System.Windows.Forms.RadioButton();
            this.rb_InvoiceOutstanding_Supplier = new System.Windows.Forms.RadioButton();
            this.lbl_InvoiceOutstanding_CustomerOrSupplierName = new System.Windows.Forms.Label();
            this.lbl_InvoiceOutstanding_CustomerOrSupplierID = new System.Windows.Forms.Label();
            this.txt_InvoiceOutstanding_CustomerOrSupplierName = new System.Windows.Forms.TextBox();
            this.txt_InvoiceOutstanding_CustomerOrSupplierID = new System.Windows.Forms.TextBox();
            this.txt_InvoiceOutstanding_LedgerCode = new System.Windows.Forms.TextBox();
            this.lbl_InvoiceOutstanding_LedgerCode = new System.Windows.Forms.Label();
            this.cb_InvoiceOutstanding_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_InvoiceOutstanding_CostCenter = new System.Windows.Forms.ComboBox();
            this.btn_InvoiceOutstanding_Search = new System.Windows.Forms.Button();
            this.btn_InvoiceOutstanding_Print = new System.Windows.Forms.Button();
            this.GV_InvoiceOutstanding_InvoiceDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_InvoiceOutstanding_InvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GV_InvoiceOutstanding_InvoiceDetails);
            this.panel1.Controls.Add(this.btn_InvoiceOutstanding_Print);
            this.panel1.Controls.Add(this.btn_InvoiceOutstanding_Search);
            this.panel1.Controls.Add(this.cob_InvoiceOutstanding_CostCenter);
            this.panel1.Controls.Add(this.cb_InvoiceOutstanding_CostCenter);
            this.panel1.Controls.Add(this.txt_InvoiceOutstanding_LedgerCode);
            this.panel1.Controls.Add(this.lbl_InvoiceOutstanding_LedgerCode);
            this.panel1.Controls.Add(this.txt_InvoiceOutstanding_CustomerOrSupplierID);
            this.panel1.Controls.Add(this.txt_InvoiceOutstanding_CustomerOrSupplierName);
            this.panel1.Controls.Add(this.lbl_InvoiceOutstanding_CustomerOrSupplierID);
            this.panel1.Controls.Add(this.lbl_InvoiceOutstanding_CustomerOrSupplierName);
            this.panel1.Controls.Add(this.rb_InvoiceOutstanding_Supplier);
            this.panel1.Controls.Add(this.rb_InvoiceOutstanding_Customer);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 359);
            this.panel1.TabIndex = 0;
            // 
            // rb_InvoiceOutstanding_Customer
            // 
            this.rb_InvoiceOutstanding_Customer.AutoSize = true;
            this.rb_InvoiceOutstanding_Customer.Location = new System.Drawing.Point(13, 17);
            this.rb_InvoiceOutstanding_Customer.Name = "rb_InvoiceOutstanding_Customer";
            this.rb_InvoiceOutstanding_Customer.Size = new System.Drawing.Size(76, 19);
            this.rb_InvoiceOutstanding_Customer.TabIndex = 0;
            this.rb_InvoiceOutstanding_Customer.TabStop = true;
            this.rb_InvoiceOutstanding_Customer.Text = "Customer";
            this.rb_InvoiceOutstanding_Customer.UseVisualStyleBackColor = true;
            // 
            // rb_InvoiceOutstanding_Supplier
            // 
            this.rb_InvoiceOutstanding_Supplier.AutoSize = true;
            this.rb_InvoiceOutstanding_Supplier.Location = new System.Drawing.Point(13, 42);
            this.rb_InvoiceOutstanding_Supplier.Name = "rb_InvoiceOutstanding_Supplier";
            this.rb_InvoiceOutstanding_Supplier.Size = new System.Drawing.Size(69, 19);
            this.rb_InvoiceOutstanding_Supplier.TabIndex = 1;
            this.rb_InvoiceOutstanding_Supplier.TabStop = true;
            this.rb_InvoiceOutstanding_Supplier.Text = "Supplier";
            this.rb_InvoiceOutstanding_Supplier.UseVisualStyleBackColor = true;
            // 
            // lbl_InvoiceOutstanding_CustomerOrSupplierName
            // 
            this.lbl_InvoiceOutstanding_CustomerOrSupplierName.AutoSize = true;
            this.lbl_InvoiceOutstanding_CustomerOrSupplierName.Location = new System.Drawing.Point(110, 17);
            this.lbl_InvoiceOutstanding_CustomerOrSupplierName.Name = "lbl_InvoiceOutstanding_CustomerOrSupplierName";
            this.lbl_InvoiceOutstanding_CustomerOrSupplierName.Size = new System.Drawing.Size(145, 15);
            this.lbl_InvoiceOutstanding_CustomerOrSupplierName.TabIndex = 2;
            this.lbl_InvoiceOutstanding_CustomerOrSupplierName.Text = "Customer / Supplier Name";
            // 
            // lbl_InvoiceOutstanding_CustomerOrSupplierID
            // 
            this.lbl_InvoiceOutstanding_CustomerOrSupplierID.AutoSize = true;
            this.lbl_InvoiceOutstanding_CustomerOrSupplierID.Location = new System.Drawing.Point(110, 45);
            this.lbl_InvoiceOutstanding_CustomerOrSupplierID.Name = "lbl_InvoiceOutstanding_CustomerOrSupplierID";
            this.lbl_InvoiceOutstanding_CustomerOrSupplierID.Size = new System.Drawing.Size(128, 15);
            this.lbl_InvoiceOutstanding_CustomerOrSupplierID.TabIndex = 3;
            this.lbl_InvoiceOutstanding_CustomerOrSupplierID.Text = "Customer / Supplier ID";
            // 
            // txt_InvoiceOutstanding_CustomerOrSupplierName
            // 
            this.txt_InvoiceOutstanding_CustomerOrSupplierName.Location = new System.Drawing.Point(261, 14);
            this.txt_InvoiceOutstanding_CustomerOrSupplierName.Name = "txt_InvoiceOutstanding_CustomerOrSupplierName";
            this.txt_InvoiceOutstanding_CustomerOrSupplierName.Size = new System.Drawing.Size(337, 22);
            this.txt_InvoiceOutstanding_CustomerOrSupplierName.TabIndex = 4;
            // 
            // txt_InvoiceOutstanding_CustomerOrSupplierID
            // 
            this.txt_InvoiceOutstanding_CustomerOrSupplierID.Location = new System.Drawing.Point(261, 42);
            this.txt_InvoiceOutstanding_CustomerOrSupplierID.Name = "txt_InvoiceOutstanding_CustomerOrSupplierID";
            this.txt_InvoiceOutstanding_CustomerOrSupplierID.Size = new System.Drawing.Size(125, 22);
            this.txt_InvoiceOutstanding_CustomerOrSupplierID.TabIndex = 5;
            // 
            // txt_InvoiceOutstanding_LedgerCode
            // 
            this.txt_InvoiceOutstanding_LedgerCode.Location = new System.Drawing.Point(473, 42);
            this.txt_InvoiceOutstanding_LedgerCode.Name = "txt_InvoiceOutstanding_LedgerCode";
            this.txt_InvoiceOutstanding_LedgerCode.Size = new System.Drawing.Size(125, 22);
            this.txt_InvoiceOutstanding_LedgerCode.TabIndex = 7;
            // 
            // lbl_InvoiceOutstanding_LedgerCode
            // 
            this.lbl_InvoiceOutstanding_LedgerCode.AutoSize = true;
            this.lbl_InvoiceOutstanding_LedgerCode.Location = new System.Drawing.Point(392, 44);
            this.lbl_InvoiceOutstanding_LedgerCode.Name = "lbl_InvoiceOutstanding_LedgerCode";
            this.lbl_InvoiceOutstanding_LedgerCode.Size = new System.Drawing.Size(75, 15);
            this.lbl_InvoiceOutstanding_LedgerCode.TabIndex = 6;
            this.lbl_InvoiceOutstanding_LedgerCode.Text = "Ledger Code";
            // 
            // cb_InvoiceOutstanding_CostCenter
            // 
            this.cb_InvoiceOutstanding_CostCenter.AutoSize = true;
            this.cb_InvoiceOutstanding_CostCenter.Location = new System.Drawing.Point(605, 17);
            this.cb_InvoiceOutstanding_CostCenter.Name = "cb_InvoiceOutstanding_CostCenter";
            this.cb_InvoiceOutstanding_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_InvoiceOutstanding_CostCenter.TabIndex = 8;
            this.cb_InvoiceOutstanding_CostCenter.Text = "Cost Center";
            this.cb_InvoiceOutstanding_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_InvoiceOutstanding_CostCenter
            // 
            this.cob_InvoiceOutstanding_CostCenter.FormattingEnabled = true;
            this.cob_InvoiceOutstanding_CostCenter.Location = new System.Drawing.Point(605, 42);
            this.cob_InvoiceOutstanding_CostCenter.Name = "cob_InvoiceOutstanding_CostCenter";
            this.cob_InvoiceOutstanding_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_InvoiceOutstanding_CostCenter.TabIndex = 9;
            // 
            // btn_InvoiceOutstanding_Search
            // 
            this.btn_InvoiceOutstanding_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InvoiceOutstanding_Search.Location = new System.Drawing.Point(732, 17);
            this.btn_InvoiceOutstanding_Search.Name = "btn_InvoiceOutstanding_Search";
            this.btn_InvoiceOutstanding_Search.Size = new System.Drawing.Size(75, 48);
            this.btn_InvoiceOutstanding_Search.TabIndex = 10;
            this.btn_InvoiceOutstanding_Search.Text = "Search";
            this.btn_InvoiceOutstanding_Search.UseVisualStyleBackColor = true;
            // 
            // btn_InvoiceOutstanding_Print
            // 
            this.btn_InvoiceOutstanding_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InvoiceOutstanding_Print.Location = new System.Drawing.Point(813, 16);
            this.btn_InvoiceOutstanding_Print.Name = "btn_InvoiceOutstanding_Print";
            this.btn_InvoiceOutstanding_Print.Size = new System.Drawing.Size(75, 48);
            this.btn_InvoiceOutstanding_Print.TabIndex = 11;
            this.btn_InvoiceOutstanding_Print.Text = "Print";
            this.btn_InvoiceOutstanding_Print.UseVisualStyleBackColor = true;
            // 
            // GV_InvoiceOutstanding_InvoiceDetails
            // 
            this.GV_InvoiceOutstanding_InvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_InvoiceOutstanding_InvoiceDetails.Location = new System.Drawing.Point(13, 78);
            this.GV_InvoiceOutstanding_InvoiceDetails.Name = "GV_InvoiceOutstanding_InvoiceDetails";
            this.GV_InvoiceOutstanding_InvoiceDetails.Size = new System.Drawing.Size(875, 267);
            this.GV_InvoiceOutstanding_InvoiceDetails.TabIndex = 12;
            // 
            // frm_Accounts_InvoiceOutstanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 386);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Accounts_InvoiceOutstanding";
            this.Text = "frm_Accounts_InvoiceOutstanding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_InvoiceOutstanding_InvoiceDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GV_InvoiceOutstanding_InvoiceDetails;
        private System.Windows.Forms.Button btn_InvoiceOutstanding_Print;
        private System.Windows.Forms.Button btn_InvoiceOutstanding_Search;
        private System.Windows.Forms.ComboBox cob_InvoiceOutstanding_CostCenter;
        private System.Windows.Forms.CheckBox cb_InvoiceOutstanding_CostCenter;
        private System.Windows.Forms.TextBox txt_InvoiceOutstanding_LedgerCode;
        private System.Windows.Forms.Label lbl_InvoiceOutstanding_LedgerCode;
        private System.Windows.Forms.TextBox txt_InvoiceOutstanding_CustomerOrSupplierID;
        private System.Windows.Forms.TextBox txt_InvoiceOutstanding_CustomerOrSupplierName;
        private System.Windows.Forms.Label lbl_InvoiceOutstanding_CustomerOrSupplierID;
        private System.Windows.Forms.Label lbl_InvoiceOutstanding_CustomerOrSupplierName;
        private System.Windows.Forms.RadioButton rb_InvoiceOutstanding_Supplier;
        private System.Windows.Forms.RadioButton rb_InvoiceOutstanding_Customer;
    }
}