namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_TransApproval
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
            this.gb_TransApproval_TransactionDate = new System.Windows.Forms.GroupBox();
            this.lbl_TransApproval_TransDateFrom = new System.Windows.Forms.Label();
            this.dt_TransApproval_TransDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dt_TransApproval_TransDateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_TransApproval_TransDateTo = new System.Windows.Forms.Label();
            this.gb_TransApproval_FilterBy = new System.Windows.Forms.GroupBox();
            this.cb_TransApproval_NotApproved = new System.Windows.Forms.CheckBox();
            this.cb_TransApproval_Approved = new System.Windows.Forms.CheckBox();
            this.gb_TransApproval_TransactionName = new System.Windows.Forms.GroupBox();
            this.cb_TransApproval_Purchase = new System.Windows.Forms.CheckBox();
            this.cb_TransApproval_Sales = new System.Windows.Forms.CheckBox();
            this.cb_TransApproval_PurchaseReturn = new System.Windows.Forms.CheckBox();
            this.cb_TransApproval_SalesReturn = new System.Windows.Forms.CheckBox();
            this.cb_TransApproval_DepositsOrWithdrawals = new System.Windows.Forms.CheckBox();
            this.cb_TransApproval_WastageDisposal = new System.Windows.Forms.CheckBox();
            this.cb_TransApproval_Receipts = new System.Windows.Forms.CheckBox();
            this.cb_TransApproval_Payments = new System.Windows.Forms.CheckBox();
            this.cob_TransApproval_CostCenter = new System.Windows.Forms.ComboBox();
            this.cb_TransApproval_CostCenter = new System.Windows.Forms.CheckBox();
            this.btn_TransApproval_Show = new System.Windows.Forms.Button();
            this.btn_TransApproval_Print = new System.Windows.Forms.Button();
            this.GV_TransApproval_TransactionDetails = new System.Windows.Forms.DataGridView();
            this.btn_TransApproval_Update = new System.Windows.Forms.Button();
            this.btn_TransApproval_Clear = new System.Windows.Forms.Button();
            this.gb_TransApproval_TransactionDate.SuspendLayout();
            this.gb_TransApproval_FilterBy.SuspendLayout();
            this.gb_TransApproval_TransactionName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_TransApproval_TransactionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_TransApproval_TransactionDate
            // 
            this.gb_TransApproval_TransactionDate.Controls.Add(this.dt_TransApproval_TransDateTo);
            this.gb_TransApproval_TransactionDate.Controls.Add(this.lbl_TransApproval_TransDateTo);
            this.gb_TransApproval_TransactionDate.Controls.Add(this.dt_TransApproval_TransDateFrom);
            this.gb_TransApproval_TransactionDate.Controls.Add(this.lbl_TransApproval_TransDateFrom);
            this.gb_TransApproval_TransactionDate.Location = new System.Drawing.Point(13, 13);
            this.gb_TransApproval_TransactionDate.Name = "gb_TransApproval_TransactionDate";
            this.gb_TransApproval_TransactionDate.Size = new System.Drawing.Size(165, 80);
            this.gb_TransApproval_TransactionDate.TabIndex = 0;
            this.gb_TransApproval_TransactionDate.TabStop = false;
            this.gb_TransApproval_TransactionDate.Text = "Transaction Date";
            // 
            // lbl_TransApproval_TransDateFrom
            // 
            this.lbl_TransApproval_TransDateFrom.AutoSize = true;
            this.lbl_TransApproval_TransDateFrom.Location = new System.Drawing.Point(7, 22);
            this.lbl_TransApproval_TransDateFrom.Name = "lbl_TransApproval_TransDateFrom";
            this.lbl_TransApproval_TransDateFrom.Size = new System.Drawing.Size(34, 15);
            this.lbl_TransApproval_TransDateFrom.TabIndex = 0;
            this.lbl_TransApproval_TransDateFrom.Text = "From";
            // 
            // dt_TransApproval_TransDateFrom
            // 
            this.dt_TransApproval_TransDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_TransApproval_TransDateFrom.Location = new System.Drawing.Point(60, 22);
            this.dt_TransApproval_TransDateFrom.Name = "dt_TransApproval_TransDateFrom";
            this.dt_TransApproval_TransDateFrom.Size = new System.Drawing.Size(96, 22);
            this.dt_TransApproval_TransDateFrom.TabIndex = 1;
            // 
            // dt_TransApproval_TransDateTo
            // 
            this.dt_TransApproval_TransDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_TransApproval_TransDateTo.Location = new System.Drawing.Point(60, 50);
            this.dt_TransApproval_TransDateTo.Name = "dt_TransApproval_TransDateTo";
            this.dt_TransApproval_TransDateTo.Size = new System.Drawing.Size(96, 22);
            this.dt_TransApproval_TransDateTo.TabIndex = 3;
            // 
            // lbl_TransApproval_TransDateTo
            // 
            this.lbl_TransApproval_TransDateTo.AutoSize = true;
            this.lbl_TransApproval_TransDateTo.Location = new System.Drawing.Point(7, 50);
            this.lbl_TransApproval_TransDateTo.Name = "lbl_TransApproval_TransDateTo";
            this.lbl_TransApproval_TransDateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_TransApproval_TransDateTo.TabIndex = 2;
            this.lbl_TransApproval_TransDateTo.Text = "To";
            // 
            // gb_TransApproval_FilterBy
            // 
            this.gb_TransApproval_FilterBy.Controls.Add(this.cb_TransApproval_Approved);
            this.gb_TransApproval_FilterBy.Controls.Add(this.cb_TransApproval_NotApproved);
            this.gb_TransApproval_FilterBy.Location = new System.Drawing.Point(184, 13);
            this.gb_TransApproval_FilterBy.Name = "gb_TransApproval_FilterBy";
            this.gb_TransApproval_FilterBy.Size = new System.Drawing.Size(165, 80);
            this.gb_TransApproval_FilterBy.TabIndex = 1;
            this.gb_TransApproval_FilterBy.TabStop = false;
            this.gb_TransApproval_FilterBy.Text = "Filter By";
            // 
            // cb_TransApproval_NotApproved
            // 
            this.cb_TransApproval_NotApproved.AutoSize = true;
            this.cb_TransApproval_NotApproved.Location = new System.Drawing.Point(16, 19);
            this.cb_TransApproval_NotApproved.Name = "cb_TransApproval_NotApproved";
            this.cb_TransApproval_NotApproved.Size = new System.Drawing.Size(103, 19);
            this.cb_TransApproval_NotApproved.TabIndex = 0;
            this.cb_TransApproval_NotApproved.Text = "Not Approved";
            this.cb_TransApproval_NotApproved.UseVisualStyleBackColor = true;
            // 
            // cb_TransApproval_Approved
            // 
            this.cb_TransApproval_Approved.AutoSize = true;
            this.cb_TransApproval_Approved.Location = new System.Drawing.Point(16, 44);
            this.cb_TransApproval_Approved.Name = "cb_TransApproval_Approved";
            this.cb_TransApproval_Approved.Size = new System.Drawing.Size(81, 19);
            this.cb_TransApproval_Approved.TabIndex = 1;
            this.cb_TransApproval_Approved.Text = "Approved";
            this.cb_TransApproval_Approved.UseVisualStyleBackColor = true;
            // 
            // gb_TransApproval_TransactionName
            // 
            this.gb_TransApproval_TransactionName.Controls.Add(this.cb_TransApproval_Receipts);
            this.gb_TransApproval_TransactionName.Controls.Add(this.cb_TransApproval_Payments);
            this.gb_TransApproval_TransactionName.Controls.Add(this.cb_TransApproval_DepositsOrWithdrawals);
            this.gb_TransApproval_TransactionName.Controls.Add(this.cb_TransApproval_WastageDisposal);
            this.gb_TransApproval_TransactionName.Controls.Add(this.cb_TransApproval_PurchaseReturn);
            this.gb_TransApproval_TransactionName.Controls.Add(this.cb_TransApproval_SalesReturn);
            this.gb_TransApproval_TransactionName.Controls.Add(this.cb_TransApproval_Purchase);
            this.gb_TransApproval_TransactionName.Controls.Add(this.cb_TransApproval_Sales);
            this.gb_TransApproval_TransactionName.Location = new System.Drawing.Point(355, 13);
            this.gb_TransApproval_TransactionName.Name = "gb_TransApproval_TransactionName";
            this.gb_TransApproval_TransactionName.Size = new System.Drawing.Size(465, 80);
            this.gb_TransApproval_TransactionName.TabIndex = 2;
            this.gb_TransApproval_TransactionName.TabStop = false;
            this.gb_TransApproval_TransactionName.Text = "Transaction Name";
            // 
            // cb_TransApproval_Purchase
            // 
            this.cb_TransApproval_Purchase.AutoSize = true;
            this.cb_TransApproval_Purchase.Location = new System.Drawing.Point(16, 44);
            this.cb_TransApproval_Purchase.Name = "cb_TransApproval_Purchase";
            this.cb_TransApproval_Purchase.Size = new System.Drawing.Size(75, 19);
            this.cb_TransApproval_Purchase.TabIndex = 1;
            this.cb_TransApproval_Purchase.Text = "Purchase";
            this.cb_TransApproval_Purchase.UseVisualStyleBackColor = true;
            // 
            // cb_TransApproval_Sales
            // 
            this.cb_TransApproval_Sales.AutoSize = true;
            this.cb_TransApproval_Sales.Location = new System.Drawing.Point(16, 19);
            this.cb_TransApproval_Sales.Name = "cb_TransApproval_Sales";
            this.cb_TransApproval_Sales.Size = new System.Drawing.Size(54, 19);
            this.cb_TransApproval_Sales.TabIndex = 0;
            this.cb_TransApproval_Sales.Text = "Sales";
            this.cb_TransApproval_Sales.UseVisualStyleBackColor = true;
            // 
            // cb_TransApproval_PurchaseReturn
            // 
            this.cb_TransApproval_PurchaseReturn.AutoSize = true;
            this.cb_TransApproval_PurchaseReturn.Location = new System.Drawing.Point(99, 43);
            this.cb_TransApproval_PurchaseReturn.Name = "cb_TransApproval_PurchaseReturn";
            this.cb_TransApproval_PurchaseReturn.Size = new System.Drawing.Size(114, 19);
            this.cb_TransApproval_PurchaseReturn.TabIndex = 3;
            this.cb_TransApproval_PurchaseReturn.Text = "Purchase Return";
            this.cb_TransApproval_PurchaseReturn.UseVisualStyleBackColor = true;
            // 
            // cb_TransApproval_SalesReturn
            // 
            this.cb_TransApproval_SalesReturn.AutoSize = true;
            this.cb_TransApproval_SalesReturn.Location = new System.Drawing.Point(99, 18);
            this.cb_TransApproval_SalesReturn.Name = "cb_TransApproval_SalesReturn";
            this.cb_TransApproval_SalesReturn.Size = new System.Drawing.Size(93, 19);
            this.cb_TransApproval_SalesReturn.TabIndex = 2;
            this.cb_TransApproval_SalesReturn.Text = "Sales Return";
            this.cb_TransApproval_SalesReturn.UseVisualStyleBackColor = true;
            // 
            // cb_TransApproval_DepositsOrWithdrawals
            // 
            this.cb_TransApproval_DepositsOrWithdrawals.AutoSize = true;
            this.cb_TransApproval_DepositsOrWithdrawals.Location = new System.Drawing.Point(223, 43);
            this.cb_TransApproval_DepositsOrWithdrawals.Name = "cb_TransApproval_DepositsOrWithdrawals";
            this.cb_TransApproval_DepositsOrWithdrawals.Size = new System.Drawing.Size(151, 19);
            this.cb_TransApproval_DepositsOrWithdrawals.TabIndex = 5;
            this.cb_TransApproval_DepositsOrWithdrawals.Text = "Deposits / Withdrawals";
            this.cb_TransApproval_DepositsOrWithdrawals.UseVisualStyleBackColor = true;
            // 
            // cb_TransApproval_WastageDisposal
            // 
            this.cb_TransApproval_WastageDisposal.AutoSize = true;
            this.cb_TransApproval_WastageDisposal.Location = new System.Drawing.Point(223, 18);
            this.cb_TransApproval_WastageDisposal.Name = "cb_TransApproval_WastageDisposal";
            this.cb_TransApproval_WastageDisposal.Size = new System.Drawing.Size(123, 19);
            this.cb_TransApproval_WastageDisposal.TabIndex = 4;
            this.cb_TransApproval_WastageDisposal.Text = "Wastage Disposal";
            this.cb_TransApproval_WastageDisposal.UseVisualStyleBackColor = true;
            // 
            // cb_TransApproval_Receipts
            // 
            this.cb_TransApproval_Receipts.AutoSize = true;
            this.cb_TransApproval_Receipts.Location = new System.Drawing.Point(383, 43);
            this.cb_TransApproval_Receipts.Name = "cb_TransApproval_Receipts";
            this.cb_TransApproval_Receipts.Size = new System.Drawing.Size(72, 19);
            this.cb_TransApproval_Receipts.TabIndex = 7;
            this.cb_TransApproval_Receipts.Text = "Receipts";
            this.cb_TransApproval_Receipts.UseVisualStyleBackColor = true;
            // 
            // cb_TransApproval_Payments
            // 
            this.cb_TransApproval_Payments.AutoSize = true;
            this.cb_TransApproval_Payments.Location = new System.Drawing.Point(383, 18);
            this.cb_TransApproval_Payments.Name = "cb_TransApproval_Payments";
            this.cb_TransApproval_Payments.Size = new System.Drawing.Size(78, 19);
            this.cb_TransApproval_Payments.TabIndex = 6;
            this.cb_TransApproval_Payments.Text = "Payments";
            this.cb_TransApproval_Payments.UseVisualStyleBackColor = true;
            // 
            // cob_TransApproval_CostCenter
            // 
            this.cob_TransApproval_CostCenter.FormattingEnabled = true;
            this.cob_TransApproval_CostCenter.Location = new System.Drawing.Point(826, 66);
            this.cob_TransApproval_CostCenter.Name = "cob_TransApproval_CostCenter";
            this.cob_TransApproval_CostCenter.Size = new System.Drawing.Size(128, 23);
            this.cob_TransApproval_CostCenter.TabIndex = 4;
            // 
            // cb_TransApproval_CostCenter
            // 
            this.cb_TransApproval_CostCenter.AutoSize = true;
            this.cb_TransApproval_CostCenter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TransApproval_CostCenter.Location = new System.Drawing.Point(826, 40);
            this.cb_TransApproval_CostCenter.Name = "cb_TransApproval_CostCenter";
            this.cb_TransApproval_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_TransApproval_CostCenter.TabIndex = 3;
            this.cb_TransApproval_CostCenter.Text = "Cost Center";
            this.cb_TransApproval_CostCenter.UseVisualStyleBackColor = true;
            // 
            // btn_TransApproval_Show
            // 
            this.btn_TransApproval_Show.Location = new System.Drawing.Point(960, 27);
            this.btn_TransApproval_Show.Name = "btn_TransApproval_Show";
            this.btn_TransApproval_Show.Size = new System.Drawing.Size(68, 62);
            this.btn_TransApproval_Show.TabIndex = 5;
            this.btn_TransApproval_Show.Text = "Show";
            this.btn_TransApproval_Show.UseVisualStyleBackColor = true;
            // 
            // btn_TransApproval_Print
            // 
            this.btn_TransApproval_Print.Location = new System.Drawing.Point(1034, 27);
            this.btn_TransApproval_Print.Name = "btn_TransApproval_Print";
            this.btn_TransApproval_Print.Size = new System.Drawing.Size(68, 62);
            this.btn_TransApproval_Print.TabIndex = 6;
            this.btn_TransApproval_Print.Text = "Print";
            this.btn_TransApproval_Print.UseVisualStyleBackColor = true;
            // 
            // GV_TransApproval_TransactionDetails
            // 
            this.GV_TransApproval_TransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_TransApproval_TransactionDetails.Location = new System.Drawing.Point(12, 99);
            this.GV_TransApproval_TransactionDetails.Name = "GV_TransApproval_TransactionDetails";
            this.GV_TransApproval_TransactionDetails.Size = new System.Drawing.Size(1090, 358);
            this.GV_TransApproval_TransactionDetails.TabIndex = 7;
            // 
            // btn_TransApproval_Update
            // 
            this.btn_TransApproval_Update.Location = new System.Drawing.Point(884, 463);
            this.btn_TransApproval_Update.Name = "btn_TransApproval_Update";
            this.btn_TransApproval_Update.Size = new System.Drawing.Size(106, 53);
            this.btn_TransApproval_Update.TabIndex = 8;
            this.btn_TransApproval_Update.Text = "Update";
            this.btn_TransApproval_Update.UseVisualStyleBackColor = true;
            // 
            // btn_TransApproval_Clear
            // 
            this.btn_TransApproval_Clear.Location = new System.Drawing.Point(996, 463);
            this.btn_TransApproval_Clear.Name = "btn_TransApproval_Clear";
            this.btn_TransApproval_Clear.Size = new System.Drawing.Size(106, 53);
            this.btn_TransApproval_Clear.TabIndex = 9;
            this.btn_TransApproval_Clear.Text = "Clear";
            this.btn_TransApproval_Clear.UseVisualStyleBackColor = true;
            // 
            // frm_Transactions_TransApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 519);
            this.Controls.Add(this.btn_TransApproval_Clear);
            this.Controls.Add(this.btn_TransApproval_Update);
            this.Controls.Add(this.GV_TransApproval_TransactionDetails);
            this.Controls.Add(this.btn_TransApproval_Print);
            this.Controls.Add(this.btn_TransApproval_Show);
            this.Controls.Add(this.cob_TransApproval_CostCenter);
            this.Controls.Add(this.cb_TransApproval_CostCenter);
            this.Controls.Add(this.gb_TransApproval_TransactionName);
            this.Controls.Add(this.gb_TransApproval_FilterBy);
            this.Controls.Add(this.gb_TransApproval_TransactionDate);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_TransApproval";
            this.Text = "frm_Transactions_TransApproval";
            this.gb_TransApproval_TransactionDate.ResumeLayout(false);
            this.gb_TransApproval_TransactionDate.PerformLayout();
            this.gb_TransApproval_FilterBy.ResumeLayout(false);
            this.gb_TransApproval_FilterBy.PerformLayout();
            this.gb_TransApproval_TransactionName.ResumeLayout(false);
            this.gb_TransApproval_TransactionName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_TransApproval_TransactionDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TransApproval_TransactionDate;
        private System.Windows.Forms.DateTimePicker dt_TransApproval_TransDateTo;
        private System.Windows.Forms.Label lbl_TransApproval_TransDateTo;
        private System.Windows.Forms.DateTimePicker dt_TransApproval_TransDateFrom;
        private System.Windows.Forms.Label lbl_TransApproval_TransDateFrom;
        private System.Windows.Forms.GroupBox gb_TransApproval_FilterBy;
        private System.Windows.Forms.CheckBox cb_TransApproval_Approved;
        private System.Windows.Forms.CheckBox cb_TransApproval_NotApproved;
        private System.Windows.Forms.GroupBox gb_TransApproval_TransactionName;
        private System.Windows.Forms.CheckBox cb_TransApproval_Receipts;
        private System.Windows.Forms.CheckBox cb_TransApproval_Payments;
        private System.Windows.Forms.CheckBox cb_TransApproval_DepositsOrWithdrawals;
        private System.Windows.Forms.CheckBox cb_TransApproval_WastageDisposal;
        private System.Windows.Forms.CheckBox cb_TransApproval_PurchaseReturn;
        private System.Windows.Forms.CheckBox cb_TransApproval_SalesReturn;
        private System.Windows.Forms.CheckBox cb_TransApproval_Purchase;
        private System.Windows.Forms.CheckBox cb_TransApproval_Sales;
        private System.Windows.Forms.ComboBox cob_TransApproval_CostCenter;
        private System.Windows.Forms.CheckBox cb_TransApproval_CostCenter;
        private System.Windows.Forms.Button btn_TransApproval_Show;
        private System.Windows.Forms.Button btn_TransApproval_Print;
        private System.Windows.Forms.DataGridView GV_TransApproval_TransactionDetails;
        private System.Windows.Forms.Button btn_TransApproval_Update;
        private System.Windows.Forms.Button btn_TransApproval_Clear;
    }
}