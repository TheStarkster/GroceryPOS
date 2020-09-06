namespace Grocery.Admin.Administration
{
    partial class Frm_Administration_StockEntryOrAdjustment
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
            this.lbl_StockEntryOrAdjustment_CostCenter = new System.Windows.Forms.Label();
            this.cob_StockEntryOrAdjustment_CostCenter = new System.Windows.Forms.ComboBox();
            this.lbl_StockEntryOrAdjustment_Date = new System.Windows.Forms.Label();
            this.dt_StockEntryOrAdjustment_Date = new System.Windows.Forms.DateTimePicker();
            this.cb_StockEntryOrAdjustment_AsOpeningStock = new System.Windows.Forms.CheckBox();
            this.lbl_StockEntryOrAdjustment_Description = new System.Windows.Forms.Label();
            this.txt_StockEntryOrAdjustment_Description = new System.Windows.Forms.TextBox();
            this.lbl_StockEntryOrAdjustment_ViewPreviousEntries = new System.Windows.Forms.LinkLabel();
            this.GV_StockEntryOrAdjustment_StockDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_StockEntryOrAdjustment_Delete = new System.Windows.Forms.Button();
            this.btn_StockEntryOrAdjustment_Update = new System.Windows.Forms.Button();
            this.btn_StockEntryOrAdjustment_Cancel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_StockEntryOrAdjustment_StockDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_StockEntryOrAdjustment_ViewPreviousEntries);
            this.panel1.Controls.Add(this.txt_StockEntryOrAdjustment_Description);
            this.panel1.Controls.Add(this.lbl_StockEntryOrAdjustment_Description);
            this.panel1.Controls.Add(this.cb_StockEntryOrAdjustment_AsOpeningStock);
            this.panel1.Controls.Add(this.dt_StockEntryOrAdjustment_Date);
            this.panel1.Controls.Add(this.lbl_StockEntryOrAdjustment_Date);
            this.panel1.Controls.Add(this.cob_StockEntryOrAdjustment_CostCenter);
            this.panel1.Controls.Add(this.lbl_StockEntryOrAdjustment_CostCenter);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 75);
            this.panel1.TabIndex = 0;
            // 
            // lbl_StockEntryOrAdjustment_CostCenter
            // 
            this.lbl_StockEntryOrAdjustment_CostCenter.AutoSize = true;
            this.lbl_StockEntryOrAdjustment_CostCenter.Location = new System.Drawing.Point(15, 17);
            this.lbl_StockEntryOrAdjustment_CostCenter.Name = "lbl_StockEntryOrAdjustment_CostCenter";
            this.lbl_StockEntryOrAdjustment_CostCenter.Size = new System.Drawing.Size(70, 15);
            this.lbl_StockEntryOrAdjustment_CostCenter.TabIndex = 0;
            this.lbl_StockEntryOrAdjustment_CostCenter.Text = "Cost Center";
            // 
            // cob_StockEntryOrAdjustment_CostCenter
            // 
            this.cob_StockEntryOrAdjustment_CostCenter.FormattingEnabled = true;
            this.cob_StockEntryOrAdjustment_CostCenter.Location = new System.Drawing.Point(91, 14);
            this.cob_StockEntryOrAdjustment_CostCenter.Name = "cob_StockEntryOrAdjustment_CostCenter";
            this.cob_StockEntryOrAdjustment_CostCenter.Size = new System.Drawing.Size(169, 23);
            this.cob_StockEntryOrAdjustment_CostCenter.TabIndex = 1;
            // 
            // lbl_StockEntryOrAdjustment_Date
            // 
            this.lbl_StockEntryOrAdjustment_Date.AutoSize = true;
            this.lbl_StockEntryOrAdjustment_Date.Location = new System.Drawing.Point(266, 17);
            this.lbl_StockEntryOrAdjustment_Date.Name = "lbl_StockEntryOrAdjustment_Date";
            this.lbl_StockEntryOrAdjustment_Date.Size = new System.Drawing.Size(32, 15);
            this.lbl_StockEntryOrAdjustment_Date.TabIndex = 2;
            this.lbl_StockEntryOrAdjustment_Date.Text = "Date";
            // 
            // dt_StockEntryOrAdjustment_Date
            // 
            this.dt_StockEntryOrAdjustment_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_StockEntryOrAdjustment_Date.Location = new System.Drawing.Point(304, 14);
            this.dt_StockEntryOrAdjustment_Date.Name = "dt_StockEntryOrAdjustment_Date";
            this.dt_StockEntryOrAdjustment_Date.Size = new System.Drawing.Size(103, 22);
            this.dt_StockEntryOrAdjustment_Date.TabIndex = 3;
            // 
            // cb_StockEntryOrAdjustment_AsOpeningStock
            // 
            this.cb_StockEntryOrAdjustment_AsOpeningStock.AutoSize = true;
            this.cb_StockEntryOrAdjustment_AsOpeningStock.Location = new System.Drawing.Point(414, 17);
            this.cb_StockEntryOrAdjustment_AsOpeningStock.Name = "cb_StockEntryOrAdjustment_AsOpeningStock";
            this.cb_StockEntryOrAdjustment_AsOpeningStock.Size = new System.Drawing.Size(124, 19);
            this.cb_StockEntryOrAdjustment_AsOpeningStock.TabIndex = 4;
            this.cb_StockEntryOrAdjustment_AsOpeningStock.Text = "As Opening Stock";
            this.cb_StockEntryOrAdjustment_AsOpeningStock.UseVisualStyleBackColor = true;
            // 
            // lbl_StockEntryOrAdjustment_Description
            // 
            this.lbl_StockEntryOrAdjustment_Description.AutoSize = true;
            this.lbl_StockEntryOrAdjustment_Description.Location = new System.Drawing.Point(15, 47);
            this.lbl_StockEntryOrAdjustment_Description.Name = "lbl_StockEntryOrAdjustment_Description";
            this.lbl_StockEntryOrAdjustment_Description.Size = new System.Drawing.Size(69, 15);
            this.lbl_StockEntryOrAdjustment_Description.TabIndex = 5;
            this.lbl_StockEntryOrAdjustment_Description.Text = "Description";
            // 
            // txt_StockEntryOrAdjustment_Description
            // 
            this.txt_StockEntryOrAdjustment_Description.Location = new System.Drawing.Point(91, 44);
            this.txt_StockEntryOrAdjustment_Description.Name = "txt_StockEntryOrAdjustment_Description";
            this.txt_StockEntryOrAdjustment_Description.Size = new System.Drawing.Size(316, 22);
            this.txt_StockEntryOrAdjustment_Description.TabIndex = 6;
            // 
            // lbl_StockEntryOrAdjustment_ViewPreviousEntries
            // 
            this.lbl_StockEntryOrAdjustment_ViewPreviousEntries.AutoSize = true;
            this.lbl_StockEntryOrAdjustment_ViewPreviousEntries.Location = new System.Drawing.Point(630, 47);
            this.lbl_StockEntryOrAdjustment_ViewPreviousEntries.Name = "lbl_StockEntryOrAdjustment_ViewPreviousEntries";
            this.lbl_StockEntryOrAdjustment_ViewPreviousEntries.Size = new System.Drawing.Size(122, 15);
            this.lbl_StockEntryOrAdjustment_ViewPreviousEntries.TabIndex = 7;
            this.lbl_StockEntryOrAdjustment_ViewPreviousEntries.TabStop = true;
            this.lbl_StockEntryOrAdjustment_ViewPreviousEntries.Text = "View Previous Entries";
            // 
            // GV_StockEntryOrAdjustment_StockDetails
            // 
            this.GV_StockEntryOrAdjustment_StockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_StockEntryOrAdjustment_StockDetails.Location = new System.Drawing.Point(13, 95);
            this.GV_StockEntryOrAdjustment_StockDetails.Name = "GV_StockEntryOrAdjustment_StockDetails";
            this.GV_StockEntryOrAdjustment_StockDetails.Size = new System.Drawing.Size(774, 317);
            this.GV_StockEntryOrAdjustment_StockDetails.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.btn_StockEntryOrAdjustment_Cancel);
            this.panel2.Controls.Add(this.btn_StockEntryOrAdjustment_Update);
            this.panel2.Controls.Add(this.btn_StockEntryOrAdjustment_Delete);
            this.panel2.Location = new System.Drawing.Point(13, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 48);
            this.panel2.TabIndex = 2;
            // 
            // btn_StockEntryOrAdjustment_Delete
            // 
            this.btn_StockEntryOrAdjustment_Delete.Location = new System.Drawing.Point(484, 4);
            this.btn_StockEntryOrAdjustment_Delete.Name = "btn_StockEntryOrAdjustment_Delete";
            this.btn_StockEntryOrAdjustment_Delete.Size = new System.Drawing.Size(91, 38);
            this.btn_StockEntryOrAdjustment_Delete.TabIndex = 0;
            this.btn_StockEntryOrAdjustment_Delete.Text = "&Delete";
            this.btn_StockEntryOrAdjustment_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_StockEntryOrAdjustment_Update
            // 
            this.btn_StockEntryOrAdjustment_Update.Location = new System.Drawing.Point(581, 4);
            this.btn_StockEntryOrAdjustment_Update.Name = "btn_StockEntryOrAdjustment_Update";
            this.btn_StockEntryOrAdjustment_Update.Size = new System.Drawing.Size(91, 38);
            this.btn_StockEntryOrAdjustment_Update.TabIndex = 1;
            this.btn_StockEntryOrAdjustment_Update.Text = "&Update";
            this.btn_StockEntryOrAdjustment_Update.UseVisualStyleBackColor = true;
            // 
            // btn_StockEntryOrAdjustment_Cancel
            // 
            this.btn_StockEntryOrAdjustment_Cancel.Location = new System.Drawing.Point(678, 4);
            this.btn_StockEntryOrAdjustment_Cancel.Name = "btn_StockEntryOrAdjustment_Cancel";
            this.btn_StockEntryOrAdjustment_Cancel.Size = new System.Drawing.Size(91, 38);
            this.btn_StockEntryOrAdjustment_Cancel.TabIndex = 2;
            this.btn_StockEntryOrAdjustment_Cancel.Text = "&Cancel";
            this.btn_StockEntryOrAdjustment_Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Frm_Administration_StockEntryOrAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GV_StockEntryOrAdjustment_StockDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Administration_StockEntryOrAdjustment";
            this.Text = "Frm_Administration_StockEntryOrAdjustment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_StockEntryOrAdjustment_StockDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_StockEntryOrAdjustment_ViewPreviousEntries;
        private System.Windows.Forms.TextBox txt_StockEntryOrAdjustment_Description;
        private System.Windows.Forms.Label lbl_StockEntryOrAdjustment_Description;
        private System.Windows.Forms.CheckBox cb_StockEntryOrAdjustment_AsOpeningStock;
        private System.Windows.Forms.DateTimePicker dt_StockEntryOrAdjustment_Date;
        private System.Windows.Forms.Label lbl_StockEntryOrAdjustment_Date;
        private System.Windows.Forms.ComboBox cob_StockEntryOrAdjustment_CostCenter;
        private System.Windows.Forms.Label lbl_StockEntryOrAdjustment_CostCenter;
        private System.Windows.Forms.DataGridView GV_StockEntryOrAdjustment_StockDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_StockEntryOrAdjustment_Cancel;
        private System.Windows.Forms.Button btn_StockEntryOrAdjustment_Update;
        private System.Windows.Forms.Button btn_StockEntryOrAdjustment_Delete;
    }
}