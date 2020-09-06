namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_ClientOutstanding
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
            this.GV_ClientOutstanding_InvoiceDetails = new System.Windows.Forms.DataGridView();
            this.btn_ClientOutstanding_Print = new System.Windows.Forms.Button();
            this.btn_ClientOutstanding_Search = new System.Windows.Forms.Button();
            this.cob_ClientOutstanding_CostCenter = new System.Windows.Forms.ComboBox();
            this.cb_ClientOutstanding_CostCenter = new System.Windows.Forms.CheckBox();
            this.txt_ClientOutstanding_LedgerCode = new System.Windows.Forms.TextBox();
            this.lbl_ClientOutstanding_LedgerCode = new System.Windows.Forms.Label();
            this.txt_ClientOutstanding_CustomerOrSupplierID = new System.Windows.Forms.TextBox();
            this.txt_ClientOutstanding_CustomerOrSupplierName = new System.Windows.Forms.TextBox();
            this.lbl_ClientOutstanding_CustomerOrSupplierID = new System.Windows.Forms.Label();
            this.lbl_ClientOutstanding_CustomerOrSupplierName = new System.Windows.Forms.Label();
            this.rb_ClientOutstanding_Supplier = new System.Windows.Forms.RadioButton();
            this.rb_ClientOutstanding_Customer = new System.Windows.Forms.RadioButton();
            this.cb_ClientOutstanding_FilterByProject = new System.Windows.Forms.CheckBox();
            this.txt_ClientOutstanding_Project = new System.Windows.Forms.TextBox();
            this.cob_ClientOutstanding_AsOnDate = new System.Windows.Forms.ComboBox();
            this.cb_ClientOutstanding_AsOnDate = new System.Windows.Forms.CheckBox();
            this.btn_ClientOutstanding_New = new System.Windows.Forms.Button();
            this.txt_ClientOutstanding_Debit = new System.Windows.Forms.TextBox();
            this.txt_ClientOutstanding_Credit = new System.Windows.Forms.TextBox();
            this.txt_ClientOutstanding_Balance = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ClientOutstanding_InvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_ClientOutstanding_Balance);
            this.panel1.Controls.Add(this.txt_ClientOutstanding_Credit);
            this.panel1.Controls.Add(this.txt_ClientOutstanding_Debit);
            this.panel1.Controls.Add(this.btn_ClientOutstanding_New);
            this.panel1.Controls.Add(this.cob_ClientOutstanding_AsOnDate);
            this.panel1.Controls.Add(this.cb_ClientOutstanding_AsOnDate);
            this.panel1.Controls.Add(this.txt_ClientOutstanding_Project);
            this.panel1.Controls.Add(this.cb_ClientOutstanding_FilterByProject);
            this.panel1.Controls.Add(this.GV_ClientOutstanding_InvoiceDetails);
            this.panel1.Controls.Add(this.btn_ClientOutstanding_Print);
            this.panel1.Controls.Add(this.btn_ClientOutstanding_Search);
            this.panel1.Controls.Add(this.cob_ClientOutstanding_CostCenter);
            this.panel1.Controls.Add(this.cb_ClientOutstanding_CostCenter);
            this.panel1.Controls.Add(this.txt_ClientOutstanding_LedgerCode);
            this.panel1.Controls.Add(this.lbl_ClientOutstanding_LedgerCode);
            this.panel1.Controls.Add(this.txt_ClientOutstanding_CustomerOrSupplierID);
            this.panel1.Controls.Add(this.txt_ClientOutstanding_CustomerOrSupplierName);
            this.panel1.Controls.Add(this.lbl_ClientOutstanding_CustomerOrSupplierID);
            this.panel1.Controls.Add(this.lbl_ClientOutstanding_CustomerOrSupplierName);
            this.panel1.Controls.Add(this.rb_ClientOutstanding_Supplier);
            this.panel1.Controls.Add(this.rb_ClientOutstanding_Customer);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 396);
            this.panel1.TabIndex = 1;
            // 
            // GV_ClientOutstanding_InvoiceDetails
            // 
            this.GV_ClientOutstanding_InvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ClientOutstanding_InvoiceDetails.Location = new System.Drawing.Point(13, 78);
            this.GV_ClientOutstanding_InvoiceDetails.Name = "GV_ClientOutstanding_InvoiceDetails";
            this.GV_ClientOutstanding_InvoiceDetails.Size = new System.Drawing.Size(1124, 267);
            this.GV_ClientOutstanding_InvoiceDetails.TabIndex = 12;
            // 
            // btn_ClientOutstanding_Print
            // 
            this.btn_ClientOutstanding_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClientOutstanding_Print.Location = new System.Drawing.Point(1062, 12);
            this.btn_ClientOutstanding_Print.Name = "btn_ClientOutstanding_Print";
            this.btn_ClientOutstanding_Print.Size = new System.Drawing.Size(75, 48);
            this.btn_ClientOutstanding_Print.TabIndex = 11;
            this.btn_ClientOutstanding_Print.Text = "Print";
            this.btn_ClientOutstanding_Print.UseVisualStyleBackColor = true;
            // 
            // btn_ClientOutstanding_Search
            // 
            this.btn_ClientOutstanding_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClientOutstanding_Search.Location = new System.Drawing.Point(981, 13);
            this.btn_ClientOutstanding_Search.Name = "btn_ClientOutstanding_Search";
            this.btn_ClientOutstanding_Search.Size = new System.Drawing.Size(75, 48);
            this.btn_ClientOutstanding_Search.TabIndex = 10;
            this.btn_ClientOutstanding_Search.Text = "Search";
            this.btn_ClientOutstanding_Search.UseVisualStyleBackColor = true;
            // 
            // cob_ClientOutstanding_CostCenter
            // 
            this.cob_ClientOutstanding_CostCenter.FormattingEnabled = true;
            this.cob_ClientOutstanding_CostCenter.Location = new System.Drawing.Point(854, 37);
            this.cob_ClientOutstanding_CostCenter.Name = "cob_ClientOutstanding_CostCenter";
            this.cob_ClientOutstanding_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_ClientOutstanding_CostCenter.TabIndex = 9;
            // 
            // cb_ClientOutstanding_CostCenter
            // 
            this.cb_ClientOutstanding_CostCenter.AutoSize = true;
            this.cb_ClientOutstanding_CostCenter.Location = new System.Drawing.Point(854, 12);
            this.cb_ClientOutstanding_CostCenter.Name = "cb_ClientOutstanding_CostCenter";
            this.cb_ClientOutstanding_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_ClientOutstanding_CostCenter.TabIndex = 8;
            this.cb_ClientOutstanding_CostCenter.Text = "Cost Center";
            this.cb_ClientOutstanding_CostCenter.UseVisualStyleBackColor = true;
            // 
            // txt_ClientOutstanding_LedgerCode
            // 
            this.txt_ClientOutstanding_LedgerCode.Location = new System.Drawing.Point(429, 40);
            this.txt_ClientOutstanding_LedgerCode.Name = "txt_ClientOutstanding_LedgerCode";
            this.txt_ClientOutstanding_LedgerCode.Size = new System.Drawing.Size(92, 22);
            this.txt_ClientOutstanding_LedgerCode.TabIndex = 7;
            // 
            // lbl_ClientOutstanding_LedgerCode
            // 
            this.lbl_ClientOutstanding_LedgerCode.AutoSize = true;
            this.lbl_ClientOutstanding_LedgerCode.Location = new System.Drawing.Point(345, 44);
            this.lbl_ClientOutstanding_LedgerCode.Name = "lbl_ClientOutstanding_LedgerCode";
            this.lbl_ClientOutstanding_LedgerCode.Size = new System.Drawing.Size(75, 15);
            this.lbl_ClientOutstanding_LedgerCode.TabIndex = 6;
            this.lbl_ClientOutstanding_LedgerCode.Text = "Ledger Code";
            // 
            // txt_ClientOutstanding_CustomerOrSupplierID
            // 
            this.txt_ClientOutstanding_CustomerOrSupplierID.Location = new System.Drawing.Point(261, 42);
            this.txt_ClientOutstanding_CustomerOrSupplierID.Name = "txt_ClientOutstanding_CustomerOrSupplierID";
            this.txt_ClientOutstanding_CustomerOrSupplierID.Size = new System.Drawing.Size(78, 22);
            this.txt_ClientOutstanding_CustomerOrSupplierID.TabIndex = 5;
            // 
            // txt_ClientOutstanding_CustomerOrSupplierName
            // 
            this.txt_ClientOutstanding_CustomerOrSupplierName.Location = new System.Drawing.Point(261, 14);
            this.txt_ClientOutstanding_CustomerOrSupplierName.Name = "txt_ClientOutstanding_CustomerOrSupplierName";
            this.txt_ClientOutstanding_CustomerOrSupplierName.Size = new System.Drawing.Size(260, 22);
            this.txt_ClientOutstanding_CustomerOrSupplierName.TabIndex = 4;
            // 
            // lbl_ClientOutstanding_CustomerOrSupplierID
            // 
            this.lbl_ClientOutstanding_CustomerOrSupplierID.AutoSize = true;
            this.lbl_ClientOutstanding_CustomerOrSupplierID.Location = new System.Drawing.Point(110, 45);
            this.lbl_ClientOutstanding_CustomerOrSupplierID.Name = "lbl_ClientOutstanding_CustomerOrSupplierID";
            this.lbl_ClientOutstanding_CustomerOrSupplierID.Size = new System.Drawing.Size(128, 15);
            this.lbl_ClientOutstanding_CustomerOrSupplierID.TabIndex = 3;
            this.lbl_ClientOutstanding_CustomerOrSupplierID.Text = "Customer / Supplier ID";
            // 
            // lbl_ClientOutstanding_CustomerOrSupplierName
            // 
            this.lbl_ClientOutstanding_CustomerOrSupplierName.AutoSize = true;
            this.lbl_ClientOutstanding_CustomerOrSupplierName.Location = new System.Drawing.Point(110, 17);
            this.lbl_ClientOutstanding_CustomerOrSupplierName.Name = "lbl_ClientOutstanding_CustomerOrSupplierName";
            this.lbl_ClientOutstanding_CustomerOrSupplierName.Size = new System.Drawing.Size(145, 15);
            this.lbl_ClientOutstanding_CustomerOrSupplierName.TabIndex = 2;
            this.lbl_ClientOutstanding_CustomerOrSupplierName.Text = "Customer / Supplier Name";
            // 
            // rb_ClientOutstanding_Supplier
            // 
            this.rb_ClientOutstanding_Supplier.AutoSize = true;
            this.rb_ClientOutstanding_Supplier.Location = new System.Drawing.Point(13, 42);
            this.rb_ClientOutstanding_Supplier.Name = "rb_ClientOutstanding_Supplier";
            this.rb_ClientOutstanding_Supplier.Size = new System.Drawing.Size(69, 19);
            this.rb_ClientOutstanding_Supplier.TabIndex = 1;
            this.rb_ClientOutstanding_Supplier.TabStop = true;
            this.rb_ClientOutstanding_Supplier.Text = "Supplier";
            this.rb_ClientOutstanding_Supplier.UseVisualStyleBackColor = true;
            // 
            // rb_ClientOutstanding_Customer
            // 
            this.rb_ClientOutstanding_Customer.AutoSize = true;
            this.rb_ClientOutstanding_Customer.Location = new System.Drawing.Point(13, 17);
            this.rb_ClientOutstanding_Customer.Name = "rb_ClientOutstanding_Customer";
            this.rb_ClientOutstanding_Customer.Size = new System.Drawing.Size(76, 19);
            this.rb_ClientOutstanding_Customer.TabIndex = 0;
            this.rb_ClientOutstanding_Customer.TabStop = true;
            this.rb_ClientOutstanding_Customer.Text = "Customer";
            this.rb_ClientOutstanding_Customer.UseVisualStyleBackColor = true;
            // 
            // cb_ClientOutstanding_FilterByProject
            // 
            this.cb_ClientOutstanding_FilterByProject.AutoSize = true;
            this.cb_ClientOutstanding_FilterByProject.Location = new System.Drawing.Point(527, 17);
            this.cb_ClientOutstanding_FilterByProject.Name = "cb_ClientOutstanding_FilterByProject";
            this.cb_ClientOutstanding_FilterByProject.Size = new System.Drawing.Size(111, 19);
            this.cb_ClientOutstanding_FilterByProject.TabIndex = 13;
            this.cb_ClientOutstanding_FilterByProject.Text = "Filter By Project";
            this.cb_ClientOutstanding_FilterByProject.UseVisualStyleBackColor = true;
            // 
            // txt_ClientOutstanding_Project
            // 
            this.txt_ClientOutstanding_Project.Location = new System.Drawing.Point(527, 38);
            this.txt_ClientOutstanding_Project.Name = "txt_ClientOutstanding_Project";
            this.txt_ClientOutstanding_Project.Size = new System.Drawing.Size(194, 22);
            this.txt_ClientOutstanding_Project.TabIndex = 14;
            // 
            // cob_ClientOutstanding_AsOnDate
            // 
            this.cob_ClientOutstanding_AsOnDate.FormattingEnabled = true;
            this.cob_ClientOutstanding_AsOnDate.Location = new System.Drawing.Point(727, 37);
            this.cob_ClientOutstanding_AsOnDate.Name = "cob_ClientOutstanding_AsOnDate";
            this.cob_ClientOutstanding_AsOnDate.Size = new System.Drawing.Size(121, 23);
            this.cob_ClientOutstanding_AsOnDate.TabIndex = 16;
            // 
            // cb_ClientOutstanding_AsOnDate
            // 
            this.cb_ClientOutstanding_AsOnDate.AutoSize = true;
            this.cb_ClientOutstanding_AsOnDate.Location = new System.Drawing.Point(727, 13);
            this.cb_ClientOutstanding_AsOnDate.Name = "cb_ClientOutstanding_AsOnDate";
            this.cb_ClientOutstanding_AsOnDate.Size = new System.Drawing.Size(87, 19);
            this.cb_ClientOutstanding_AsOnDate.TabIndex = 15;
            this.cb_ClientOutstanding_AsOnDate.Text = "As on Date";
            this.cb_ClientOutstanding_AsOnDate.UseVisualStyleBackColor = true;
            // 
            // btn_ClientOutstanding_New
            // 
            this.btn_ClientOutstanding_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClientOutstanding_New.Location = new System.Drawing.Point(180, 351);
            this.btn_ClientOutstanding_New.Name = "btn_ClientOutstanding_New";
            this.btn_ClientOutstanding_New.Size = new System.Drawing.Size(75, 34);
            this.btn_ClientOutstanding_New.TabIndex = 17;
            this.btn_ClientOutstanding_New.Text = "New";
            this.btn_ClientOutstanding_New.UseVisualStyleBackColor = true;
            // 
            // txt_ClientOutstanding_Debit
            // 
            this.txt_ClientOutstanding_Debit.Location = new System.Drawing.Point(435, 358);
            this.txt_ClientOutstanding_Debit.Name = "txt_ClientOutstanding_Debit";
            this.txt_ClientOutstanding_Debit.Size = new System.Drawing.Size(114, 22);
            this.txt_ClientOutstanding_Debit.TabIndex = 18;
            // 
            // txt_ClientOutstanding_Credit
            // 
            this.txt_ClientOutstanding_Credit.Location = new System.Drawing.Point(555, 358);
            this.txt_ClientOutstanding_Credit.Name = "txt_ClientOutstanding_Credit";
            this.txt_ClientOutstanding_Credit.Size = new System.Drawing.Size(114, 22);
            this.txt_ClientOutstanding_Credit.TabIndex = 19;
            // 
            // txt_ClientOutstanding_Balance
            // 
            this.txt_ClientOutstanding_Balance.Location = new System.Drawing.Point(675, 358);
            this.txt_ClientOutstanding_Balance.Name = "txt_ClientOutstanding_Balance";
            this.txt_ClientOutstanding_Balance.Size = new System.Drawing.Size(114, 22);
            this.txt_ClientOutstanding_Balance.TabIndex = 20;
            // 
            // frm_Accounts_ClientOutstanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1166, 418);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Accounts_ClientOutstanding";
            this.Text = "frm_Accounts_ClientOutstanding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ClientOutstanding_InvoiceDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ClientOutstanding_Balance;
        private System.Windows.Forms.TextBox txt_ClientOutstanding_Credit;
        private System.Windows.Forms.TextBox txt_ClientOutstanding_Debit;
        private System.Windows.Forms.Button btn_ClientOutstanding_New;
        private System.Windows.Forms.ComboBox cob_ClientOutstanding_AsOnDate;
        private System.Windows.Forms.CheckBox cb_ClientOutstanding_AsOnDate;
        private System.Windows.Forms.TextBox txt_ClientOutstanding_Project;
        private System.Windows.Forms.CheckBox cb_ClientOutstanding_FilterByProject;
        private System.Windows.Forms.DataGridView GV_ClientOutstanding_InvoiceDetails;
        private System.Windows.Forms.Button btn_ClientOutstanding_Print;
        private System.Windows.Forms.Button btn_ClientOutstanding_Search;
        private System.Windows.Forms.ComboBox cob_ClientOutstanding_CostCenter;
        private System.Windows.Forms.CheckBox cb_ClientOutstanding_CostCenter;
        private System.Windows.Forms.TextBox txt_ClientOutstanding_LedgerCode;
        private System.Windows.Forms.Label lbl_ClientOutstanding_LedgerCode;
        private System.Windows.Forms.TextBox txt_ClientOutstanding_CustomerOrSupplierID;
        private System.Windows.Forms.TextBox txt_ClientOutstanding_CustomerOrSupplierName;
        private System.Windows.Forms.Label lbl_ClientOutstanding_CustomerOrSupplierID;
        private System.Windows.Forms.Label lbl_ClientOutstanding_CustomerOrSupplierName;
        private System.Windows.Forms.RadioButton rb_ClientOutstanding_Supplier;
        private System.Windows.Forms.RadioButton rb_ClientOutstanding_Customer;
    }
}