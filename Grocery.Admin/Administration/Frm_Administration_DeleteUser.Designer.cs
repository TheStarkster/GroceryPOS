namespace Grocery.Admin.Administration
{
    partial class Frm_Administration_DeleteUser
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
            this.GV_DeleteUser_UserDetails = new System.Windows.Forms.DataGridView();
            this.btn_DeleteUser_Delete = new System.Windows.Forms.Button();
            this.btn_DeleteUser_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DeleteUser_UserDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_DeleteUser_UserDetails
            // 
            this.GV_DeleteUser_UserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_DeleteUser_UserDetails.Location = new System.Drawing.Point(10, 10);
            this.GV_DeleteUser_UserDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GV_DeleteUser_UserDetails.Name = "GV_DeleteUser_UserDetails";
            this.GV_DeleteUser_UserDetails.Size = new System.Drawing.Size(341, 156);
            this.GV_DeleteUser_UserDetails.TabIndex = 0;
            // 
            // btn_DeleteUser_Delete
            // 
            this.btn_DeleteUser_Delete.Location = new System.Drawing.Point(205, 170);
            this.btn_DeleteUser_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteUser_Delete.Name = "btn_DeleteUser_Delete";
            this.btn_DeleteUser_Delete.Size = new System.Drawing.Size(71, 32);
            this.btn_DeleteUser_Delete.TabIndex = 1;
            this.btn_DeleteUser_Delete.Text = "&Delete";
            this.btn_DeleteUser_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteUser_Cancel
            // 
            this.btn_DeleteUser_Cancel.Location = new System.Drawing.Point(280, 170);
            this.btn_DeleteUser_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteUser_Cancel.Name = "btn_DeleteUser_Cancel";
            this.btn_DeleteUser_Cancel.Size = new System.Drawing.Size(71, 32);
            this.btn_DeleteUser_Cancel.TabIndex = 2;
            this.btn_DeleteUser_Cancel.Text = "&Cancel";
            this.btn_DeleteUser_Cancel.UseVisualStyleBackColor = true;
            // 
            // Frm_Administration_DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 214);
            this.Controls.Add(this.btn_DeleteUser_Cancel);
            this.Controls.Add(this.btn_DeleteUser_Delete);
            this.Controls.Add(this.GV_DeleteUser_UserDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Administration_DeleteUser";
            this.Text = "Frm_Administration_DeleteUser";
            ((System.ComponentModel.ISupportInitialize)(this.GV_DeleteUser_UserDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_DeleteUser_UserDetails;
        private System.Windows.Forms.Button btn_DeleteUser_Delete;
        private System.Windows.Forms.Button btn_DeleteUser_Cancel;
    }
}