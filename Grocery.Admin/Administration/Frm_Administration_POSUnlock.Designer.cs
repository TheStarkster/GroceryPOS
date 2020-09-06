namespace Grocery.Admin.Administration
{
    partial class Frm_Administration_POSUnlock
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
            this.cb_POSUnlock_ResetUserLoginStatus = new System.Windows.Forms.CheckBox();
            this.cob_POSUnlock_LoginStatus = new System.Windows.Forms.ComboBox();
            this.btn_POSUnlock_Reset = new System.Windows.Forms.Button();
            this.lbl_POSUnlock_POSName = new System.Windows.Forms.Label();
            this.cob_POSUnlock_POSName = new System.Windows.Forms.ComboBox();
            this.btn_POSUnlock_Update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_POSUnlock_Update);
            this.panel1.Controls.Add(this.cob_POSUnlock_POSName);
            this.panel1.Controls.Add(this.lbl_POSUnlock_POSName);
            this.panel1.Controls.Add(this.btn_POSUnlock_Reset);
            this.panel1.Controls.Add(this.cob_POSUnlock_LoginStatus);
            this.panel1.Controls.Add(this.cb_POSUnlock_ResetUserLoginStatus);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 174);
            this.panel1.TabIndex = 0;
            // 
            // cb_POSUnlock_ResetUserLoginStatus
            // 
            this.cb_POSUnlock_ResetUserLoginStatus.Location = new System.Drawing.Point(16, 14);
            this.cb_POSUnlock_ResetUserLoginStatus.Name = "cb_POSUnlock_ResetUserLoginStatus";
            this.cb_POSUnlock_ResetUserLoginStatus.Size = new System.Drawing.Size(109, 46);
            this.cb_POSUnlock_ResetUserLoginStatus.TabIndex = 0;
            this.cb_POSUnlock_ResetUserLoginStatus.Text = "Reset User Login Status";
            this.cb_POSUnlock_ResetUserLoginStatus.UseVisualStyleBackColor = true;
            // 
            // cob_POSUnlock_LoginStatus
            // 
            this.cob_POSUnlock_LoginStatus.FormattingEnabled = true;
            this.cob_POSUnlock_LoginStatus.Location = new System.Drawing.Point(118, 26);
            this.cob_POSUnlock_LoginStatus.Name = "cob_POSUnlock_LoginStatus";
            this.cob_POSUnlock_LoginStatus.Size = new System.Drawing.Size(199, 23);
            this.cob_POSUnlock_LoginStatus.TabIndex = 1;
            // 
            // btn_POSUnlock_Reset
            // 
            this.btn_POSUnlock_Reset.Location = new System.Drawing.Point(230, 56);
            this.btn_POSUnlock_Reset.Name = "btn_POSUnlock_Reset";
            this.btn_POSUnlock_Reset.Size = new System.Drawing.Size(87, 38);
            this.btn_POSUnlock_Reset.TabIndex = 2;
            this.btn_POSUnlock_Reset.Text = "Reset";
            this.btn_POSUnlock_Reset.UseVisualStyleBackColor = true;
            // 
            // lbl_POSUnlock_POSName
            // 
            this.lbl_POSUnlock_POSName.AutoSize = true;
            this.lbl_POSUnlock_POSName.Location = new System.Drawing.Point(13, 101);
            this.lbl_POSUnlock_POSName.Name = "lbl_POSUnlock_POSName";
            this.lbl_POSUnlock_POSName.Size = new System.Drawing.Size(63, 15);
            this.lbl_POSUnlock_POSName.TabIndex = 3;
            this.lbl_POSUnlock_POSName.Text = "POS Name";
            // 
            // cob_POSUnlock_POSName
            // 
            this.cob_POSUnlock_POSName.FormattingEnabled = true;
            this.cob_POSUnlock_POSName.Location = new System.Drawing.Point(118, 98);
            this.cob_POSUnlock_POSName.Name = "cob_POSUnlock_POSName";
            this.cob_POSUnlock_POSName.Size = new System.Drawing.Size(199, 23);
            this.cob_POSUnlock_POSName.TabIndex = 4;
            // 
            // btn_POSUnlock_Update
            // 
            this.btn_POSUnlock_Update.Location = new System.Drawing.Point(230, 127);
            this.btn_POSUnlock_Update.Name = "btn_POSUnlock_Update";
            this.btn_POSUnlock_Update.Size = new System.Drawing.Size(87, 38);
            this.btn_POSUnlock_Update.TabIndex = 5;
            this.btn_POSUnlock_Update.Text = "Update";
            this.btn_POSUnlock_Update.UseVisualStyleBackColor = true;
            // 
            // Frm_Administration_POSUnlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 196);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Administration_POSUnlock";
            this.Text = "Frm_Administration_POSUnlock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_POSUnlock_Update;
        private System.Windows.Forms.ComboBox cob_POSUnlock_POSName;
        private System.Windows.Forms.Label lbl_POSUnlock_POSName;
        private System.Windows.Forms.Button btn_POSUnlock_Reset;
        private System.Windows.Forms.ComboBox cob_POSUnlock_LoginStatus;
        private System.Windows.Forms.CheckBox cb_POSUnlock_ResetUserLoginStatus;
    }
}