namespace Grocery.Admin.Master
{
    partial class Frm_Master_PartyGrouping
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Master_PartyGrouping_Cancel = new System.Windows.Forms.Button();
            this.btn_Master_PartyGrouping_Delete = new System.Windows.Forms.Button();
            this.btn_Master_PartyGrouping_Update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_Master_PartyGrouping_Customers = new System.Windows.Forms.RadioButton();
            this.rbtn_Master_PartyGrouping_Supplier = new System.Windows.Forms.RadioButton();
            this.txt_Master_PartyGrouping_NoOfDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Master_PartyGrouping_GroupId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Master_PartyGrouping_GroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Master_PartyGrouping_PaymentTerms = new System.Windows.Forms.TextBox();
            this.txt_Master_PartyGrouping_CreditLimits = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerName,
            this.CustomerAddress});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 132);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(11, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 135);
            this.panel4.TabIndex = 10;
            // 
            // btn_Master_PartyGrouping_Cancel
            // 
            this.btn_Master_PartyGrouping_Cancel.Location = new System.Drawing.Point(652, 222);
            this.btn_Master_PartyGrouping_Cancel.Name = "btn_Master_PartyGrouping_Cancel";
            this.btn_Master_PartyGrouping_Cancel.Size = new System.Drawing.Size(73, 23);
            this.btn_Master_PartyGrouping_Cancel.TabIndex = 3;
            this.btn_Master_PartyGrouping_Cancel.Text = "Cancel";
            this.btn_Master_PartyGrouping_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Master_PartyGrouping_Delete
            // 
            this.btn_Master_PartyGrouping_Delete.Location = new System.Drawing.Point(652, 193);
            this.btn_Master_PartyGrouping_Delete.Name = "btn_Master_PartyGrouping_Delete";
            this.btn_Master_PartyGrouping_Delete.Size = new System.Drawing.Size(73, 23);
            this.btn_Master_PartyGrouping_Delete.TabIndex = 2;
            this.btn_Master_PartyGrouping_Delete.Text = "Delete";
            this.btn_Master_PartyGrouping_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Master_PartyGrouping_Update
            // 
            this.btn_Master_PartyGrouping_Update.Location = new System.Drawing.Point(652, 164);
            this.btn_Master_PartyGrouping_Update.Name = "btn_Master_PartyGrouping_Update";
            this.btn_Master_PartyGrouping_Update.Size = new System.Drawing.Size(73, 23);
            this.btn_Master_PartyGrouping_Update.TabIndex = 0;
            this.btn_Master_PartyGrouping_Update.Text = "Update";
            this.btn_Master_PartyGrouping_Update.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_Master_PartyGrouping_Supplier);
            this.panel1.Controls.Add(this.rbtn_Master_PartyGrouping_Customers);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 40);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbtn_Master_PartyGrouping_Customers
            // 
            this.rbtn_Master_PartyGrouping_Customers.AutoSize = true;
            this.rbtn_Master_PartyGrouping_Customers.Location = new System.Drawing.Point(11, 12);
            this.rbtn_Master_PartyGrouping_Customers.Name = "rbtn_Master_PartyGrouping_Customers";
            this.rbtn_Master_PartyGrouping_Customers.Size = new System.Drawing.Size(74, 17);
            this.rbtn_Master_PartyGrouping_Customers.TabIndex = 0;
            this.rbtn_Master_PartyGrouping_Customers.Text = "Customers";
            this.rbtn_Master_PartyGrouping_Customers.UseVisualStyleBackColor = true;
            // 
            // rbtn_Master_PartyGrouping_Supplier
            // 
            this.rbtn_Master_PartyGrouping_Supplier.AutoSize = true;
            this.rbtn_Master_PartyGrouping_Supplier.Checked = true;
            this.rbtn_Master_PartyGrouping_Supplier.Location = new System.Drawing.Point(128, 12);
            this.rbtn_Master_PartyGrouping_Supplier.Name = "rbtn_Master_PartyGrouping_Supplier";
            this.rbtn_Master_PartyGrouping_Supplier.Size = new System.Drawing.Size(63, 17);
            this.rbtn_Master_PartyGrouping_Supplier.TabIndex = 1;
            this.rbtn_Master_PartyGrouping_Supplier.TabStop = true;
            this.rbtn_Master_PartyGrouping_Supplier.Text = "Supplier";
            this.rbtn_Master_PartyGrouping_Supplier.UseVisualStyleBackColor = true;
            // 
            // txt_Master_PartyGrouping_NoOfDays
            // 
            this.txt_Master_PartyGrouping_NoOfDays.Location = new System.Drawing.Point(105, 110);
            this.txt_Master_PartyGrouping_NoOfDays.Name = "txt_Master_PartyGrouping_NoOfDays";
            this.txt_Master_PartyGrouping_NoOfDays.Size = new System.Drawing.Size(100, 20);
            this.txt_Master_PartyGrouping_NoOfDays.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Credit Limits";
            // 
            // txt_Master_PartyGrouping_GroupId
            // 
            this.txt_Master_PartyGrouping_GroupId.Location = new System.Drawing.Point(105, 58);
            this.txt_Master_PartyGrouping_GroupId.Name = "txt_Master_PartyGrouping_GroupId";
            this.txt_Master_PartyGrouping_GroupId.Size = new System.Drawing.Size(275, 20);
            this.txt_Master_PartyGrouping_GroupId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Group ID";
            // 
            // txt_Master_PartyGrouping_GroupName
            // 
            this.txt_Master_PartyGrouping_GroupName.Location = new System.Drawing.Point(105, 84);
            this.txt_Master_PartyGrouping_GroupName.Name = "txt_Master_PartyGrouping_GroupName";
            this.txt_Master_PartyGrouping_GroupName.Size = new System.Drawing.Size(275, 20);
            this.txt_Master_PartyGrouping_GroupName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Group Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Payment Terms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "No Of Days";
            // 
            // txt_Master_PartyGrouping_PaymentTerms
            // 
            this.txt_Master_PartyGrouping_PaymentTerms.Location = new System.Drawing.Point(105, 135);
            this.txt_Master_PartyGrouping_PaymentTerms.Name = "txt_Master_PartyGrouping_PaymentTerms";
            this.txt_Master_PartyGrouping_PaymentTerms.Size = new System.Drawing.Size(275, 20);
            this.txt_Master_PartyGrouping_PaymentTerms.TabIndex = 15;
            // 
            // txt_Master_PartyGrouping_CreditLimits
            // 
            this.txt_Master_PartyGrouping_CreditLimits.Location = new System.Drawing.Point(280, 109);
            this.txt_Master_PartyGrouping_CreditLimits.Name = "txt_Master_PartyGrouping_CreditLimits";
            this.txt_Master_PartyGrouping_CreditLimits.Size = new System.Drawing.Size(100, 20);
            this.txt_Master_PartyGrouping_CreditLimits.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Location = new System.Drawing.Point(436, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 144);
            this.panel5.TabIndex = 17;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.GroupName});
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(351, 144);
            this.dataGridView2.TabIndex = 0;
            // 
            // GroupId
            // 
            this.GroupId.HeaderText = "Group ID";
            this.GroupId.Name = "GroupId";
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Group Name";
            this.GroupName.Name = "GroupName";
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Customer ID";
            this.CustomerId.Name = "CustomerId";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.HeaderText = "Customer Address";
            this.CustomerAddress.Name = "CustomerAddress";
            // 
            // Frm_Master_PartyGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 301);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_Master_PartyGrouping_Cancel);
            this.Controls.Add(this.txt_Master_PartyGrouping_CreditLimits);
            this.Controls.Add(this.btn_Master_PartyGrouping_Delete);
            this.Controls.Add(this.btn_Master_PartyGrouping_Update);
            this.Controls.Add(this.txt_Master_PartyGrouping_PaymentTerms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Master_PartyGrouping_NoOfDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Master_PartyGrouping_GroupId);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_Master_PartyGrouping_GroupName);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Master_PartyGrouping";
            this.Text = "Frm_Master_PartyGrouping";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Master_PartyGrouping_Cancel;
        private System.Windows.Forms.Button btn_Master_PartyGrouping_Delete;
        private System.Windows.Forms.Button btn_Master_PartyGrouping_Update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.RadioButton rbtn_Master_PartyGrouping_Supplier;
        private System.Windows.Forms.RadioButton rbtn_Master_PartyGrouping_Customers;
        private System.Windows.Forms.TextBox txt_Master_PartyGrouping_NoOfDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Master_PartyGrouping_GroupId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Master_PartyGrouping_GroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Master_PartyGrouping_PaymentTerms;
        private System.Windows.Forms.TextBox txt_Master_PartyGrouping_CreditLimits;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
    }
}