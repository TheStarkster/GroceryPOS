namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_PointSearching
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
            this.cb_PointSearching_CostCenter = new System.Windows.Forms.CheckBox();
            this.cob_PointSearching_CostCenter = new System.Windows.Forms.ComboBox();
            this.lbl_PointSearching_SearchOn = new System.Windows.Forms.Label();
            this.cob_PointSearching_SearchOn = new System.Windows.Forms.ComboBox();
            this.lbl_PointSearching_Date = new System.Windows.Forms.Label();
            this.dt_PointSearching_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_PointSearching_Keyword = new System.Windows.Forms.Label();
            this.txt_PointSearching_Keyword = new System.Windows.Forms.TextBox();
            this.btn_PointSearching_SearchKeyword = new System.Windows.Forms.Button();
            this.GV_PointSearching_PointDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PointSearching_PointDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_PointSearching_SearchKeyword);
            this.panel1.Controls.Add(this.txt_PointSearching_Keyword);
            this.panel1.Controls.Add(this.lbl_PointSearching_Keyword);
            this.panel1.Controls.Add(this.dt_PointSearching_Date);
            this.panel1.Controls.Add(this.lbl_PointSearching_Date);
            this.panel1.Controls.Add(this.cob_PointSearching_SearchOn);
            this.panel1.Controls.Add(this.lbl_PointSearching_SearchOn);
            this.panel1.Controls.Add(this.cob_PointSearching_CostCenter);
            this.panel1.Controls.Add(this.cb_PointSearching_CostCenter);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 68);
            this.panel1.TabIndex = 0;
            // 
            // cb_PointSearching_CostCenter
            // 
            this.cb_PointSearching_CostCenter.AutoSize = true;
            this.cb_PointSearching_CostCenter.Location = new System.Drawing.Point(15, 10);
            this.cb_PointSearching_CostCenter.Name = "cb_PointSearching_CostCenter";
            this.cb_PointSearching_CostCenter.Size = new System.Drawing.Size(89, 19);
            this.cb_PointSearching_CostCenter.TabIndex = 0;
            this.cb_PointSearching_CostCenter.Text = "Cost Center";
            this.cb_PointSearching_CostCenter.UseVisualStyleBackColor = true;
            // 
            // cob_PointSearching_CostCenter
            // 
            this.cob_PointSearching_CostCenter.FormattingEnabled = true;
            this.cob_PointSearching_CostCenter.Location = new System.Drawing.Point(15, 35);
            this.cob_PointSearching_CostCenter.Name = "cob_PointSearching_CostCenter";
            this.cob_PointSearching_CostCenter.Size = new System.Drawing.Size(142, 23);
            this.cob_PointSearching_CostCenter.TabIndex = 1;
            // 
            // lbl_PointSearching_SearchOn
            // 
            this.lbl_PointSearching_SearchOn.AutoSize = true;
            this.lbl_PointSearching_SearchOn.Location = new System.Drawing.Point(160, 11);
            this.lbl_PointSearching_SearchOn.Name = "lbl_PointSearching_SearchOn";
            this.lbl_PointSearching_SearchOn.Size = new System.Drawing.Size(59, 15);
            this.lbl_PointSearching_SearchOn.TabIndex = 2;
            this.lbl_PointSearching_SearchOn.Text = "SearchOn";
            // 
            // cob_PointSearching_SearchOn
            // 
            this.cob_PointSearching_SearchOn.FormattingEnabled = true;
            this.cob_PointSearching_SearchOn.Location = new System.Drawing.Point(163, 35);
            this.cob_PointSearching_SearchOn.Name = "cob_PointSearching_SearchOn";
            this.cob_PointSearching_SearchOn.Size = new System.Drawing.Size(139, 23);
            this.cob_PointSearching_SearchOn.TabIndex = 3;
            // 
            // lbl_PointSearching_Date
            // 
            this.lbl_PointSearching_Date.AutoSize = true;
            this.lbl_PointSearching_Date.Location = new System.Drawing.Point(305, 11);
            this.lbl_PointSearching_Date.Name = "lbl_PointSearching_Date";
            this.lbl_PointSearching_Date.Size = new System.Drawing.Size(32, 15);
            this.lbl_PointSearching_Date.TabIndex = 4;
            this.lbl_PointSearching_Date.Text = "Date";
            // 
            // dt_PointSearching_Date
            // 
            this.dt_PointSearching_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_PointSearching_Date.Location = new System.Drawing.Point(308, 35);
            this.dt_PointSearching_Date.Name = "dt_PointSearching_Date";
            this.dt_PointSearching_Date.Size = new System.Drawing.Size(111, 22);
            this.dt_PointSearching_Date.TabIndex = 5;
            // 
            // lbl_PointSearching_Keyword
            // 
            this.lbl_PointSearching_Keyword.AutoSize = true;
            this.lbl_PointSearching_Keyword.Location = new System.Drawing.Point(424, 11);
            this.lbl_PointSearching_Keyword.Name = "lbl_PointSearching_Keyword";
            this.lbl_PointSearching_Keyword.Size = new System.Drawing.Size(56, 15);
            this.lbl_PointSearching_Keyword.TabIndex = 6;
            this.lbl_PointSearching_Keyword.Text = "Keyword";
            // 
            // txt_PointSearching_Keyword
            // 
            this.txt_PointSearching_Keyword.Location = new System.Drawing.Point(427, 35);
            this.txt_PointSearching_Keyword.Name = "txt_PointSearching_Keyword";
            this.txt_PointSearching_Keyword.Size = new System.Drawing.Size(327, 22);
            this.txt_PointSearching_Keyword.TabIndex = 7;
            // 
            // btn_PointSearching_SearchKeyword
            // 
            this.btn_PointSearching_SearchKeyword.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_PointSearching_SearchKeyword.Location = new System.Drawing.Point(760, 19);
            this.btn_PointSearching_SearchKeyword.Name = "btn_PointSearching_SearchKeyword";
            this.btn_PointSearching_SearchKeyword.Size = new System.Drawing.Size(34, 41);
            this.btn_PointSearching_SearchKeyword.TabIndex = 8;
            this.btn_PointSearching_SearchKeyword.UseVisualStyleBackColor = true;
            // 
            // GV_PointSearching_PointDetails
            // 
            this.GV_PointSearching_PointDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_PointSearching_PointDetails.Location = new System.Drawing.Point(12, 87);
            this.GV_PointSearching_PointDetails.Name = "GV_PointSearching_PointDetails";
            this.GV_PointSearching_PointDetails.Size = new System.Drawing.Size(804, 322);
            this.GV_PointSearching_PointDetails.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 52);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "&Select";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "&Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Frm_Reports_PointSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GV_PointSearching_PointDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_PointSearching";
            this.Text = "Frm_Reports_PointSearching";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PointSearching_PointDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_PointSearching_SearchKeyword;
        private System.Windows.Forms.TextBox txt_PointSearching_Keyword;
        private System.Windows.Forms.Label lbl_PointSearching_Keyword;
        private System.Windows.Forms.DateTimePicker dt_PointSearching_Date;
        private System.Windows.Forms.Label lbl_PointSearching_Date;
        private System.Windows.Forms.ComboBox cob_PointSearching_SearchOn;
        private System.Windows.Forms.Label lbl_PointSearching_SearchOn;
        private System.Windows.Forms.ComboBox cob_PointSearching_CostCenter;
        private System.Windows.Forms.CheckBox cb_PointSearching_CostCenter;
        private System.Windows.Forms.DataGridView GV_PointSearching_PointDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}