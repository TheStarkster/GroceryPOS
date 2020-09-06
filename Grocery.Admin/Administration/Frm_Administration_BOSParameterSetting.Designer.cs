namespace Grocery.Admin.Administration
{
    partial class Frm_Administration_BOSParameterSetting
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
            this.GV_BOSParameterSetting_ParameterDetails = new System.Windows.Forms.DataGridView();
            this.btn_BOSParameterSetting_Save = new System.Windows.Forms.Button();
            this.btn_BOSParameterSetting_Cancel = new System.Windows.Forms.Button();
            this.lbl_BOSParameterSetting_ArabicDescription = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BOSParameterSetting_ParameterDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BOSParameterSetting_ParameterDetails
            // 
            this.GV_BOSParameterSetting_ParameterDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BOSParameterSetting_ParameterDetails.Location = new System.Drawing.Point(13, 13);
            this.GV_BOSParameterSetting_ParameterDetails.Name = "GV_BOSParameterSetting_ParameterDetails";
            this.GV_BOSParameterSetting_ParameterDetails.Size = new System.Drawing.Size(459, 432);
            this.GV_BOSParameterSetting_ParameterDetails.TabIndex = 0;
            // 
            // btn_BOSParameterSetting_Save
            // 
            this.btn_BOSParameterSetting_Save.Location = new System.Drawing.Point(292, 451);
            this.btn_BOSParameterSetting_Save.Name = "btn_BOSParameterSetting_Save";
            this.btn_BOSParameterSetting_Save.Size = new System.Drawing.Size(87, 43);
            this.btn_BOSParameterSetting_Save.TabIndex = 1;
            this.btn_BOSParameterSetting_Save.Text = "Save";
            this.btn_BOSParameterSetting_Save.UseVisualStyleBackColor = true;
            // 
            // btn_BOSParameterSetting_Cancel
            // 
            this.btn_BOSParameterSetting_Cancel.Location = new System.Drawing.Point(385, 451);
            this.btn_BOSParameterSetting_Cancel.Name = "btn_BOSParameterSetting_Cancel";
            this.btn_BOSParameterSetting_Cancel.Size = new System.Drawing.Size(87, 43);
            this.btn_BOSParameterSetting_Cancel.TabIndex = 2;
            this.btn_BOSParameterSetting_Cancel.Text = "Cancel";
            this.btn_BOSParameterSetting_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_BOSParameterSetting_ArabicDescription
            // 
            this.lbl_BOSParameterSetting_ArabicDescription.AutoSize = true;
            this.lbl_BOSParameterSetting_ArabicDescription.Location = new System.Drawing.Point(12, 465);
            this.lbl_BOSParameterSetting_ArabicDescription.Name = "lbl_BOSParameterSetting_ArabicDescription";
            this.lbl_BOSParameterSetting_ArabicDescription.Size = new System.Drawing.Size(185, 15);
            this.lbl_BOSParameterSetting_ArabicDescription.TabIndex = 3;
            this.lbl_BOSParameterSetting_ArabicDescription.TabStop = true;
            this.lbl_BOSParameterSetting_ArabicDescription.Text = "Arabic Description Against Items";
            // 
            // Frm_Administration_BOSParameterSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 495);
            this.Controls.Add(this.lbl_BOSParameterSetting_ArabicDescription);
            this.Controls.Add(this.btn_BOSParameterSetting_Cancel);
            this.Controls.Add(this.btn_BOSParameterSetting_Save);
            this.Controls.Add(this.GV_BOSParameterSetting_ParameterDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Administration_BOSParameterSetting";
            this.Text = "Frm_Administration_BOSParameterSetting";
            ((System.ComponentModel.ISupportInitialize)(this.GV_BOSParameterSetting_ParameterDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BOSParameterSetting_ParameterDetails;
        private System.Windows.Forms.Button btn_BOSParameterSetting_Save;
        private System.Windows.Forms.Button btn_BOSParameterSetting_Cancel;
        private System.Windows.Forms.LinkLabel lbl_BOSParameterSetting_ArabicDescription;
    }
}