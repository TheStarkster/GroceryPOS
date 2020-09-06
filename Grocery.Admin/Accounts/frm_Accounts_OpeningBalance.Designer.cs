namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_OpeningBalance
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
            this.gb_OpeningBalance_Details = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_OpeningBalance_Supplier = new System.Windows.Forms.RadioButton();
            this.rb_OpeningBalance_Customer = new System.Windows.Forms.RadioButton();
            this.lbl_OpeningBalance_CustName = new System.Windows.Forms.Label();
            this.txt_OpeningBalance_CustName = new System.Windows.Forms.TextBox();
            this.lbl_OpeningBalance_CostCenter = new System.Windows.Forms.Label();
            this.cob_OpeningBalance_CostCenter = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GV_OpeningBalance_BalanceDetails = new System.Windows.Forms.DataGridView();
            this.cob_OpeningBalance_OpeningBalanceType = new System.Windows.Forms.ComboBox();
            this.lbl_OpeningBalance_OpeningBalanceType = new System.Windows.Forms.Label();
            this.lbl_OpeningBalance_OpeningBalanceDate = new System.Windows.Forms.Label();
            this.dt_OpeningBalance_OpeningBalanceDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_OpeningBalance_TotalAmt = new System.Windows.Forms.Label();
            this.txt_OpeningBalance_TotalAmt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_OpeningBalance_Set = new System.Windows.Forms.Button();
            this.btn_OpeningBalance_Cancel = new System.Windows.Forms.Button();
            this.gb_OpeningBalance_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_OpeningBalance_BalanceDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_OpeningBalance_Details
            // 
            this.gb_OpeningBalance_Details.Controls.Add(this.txt_OpeningBalance_TotalAmt);
            this.gb_OpeningBalance_Details.Controls.Add(this.lbl_OpeningBalance_TotalAmt);
            this.gb_OpeningBalance_Details.Controls.Add(this.dt_OpeningBalance_OpeningBalanceDate);
            this.gb_OpeningBalance_Details.Controls.Add(this.lbl_OpeningBalance_OpeningBalanceDate);
            this.gb_OpeningBalance_Details.Controls.Add(this.cob_OpeningBalance_OpeningBalanceType);
            this.gb_OpeningBalance_Details.Controls.Add(this.lbl_OpeningBalance_OpeningBalanceType);
            this.gb_OpeningBalance_Details.Controls.Add(this.GV_OpeningBalance_BalanceDetails);
            this.gb_OpeningBalance_Details.Controls.Add(this.textBox2);
            this.gb_OpeningBalance_Details.Controls.Add(this.cob_OpeningBalance_CostCenter);
            this.gb_OpeningBalance_Details.Controls.Add(this.lbl_OpeningBalance_CostCenter);
            this.gb_OpeningBalance_Details.Controls.Add(this.txt_OpeningBalance_CustName);
            this.gb_OpeningBalance_Details.Controls.Add(this.lbl_OpeningBalance_CustName);
            this.gb_OpeningBalance_Details.Controls.Add(this.panel1);
            this.gb_OpeningBalance_Details.Location = new System.Drawing.Point(15, 15);
            this.gb_OpeningBalance_Details.Name = "gb_OpeningBalance_Details";
            this.gb_OpeningBalance_Details.Size = new System.Drawing.Size(615, 338);
            this.gb_OpeningBalance_Details.TabIndex = 0;
            this.gb_OpeningBalance_Details.TabStop = false;
            this.gb_OpeningBalance_Details.Text = "Open Balance Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rb_OpeningBalance_Customer);
            this.panel1.Controls.Add(this.rb_OpeningBalance_Supplier);
            this.panel1.Location = new System.Drawing.Point(7, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 60);
            this.panel1.TabIndex = 0;
            // 
            // rb_OpeningBalance_Supplier
            // 
            this.rb_OpeningBalance_Supplier.AutoSize = true;
            this.rb_OpeningBalance_Supplier.Location = new System.Drawing.Point(4, 4);
            this.rb_OpeningBalance_Supplier.Name = "rb_OpeningBalance_Supplier";
            this.rb_OpeningBalance_Supplier.Size = new System.Drawing.Size(69, 19);
            this.rb_OpeningBalance_Supplier.TabIndex = 0;
            this.rb_OpeningBalance_Supplier.TabStop = true;
            this.rb_OpeningBalance_Supplier.Text = "Supplier";
            this.rb_OpeningBalance_Supplier.UseVisualStyleBackColor = true;
            // 
            // rb_OpeningBalance_Customer
            // 
            this.rb_OpeningBalance_Customer.AutoSize = true;
            this.rb_OpeningBalance_Customer.Location = new System.Drawing.Point(4, 29);
            this.rb_OpeningBalance_Customer.Name = "rb_OpeningBalance_Customer";
            this.rb_OpeningBalance_Customer.Size = new System.Drawing.Size(76, 19);
            this.rb_OpeningBalance_Customer.TabIndex = 1;
            this.rb_OpeningBalance_Customer.TabStop = true;
            this.rb_OpeningBalance_Customer.Text = "Customer";
            this.rb_OpeningBalance_Customer.UseVisualStyleBackColor = true;
            // 
            // lbl_OpeningBalance_CustName
            // 
            this.lbl_OpeningBalance_CustName.AutoSize = true;
            this.lbl_OpeningBalance_CustName.Location = new System.Drawing.Point(128, 29);
            this.lbl_OpeningBalance_CustName.Name = "lbl_OpeningBalance_CustName";
            this.lbl_OpeningBalance_CustName.Size = new System.Drawing.Size(91, 15);
            this.lbl_OpeningBalance_CustName.TabIndex = 1;
            this.lbl_OpeningBalance_CustName.Text = "Customer Name";
            // 
            // txt_OpeningBalance_CustName
            // 
            this.txt_OpeningBalance_CustName.Location = new System.Drawing.Point(131, 51);
            this.txt_OpeningBalance_CustName.Name = "txt_OpeningBalance_CustName";
            this.txt_OpeningBalance_CustName.Size = new System.Drawing.Size(350, 22);
            this.txt_OpeningBalance_CustName.TabIndex = 2;
            // 
            // lbl_OpeningBalance_CostCenter
            // 
            this.lbl_OpeningBalance_CostCenter.AutoSize = true;
            this.lbl_OpeningBalance_CostCenter.Location = new System.Drawing.Point(405, 26);
            this.lbl_OpeningBalance_CostCenter.Name = "lbl_OpeningBalance_CostCenter";
            this.lbl_OpeningBalance_CostCenter.Size = new System.Drawing.Size(70, 15);
            this.lbl_OpeningBalance_CostCenter.TabIndex = 3;
            this.lbl_OpeningBalance_CostCenter.Text = "Cost Center";
            // 
            // cob_OpeningBalance_CostCenter
            // 
            this.cob_OpeningBalance_CostCenter.FormattingEnabled = true;
            this.cob_OpeningBalance_CostCenter.Location = new System.Drawing.Point(481, 21);
            this.cob_OpeningBalance_CostCenter.Name = "cob_OpeningBalance_CostCenter";
            this.cob_OpeningBalance_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_OpeningBalance_CostCenter.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(487, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 22);
            this.textBox2.TabIndex = 5;
            // 
            // GV_OpeningBalance_BalanceDetails
            // 
            this.GV_OpeningBalance_BalanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_OpeningBalance_BalanceDetails.Location = new System.Drawing.Point(7, 89);
            this.GV_OpeningBalance_BalanceDetails.Name = "GV_OpeningBalance_BalanceDetails";
            this.GV_OpeningBalance_BalanceDetails.Size = new System.Drawing.Size(595, 150);
            this.GV_OpeningBalance_BalanceDetails.TabIndex = 6;
            // 
            // cob_OpeningBalance_OpeningBalanceType
            // 
            this.cob_OpeningBalance_OpeningBalanceType.FormattingEnabled = true;
            this.cob_OpeningBalance_OpeningBalanceType.Location = new System.Drawing.Point(481, 245);
            this.cob_OpeningBalance_OpeningBalanceType.Name = "cob_OpeningBalance_OpeningBalanceType";
            this.cob_OpeningBalance_OpeningBalanceType.Size = new System.Drawing.Size(121, 23);
            this.cob_OpeningBalance_OpeningBalanceType.TabIndex = 8;
            // 
            // lbl_OpeningBalance_OpeningBalanceType
            // 
            this.lbl_OpeningBalance_OpeningBalanceType.AutoSize = true;
            this.lbl_OpeningBalance_OpeningBalanceType.Location = new System.Drawing.Point(347, 248);
            this.lbl_OpeningBalance_OpeningBalanceType.Name = "lbl_OpeningBalance_OpeningBalanceType";
            this.lbl_OpeningBalance_OpeningBalanceType.Size = new System.Drawing.Size(128, 15);
            this.lbl_OpeningBalance_OpeningBalanceType.TabIndex = 7;
            this.lbl_OpeningBalance_OpeningBalanceType.Text = "Opening Balance Type";
            // 
            // lbl_OpeningBalance_OpeningBalanceDate
            // 
            this.lbl_OpeningBalance_OpeningBalanceDate.AutoSize = true;
            this.lbl_OpeningBalance_OpeningBalanceDate.Location = new System.Drawing.Point(347, 278);
            this.lbl_OpeningBalance_OpeningBalanceDate.Name = "lbl_OpeningBalance_OpeningBalanceDate";
            this.lbl_OpeningBalance_OpeningBalanceDate.Size = new System.Drawing.Size(126, 15);
            this.lbl_OpeningBalance_OpeningBalanceDate.TabIndex = 9;
            this.lbl_OpeningBalance_OpeningBalanceDate.Text = "Opening Balance Date";
            // 
            // dt_OpeningBalance_OpeningBalanceDate
            // 
            this.dt_OpeningBalance_OpeningBalanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_OpeningBalance_OpeningBalanceDate.Location = new System.Drawing.Point(481, 275);
            this.dt_OpeningBalance_OpeningBalanceDate.Name = "dt_OpeningBalance_OpeningBalanceDate";
            this.dt_OpeningBalance_OpeningBalanceDate.Size = new System.Drawing.Size(121, 22);
            this.dt_OpeningBalance_OpeningBalanceDate.TabIndex = 10;
            // 
            // lbl_OpeningBalance_TotalAmt
            // 
            this.lbl_OpeningBalance_TotalAmt.AutoSize = true;
            this.lbl_OpeningBalance_TotalAmt.Location = new System.Drawing.Point(347, 307);
            this.lbl_OpeningBalance_TotalAmt.Name = "lbl_OpeningBalance_TotalAmt";
            this.lbl_OpeningBalance_TotalAmt.Size = new System.Drawing.Size(80, 15);
            this.lbl_OpeningBalance_TotalAmt.TabIndex = 11;
            this.lbl_OpeningBalance_TotalAmt.Text = "Total Amount";
            // 
            // txt_OpeningBalance_TotalAmt
            // 
            this.txt_OpeningBalance_TotalAmt.Location = new System.Drawing.Point(481, 304);
            this.txt_OpeningBalance_TotalAmt.Name = "txt_OpeningBalance_TotalAmt";
            this.txt_OpeningBalance_TotalAmt.Size = new System.Drawing.Size(121, 22);
            this.txt_OpeningBalance_TotalAmt.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_OpeningBalance_Cancel);
            this.panel2.Controls.Add(this.btn_OpeningBalance_Set);
            this.panel2.Location = new System.Drawing.Point(15, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 45);
            this.panel2.TabIndex = 1;
            // 
            // btn_OpeningBalance_Set
            // 
            this.btn_OpeningBalance_Set.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpeningBalance_Set.Location = new System.Drawing.Point(433, 3);
            this.btn_OpeningBalance_Set.Name = "btn_OpeningBalance_Set";
            this.btn_OpeningBalance_Set.Size = new System.Drawing.Size(86, 36);
            this.btn_OpeningBalance_Set.TabIndex = 0;
            this.btn_OpeningBalance_Set.Text = "Set";
            this.btn_OpeningBalance_Set.UseVisualStyleBackColor = true;
            // 
            // btn_OpeningBalance_Cancel
            // 
            this.btn_OpeningBalance_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpeningBalance_Cancel.Location = new System.Drawing.Point(525, 3);
            this.btn_OpeningBalance_Cancel.Name = "btn_OpeningBalance_Cancel";
            this.btn_OpeningBalance_Cancel.Size = new System.Drawing.Size(86, 36);
            this.btn_OpeningBalance_Cancel.TabIndex = 1;
            this.btn_OpeningBalance_Cancel.Text = "Cancel";
            this.btn_OpeningBalance_Cancel.UseVisualStyleBackColor = true;
            // 
            // frm_Accounts_OpeningBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_OpeningBalance_Details);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Accounts_OpeningBalance";
            this.Text = "frm_Accounts_OpeningBalance";
            this.gb_OpeningBalance_Details.ResumeLayout(false);
            this.gb_OpeningBalance_Details.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_OpeningBalance_BalanceDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_OpeningBalance_Details;
        private System.Windows.Forms.TextBox txt_OpeningBalance_TotalAmt;
        private System.Windows.Forms.Label lbl_OpeningBalance_TotalAmt;
        private System.Windows.Forms.DateTimePicker dt_OpeningBalance_OpeningBalanceDate;
        private System.Windows.Forms.Label lbl_OpeningBalance_OpeningBalanceDate;
        private System.Windows.Forms.ComboBox cob_OpeningBalance_OpeningBalanceType;
        private System.Windows.Forms.Label lbl_OpeningBalance_OpeningBalanceType;
        private System.Windows.Forms.DataGridView GV_OpeningBalance_BalanceDetails;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cob_OpeningBalance_CostCenter;
        private System.Windows.Forms.Label lbl_OpeningBalance_CostCenter;
        private System.Windows.Forms.TextBox txt_OpeningBalance_CustName;
        private System.Windows.Forms.Label lbl_OpeningBalance_CustName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_OpeningBalance_Customer;
        private System.Windows.Forms.RadioButton rb_OpeningBalance_Supplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_OpeningBalance_Cancel;
        private System.Windows.Forms.Button btn_OpeningBalance_Set;
    }
}