namespace Grocery.Admin.Vat_Tax
{
    partial class Frm_VatTax_VatLocking
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
            this.cb_VatLocking_AddNew = new System.Windows.Forms.CheckBox();
            this.lbl_VatLocking_TransactionDateFrom = new System.Windows.Forms.Label();
            this.dt_VatLocking_TransactionDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dt_VatLocking_TransactionDateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_VatLocking_VatLockingDateTo = new System.Windows.Forms.Label();
            this.dt_VatLocking_SubmissionDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_VatLocking_SubmissionDate = new System.Windows.Forms.Label();
            this.lbl_VatLocking_SubmissionStatus = new System.Windows.Forms.Label();
            this.cob_VatLocking_SubmissionStatus = new System.Windows.Forms.ComboBox();
            this.btn_VatLocking_Update = new System.Windows.Forms.Button();
            this.btn_VatLocking_Delete = new System.Windows.Forms.Button();
            this.btn_VatLocking_Cancel = new System.Windows.Forms.Button();
            this.GV_VatLocking_VatLockingDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatLocking_VatLockingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GV_VatLocking_VatLockingDetails);
            this.panel1.Controls.Add(this.btn_VatLocking_Cancel);
            this.panel1.Controls.Add(this.btn_VatLocking_Delete);
            this.panel1.Controls.Add(this.btn_VatLocking_Update);
            this.panel1.Controls.Add(this.cob_VatLocking_SubmissionStatus);
            this.panel1.Controls.Add(this.lbl_VatLocking_SubmissionStatus);
            this.panel1.Controls.Add(this.dt_VatLocking_SubmissionDate);
            this.panel1.Controls.Add(this.lbl_VatLocking_SubmissionDate);
            this.panel1.Controls.Add(this.dt_VatLocking_TransactionDateTo);
            this.panel1.Controls.Add(this.lbl_VatLocking_VatLockingDateTo);
            this.panel1.Controls.Add(this.dt_VatLocking_TransactionDateFrom);
            this.panel1.Controls.Add(this.lbl_VatLocking_TransactionDateFrom);
            this.panel1.Controls.Add(this.cb_VatLocking_AddNew);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 376);
            this.panel1.TabIndex = 0;
            // 
            // cb_VatLocking_AddNew
            // 
            this.cb_VatLocking_AddNew.AutoSize = true;
            this.cb_VatLocking_AddNew.Location = new System.Drawing.Point(18, 12);
            this.cb_VatLocking_AddNew.Name = "cb_VatLocking_AddNew";
            this.cb_VatLocking_AddNew.Size = new System.Drawing.Size(77, 19);
            this.cb_VatLocking_AddNew.TabIndex = 0;
            this.cb_VatLocking_AddNew.Text = "Add New";
            this.cb_VatLocking_AddNew.UseVisualStyleBackColor = true;
            // 
            // lbl_VatLocking_TransactionDateFrom
            // 
            this.lbl_VatLocking_TransactionDateFrom.AutoSize = true;
            this.lbl_VatLocking_TransactionDateFrom.Location = new System.Drawing.Point(15, 46);
            this.lbl_VatLocking_TransactionDateFrom.Name = "lbl_VatLocking_TransactionDateFrom";
            this.lbl_VatLocking_TransactionDateFrom.Size = new System.Drawing.Size(99, 15);
            this.lbl_VatLocking_TransactionDateFrom.TabIndex = 1;
            this.lbl_VatLocking_TransactionDateFrom.Text = "Transaction Date";
            // 
            // dt_VatLocking_TransactionDateFrom
            // 
            this.dt_VatLocking_TransactionDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VatLocking_TransactionDateFrom.Location = new System.Drawing.Point(128, 46);
            this.dt_VatLocking_TransactionDateFrom.Name = "dt_VatLocking_TransactionDateFrom";
            this.dt_VatLocking_TransactionDateFrom.Size = new System.Drawing.Size(121, 22);
            this.dt_VatLocking_TransactionDateFrom.TabIndex = 2;
            // 
            // dt_VatLocking_TransactionDateTo
            // 
            this.dt_VatLocking_TransactionDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VatLocking_TransactionDateTo.Location = new System.Drawing.Point(128, 74);
            this.dt_VatLocking_TransactionDateTo.Name = "dt_VatLocking_TransactionDateTo";
            this.dt_VatLocking_TransactionDateTo.Size = new System.Drawing.Size(121, 22);
            this.dt_VatLocking_TransactionDateTo.TabIndex = 4;
            // 
            // lbl_VatLocking_VatLockingDateTo
            // 
            this.lbl_VatLocking_VatLockingDateTo.AutoSize = true;
            this.lbl_VatLocking_VatLockingDateTo.Location = new System.Drawing.Point(91, 74);
            this.lbl_VatLocking_VatLockingDateTo.Name = "lbl_VatLocking_VatLockingDateTo";
            this.lbl_VatLocking_VatLockingDateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_VatLocking_VatLockingDateTo.TabIndex = 3;
            this.lbl_VatLocking_VatLockingDateTo.Text = "To";
            // 
            // dt_VatLocking_SubmissionDate
            // 
            this.dt_VatLocking_SubmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VatLocking_SubmissionDate.Location = new System.Drawing.Point(128, 102);
            this.dt_VatLocking_SubmissionDate.Name = "dt_VatLocking_SubmissionDate";
            this.dt_VatLocking_SubmissionDate.Size = new System.Drawing.Size(121, 22);
            this.dt_VatLocking_SubmissionDate.TabIndex = 6;
            // 
            // lbl_VatLocking_SubmissionDate
            // 
            this.lbl_VatLocking_SubmissionDate.AutoSize = true;
            this.lbl_VatLocking_SubmissionDate.Location = new System.Drawing.Point(17, 108);
            this.lbl_VatLocking_SubmissionDate.Name = "lbl_VatLocking_SubmissionDate";
            this.lbl_VatLocking_SubmissionDate.Size = new System.Drawing.Size(97, 15);
            this.lbl_VatLocking_SubmissionDate.TabIndex = 5;
            this.lbl_VatLocking_SubmissionDate.Text = "Submission Date";
            // 
            // lbl_VatLocking_SubmissionStatus
            // 
            this.lbl_VatLocking_SubmissionStatus.AutoSize = true;
            this.lbl_VatLocking_SubmissionStatus.Location = new System.Drawing.Point(17, 134);
            this.lbl_VatLocking_SubmissionStatus.Name = "lbl_VatLocking_SubmissionStatus";
            this.lbl_VatLocking_SubmissionStatus.Size = new System.Drawing.Size(106, 15);
            this.lbl_VatLocking_SubmissionStatus.TabIndex = 7;
            this.lbl_VatLocking_SubmissionStatus.Text = "Submission Status";
            // 
            // cob_VatLocking_SubmissionStatus
            // 
            this.cob_VatLocking_SubmissionStatus.FormattingEnabled = true;
            this.cob_VatLocking_SubmissionStatus.Location = new System.Drawing.Point(128, 131);
            this.cob_VatLocking_SubmissionStatus.Name = "cob_VatLocking_SubmissionStatus";
            this.cob_VatLocking_SubmissionStatus.Size = new System.Drawing.Size(121, 23);
            this.cob_VatLocking_SubmissionStatus.TabIndex = 8;
            // 
            // btn_VatLocking_Update
            // 
            this.btn_VatLocking_Update.Location = new System.Drawing.Point(18, 160);
            this.btn_VatLocking_Update.Name = "btn_VatLocking_Update";
            this.btn_VatLocking_Update.Size = new System.Drawing.Size(75, 39);
            this.btn_VatLocking_Update.TabIndex = 9;
            this.btn_VatLocking_Update.Text = "&Update";
            this.btn_VatLocking_Update.UseVisualStyleBackColor = true;
            // 
            // btn_VatLocking_Delete
            // 
            this.btn_VatLocking_Delete.Location = new System.Drawing.Point(99, 160);
            this.btn_VatLocking_Delete.Name = "btn_VatLocking_Delete";
            this.btn_VatLocking_Delete.Size = new System.Drawing.Size(75, 39);
            this.btn_VatLocking_Delete.TabIndex = 10;
            this.btn_VatLocking_Delete.Text = "&Delete";
            this.btn_VatLocking_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_VatLocking_Cancel
            // 
            this.btn_VatLocking_Cancel.Location = new System.Drawing.Point(180, 160);
            this.btn_VatLocking_Cancel.Name = "btn_VatLocking_Cancel";
            this.btn_VatLocking_Cancel.Size = new System.Drawing.Size(75, 39);
            this.btn_VatLocking_Cancel.TabIndex = 11;
            this.btn_VatLocking_Cancel.Text = "&Cancel";
            this.btn_VatLocking_Cancel.UseVisualStyleBackColor = true;
            // 
            // GV_VatLocking_VatLockingDetails
            // 
            this.GV_VatLocking_VatLockingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_VatLocking_VatLockingDetails.Location = new System.Drawing.Point(261, 12);
            this.GV_VatLocking_VatLockingDetails.Name = "GV_VatLocking_VatLockingDetails";
            this.GV_VatLocking_VatLockingDetails.Size = new System.Drawing.Size(392, 345);
            this.GV_VatLocking_VatLockingDetails.TabIndex = 12;
            // 
            // VatLocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 400);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VatLocking";
            this.Text = "VatLocking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VatLocking_VatLockingDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GV_VatLocking_VatLockingDetails;
        private System.Windows.Forms.Button btn_VatLocking_Cancel;
        private System.Windows.Forms.Button btn_VatLocking_Delete;
        private System.Windows.Forms.Button btn_VatLocking_Update;
        private System.Windows.Forms.ComboBox cob_VatLocking_SubmissionStatus;
        private System.Windows.Forms.Label lbl_VatLocking_SubmissionStatus;
        private System.Windows.Forms.DateTimePicker dt_VatLocking_SubmissionDate;
        private System.Windows.Forms.Label lbl_VatLocking_SubmissionDate;
        private System.Windows.Forms.DateTimePicker dt_VatLocking_TransactionDateTo;
        private System.Windows.Forms.Label lbl_VatLocking_VatLockingDateTo;
        private System.Windows.Forms.DateTimePicker dt_VatLocking_TransactionDateFrom;
        private System.Windows.Forms.Label lbl_VatLocking_TransactionDateFrom;
        private System.Windows.Forms.CheckBox cb_VatLocking_AddNew;
    }
}