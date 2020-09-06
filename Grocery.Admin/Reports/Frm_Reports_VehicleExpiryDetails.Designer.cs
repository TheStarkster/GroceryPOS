namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_VehicleExpiryDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.GV_VehicleExpiryDetails_VehicleDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV_VehicleExpiryDetails_VehicleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Expiry Details";
            // 
            // GV_VehicleExpiryDetails_VehicleDetails
            // 
            this.GV_VehicleExpiryDetails_VehicleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_VehicleExpiryDetails_VehicleDetails.Location = new System.Drawing.Point(13, 36);
            this.GV_VehicleExpiryDetails_VehicleDetails.Name = "GV_VehicleExpiryDetails_VehicleDetails";
            this.GV_VehicleExpiryDetails_VehicleDetails.Size = new System.Drawing.Size(721, 316);
            this.GV_VehicleExpiryDetails_VehicleDetails.TabIndex = 1;
            // 
            // Frm_Reports_VehicleExpiryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 362);
            this.Controls.Add(this.GV_VehicleExpiryDetails_VehicleDetails);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_VehicleExpiryDetails";
            this.Text = "Frm_Reports_VehicleExpiryDetails";
            ((System.ComponentModel.ISupportInitialize)(this.GV_VehicleExpiryDetails_VehicleDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GV_VehicleExpiryDetails_VehicleDetails;
    }
}