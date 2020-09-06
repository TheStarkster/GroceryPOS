namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_StaffDetails
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
            this.GV_StaffDetails = new System.Windows.Forms.DataGridView();
            this.lbl_StaffDetails_Total = new System.Windows.Forms.Label();
            this.txt_StaffDetails_Total = new System.Windows.Forms.TextBox();
            this.btn_StaffDetails_Update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_StaffDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_StaffDetails_Update);
            this.panel1.Controls.Add(this.txt_StaffDetails_Total);
            this.panel1.Controls.Add(this.lbl_StaffDetails_Total);
            this.panel1.Controls.Add(this.GV_StaffDetails);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 328);
            this.panel1.TabIndex = 0;
            // 
            // GV_StaffDetails
            // 
            this.GV_StaffDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_StaffDetails.Location = new System.Drawing.Point(3, 3);
            this.GV_StaffDetails.Name = "GV_StaffDetails";
            this.GV_StaffDetails.Size = new System.Drawing.Size(450, 249);
            this.GV_StaffDetails.TabIndex = 0;
            // 
            // lbl_StaffDetails_Total
            // 
            this.lbl_StaffDetails_Total.AutoSize = true;
            this.lbl_StaffDetails_Total.Location = new System.Drawing.Point(280, 262);
            this.lbl_StaffDetails_Total.Name = "lbl_StaffDetails_Total";
            this.lbl_StaffDetails_Total.Size = new System.Drawing.Size(34, 15);
            this.lbl_StaffDetails_Total.TabIndex = 1;
            this.lbl_StaffDetails_Total.Text = "Total";
            // 
            // txt_StaffDetails_Total
            // 
            this.txt_StaffDetails_Total.Location = new System.Drawing.Point(320, 259);
            this.txt_StaffDetails_Total.Name = "txt_StaffDetails_Total";
            this.txt_StaffDetails_Total.Size = new System.Drawing.Size(134, 22);
            this.txt_StaffDetails_Total.TabIndex = 2;
            // 
            // btn_StaffDetails_Update
            // 
            this.btn_StaffDetails_Update.Location = new System.Drawing.Point(378, 287);
            this.btn_StaffDetails_Update.Name = "btn_StaffDetails_Update";
            this.btn_StaffDetails_Update.Size = new System.Drawing.Size(75, 32);
            this.btn_StaffDetails_Update.TabIndex = 3;
            this.btn_StaffDetails_Update.Text = "Update";
            this.btn_StaffDetails_Update.UseVisualStyleBackColor = true;
            // 
            // frm_Transactions_StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 348);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_StaffDetails";
            this.Text = "frm_Transactions_StaffDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_StaffDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_StaffDetails_Update;
        private System.Windows.Forms.TextBox txt_StaffDetails_Total;
        private System.Windows.Forms.Label lbl_StaffDetails_Total;
        private System.Windows.Forms.DataGridView GV_StaffDetails;
    }
}