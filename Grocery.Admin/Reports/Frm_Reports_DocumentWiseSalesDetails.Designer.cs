namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_DocumentWiseSalesDetails
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
            this.dt_DocumentWiseSalesDetails_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_DocumentWiseSalesDetails_DateTo = new System.Windows.Forms.Label();
            this.dt_DocumentWiseSalesDetails_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_DocumentWiseSalesDetails_DateFrom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_DocumentWiseSalesDetails_Department = new System.Windows.Forms.CheckBox();
            this.cb_DocumentWiseSalesDetails_CostCenter = new System.Windows.Forms.CheckBox();
            this.txt_DocumentWiseSalesDetails_Department = new System.Windows.Forms.TextBox();
            this.cob_DocumentWiseSalesDetails_CostCenter = new System.Windows.Forms.ComboBox();
            this.btn_DocumentWiseSalesDetails_Show = new System.Windows.Forms.Button();
            this.btn_DocumentWiseSalesDetails_Print = new System.Windows.Forms.Button();
            this.btn_DocumentWiseSalesDetails_Close = new System.Windows.Forms.Button();
            this.GV_DocumentWiseSalesDetails_DepartmentDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DocumentWiseSalesDetails_DepartmentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_DocumentWiseSalesDetails_DateTo
            // 
            this.dt_DocumentWiseSalesDetails_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DocumentWiseSalesDetails_DateTo.Location = new System.Drawing.Point(84, 41);
            this.dt_DocumentWiseSalesDetails_DateTo.Name = "dt_DocumentWiseSalesDetails_DateTo";
            this.dt_DocumentWiseSalesDetails_DateTo.Size = new System.Drawing.Size(102, 22);
            this.dt_DocumentWiseSalesDetails_DateTo.TabIndex = 7;
            // 
            // lbl_DocumentWiseSalesDetails_DateTo
            // 
            this.lbl_DocumentWiseSalesDetails_DateTo.AutoSize = true;
            this.lbl_DocumentWiseSalesDetails_DateTo.Location = new System.Drawing.Point(16, 41);
            this.lbl_DocumentWiseSalesDetails_DateTo.Name = "lbl_DocumentWiseSalesDetails_DateTo";
            this.lbl_DocumentWiseSalesDetails_DateTo.Size = new System.Drawing.Size(49, 15);
            this.lbl_DocumentWiseSalesDetails_DateTo.TabIndex = 6;
            this.lbl_DocumentWiseSalesDetails_DateTo.Text = "Date To";
            // 
            // dt_DocumentWiseSalesDetails_DateFrom
            // 
            this.dt_DocumentWiseSalesDetails_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DocumentWiseSalesDetails_DateFrom.Location = new System.Drawing.Point(84, 13);
            this.dt_DocumentWiseSalesDetails_DateFrom.Name = "dt_DocumentWiseSalesDetails_DateFrom";
            this.dt_DocumentWiseSalesDetails_DateFrom.Size = new System.Drawing.Size(102, 22);
            this.dt_DocumentWiseSalesDetails_DateFrom.TabIndex = 5;
            // 
            // lbl_DocumentWiseSalesDetails_DateFrom
            // 
            this.lbl_DocumentWiseSalesDetails_DateFrom.AutoSize = true;
            this.lbl_DocumentWiseSalesDetails_DateFrom.Location = new System.Drawing.Point(16, 13);
            this.lbl_DocumentWiseSalesDetails_DateFrom.Name = "lbl_DocumentWiseSalesDetails_DateFrom";
            this.lbl_DocumentWiseSalesDetails_DateFrom.Size = new System.Drawing.Size(62, 15);
            this.lbl_DocumentWiseSalesDetails_DateFrom.TabIndex = 4;
            this.lbl_DocumentWiseSalesDetails_DateFrom.Text = "Date From";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_DocumentWiseSalesDetails_Close);
            this.panel1.Controls.Add(this.btn_DocumentWiseSalesDetails_Print);
            this.panel1.Controls.Add(this.btn_DocumentWiseSalesDetails_Show);
            this.panel1.Controls.Add(this.cob_DocumentWiseSalesDetails_CostCenter);
            this.panel1.Controls.Add(this.txt_DocumentWiseSalesDetails_Department);
            this.panel1.Controls.Add(this.cb_DocumentWiseSalesDetails_CostCenter);
            this.panel1.Controls.Add(this.cb_DocumentWiseSalesDetails_Department);
            this.panel1.Controls.Add(this.lbl_DocumentWiseSalesDetails_DateFrom);
            this.panel1.Controls.Add(this.dt_DocumentWiseSalesDetails_DateTo);
            this.panel1.Controls.Add(this.dt_DocumentWiseSalesDetails_DateFrom);
            this.panel1.Controls.Add(this.lbl_DocumentWiseSalesDetails_DateTo);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 72);
            this.panel1.TabIndex = 8;
            // 
            // cb_DocumentWiseSalesDetails_Department
            // 
            this.cb_DocumentWiseSalesDetails_Department.AutoSize = true;
            this.cb_DocumentWiseSalesDetails_Department.Location = new System.Drawing.Point(193, 17);
            this.cb_DocumentWiseSalesDetails_Department.Name = "cb_DocumentWiseSalesDetails_Department";
            this.cb_DocumentWiseSalesDetails_Department.Size = new System.Drawing.Size(88, 19);
            this.cb_DocumentWiseSalesDetails_Department.TabIndex = 8;
            this.cb_DocumentWiseSalesDetails_Department.Text = "Department";
            this.cb_DocumentWiseSalesDetails_Department.UseVisualStyleBackColor = true;
            // 
            // cb_DocumentWiseSalesDetails_CostCenter
            // 
            this.cb_DocumentWiseSalesDetails_CostCenter.AutoSize = true;
            this.cb_DocumentWiseSalesDetails_CostCenter.Location = new System.Drawing.Point(193, 42);
            this.cb_DocumentWiseSalesDetails_CostCenter.Name = "cb_DocumentWiseSalesDetails_CostCenter";
            this.cb_DocumentWiseSalesDetails_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_DocumentWiseSalesDetails_CostCenter.TabIndex = 9;
            this.cb_DocumentWiseSalesDetails_CostCenter.Text = "Cost Center";
            this.cb_DocumentWiseSalesDetails_CostCenter.UseVisualStyleBackColor = true;
            // 
            // txt_DocumentWiseSalesDetails_Department
            // 
            this.txt_DocumentWiseSalesDetails_Department.Location = new System.Drawing.Point(288, 14);
            this.txt_DocumentWiseSalesDetails_Department.Name = "txt_DocumentWiseSalesDetails_Department";
            this.txt_DocumentWiseSalesDetails_Department.Size = new System.Drawing.Size(202, 22);
            this.txt_DocumentWiseSalesDetails_Department.TabIndex = 10;
            // 
            // cob_DocumentWiseSalesDetails_CostCenter
            // 
            this.cob_DocumentWiseSalesDetails_CostCenter.FormattingEnabled = true;
            this.cob_DocumentWiseSalesDetails_CostCenter.Location = new System.Drawing.Point(289, 41);
            this.cob_DocumentWiseSalesDetails_CostCenter.Name = "cob_DocumentWiseSalesDetails_CostCenter";
            this.cob_DocumentWiseSalesDetails_CostCenter.Size = new System.Drawing.Size(201, 23);
            this.cob_DocumentWiseSalesDetails_CostCenter.TabIndex = 11;
            // 
            // btn_DocumentWiseSalesDetails_Show
            // 
            this.btn_DocumentWiseSalesDetails_Show.Location = new System.Drawing.Point(497, 14);
            this.btn_DocumentWiseSalesDetails_Show.Name = "btn_DocumentWiseSalesDetails_Show";
            this.btn_DocumentWiseSalesDetails_Show.Size = new System.Drawing.Size(75, 49);
            this.btn_DocumentWiseSalesDetails_Show.TabIndex = 12;
            this.btn_DocumentWiseSalesDetails_Show.Text = "Show";
            this.btn_DocumentWiseSalesDetails_Show.UseVisualStyleBackColor = true;
            // 
            // btn_DocumentWiseSalesDetails_Print
            // 
            this.btn_DocumentWiseSalesDetails_Print.Location = new System.Drawing.Point(578, 14);
            this.btn_DocumentWiseSalesDetails_Print.Name = "btn_DocumentWiseSalesDetails_Print";
            this.btn_DocumentWiseSalesDetails_Print.Size = new System.Drawing.Size(75, 49);
            this.btn_DocumentWiseSalesDetails_Print.TabIndex = 13;
            this.btn_DocumentWiseSalesDetails_Print.Text = "Print";
            this.btn_DocumentWiseSalesDetails_Print.UseVisualStyleBackColor = true;
            // 
            // btn_DocumentWiseSalesDetails_Close
            // 
            this.btn_DocumentWiseSalesDetails_Close.Location = new System.Drawing.Point(659, 14);
            this.btn_DocumentWiseSalesDetails_Close.Name = "btn_DocumentWiseSalesDetails_Close";
            this.btn_DocumentWiseSalesDetails_Close.Size = new System.Drawing.Size(75, 49);
            this.btn_DocumentWiseSalesDetails_Close.TabIndex = 14;
            this.btn_DocumentWiseSalesDetails_Close.Text = "Close";
            this.btn_DocumentWiseSalesDetails_Close.UseVisualStyleBackColor = true;
            // 
            // GV_DocumentWiseSalesDetails_DepartmentDetails
            // 
            this.GV_DocumentWiseSalesDetails_DepartmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_DocumentWiseSalesDetails_DepartmentDetails.Location = new System.Drawing.Point(13, 92);
            this.GV_DocumentWiseSalesDetails_DepartmentDetails.Name = "GV_DocumentWiseSalesDetails_DepartmentDetails";
            this.GV_DocumentWiseSalesDetails_DepartmentDetails.Size = new System.Drawing.Size(908, 329);
            this.GV_DocumentWiseSalesDetails_DepartmentDetails.TabIndex = 9;
            // 
            // Frm_Reports_DocumentWiseSalesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 431);
            this.Controls.Add(this.GV_DocumentWiseSalesDetails_DepartmentDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_DocumentWiseSalesDetails";
            this.Text = "Frm_Reports_DocumentWiseSalesDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DocumentWiseSalesDetails_DepartmentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_DocumentWiseSalesDetails_DateTo;
        private System.Windows.Forms.Label lbl_DocumentWiseSalesDetails_DateTo;
        private System.Windows.Forms.DateTimePicker dt_DocumentWiseSalesDetails_DateFrom;
        private System.Windows.Forms.Label lbl_DocumentWiseSalesDetails_DateFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DocumentWiseSalesDetails_Close;
        private System.Windows.Forms.Button btn_DocumentWiseSalesDetails_Print;
        private System.Windows.Forms.Button btn_DocumentWiseSalesDetails_Show;
        private System.Windows.Forms.ComboBox cob_DocumentWiseSalesDetails_CostCenter;
        private System.Windows.Forms.TextBox txt_DocumentWiseSalesDetails_Department;
        private System.Windows.Forms.CheckBox cb_DocumentWiseSalesDetails_CostCenter;
        private System.Windows.Forms.CheckBox cb_DocumentWiseSalesDetails_Department;
        private System.Windows.Forms.DataGridView GV_DocumentWiseSalesDetails_DepartmentDetails;
    }
}