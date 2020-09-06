namespace Grocery.Admin.Master
{
    partial class Frm_Master_ItemModelMaster
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
            this.txt_ItemModel_ModelDesc = new System.Windows.Forms.TextBox();
            this.lbl_ItemModel_ModelDesc = new System.Windows.Forms.Label();
            this.txt_ItemModel_ModelName = new System.Windows.Forms.TextBox();
            this.lbl_ItemModel_ModelName = new System.Windows.Forms.Label();
            this.txt_ItemModel_ModelID = new System.Windows.Forms.TextBox();
            this.lbl_ItemModel_ModelID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ItemModel_Close = new System.Windows.Forms.Button();
            this.btn_ItemModel_Save = new System.Windows.Forms.Button();
            this.btn_ItemModel_Delete = new System.Windows.Forms.Button();
            this.btn_ItemModel_Edit = new System.Windows.Forms.Button();
            this.btn_ItemModel_New = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_ItemModel_ModelDetails = new System.Windows.Forms.DataGridView();
            this.txt_ItemModel_SrchModelName = new System.Windows.Forms.TextBox();
            this.lbl_ItemModel_SrchModelName = new System.Windows.Forms.Label();
            this.btn_ItemModel_Cancel = new System.Windows.Forms.Button();
            this.clmmodelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemModel_ModelDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_ItemModel_ModelDesc);
            this.panel1.Controls.Add(this.lbl_ItemModel_ModelDesc);
            this.panel1.Controls.Add(this.txt_ItemModel_ModelName);
            this.panel1.Controls.Add(this.lbl_ItemModel_ModelName);
            this.panel1.Controls.Add(this.txt_ItemModel_ModelID);
            this.panel1.Controls.Add(this.lbl_ItemModel_ModelID);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 107);
            this.panel1.TabIndex = 0;
            // 
            // txt_ItemModel_ModelDesc
            // 
            this.txt_ItemModel_ModelDesc.Location = new System.Drawing.Point(128, 70);
            this.txt_ItemModel_ModelDesc.Name = "txt_ItemModel_ModelDesc";
            this.txt_ItemModel_ModelDesc.Size = new System.Drawing.Size(331, 22);
            this.txt_ItemModel_ModelDesc.TabIndex = 5;
            // 
            // lbl_ItemModel_ModelDesc
            // 
            this.lbl_ItemModel_ModelDesc.AutoSize = true;
            this.lbl_ItemModel_ModelDesc.Location = new System.Drawing.Point(15, 70);
            this.lbl_ItemModel_ModelDesc.Name = "lbl_ItemModel_ModelDesc";
            this.lbl_ItemModel_ModelDesc.Size = new System.Drawing.Size(107, 15);
            this.lbl_ItemModel_ModelDesc.TabIndex = 4;
            this.lbl_ItemModel_ModelDesc.Text = "Model Description";
            // 
            // txt_ItemModel_ModelName
            // 
            this.txt_ItemModel_ModelName.Location = new System.Drawing.Point(128, 42);
            this.txt_ItemModel_ModelName.Name = "txt_ItemModel_ModelName";
            this.txt_ItemModel_ModelName.Size = new System.Drawing.Size(331, 22);
            this.txt_ItemModel_ModelName.TabIndex = 3;
            // 
            // lbl_ItemModel_ModelName
            // 
            this.lbl_ItemModel_ModelName.AutoSize = true;
            this.lbl_ItemModel_ModelName.Location = new System.Drawing.Point(15, 43);
            this.lbl_ItemModel_ModelName.Name = "lbl_ItemModel_ModelName";
            this.lbl_ItemModel_ModelName.Size = new System.Drawing.Size(75, 15);
            this.lbl_ItemModel_ModelName.TabIndex = 2;
            this.lbl_ItemModel_ModelName.Text = "Model Name";
            // 
            // txt_ItemModel_ModelID
            // 
            this.txt_ItemModel_ModelID.Enabled = false;
            this.txt_ItemModel_ModelID.Location = new System.Drawing.Point(128, 15);
            this.txt_ItemModel_ModelID.Name = "txt_ItemModel_ModelID";
            this.txt_ItemModel_ModelID.Size = new System.Drawing.Size(100, 22);
            this.txt_ItemModel_ModelID.TabIndex = 1;
            // 
            // lbl_ItemModel_ModelID
            // 
            this.lbl_ItemModel_ModelID.AutoSize = true;
            this.lbl_ItemModel_ModelID.Location = new System.Drawing.Point(15, 15);
            this.lbl_ItemModel_ModelID.Name = "lbl_ItemModel_ModelID";
            this.lbl_ItemModel_ModelID.Size = new System.Drawing.Size(58, 15);
            this.lbl_ItemModel_ModelID.TabIndex = 0;
            this.lbl_ItemModel_ModelID.Text = "Model ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_ItemModel_Cancel);
            this.panel2.Controls.Add(this.btn_ItemModel_Close);
            this.panel2.Controls.Add(this.btn_ItemModel_Save);
            this.panel2.Controls.Add(this.btn_ItemModel_Delete);
            this.panel2.Controls.Add(this.btn_ItemModel_Edit);
            this.panel2.Controls.Add(this.btn_ItemModel_New);
            this.panel2.Location = new System.Drawing.Point(13, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 37);
            this.panel2.TabIndex = 1;
            // 
            // btn_ItemModel_Close
            // 
            this.btn_ItemModel_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ItemModel_Close.Location = new System.Drawing.Point(349, 4);
            this.btn_ItemModel_Close.Name = "btn_ItemModel_Close";
            this.btn_ItemModel_Close.Size = new System.Drawing.Size(67, 29);
            this.btn_ItemModel_Close.TabIndex = 4;
            this.btn_ItemModel_Close.Text = "&Close";
            this.btn_ItemModel_Close.UseVisualStyleBackColor = true;
            this.btn_ItemModel_Close.Click += new System.EventHandler(this.btn_ItemModel_Close_Click);
            // 
            // btn_ItemModel_Save
            // 
            this.btn_ItemModel_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ItemModel_Save.Location = new System.Drawing.Point(276, 4);
            this.btn_ItemModel_Save.Name = "btn_ItemModel_Save";
            this.btn_ItemModel_Save.Size = new System.Drawing.Size(67, 29);
            this.btn_ItemModel_Save.TabIndex = 3;
            this.btn_ItemModel_Save.Text = "&Save";
            this.btn_ItemModel_Save.UseVisualStyleBackColor = true;
            this.btn_ItemModel_Save.Click += new System.EventHandler(this.btn_ItemModel_Save_Click);
            // 
            // btn_ItemModel_Delete
            // 
            this.btn_ItemModel_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ItemModel_Delete.Location = new System.Drawing.Point(203, 4);
            this.btn_ItemModel_Delete.Name = "btn_ItemModel_Delete";
            this.btn_ItemModel_Delete.Size = new System.Drawing.Size(67, 29);
            this.btn_ItemModel_Delete.TabIndex = 2;
            this.btn_ItemModel_Delete.Text = "&Delete";
            this.btn_ItemModel_Delete.UseVisualStyleBackColor = true;
            this.btn_ItemModel_Delete.Click += new System.EventHandler(this.btn_ItemModel_Delete_Click);
            // 
            // btn_ItemModel_Edit
            // 
            this.btn_ItemModel_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ItemModel_Edit.Location = new System.Drawing.Point(130, 4);
            this.btn_ItemModel_Edit.Name = "btn_ItemModel_Edit";
            this.btn_ItemModel_Edit.Size = new System.Drawing.Size(67, 29);
            this.btn_ItemModel_Edit.TabIndex = 1;
            this.btn_ItemModel_Edit.Text = "&Edit";
            this.btn_ItemModel_Edit.UseVisualStyleBackColor = true;
            this.btn_ItemModel_Edit.Click += new System.EventHandler(this.btn_ItemModel_Edit_Click);
            // 
            // btn_ItemModel_New
            // 
            this.btn_ItemModel_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ItemModel_New.Location = new System.Drawing.Point(57, 4);
            this.btn_ItemModel_New.Name = "btn_ItemModel_New";
            this.btn_ItemModel_New.Size = new System.Drawing.Size(67, 29);
            this.btn_ItemModel_New.TabIndex = 0;
            this.btn_ItemModel_New.Text = "&New";
            this.btn_ItemModel_New.UseVisualStyleBackColor = true;
            this.btn_ItemModel_New.Click += new System.EventHandler(this.btn_ItemModel_New_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.GV_ItemModel_ModelDetails);
            this.panel3.Controls.Add(this.txt_ItemModel_SrchModelName);
            this.panel3.Controls.Add(this.lbl_ItemModel_SrchModelName);
            this.panel3.Location = new System.Drawing.Point(13, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 194);
            this.panel3.TabIndex = 2;
            // 
            // GV_ItemModel_ModelDetails
            // 
            this.GV_ItemModel_ModelDetails.AllowUserToAddRows = false;
            this.GV_ItemModel_ModelDetails.AllowUserToDeleteRows = false;
            this.GV_ItemModel_ModelDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ItemModel_ModelDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmmodelID,
            this.clmModelName,
            this.clmDescription});
            this.GV_ItemModel_ModelDetails.Location = new System.Drawing.Point(15, 42);
            this.GV_ItemModel_ModelDetails.Name = "GV_ItemModel_ModelDetails";
            this.GV_ItemModel_ModelDetails.ReadOnly = true;
            this.GV_ItemModel_ModelDetails.Size = new System.Drawing.Size(448, 139);
            this.GV_ItemModel_ModelDetails.TabIndex = 6;
            this.GV_ItemModel_ModelDetails.DoubleClick += new System.EventHandler(this.GV_ItemModel_ModelDetails_DoubleClick);
            // 
            // txt_ItemModel_SrchModelName
            // 
            this.txt_ItemModel_SrchModelName.Location = new System.Drawing.Point(130, 12);
            this.txt_ItemModel_SrchModelName.Name = "txt_ItemModel_SrchModelName";
            this.txt_ItemModel_SrchModelName.Size = new System.Drawing.Size(331, 22);
            this.txt_ItemModel_SrchModelName.TabIndex = 5;
            this.txt_ItemModel_SrchModelName.TextChanged += new System.EventHandler(this.txt_ItemModel_SrchModelName_TextChanged);
            // 
            // lbl_ItemModel_SrchModelName
            // 
            this.lbl_ItemModel_SrchModelName.AutoSize = true;
            this.lbl_ItemModel_SrchModelName.Location = new System.Drawing.Point(17, 13);
            this.lbl_ItemModel_SrchModelName.Name = "lbl_ItemModel_SrchModelName";
            this.lbl_ItemModel_SrchModelName.Size = new System.Drawing.Size(75, 15);
            this.lbl_ItemModel_SrchModelName.TabIndex = 4;
            this.lbl_ItemModel_SrchModelName.Text = "Model Name";
            // 
            // btn_ItemModel_Cancel
            // 
            this.btn_ItemModel_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ItemModel_Cancel.Location = new System.Drawing.Point(349, 4);
            this.btn_ItemModel_Cancel.Name = "btn_ItemModel_Cancel";
            this.btn_ItemModel_Cancel.Size = new System.Drawing.Size(67, 29);
            this.btn_ItemModel_Cancel.TabIndex = 5;
            this.btn_ItemModel_Cancel.Text = "&Cancel";
            this.btn_ItemModel_Cancel.UseVisualStyleBackColor = true;
            this.btn_ItemModel_Cancel.Click += new System.EventHandler(this.btn_ItemModel_Cancel_Click);
            // 
            // clmmodelID
            // 
            this.clmmodelID.HeaderText = "Model ID";
            this.clmmodelID.Name = "clmmodelID";
            this.clmmodelID.ReadOnly = true;
            // 
            // clmModelName
            // 
            this.clmModelName.HeaderText = "Model Name";
            this.clmModelName.Name = "clmModelName";
            this.clmModelName.ReadOnly = true;
            this.clmModelName.Width = 150;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            this.clmDescription.Width = 150;
            // 
            // Frm_Master_ItemModelMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 386);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Master_ItemModelMaster";
            this.Text = "Frm_Master_ItemModel";
            this.Load += new System.EventHandler(this.Frm_Master_ItemModelMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemModel_ModelDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ItemModel_ModelDesc;
        private System.Windows.Forms.Label lbl_ItemModel_ModelDesc;
        private System.Windows.Forms.TextBox txt_ItemModel_ModelName;
        private System.Windows.Forms.Label lbl_ItemModel_ModelName;
        private System.Windows.Forms.TextBox txt_ItemModel_ModelID;
        private System.Windows.Forms.Label lbl_ItemModel_ModelID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ItemModel_Close;
        private System.Windows.Forms.Button btn_ItemModel_Save;
        private System.Windows.Forms.Button btn_ItemModel_Delete;
        private System.Windows.Forms.Button btn_ItemModel_Edit;
        private System.Windows.Forms.Button btn_ItemModel_New;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView GV_ItemModel_ModelDetails;
        private System.Windows.Forms.TextBox txt_ItemModel_SrchModelName;
        private System.Windows.Forms.Label lbl_ItemModel_SrchModelName;
        private System.Windows.Forms.Button btn_ItemModel_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmodelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
    }
}