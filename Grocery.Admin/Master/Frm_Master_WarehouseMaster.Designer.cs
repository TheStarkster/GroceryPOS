namespace Grocery.Admin.Master
{
    partial class Frm_Master_WarehouseMaster
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
            this.GV_WarehouseMaster = new System.Windows.Forms.DataGridView();
            this.clmWarehouseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWarehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Warehouse_WarehouseName_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Warehouse_WarehouseId_Search = new System.Windows.Forms.TextBox();
            this.btn_WarehouseMaster_Close = new System.Windows.Forms.Button();
            this.btn_WarehouseMaster_Save = new System.Windows.Forms.Button();
            this.btn_WarehouseMaster_Delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_WarehouseMaster_Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_WarehouseMaster_Cancel = new System.Windows.Forms.Button();
            this.btn_WarehouseMaster_New = new System.Windows.Forms.Button();
            this.txt_WarehouseMaster_WarehouseEmpID = new System.Windows.Forms.TextBox();
            this.txt_WarehouseMaster_WarehouseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_WarehouseMaster_WarehouseId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cob_WarehouseMaster_WarehouseSalesman = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_WarehouseMaster)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_WarehouseMaster
            // 
            this.GV_WarehouseMaster.AllowUserToAddRows = false;
            this.GV_WarehouseMaster.AllowUserToDeleteRows = false;
            this.GV_WarehouseMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_WarehouseMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_WarehouseMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmWarehouseId,
            this.clmWarehouseName,
            this.clmSalesman,
            this.clmEmpId});
            this.GV_WarehouseMaster.Location = new System.Drawing.Point(3, 3);
            this.GV_WarehouseMaster.Name = "GV_WarehouseMaster";
            this.GV_WarehouseMaster.ReadOnly = true;
            this.GV_WarehouseMaster.Size = new System.Drawing.Size(773, 220);
            this.GV_WarehouseMaster.TabIndex = 0;
            this.GV_WarehouseMaster.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // clmWarehouseId
            // 
            this.clmWarehouseId.HeaderText = "Warehouse ID";
            this.clmWarehouseId.Name = "clmWarehouseId";
            this.clmWarehouseId.ReadOnly = true;
            // 
            // clmWarehouseName
            // 
            this.clmWarehouseName.HeaderText = "Warehouse Name";
            this.clmWarehouseName.Name = "clmWarehouseName";
            this.clmWarehouseName.ReadOnly = true;
            // 
            // clmSalesman
            // 
            this.clmSalesman.HeaderText = "Salesman Name";
            this.clmSalesman.Name = "clmSalesman";
            this.clmSalesman.ReadOnly = true;
            // 
            // clmEmpId
            // 
            this.clmEmpId.HeaderText = "EmpId";
            this.clmEmpId.Name = "clmEmpId";
            this.clmEmpId.ReadOnly = true;
            this.clmEmpId.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GV_WarehouseMaster);
            this.panel4.Location = new System.Drawing.Point(12, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 223);
            this.panel4.TabIndex = 10;
            // 
            // txt_Warehouse_WarehouseName_Search
            // 
            this.txt_Warehouse_WarehouseName_Search.Location = new System.Drawing.Point(166, 24);
            this.txt_Warehouse_WarehouseName_Search.Name = "txt_Warehouse_WarehouseName_Search";
            this.txt_Warehouse_WarehouseName_Search.Size = new System.Drawing.Size(230, 20);
            this.txt_Warehouse_WarehouseName_Search.TabIndex = 3;
            this.txt_Warehouse_WarehouseName_Search.TextChanged += new System.EventHandler(this.txt_Warehouse_WarehouseName_Search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Warehouse Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Warehouse ID";
            // 
            // txt_Warehouse_WarehouseId_Search
            // 
            this.txt_Warehouse_WarehouseId_Search.Location = new System.Drawing.Point(11, 24);
            this.txt_Warehouse_WarehouseId_Search.Name = "txt_Warehouse_WarehouseId_Search";
            this.txt_Warehouse_WarehouseId_Search.Size = new System.Drawing.Size(100, 20);
            this.txt_Warehouse_WarehouseId_Search.TabIndex = 0;
            this.txt_Warehouse_WarehouseId_Search.TextChanged += new System.EventHandler(this.txt_Warehouse_WarehouseId_Search_TextChanged);
            // 
            // btn_WarehouseMaster_Close
            // 
            this.btn_WarehouseMaster_Close.Location = new System.Drawing.Point(327, 8);
            this.btn_WarehouseMaster_Close.Name = "btn_WarehouseMaster_Close";
            this.btn_WarehouseMaster_Close.Size = new System.Drawing.Size(69, 23);
            this.btn_WarehouseMaster_Close.TabIndex = 4;
            this.btn_WarehouseMaster_Close.Text = "Close";
            this.btn_WarehouseMaster_Close.UseVisualStyleBackColor = true;
            this.btn_WarehouseMaster_Close.Click += new System.EventHandler(this.btn_WarehouseMaster_Close_Click);
            // 
            // btn_WarehouseMaster_Save
            // 
            this.btn_WarehouseMaster_Save.Location = new System.Drawing.Point(248, 8);
            this.btn_WarehouseMaster_Save.Name = "btn_WarehouseMaster_Save";
            this.btn_WarehouseMaster_Save.Size = new System.Drawing.Size(73, 23);
            this.btn_WarehouseMaster_Save.TabIndex = 3;
            this.btn_WarehouseMaster_Save.Text = "Save";
            this.btn_WarehouseMaster_Save.UseVisualStyleBackColor = true;
            this.btn_WarehouseMaster_Save.Click += new System.EventHandler(this.btn_WarehouseMaster_Save_Click);
            // 
            // btn_WarehouseMaster_Delete
            // 
            this.btn_WarehouseMaster_Delete.Location = new System.Drawing.Point(176, 8);
            this.btn_WarehouseMaster_Delete.Name = "btn_WarehouseMaster_Delete";
            this.btn_WarehouseMaster_Delete.Size = new System.Drawing.Size(66, 23);
            this.btn_WarehouseMaster_Delete.TabIndex = 2;
            this.btn_WarehouseMaster_Delete.Text = "Delete";
            this.btn_WarehouseMaster_Delete.UseVisualStyleBackColor = true;
            this.btn_WarehouseMaster_Delete.Click += new System.EventHandler(this.btn_WarehouseMaster_Delete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_Warehouse_WarehouseName_Search);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_Warehouse_WarehouseId_Search);
            this.panel3.Location = new System.Drawing.Point(12, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 54);
            this.panel3.TabIndex = 9;
            // 
            // btn_WarehouseMaster_Edit
            // 
            this.btn_WarehouseMaster_Edit.Location = new System.Drawing.Point(111, 8);
            this.btn_WarehouseMaster_Edit.Name = "btn_WarehouseMaster_Edit";
            this.btn_WarehouseMaster_Edit.Size = new System.Drawing.Size(59, 23);
            this.btn_WarehouseMaster_Edit.TabIndex = 1;
            this.btn_WarehouseMaster_Edit.Text = "Edit";
            this.btn_WarehouseMaster_Edit.UseVisualStyleBackColor = true;
            this.btn_WarehouseMaster_Edit.Click += new System.EventHandler(this.btn_WarehouseMaster_Edit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_WarehouseMaster_Cancel);
            this.panel2.Controls.Add(this.btn_WarehouseMaster_Close);
            this.panel2.Controls.Add(this.btn_WarehouseMaster_Save);
            this.panel2.Controls.Add(this.btn_WarehouseMaster_Delete);
            this.panel2.Controls.Add(this.btn_WarehouseMaster_Edit);
            this.panel2.Controls.Add(this.btn_WarehouseMaster_New);
            this.panel2.Location = new System.Drawing.Point(12, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 39);
            this.panel2.TabIndex = 8;
            // 
            // btn_WarehouseMaster_Cancel
            // 
            this.btn_WarehouseMaster_Cancel.Location = new System.Drawing.Point(328, 8);
            this.btn_WarehouseMaster_Cancel.Name = "btn_WarehouseMaster_Cancel";
            this.btn_WarehouseMaster_Cancel.Size = new System.Drawing.Size(69, 23);
            this.btn_WarehouseMaster_Cancel.TabIndex = 5;
            this.btn_WarehouseMaster_Cancel.Text = "Cancel";
            this.btn_WarehouseMaster_Cancel.UseVisualStyleBackColor = true;
            this.btn_WarehouseMaster_Cancel.Click += new System.EventHandler(this.btn_WarehouseMaster_Cancel_Click);
            // 
            // btn_WarehouseMaster_New
            // 
            this.btn_WarehouseMaster_New.Location = new System.Drawing.Point(43, 8);
            this.btn_WarehouseMaster_New.Name = "btn_WarehouseMaster_New";
            this.btn_WarehouseMaster_New.Size = new System.Drawing.Size(62, 23);
            this.btn_WarehouseMaster_New.TabIndex = 0;
            this.btn_WarehouseMaster_New.Text = "New";
            this.btn_WarehouseMaster_New.UseVisualStyleBackColor = true;
            this.btn_WarehouseMaster_New.Click += new System.EventHandler(this.btn_WarehouseMaster_New_Click);
            // 
            // txt_WarehouseMaster_WarehouseEmpID
            // 
            this.txt_WarehouseMaster_WarehouseEmpID.Enabled = false;
            this.txt_WarehouseMaster_WarehouseEmpID.Location = new System.Drawing.Point(531, 65);
            this.txt_WarehouseMaster_WarehouseEmpID.Name = "txt_WarehouseMaster_WarehouseEmpID";
            this.txt_WarehouseMaster_WarehouseEmpID.Size = new System.Drawing.Size(173, 20);
            this.txt_WarehouseMaster_WarehouseEmpID.TabIndex = 5;
            // 
            // txt_WarehouseMaster_WarehouseName
            // 
            this.txt_WarehouseMaster_WarehouseName.Location = new System.Drawing.Point(111, 38);
            this.txt_WarehouseMaster_WarehouseName.Name = "txt_WarehouseMaster_WarehouseName";
            this.txt_WarehouseMaster_WarehouseName.Size = new System.Drawing.Size(593, 20);
            this.txt_WarehouseMaster_WarehouseName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salesman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Warehouse Name";
            // 
            // txt_WarehouseMaster_WarehouseId
            // 
            this.txt_WarehouseMaster_WarehouseId.Enabled = false;
            this.txt_WarehouseMaster_WarehouseId.Location = new System.Drawing.Point(111, 7);
            this.txt_WarehouseMaster_WarehouseId.Name = "txt_WarehouseMaster_WarehouseId";
            this.txt_WarehouseMaster_WarehouseId.Size = new System.Drawing.Size(173, 20);
            this.txt_WarehouseMaster_WarehouseId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cob_WarehouseMaster_WarehouseSalesman);
            this.panel1.Controls.Add(this.txt_WarehouseMaster_WarehouseEmpID);
            this.panel1.Controls.Add(this.txt_WarehouseMaster_WarehouseName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_WarehouseMaster_WarehouseId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 92);
            this.panel1.TabIndex = 7;
            // 
            // cob_WarehouseMaster_WarehouseSalesman
            // 
            this.cob_WarehouseMaster_WarehouseSalesman.FormattingEnabled = true;
            this.cob_WarehouseMaster_WarehouseSalesman.Location = new System.Drawing.Point(111, 64);
            this.cob_WarehouseMaster_WarehouseSalesman.Name = "cob_WarehouseMaster_WarehouseSalesman";
            this.cob_WarehouseMaster_WarehouseSalesman.Size = new System.Drawing.Size(414, 21);
            this.cob_WarehouseMaster_WarehouseSalesman.TabIndex = 69;
            this.cob_WarehouseMaster_WarehouseSalesman.SelectedIndexChanged += new System.EventHandler(this.cob_WarehouseMaster_WarehouseSalesman_SelectedIndexChanged);
            // 
            // Frm_Master_WarehouseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Master_WarehouseMaster";
            this.Text = "Frm_Master_WarehouseMaster";
            this.Load += new System.EventHandler(this.Frm_Master_WarehouseMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_WarehouseMaster)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GV_WarehouseMaster;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Warehouse_WarehouseName_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Warehouse_WarehouseId_Search;
        private System.Windows.Forms.Button btn_WarehouseMaster_Close;
        private System.Windows.Forms.Button btn_WarehouseMaster_Save;
        private System.Windows.Forms.Button btn_WarehouseMaster_Delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_WarehouseMaster_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_WarehouseMaster_New;
        private System.Windows.Forms.TextBox txt_WarehouseMaster_WarehouseEmpID;
        private System.Windows.Forms.TextBox txt_WarehouseMaster_WarehouseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_WarehouseMaster_WarehouseId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cob_WarehouseMaster_WarehouseSalesman;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWarehouseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesman;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpId;
        private System.Windows.Forms.Button btn_WarehouseMaster_Cancel;
    }
}