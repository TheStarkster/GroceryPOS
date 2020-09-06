namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_ItemIssue
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
            this.gb_ItemIssue_ItemIssueDetails = new System.Windows.Forms.GroupBox();
            this.lbl_ItemIssue_IssueID = new System.Windows.Forms.Label();
            this.txt_ItemIssue_IssueID = new System.Windows.Forms.TextBox();
            this.txt_ItemIssue_RefNo = new System.Windows.Forms.TextBox();
            this.lbl_ItemIssue_RefNo = new System.Windows.Forms.Label();
            this.lbl_ItemIssue_IssueType = new System.Windows.Forms.Label();
            this.cob_ItemIssue_IssueType = new System.Windows.Forms.ComboBox();
            this.lbl_ItemIssue_Date = new System.Windows.Forms.Label();
            this.dt_ItemIssue_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_ItemIssue_Description = new System.Windows.Forms.Label();
            this.txt_ItemIssue_Description = new System.Windows.Forms.RichTextBox();
            this.lbl_ItemIssue_CostCenter = new System.Windows.Forms.Label();
            this.cob_ItemIssue_CostCenter = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ItemIssue_First = new System.Windows.Forms.Button();
            this.btn_ItemIssue_Next = new System.Windows.Forms.Button();
            this.btn_ItemIssue_Previous = new System.Windows.Forms.Button();
            this.btn_ItemIssue_Last = new System.Windows.Forms.Button();
            this.cb_ItemIssue_ListOnlyOneItem = new System.Windows.Forms.CheckBox();
            this.cb_ItemIssue_ListAllItems = new System.Windows.Forms.CheckBox();
            this.GV_ItemIssue_ItemDetails = new System.Windows.Forms.DataGridView();
            this.lbl_ItemIssue_TotalQty = new System.Windows.Forms.Label();
            this.txt_ItemIssue_TotalQty = new System.Windows.Forms.TextBox();
            this.lbl_ItemIssue_NetAmt = new System.Windows.Forms.Label();
            this.txt_ItemIssue_NetAmt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ItemIssue_Add = new System.Windows.Forms.Button();
            this.btn_ItemIssue_Edit = new System.Windows.Forms.Button();
            this.btn_ItemIssue_Delete = new System.Windows.Forms.Button();
            this.btn_ItemIssue_View = new System.Windows.Forms.Button();
            this.btn_ItemIssue_Exit = new System.Windows.Forms.Button();
            this.gb_ItemIssue_ItemIssueDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemIssue_ItemDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ItemIssue_ItemIssueDetails
            // 
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.txt_ItemIssue_NetAmt);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.lbl_ItemIssue_NetAmt);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.txt_ItemIssue_TotalQty);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.lbl_ItemIssue_TotalQty);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.GV_ItemIssue_ItemDetails);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.cb_ItemIssue_ListAllItems);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.cb_ItemIssue_ListOnlyOneItem);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.panel1);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.cob_ItemIssue_CostCenter);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.lbl_ItemIssue_CostCenter);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.txt_ItemIssue_Description);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.lbl_ItemIssue_Description);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.dt_ItemIssue_Date);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.lbl_ItemIssue_Date);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.cob_ItemIssue_IssueType);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.lbl_ItemIssue_IssueType);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.txt_ItemIssue_RefNo);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.lbl_ItemIssue_RefNo);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.txt_ItemIssue_IssueID);
            this.gb_ItemIssue_ItemIssueDetails.Controls.Add(this.lbl_ItemIssue_IssueID);
            this.gb_ItemIssue_ItemIssueDetails.Location = new System.Drawing.Point(13, 13);
            this.gb_ItemIssue_ItemIssueDetails.Name = "gb_ItemIssue_ItemIssueDetails";
            this.gb_ItemIssue_ItemIssueDetails.Size = new System.Drawing.Size(897, 439);
            this.gb_ItemIssue_ItemIssueDetails.TabIndex = 0;
            this.gb_ItemIssue_ItemIssueDetails.TabStop = false;
            this.gb_ItemIssue_ItemIssueDetails.Text = "Item Issue Details";
            // 
            // lbl_ItemIssue_IssueID
            // 
            this.lbl_ItemIssue_IssueID.AutoSize = true;
            this.lbl_ItemIssue_IssueID.Location = new System.Drawing.Point(7, 22);
            this.lbl_ItemIssue_IssueID.Name = "lbl_ItemIssue_IssueID";
            this.lbl_ItemIssue_IssueID.Size = new System.Drawing.Size(52, 15);
            this.lbl_ItemIssue_IssueID.TabIndex = 0;
            this.lbl_ItemIssue_IssueID.Text = "Issue ID";
            // 
            // txt_ItemIssue_IssueID
            // 
            this.txt_ItemIssue_IssueID.Location = new System.Drawing.Point(80, 19);
            this.txt_ItemIssue_IssueID.Name = "txt_ItemIssue_IssueID";
            this.txt_ItemIssue_IssueID.Size = new System.Drawing.Size(120, 22);
            this.txt_ItemIssue_IssueID.TabIndex = 1;
            // 
            // txt_ItemIssue_RefNo
            // 
            this.txt_ItemIssue_RefNo.Location = new System.Drawing.Point(80, 47);
            this.txt_ItemIssue_RefNo.Name = "txt_ItemIssue_RefNo";
            this.txt_ItemIssue_RefNo.Size = new System.Drawing.Size(120, 22);
            this.txt_ItemIssue_RefNo.TabIndex = 3;
            // 
            // lbl_ItemIssue_RefNo
            // 
            this.lbl_ItemIssue_RefNo.AutoSize = true;
            this.lbl_ItemIssue_RefNo.Location = new System.Drawing.Point(7, 50);
            this.lbl_ItemIssue_RefNo.Name = "lbl_ItemIssue_RefNo";
            this.lbl_ItemIssue_RefNo.Size = new System.Drawing.Size(44, 15);
            this.lbl_ItemIssue_RefNo.TabIndex = 2;
            this.lbl_ItemIssue_RefNo.Text = "Ref No";
            // 
            // lbl_ItemIssue_IssueType
            // 
            this.lbl_ItemIssue_IssueType.AutoSize = true;
            this.lbl_ItemIssue_IssueType.Location = new System.Drawing.Point(7, 78);
            this.lbl_ItemIssue_IssueType.Name = "lbl_ItemIssue_IssueType";
            this.lbl_ItemIssue_IssueType.Size = new System.Drawing.Size(66, 15);
            this.lbl_ItemIssue_IssueType.TabIndex = 4;
            this.lbl_ItemIssue_IssueType.Text = "Issue Type";
            // 
            // cob_ItemIssue_IssueType
            // 
            this.cob_ItemIssue_IssueType.FormattingEnabled = true;
            this.cob_ItemIssue_IssueType.Location = new System.Drawing.Point(80, 76);
            this.cob_ItemIssue_IssueType.Name = "cob_ItemIssue_IssueType";
            this.cob_ItemIssue_IssueType.Size = new System.Drawing.Size(121, 23);
            this.cob_ItemIssue_IssueType.TabIndex = 5;
            // 
            // lbl_ItemIssue_Date
            // 
            this.lbl_ItemIssue_Date.AutoSize = true;
            this.lbl_ItemIssue_Date.Location = new System.Drawing.Point(219, 22);
            this.lbl_ItemIssue_Date.Name = "lbl_ItemIssue_Date";
            this.lbl_ItemIssue_Date.Size = new System.Drawing.Size(32, 15);
            this.lbl_ItemIssue_Date.TabIndex = 6;
            this.lbl_ItemIssue_Date.Text = "Date";
            // 
            // dt_ItemIssue_Date
            // 
            this.dt_ItemIssue_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ItemIssue_Date.Location = new System.Drawing.Point(301, 22);
            this.dt_ItemIssue_Date.Name = "dt_ItemIssue_Date";
            this.dt_ItemIssue_Date.Size = new System.Drawing.Size(102, 22);
            this.dt_ItemIssue_Date.TabIndex = 7;
            // 
            // lbl_ItemIssue_Description
            // 
            this.lbl_ItemIssue_Description.AutoSize = true;
            this.lbl_ItemIssue_Description.Location = new System.Drawing.Point(219, 54);
            this.lbl_ItemIssue_Description.Name = "lbl_ItemIssue_Description";
            this.lbl_ItemIssue_Description.Size = new System.Drawing.Size(69, 15);
            this.lbl_ItemIssue_Description.TabIndex = 8;
            this.lbl_ItemIssue_Description.Text = "Description";
            // 
            // txt_ItemIssue_Description
            // 
            this.txt_ItemIssue_Description.Location = new System.Drawing.Point(301, 50);
            this.txt_ItemIssue_Description.Name = "txt_ItemIssue_Description";
            this.txt_ItemIssue_Description.Size = new System.Drawing.Size(284, 74);
            this.txt_ItemIssue_Description.TabIndex = 9;
            this.txt_ItemIssue_Description.Text = "";
            // 
            // lbl_ItemIssue_CostCenter
            // 
            this.lbl_ItemIssue_CostCenter.AutoSize = true;
            this.lbl_ItemIssue_CostCenter.Location = new System.Drawing.Point(591, 76);
            this.lbl_ItemIssue_CostCenter.Name = "lbl_ItemIssue_CostCenter";
            this.lbl_ItemIssue_CostCenter.Size = new System.Drawing.Size(70, 15);
            this.lbl_ItemIssue_CostCenter.TabIndex = 10;
            this.lbl_ItemIssue_CostCenter.Text = "Cost Center";
            // 
            // cob_ItemIssue_CostCenter
            // 
            this.cob_ItemIssue_CostCenter.FormattingEnabled = true;
            this.cob_ItemIssue_CostCenter.Location = new System.Drawing.Point(594, 94);
            this.cob_ItemIssue_CostCenter.Name = "cob_ItemIssue_CostCenter";
            this.cob_ItemIssue_CostCenter.Size = new System.Drawing.Size(101, 23);
            this.cob_ItemIssue_CostCenter.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ItemIssue_Last);
            this.panel1.Controls.Add(this.btn_ItemIssue_Previous);
            this.panel1.Controls.Add(this.btn_ItemIssue_Next);
            this.panel1.Controls.Add(this.btn_ItemIssue_First);
            this.panel1.Location = new System.Drawing.Point(701, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 98);
            this.panel1.TabIndex = 12;
            // 
            // btn_ItemIssue_First
            // 
            this.btn_ItemIssue_First.Location = new System.Drawing.Point(3, 4);
            this.btn_ItemIssue_First.Name = "btn_ItemIssue_First";
            this.btn_ItemIssue_First.Size = new System.Drawing.Size(86, 40);
            this.btn_ItemIssue_First.TabIndex = 0;
            this.btn_ItemIssue_First.Text = "First";
            this.btn_ItemIssue_First.UseVisualStyleBackColor = true;
            // 
            // btn_ItemIssue_Next
            // 
            this.btn_ItemIssue_Next.Location = new System.Drawing.Point(95, 4);
            this.btn_ItemIssue_Next.Name = "btn_ItemIssue_Next";
            this.btn_ItemIssue_Next.Size = new System.Drawing.Size(86, 40);
            this.btn_ItemIssue_Next.TabIndex = 1;
            this.btn_ItemIssue_Next.Text = "Next";
            this.btn_ItemIssue_Next.UseVisualStyleBackColor = true;
            // 
            // btn_ItemIssue_Previous
            // 
            this.btn_ItemIssue_Previous.Location = new System.Drawing.Point(3, 50);
            this.btn_ItemIssue_Previous.Name = "btn_ItemIssue_Previous";
            this.btn_ItemIssue_Previous.Size = new System.Drawing.Size(86, 40);
            this.btn_ItemIssue_Previous.TabIndex = 2;
            this.btn_ItemIssue_Previous.Text = "Previous";
            this.btn_ItemIssue_Previous.UseVisualStyleBackColor = true;
            // 
            // btn_ItemIssue_Last
            // 
            this.btn_ItemIssue_Last.Location = new System.Drawing.Point(95, 50);
            this.btn_ItemIssue_Last.Name = "btn_ItemIssue_Last";
            this.btn_ItemIssue_Last.Size = new System.Drawing.Size(86, 40);
            this.btn_ItemIssue_Last.TabIndex = 3;
            this.btn_ItemIssue_Last.Text = "Last";
            this.btn_ItemIssue_Last.UseVisualStyleBackColor = true;
            // 
            // cb_ItemIssue_ListOnlyOneItem
            // 
            this.cb_ItemIssue_ListOnlyOneItem.AutoSize = true;
            this.cb_ItemIssue_ListOnlyOneItem.Location = new System.Drawing.Point(421, 131);
            this.cb_ItemIssue_ListOnlyOneItem.Name = "cb_ItemIssue_ListOnlyOneItem";
            this.cb_ItemIssue_ListOnlyOneItem.Size = new System.Drawing.Size(126, 19);
            this.cb_ItemIssue_ListOnlyOneItem.TabIndex = 13;
            this.cb_ItemIssue_ListOnlyOneItem.Text = "List Only One Item";
            this.cb_ItemIssue_ListOnlyOneItem.UseVisualStyleBackColor = true;
            // 
            // cb_ItemIssue_ListAllItems
            // 
            this.cb_ItemIssue_ListAllItems.AutoSize = true;
            this.cb_ItemIssue_ListAllItems.Location = new System.Drawing.Point(594, 131);
            this.cb_ItemIssue_ListAllItems.Name = "cb_ItemIssue_ListAllItems";
            this.cb_ItemIssue_ListAllItems.Size = new System.Drawing.Size(96, 19);
            this.cb_ItemIssue_ListAllItems.TabIndex = 14;
            this.cb_ItemIssue_ListAllItems.Text = "List All Items";
            this.cb_ItemIssue_ListAllItems.UseVisualStyleBackColor = true;
            // 
            // GV_ItemIssue_ItemDetails
            // 
            this.GV_ItemIssue_ItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ItemIssue_ItemDetails.Location = new System.Drawing.Point(10, 154);
            this.GV_ItemIssue_ItemDetails.Name = "GV_ItemIssue_ItemDetails";
            this.GV_ItemIssue_ItemDetails.Size = new System.Drawing.Size(877, 244);
            this.GV_ItemIssue_ItemDetails.TabIndex = 15;
            // 
            // lbl_ItemIssue_TotalQty
            // 
            this.lbl_ItemIssue_TotalQty.AutoSize = true;
            this.lbl_ItemIssue_TotalQty.Location = new System.Drawing.Point(433, 412);
            this.lbl_ItemIssue_TotalQty.Name = "lbl_ItemIssue_TotalQty";
            this.lbl_ItemIssue_TotalQty.Size = new System.Drawing.Size(57, 15);
            this.lbl_ItemIssue_TotalQty.TabIndex = 16;
            this.lbl_ItemIssue_TotalQty.Text = "Total Qty";
            // 
            // txt_ItemIssue_TotalQty
            // 
            this.txt_ItemIssue_TotalQty.Location = new System.Drawing.Point(496, 408);
            this.txt_ItemIssue_TotalQty.Name = "txt_ItemIssue_TotalQty";
            this.txt_ItemIssue_TotalQty.Size = new System.Drawing.Size(148, 22);
            this.txt_ItemIssue_TotalQty.TabIndex = 17;
            // 
            // lbl_ItemIssue_NetAmt
            // 
            this.lbl_ItemIssue_NetAmt.AutoSize = true;
            this.lbl_ItemIssue_NetAmt.Location = new System.Drawing.Point(661, 412);
            this.lbl_ItemIssue_NetAmt.Name = "lbl_ItemIssue_NetAmt";
            this.lbl_ItemIssue_NetAmt.Size = new System.Drawing.Size(72, 15);
            this.lbl_ItemIssue_NetAmt.TabIndex = 18;
            this.lbl_ItemIssue_NetAmt.Text = "Net Amount";
            // 
            // txt_ItemIssue_NetAmt
            // 
            this.txt_ItemIssue_NetAmt.Location = new System.Drawing.Point(739, 408);
            this.txt_ItemIssue_NetAmt.Name = "txt_ItemIssue_NetAmt";
            this.txt_ItemIssue_NetAmt.Size = new System.Drawing.Size(148, 22);
            this.txt_ItemIssue_NetAmt.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_ItemIssue_Exit);
            this.panel2.Controls.Add(this.btn_ItemIssue_View);
            this.panel2.Controls.Add(this.btn_ItemIssue_Delete);
            this.panel2.Controls.Add(this.btn_ItemIssue_Edit);
            this.panel2.Controls.Add(this.btn_ItemIssue_Add);
            this.panel2.Location = new System.Drawing.Point(13, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 53);
            this.panel2.TabIndex = 1;
            // 
            // btn_ItemIssue_Add
            // 
            this.btn_ItemIssue_Add.Location = new System.Drawing.Point(202, 4);
            this.btn_ItemIssue_Add.Name = "btn_ItemIssue_Add";
            this.btn_ItemIssue_Add.Size = new System.Drawing.Size(92, 44);
            this.btn_ItemIssue_Add.TabIndex = 0;
            this.btn_ItemIssue_Add.Text = "Add";
            this.btn_ItemIssue_Add.UseVisualStyleBackColor = true;
            // 
            // btn_ItemIssue_Edit
            // 
            this.btn_ItemIssue_Edit.Location = new System.Drawing.Point(300, 4);
            this.btn_ItemIssue_Edit.Name = "btn_ItemIssue_Edit";
            this.btn_ItemIssue_Edit.Size = new System.Drawing.Size(92, 44);
            this.btn_ItemIssue_Edit.TabIndex = 1;
            this.btn_ItemIssue_Edit.Text = "Edit";
            this.btn_ItemIssue_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_ItemIssue_Delete
            // 
            this.btn_ItemIssue_Delete.Location = new System.Drawing.Point(397, 3);
            this.btn_ItemIssue_Delete.Name = "btn_ItemIssue_Delete";
            this.btn_ItemIssue_Delete.Size = new System.Drawing.Size(92, 44);
            this.btn_ItemIssue_Delete.TabIndex = 2;
            this.btn_ItemIssue_Delete.Text = "Delete";
            this.btn_ItemIssue_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_ItemIssue_View
            // 
            this.btn_ItemIssue_View.Location = new System.Drawing.Point(495, 4);
            this.btn_ItemIssue_View.Name = "btn_ItemIssue_View";
            this.btn_ItemIssue_View.Size = new System.Drawing.Size(92, 44);
            this.btn_ItemIssue_View.TabIndex = 3;
            this.btn_ItemIssue_View.Text = "View";
            this.btn_ItemIssue_View.UseVisualStyleBackColor = true;
            // 
            // btn_ItemIssue_Exit
            // 
            this.btn_ItemIssue_Exit.Location = new System.Drawing.Point(593, 3);
            this.btn_ItemIssue_Exit.Name = "btn_ItemIssue_Exit";
            this.btn_ItemIssue_Exit.Size = new System.Drawing.Size(92, 44);
            this.btn_ItemIssue_Exit.TabIndex = 4;
            this.btn_ItemIssue_Exit.Text = "Exit";
            this.btn_ItemIssue_Exit.UseVisualStyleBackColor = true;
            // 
            // frm_Transactions_ItemIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_ItemIssue_ItemIssueDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_ItemIssue";
            this.Text = "frm_Transactions_ItemIssue";
            this.gb_ItemIssue_ItemIssueDetails.ResumeLayout(false);
            this.gb_ItemIssue_ItemIssueDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemIssue_ItemDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ItemIssue_ItemIssueDetails;
        private System.Windows.Forms.TextBox txt_ItemIssue_NetAmt;
        private System.Windows.Forms.Label lbl_ItemIssue_NetAmt;
        private System.Windows.Forms.TextBox txt_ItemIssue_TotalQty;
        private System.Windows.Forms.Label lbl_ItemIssue_TotalQty;
        private System.Windows.Forms.DataGridView GV_ItemIssue_ItemDetails;
        private System.Windows.Forms.CheckBox cb_ItemIssue_ListAllItems;
        private System.Windows.Forms.CheckBox cb_ItemIssue_ListOnlyOneItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ItemIssue_Last;
        private System.Windows.Forms.Button btn_ItemIssue_Previous;
        private System.Windows.Forms.Button btn_ItemIssue_Next;
        private System.Windows.Forms.Button btn_ItemIssue_First;
        private System.Windows.Forms.ComboBox cob_ItemIssue_CostCenter;
        private System.Windows.Forms.Label lbl_ItemIssue_CostCenter;
        private System.Windows.Forms.RichTextBox txt_ItemIssue_Description;
        private System.Windows.Forms.Label lbl_ItemIssue_Description;
        private System.Windows.Forms.DateTimePicker dt_ItemIssue_Date;
        private System.Windows.Forms.Label lbl_ItemIssue_Date;
        private System.Windows.Forms.ComboBox cob_ItemIssue_IssueType;
        private System.Windows.Forms.Label lbl_ItemIssue_IssueType;
        private System.Windows.Forms.TextBox txt_ItemIssue_RefNo;
        private System.Windows.Forms.Label lbl_ItemIssue_RefNo;
        private System.Windows.Forms.TextBox txt_ItemIssue_IssueID;
        private System.Windows.Forms.Label lbl_ItemIssue_IssueID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ItemIssue_Exit;
        private System.Windows.Forms.Button btn_ItemIssue_View;
        private System.Windows.Forms.Button btn_ItemIssue_Delete;
        private System.Windows.Forms.Button btn_ItemIssue_Edit;
        private System.Windows.Forms.Button btn_ItemIssue_Add;
    }
}