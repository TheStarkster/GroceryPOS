namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_ProfitScreen
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
            this.gb_ProfitScreen_OrderBy = new System.Windows.Forms.GroupBox();
            this.rb_ProfitScreen_Cost = new System.Windows.Forms.RadioButton();
            this.rb_ProfitScreen_Profit = new System.Windows.Forms.RadioButton();
            this.rb_ProfitScreen_SellingPrice = new System.Windows.Forms.RadioButton();
            this.cb_ProfitScreen_DescendingOrder = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_ProfitScreen_ItemName = new System.Windows.Forms.RadioButton();
            this.rb_ProfitScreen_ItemID = new System.Windows.Forms.RadioButton();
            this.rb_ProfitScreen_ItemCategory = new System.Windows.Forms.RadioButton();
            this.rb_ProfitScreen_ItemSubCategory = new System.Windows.Forms.RadioButton();
            this.rb_ProfitScreen_Barcode = new System.Windows.Forms.RadioButton();
            this.txt_ProfitScreen_Barcode = new System.Windows.Forms.TextBox();
            this.btn_ProfitScreen_Search = new System.Windows.Forms.Button();
            this.GV_ProfitScreen_ProfitDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ProfitScreen_Ok = new System.Windows.Forms.Button();
            this.btn_ProfitScreen_Cancel = new System.Windows.Forms.Button();
            this.gb_ProfitScreen_OrderBy.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ProfitScreen_ProfitDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ProfitScreen_OrderBy
            // 
            this.gb_ProfitScreen_OrderBy.Controls.Add(this.cb_ProfitScreen_DescendingOrder);
            this.gb_ProfitScreen_OrderBy.Controls.Add(this.rb_ProfitScreen_SellingPrice);
            this.gb_ProfitScreen_OrderBy.Controls.Add(this.rb_ProfitScreen_Profit);
            this.gb_ProfitScreen_OrderBy.Controls.Add(this.rb_ProfitScreen_Cost);
            this.gb_ProfitScreen_OrderBy.Location = new System.Drawing.Point(13, 5);
            this.gb_ProfitScreen_OrderBy.Name = "gb_ProfitScreen_OrderBy";
            this.gb_ProfitScreen_OrderBy.Size = new System.Drawing.Size(197, 79);
            this.gb_ProfitScreen_OrderBy.TabIndex = 0;
            this.gb_ProfitScreen_OrderBy.TabStop = false;
            this.gb_ProfitScreen_OrderBy.Text = "Order By";
            // 
            // rb_ProfitScreen_Cost
            // 
            this.rb_ProfitScreen_Cost.AutoSize = true;
            this.rb_ProfitScreen_Cost.Location = new System.Drawing.Point(7, 22);
            this.rb_ProfitScreen_Cost.Name = "rb_ProfitScreen_Cost";
            this.rb_ProfitScreen_Cost.Size = new System.Drawing.Size(50, 19);
            this.rb_ProfitScreen_Cost.TabIndex = 0;
            this.rb_ProfitScreen_Cost.TabStop = true;
            this.rb_ProfitScreen_Cost.Text = "Cost";
            this.rb_ProfitScreen_Cost.UseVisualStyleBackColor = true;
            // 
            // rb_ProfitScreen_Profit
            // 
            this.rb_ProfitScreen_Profit.AutoSize = true;
            this.rb_ProfitScreen_Profit.Location = new System.Drawing.Point(7, 47);
            this.rb_ProfitScreen_Profit.Name = "rb_ProfitScreen_Profit";
            this.rb_ProfitScreen_Profit.Size = new System.Drawing.Size(54, 19);
            this.rb_ProfitScreen_Profit.TabIndex = 1;
            this.rb_ProfitScreen_Profit.TabStop = true;
            this.rb_ProfitScreen_Profit.Text = "Profit";
            this.rb_ProfitScreen_Profit.UseVisualStyleBackColor = true;
            // 
            // rb_ProfitScreen_SellingPrice
            // 
            this.rb_ProfitScreen_SellingPrice.AutoSize = true;
            this.rb_ProfitScreen_SellingPrice.Location = new System.Drawing.Point(73, 22);
            this.rb_ProfitScreen_SellingPrice.Name = "rb_ProfitScreen_SellingPrice";
            this.rb_ProfitScreen_SellingPrice.Size = new System.Drawing.Size(90, 19);
            this.rb_ProfitScreen_SellingPrice.TabIndex = 2;
            this.rb_ProfitScreen_SellingPrice.TabStop = true;
            this.rb_ProfitScreen_SellingPrice.Text = "Selling Price";
            this.rb_ProfitScreen_SellingPrice.UseVisualStyleBackColor = true;
            // 
            // cb_ProfitScreen_DescendingOrder
            // 
            this.cb_ProfitScreen_DescendingOrder.AutoSize = true;
            this.cb_ProfitScreen_DescendingOrder.Location = new System.Drawing.Point(73, 48);
            this.cb_ProfitScreen_DescendingOrder.Name = "cb_ProfitScreen_DescendingOrder";
            this.cb_ProfitScreen_DescendingOrder.Size = new System.Drawing.Size(123, 19);
            this.cb_ProfitScreen_DescendingOrder.TabIndex = 3;
            this.cb_ProfitScreen_DescendingOrder.Text = "Descending Order";
            this.cb_ProfitScreen_DescendingOrder.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ProfitScreen_Search);
            this.panel1.Controls.Add(this.txt_ProfitScreen_Barcode);
            this.panel1.Controls.Add(this.rb_ProfitScreen_Barcode);
            this.panel1.Controls.Add(this.rb_ProfitScreen_ItemSubCategory);
            this.panel1.Controls.Add(this.rb_ProfitScreen_ItemCategory);
            this.panel1.Controls.Add(this.rb_ProfitScreen_ItemID);
            this.panel1.Controls.Add(this.rb_ProfitScreen_ItemName);
            this.panel1.Location = new System.Drawing.Point(217, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 71);
            this.panel1.TabIndex = 1;
            // 
            // rb_ProfitScreen_ItemName
            // 
            this.rb_ProfitScreen_ItemName.AutoSize = true;
            this.rb_ProfitScreen_ItemName.Location = new System.Drawing.Point(14, 13);
            this.rb_ProfitScreen_ItemName.Name = "rb_ProfitScreen_ItemName";
            this.rb_ProfitScreen_ItemName.Size = new System.Drawing.Size(81, 19);
            this.rb_ProfitScreen_ItemName.TabIndex = 1;
            this.rb_ProfitScreen_ItemName.TabStop = true;
            this.rb_ProfitScreen_ItemName.Text = "Item Name";
            this.rb_ProfitScreen_ItemName.UseVisualStyleBackColor = true;
            // 
            // rb_ProfitScreen_ItemID
            // 
            this.rb_ProfitScreen_ItemID.AutoSize = true;
            this.rb_ProfitScreen_ItemID.Location = new System.Drawing.Point(14, 39);
            this.rb_ProfitScreen_ItemID.Name = "rb_ProfitScreen_ItemID";
            this.rb_ProfitScreen_ItemID.Size = new System.Drawing.Size(64, 19);
            this.rb_ProfitScreen_ItemID.TabIndex = 2;
            this.rb_ProfitScreen_ItemID.TabStop = true;
            this.rb_ProfitScreen_ItemID.Text = "Item ID";
            this.rb_ProfitScreen_ItemID.UseVisualStyleBackColor = true;
            // 
            // rb_ProfitScreen_ItemCategory
            // 
            this.rb_ProfitScreen_ItemCategory.AutoSize = true;
            this.rb_ProfitScreen_ItemCategory.Location = new System.Drawing.Point(101, 13);
            this.rb_ProfitScreen_ItemCategory.Name = "rb_ProfitScreen_ItemCategory";
            this.rb_ProfitScreen_ItemCategory.Size = new System.Drawing.Size(100, 19);
            this.rb_ProfitScreen_ItemCategory.TabIndex = 3;
            this.rb_ProfitScreen_ItemCategory.TabStop = true;
            this.rb_ProfitScreen_ItemCategory.Text = "Item Category";
            this.rb_ProfitScreen_ItemCategory.UseVisualStyleBackColor = true;
            // 
            // rb_ProfitScreen_ItemSubCategory
            // 
            this.rb_ProfitScreen_ItemSubCategory.AutoSize = true;
            this.rb_ProfitScreen_ItemSubCategory.Location = new System.Drawing.Point(101, 38);
            this.rb_ProfitScreen_ItemSubCategory.Name = "rb_ProfitScreen_ItemSubCategory";
            this.rb_ProfitScreen_ItemSubCategory.Size = new System.Drawing.Size(121, 19);
            this.rb_ProfitScreen_ItemSubCategory.TabIndex = 4;
            this.rb_ProfitScreen_ItemSubCategory.TabStop = true;
            this.rb_ProfitScreen_ItemSubCategory.Text = "Item SubCategory";
            this.rb_ProfitScreen_ItemSubCategory.UseVisualStyleBackColor = true;
            // 
            // rb_ProfitScreen_Barcode
            // 
            this.rb_ProfitScreen_Barcode.AutoSize = true;
            this.rb_ProfitScreen_Barcode.Location = new System.Drawing.Point(253, 13);
            this.rb_ProfitScreen_Barcode.Name = "rb_ProfitScreen_Barcode";
            this.rb_ProfitScreen_Barcode.Size = new System.Drawing.Size(69, 19);
            this.rb_ProfitScreen_Barcode.TabIndex = 5;
            this.rb_ProfitScreen_Barcode.TabStop = true;
            this.rb_ProfitScreen_Barcode.Text = "Barcode";
            this.rb_ProfitScreen_Barcode.UseVisualStyleBackColor = true;
            // 
            // txt_ProfitScreen_Barcode
            // 
            this.txt_ProfitScreen_Barcode.Location = new System.Drawing.Point(253, 35);
            this.txt_ProfitScreen_Barcode.Name = "txt_ProfitScreen_Barcode";
            this.txt_ProfitScreen_Barcode.Size = new System.Drawing.Size(348, 22);
            this.txt_ProfitScreen_Barcode.TabIndex = 6;
            // 
            // btn_ProfitScreen_Search
            // 
            this.btn_ProfitScreen_Search.Location = new System.Drawing.Point(607, 13);
            this.btn_ProfitScreen_Search.Name = "btn_ProfitScreen_Search";
            this.btn_ProfitScreen_Search.Size = new System.Drawing.Size(75, 44);
            this.btn_ProfitScreen_Search.TabIndex = 2;
            this.btn_ProfitScreen_Search.Text = "Search";
            this.btn_ProfitScreen_Search.UseVisualStyleBackColor = true;
            // 
            // GV_ProfitScreen_ProfitDetails
            // 
            this.GV_ProfitScreen_ProfitDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ProfitScreen_ProfitDetails.Location = new System.Drawing.Point(13, 91);
            this.GV_ProfitScreen_ProfitDetails.Name = "GV_ProfitScreen_ProfitDetails";
            this.GV_ProfitScreen_ProfitDetails.Size = new System.Drawing.Size(898, 292);
            this.GV_ProfitScreen_ProfitDetails.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_ProfitScreen_Cancel);
            this.panel2.Controls.Add(this.btn_ProfitScreen_Ok);
            this.panel2.Location = new System.Drawing.Point(13, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 45);
            this.panel2.TabIndex = 3;
            // 
            // btn_ProfitScreen_Ok
            // 
            this.btn_ProfitScreen_Ok.Location = new System.Drawing.Point(730, 3);
            this.btn_ProfitScreen_Ok.Name = "btn_ProfitScreen_Ok";
            this.btn_ProfitScreen_Ok.Size = new System.Drawing.Size(75, 38);
            this.btn_ProfitScreen_Ok.TabIndex = 3;
            this.btn_ProfitScreen_Ok.Text = "OK";
            this.btn_ProfitScreen_Ok.UseVisualStyleBackColor = true;
            // 
            // btn_ProfitScreen_Cancel
            // 
            this.btn_ProfitScreen_Cancel.Location = new System.Drawing.Point(811, 3);
            this.btn_ProfitScreen_Cancel.Name = "btn_ProfitScreen_Cancel";
            this.btn_ProfitScreen_Cancel.Size = new System.Drawing.Size(75, 38);
            this.btn_ProfitScreen_Cancel.TabIndex = 4;
            this.btn_ProfitScreen_Cancel.Text = "Cancel";
            this.btn_ProfitScreen_Cancel.UseVisualStyleBackColor = true;
            // 
            // Frm_Reports_ProfitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GV_ProfitScreen_ProfitDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_ProfitScreen_OrderBy);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_ProfitScreen";
            this.Text = "Frm_Reports_ProfitScreen";
            this.gb_ProfitScreen_OrderBy.ResumeLayout(false);
            this.gb_ProfitScreen_OrderBy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ProfitScreen_ProfitDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ProfitScreen_OrderBy;
        private System.Windows.Forms.CheckBox cb_ProfitScreen_DescendingOrder;
        private System.Windows.Forms.RadioButton rb_ProfitScreen_SellingPrice;
        private System.Windows.Forms.RadioButton rb_ProfitScreen_Profit;
        private System.Windows.Forms.RadioButton rb_ProfitScreen_Cost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ProfitScreen_Search;
        private System.Windows.Forms.TextBox txt_ProfitScreen_Barcode;
        private System.Windows.Forms.RadioButton rb_ProfitScreen_Barcode;
        private System.Windows.Forms.RadioButton rb_ProfitScreen_ItemSubCategory;
        private System.Windows.Forms.RadioButton rb_ProfitScreen_ItemCategory;
        private System.Windows.Forms.RadioButton rb_ProfitScreen_ItemID;
        private System.Windows.Forms.RadioButton rb_ProfitScreen_ItemName;
        private System.Windows.Forms.DataGridView GV_ProfitScreen_ProfitDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ProfitScreen_Cancel;
        private System.Windows.Forms.Button btn_ProfitScreen_Ok;
    }
}