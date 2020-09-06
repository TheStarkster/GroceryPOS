namespace Grocery.Admin.Master
{
    partial class Frm_Master_CreditCard
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
            this.GV_CreditCardMaster = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Master_CreditCard_Name_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Master_CreditCard_Id_Search = new System.Windows.Forms.TextBox();
            this.btn_Master_CreditCard_Close = new System.Windows.Forms.Button();
            this.btn_Master_CreditCard_Save = new System.Windows.Forms.Button();
            this.btn_Master_CreditCard_Delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Master_CreditCard_Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Master_CreditCard_New = new System.Windows.Forms.Button();
            this.txt_Master_CreditCard_Bank = new System.Windows.Forms.TextBox();
            this.txt_Master_CreditCard_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Master_CreditCard_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Master_CreditCard_CommissionRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCommissionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Master_CreditCard_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV_CreditCardMaster)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_CreditCardMaster
            // 
            this.GV_CreditCardMaster.AllowUserToAddRows = false;
            this.GV_CreditCardMaster.AllowUserToDeleteRows = false;
            this.GV_CreditCardMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_CreditCardMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_CreditCardMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.clmBank,
            this.clmCommissionRate});
            this.GV_CreditCardMaster.Location = new System.Drawing.Point(0, 3);
            this.GV_CreditCardMaster.Name = "GV_CreditCardMaster";
            this.GV_CreditCardMaster.ReadOnly = true;
            this.GV_CreditCardMaster.Size = new System.Drawing.Size(773, 180);
            this.GV_CreditCardMaster.TabIndex = 0;
            this.GV_CreditCardMaster.DoubleClick += new System.EventHandler(this.GV_CreditCardMaster_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GV_CreditCardMaster);
            this.panel4.Location = new System.Drawing.Point(12, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 183);
            this.panel4.TabIndex = 10;
            // 
            // txt_Master_CreditCard_Name_Search
            // 
            this.txt_Master_CreditCard_Name_Search.Location = new System.Drawing.Point(166, 24);
            this.txt_Master_CreditCard_Name_Search.Name = "txt_Master_CreditCard_Name_Search";
            this.txt_Master_CreditCard_Name_Search.Size = new System.Drawing.Size(230, 20);
            this.txt_Master_CreditCard_Name_Search.TabIndex = 3;
            this.txt_Master_CreditCard_Name_Search.TextChanged += new System.EventHandler(this.txt_Master_CreditCard_Name_Search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Credit Card ID";
            // 
            // txt_Master_CreditCard_Id_Search
            // 
            this.txt_Master_CreditCard_Id_Search.Location = new System.Drawing.Point(11, 24);
            this.txt_Master_CreditCard_Id_Search.Name = "txt_Master_CreditCard_Id_Search";
            this.txt_Master_CreditCard_Id_Search.Size = new System.Drawing.Size(100, 20);
            this.txt_Master_CreditCard_Id_Search.TabIndex = 0;
            this.txt_Master_CreditCard_Id_Search.TextChanged += new System.EventHandler(this.txt_Master_CreditCard_Id_Search_TextChanged);
            // 
            // btn_Master_CreditCard_Close
            // 
            this.btn_Master_CreditCard_Close.Location = new System.Drawing.Point(327, 8);
            this.btn_Master_CreditCard_Close.Name = "btn_Master_CreditCard_Close";
            this.btn_Master_CreditCard_Close.Size = new System.Drawing.Size(69, 23);
            this.btn_Master_CreditCard_Close.TabIndex = 4;
            this.btn_Master_CreditCard_Close.Text = "Close";
            this.btn_Master_CreditCard_Close.UseVisualStyleBackColor = true;
            this.btn_Master_CreditCard_Close.Click += new System.EventHandler(this.btn_Master_CreditCard_Close_Click);
            // 
            // btn_Master_CreditCard_Save
            // 
            this.btn_Master_CreditCard_Save.Location = new System.Drawing.Point(248, 8);
            this.btn_Master_CreditCard_Save.Name = "btn_Master_CreditCard_Save";
            this.btn_Master_CreditCard_Save.Size = new System.Drawing.Size(73, 23);
            this.btn_Master_CreditCard_Save.TabIndex = 3;
            this.btn_Master_CreditCard_Save.Text = "Save";
            this.btn_Master_CreditCard_Save.UseVisualStyleBackColor = true;
            this.btn_Master_CreditCard_Save.Click += new System.EventHandler(this.btn_Master_CreditCard_Save_Click);
            // 
            // btn_Master_CreditCard_Delete
            // 
            this.btn_Master_CreditCard_Delete.Location = new System.Drawing.Point(176, 8);
            this.btn_Master_CreditCard_Delete.Name = "btn_Master_CreditCard_Delete";
            this.btn_Master_CreditCard_Delete.Size = new System.Drawing.Size(66, 23);
            this.btn_Master_CreditCard_Delete.TabIndex = 2;
            this.btn_Master_CreditCard_Delete.Text = "Delete";
            this.btn_Master_CreditCard_Delete.UseVisualStyleBackColor = true;
            this.btn_Master_CreditCard_Delete.Click += new System.EventHandler(this.btn_Master_CreditCard_Delete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_Master_CreditCard_Name_Search);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_Master_CreditCard_Id_Search);
            this.panel3.Location = new System.Drawing.Point(12, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 64);
            this.panel3.TabIndex = 9;
            // 
            // btn_Master_CreditCard_Edit
            // 
            this.btn_Master_CreditCard_Edit.Location = new System.Drawing.Point(111, 8);
            this.btn_Master_CreditCard_Edit.Name = "btn_Master_CreditCard_Edit";
            this.btn_Master_CreditCard_Edit.Size = new System.Drawing.Size(59, 23);
            this.btn_Master_CreditCard_Edit.TabIndex = 1;
            this.btn_Master_CreditCard_Edit.Text = "Edit";
            this.btn_Master_CreditCard_Edit.UseVisualStyleBackColor = true;
            this.btn_Master_CreditCard_Edit.Click += new System.EventHandler(this.btn_Master_CreditCard_Edit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Master_CreditCard_Cancel);
            this.panel2.Controls.Add(this.btn_Master_CreditCard_Close);
            this.panel2.Controls.Add(this.btn_Master_CreditCard_Save);
            this.panel2.Controls.Add(this.btn_Master_CreditCard_Delete);
            this.panel2.Controls.Add(this.btn_Master_CreditCard_Edit);
            this.panel2.Controls.Add(this.btn_Master_CreditCard_New);
            this.panel2.Location = new System.Drawing.Point(12, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 49);
            this.panel2.TabIndex = 8;
            // 
            // btn_Master_CreditCard_New
            // 
            this.btn_Master_CreditCard_New.Location = new System.Drawing.Point(43, 8);
            this.btn_Master_CreditCard_New.Name = "btn_Master_CreditCard_New";
            this.btn_Master_CreditCard_New.Size = new System.Drawing.Size(62, 23);
            this.btn_Master_CreditCard_New.TabIndex = 0;
            this.btn_Master_CreditCard_New.Text = "New";
            this.btn_Master_CreditCard_New.UseVisualStyleBackColor = true;
            this.btn_Master_CreditCard_New.Click += new System.EventHandler(this.btn_Master_CreditCard_New_Click);
            // 
            // txt_Master_CreditCard_Bank
            // 
            this.txt_Master_CreditCard_Bank.Location = new System.Drawing.Point(111, 65);
            this.txt_Master_CreditCard_Bank.Name = "txt_Master_CreditCard_Bank";
            this.txt_Master_CreditCard_Bank.Size = new System.Drawing.Size(593, 20);
            this.txt_Master_CreditCard_Bank.TabIndex = 5;
            // 
            // txt_Master_CreditCard_Name
            // 
            this.txt_Master_CreditCard_Name.Location = new System.Drawing.Point(111, 38);
            this.txt_Master_CreditCard_Name.Name = "txt_Master_CreditCard_Name";
            this.txt_Master_CreditCard_Name.Size = new System.Drawing.Size(593, 20);
            this.txt_Master_CreditCard_Name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txt_Master_CreditCard_Id
            // 
            this.txt_Master_CreditCard_Id.Location = new System.Drawing.Point(111, 12);
            this.txt_Master_CreditCard_Id.Name = "txt_Master_CreditCard_Id";
            this.txt_Master_CreditCard_Id.Size = new System.Drawing.Size(173, 20);
            this.txt_Master_CreditCard_Id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Master_CreditCard_CommissionRate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Master_CreditCard_Bank);
            this.panel1.Controls.Add(this.txt_Master_CreditCard_Name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Master_CreditCard_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 125);
            this.panel1.TabIndex = 7;
            // 
            // txt_Master_CreditCard_CommissionRate
            // 
            this.txt_Master_CreditCard_CommissionRate.Location = new System.Drawing.Point(111, 91);
            this.txt_Master_CreditCard_CommissionRate.Name = "txt_Master_CreditCard_CommissionRate";
            this.txt_Master_CreditCard_CommissionRate.Size = new System.Drawing.Size(593, 20);
            this.txt_Master_CreditCard_CommissionRate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Commission Rate";
            // 
            // clmID
            // 
            this.clmID.HeaderText = "Card ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmBank
            // 
            this.clmBank.HeaderText = "Bank";
            this.clmBank.Name = "clmBank";
            this.clmBank.ReadOnly = true;
            // 
            // clmCommissionRate
            // 
            this.clmCommissionRate.HeaderText = "Rate";
            this.clmCommissionRate.Name = "clmCommissionRate";
            this.clmCommissionRate.ReadOnly = true;
            // 
            // btn_Master_CreditCard_Cancel
            // 
            this.btn_Master_CreditCard_Cancel.Location = new System.Drawing.Point(328, 8);
            this.btn_Master_CreditCard_Cancel.Name = "btn_Master_CreditCard_Cancel";
            this.btn_Master_CreditCard_Cancel.Size = new System.Drawing.Size(69, 23);
            this.btn_Master_CreditCard_Cancel.TabIndex = 5;
            this.btn_Master_CreditCard_Cancel.Text = "Cancel";
            this.btn_Master_CreditCard_Cancel.UseVisualStyleBackColor = true;
            this.btn_Master_CreditCard_Cancel.Click += new System.EventHandler(this.btn_Master_CreditCard_Cancel_Click);
            // 
            // Frm_Master_CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Master_CreditCard";
            this.Load += new System.EventHandler(this.Frm_Master_CreditCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_CreditCardMaster)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GV_CreditCardMaster;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Master_CreditCard_Name_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Master_CreditCard_Id_Search;
        private System.Windows.Forms.Button btn_Master_CreditCard_Close;
        private System.Windows.Forms.Button btn_Master_CreditCard_Save;
        private System.Windows.Forms.Button btn_Master_CreditCard_Delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Master_CreditCard_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Master_CreditCard_New;
        private System.Windows.Forms.TextBox txt_Master_CreditCard_Bank;
        private System.Windows.Forms.TextBox txt_Master_CreditCard_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Master_CreditCard_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Master_CreditCard_CommissionRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCommissionRate;
        private System.Windows.Forms.Button btn_Master_CreditCard_Cancel;
    }
}