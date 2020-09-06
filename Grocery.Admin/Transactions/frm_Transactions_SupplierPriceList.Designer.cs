namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_SupplierPriceList
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
            this.txtSuppid = new System.Windows.Forms.TextBox();
            this.txt_SupplierName = new Grocery.Admin.UControl.ucComboBox();
            this.btn_SupplierPriceList_PrintPriceList = new System.Windows.Forms.Button();
            this.lbl_SupplierPriceList_SelectSupplierList = new System.Windows.Forms.Label();
            this.btn_SupplierPriceList_Search = new System.Windows.Forms.Button();
            this.txt_SupplierPriceList_ItemDetails = new System.Windows.Forms.TextBox();
            this.rb_SupplierPriceList_Barcode = new System.Windows.Forms.RadioButton();
            this.rb_SupplierPriceList_SubCategory = new System.Windows.Forms.RadioButton();
            this.rb_SupplierPriceList_Category = new System.Windows.Forms.RadioButton();
            this.rb_SupplierPriceList_ItemName = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSuppid);
            this.panel1.Controls.Add(this.txt_SupplierName);
            this.panel1.Controls.Add(this.btn_SupplierPriceList_PrintPriceList);
            this.panel1.Controls.Add(this.lbl_SupplierPriceList_SelectSupplierList);
            this.panel1.Controls.Add(this.btn_SupplierPriceList_Search);
            this.panel1.Controls.Add(this.txt_SupplierPriceList_ItemDetails);
            this.panel1.Controls.Add(this.rb_SupplierPriceList_Barcode);
            this.panel1.Controls.Add(this.rb_SupplierPriceList_SubCategory);
            this.panel1.Controls.Add(this.rb_SupplierPriceList_Category);
            this.panel1.Controls.Add(this.rb_SupplierPriceList_ItemName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 91);
            this.panel1.TabIndex = 0;
            // 
            // txtSuppid
            // 
            this.txtSuppid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSuppid.Location = new System.Drawing.Point(527, 49);
            this.txtSuppid.Name = "txtSuppid";
            this.txtSuppid.ReadOnly = true;
            this.txtSuppid.Size = new System.Drawing.Size(117, 22);
            this.txtSuppid.TabIndex = 36;
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.Location = new System.Drawing.Point(156, 49);
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.Size = new System.Drawing.Size(364, 22);
            this.txt_SupplierName.TabIndex = 35;
            this.txt_SupplierName.Tag = "SUPPLIER_LIST";
            // 
            // btn_SupplierPriceList_PrintPriceList
            // 
            this.btn_SupplierPriceList_PrintPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SupplierPriceList_PrintPriceList.Location = new System.Drawing.Point(650, 40);
            this.btn_SupplierPriceList_PrintPriceList.Name = "btn_SupplierPriceList_PrintPriceList";
            this.btn_SupplierPriceList_PrintPriceList.Size = new System.Drawing.Size(84, 46);
            this.btn_SupplierPriceList_PrintPriceList.TabIndex = 8;
            this.btn_SupplierPriceList_PrintPriceList.Text = "Print Price List";
            this.btn_SupplierPriceList_PrintPriceList.UseVisualStyleBackColor = true;
            // 
            // lbl_SupplierPriceList_SelectSupplierList
            // 
            this.lbl_SupplierPriceList_SelectSupplierList.AutoSize = true;
            this.lbl_SupplierPriceList_SelectSupplierList.Location = new System.Drawing.Point(10, 56);
            this.lbl_SupplierPriceList_SelectSupplierList.Name = "lbl_SupplierPriceList_SelectSupplierList";
            this.lbl_SupplierPriceList_SelectSupplierList.Size = new System.Drawing.Size(139, 15);
            this.lbl_SupplierPriceList_SelectSupplierList.TabIndex = 6;
            this.lbl_SupplierPriceList_SelectSupplierList.Text = "Select Supplier From List";
            // 
            // btn_SupplierPriceList_Search
            // 
            this.btn_SupplierPriceList_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SupplierPriceList_Search.Location = new System.Drawing.Point(650, 8);
            this.btn_SupplierPriceList_Search.Name = "btn_SupplierPriceList_Search";
            this.btn_SupplierPriceList_Search.Size = new System.Drawing.Size(84, 26);
            this.btn_SupplierPriceList_Search.TabIndex = 5;
            this.btn_SupplierPriceList_Search.Text = "Search";
            this.btn_SupplierPriceList_Search.UseVisualStyleBackColor = true;
            this.btn_SupplierPriceList_Search.Click += new System.EventHandler(this.btn_SupplierPriceList_Search_Click);
            // 
            // txt_SupplierPriceList_ItemDetails
            // 
            this.txt_SupplierPriceList_ItemDetails.Location = new System.Drawing.Point(362, 12);
            this.txt_SupplierPriceList_ItemDetails.Name = "txt_SupplierPriceList_ItemDetails";
            this.txt_SupplierPriceList_ItemDetails.Size = new System.Drawing.Size(282, 22);
            this.txt_SupplierPriceList_ItemDetails.TabIndex = 4;
            // 
            // rb_SupplierPriceList_Barcode
            // 
            this.rb_SupplierPriceList_Barcode.AutoSize = true;
            this.rb_SupplierPriceList_Barcode.Location = new System.Drawing.Point(286, 14);
            this.rb_SupplierPriceList_Barcode.Name = "rb_SupplierPriceList_Barcode";
            this.rb_SupplierPriceList_Barcode.Size = new System.Drawing.Size(69, 19);
            this.rb_SupplierPriceList_Barcode.TabIndex = 3;
            this.rb_SupplierPriceList_Barcode.TabStop = true;
            this.rb_SupplierPriceList_Barcode.Text = "Barcode";
            this.rb_SupplierPriceList_Barcode.UseVisualStyleBackColor = true;
            // 
            // rb_SupplierPriceList_SubCategory
            // 
            this.rb_SupplierPriceList_SubCategory.AutoSize = true;
            this.rb_SupplierPriceList_SubCategory.Location = new System.Drawing.Point(182, 15);
            this.rb_SupplierPriceList_SubCategory.Name = "rb_SupplierPriceList_SubCategory";
            this.rb_SupplierPriceList_SubCategory.Size = new System.Drawing.Size(98, 19);
            this.rb_SupplierPriceList_SubCategory.TabIndex = 2;
            this.rb_SupplierPriceList_SubCategory.TabStop = true;
            this.rb_SupplierPriceList_SubCategory.Text = "Sub Category";
            this.rb_SupplierPriceList_SubCategory.UseVisualStyleBackColor = true;
            // 
            // rb_SupplierPriceList_Category
            // 
            this.rb_SupplierPriceList_Category.AutoSize = true;
            this.rb_SupplierPriceList_Category.Location = new System.Drawing.Point(101, 14);
            this.rb_SupplierPriceList_Category.Name = "rb_SupplierPriceList_Category";
            this.rb_SupplierPriceList_Category.Size = new System.Drawing.Size(74, 19);
            this.rb_SupplierPriceList_Category.TabIndex = 1;
            this.rb_SupplierPriceList_Category.TabStop = true;
            this.rb_SupplierPriceList_Category.Text = "Category";
            this.rb_SupplierPriceList_Category.UseVisualStyleBackColor = true;
            // 
            // rb_SupplierPriceList_ItemName
            // 
            this.rb_SupplierPriceList_ItemName.AutoSize = true;
            this.rb_SupplierPriceList_ItemName.Location = new System.Drawing.Point(13, 13);
            this.rb_SupplierPriceList_ItemName.Name = "rb_SupplierPriceList_ItemName";
            this.rb_SupplierPriceList_ItemName.Size = new System.Drawing.Size(81, 19);
            this.rb_SupplierPriceList_ItemName.TabIndex = 0;
            this.rb_SupplierPriceList_ItemName.TabStop = true;
            this.rb_SupplierPriceList_ItemName.Text = "Item Name";
            this.rb_SupplierPriceList_ItemName.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(451, 426);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(553, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(655, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Location = new System.Drawing.Point(12, 111);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.Size = new System.Drawing.Size(739, 309);
            this.dgv_item.TabIndex = 5;
            // 
            // frm_Transactions_SupplierPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 461);
            this.Controls.Add(this.dgv_item);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_SupplierPriceList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions Supplier PriceList";
            this.Load += new System.EventHandler(this.frm_Transactions_SupplierPriceList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SupplierPriceList_PrintPriceList;
        private System.Windows.Forms.Label lbl_SupplierPriceList_SelectSupplierList;
        private System.Windows.Forms.Button btn_SupplierPriceList_Search;
        private System.Windows.Forms.TextBox txt_SupplierPriceList_ItemDetails;
        private System.Windows.Forms.RadioButton rb_SupplierPriceList_Barcode;
        private System.Windows.Forms.RadioButton rb_SupplierPriceList_SubCategory;
        private System.Windows.Forms.RadioButton rb_SupplierPriceList_Category;
        private System.Windows.Forms.RadioButton rb_SupplierPriceList_ItemName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSuppid;
        private UControl.ucComboBox txt_SupplierName;
        private System.Windows.Forms.DataGridView dgv_item;
    }
}