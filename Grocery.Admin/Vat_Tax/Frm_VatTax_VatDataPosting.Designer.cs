namespace Grocery.Admin.Vat_Tax
{
    partial class Frm_VatTax_VatDataPosting
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
            this.dt_VatDataPosting_DateTo = new System.Windows.Forms.DateTimePicker();
            this.dt_VatDataPosting_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_VatDataPosting_To = new System.Windows.Forms.Label();
            this.lbl_VatDataPosting_From = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_VatDataPosting_Sales = new System.Windows.Forms.CheckBox();
            this.cb_VatDataPosting_SalesReturn = new System.Windows.Forms.CheckBox();
            this.cb_VatDataPosting_Purchase = new System.Windows.Forms.CheckBox();
            this.cb_VatDataPosting_PurchaseReturn = new System.Windows.Forms.CheckBox();
            this.cob_VatDataPosting_CostCenter = new System.Windows.Forms.ComboBox();
            this.cb_VatDataPosting_CostCenter = new System.Windows.Forms.CheckBox();
            this.btn_VatDataPosting_Process = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_VatDataPosting_DateTo
            // 
            this.dt_VatDataPosting_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VatDataPosting_DateTo.Location = new System.Drawing.Point(86, 41);
            this.dt_VatDataPosting_DateTo.Name = "dt_VatDataPosting_DateTo";
            this.dt_VatDataPosting_DateTo.Size = new System.Drawing.Size(101, 22);
            this.dt_VatDataPosting_DateTo.TabIndex = 13;
            // 
            // dt_VatDataPosting_DateFrom
            // 
            this.dt_VatDataPosting_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VatDataPosting_DateFrom.Location = new System.Drawing.Point(86, 13);
            this.dt_VatDataPosting_DateFrom.Name = "dt_VatDataPosting_DateFrom";
            this.dt_VatDataPosting_DateFrom.Size = new System.Drawing.Size(101, 22);
            this.dt_VatDataPosting_DateFrom.TabIndex = 12;
            // 
            // lbl_VatDataPosting_To
            // 
            this.lbl_VatDataPosting_To.AutoSize = true;
            this.lbl_VatDataPosting_To.Location = new System.Drawing.Point(18, 47);
            this.lbl_VatDataPosting_To.Name = "lbl_VatDataPosting_To";
            this.lbl_VatDataPosting_To.Size = new System.Drawing.Size(21, 15);
            this.lbl_VatDataPosting_To.TabIndex = 11;
            this.lbl_VatDataPosting_To.Text = "To";
            // 
            // lbl_VatDataPosting_From
            // 
            this.lbl_VatDataPosting_From.AutoSize = true;
            this.lbl_VatDataPosting_From.Location = new System.Drawing.Point(18, 19);
            this.lbl_VatDataPosting_From.Name = "lbl_VatDataPosting_From";
            this.lbl_VatDataPosting_From.Size = new System.Drawing.Size(34, 15);
            this.lbl_VatDataPosting_From.TabIndex = 10;
            this.lbl_VatDataPosting_From.Text = "From";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_VatDataPosting_Process);
            this.panel1.Controls.Add(this.cob_VatDataPosting_CostCenter);
            this.panel1.Controls.Add(this.cb_VatDataPosting_CostCenter);
            this.panel1.Controls.Add(this.cb_VatDataPosting_PurchaseReturn);
            this.panel1.Controls.Add(this.cb_VatDataPosting_Purchase);
            this.panel1.Controls.Add(this.cb_VatDataPosting_SalesReturn);
            this.panel1.Controls.Add(this.cb_VatDataPosting_Sales);
            this.panel1.Controls.Add(this.lbl_VatDataPosting_From);
            this.panel1.Controls.Add(this.dt_VatDataPosting_DateTo);
            this.panel1.Controls.Add(this.dt_VatDataPosting_DateFrom);
            this.panel1.Controls.Add(this.lbl_VatDataPosting_To);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 177);
            this.panel1.TabIndex = 14;
            // 
            // cb_VatDataPosting_Sales
            // 
            this.cb_VatDataPosting_Sales.AutoSize = true;
            this.cb_VatDataPosting_Sales.Location = new System.Drawing.Point(210, 16);
            this.cb_VatDataPosting_Sales.Name = "cb_VatDataPosting_Sales";
            this.cb_VatDataPosting_Sales.Size = new System.Drawing.Size(54, 19);
            this.cb_VatDataPosting_Sales.TabIndex = 14;
            this.cb_VatDataPosting_Sales.Text = "Sales";
            this.cb_VatDataPosting_Sales.UseVisualStyleBackColor = true;
            // 
            // cb_VatDataPosting_SalesReturn
            // 
            this.cb_VatDataPosting_SalesReturn.AutoSize = true;
            this.cb_VatDataPosting_SalesReturn.Location = new System.Drawing.Point(297, 13);
            this.cb_VatDataPosting_SalesReturn.Name = "cb_VatDataPosting_SalesReturn";
            this.cb_VatDataPosting_SalesReturn.Size = new System.Drawing.Size(93, 19);
            this.cb_VatDataPosting_SalesReturn.TabIndex = 15;
            this.cb_VatDataPosting_SalesReturn.Text = "Sales Return";
            this.cb_VatDataPosting_SalesReturn.UseVisualStyleBackColor = true;
            // 
            // cb_VatDataPosting_Purchase
            // 
            this.cb_VatDataPosting_Purchase.AutoSize = true;
            this.cb_VatDataPosting_Purchase.Location = new System.Drawing.Point(210, 41);
            this.cb_VatDataPosting_Purchase.Name = "cb_VatDataPosting_Purchase";
            this.cb_VatDataPosting_Purchase.Size = new System.Drawing.Size(75, 19);
            this.cb_VatDataPosting_Purchase.TabIndex = 16;
            this.cb_VatDataPosting_Purchase.Text = "Purchase";
            this.cb_VatDataPosting_Purchase.UseVisualStyleBackColor = true;
            // 
            // cb_VatDataPosting_PurchaseReturn
            // 
            this.cb_VatDataPosting_PurchaseReturn.AutoSize = true;
            this.cb_VatDataPosting_PurchaseReturn.Location = new System.Drawing.Point(297, 41);
            this.cb_VatDataPosting_PurchaseReturn.Name = "cb_VatDataPosting_PurchaseReturn";
            this.cb_VatDataPosting_PurchaseReturn.Size = new System.Drawing.Size(114, 19);
            this.cb_VatDataPosting_PurchaseReturn.TabIndex = 17;
            this.cb_VatDataPosting_PurchaseReturn.Text = "Purchase Return";
            this.cb_VatDataPosting_PurchaseReturn.UseVisualStyleBackColor = true;
            // 
            // cob_VatDataPosting_CostCenter
            // 
            this.cob_VatDataPosting_CostCenter.FormattingEnabled = true;
            this.cob_VatDataPosting_CostCenter.Location = new System.Drawing.Point(291, 71);
            this.cob_VatDataPosting_CostCenter.Name = "cob_VatDataPosting_CostCenter";
            this.cob_VatDataPosting_CostCenter.Size = new System.Drawing.Size(120, 23);
            this.cob_VatDataPosting_CostCenter.TabIndex = 19;
            // 
            // cb_VatDataPosting_CostCenter
            // 
            this.cb_VatDataPosting_CostCenter.AutoSize = true;
            this.cb_VatDataPosting_CostCenter.Location = new System.Drawing.Point(196, 75);
            this.cb_VatDataPosting_CostCenter.Name = "cb_VatDataPosting_CostCenter";
            this.cb_VatDataPosting_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_VatDataPosting_CostCenter.TabIndex = 18;
            this.cb_VatDataPosting_CostCenter.Text = "Cost Center";
            this.cb_VatDataPosting_CostCenter.UseVisualStyleBackColor = true;
            // 
            // btn_VatDataPosting_Process
            // 
            this.btn_VatDataPosting_Process.Location = new System.Drawing.Point(435, 25);
            this.btn_VatDataPosting_Process.Name = "btn_VatDataPosting_Process";
            this.btn_VatDataPosting_Process.Size = new System.Drawing.Size(96, 44);
            this.btn_VatDataPosting_Process.TabIndex = 20;
            this.btn_VatDataPosting_Process.Text = "Proceed";
            this.btn_VatDataPosting_Process.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 22);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(510, 22);
            this.textBox2.TabIndex = 22;
            // 
            // Frm_VatTax_VatDataPosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 198);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_VatTax_VatDataPosting";
            this.Text = "Frm_VatTax_VatDataPosting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_VatDataPosting_DateTo;
        private System.Windows.Forms.DateTimePicker dt_VatDataPosting_DateFrom;
        private System.Windows.Forms.Label lbl_VatDataPosting_To;
        private System.Windows.Forms.Label lbl_VatDataPosting_From;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_VatDataPosting_PurchaseReturn;
        private System.Windows.Forms.CheckBox cb_VatDataPosting_Purchase;
        private System.Windows.Forms.CheckBox cb_VatDataPosting_SalesReturn;
        private System.Windows.Forms.CheckBox cb_VatDataPosting_Sales;
        private System.Windows.Forms.ComboBox cob_VatDataPosting_CostCenter;
        private System.Windows.Forms.CheckBox cb_VatDataPosting_CostCenter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_VatDataPosting_Process;
    }
}