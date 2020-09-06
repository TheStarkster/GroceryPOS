namespace Grocery.Admin.Administration
{
    partial class Frm_Administration_POSParameterSetting
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
            this.GV_POSParameterSetting_ParameterDetails = new System.Windows.Forms.DataGridView();
            this.lbl_POSParameterSetting_POSMainLocation = new System.Windows.Forms.Label();
            this.cob_POSParameterSetting_POSMainLocation = new System.Windows.Forms.ComboBox();
            this.lbl_POSParameterSetting_POSDefaultCurrency = new System.Windows.Forms.Label();
            this.cob_POSParameterSetting_POSDefaultCurrency = new System.Windows.Forms.ComboBox();
            this.cb_POSParameterSetting_CostCode = new System.Windows.Forms.CheckBox();
            this.txt_POSParameterSetting_CostCode = new System.Windows.Forms.TextBox();
            this.btn_POSParameterSetting_Save = new System.Windows.Forms.Button();
            this.btn_POSParameterSetting_Cancel = new System.Windows.Forms.Button();
            this.lbl_POSParameterSetting_TillClosingOrXReport = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GV_POSParameterSetting_ParameterDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_POSParameterSetting_ParameterDetails
            // 
            this.GV_POSParameterSetting_ParameterDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_POSParameterSetting_ParameterDetails.Location = new System.Drawing.Point(13, 13);
            this.GV_POSParameterSetting_ParameterDetails.Name = "GV_POSParameterSetting_ParameterDetails";
            this.GV_POSParameterSetting_ParameterDetails.Size = new System.Drawing.Size(458, 472);
            this.GV_POSParameterSetting_ParameterDetails.TabIndex = 0;
            // 
            // lbl_POSParameterSetting_POSMainLocation
            // 
            this.lbl_POSParameterSetting_POSMainLocation.AutoSize = true;
            this.lbl_POSParameterSetting_POSMainLocation.Location = new System.Drawing.Point(12, 499);
            this.lbl_POSParameterSetting_POSMainLocation.Name = "lbl_POSParameterSetting_POSMainLocation";
            this.lbl_POSParameterSetting_POSMainLocation.Size = new System.Drawing.Size(118, 15);
            this.lbl_POSParameterSetting_POSMainLocation.TabIndex = 1;
            this.lbl_POSParameterSetting_POSMainLocation.Text = "POS - Main Location";
            // 
            // cob_POSParameterSetting_POSMainLocation
            // 
            this.cob_POSParameterSetting_POSMainLocation.FormattingEnabled = true;
            this.cob_POSParameterSetting_POSMainLocation.Location = new System.Drawing.Point(15, 517);
            this.cob_POSParameterSetting_POSMainLocation.Name = "cob_POSParameterSetting_POSMainLocation";
            this.cob_POSParameterSetting_POSMainLocation.Size = new System.Drawing.Size(163, 23);
            this.cob_POSParameterSetting_POSMainLocation.TabIndex = 2;
            // 
            // lbl_POSParameterSetting_POSDefaultCurrency
            // 
            this.lbl_POSParameterSetting_POSDefaultCurrency.AutoSize = true;
            this.lbl_POSParameterSetting_POSDefaultCurrency.Location = new System.Drawing.Point(179, 499);
            this.lbl_POSParameterSetting_POSDefaultCurrency.Name = "lbl_POSParameterSetting_POSDefaultCurrency";
            this.lbl_POSParameterSetting_POSDefaultCurrency.Size = new System.Drawing.Size(131, 15);
            this.lbl_POSParameterSetting_POSDefaultCurrency.TabIndex = 3;
            this.lbl_POSParameterSetting_POSDefaultCurrency.Text = "POS - Default Currency";
            // 
            // cob_POSParameterSetting_POSDefaultCurrency
            // 
            this.cob_POSParameterSetting_POSDefaultCurrency.FormattingEnabled = true;
            this.cob_POSParameterSetting_POSDefaultCurrency.Location = new System.Drawing.Point(182, 517);
            this.cob_POSParameterSetting_POSDefaultCurrency.Name = "cob_POSParameterSetting_POSDefaultCurrency";
            this.cob_POSParameterSetting_POSDefaultCurrency.Size = new System.Drawing.Size(163, 23);
            this.cob_POSParameterSetting_POSDefaultCurrency.TabIndex = 4;
            // 
            // cb_POSParameterSetting_CostCode
            // 
            this.cb_POSParameterSetting_CostCode.AutoSize = true;
            this.cb_POSParameterSetting_CostCode.Location = new System.Drawing.Point(13, 547);
            this.cb_POSParameterSetting_CostCode.Name = "cb_POSParameterSetting_CostCode";
            this.cb_POSParameterSetting_CostCode.Size = new System.Drawing.Size(109, 19);
            this.cb_POSParameterSetting_CostCode.TabIndex = 5;
            this.cb_POSParameterSetting_CostCode.Text = "Cost Code (0-9)";
            this.cb_POSParameterSetting_CostCode.UseVisualStyleBackColor = true;
            // 
            // txt_POSParameterSetting_CostCode
            // 
            this.txt_POSParameterSetting_CostCode.Location = new System.Drawing.Point(182, 547);
            this.txt_POSParameterSetting_CostCode.Name = "txt_POSParameterSetting_CostCode";
            this.txt_POSParameterSetting_CostCode.Size = new System.Drawing.Size(163, 22);
            this.txt_POSParameterSetting_CostCode.TabIndex = 6;
            // 
            // btn_POSParameterSetting_Save
            // 
            this.btn_POSParameterSetting_Save.Location = new System.Drawing.Point(351, 512);
            this.btn_POSParameterSetting_Save.Name = "btn_POSParameterSetting_Save";
            this.btn_POSParameterSetting_Save.Size = new System.Drawing.Size(59, 57);
            this.btn_POSParameterSetting_Save.TabIndex = 7;
            this.btn_POSParameterSetting_Save.Text = "Save";
            this.btn_POSParameterSetting_Save.UseVisualStyleBackColor = true;
            // 
            // btn_POSParameterSetting_Cancel
            // 
            this.btn_POSParameterSetting_Cancel.Location = new System.Drawing.Point(412, 512);
            this.btn_POSParameterSetting_Cancel.Name = "btn_POSParameterSetting_Cancel";
            this.btn_POSParameterSetting_Cancel.Size = new System.Drawing.Size(59, 57);
            this.btn_POSParameterSetting_Cancel.TabIndex = 8;
            this.btn_POSParameterSetting_Cancel.Text = "Cancel";
            this.btn_POSParameterSetting_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_POSParameterSetting_TillClosingOrXReport
            // 
            this.lbl_POSParameterSetting_TillClosingOrXReport.AutoSize = true;
            this.lbl_POSParameterSetting_TillClosingOrXReport.Location = new System.Drawing.Point(236, 575);
            this.lbl_POSParameterSetting_TillClosingOrXReport.Name = "lbl_POSParameterSetting_TillClosingOrXReport";
            this.lbl_POSParameterSetting_TillClosingOrXReport.Size = new System.Drawing.Size(235, 15);
            this.lbl_POSParameterSetting_TillClosingOrXReport.TabIndex = 9;
            this.lbl_POSParameterSetting_TillClosingOrXReport.TabStop = true;
            this.lbl_POSParameterSetting_TillClosingOrXReport.Text = "Till closing / X Report Structure Defenition";
            // 
            // Frm_Administration_POSParameterSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 599);
            this.Controls.Add(this.lbl_POSParameterSetting_TillClosingOrXReport);
            this.Controls.Add(this.btn_POSParameterSetting_Cancel);
            this.Controls.Add(this.btn_POSParameterSetting_Save);
            this.Controls.Add(this.txt_POSParameterSetting_CostCode);
            this.Controls.Add(this.cb_POSParameterSetting_CostCode);
            this.Controls.Add(this.cob_POSParameterSetting_POSDefaultCurrency);
            this.Controls.Add(this.lbl_POSParameterSetting_POSDefaultCurrency);
            this.Controls.Add(this.cob_POSParameterSetting_POSMainLocation);
            this.Controls.Add(this.lbl_POSParameterSetting_POSMainLocation);
            this.Controls.Add(this.GV_POSParameterSetting_ParameterDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Administration_POSParameterSetting";
            this.Text = "Frm_Administration_POSParameterSetting";
            ((System.ComponentModel.ISupportInitialize)(this.GV_POSParameterSetting_ParameterDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_POSParameterSetting_ParameterDetails;
        private System.Windows.Forms.Label lbl_POSParameterSetting_POSMainLocation;
        private System.Windows.Forms.ComboBox cob_POSParameterSetting_POSMainLocation;
        private System.Windows.Forms.Label lbl_POSParameterSetting_POSDefaultCurrency;
        private System.Windows.Forms.ComboBox cob_POSParameterSetting_POSDefaultCurrency;
        private System.Windows.Forms.CheckBox cb_POSParameterSetting_CostCode;
        private System.Windows.Forms.TextBox txt_POSParameterSetting_CostCode;
        private System.Windows.Forms.Button btn_POSParameterSetting_Save;
        private System.Windows.Forms.Button btn_POSParameterSetting_Cancel;
        private System.Windows.Forms.LinkLabel lbl_POSParameterSetting_TillClosingOrXReport;
    }
}