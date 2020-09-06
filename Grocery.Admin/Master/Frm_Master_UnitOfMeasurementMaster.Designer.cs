namespace Grocery.Admin.Master
{
    partial class Frm_Master_UnitOfMeasurementMaster
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
            this.GV_Uom = new System.Windows.Forms.DataGridView();
            this.UomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UomPrintAs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UnitOfMeasurementMaster_UnitName_Search = new System.Windows.Forms.TextBox();
            this.btn_UnitOfMeasurementMaster_Close = new System.Windows.Forms.Button();
            this.btn_UnitOfMeasurementMaster_Save = new System.Windows.Forms.Button();
            this.btn_UnitOfMeasurementMaster_Delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_UnitOfMeasurementMaster_Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_UnitOfMeasurementMaster_Cancel = new System.Windows.Forms.Button();
            this.btn_UnitOfMeasurementMaster_New = new System.Windows.Forms.Button();
            this.txt_UnitOfMeasurementMaster_UomPrintAs = new System.Windows.Forms.TextBox();
            this.txt_UnitOfMeasurementMaster_UomName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UnitOfMeasurementMaster_UomId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Uom)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_Uom
            // 
            this.GV_Uom.AllowUserToAddRows = false;
            this.GV_Uom.AllowUserToDeleteRows = false;
            this.GV_Uom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_Uom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Uom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UomId,
            this.UomName,
            this.UomPrintAs});
            this.GV_Uom.Location = new System.Drawing.Point(3, 18);
            this.GV_Uom.Name = "GV_Uom";
            this.GV_Uom.ReadOnly = true;
            this.GV_Uom.Size = new System.Drawing.Size(773, 220);
            this.GV_Uom.TabIndex = 0;
            this.GV_Uom.DoubleClick += new System.EventHandler(this.GV_Uom_DoubleClick);
            // 
            // UomId
            // 
            this.UomId.HeaderText = "UOM ID";
            this.UomId.Name = "UomId";
            this.UomId.ReadOnly = true;
            // 
            // UomName
            // 
            this.UomName.HeaderText = "UOM Name";
            this.UomName.Name = "UomName";
            this.UomName.ReadOnly = true;
            // 
            // UomPrintAs
            // 
            this.UomPrintAs.HeaderText = "UOM Print As";
            this.UomPrintAs.Name = "UomPrintAs";
            this.UomPrintAs.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GV_Uom);
            this.panel4.Location = new System.Drawing.Point(12, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 223);
            this.panel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Unit Name";
            // 
            // txt_UnitOfMeasurementMaster_UnitName_Search
            // 
            this.txt_UnitOfMeasurementMaster_UnitName_Search.Location = new System.Drawing.Point(77, 8);
            this.txt_UnitOfMeasurementMaster_UnitName_Search.Name = "txt_UnitOfMeasurementMaster_UnitName_Search";
            this.txt_UnitOfMeasurementMaster_UnitName_Search.Size = new System.Drawing.Size(526, 20);
            this.txt_UnitOfMeasurementMaster_UnitName_Search.TabIndex = 0;
            this.txt_UnitOfMeasurementMaster_UnitName_Search.TextChanged += new System.EventHandler(this.txt_UnitOfMeasurementMaster_UnitName_Search_TextChanged);
            // 
            // btn_UnitOfMeasurementMaster_Close
            // 
            this.btn_UnitOfMeasurementMaster_Close.Location = new System.Drawing.Point(327, 8);
            this.btn_UnitOfMeasurementMaster_Close.Name = "btn_UnitOfMeasurementMaster_Close";
            this.btn_UnitOfMeasurementMaster_Close.Size = new System.Drawing.Size(69, 23);
            this.btn_UnitOfMeasurementMaster_Close.TabIndex = 4;
            this.btn_UnitOfMeasurementMaster_Close.Text = "Close";
            this.btn_UnitOfMeasurementMaster_Close.UseVisualStyleBackColor = true;
            this.btn_UnitOfMeasurementMaster_Close.Click += new System.EventHandler(this.btn_UnitOfMeasurementMaster_Close_Click);
            // 
            // btn_UnitOfMeasurementMaster_Save
            // 
            this.btn_UnitOfMeasurementMaster_Save.Location = new System.Drawing.Point(248, 8);
            this.btn_UnitOfMeasurementMaster_Save.Name = "btn_UnitOfMeasurementMaster_Save";
            this.btn_UnitOfMeasurementMaster_Save.Size = new System.Drawing.Size(73, 23);
            this.btn_UnitOfMeasurementMaster_Save.TabIndex = 3;
            this.btn_UnitOfMeasurementMaster_Save.Text = "Save";
            this.btn_UnitOfMeasurementMaster_Save.UseVisualStyleBackColor = true;
            this.btn_UnitOfMeasurementMaster_Save.Click += new System.EventHandler(this.btn_UnitOfMeasurementMaster_Save_Click);
            // 
            // btn_UnitOfMeasurementMaster_Delete
            // 
            this.btn_UnitOfMeasurementMaster_Delete.Location = new System.Drawing.Point(176, 8);
            this.btn_UnitOfMeasurementMaster_Delete.Name = "btn_UnitOfMeasurementMaster_Delete";
            this.btn_UnitOfMeasurementMaster_Delete.Size = new System.Drawing.Size(66, 23);
            this.btn_UnitOfMeasurementMaster_Delete.TabIndex = 2;
            this.btn_UnitOfMeasurementMaster_Delete.Text = "Delete";
            this.btn_UnitOfMeasurementMaster_Delete.UseVisualStyleBackColor = true;
            this.btn_UnitOfMeasurementMaster_Delete.Click += new System.EventHandler(this.btn_UnitOfMeasurementMaster_Delete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_UnitOfMeasurementMaster_UnitName_Search);
            this.panel3.Location = new System.Drawing.Point(12, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 42);
            this.panel3.TabIndex = 9;
            // 
            // btn_UnitOfMeasurementMaster_Edit
            // 
            this.btn_UnitOfMeasurementMaster_Edit.Location = new System.Drawing.Point(111, 8);
            this.btn_UnitOfMeasurementMaster_Edit.Name = "btn_UnitOfMeasurementMaster_Edit";
            this.btn_UnitOfMeasurementMaster_Edit.Size = new System.Drawing.Size(59, 23);
            this.btn_UnitOfMeasurementMaster_Edit.TabIndex = 1;
            this.btn_UnitOfMeasurementMaster_Edit.Text = "Edit";
            this.btn_UnitOfMeasurementMaster_Edit.UseVisualStyleBackColor = true;
            this.btn_UnitOfMeasurementMaster_Edit.Click += new System.EventHandler(this.btn_UnitOfMeasurementMaster_Edit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_UnitOfMeasurementMaster_Cancel);
            this.panel2.Controls.Add(this.btn_UnitOfMeasurementMaster_Close);
            this.panel2.Controls.Add(this.btn_UnitOfMeasurementMaster_Save);
            this.panel2.Controls.Add(this.btn_UnitOfMeasurementMaster_Delete);
            this.panel2.Controls.Add(this.btn_UnitOfMeasurementMaster_Edit);
            this.panel2.Controls.Add(this.btn_UnitOfMeasurementMaster_New);
            this.panel2.Location = new System.Drawing.Point(12, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 39);
            this.panel2.TabIndex = 8;
            // 
            // btn_UnitOfMeasurementMaster_Cancel
            // 
            this.btn_UnitOfMeasurementMaster_Cancel.Location = new System.Drawing.Point(328, 8);
            this.btn_UnitOfMeasurementMaster_Cancel.Name = "btn_UnitOfMeasurementMaster_Cancel";
            this.btn_UnitOfMeasurementMaster_Cancel.Size = new System.Drawing.Size(69, 23);
            this.btn_UnitOfMeasurementMaster_Cancel.TabIndex = 5;
            this.btn_UnitOfMeasurementMaster_Cancel.Text = "Cancel";
            this.btn_UnitOfMeasurementMaster_Cancel.UseVisualStyleBackColor = true;
            this.btn_UnitOfMeasurementMaster_Cancel.Click += new System.EventHandler(this.btn_UnitOfMeasurementMaster_Cancel_Click);
            // 
            // btn_UnitOfMeasurementMaster_New
            // 
            this.btn_UnitOfMeasurementMaster_New.Location = new System.Drawing.Point(43, 8);
            this.btn_UnitOfMeasurementMaster_New.Name = "btn_UnitOfMeasurementMaster_New";
            this.btn_UnitOfMeasurementMaster_New.Size = new System.Drawing.Size(62, 23);
            this.btn_UnitOfMeasurementMaster_New.TabIndex = 0;
            this.btn_UnitOfMeasurementMaster_New.Text = "New";
            this.btn_UnitOfMeasurementMaster_New.UseVisualStyleBackColor = true;
            this.btn_UnitOfMeasurementMaster_New.Click += new System.EventHandler(this.btn_UnitOfMeasurementMaster_New_Click);
            // 
            // txt_UnitOfMeasurementMaster_UomPrintAs
            // 
            this.txt_UnitOfMeasurementMaster_UomPrintAs.Location = new System.Drawing.Point(111, 65);
            this.txt_UnitOfMeasurementMaster_UomPrintAs.Name = "txt_UnitOfMeasurementMaster_UomPrintAs";
            this.txt_UnitOfMeasurementMaster_UomPrintAs.Size = new System.Drawing.Size(662, 20);
            this.txt_UnitOfMeasurementMaster_UomPrintAs.TabIndex = 5;
            // 
            // txt_UnitOfMeasurementMaster_UomName
            // 
            this.txt_UnitOfMeasurementMaster_UomName.Location = new System.Drawing.Point(111, 38);
            this.txt_UnitOfMeasurementMaster_UomName.Name = "txt_UnitOfMeasurementMaster_UomName";
            this.txt_UnitOfMeasurementMaster_UomName.Size = new System.Drawing.Size(662, 20);
            this.txt_UnitOfMeasurementMaster_UomName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "UOM Print As";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UOM Name";
            // 
            // txt_UnitOfMeasurementMaster_UomId
            // 
            this.txt_UnitOfMeasurementMaster_UomId.Location = new System.Drawing.Point(111, 7);
            this.txt_UnitOfMeasurementMaster_UomId.Name = "txt_UnitOfMeasurementMaster_UomId";
            this.txt_UnitOfMeasurementMaster_UomId.Size = new System.Drawing.Size(173, 20);
            this.txt_UnitOfMeasurementMaster_UomId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UOM ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_UnitOfMeasurementMaster_UomPrintAs);
            this.panel1.Controls.Add(this.txt_UnitOfMeasurementMaster_UomName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_UnitOfMeasurementMaster_UomId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 92);
            this.panel1.TabIndex = 7;
            // 
            // Frm_Master_UnitOfMeasurementMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Master_UnitOfMeasurementMaster";
            this.Text = "Frm_Master_UnitOfMeasurementMaster";
            this.Load += new System.EventHandler(this.Frm_Master_UnitOfMeasurementMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_Uom)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GV_Uom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UnitOfMeasurementMaster_UnitName_Search;
        private System.Windows.Forms.Button btn_UnitOfMeasurementMaster_Close;
        private System.Windows.Forms.Button btn_UnitOfMeasurementMaster_Save;
        private System.Windows.Forms.Button btn_UnitOfMeasurementMaster_Delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_UnitOfMeasurementMaster_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_UnitOfMeasurementMaster_New;
        private System.Windows.Forms.TextBox txt_UnitOfMeasurementMaster_UomPrintAs;
        private System.Windows.Forms.TextBox txt_UnitOfMeasurementMaster_UomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UnitOfMeasurementMaster_UomId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UomPrintAs;
        private System.Windows.Forms.Button btn_UnitOfMeasurementMaster_Cancel;
    }
}