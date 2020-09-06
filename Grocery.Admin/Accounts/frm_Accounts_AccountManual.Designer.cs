namespace Grocery.Admin.Accounts
{
    partial class frm_Accounts_AccountManual
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
            this.tv_AccountManual_AccountTree = new System.Windows.Forms.TreeView();
            this.gb_AccountManual = new System.Windows.Forms.GroupBox();
            this.rb_AccountManual_AccountLedger = new System.Windows.Forms.RadioButton();
            this.rb_AccountManual_AccountGroups = new System.Windows.Forms.RadioButton();
            this.lbl_AccountManual_GroupUnder = new System.Windows.Forms.Label();
            this.cob_AccountManual_GroupUnder = new System.Windows.Forms.ComboBox();
            this.lbl_AccountManual_LedgerCode = new System.Windows.Forms.Label();
            this.txt_AccountManual_LedgerCode = new System.Windows.Forms.TextBox();
            this.txt_AccountManual_AccountName = new System.Windows.Forms.TextBox();
            this.lbl_AccountManual_AccountName = new System.Windows.Forms.Label();
            this.txt_AccountManual_OpeningBalance = new System.Windows.Forms.TextBox();
            this.lbl_AccountManual_OpeningBalance = new System.Windows.Forms.Label();
            this.lbl_AccountManual_OpeningBalanceDate = new System.Windows.Forms.Label();
            this.dt_AccountManual_OpeningBalanceDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_AccountManual_OpeningBalanceType = new System.Windows.Forms.Label();
            this.cob_AccountManual_OpeningBalanceType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AccountManual_Add = new System.Windows.Forms.Button();
            this.btn_AccountManual_Edit = new System.Windows.Forms.Button();
            this.btn_AccountManual_Delete = new System.Windows.Forms.Button();
            this.btn_AccountManual_View = new System.Windows.Forms.Button();
            this.btn_AccountManual_Close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_AccountManual_Keyword = new System.Windows.Forms.Label();
            this.txt_AccountManual_Keyword = new System.Windows.Forms.TextBox();
            this.btn_AccountManual_KeywordSrch = new System.Windows.Forms.Button();
            this.GV_AccountManual_LedgerDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gb_AccountManual.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_AccountManual_LedgerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tv_AccountManual_AccountTree);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 502);
            this.panel1.TabIndex = 0;
            // 
            // tv_AccountManual_AccountTree
            // 
            this.tv_AccountManual_AccountTree.Location = new System.Drawing.Point(17, 17);
            this.tv_AccountManual_AccountTree.Name = "tv_AccountManual_AccountTree";
            this.tv_AccountManual_AccountTree.Size = new System.Drawing.Size(289, 470);
            this.tv_AccountManual_AccountTree.TabIndex = 0;
            // 
            // gb_AccountManual
            // 
            this.gb_AccountManual.Controls.Add(this.cob_AccountManual_OpeningBalanceType);
            this.gb_AccountManual.Controls.Add(this.lbl_AccountManual_OpeningBalanceType);
            this.gb_AccountManual.Controls.Add(this.dt_AccountManual_OpeningBalanceDate);
            this.gb_AccountManual.Controls.Add(this.lbl_AccountManual_OpeningBalanceDate);
            this.gb_AccountManual.Controls.Add(this.txt_AccountManual_OpeningBalance);
            this.gb_AccountManual.Controls.Add(this.lbl_AccountManual_OpeningBalance);
            this.gb_AccountManual.Controls.Add(this.txt_AccountManual_AccountName);
            this.gb_AccountManual.Controls.Add(this.lbl_AccountManual_AccountName);
            this.gb_AccountManual.Controls.Add(this.txt_AccountManual_LedgerCode);
            this.gb_AccountManual.Controls.Add(this.lbl_AccountManual_LedgerCode);
            this.gb_AccountManual.Controls.Add(this.cob_AccountManual_GroupUnder);
            this.gb_AccountManual.Controls.Add(this.lbl_AccountManual_GroupUnder);
            this.gb_AccountManual.Location = new System.Drawing.Point(341, 43);
            this.gb_AccountManual.Name = "gb_AccountManual";
            this.gb_AccountManual.Size = new System.Drawing.Size(499, 193);
            this.gb_AccountManual.TabIndex = 1;
            this.gb_AccountManual.TabStop = false;
            this.gb_AccountManual.Text = "Account Manual";
            // 
            // rb_AccountManual_AccountLedger
            // 
            this.rb_AccountManual_AccountLedger.AutoSize = true;
            this.rb_AccountManual_AccountLedger.Location = new System.Drawing.Point(466, 15);
            this.rb_AccountManual_AccountLedger.Name = "rb_AccountManual_AccountLedger";
            this.rb_AccountManual_AccountLedger.Size = new System.Drawing.Size(112, 19);
            this.rb_AccountManual_AccountLedger.TabIndex = 2;
            this.rb_AccountManual_AccountLedger.TabStop = true;
            this.rb_AccountManual_AccountLedger.Text = "Account Ledger";
            this.rb_AccountManual_AccountLedger.UseVisualStyleBackColor = true;
            // 
            // rb_AccountManual_AccountGroups
            // 
            this.rb_AccountManual_AccountGroups.AutoSize = true;
            this.rb_AccountManual_AccountGroups.Location = new System.Drawing.Point(651, 15);
            this.rb_AccountManual_AccountGroups.Name = "rb_AccountManual_AccountGroups";
            this.rb_AccountManual_AccountGroups.Size = new System.Drawing.Size(114, 19);
            this.rb_AccountManual_AccountGroups.TabIndex = 3;
            this.rb_AccountManual_AccountGroups.TabStop = true;
            this.rb_AccountManual_AccountGroups.Text = "Account Groups";
            this.rb_AccountManual_AccountGroups.UseVisualStyleBackColor = true;
            // 
            // lbl_AccountManual_GroupUnder
            // 
            this.lbl_AccountManual_GroupUnder.AutoSize = true;
            this.lbl_AccountManual_GroupUnder.Location = new System.Drawing.Point(25, 24);
            this.lbl_AccountManual_GroupUnder.Name = "lbl_AccountManual_GroupUnder";
            this.lbl_AccountManual_GroupUnder.Size = new System.Drawing.Size(76, 15);
            this.lbl_AccountManual_GroupUnder.TabIndex = 0;
            this.lbl_AccountManual_GroupUnder.Text = "Group Under";
            // 
            // cob_AccountManual_GroupUnder
            // 
            this.cob_AccountManual_GroupUnder.FormattingEnabled = true;
            this.cob_AccountManual_GroupUnder.Location = new System.Drawing.Point(158, 21);
            this.cob_AccountManual_GroupUnder.Name = "cob_AccountManual_GroupUnder";
            this.cob_AccountManual_GroupUnder.Size = new System.Drawing.Size(196, 23);
            this.cob_AccountManual_GroupUnder.TabIndex = 1;
            // 
            // lbl_AccountManual_LedgerCode
            // 
            this.lbl_AccountManual_LedgerCode.AutoSize = true;
            this.lbl_AccountManual_LedgerCode.Location = new System.Drawing.Point(25, 53);
            this.lbl_AccountManual_LedgerCode.Name = "lbl_AccountManual_LedgerCode";
            this.lbl_AccountManual_LedgerCode.Size = new System.Drawing.Size(75, 15);
            this.lbl_AccountManual_LedgerCode.TabIndex = 2;
            this.lbl_AccountManual_LedgerCode.Text = "Ledger Code";
            // 
            // txt_AccountManual_LedgerCode
            // 
            this.txt_AccountManual_LedgerCode.Location = new System.Drawing.Point(158, 50);
            this.txt_AccountManual_LedgerCode.Name = "txt_AccountManual_LedgerCode";
            this.txt_AccountManual_LedgerCode.Size = new System.Drawing.Size(316, 22);
            this.txt_AccountManual_LedgerCode.TabIndex = 3;
            // 
            // txt_AccountManual_AccountName
            // 
            this.txt_AccountManual_AccountName.Location = new System.Drawing.Point(158, 78);
            this.txt_AccountManual_AccountName.Name = "txt_AccountManual_AccountName";
            this.txt_AccountManual_AccountName.Size = new System.Drawing.Size(316, 22);
            this.txt_AccountManual_AccountName.TabIndex = 5;
            // 
            // lbl_AccountManual_AccountName
            // 
            this.lbl_AccountManual_AccountName.AutoSize = true;
            this.lbl_AccountManual_AccountName.Location = new System.Drawing.Point(25, 81);
            this.lbl_AccountManual_AccountName.Name = "lbl_AccountManual_AccountName";
            this.lbl_AccountManual_AccountName.Size = new System.Drawing.Size(87, 15);
            this.lbl_AccountManual_AccountName.TabIndex = 4;
            this.lbl_AccountManual_AccountName.Text = "Account Name";
            // 
            // txt_AccountManual_OpeningBalance
            // 
            this.txt_AccountManual_OpeningBalance.Location = new System.Drawing.Point(158, 106);
            this.txt_AccountManual_OpeningBalance.Name = "txt_AccountManual_OpeningBalance";
            this.txt_AccountManual_OpeningBalance.Size = new System.Drawing.Size(316, 22);
            this.txt_AccountManual_OpeningBalance.TabIndex = 7;
            // 
            // lbl_AccountManual_OpeningBalance
            // 
            this.lbl_AccountManual_OpeningBalance.AutoSize = true;
            this.lbl_AccountManual_OpeningBalance.Location = new System.Drawing.Point(25, 109);
            this.lbl_AccountManual_OpeningBalance.Name = "lbl_AccountManual_OpeningBalance";
            this.lbl_AccountManual_OpeningBalance.Size = new System.Drawing.Size(98, 15);
            this.lbl_AccountManual_OpeningBalance.TabIndex = 6;
            this.lbl_AccountManual_OpeningBalance.Text = "Opening Balance";
            // 
            // lbl_AccountManual_OpeningBalanceDate
            // 
            this.lbl_AccountManual_OpeningBalanceDate.AutoSize = true;
            this.lbl_AccountManual_OpeningBalanceDate.Location = new System.Drawing.Point(25, 140);
            this.lbl_AccountManual_OpeningBalanceDate.Name = "lbl_AccountManual_OpeningBalanceDate";
            this.lbl_AccountManual_OpeningBalanceDate.Size = new System.Drawing.Size(126, 15);
            this.lbl_AccountManual_OpeningBalanceDate.TabIndex = 8;
            this.lbl_AccountManual_OpeningBalanceDate.Text = "Opening Balance Date";
            // 
            // dt_AccountManual_OpeningBalanceDate
            // 
            this.dt_AccountManual_OpeningBalanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_AccountManual_OpeningBalanceDate.Location = new System.Drawing.Point(158, 134);
            this.dt_AccountManual_OpeningBalanceDate.Name = "dt_AccountManual_OpeningBalanceDate";
            this.dt_AccountManual_OpeningBalanceDate.Size = new System.Drawing.Size(146, 22);
            this.dt_AccountManual_OpeningBalanceDate.TabIndex = 9;
            // 
            // lbl_AccountManual_OpeningBalanceType
            // 
            this.lbl_AccountManual_OpeningBalanceType.AutoSize = true;
            this.lbl_AccountManual_OpeningBalanceType.Location = new System.Drawing.Point(25, 165);
            this.lbl_AccountManual_OpeningBalanceType.Name = "lbl_AccountManual_OpeningBalanceType";
            this.lbl_AccountManual_OpeningBalanceType.Size = new System.Drawing.Size(128, 15);
            this.lbl_AccountManual_OpeningBalanceType.TabIndex = 10;
            this.lbl_AccountManual_OpeningBalanceType.Text = "Opening Balance Type";
            // 
            // cob_AccountManual_OpeningBalanceType
            // 
            this.cob_AccountManual_OpeningBalanceType.FormattingEnabled = true;
            this.cob_AccountManual_OpeningBalanceType.Location = new System.Drawing.Point(158, 162);
            this.cob_AccountManual_OpeningBalanceType.Name = "cob_AccountManual_OpeningBalanceType";
            this.cob_AccountManual_OpeningBalanceType.Size = new System.Drawing.Size(146, 23);
            this.cob_AccountManual_OpeningBalanceType.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_AccountManual_Close);
            this.panel2.Controls.Add(this.btn_AccountManual_View);
            this.panel2.Controls.Add(this.btn_AccountManual_Delete);
            this.panel2.Controls.Add(this.btn_AccountManual_Edit);
            this.panel2.Controls.Add(this.btn_AccountManual_Add);
            this.panel2.Location = new System.Drawing.Point(342, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 46);
            this.panel2.TabIndex = 4;
            // 
            // btn_AccountManual_Add
            // 
            this.btn_AccountManual_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountManual_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_AccountManual_Add.Name = "btn_AccountManual_Add";
            this.btn_AccountManual_Add.Size = new System.Drawing.Size(93, 39);
            this.btn_AccountManual_Add.TabIndex = 0;
            this.btn_AccountManual_Add.Text = "&Add";
            this.btn_AccountManual_Add.UseVisualStyleBackColor = true;
            // 
            // btn_AccountManual_Edit
            // 
            this.btn_AccountManual_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountManual_Edit.Location = new System.Drawing.Point(102, 3);
            this.btn_AccountManual_Edit.Name = "btn_AccountManual_Edit";
            this.btn_AccountManual_Edit.Size = new System.Drawing.Size(93, 39);
            this.btn_AccountManual_Edit.TabIndex = 1;
            this.btn_AccountManual_Edit.Text = "&Edit";
            this.btn_AccountManual_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_AccountManual_Delete
            // 
            this.btn_AccountManual_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountManual_Delete.Location = new System.Drawing.Point(201, 3);
            this.btn_AccountManual_Delete.Name = "btn_AccountManual_Delete";
            this.btn_AccountManual_Delete.Size = new System.Drawing.Size(93, 39);
            this.btn_AccountManual_Delete.TabIndex = 2;
            this.btn_AccountManual_Delete.Text = "&Delete";
            this.btn_AccountManual_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_AccountManual_View
            // 
            this.btn_AccountManual_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountManual_View.Location = new System.Drawing.Point(300, 4);
            this.btn_AccountManual_View.Name = "btn_AccountManual_View";
            this.btn_AccountManual_View.Size = new System.Drawing.Size(93, 39);
            this.btn_AccountManual_View.TabIndex = 3;
            this.btn_AccountManual_View.Text = "&View";
            this.btn_AccountManual_View.UseVisualStyleBackColor = true;
            // 
            // btn_AccountManual_Close
            // 
            this.btn_AccountManual_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountManual_Close.Location = new System.Drawing.Point(399, 4);
            this.btn_AccountManual_Close.Name = "btn_AccountManual_Close";
            this.btn_AccountManual_Close.Size = new System.Drawing.Size(93, 39);
            this.btn_AccountManual_Close.TabIndex = 4;
            this.btn_AccountManual_Close.Text = "&Close";
            this.btn_AccountManual_Close.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.GV_AccountManual_LedgerDetails);
            this.panel3.Controls.Add(this.btn_AccountManual_KeywordSrch);
            this.panel3.Controls.Add(this.txt_AccountManual_Keyword);
            this.panel3.Controls.Add(this.lbl_AccountManual_Keyword);
            this.panel3.Location = new System.Drawing.Point(342, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 226);
            this.panel3.TabIndex = 5;
            // 
            // lbl_AccountManual_Keyword
            // 
            this.lbl_AccountManual_Keyword.AutoSize = true;
            this.lbl_AccountManual_Keyword.Location = new System.Drawing.Point(4, 4);
            this.lbl_AccountManual_Keyword.Name = "lbl_AccountManual_Keyword";
            this.lbl_AccountManual_Keyword.Size = new System.Drawing.Size(191, 15);
            this.lbl_AccountManual_Keyword.TabIndex = 0;
            this.lbl_AccountManual_Keyword.Text = "Type Keyword Here For Searching";
            // 
            // txt_AccountManual_Keyword
            // 
            this.txt_AccountManual_Keyword.Location = new System.Drawing.Point(7, 23);
            this.txt_AccountManual_Keyword.Name = "txt_AccountManual_Keyword";
            this.txt_AccountManual_Keyword.Size = new System.Drawing.Size(432, 22);
            this.txt_AccountManual_Keyword.TabIndex = 1;
            // 
            // btn_AccountManual_KeywordSrch
            // 
            this.btn_AccountManual_KeywordSrch.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_AccountManual_KeywordSrch.Location = new System.Drawing.Point(445, 12);
            this.btn_AccountManual_KeywordSrch.Name = "btn_AccountManual_KeywordSrch";
            this.btn_AccountManual_KeywordSrch.Size = new System.Drawing.Size(47, 33);
            this.btn_AccountManual_KeywordSrch.TabIndex = 2;
            this.btn_AccountManual_KeywordSrch.UseVisualStyleBackColor = true;
            // 
            // GV_AccountManual_LedgerDetails
            // 
            this.GV_AccountManual_LedgerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_AccountManual_LedgerDetails.Location = new System.Drawing.Point(7, 52);
            this.GV_AccountManual_LedgerDetails.Name = "GV_AccountManual_LedgerDetails";
            this.GV_AccountManual_LedgerDetails.Size = new System.Drawing.Size(485, 171);
            this.GV_AccountManual_LedgerDetails.TabIndex = 3;
            // 
            // frm_Accounts_AccountManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rb_AccountManual_AccountGroups);
            this.Controls.Add(this.rb_AccountManual_AccountLedger);
            this.Controls.Add(this.gb_AccountManual);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Accounts_AccountManual";
            this.Text = "frm_Accounts_AccountManual";
            this.panel1.ResumeLayout(false);
            this.gb_AccountManual.ResumeLayout(false);
            this.gb_AccountManual.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_AccountManual_LedgerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tv_AccountManual_AccountTree;
        private System.Windows.Forms.GroupBox gb_AccountManual;
        private System.Windows.Forms.ComboBox cob_AccountManual_OpeningBalanceType;
        private System.Windows.Forms.Label lbl_AccountManual_OpeningBalanceType;
        private System.Windows.Forms.DateTimePicker dt_AccountManual_OpeningBalanceDate;
        private System.Windows.Forms.Label lbl_AccountManual_OpeningBalanceDate;
        private System.Windows.Forms.TextBox txt_AccountManual_OpeningBalance;
        private System.Windows.Forms.Label lbl_AccountManual_OpeningBalance;
        private System.Windows.Forms.TextBox txt_AccountManual_AccountName;
        private System.Windows.Forms.Label lbl_AccountManual_AccountName;
        private System.Windows.Forms.TextBox txt_AccountManual_LedgerCode;
        private System.Windows.Forms.Label lbl_AccountManual_LedgerCode;
        private System.Windows.Forms.ComboBox cob_AccountManual_GroupUnder;
        private System.Windows.Forms.Label lbl_AccountManual_GroupUnder;
        private System.Windows.Forms.RadioButton rb_AccountManual_AccountLedger;
        private System.Windows.Forms.RadioButton rb_AccountManual_AccountGroups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_AccountManual_Close;
        private System.Windows.Forms.Button btn_AccountManual_View;
        private System.Windows.Forms.Button btn_AccountManual_Delete;
        private System.Windows.Forms.Button btn_AccountManual_Edit;
        private System.Windows.Forms.Button btn_AccountManual_Add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView GV_AccountManual_LedgerDetails;
        private System.Windows.Forms.Button btn_AccountManual_KeywordSrch;
        private System.Windows.Forms.TextBox txt_AccountManual_Keyword;
        private System.Windows.Forms.Label lbl_AccountManual_Keyword;
    }
}