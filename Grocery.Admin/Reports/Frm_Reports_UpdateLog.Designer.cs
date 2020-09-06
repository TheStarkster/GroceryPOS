namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_UpdateLog
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
            this.gb_UpdateLog_Date = new System.Windows.Forms.GroupBox();
            this.lbl_UpdateLog_DateFrom = new System.Windows.Forms.Label();
            this.dt_UpdateLog_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.dt_UpdateLog_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_UpdateLog_DateTo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_UpdateLog_ActivityName = new System.Windows.Forms.RadioButton();
            this.rb_UpdateLog_TableID = new System.Windows.Forms.RadioButton();
            this.rb_UpdateLog_TableName = new System.Windows.Forms.RadioButton();
            this.rb_UpdateLog_DoneBy = new System.Windows.Forms.RadioButton();
            this.txt_UpdateLog_Activity = new System.Windows.Forms.TextBox();
            this.btn_UpdateLog_SearchActivity = new System.Windows.Forms.Button();
            this.GV_UpdateLog_ActivitDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_UpdateLog_Ok = new System.Windows.Forms.Button();
            this.btn_UpdateLog_Cancel = new System.Windows.Forms.Button();
            this.gb_UpdateLog_Date.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_UpdateLog_ActivitDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_UpdateLog_Date
            // 
            this.gb_UpdateLog_Date.Controls.Add(this.dt_UpdateLog_DateTo);
            this.gb_UpdateLog_Date.Controls.Add(this.lbl_UpdateLog_DateTo);
            this.gb_UpdateLog_Date.Controls.Add(this.dt_UpdateLog_DateFrom);
            this.gb_UpdateLog_Date.Controls.Add(this.lbl_UpdateLog_DateFrom);
            this.gb_UpdateLog_Date.Location = new System.Drawing.Point(12, 12);
            this.gb_UpdateLog_Date.Name = "gb_UpdateLog_Date";
            this.gb_UpdateLog_Date.Size = new System.Drawing.Size(166, 80);
            this.gb_UpdateLog_Date.TabIndex = 0;
            this.gb_UpdateLog_Date.TabStop = false;
            this.gb_UpdateLog_Date.Text = "Date";
            // 
            // lbl_UpdateLog_DateFrom
            // 
            this.lbl_UpdateLog_DateFrom.AutoSize = true;
            this.lbl_UpdateLog_DateFrom.Location = new System.Drawing.Point(7, 22);
            this.lbl_UpdateLog_DateFrom.Name = "lbl_UpdateLog_DateFrom";
            this.lbl_UpdateLog_DateFrom.Size = new System.Drawing.Size(34, 15);
            this.lbl_UpdateLog_DateFrom.TabIndex = 0;
            this.lbl_UpdateLog_DateFrom.Text = "From";
            // 
            // dt_UpdateLog_DateFrom
            // 
            this.dt_UpdateLog_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_UpdateLog_DateFrom.Location = new System.Drawing.Point(48, 22);
            this.dt_UpdateLog_DateFrom.Name = "dt_UpdateLog_DateFrom";
            this.dt_UpdateLog_DateFrom.Size = new System.Drawing.Size(109, 22);
            this.dt_UpdateLog_DateFrom.TabIndex = 1;
            // 
            // dt_UpdateLog_DateTo
            // 
            this.dt_UpdateLog_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_UpdateLog_DateTo.Location = new System.Drawing.Point(48, 50);
            this.dt_UpdateLog_DateTo.Name = "dt_UpdateLog_DateTo";
            this.dt_UpdateLog_DateTo.Size = new System.Drawing.Size(109, 22);
            this.dt_UpdateLog_DateTo.TabIndex = 3;
            // 
            // lbl_UpdateLog_DateTo
            // 
            this.lbl_UpdateLog_DateTo.AutoSize = true;
            this.lbl_UpdateLog_DateTo.Location = new System.Drawing.Point(7, 50);
            this.lbl_UpdateLog_DateTo.Name = "lbl_UpdateLog_DateTo";
            this.lbl_UpdateLog_DateTo.Size = new System.Drawing.Size(21, 15);
            this.lbl_UpdateLog_DateTo.TabIndex = 2;
            this.lbl_UpdateLog_DateTo.Text = "To";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_UpdateLog_SearchActivity);
            this.panel1.Controls.Add(this.txt_UpdateLog_Activity);
            this.panel1.Controls.Add(this.rb_UpdateLog_DoneBy);
            this.panel1.Controls.Add(this.rb_UpdateLog_TableName);
            this.panel1.Controls.Add(this.rb_UpdateLog_TableID);
            this.panel1.Controls.Add(this.rb_UpdateLog_ActivityName);
            this.panel1.Controls.Add(this.gb_UpdateLog_Date);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 97);
            this.panel1.TabIndex = 1;
            // 
            // rb_UpdateLog_ActivityName
            // 
            this.rb_UpdateLog_ActivityName.AutoSize = true;
            this.rb_UpdateLog_ActivityName.Location = new System.Drawing.Point(194, 30);
            this.rb_UpdateLog_ActivityName.Name = "rb_UpdateLog_ActivityName";
            this.rb_UpdateLog_ActivityName.Size = new System.Drawing.Size(102, 19);
            this.rb_UpdateLog_ActivityName.TabIndex = 1;
            this.rb_UpdateLog_ActivityName.TabStop = true;
            this.rb_UpdateLog_ActivityName.Text = "Activity Name";
            this.rb_UpdateLog_ActivityName.UseVisualStyleBackColor = true;
            // 
            // rb_UpdateLog_TableID
            // 
            this.rb_UpdateLog_TableID.AutoSize = true;
            this.rb_UpdateLog_TableID.Location = new System.Drawing.Point(311, 30);
            this.rb_UpdateLog_TableID.Name = "rb_UpdateLog_TableID";
            this.rb_UpdateLog_TableID.Size = new System.Drawing.Size(70, 19);
            this.rb_UpdateLog_TableID.TabIndex = 2;
            this.rb_UpdateLog_TableID.TabStop = true;
            this.rb_UpdateLog_TableID.Text = "Table ID";
            this.rb_UpdateLog_TableID.UseVisualStyleBackColor = true;
            // 
            // rb_UpdateLog_TableName
            // 
            this.rb_UpdateLog_TableName.AutoSize = true;
            this.rb_UpdateLog_TableName.Location = new System.Drawing.Point(403, 30);
            this.rb_UpdateLog_TableName.Name = "rb_UpdateLog_TableName";
            this.rb_UpdateLog_TableName.Size = new System.Drawing.Size(87, 19);
            this.rb_UpdateLog_TableName.TabIndex = 3;
            this.rb_UpdateLog_TableName.TabStop = true;
            this.rb_UpdateLog_TableName.Text = "Table Name";
            this.rb_UpdateLog_TableName.UseVisualStyleBackColor = true;
            // 
            // rb_UpdateLog_DoneBy
            // 
            this.rb_UpdateLog_DoneBy.AutoSize = true;
            this.rb_UpdateLog_DoneBy.Location = new System.Drawing.Point(507, 30);
            this.rb_UpdateLog_DoneBy.Name = "rb_UpdateLog_DoneBy";
            this.rb_UpdateLog_DoneBy.Size = new System.Drawing.Size(72, 19);
            this.rb_UpdateLog_DoneBy.TabIndex = 4;
            this.rb_UpdateLog_DoneBy.TabStop = true;
            this.rb_UpdateLog_DoneBy.Text = "Done By";
            this.rb_UpdateLog_DoneBy.UseVisualStyleBackColor = true;
            // 
            // txt_UpdateLog_Activity
            // 
            this.txt_UpdateLog_Activity.Location = new System.Drawing.Point(194, 56);
            this.txt_UpdateLog_Activity.Name = "txt_UpdateLog_Activity";
            this.txt_UpdateLog_Activity.Size = new System.Drawing.Size(385, 22);
            this.txt_UpdateLog_Activity.TabIndex = 5;
            // 
            // btn_UpdateLog_SearchActivity
            // 
            this.btn_UpdateLog_SearchActivity.Location = new System.Drawing.Point(585, 47);
            this.btn_UpdateLog_SearchActivity.Name = "btn_UpdateLog_SearchActivity";
            this.btn_UpdateLog_SearchActivity.Size = new System.Drawing.Size(75, 30);
            this.btn_UpdateLog_SearchActivity.TabIndex = 6;
            this.btn_UpdateLog_SearchActivity.Text = "Search";
            this.btn_UpdateLog_SearchActivity.UseVisualStyleBackColor = true;
            // 
            // GV_UpdateLog_ActivitDetails
            // 
            this.GV_UpdateLog_ActivitDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_UpdateLog_ActivitDetails.Location = new System.Drawing.Point(13, 117);
            this.GV_UpdateLog_ActivitDetails.Name = "GV_UpdateLog_ActivitDetails";
            this.GV_UpdateLog_ActivitDetails.Size = new System.Drawing.Size(712, 249);
            this.GV_UpdateLog_ActivitDetails.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_UpdateLog_Cancel);
            this.panel2.Controls.Add(this.btn_UpdateLog_Ok);
            this.panel2.Location = new System.Drawing.Point(13, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 50);
            this.panel2.TabIndex = 3;
            // 
            // btn_UpdateLog_Ok
            // 
            this.btn_UpdateLog_Ok.Location = new System.Drawing.Point(517, 3);
            this.btn_UpdateLog_Ok.Name = "btn_UpdateLog_Ok";
            this.btn_UpdateLog_Ok.Size = new System.Drawing.Size(92, 40);
            this.btn_UpdateLog_Ok.TabIndex = 0;
            this.btn_UpdateLog_Ok.Text = "OK";
            this.btn_UpdateLog_Ok.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateLog_Cancel
            // 
            this.btn_UpdateLog_Cancel.Location = new System.Drawing.Point(615, 3);
            this.btn_UpdateLog_Cancel.Name = "btn_UpdateLog_Cancel";
            this.btn_UpdateLog_Cancel.Size = new System.Drawing.Size(92, 40);
            this.btn_UpdateLog_Cancel.TabIndex = 1;
            this.btn_UpdateLog_Cancel.Text = "Cancel";
            this.btn_UpdateLog_Cancel.UseVisualStyleBackColor = true;
            // 
            // Frm_Reports_UpdateLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GV_UpdateLog_ActivitDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_UpdateLog";
            this.Text = "Frm_Reports_UpdateLog";
            this.gb_UpdateLog_Date.ResumeLayout(false);
            this.gb_UpdateLog_Date.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_UpdateLog_ActivitDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_UpdateLog_Date;
        private System.Windows.Forms.DateTimePicker dt_UpdateLog_DateTo;
        private System.Windows.Forms.Label lbl_UpdateLog_DateTo;
        private System.Windows.Forms.DateTimePicker dt_UpdateLog_DateFrom;
        private System.Windows.Forms.Label lbl_UpdateLog_DateFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_UpdateLog_SearchActivity;
        private System.Windows.Forms.TextBox txt_UpdateLog_Activity;
        private System.Windows.Forms.RadioButton rb_UpdateLog_DoneBy;
        private System.Windows.Forms.RadioButton rb_UpdateLog_TableName;
        private System.Windows.Forms.RadioButton rb_UpdateLog_TableID;
        private System.Windows.Forms.RadioButton rb_UpdateLog_ActivityName;
        private System.Windows.Forms.DataGridView GV_UpdateLog_ActivitDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_UpdateLog_Cancel;
        private System.Windows.Forms.Button btn_UpdateLog_Ok;
    }
}