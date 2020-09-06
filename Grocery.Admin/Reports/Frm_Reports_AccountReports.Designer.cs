namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_AccountReports
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
            this.lbl_AccountReports_LastYear = new System.Windows.Forms.LinkLabel();
            this.lbl_AccountReports_LastMonth = new System.Windows.Forms.LinkLabel();
            this.lbl_AccountReports_ThisYear = new System.Windows.Forms.LinkLabel();
            this.lbl_AccountReports_ThisMonth = new System.Windows.Forms.LinkLabel();
            this.lbl_AccountReports_ThisWeek = new System.Windows.Forms.LinkLabel();
            this.lbl_AccountReports_Today = new System.Windows.Forms.LinkLabel();
            this.dt_AccountReports_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_AccountReports_DateTo = new System.Windows.Forms.Label();
            this.dt_AccountReports_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_AccountReports_DateFrom = new System.Windows.Forms.Label();
            this.cb_AccountReports_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_AccountReports_CostCenter = new System.Windows.Forms.ComboBox();
            this.tv_AccountReports_AccountTree = new System.Windows.Forms.TreeView();
            this.GV_AccountReports_AccountDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_AccountReports_AccountDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cob_AccountReports_CostCenter);
            this.panel1.Controls.Add(this.cb_AccountReports_CostCenter);
            this.panel1.Controls.Add(this.lbl_AccountReports_LastYear);
            this.panel1.Controls.Add(this.lbl_AccountReports_LastMonth);
            this.panel1.Controls.Add(this.lbl_AccountReports_ThisYear);
            this.panel1.Controls.Add(this.lbl_AccountReports_ThisMonth);
            this.panel1.Controls.Add(this.lbl_AccountReports_ThisWeek);
            this.panel1.Controls.Add(this.lbl_AccountReports_Today);
            this.panel1.Controls.Add(this.dt_AccountReports_DateTo);
            this.panel1.Controls.Add(this.lbl_AccountReports_DateTo);
            this.panel1.Controls.Add(this.dt_AccountReports_DateFrom);
            this.panel1.Controls.Add(this.lbl_AccountReports_DateFrom);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 58);
            this.panel1.TabIndex = 0;
            // 
            // lbl_AccountReports_LastYear
            // 
            this.lbl_AccountReports_LastYear.AutoSize = true;
            this.lbl_AccountReports_LastYear.Location = new System.Drawing.Point(580, 18);
            this.lbl_AccountReports_LastYear.Name = "lbl_AccountReports_LastYear";
            this.lbl_AccountReports_LastYear.Size = new System.Drawing.Size(56, 15);
            this.lbl_AccountReports_LastYear.TabIndex = 9;
            this.lbl_AccountReports_LastYear.TabStop = true;
            this.lbl_AccountReports_LastYear.Text = "Last Year";
            // 
            // lbl_AccountReports_LastMonth
            // 
            this.lbl_AccountReports_LastMonth.AutoSize = true;
            this.lbl_AccountReports_LastMonth.Location = new System.Drawing.Point(504, 18);
            this.lbl_AccountReports_LastMonth.Name = "lbl_AccountReports_LastMonth";
            this.lbl_AccountReports_LastMonth.Size = new System.Drawing.Size(70, 15);
            this.lbl_AccountReports_LastMonth.TabIndex = 8;
            this.lbl_AccountReports_LastMonth.TabStop = true;
            this.lbl_AccountReports_LastMonth.Text = "Last Month";
            // 
            // lbl_AccountReports_ThisYear
            // 
            this.lbl_AccountReports_ThisYear.AutoSize = true;
            this.lbl_AccountReports_ThisYear.Location = new System.Drawing.Point(441, 18);
            this.lbl_AccountReports_ThisYear.Name = "lbl_AccountReports_ThisYear";
            this.lbl_AccountReports_ThisYear.Size = new System.Drawing.Size(57, 15);
            this.lbl_AccountReports_ThisYear.TabIndex = 7;
            this.lbl_AccountReports_ThisYear.TabStop = true;
            this.lbl_AccountReports_ThisYear.Text = "This Year";
            // 
            // lbl_AccountReports_ThisMonth
            // 
            this.lbl_AccountReports_ThisMonth.AutoSize = true;
            this.lbl_AccountReports_ThisMonth.Location = new System.Drawing.Point(364, 18);
            this.lbl_AccountReports_ThisMonth.Name = "lbl_AccountReports_ThisMonth";
            this.lbl_AccountReports_ThisMonth.Size = new System.Drawing.Size(71, 15);
            this.lbl_AccountReports_ThisMonth.TabIndex = 6;
            this.lbl_AccountReports_ThisMonth.TabStop = true;
            this.lbl_AccountReports_ThisMonth.Text = "This Month";
            // 
            // lbl_AccountReports_ThisWeek
            // 
            this.lbl_AccountReports_ThisWeek.AutoSize = true;
            this.lbl_AccountReports_ThisWeek.Location = new System.Drawing.Point(294, 18);
            this.lbl_AccountReports_ThisWeek.Name = "lbl_AccountReports_ThisWeek";
            this.lbl_AccountReports_ThisWeek.Size = new System.Drawing.Size(64, 15);
            this.lbl_AccountReports_ThisWeek.TabIndex = 5;
            this.lbl_AccountReports_ThisWeek.TabStop = true;
            this.lbl_AccountReports_ThisWeek.Text = "This Week";
            // 
            // lbl_AccountReports_Today
            // 
            this.lbl_AccountReports_Today.AutoSize = true;
            this.lbl_AccountReports_Today.Location = new System.Drawing.Point(247, 18);
            this.lbl_AccountReports_Today.Name = "lbl_AccountReports_Today";
            this.lbl_AccountReports_Today.Size = new System.Drawing.Size(41, 15);
            this.lbl_AccountReports_Today.TabIndex = 4;
            this.lbl_AccountReports_Today.TabStop = true;
            this.lbl_AccountReports_Today.Text = "Today";
            // 
            // dt_AccountReports_DateTo
            // 
            this.dt_AccountReports_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_AccountReports_DateTo.Location = new System.Drawing.Point(121, 27);
            this.dt_AccountReports_DateTo.Name = "dt_AccountReports_DateTo";
            this.dt_AccountReports_DateTo.Size = new System.Drawing.Size(102, 22);
            this.dt_AccountReports_DateTo.TabIndex = 3;
            // 
            // lbl_AccountReports_DateTo
            // 
            this.lbl_AccountReports_DateTo.AutoSize = true;
            this.lbl_AccountReports_DateTo.Location = new System.Drawing.Point(118, 9);
            this.lbl_AccountReports_DateTo.Name = "lbl_AccountReports_DateTo";
            this.lbl_AccountReports_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_AccountReports_DateTo.TabIndex = 2;
            this.lbl_AccountReports_DateTo.Text = "To";
            // 
            // dt_AccountReports_DateFrom
            // 
            this.dt_AccountReports_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_AccountReports_DateFrom.Location = new System.Drawing.Point(6, 27);
            this.dt_AccountReports_DateFrom.Name = "dt_AccountReports_DateFrom";
            this.dt_AccountReports_DateFrom.Size = new System.Drawing.Size(102, 22);
            this.dt_AccountReports_DateFrom.TabIndex = 1;
            // 
            // lbl_AccountReports_DateFrom
            // 
            this.lbl_AccountReports_DateFrom.AutoSize = true;
            this.lbl_AccountReports_DateFrom.Location = new System.Drawing.Point(3, 9);
            this.lbl_AccountReports_DateFrom.Name = "lbl_AccountReports_DateFrom";
            this.lbl_AccountReports_DateFrom.Size = new System.Drawing.Size(34, 15);
            this.lbl_AccountReports_DateFrom.TabIndex = 0;
            this.lbl_AccountReports_DateFrom.Text = "From";
            // 
            // cb_AccountReports_CostCenter
            // 
            this.cb_AccountReports_CostCenter.AutoSize = true;
            this.cb_AccountReports_CostCenter.Location = new System.Drawing.Point(679, 15);
            this.cb_AccountReports_CostCenter.Name = "cb_AccountReports_CostCenter";
            this.cb_AccountReports_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_AccountReports_CostCenter.TabIndex = 10;
            this.cb_AccountReports_CostCenter.Text = "Cost Center";
            this.cb_AccountReports_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_AccountReports_CostCenter
            // 
            this.cob_AccountReports_CostCenter.FormattingEnabled = true;
            this.cob_AccountReports_CostCenter.Location = new System.Drawing.Point(775, 15);
            this.cob_AccountReports_CostCenter.Name = "cob_AccountReports_CostCenter";
            this.cob_AccountReports_CostCenter.Size = new System.Drawing.Size(121, 23);
            this.cob_AccountReports_CostCenter.TabIndex = 11;
            // 
            // tv_AccountReports_AccountTree
            // 
            this.tv_AccountReports_AccountTree.Location = new System.Drawing.Point(13, 78);
            this.tv_AccountReports_AccountTree.Name = "tv_AccountReports_AccountTree";
            this.tv_AccountReports_AccountTree.Size = new System.Drawing.Size(274, 429);
            this.tv_AccountReports_AccountTree.TabIndex = 1;
            // 
            // GV_AccountReports_AccountDetails
            // 
            this.GV_AccountReports_AccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_AccountReports_AccountDetails.Location = new System.Drawing.Point(294, 78);
            this.GV_AccountReports_AccountDetails.Name = "GV_AccountReports_AccountDetails";
            this.GV_AccountReports_AccountDetails.Size = new System.Drawing.Size(623, 429);
            this.GV_AccountReports_AccountDetails.TabIndex = 2;
            // 
            // Frm_Reports_AccountReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 519);
            this.Controls.Add(this.GV_AccountReports_AccountDetails);
            this.Controls.Add(this.tv_AccountReports_AccountTree);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_AccountReports";
            this.Text = "Frm_Reports_AccountReports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_AccountReports_AccountDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_AccountReports_LastYear;
        private System.Windows.Forms.LinkLabel lbl_AccountReports_LastMonth;
        private System.Windows.Forms.LinkLabel lbl_AccountReports_ThisYear;
        private System.Windows.Forms.LinkLabel lbl_AccountReports_ThisMonth;
        private System.Windows.Forms.LinkLabel lbl_AccountReports_ThisWeek;
        private System.Windows.Forms.LinkLabel lbl_AccountReports_Today;
        private System.Windows.Forms.DateTimePicker dt_AccountReports_DateTo;
        private System.Windows.Forms.Label lbl_AccountReports_DateTo;
        private System.Windows.Forms.DateTimePicker dt_AccountReports_DateFrom;
        private System.Windows.Forms.Label lbl_AccountReports_DateFrom;
        private System.Windows.Forms.ComboBox cob_AccountReports_CostCenter;
        private System.Windows.Forms.CheckBox cb_AccountReports_CostCenter;
        private System.Windows.Forms.TreeView tv_AccountReports_AccountTree;
        private System.Windows.Forms.DataGridView GV_AccountReports_AccountDetails;
    }
}