namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_StaffSalarySearch
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
            this.cb_StaffSalarySearch_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_StaffSalarySearch_CostCenter = new System.Windows.Forms.ComboBox();
            this.rb_StaffSalarySearch_TransDateFrom = new System.Windows.Forms.RadioButton();
            this.lbl_StaffSalarySearch_TransDateTo = new System.Windows.Forms.Label();
            this.dt_StaffSalarySearch_TransDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dt_StaffSalarySearch_TransDateTo = new System.Windows.Forms.DateTimePicker();
            this.rb_StaffSalarySearch_SlipNo = new System.Windows.Forms.RadioButton();
            this.rb_StaffSalarySearch_StaffID = new System.Windows.Forms.RadioButton();
            this.rb_StaffSalarySearch_StaffName = new System.Windows.Forms.RadioButton();
            this.txt_StaffSalarySearch_StaffSearch = new System.Windows.Forms.TextBox();
            this.btn_StaffSalarySearch_StaffSearch = new System.Windows.Forms.Button();
            this.GV_StaffSalarySearch_StaffSalaryDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_StaffSalarySearch_Select = new System.Windows.Forms.Button();
            this.btn_StaffSalarySearch_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_StaffSalarySearch_StaffSalaryDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_StaffSalarySearch_StaffSearch);
            this.panel1.Controls.Add(this.txt_StaffSalarySearch_StaffSearch);
            this.panel1.Controls.Add(this.rb_StaffSalarySearch_StaffName);
            this.panel1.Controls.Add(this.rb_StaffSalarySearch_StaffID);
            this.panel1.Controls.Add(this.rb_StaffSalarySearch_SlipNo);
            this.panel1.Controls.Add(this.dt_StaffSalarySearch_TransDateTo);
            this.panel1.Controls.Add(this.dt_StaffSalarySearch_TransDateFrom);
            this.panel1.Controls.Add(this.lbl_StaffSalarySearch_TransDateTo);
            this.panel1.Controls.Add(this.rb_StaffSalarySearch_TransDateFrom);
            this.panel1.Controls.Add(this.cob_StaffSalarySearch_CostCenter);
            this.panel1.Controls.Add(this.cb_StaffSalarySearch_CostCenter);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 80);
            this.panel1.TabIndex = 0;
            // 
            // cb_StaffSalarySearch_CostCenter
            // 
            this.cb_StaffSalarySearch_CostCenter.AutoSize = true;
            this.cb_StaffSalarySearch_CostCenter.Location = new System.Drawing.Point(14, 14);
            this.cb_StaffSalarySearch_CostCenter.Name = "cb_StaffSalarySearch_CostCenter";
            this.cb_StaffSalarySearch_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_StaffSalarySearch_CostCenter.TabIndex = 0;
            this.cb_StaffSalarySearch_CostCenter.Text = "Cost Center";
            this.cb_StaffSalarySearch_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_StaffSalarySearch_CostCenter
            // 
            this.cob_StaffSalarySearch_CostCenter.FormattingEnabled = true;
            this.cob_StaffSalarySearch_CostCenter.Location = new System.Drawing.Point(14, 40);
            this.cob_StaffSalarySearch_CostCenter.Name = "cob_StaffSalarySearch_CostCenter";
            this.cob_StaffSalarySearch_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_StaffSalarySearch_CostCenter.TabIndex = 1;
            // 
            // rb_StaffSalarySearch_TransDateFrom
            // 
            this.rb_StaffSalarySearch_TransDateFrom.AutoSize = true;
            this.rb_StaffSalarySearch_TransDateFrom.Location = new System.Drawing.Point(156, 15);
            this.rb_StaffSalarySearch_TransDateFrom.Name = "rb_StaffSalarySearch_TransDateFrom";
            this.rb_StaffSalarySearch_TransDateFrom.Size = new System.Drawing.Size(117, 19);
            this.rb_StaffSalarySearch_TransDateFrom.TabIndex = 2;
            this.rb_StaffSalarySearch_TransDateFrom.TabStop = true;
            this.rb_StaffSalarySearch_TransDateFrom.Text = "Trans. Date From";
            this.rb_StaffSalarySearch_TransDateFrom.UseVisualStyleBackColor = true;
            // 
            // lbl_StaffSalarySearch_TransDateTo
            // 
            this.lbl_StaffSalarySearch_TransDateTo.AutoSize = true;
            this.lbl_StaffSalarySearch_TransDateTo.Location = new System.Drawing.Point(241, 43);
            this.lbl_StaffSalarySearch_TransDateTo.Name = "lbl_StaffSalarySearch_TransDateTo";
            this.lbl_StaffSalarySearch_TransDateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_StaffSalarySearch_TransDateTo.TabIndex = 3;
            this.lbl_StaffSalarySearch_TransDateTo.Text = "To";
            // 
            // dt_StaffSalarySearch_TransDateFrom
            // 
            this.dt_StaffSalarySearch_TransDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_StaffSalarySearch_TransDateFrom.Location = new System.Drawing.Point(280, 13);
            this.dt_StaffSalarySearch_TransDateFrom.Name = "dt_StaffSalarySearch_TransDateFrom";
            this.dt_StaffSalarySearch_TransDateFrom.Size = new System.Drawing.Size(97, 22);
            this.dt_StaffSalarySearch_TransDateFrom.TabIndex = 4;
            // 
            // dt_StaffSalarySearch_TransDateTo
            // 
            this.dt_StaffSalarySearch_TransDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_StaffSalarySearch_TransDateTo.Location = new System.Drawing.Point(280, 40);
            this.dt_StaffSalarySearch_TransDateTo.Name = "dt_StaffSalarySearch_TransDateTo";
            this.dt_StaffSalarySearch_TransDateTo.Size = new System.Drawing.Size(97, 22);
            this.dt_StaffSalarySearch_TransDateTo.TabIndex = 5;
            // 
            // rb_StaffSalarySearch_SlipNo
            // 
            this.rb_StaffSalarySearch_SlipNo.AutoSize = true;
            this.rb_StaffSalarySearch_SlipNo.Location = new System.Drawing.Point(383, 17);
            this.rb_StaffSalarySearch_SlipNo.Name = "rb_StaffSalarySearch_SlipNo";
            this.rb_StaffSalarySearch_SlipNo.Size = new System.Drawing.Size(64, 19);
            this.rb_StaffSalarySearch_SlipNo.TabIndex = 6;
            this.rb_StaffSalarySearch_SlipNo.TabStop = true;
            this.rb_StaffSalarySearch_SlipNo.Text = "Slip No";
            this.rb_StaffSalarySearch_SlipNo.UseVisualStyleBackColor = true;
            // 
            // rb_StaffSalarySearch_StaffID
            // 
            this.rb_StaffSalarySearch_StaffID.AutoSize = true;
            this.rb_StaffSalarySearch_StaffID.Location = new System.Drawing.Point(383, 44);
            this.rb_StaffSalarySearch_StaffID.Name = "rb_StaffSalarySearch_StaffID";
            this.rb_StaffSalarySearch_StaffID.Size = new System.Drawing.Size(66, 19);
            this.rb_StaffSalarySearch_StaffID.TabIndex = 7;
            this.rb_StaffSalarySearch_StaffID.TabStop = true;
            this.rb_StaffSalarySearch_StaffID.Text = "Staff ID";
            this.rb_StaffSalarySearch_StaffID.UseVisualStyleBackColor = true;
            // 
            // rb_StaffSalarySearch_StaffName
            // 
            this.rb_StaffSalarySearch_StaffName.AutoSize = true;
            this.rb_StaffSalarySearch_StaffName.Location = new System.Drawing.Point(453, 17);
            this.rb_StaffSalarySearch_StaffName.Name = "rb_StaffSalarySearch_StaffName";
            this.rb_StaffSalarySearch_StaffName.Size = new System.Drawing.Size(83, 19);
            this.rb_StaffSalarySearch_StaffName.TabIndex = 8;
            this.rb_StaffSalarySearch_StaffName.TabStop = true;
            this.rb_StaffSalarySearch_StaffName.Text = "Staff Name";
            this.rb_StaffSalarySearch_StaffName.UseVisualStyleBackColor = true;
            // 
            // txt_StaffSalarySearch_StaffSearch
            // 
            this.txt_StaffSalarySearch_StaffSearch.Location = new System.Drawing.Point(456, 44);
            this.txt_StaffSalarySearch_StaffSearch.Name = "txt_StaffSalarySearch_StaffSearch";
            this.txt_StaffSalarySearch_StaffSearch.Size = new System.Drawing.Size(321, 22);
            this.txt_StaffSalarySearch_StaffSearch.TabIndex = 9;
            // 
            // btn_StaffSalarySearch_StaffSearch
            // 
            this.btn_StaffSalarySearch_StaffSearch.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_StaffSalarySearch_StaffSearch.Location = new System.Drawing.Point(783, 35);
            this.btn_StaffSalarySearch_StaffSearch.Name = "btn_StaffSalarySearch_StaffSearch";
            this.btn_StaffSalarySearch_StaffSearch.Size = new System.Drawing.Size(38, 37);
            this.btn_StaffSalarySearch_StaffSearch.TabIndex = 10;
            this.btn_StaffSalarySearch_StaffSearch.UseVisualStyleBackColor = true;
            // 
            // GV_StaffSalarySearch_StaffSalaryDetails
            // 
            this.GV_StaffSalarySearch_StaffSalaryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_StaffSalarySearch_StaffSalaryDetails.Location = new System.Drawing.Point(15, 102);
            this.GV_StaffSalarySearch_StaffSalaryDetails.Name = "GV_StaffSalarySearch_StaffSalaryDetails";
            this.GV_StaffSalarySearch_StaffSalaryDetails.Size = new System.Drawing.Size(828, 308);
            this.GV_StaffSalarySearch_StaffSalaryDetails.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_StaffSalarySearch_Close);
            this.panel2.Controls.Add(this.btn_StaffSalarySearch_Select);
            this.panel2.Location = new System.Drawing.Point(13, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 47);
            this.panel2.TabIndex = 2;
            // 
            // btn_StaffSalarySearch_Select
            // 
            this.btn_StaffSalarySearch_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StaffSalarySearch_Select.Location = new System.Drawing.Point(637, 4);
            this.btn_StaffSalarySearch_Select.Name = "btn_StaffSalarySearch_Select";
            this.btn_StaffSalarySearch_Select.Size = new System.Drawing.Size(90, 40);
            this.btn_StaffSalarySearch_Select.TabIndex = 0;
            this.btn_StaffSalarySearch_Select.Text = "&Select";
            this.btn_StaffSalarySearch_Select.UseVisualStyleBackColor = true;
            // 
            // btn_StaffSalarySearch_Close
            // 
            this.btn_StaffSalarySearch_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StaffSalarySearch_Close.Location = new System.Drawing.Point(733, 3);
            this.btn_StaffSalarySearch_Close.Name = "btn_StaffSalarySearch_Close";
            this.btn_StaffSalarySearch_Close.Size = new System.Drawing.Size(90, 40);
            this.btn_StaffSalarySearch_Close.TabIndex = 1;
            this.btn_StaffSalarySearch_Close.Text = "&Close";
            this.btn_StaffSalarySearch_Close.UseVisualStyleBackColor = true;
            // 
            // frm_Master_StaffSalarySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GV_StaffSalarySearch_StaffSalaryDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Master_StaffSalarySearch";
            this.Text = "frm_Master_StaffSalarySearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_StaffSalarySearch_StaffSalaryDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_StaffSalarySearch_StaffSearch;
        private System.Windows.Forms.TextBox txt_StaffSalarySearch_StaffSearch;
        private System.Windows.Forms.RadioButton rb_StaffSalarySearch_StaffName;
        private System.Windows.Forms.RadioButton rb_StaffSalarySearch_StaffID;
        private System.Windows.Forms.RadioButton rb_StaffSalarySearch_SlipNo;
        private System.Windows.Forms.DateTimePicker dt_StaffSalarySearch_TransDateTo;
        private System.Windows.Forms.DateTimePicker dt_StaffSalarySearch_TransDateFrom;
        private System.Windows.Forms.Label lbl_StaffSalarySearch_TransDateTo;
        private System.Windows.Forms.RadioButton rb_StaffSalarySearch_TransDateFrom;
        private System.Windows.Forms.ComboBox cob_StaffSalarySearch_CostCenter;
        private System.Windows.Forms.CheckBox cb_StaffSalarySearch_CostCenter;
        private System.Windows.Forms.DataGridView GV_StaffSalarySearch_StaffSalaryDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_StaffSalarySearch_Close;
        private System.Windows.Forms.Button btn_StaffSalarySearch_Select;
    }
}