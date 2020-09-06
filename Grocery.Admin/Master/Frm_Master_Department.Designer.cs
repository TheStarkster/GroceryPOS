namespace Grocery.Admin.Master
{
    partial class Frm_Master_Department
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
            this.GV_Department = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Master_Department_Cancel = new System.Windows.Forms.Button();
            this.btn_Master_Department_Close = new System.Windows.Forms.Button();
            this.btn_Master_Department_Save = new System.Windows.Forms.Button();
            this.btn_Master_Department_Delete = new System.Windows.Forms.Button();
            this.btn_Master_Department_Edit = new System.Windows.Forms.Button();
            this.btn_Master_Department_New = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Master_Departmet_DepartmentId_Search = new System.Windows.Forms.TextBox();
            this.txt_Master_Departmet_DepartmentName_Search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Master_Department_ArabicName = new System.Windows.Forms.TextBox();
            this.txt_Master_Department_DepartmentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Master_Department_DepartmentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Master_Department_DepartmentDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Dpt_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dtp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArabicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Department)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_Department
            // 
            this.GV_Department.AllowUserToAddRows = false;
            this.GV_Department.AllowUserToDeleteRows = false;
            this.GV_Department.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Department.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dpt_Id,
            this.Dtp_Name,
            this.DepartmentDesc,
            this.ArabicName});
            this.GV_Department.Location = new System.Drawing.Point(0, 3);
            this.GV_Department.Name = "GV_Department";
            this.GV_Department.ReadOnly = true;
            this.GV_Department.Size = new System.Drawing.Size(445, 180);
            this.GV_Department.TabIndex = 0;
            this.GV_Department.DoubleClick += new System.EventHandler(this.GV_Department_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Master_Department_Cancel);
            this.panel2.Controls.Add(this.btn_Master_Department_Close);
            this.panel2.Controls.Add(this.btn_Master_Department_Save);
            this.panel2.Controls.Add(this.btn_Master_Department_Delete);
            this.panel2.Controls.Add(this.btn_Master_Department_Edit);
            this.panel2.Controls.Add(this.btn_Master_Department_New);
            this.panel2.Location = new System.Drawing.Point(12, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 49);
            this.panel2.TabIndex = 16;
            // 
            // btn_Master_Department_Cancel
            // 
            this.btn_Master_Department_Cancel.Location = new System.Drawing.Point(328, 9);
            this.btn_Master_Department_Cancel.Name = "btn_Master_Department_Cancel";
            this.btn_Master_Department_Cancel.Size = new System.Drawing.Size(69, 23);
            this.btn_Master_Department_Cancel.TabIndex = 5;
            this.btn_Master_Department_Cancel.Text = "Cancel";
            this.btn_Master_Department_Cancel.UseVisualStyleBackColor = true;
            this.btn_Master_Department_Cancel.Click += new System.EventHandler(this.btn_Master_Department_Cancel_Click);
            // 
            // btn_Master_Department_Close
            // 
            this.btn_Master_Department_Close.Location = new System.Drawing.Point(327, 8);
            this.btn_Master_Department_Close.Name = "btn_Master_Department_Close";
            this.btn_Master_Department_Close.Size = new System.Drawing.Size(69, 23);
            this.btn_Master_Department_Close.TabIndex = 4;
            this.btn_Master_Department_Close.Text = "Close";
            this.btn_Master_Department_Close.UseVisualStyleBackColor = true;
            this.btn_Master_Department_Close.Click += new System.EventHandler(this.btn_Master_Department_Close_Click);
            // 
            // btn_Master_Department_Save
            // 
            this.btn_Master_Department_Save.Location = new System.Drawing.Point(248, 8);
            this.btn_Master_Department_Save.Name = "btn_Master_Department_Save";
            this.btn_Master_Department_Save.Size = new System.Drawing.Size(73, 23);
            this.btn_Master_Department_Save.TabIndex = 3;
            this.btn_Master_Department_Save.Text = "Save";
            this.btn_Master_Department_Save.UseVisualStyleBackColor = true;
            this.btn_Master_Department_Save.Click += new System.EventHandler(this.btn_Master_Department_Save_Click);
            // 
            // btn_Master_Department_Delete
            // 
            this.btn_Master_Department_Delete.Location = new System.Drawing.Point(176, 8);
            this.btn_Master_Department_Delete.Name = "btn_Master_Department_Delete";
            this.btn_Master_Department_Delete.Size = new System.Drawing.Size(66, 23);
            this.btn_Master_Department_Delete.TabIndex = 2;
            this.btn_Master_Department_Delete.Text = "Delete";
            this.btn_Master_Department_Delete.UseVisualStyleBackColor = true;
            this.btn_Master_Department_Delete.Click += new System.EventHandler(this.btn_Master_Department_Delete_Click);
            // 
            // btn_Master_Department_Edit
            // 
            this.btn_Master_Department_Edit.Location = new System.Drawing.Point(111, 8);
            this.btn_Master_Department_Edit.Name = "btn_Master_Department_Edit";
            this.btn_Master_Department_Edit.Size = new System.Drawing.Size(59, 23);
            this.btn_Master_Department_Edit.TabIndex = 1;
            this.btn_Master_Department_Edit.Text = "Edit";
            this.btn_Master_Department_Edit.UseVisualStyleBackColor = true;
            this.btn_Master_Department_Edit.Click += new System.EventHandler(this.btn_Master_Department_Edit_Click);
            // 
            // btn_Master_Department_New
            // 
            this.btn_Master_Department_New.Location = new System.Drawing.Point(43, 8);
            this.btn_Master_Department_New.Name = "btn_Master_Department_New";
            this.btn_Master_Department_New.Size = new System.Drawing.Size(62, 23);
            this.btn_Master_Department_New.TabIndex = 0;
            this.btn_Master_Department_New.Text = "New";
            this.btn_Master_Department_New.UseVisualStyleBackColor = true;
            this.btn_Master_Department_New.Click += new System.EventHandler(this.btn_Master_Department_New_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GV_Department);
            this.panel4.Location = new System.Drawing.Point(12, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 183);
            this.panel4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Department Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Department ID";
            // 
            // txt_Master_Departmet_DepartmentId_Search
            // 
            this.txt_Master_Departmet_DepartmentId_Search.Location = new System.Drawing.Point(11, 24);
            this.txt_Master_Departmet_DepartmentId_Search.Name = "txt_Master_Departmet_DepartmentId_Search";
            this.txt_Master_Departmet_DepartmentId_Search.Size = new System.Drawing.Size(100, 20);
            this.txt_Master_Departmet_DepartmentId_Search.TabIndex = 0;
            this.txt_Master_Departmet_DepartmentId_Search.TextChanged += new System.EventHandler(this.txt_Master_Departmet_DepartmentId_Search_TextChanged);
            // 
            // txt_Master_Departmet_DepartmentName_Search
            // 
            this.txt_Master_Departmet_DepartmentName_Search.Location = new System.Drawing.Point(166, 24);
            this.txt_Master_Departmet_DepartmentName_Search.Name = "txt_Master_Departmet_DepartmentName_Search";
            this.txt_Master_Departmet_DepartmentName_Search.Size = new System.Drawing.Size(271, 20);
            this.txt_Master_Departmet_DepartmentName_Search.TabIndex = 3;
            this.txt_Master_Departmet_DepartmentName_Search.TextChanged += new System.EventHandler(this.txt_Master_Departmet_DepartmentName_Search_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_Master_Departmet_DepartmentName_Search);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_Master_Departmet_DepartmentId_Search);
            this.panel3.Location = new System.Drawing.Point(12, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 49);
            this.panel3.TabIndex = 17;
            // 
            // txt_Master_Department_ArabicName
            // 
            this.txt_Master_Department_ArabicName.Location = new System.Drawing.Point(136, 65);
            this.txt_Master_Department_ArabicName.Name = "txt_Master_Department_ArabicName";
            this.txt_Master_Department_ArabicName.Size = new System.Drawing.Size(283, 20);
            this.txt_Master_Department_ArabicName.TabIndex = 5;
            // 
            // txt_Master_Department_DepartmentName
            // 
            this.txt_Master_Department_DepartmentName.Location = new System.Drawing.Point(136, 38);
            this.txt_Master_Department_DepartmentName.Name = "txt_Master_Department_DepartmentName";
            this.txt_Master_Department_DepartmentName.Size = new System.Drawing.Size(283, 20);
            this.txt_Master_Department_DepartmentName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arabic Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name";
            // 
            // txt_Master_Department_DepartmentId
            // 
            this.txt_Master_Department_DepartmentId.Location = new System.Drawing.Point(136, 12);
            this.txt_Master_Department_DepartmentId.Name = "txt_Master_Department_DepartmentId";
            this.txt_Master_Department_DepartmentId.Size = new System.Drawing.Size(130, 20);
            this.txt_Master_Department_DepartmentId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Master_Department_DepartmentDescription);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Master_Department_ArabicName);
            this.panel1.Controls.Add(this.txt_Master_Department_DepartmentName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Master_Department_DepartmentId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 125);
            this.panel1.TabIndex = 15;
            // 
            // txt_Master_Department_DepartmentDescription
            // 
            this.txt_Master_Department_DepartmentDescription.Location = new System.Drawing.Point(136, 91);
            this.txt_Master_Department_DepartmentDescription.Name = "txt_Master_Department_DepartmentDescription";
            this.txt_Master_Department_DepartmentDescription.Size = new System.Drawing.Size(283, 20);
            this.txt_Master_Department_DepartmentDescription.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Department Description";
            // 
            // Dpt_Id
            // 
            this.Dpt_Id.HeaderText = "Department ID";
            this.Dpt_Id.Name = "Dpt_Id";
            this.Dpt_Id.ReadOnly = true;
            // 
            // Dtp_Name
            // 
            this.Dtp_Name.HeaderText = "Department Name";
            this.Dtp_Name.Name = "Dtp_Name";
            this.Dtp_Name.ReadOnly = true;
            // 
            // DepartmentDesc
            // 
            this.DepartmentDesc.HeaderText = "Description";
            this.DepartmentDesc.Name = "DepartmentDesc";
            this.DepartmentDesc.ReadOnly = true;
            // 
            // ArabicName
            // 
            this.ArabicName.HeaderText = "ArabicName";
            this.ArabicName.Name = "ArabicName";
            this.ArabicName.ReadOnly = true;
            this.ArabicName.Visible = false;
            // 
            // Frm_Master_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Master_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Master_Department";
            this.Load += new System.EventHandler(this.Frm_Master_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_Department)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GV_Department;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Master_Department_Close;
        private System.Windows.Forms.Button btn_Master_Department_Save;
        private System.Windows.Forms.Button btn_Master_Department_Delete;
        private System.Windows.Forms.Button btn_Master_Department_Edit;
        private System.Windows.Forms.Button btn_Master_Department_New;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Master_Departmet_DepartmentId_Search;
        private System.Windows.Forms.TextBox txt_Master_Departmet_DepartmentName_Search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Master_Department_ArabicName;
        private System.Windows.Forms.TextBox txt_Master_Department_DepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Master_Department_DepartmentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Master_Department_DepartmentDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Master_Department_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpt_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dtp_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArabicName;
    }
}