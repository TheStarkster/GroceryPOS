namespace Grocery.Admin.Common
{
    partial class frm_Common_List
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
            this.txt_KeyWord = new System.Windows.Forms.TextBox();
            this.lbl_Currency = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_KeyWord);
            this.panel1.Controls.Add(this.lbl_Currency);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 31);
            this.panel1.TabIndex = 0;
            // 
            // txt_KeyWord
            // 
            this.txt_KeyWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_KeyWord.Location = new System.Drawing.Point(128, 6);
            this.txt_KeyWord.Name = "txt_KeyWord";
            this.txt_KeyWord.Size = new System.Drawing.Size(518, 20);
            this.txt_KeyWord.TabIndex = 15;
            this.txt_KeyWord.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            this.txt_KeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyWord_KeyPress);
            // 
            // lbl_Currency
            // 
            this.lbl_Currency.AutoSize = true;
            this.lbl_Currency.Location = new System.Drawing.Point(12, 9);
            this.lbl_Currency.Name = "lbl_Currency";
            this.lbl_Currency.Size = new System.Drawing.Size(88, 13);
            this.lbl_Currency.TabIndex = 13;
            this.lbl_Currency.Text = "Search Keyword:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgv_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 613);
            this.panel2.TabIndex = 3;
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_list.Location = new System.Drawing.Point(0, 0);
            this.dgv_list.MultiSelect = false;
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_list.RowTemplate.ReadOnly = true;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(650, 611);
            this.dgv_list.TabIndex = 38;
            this.dgv_list.DoubleClick += new System.EventHandler(this.dgv_list_DoubleClick);
            this.dgv_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_list_KeyDown);
            this.dgv_list.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_list_KeyPress);
            // 
            // frm_Common_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Common_List";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frm_Common_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Currency;
        private System.Windows.Forms.TextBox txt_KeyWord;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgv_list;
    }
}