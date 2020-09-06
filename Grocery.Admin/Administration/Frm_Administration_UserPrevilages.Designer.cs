namespace Grocery.Admin.Administration
{
    partial class Frm_Administration_UserPrevilages
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
            this.lbl_UserPrevilages_SelectanUser = new System.Windows.Forms.Label();
            this.cob_UserPrevilages_SelectanUser = new System.Windows.Forms.ComboBox();
            this.cb_UserPrevilages_SelectAll = new System.Windows.Forms.CheckBox();
            this.GV_UserPrevilages_UserDetails = new System.Windows.Forms.DataGridView();
            this.btn_UserPrevilages_Set = new System.Windows.Forms.Button();
            this.btn_UserPrevilages_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_UserPrevilages_UserDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_UserPrevilages_Cancel);
            this.panel1.Controls.Add(this.btn_UserPrevilages_Set);
            this.panel1.Controls.Add(this.GV_UserPrevilages_UserDetails);
            this.panel1.Controls.Add(this.cb_UserPrevilages_SelectAll);
            this.panel1.Controls.Add(this.cob_UserPrevilages_SelectanUser);
            this.panel1.Controls.Add(this.lbl_UserPrevilages_SelectanUser);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 282);
            this.panel1.TabIndex = 0;
            // 
            // lbl_UserPrevilages_SelectanUser
            // 
            this.lbl_UserPrevilages_SelectanUser.AutoSize = true;
            this.lbl_UserPrevilages_SelectanUser.Location = new System.Drawing.Point(10, 19);
            this.lbl_UserPrevilages_SelectanUser.Name = "lbl_UserPrevilages_SelectanUser";
            this.lbl_UserPrevilages_SelectanUser.Size = new System.Drawing.Size(83, 15);
            this.lbl_UserPrevilages_SelectanUser.TabIndex = 0;
            this.lbl_UserPrevilages_SelectanUser.Text = "Select an User";
            // 
            // cob_UserPrevilages_SelectanUser
            // 
            this.cob_UserPrevilages_SelectanUser.FormattingEnabled = true;
            this.cob_UserPrevilages_SelectanUser.Location = new System.Drawing.Point(99, 15);
            this.cob_UserPrevilages_SelectanUser.Name = "cob_UserPrevilages_SelectanUser";
            this.cob_UserPrevilages_SelectanUser.Size = new System.Drawing.Size(174, 23);
            this.cob_UserPrevilages_SelectanUser.TabIndex = 1;
            // 
            // cb_UserPrevilages_SelectAll
            // 
            this.cb_UserPrevilages_SelectAll.AutoSize = true;
            this.cb_UserPrevilages_SelectAll.Location = new System.Drawing.Point(279, 19);
            this.cb_UserPrevilages_SelectAll.Name = "cb_UserPrevilages_SelectAll";
            this.cb_UserPrevilages_SelectAll.Size = new System.Drawing.Size(76, 19);
            this.cb_UserPrevilages_SelectAll.TabIndex = 2;
            this.cb_UserPrevilages_SelectAll.Text = "Select All";
            this.cb_UserPrevilages_SelectAll.UseVisualStyleBackColor = true;
            // 
            // GV_UserPrevilages_UserDetails
            // 
            this.GV_UserPrevilages_UserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_UserPrevilages_UserDetails.Location = new System.Drawing.Point(13, 44);
            this.GV_UserPrevilages_UserDetails.Name = "GV_UserPrevilages_UserDetails";
            this.GV_UserPrevilages_UserDetails.Size = new System.Drawing.Size(564, 189);
            this.GV_UserPrevilages_UserDetails.TabIndex = 3;
            // 
            // btn_UserPrevilages_Set
            // 
            this.btn_UserPrevilages_Set.Location = new System.Drawing.Point(389, 239);
            this.btn_UserPrevilages_Set.Name = "btn_UserPrevilages_Set";
            this.btn_UserPrevilages_Set.Size = new System.Drawing.Size(91, 37);
            this.btn_UserPrevilages_Set.TabIndex = 4;
            this.btn_UserPrevilages_Set.Text = "Set";
            this.btn_UserPrevilages_Set.UseVisualStyleBackColor = true;
            // 
            // btn_UserPrevilages_Cancel
            // 
            this.btn_UserPrevilages_Cancel.Location = new System.Drawing.Point(486, 239);
            this.btn_UserPrevilages_Cancel.Name = "btn_UserPrevilages_Cancel";
            this.btn_UserPrevilages_Cancel.Size = new System.Drawing.Size(91, 37);
            this.btn_UserPrevilages_Cancel.TabIndex = 5;
            this.btn_UserPrevilages_Cancel.Text = "Cancel";
            this.btn_UserPrevilages_Cancel.UseVisualStyleBackColor = true;
            // 
            // Frm_Administration_UserPrevilages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 304);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Administration_UserPrevilages";
            this.Text = "Frm_Administration_UserPrevilages";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_UserPrevilages_UserDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_UserPrevilages_Cancel;
        private System.Windows.Forms.Button btn_UserPrevilages_Set;
        private System.Windows.Forms.DataGridView GV_UserPrevilages_UserDetails;
        private System.Windows.Forms.CheckBox cb_UserPrevilages_SelectAll;
        private System.Windows.Forms.ComboBox cob_UserPrevilages_SelectanUser;
        private System.Windows.Forms.Label lbl_UserPrevilages_SelectanUser;
    }
}