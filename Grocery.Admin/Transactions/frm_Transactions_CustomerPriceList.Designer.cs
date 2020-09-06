namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_CustomerPriceList
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
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.txt_CustomerPriceList_CustName = new Grocery.Admin.UControl.ucComboBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txt_CustomerPriceList_ItemName = new Grocery.Admin.UControl.ucComboBox();
            this.dt_CustomerPriceList_BalanceDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_CustomerPriceList_BalanceDate = new System.Windows.Forms.Label();
            this.txt_CustomerPriceList_SellingPrice = new System.Windows.Forms.TextBox();
            this.lbl_CustomerPriceList_SellingPrice = new System.Windows.Forms.Label();
            this.txt_CustomerPriceList_Barcode = new System.Windows.Forms.TextBox();
            this.lbl_CustomerPriceList_Barcode = new System.Windows.Forms.Label();
            this.lbl_CustomerPriceList_CustName = new System.Windows.Forms.Label();
            this.lbl_CustomerPriceList_ItemName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CustomerPriceList_Close = new System.Windows.Forms.Button();
            this.btn_CustomerPriceList_Save = new System.Windows.Forms.Button();
            this.btn_CustomerPriceList_Delete = new System.Windows.Forms.Button();
            this.btn_CustomerPriceList_Edit = new System.Windows.Forms.Button();
            this.btn_CustomerPriceList_New = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_CustomerPriceList_SrchCost = new System.Windows.Forms.TextBox();
            this.lbl_CustomerPriceList_SrchCost = new System.Windows.Forms.Label();
            this.txt_CustomerPriceList_SrchCustName = new System.Windows.Forms.TextBox();
            this.lbl_CustomerPriceList_SrchCustName = new System.Windows.Forms.Label();
            this.txt_CustomerPriceList_SrchItemName = new System.Windows.Forms.TextBox();
            this.lbl_CustomerPriceList_SrchItemName = new System.Windows.Forms.Label();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCustomerid);
            this.panel1.Controls.Add(this.txt_CustomerPriceList_CustName);
            this.panel1.Controls.Add(this.txtItemCode);
            this.panel1.Controls.Add(this.txt_CustomerPriceList_ItemName);
            this.panel1.Controls.Add(this.dt_CustomerPriceList_BalanceDate);
            this.panel1.Controls.Add(this.lbl_CustomerPriceList_BalanceDate);
            this.panel1.Controls.Add(this.txt_CustomerPriceList_SellingPrice);
            this.panel1.Controls.Add(this.lbl_CustomerPriceList_SellingPrice);
            this.panel1.Controls.Add(this.txt_CustomerPriceList_Barcode);
            this.panel1.Controls.Add(this.lbl_CustomerPriceList_Barcode);
            this.panel1.Controls.Add(this.lbl_CustomerPriceList_CustName);
            this.panel1.Controls.Add(this.lbl_CustomerPriceList_ItemName);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 183);
            this.panel1.TabIndex = 0;
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCustomerid.Location = new System.Drawing.Point(492, 54);
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.ReadOnly = true;
            this.txtCustomerid.Size = new System.Drawing.Size(117, 22);
            this.txtCustomerid.TabIndex = 38;
            // 
            // txt_CustomerPriceList_CustName
            // 
            this.txt_CustomerPriceList_CustName.Location = new System.Drawing.Point(114, 53);
            this.txt_CustomerPriceList_CustName.Name = "txt_CustomerPriceList_CustName";
            this.txt_CustomerPriceList_CustName.Size = new System.Drawing.Size(372, 24);
            this.txt_CustomerPriceList_CustName.TabIndex = 37;
            this.txt_CustomerPriceList_CustName.Tag = "CUSTOMER_LIST";
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.Color.Gainsboro;
            this.txtItemCode.Location = new System.Drawing.Point(492, 21);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(117, 22);
            this.txtItemCode.TabIndex = 36;
            // 
            // txt_CustomerPriceList_ItemName
            // 
            this.txt_CustomerPriceList_ItemName.Location = new System.Drawing.Point(114, 24);
            this.txt_CustomerPriceList_ItemName.Name = "txt_CustomerPriceList_ItemName";
            this.txt_CustomerPriceList_ItemName.Size = new System.Drawing.Size(362, 25);
            this.txt_CustomerPriceList_ItemName.TabIndex = 35;
            this.txt_CustomerPriceList_ItemName.Tag = "ITEM_LIST";
            // 
            // dt_CustomerPriceList_BalanceDate
            // 
            this.dt_CustomerPriceList_BalanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_CustomerPriceList_BalanceDate.Location = new System.Drawing.Point(114, 142);
            this.dt_CustomerPriceList_BalanceDate.Name = "dt_CustomerPriceList_BalanceDate";
            this.dt_CustomerPriceList_BalanceDate.Size = new System.Drawing.Size(97, 22);
            this.dt_CustomerPriceList_BalanceDate.TabIndex = 9;
            // 
            // lbl_CustomerPriceList_BalanceDate
            // 
            this.lbl_CustomerPriceList_BalanceDate.AutoSize = true;
            this.lbl_CustomerPriceList_BalanceDate.Location = new System.Drawing.Point(17, 148);
            this.lbl_CustomerPriceList_BalanceDate.Name = "lbl_CustomerPriceList_BalanceDate";
            this.lbl_CustomerPriceList_BalanceDate.Size = new System.Drawing.Size(80, 15);
            this.lbl_CustomerPriceList_BalanceDate.TabIndex = 8;
            this.lbl_CustomerPriceList_BalanceDate.Text = "Balance Date ";
            // 
            // txt_CustomerPriceList_SellingPrice
            // 
            this.txt_CustomerPriceList_SellingPrice.Location = new System.Drawing.Point(114, 114);
            this.txt_CustomerPriceList_SellingPrice.Name = "txt_CustomerPriceList_SellingPrice";
            this.txt_CustomerPriceList_SellingPrice.Size = new System.Drawing.Size(97, 22);
            this.txt_CustomerPriceList_SellingPrice.TabIndex = 7;
            // 
            // lbl_CustomerPriceList_SellingPrice
            // 
            this.lbl_CustomerPriceList_SellingPrice.AutoSize = true;
            this.lbl_CustomerPriceList_SellingPrice.Location = new System.Drawing.Point(17, 117);
            this.lbl_CustomerPriceList_SellingPrice.Name = "lbl_CustomerPriceList_SellingPrice";
            this.lbl_CustomerPriceList_SellingPrice.Size = new System.Drawing.Size(98, 15);
            this.lbl_CustomerPriceList_SellingPrice.TabIndex = 6;
            this.lbl_CustomerPriceList_SellingPrice.Text = "Item Selling Price";
            // 
            // txt_CustomerPriceList_Barcode
            // 
            this.txt_CustomerPriceList_Barcode.Location = new System.Drawing.Point(114, 86);
            this.txt_CustomerPriceList_Barcode.Name = "txt_CustomerPriceList_Barcode";
            this.txt_CustomerPriceList_Barcode.Size = new System.Drawing.Size(205, 22);
            this.txt_CustomerPriceList_Barcode.TabIndex = 5;
            // 
            // lbl_CustomerPriceList_Barcode
            // 
            this.lbl_CustomerPriceList_Barcode.AutoSize = true;
            this.lbl_CustomerPriceList_Barcode.Location = new System.Drawing.Point(17, 89);
            this.lbl_CustomerPriceList_Barcode.Name = "lbl_CustomerPriceList_Barcode";
            this.lbl_CustomerPriceList_Barcode.Size = new System.Drawing.Size(51, 15);
            this.lbl_CustomerPriceList_Barcode.TabIndex = 4;
            this.lbl_CustomerPriceList_Barcode.Text = "Barcode";
            // 
            // lbl_CustomerPriceList_CustName
            // 
            this.lbl_CustomerPriceList_CustName.AutoSize = true;
            this.lbl_CustomerPriceList_CustName.Location = new System.Drawing.Point(17, 60);
            this.lbl_CustomerPriceList_CustName.Name = "lbl_CustomerPriceList_CustName";
            this.lbl_CustomerPriceList_CustName.Size = new System.Drawing.Size(91, 15);
            this.lbl_CustomerPriceList_CustName.TabIndex = 2;
            this.lbl_CustomerPriceList_CustName.Text = "Customer Name";
            // 
            // lbl_CustomerPriceList_ItemName
            // 
            this.lbl_CustomerPriceList_ItemName.AutoSize = true;
            this.lbl_CustomerPriceList_ItemName.Location = new System.Drawing.Point(17, 28);
            this.lbl_CustomerPriceList_ItemName.Name = "lbl_CustomerPriceList_ItemName";
            this.lbl_CustomerPriceList_ItemName.Size = new System.Drawing.Size(63, 15);
            this.lbl_CustomerPriceList_ItemName.TabIndex = 0;
            this.lbl_CustomerPriceList_ItemName.Text = "Item Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_CustomerPriceList_Close);
            this.panel2.Controls.Add(this.btn_CustomerPriceList_Save);
            this.panel2.Controls.Add(this.btn_CustomerPriceList_Delete);
            this.panel2.Controls.Add(this.btn_CustomerPriceList_Edit);
            this.panel2.Controls.Add(this.btn_CustomerPriceList_New);
            this.panel2.Location = new System.Drawing.Point(644, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 183);
            this.panel2.TabIndex = 1;
            // 
            // btn_CustomerPriceList_Close
            // 
            this.btn_CustomerPriceList_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CustomerPriceList_Close.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerPriceList_Close.Image = global::Grocery.Admin.Properties.Resources.delete_1_icon;
            this.btn_CustomerPriceList_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CustomerPriceList_Close.Location = new System.Drawing.Point(18, 144);
            this.btn_CustomerPriceList_Close.Name = "btn_CustomerPriceList_Close";
            this.btn_CustomerPriceList_Close.Size = new System.Drawing.Size(94, 29);
            this.btn_CustomerPriceList_Close.TabIndex = 4;
            this.btn_CustomerPriceList_Close.Text = "&Close";
            this.btn_CustomerPriceList_Close.UseVisualStyleBackColor = true;
            this.btn_CustomerPriceList_Close.Click += new System.EventHandler(this.btn_CustomerPriceList_Close_Click);
            // 
            // btn_CustomerPriceList_Save
            // 
            this.btn_CustomerPriceList_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CustomerPriceList_Save.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerPriceList_Save.Image = global::Grocery.Admin.Properties.Resources.floppy_icon;
            this.btn_CustomerPriceList_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CustomerPriceList_Save.Location = new System.Drawing.Point(18, 109);
            this.btn_CustomerPriceList_Save.Name = "btn_CustomerPriceList_Save";
            this.btn_CustomerPriceList_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_CustomerPriceList_Save.TabIndex = 3;
            this.btn_CustomerPriceList_Save.Text = "&Save";
            this.btn_CustomerPriceList_Save.UseVisualStyleBackColor = true;
            this.btn_CustomerPriceList_Save.Click += new System.EventHandler(this.btn_CustomerPriceList_Save_Click);
            // 
            // btn_CustomerPriceList_Delete
            // 
            this.btn_CustomerPriceList_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CustomerPriceList_Delete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerPriceList_Delete.Image = global::Grocery.Admin.Properties.Resources.Math_minus_icon;
            this.btn_CustomerPriceList_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CustomerPriceList_Delete.Location = new System.Drawing.Point(18, 74);
            this.btn_CustomerPriceList_Delete.Name = "btn_CustomerPriceList_Delete";
            this.btn_CustomerPriceList_Delete.Size = new System.Drawing.Size(94, 29);
            this.btn_CustomerPriceList_Delete.TabIndex = 2;
            this.btn_CustomerPriceList_Delete.Text = "&Delete";
            this.btn_CustomerPriceList_Delete.UseVisualStyleBackColor = true;
            this.btn_CustomerPriceList_Delete.Click += new System.EventHandler(this.btn_CustomerPriceList_Delete_Click);
            // 
            // btn_CustomerPriceList_Edit
            // 
            this.btn_CustomerPriceList_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CustomerPriceList_Edit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerPriceList_Edit.Image = global::Grocery.Admin.Properties.Resources.edit_file_icon;
            this.btn_CustomerPriceList_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CustomerPriceList_Edit.Location = new System.Drawing.Point(18, 39);
            this.btn_CustomerPriceList_Edit.Name = "btn_CustomerPriceList_Edit";
            this.btn_CustomerPriceList_Edit.Size = new System.Drawing.Size(94, 29);
            this.btn_CustomerPriceList_Edit.TabIndex = 1;
            this.btn_CustomerPriceList_Edit.Text = "&Edit";
            this.btn_CustomerPriceList_Edit.UseVisualStyleBackColor = true;
            this.btn_CustomerPriceList_Edit.Click += new System.EventHandler(this.btn_CustomerPriceList_Edit_Click);
            // 
            // btn_CustomerPriceList_New
            // 
            this.btn_CustomerPriceList_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CustomerPriceList_New.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerPriceList_New.Image = global::Grocery.Admin.Properties.Resources.add_icon;
            this.btn_CustomerPriceList_New.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CustomerPriceList_New.Location = new System.Drawing.Point(18, 4);
            this.btn_CustomerPriceList_New.Name = "btn_CustomerPriceList_New";
            this.btn_CustomerPriceList_New.Size = new System.Drawing.Size(94, 29);
            this.btn_CustomerPriceList_New.TabIndex = 0;
            this.btn_CustomerPriceList_New.Text = "&New";
            this.btn_CustomerPriceList_New.UseVisualStyleBackColor = true;
            this.btn_CustomerPriceList_New.Click += new System.EventHandler(this.btn_CustomerPriceList_New_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_CustomerPriceList_SrchCost);
            this.panel3.Controls.Add(this.lbl_CustomerPriceList_SrchCost);
            this.panel3.Controls.Add(this.txt_CustomerPriceList_SrchCustName);
            this.panel3.Controls.Add(this.lbl_CustomerPriceList_SrchCustName);
            this.panel3.Controls.Add(this.txt_CustomerPriceList_SrchItemName);
            this.panel3.Controls.Add(this.lbl_CustomerPriceList_SrchItemName);
            this.panel3.Location = new System.Drawing.Point(13, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 61);
            this.panel3.TabIndex = 2;
            // 
            // txt_CustomerPriceList_SrchCost
            // 
            this.txt_CustomerPriceList_SrchCost.Location = new System.Drawing.Point(527, 27);
            this.txt_CustomerPriceList_SrchCost.Name = "txt_CustomerPriceList_SrchCost";
            this.txt_CustomerPriceList_SrchCost.Size = new System.Drawing.Size(186, 22);
            this.txt_CustomerPriceList_SrchCost.TabIndex = 6;
            this.txt_CustomerPriceList_SrchCost.TextChanged += new System.EventHandler(this.txt_CustomerPriceList_SrchCost_TextChanged);
            // 
            // lbl_CustomerPriceList_SrchCost
            // 
            this.lbl_CustomerPriceList_SrchCost.AutoSize = true;
            this.lbl_CustomerPriceList_SrchCost.Location = new System.Drawing.Point(524, 9);
            this.lbl_CustomerPriceList_SrchCost.Name = "lbl_CustomerPriceList_SrchCost";
            this.lbl_CustomerPriceList_SrchCost.Size = new System.Drawing.Size(32, 15);
            this.lbl_CustomerPriceList_SrchCost.TabIndex = 5;
            this.lbl_CustomerPriceList_SrchCost.Text = "Cost";
            // 
            // txt_CustomerPriceList_SrchCustName
            // 
            this.txt_CustomerPriceList_SrchCustName.Location = new System.Drawing.Point(249, 27);
            this.txt_CustomerPriceList_SrchCustName.Name = "txt_CustomerPriceList_SrchCustName";
            this.txt_CustomerPriceList_SrchCustName.Size = new System.Drawing.Size(229, 22);
            this.txt_CustomerPriceList_SrchCustName.TabIndex = 4;
            this.txt_CustomerPriceList_SrchCustName.TextChanged += new System.EventHandler(this.txt_CustomerPriceList_SrchCustName_TextChanged);
            // 
            // lbl_CustomerPriceList_SrchCustName
            // 
            this.lbl_CustomerPriceList_SrchCustName.AutoSize = true;
            this.lbl_CustomerPriceList_SrchCustName.Location = new System.Drawing.Point(246, 9);
            this.lbl_CustomerPriceList_SrchCustName.Name = "lbl_CustomerPriceList_SrchCustName";
            this.lbl_CustomerPriceList_SrchCustName.Size = new System.Drawing.Size(91, 15);
            this.lbl_CustomerPriceList_SrchCustName.TabIndex = 3;
            this.lbl_CustomerPriceList_SrchCustName.Text = "Customer Name";
            // 
            // txt_CustomerPriceList_SrchItemName
            // 
            this.txt_CustomerPriceList_SrchItemName.Location = new System.Drawing.Point(22, 27);
            this.txt_CustomerPriceList_SrchItemName.Name = "txt_CustomerPriceList_SrchItemName";
            this.txt_CustomerPriceList_SrchItemName.Size = new System.Drawing.Size(200, 22);
            this.txt_CustomerPriceList_SrchItemName.TabIndex = 2;
            this.txt_CustomerPriceList_SrchItemName.TextChanged += new System.EventHandler(this.txt_CustomerPriceList_SrchItemName_TextChanged);
            // 
            // lbl_CustomerPriceList_SrchItemName
            // 
            this.lbl_CustomerPriceList_SrchItemName.AutoSize = true;
            this.lbl_CustomerPriceList_SrchItemName.Location = new System.Drawing.Point(19, 9);
            this.lbl_CustomerPriceList_SrchItemName.Name = "lbl_CustomerPriceList_SrchItemName";
            this.lbl_CustomerPriceList_SrchItemName.Size = new System.Drawing.Size(63, 15);
            this.lbl_CustomerPriceList_SrchItemName.TabIndex = 1;
            this.lbl_CustomerPriceList_SrchItemName.Text = "Item Name";
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Location = new System.Drawing.Point(12, 272);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_item.Size = new System.Drawing.Size(757, 358);
            this.dgv_item.TabIndex = 5;
            this.dgv_item.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_item_CellDoubleClick);
            // 
            // frm_Transactions_CustomerPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 631);
            this.Controls.Add(this.dgv_item);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_CustomerPriceList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Price List";
            this.Load += new System.EventHandler(this.frm_Transactions_CustomerPriceList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dt_CustomerPriceList_BalanceDate;
        private System.Windows.Forms.Label lbl_CustomerPriceList_BalanceDate;
        private System.Windows.Forms.TextBox txt_CustomerPriceList_SellingPrice;
        private System.Windows.Forms.Label lbl_CustomerPriceList_SellingPrice;
        private System.Windows.Forms.TextBox txt_CustomerPriceList_Barcode;
        private System.Windows.Forms.Label lbl_CustomerPriceList_Barcode;
        private System.Windows.Forms.Label lbl_CustomerPriceList_CustName;
        private System.Windows.Forms.Label lbl_CustomerPriceList_ItemName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_CustomerPriceList_Close;
        private System.Windows.Forms.Button btn_CustomerPriceList_Save;
        private System.Windows.Forms.Button btn_CustomerPriceList_Delete;
        private System.Windows.Forms.Button btn_CustomerPriceList_Edit;
        private System.Windows.Forms.Button btn_CustomerPriceList_New;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_CustomerPriceList_SrchCost;
        private System.Windows.Forms.Label lbl_CustomerPriceList_SrchCost;
        private System.Windows.Forms.TextBox txt_CustomerPriceList_SrchCustName;
        private System.Windows.Forms.Label lbl_CustomerPriceList_SrchCustName;
        private System.Windows.Forms.TextBox txt_CustomerPriceList_SrchItemName;
        private System.Windows.Forms.Label lbl_CustomerPriceList_SrchItemName;
        private System.Windows.Forms.DataGridView dgv_item;
        private UControl.ucComboBox txt_CustomerPriceList_ItemName;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtCustomerid;
        private UControl.ucComboBox txt_CustomerPriceList_CustName;
    }
}