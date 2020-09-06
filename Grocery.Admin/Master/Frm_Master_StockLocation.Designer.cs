namespace Grocery.Admin.Master
{
    partial class Frm_Master_StockLocation
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.GV_Stocklocation = new System.Windows.Forms.DataGridView();
            this.StockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Master_StockLocation_Description_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Master_StockLocation_Location_Search = new System.Windows.Forms.TextBox();
            this.btn_Master_StockLocation_Close = new System.Windows.Forms.Button();
            this.btn_Master_StockLocation_Save = new System.Windows.Forms.Button();
            this.btn_Master_StockLocation_Delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Master_StockLocation_Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Master_StockLocation_Cancel = new System.Windows.Forms.Button();
            this.btn_Master_StockLocation_New = new System.Windows.Forms.Button();
            this.txt_Master_StockLocation_StockDescription = new System.Windows.Forms.TextBox();
            this.txt_Master_StockLocation_StockLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Master_StockLocationr_StockId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Stocklocation)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GV_Stocklocation);
            this.panel4.Location = new System.Drawing.Point(12, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 223);
            this.panel4.TabIndex = 10;
            // 
            // GV_Stocklocation
            // 
            this.GV_Stocklocation.AllowUserToAddRows = false;
            this.GV_Stocklocation.AllowUserToDeleteRows = false;
            this.GV_Stocklocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_Stocklocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Stocklocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockId,
            this.StockLocation,
            this.StockDesc});
            this.GV_Stocklocation.Location = new System.Drawing.Point(0, 0);
            this.GV_Stocklocation.Name = "GV_Stocklocation";
            this.GV_Stocklocation.ReadOnly = true;
            this.GV_Stocklocation.Size = new System.Drawing.Size(773, 220);
            this.GV_Stocklocation.TabIndex = 0;
            this.GV_Stocklocation.DoubleClick += new System.EventHandler(this.GV_Stocklocation_DoubleClick);
            // 
            // StockId
            // 
            this.StockId.HeaderText = "Stock ID";
            this.StockId.Name = "StockId";
            this.StockId.ReadOnly = true;
            // 
            // StockLocation
            // 
            this.StockLocation.HeaderText = "Stock Location";
            this.StockLocation.Name = "StockLocation";
            this.StockLocation.ReadOnly = true;
            // 
            // StockDesc
            // 
            this.StockDesc.HeaderText = "Stock Desc.";
            this.StockDesc.Name = "StockDesc";
            this.StockDesc.ReadOnly = true;
            // 
            // txt_Master_StockLocation_Description_Search
            // 
            this.txt_Master_StockLocation_Description_Search.Location = new System.Drawing.Point(166, 24);
            this.txt_Master_StockLocation_Description_Search.Name = "txt_Master_StockLocation_Description_Search";
            this.txt_Master_StockLocation_Description_Search.Size = new System.Drawing.Size(230, 20);
            this.txt_Master_StockLocation_Description_Search.TabIndex = 3;
            this.txt_Master_StockLocation_Description_Search.TextChanged += new System.EventHandler(this.txt_Master_StockLocation_Description_Search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stock Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stock Location";
            // 
            // txt_Master_StockLocation_Location_Search
            // 
            this.txt_Master_StockLocation_Location_Search.Location = new System.Drawing.Point(11, 24);
            this.txt_Master_StockLocation_Location_Search.Name = "txt_Master_StockLocation_Location_Search";
            this.txt_Master_StockLocation_Location_Search.Size = new System.Drawing.Size(100, 20);
            this.txt_Master_StockLocation_Location_Search.TabIndex = 0;
            this.txt_Master_StockLocation_Location_Search.TextChanged += new System.EventHandler(this.txt_Master_StockLocation_Location_Search_TextChanged);
            // 
            // btn_Master_StockLocation_Close
            // 
            this.btn_Master_StockLocation_Close.Location = new System.Drawing.Point(327, 8);
            this.btn_Master_StockLocation_Close.Name = "btn_Master_StockLocation_Close";
            this.btn_Master_StockLocation_Close.Size = new System.Drawing.Size(69, 23);
            this.btn_Master_StockLocation_Close.TabIndex = 4;
            this.btn_Master_StockLocation_Close.Text = "Close";
            this.btn_Master_StockLocation_Close.UseVisualStyleBackColor = true;
            this.btn_Master_StockLocation_Close.Click += new System.EventHandler(this.btn_Master_StockLocation_Close_Click);
            // 
            // btn_Master_StockLocation_Save
            // 
            this.btn_Master_StockLocation_Save.Location = new System.Drawing.Point(248, 8);
            this.btn_Master_StockLocation_Save.Name = "btn_Master_StockLocation_Save";
            this.btn_Master_StockLocation_Save.Size = new System.Drawing.Size(73, 23);
            this.btn_Master_StockLocation_Save.TabIndex = 3;
            this.btn_Master_StockLocation_Save.Text = "Save";
            this.btn_Master_StockLocation_Save.UseVisualStyleBackColor = true;
            this.btn_Master_StockLocation_Save.Click += new System.EventHandler(this.btn_Master_StockLocation_Save_Click);
            // 
            // btn_Master_StockLocation_Delete
            // 
            this.btn_Master_StockLocation_Delete.Location = new System.Drawing.Point(176, 8);
            this.btn_Master_StockLocation_Delete.Name = "btn_Master_StockLocation_Delete";
            this.btn_Master_StockLocation_Delete.Size = new System.Drawing.Size(66, 23);
            this.btn_Master_StockLocation_Delete.TabIndex = 2;
            this.btn_Master_StockLocation_Delete.Text = "Delete";
            this.btn_Master_StockLocation_Delete.UseVisualStyleBackColor = true;
            this.btn_Master_StockLocation_Delete.Click += new System.EventHandler(this.btn_Master_StockLocation_Delete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_Master_StockLocation_Description_Search);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_Master_StockLocation_Location_Search);
            this.panel3.Location = new System.Drawing.Point(12, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 54);
            this.panel3.TabIndex = 9;
            // 
            // btn_Master_StockLocation_Edit
            // 
            this.btn_Master_StockLocation_Edit.Location = new System.Drawing.Point(111, 8);
            this.btn_Master_StockLocation_Edit.Name = "btn_Master_StockLocation_Edit";
            this.btn_Master_StockLocation_Edit.Size = new System.Drawing.Size(59, 23);
            this.btn_Master_StockLocation_Edit.TabIndex = 1;
            this.btn_Master_StockLocation_Edit.Text = "Edit";
            this.btn_Master_StockLocation_Edit.UseVisualStyleBackColor = true;
            this.btn_Master_StockLocation_Edit.Click += new System.EventHandler(this.btn_Master_StockLocation_Edit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Master_StockLocation_Cancel);
            this.panel2.Controls.Add(this.btn_Master_StockLocation_Close);
            this.panel2.Controls.Add(this.btn_Master_StockLocation_Save);
            this.panel2.Controls.Add(this.btn_Master_StockLocation_Delete);
            this.panel2.Controls.Add(this.btn_Master_StockLocation_Edit);
            this.panel2.Controls.Add(this.btn_Master_StockLocation_New);
            this.panel2.Location = new System.Drawing.Point(12, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 39);
            this.panel2.TabIndex = 8;
            // 
            // btn_Master_StockLocation_Cancel
            // 
            this.btn_Master_StockLocation_Cancel.Location = new System.Drawing.Point(328, 8);
            this.btn_Master_StockLocation_Cancel.Name = "btn_Master_StockLocation_Cancel";
            this.btn_Master_StockLocation_Cancel.Size = new System.Drawing.Size(69, 23);
            this.btn_Master_StockLocation_Cancel.TabIndex = 5;
            this.btn_Master_StockLocation_Cancel.Text = "Cancel";
            this.btn_Master_StockLocation_Cancel.UseVisualStyleBackColor = true;
            this.btn_Master_StockLocation_Cancel.Click += new System.EventHandler(this.btn_Master_StockLocation_Cancel_Click);
            // 
            // btn_Master_StockLocation_New
            // 
            this.btn_Master_StockLocation_New.Location = new System.Drawing.Point(43, 8);
            this.btn_Master_StockLocation_New.Name = "btn_Master_StockLocation_New";
            this.btn_Master_StockLocation_New.Size = new System.Drawing.Size(62, 23);
            this.btn_Master_StockLocation_New.TabIndex = 0;
            this.btn_Master_StockLocation_New.Text = "New";
            this.btn_Master_StockLocation_New.UseVisualStyleBackColor = true;
            this.btn_Master_StockLocation_New.Click += new System.EventHandler(this.btn_Master_StockLocation_New_Click);
            // 
            // txt_Master_StockLocation_StockDescription
            // 
            this.txt_Master_StockLocation_StockDescription.Location = new System.Drawing.Point(111, 65);
            this.txt_Master_StockLocation_StockDescription.Name = "txt_Master_StockLocation_StockDescription";
            this.txt_Master_StockLocation_StockDescription.Size = new System.Drawing.Size(593, 20);
            this.txt_Master_StockLocation_StockDescription.TabIndex = 5;
            // 
            // txt_Master_StockLocation_StockLocation
            // 
            this.txt_Master_StockLocation_StockLocation.Location = new System.Drawing.Point(111, 38);
            this.txt_Master_StockLocation_StockLocation.Name = "txt_Master_StockLocation_StockLocation";
            this.txt_Master_StockLocation_StockLocation.Size = new System.Drawing.Size(593, 20);
            this.txt_Master_StockLocation_StockLocation.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock Location";
            // 
            // txt_Master_StockLocationr_StockId
            // 
            this.txt_Master_StockLocationr_StockId.Location = new System.Drawing.Point(111, 7);
            this.txt_Master_StockLocationr_StockId.Name = "txt_Master_StockLocationr_StockId";
            this.txt_Master_StockLocationr_StockId.Size = new System.Drawing.Size(173, 20);
            this.txt_Master_StockLocationr_StockId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Master_StockLocation_StockDescription);
            this.panel1.Controls.Add(this.txt_Master_StockLocation_StockLocation);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Master_StockLocationr_StockId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 92);
            this.panel1.TabIndex = 7;
            // 
            // Frm_Master_StockLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Master_StockLocation";
            this.Text = "Frm_Master_StockLocation";
            this.Load += new System.EventHandler(this.Frm_Master_StockLocation_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_Stocklocation)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Master_StockLocation_Description_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Master_StockLocation_Location_Search;
        private System.Windows.Forms.Button btn_Master_StockLocation_Close;
        private System.Windows.Forms.Button btn_Master_StockLocation_Save;
        private System.Windows.Forms.Button btn_Master_StockLocation_Delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Master_StockLocation_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Master_StockLocation_New;
        private System.Windows.Forms.TextBox txt_Master_StockLocation_StockDescription;
        private System.Windows.Forms.TextBox txt_Master_StockLocation_StockLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Master_StockLocationr_StockId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GV_Stocklocation;
        private System.Windows.Forms.Button btn_Master_StockLocation_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDesc;
    }
}