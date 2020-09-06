namespace Grocery.Admin.Master
{
    partial class frm_Master_BranchMaster
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
            this.SC_BrandMaster = new System.Windows.Forms.SplitContainer();
            this.lblBranch = new System.Windows.Forms.Label();
            this.SC_BranchMasterPanel3 = new System.Windows.Forms.Panel();
            this.GV_BranchMaster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SC_BrandMaster)).BeginInit();
            this.SC_BrandMaster.Panel1.SuspendLayout();
            this.SC_BrandMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BranchMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // SC_BrandMaster
            // 
            this.SC_BrandMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SC_BrandMaster.Location = new System.Drawing.Point(510, 201);
            this.SC_BrandMaster.Name = "SC_BrandMaster";
            this.SC_BrandMaster.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SC_BrandMaster.Panel1
            // 
            this.SC_BrandMaster.Panel1.Controls.Add(this.lblBranch);
            this.SC_BrandMaster.Panel1.Controls.Add(this.SC_BranchMasterPanel3);
            this.SC_BrandMaster.Size = new System.Drawing.Size(445, 333);
            this.SC_BrandMaster.SplitterDistance = 126;
            this.SC_BrandMaster.TabIndex = 0;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(32, 40);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(35, 13);
            this.lblBranch.TabIndex = 1;
            this.lblBranch.Text = "label1";
            // 
            // SC_BranchMasterPanel3
            // 
            this.SC_BranchMasterPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SC_BranchMasterPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SC_BranchMasterPanel3.Location = new System.Drawing.Point(0, -160);
            this.SC_BranchMasterPanel3.Name = "SC_BranchMasterPanel3";
            this.SC_BranchMasterPanel3.Size = new System.Drawing.Size(443, 284);
            this.SC_BranchMasterPanel3.TabIndex = 0;
            // 
            // GV_BranchMaster
            // 
            this.GV_BranchMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BranchMaster.Location = new System.Drawing.Point(12, 317);
            this.GV_BranchMaster.Name = "GV_BranchMaster";
            this.GV_BranchMaster.Size = new System.Drawing.Size(443, 201);
            this.GV_BranchMaster.TabIndex = 1;
            // 
            // frm_Master_BranchMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 530);
            this.Controls.Add(this.GV_BranchMaster);
            this.Controls.Add(this.SC_BrandMaster);
            this.Name = "frm_Master_BranchMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch Master";
            this.Load += new System.EventHandler(this.Frm_Master_ItemBranch_Load);
            this.SC_BrandMaster.Panel1.ResumeLayout(false);
            this.SC_BrandMaster.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_BrandMaster)).EndInit();
            this.SC_BrandMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BranchMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SC_BrandMaster;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Panel SC_BranchMasterPanel3;
        private System.Windows.Forms.DataGridView GV_BranchMaster;
    }
}