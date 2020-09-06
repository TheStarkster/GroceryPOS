namespace Grocery.Admin.Master
{
    partial class Frm_Master_ItemSearch
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
            this.lbl_ItemSearch_SearchOn = new System.Windows.Forms.Label();
            this.cob_ItemSearch_SearchOn = new System.Windows.Forms.ComboBox();
            this.lbl_ItemSearch_Keyword = new System.Windows.Forms.Label();
            this.txt_ItemSearch_Keyword = new System.Windows.Forms.TextBox();
            this.btn_ItemSearch_KeywordSrch = new System.Windows.Forms.Button();
            this.GV_ItemSearch_ItemDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ItemSearch_Select = new System.Windows.Forms.Button();
            this.btn_ItemSearch_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemSearch_ItemDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ItemSearch_KeywordSrch);
            this.panel1.Controls.Add(this.txt_ItemSearch_Keyword);
            this.panel1.Controls.Add(this.lbl_ItemSearch_Keyword);
            this.panel1.Controls.Add(this.cob_ItemSearch_SearchOn);
            this.panel1.Controls.Add(this.lbl_ItemSearch_SearchOn);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 54);
            this.panel1.TabIndex = 0;
            // 
            // lbl_ItemSearch_SearchOn
            // 
            this.lbl_ItemSearch_SearchOn.AutoSize = true;
            this.lbl_ItemSearch_SearchOn.Location = new System.Drawing.Point(3, 17);
            this.lbl_ItemSearch_SearchOn.Name = "lbl_ItemSearch_SearchOn";
            this.lbl_ItemSearch_SearchOn.Size = new System.Drawing.Size(65, 15);
            this.lbl_ItemSearch_SearchOn.TabIndex = 0;
            this.lbl_ItemSearch_SearchOn.Text = "Search On:";
            // 
            // cob_ItemSearch_SearchOn
            // 
            this.cob_ItemSearch_SearchOn.FormattingEnabled = true;
            this.cob_ItemSearch_SearchOn.Location = new System.Drawing.Point(74, 14);
            this.cob_ItemSearch_SearchOn.Name = "cob_ItemSearch_SearchOn";
            this.cob_ItemSearch_SearchOn.Size = new System.Drawing.Size(167, 23);
            this.cob_ItemSearch_SearchOn.TabIndex = 1;
            // 
            // lbl_ItemSearch_Keyword
            // 
            this.lbl_ItemSearch_Keyword.AutoSize = true;
            this.lbl_ItemSearch_Keyword.Location = new System.Drawing.Point(348, 20);
            this.lbl_ItemSearch_Keyword.Name = "lbl_ItemSearch_Keyword";
            this.lbl_ItemSearch_Keyword.Size = new System.Drawing.Size(59, 15);
            this.lbl_ItemSearch_Keyword.TabIndex = 2;
            this.lbl_ItemSearch_Keyword.Text = "Keyword:";
            // 
            // txt_ItemSearch_Keyword
            // 
            this.txt_ItemSearch_Keyword.Location = new System.Drawing.Point(413, 17);
            this.txt_ItemSearch_Keyword.Name = "txt_ItemSearch_Keyword";
            this.txt_ItemSearch_Keyword.Size = new System.Drawing.Size(420, 22);
            this.txt_ItemSearch_Keyword.TabIndex = 3;
            // 
            // btn_ItemSearch_KeywordSrch
            // 
            this.btn_ItemSearch_KeywordSrch.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_ItemSearch_KeywordSrch.Location = new System.Drawing.Point(839, 9);
            this.btn_ItemSearch_KeywordSrch.Name = "btn_ItemSearch_KeywordSrch";
            this.btn_ItemSearch_KeywordSrch.Size = new System.Drawing.Size(39, 37);
            this.btn_ItemSearch_KeywordSrch.TabIndex = 4;
            this.btn_ItemSearch_KeywordSrch.UseVisualStyleBackColor = true;
            // 
            // GV_ItemSearch_ItemDetails
            // 
            this.GV_ItemSearch_ItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ItemSearch_ItemDetails.Location = new System.Drawing.Point(13, 76);
            this.GV_ItemSearch_ItemDetails.Name = "GV_ItemSearch_ItemDetails";
            this.GV_ItemSearch_ItemDetails.Size = new System.Drawing.Size(906, 306);
            this.GV_ItemSearch_ItemDetails.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_ItemSearch_Close);
            this.panel2.Controls.Add(this.btn_ItemSearch_Select);
            this.panel2.Location = new System.Drawing.Point(17, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 45);
            this.panel2.TabIndex = 2;
            // 
            // btn_ItemSearch_Select
            // 
            this.btn_ItemSearch_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ItemSearch_Select.Location = new System.Drawing.Point(363, 3);
            this.btn_ItemSearch_Select.Name = "btn_ItemSearch_Select";
            this.btn_ItemSearch_Select.Size = new System.Drawing.Size(105, 36);
            this.btn_ItemSearch_Select.TabIndex = 0;
            this.btn_ItemSearch_Select.Text = "&Select";
            this.btn_ItemSearch_Select.UseVisualStyleBackColor = true;
            // 
            // btn_ItemSearch_Close
            // 
            this.btn_ItemSearch_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ItemSearch_Close.Location = new System.Drawing.Point(474, 3);
            this.btn_ItemSearch_Close.Name = "btn_ItemSearch_Close";
            this.btn_ItemSearch_Close.Size = new System.Drawing.Size(105, 36);
            this.btn_ItemSearch_Close.TabIndex = 1;
            this.btn_ItemSearch_Close.Text = "&Close";
            this.btn_ItemSearch_Close.UseVisualStyleBackColor = true;
            // 
            // Frm_Master_ItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 445);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GV_ItemSearch_ItemDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Master_ItemSearch";
            this.Text = "Frm_Master_ItemSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemSearch_ItemDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ItemSearch_KeywordSrch;
        private System.Windows.Forms.TextBox txt_ItemSearch_Keyword;
        private System.Windows.Forms.Label lbl_ItemSearch_Keyword;
        private System.Windows.Forms.ComboBox cob_ItemSearch_SearchOn;
        private System.Windows.Forms.Label lbl_ItemSearch_SearchOn;
        private System.Windows.Forms.DataGridView GV_ItemSearch_ItemDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ItemSearch_Close;
        private System.Windows.Forms.Button btn_ItemSearch_Select;
    }
}