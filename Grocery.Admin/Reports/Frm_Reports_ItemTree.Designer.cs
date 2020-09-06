namespace Grocery.Admin.Reports
{
    partial class Frm_Reports_ItemTree
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
            this.gb_ItemTree_ItemInformation = new System.Windows.Forms.GroupBox();
            this.lbl_ItemTree_Barcode = new System.Windows.Forms.Label();
            this.txt_ItemTree_Barcode = new System.Windows.Forms.TextBox();
            this.txt_ItemTree_Category = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_Category = new System.Windows.Forms.Label();
            this.txt_ItemTree_ItemID = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_ItemID = new System.Windows.Forms.Label();
            this.txt_ItemTree_Name = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_Name = new System.Windows.Forms.Label();
            this.txt_ItemTree_BasicUOM = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_BasicUOM = new System.Windows.Forms.Label();
            this.txt_ItemTree_ReorderLevel = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_ReorderLevel = new System.Windows.Forms.Label();
            this.txt_ItemTree_SellingPrice = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_SellingPrice = new System.Windows.Forms.Label();
            this.txt_ItemTree_Cost = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_Cost = new System.Windows.Forms.Label();
            this.lbl_ItemTree_StockDate = new System.Windows.Forms.Label();
            this.txt_ItemTree_OpeningStock = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_OpeningStock = new System.Windows.Forms.Label();
            this.txt_ItemTree_CurrentStock = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_CurrentStock = new System.Windows.Forms.Label();
            this.txt_ItemTree_MainSupplier = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_MainSupplier = new System.Windows.Forms.Label();
            this.txt_ItemTree_LocalSupplier = new System.Windows.Forms.TextBox();
            this.lbl_ItemTree_LocalSupplier = new System.Windows.Forms.Label();
            this.GV_ItemTree_ItemDetails = new System.Windows.Forms.DataGridView();
            this.dt_ItemTree_StockDate = new System.Windows.Forms.DateTimePicker();
            this.tv_ItemTree_CategoryTree = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.gb_ItemTree_ItemInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemTree_ItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tv_ItemTree_CategoryTree);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 624);
            this.panel1.TabIndex = 0;
            // 
            // gb_ItemTree_ItemInformation
            // 
            this.gb_ItemTree_ItemInformation.Controls.Add(this.dt_ItemTree_StockDate);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.GV_ItemTree_ItemDetails);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_LocalSupplier);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_LocalSupplier);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_MainSupplier);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_MainSupplier);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_CurrentStock);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_CurrentStock);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_OpeningStock);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_OpeningStock);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_StockDate);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_Cost);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_Cost);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_SellingPrice);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_SellingPrice);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_ReorderLevel);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_ReorderLevel);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_BasicUOM);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_BasicUOM);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_Name);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_Name);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_ItemID);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_ItemID);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_Category);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_Category);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.txt_ItemTree_Barcode);
            this.gb_ItemTree_ItemInformation.Controls.Add(this.lbl_ItemTree_Barcode);
            this.gb_ItemTree_ItemInformation.Location = new System.Drawing.Point(362, 13);
            this.gb_ItemTree_ItemInformation.Name = "gb_ItemTree_ItemInformation";
            this.gb_ItemTree_ItemInformation.Size = new System.Drawing.Size(340, 624);
            this.gb_ItemTree_ItemInformation.TabIndex = 1;
            this.gb_ItemTree_ItemInformation.TabStop = false;
            this.gb_ItemTree_ItemInformation.Text = "Item Information";
            // 
            // lbl_ItemTree_Barcode
            // 
            this.lbl_ItemTree_Barcode.AutoSize = true;
            this.lbl_ItemTree_Barcode.Location = new System.Drawing.Point(7, 22);
            this.lbl_ItemTree_Barcode.Name = "lbl_ItemTree_Barcode";
            this.lbl_ItemTree_Barcode.Size = new System.Drawing.Size(51, 15);
            this.lbl_ItemTree_Barcode.TabIndex = 0;
            this.lbl_ItemTree_Barcode.Text = "Barcode";
            // 
            // txt_ItemTree_Barcode
            // 
            this.txt_ItemTree_Barcode.Location = new System.Drawing.Point(131, 22);
            this.txt_ItemTree_Barcode.Name = "txt_ItemTree_Barcode";
            this.txt_ItemTree_Barcode.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_Barcode.TabIndex = 1;
            // 
            // txt_ItemTree_Category
            // 
            this.txt_ItemTree_Category.Location = new System.Drawing.Point(131, 50);
            this.txt_ItemTree_Category.Name = "txt_ItemTree_Category";
            this.txt_ItemTree_Category.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_Category.TabIndex = 3;
            // 
            // lbl_ItemTree_Category
            // 
            this.lbl_ItemTree_Category.AutoSize = true;
            this.lbl_ItemTree_Category.Location = new System.Drawing.Point(7, 50);
            this.lbl_ItemTree_Category.Name = "lbl_ItemTree_Category";
            this.lbl_ItemTree_Category.Size = new System.Drawing.Size(56, 15);
            this.lbl_ItemTree_Category.TabIndex = 2;
            this.lbl_ItemTree_Category.Text = "Category";
            // 
            // txt_ItemTree_ItemID
            // 
            this.txt_ItemTree_ItemID.Location = new System.Drawing.Point(131, 78);
            this.txt_ItemTree_ItemID.Name = "txt_ItemTree_ItemID";
            this.txt_ItemTree_ItemID.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_ItemID.TabIndex = 5;
            // 
            // lbl_ItemTree_ItemID
            // 
            this.lbl_ItemTree_ItemID.AutoSize = true;
            this.lbl_ItemTree_ItemID.Location = new System.Drawing.Point(7, 78);
            this.lbl_ItemTree_ItemID.Name = "lbl_ItemTree_ItemID";
            this.lbl_ItemTree_ItemID.Size = new System.Drawing.Size(46, 15);
            this.lbl_ItemTree_ItemID.TabIndex = 4;
            this.lbl_ItemTree_ItemID.Text = "Item ID";
            // 
            // txt_ItemTree_Name
            // 
            this.txt_ItemTree_Name.Location = new System.Drawing.Point(131, 106);
            this.txt_ItemTree_Name.Name = "txt_ItemTree_Name";
            this.txt_ItemTree_Name.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_Name.TabIndex = 7;
            // 
            // lbl_ItemTree_Name
            // 
            this.lbl_ItemTree_Name.AutoSize = true;
            this.lbl_ItemTree_Name.Location = new System.Drawing.Point(7, 106);
            this.lbl_ItemTree_Name.Name = "lbl_ItemTree_Name";
            this.lbl_ItemTree_Name.Size = new System.Drawing.Size(37, 15);
            this.lbl_ItemTree_Name.TabIndex = 6;
            this.lbl_ItemTree_Name.Text = "Name";
            // 
            // txt_ItemTree_BasicUOM
            // 
            this.txt_ItemTree_BasicUOM.Location = new System.Drawing.Point(131, 134);
            this.txt_ItemTree_BasicUOM.Name = "txt_ItemTree_BasicUOM";
            this.txt_ItemTree_BasicUOM.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_BasicUOM.TabIndex = 9;
            // 
            // lbl_ItemTree_BasicUOM
            // 
            this.lbl_ItemTree_BasicUOM.AutoSize = true;
            this.lbl_ItemTree_BasicUOM.Location = new System.Drawing.Point(7, 134);
            this.lbl_ItemTree_BasicUOM.Name = "lbl_ItemTree_BasicUOM";
            this.lbl_ItemTree_BasicUOM.Size = new System.Drawing.Size(69, 15);
            this.lbl_ItemTree_BasicUOM.TabIndex = 8;
            this.lbl_ItemTree_BasicUOM.Text = "Basic UOM";
            // 
            // txt_ItemTree_ReorderLevel
            // 
            this.txt_ItemTree_ReorderLevel.Location = new System.Drawing.Point(131, 162);
            this.txt_ItemTree_ReorderLevel.Name = "txt_ItemTree_ReorderLevel";
            this.txt_ItemTree_ReorderLevel.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_ReorderLevel.TabIndex = 11;
            // 
            // lbl_ItemTree_ReorderLevel
            // 
            this.lbl_ItemTree_ReorderLevel.AutoSize = true;
            this.lbl_ItemTree_ReorderLevel.Location = new System.Drawing.Point(7, 162);
            this.lbl_ItemTree_ReorderLevel.Name = "lbl_ItemTree_ReorderLevel";
            this.lbl_ItemTree_ReorderLevel.Size = new System.Drawing.Size(81, 15);
            this.lbl_ItemTree_ReorderLevel.TabIndex = 10;
            this.lbl_ItemTree_ReorderLevel.Text = "Reorder Level";
            // 
            // txt_ItemTree_SellingPrice
            // 
            this.txt_ItemTree_SellingPrice.Location = new System.Drawing.Point(131, 190);
            this.txt_ItemTree_SellingPrice.Name = "txt_ItemTree_SellingPrice";
            this.txt_ItemTree_SellingPrice.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_SellingPrice.TabIndex = 13;
            // 
            // lbl_ItemTree_SellingPrice
            // 
            this.lbl_ItemTree_SellingPrice.AutoSize = true;
            this.lbl_ItemTree_SellingPrice.Location = new System.Drawing.Point(7, 190);
            this.lbl_ItemTree_SellingPrice.Name = "lbl_ItemTree_SellingPrice";
            this.lbl_ItemTree_SellingPrice.Size = new System.Drawing.Size(72, 15);
            this.lbl_ItemTree_SellingPrice.TabIndex = 12;
            this.lbl_ItemTree_SellingPrice.Text = "Selling Price";
            // 
            // txt_ItemTree_Cost
            // 
            this.txt_ItemTree_Cost.Location = new System.Drawing.Point(131, 218);
            this.txt_ItemTree_Cost.Name = "txt_ItemTree_Cost";
            this.txt_ItemTree_Cost.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_Cost.TabIndex = 15;
            // 
            // lbl_ItemTree_Cost
            // 
            this.lbl_ItemTree_Cost.AutoSize = true;
            this.lbl_ItemTree_Cost.Location = new System.Drawing.Point(7, 218);
            this.lbl_ItemTree_Cost.Name = "lbl_ItemTree_Cost";
            this.lbl_ItemTree_Cost.Size = new System.Drawing.Size(32, 15);
            this.lbl_ItemTree_Cost.TabIndex = 14;
            this.lbl_ItemTree_Cost.Text = "Cost";
            // 
            // lbl_ItemTree_StockDate
            // 
            this.lbl_ItemTree_StockDate.AutoSize = true;
            this.lbl_ItemTree_StockDate.Location = new System.Drawing.Point(7, 246);
            this.lbl_ItemTree_StockDate.Name = "lbl_ItemTree_StockDate";
            this.lbl_ItemTree_StockDate.Size = new System.Drawing.Size(65, 15);
            this.lbl_ItemTree_StockDate.TabIndex = 16;
            this.lbl_ItemTree_StockDate.Text = "Stock Date";
            // 
            // txt_ItemTree_OpeningStock
            // 
            this.txt_ItemTree_OpeningStock.Location = new System.Drawing.Point(131, 274);
            this.txt_ItemTree_OpeningStock.Name = "txt_ItemTree_OpeningStock";
            this.txt_ItemTree_OpeningStock.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_OpeningStock.TabIndex = 19;
            // 
            // lbl_ItemTree_OpeningStock
            // 
            this.lbl_ItemTree_OpeningStock.AutoSize = true;
            this.lbl_ItemTree_OpeningStock.Location = new System.Drawing.Point(7, 274);
            this.lbl_ItemTree_OpeningStock.Name = "lbl_ItemTree_OpeningStock";
            this.lbl_ItemTree_OpeningStock.Size = new System.Drawing.Size(86, 15);
            this.lbl_ItemTree_OpeningStock.TabIndex = 18;
            this.lbl_ItemTree_OpeningStock.Text = "Opening Stock";
            // 
            // txt_ItemTree_CurrentStock
            // 
            this.txt_ItemTree_CurrentStock.Location = new System.Drawing.Point(131, 302);
            this.txt_ItemTree_CurrentStock.Name = "txt_ItemTree_CurrentStock";
            this.txt_ItemTree_CurrentStock.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_CurrentStock.TabIndex = 21;
            // 
            // lbl_ItemTree_CurrentStock
            // 
            this.lbl_ItemTree_CurrentStock.AutoSize = true;
            this.lbl_ItemTree_CurrentStock.Location = new System.Drawing.Point(7, 302);
            this.lbl_ItemTree_CurrentStock.Name = "lbl_ItemTree_CurrentStock";
            this.lbl_ItemTree_CurrentStock.Size = new System.Drawing.Size(80, 15);
            this.lbl_ItemTree_CurrentStock.TabIndex = 20;
            this.lbl_ItemTree_CurrentStock.Text = "Current Stock";
            // 
            // txt_ItemTree_MainSupplier
            // 
            this.txt_ItemTree_MainSupplier.Location = new System.Drawing.Point(131, 330);
            this.txt_ItemTree_MainSupplier.Name = "txt_ItemTree_MainSupplier";
            this.txt_ItemTree_MainSupplier.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_MainSupplier.TabIndex = 3;
            // 
            // lbl_ItemTree_MainSupplier
            // 
            this.lbl_ItemTree_MainSupplier.AutoSize = true;
            this.lbl_ItemTree_MainSupplier.Location = new System.Drawing.Point(7, 330);
            this.lbl_ItemTree_MainSupplier.Name = "lbl_ItemTree_MainSupplier";
            this.lbl_ItemTree_MainSupplier.Size = new System.Drawing.Size(82, 15);
            this.lbl_ItemTree_MainSupplier.TabIndex = 2;
            this.lbl_ItemTree_MainSupplier.Text = "Main Supplier";
            // 
            // txt_ItemTree_LocalSupplier
            // 
            this.txt_ItemTree_LocalSupplier.Location = new System.Drawing.Point(131, 358);
            this.txt_ItemTree_LocalSupplier.Name = "txt_ItemTree_LocalSupplier";
            this.txt_ItemTree_LocalSupplier.Size = new System.Drawing.Size(176, 22);
            this.txt_ItemTree_LocalSupplier.TabIndex = 23;
            // 
            // lbl_ItemTree_LocalSupplier
            // 
            this.lbl_ItemTree_LocalSupplier.AutoSize = true;
            this.lbl_ItemTree_LocalSupplier.Location = new System.Drawing.Point(7, 358);
            this.lbl_ItemTree_LocalSupplier.Name = "lbl_ItemTree_LocalSupplier";
            this.lbl_ItemTree_LocalSupplier.Size = new System.Drawing.Size(83, 15);
            this.lbl_ItemTree_LocalSupplier.TabIndex = 22;
            this.lbl_ItemTree_LocalSupplier.Text = "Local Supplier";
            // 
            // GV_ItemTree_ItemDetails
            // 
            this.GV_ItemTree_ItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ItemTree_ItemDetails.Location = new System.Drawing.Point(6, 386);
            this.GV_ItemTree_ItemDetails.Name = "GV_ItemTree_ItemDetails";
            this.GV_ItemTree_ItemDetails.Size = new System.Drawing.Size(328, 232);
            this.GV_ItemTree_ItemDetails.TabIndex = 24;
            // 
            // dt_ItemTree_StockDate
            // 
            this.dt_ItemTree_StockDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ItemTree_StockDate.Location = new System.Drawing.Point(131, 247);
            this.dt_ItemTree_StockDate.Name = "dt_ItemTree_StockDate";
            this.dt_ItemTree_StockDate.Size = new System.Drawing.Size(176, 22);
            this.dt_ItemTree_StockDate.TabIndex = 25;
            // 
            // tv_ItemTree_CategoryTree
            // 
            this.tv_ItemTree_CategoryTree.Location = new System.Drawing.Point(16, 12);
            this.tv_ItemTree_CategoryTree.Name = "tv_ItemTree_CategoryTree";
            this.tv_ItemTree_CategoryTree.Size = new System.Drawing.Size(312, 605);
            this.tv_ItemTree_CategoryTree.TabIndex = 0;
            // 
            // Frm_Reports_ItemTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 649);
            this.Controls.Add(this.gb_ItemTree_ItemInformation);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Reports_ItemTree";
            this.Text = "Frm_Reports_ItemTree";
            this.panel1.ResumeLayout(false);
            this.gb_ItemTree_ItemInformation.ResumeLayout(false);
            this.gb_ItemTree_ItemInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemTree_ItemDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tv_ItemTree_CategoryTree;
        private System.Windows.Forms.GroupBox gb_ItemTree_ItemInformation;
        private System.Windows.Forms.DateTimePicker dt_ItemTree_StockDate;
        private System.Windows.Forms.DataGridView GV_ItemTree_ItemDetails;
        private System.Windows.Forms.TextBox txt_ItemTree_LocalSupplier;
        private System.Windows.Forms.Label lbl_ItemTree_LocalSupplier;
        private System.Windows.Forms.TextBox txt_ItemTree_MainSupplier;
        private System.Windows.Forms.Label lbl_ItemTree_MainSupplier;
        private System.Windows.Forms.TextBox txt_ItemTree_CurrentStock;
        private System.Windows.Forms.Label lbl_ItemTree_CurrentStock;
        private System.Windows.Forms.TextBox txt_ItemTree_OpeningStock;
        private System.Windows.Forms.Label lbl_ItemTree_OpeningStock;
        private System.Windows.Forms.Label lbl_ItemTree_StockDate;
        private System.Windows.Forms.TextBox txt_ItemTree_Cost;
        private System.Windows.Forms.Label lbl_ItemTree_Cost;
        private System.Windows.Forms.TextBox txt_ItemTree_SellingPrice;
        private System.Windows.Forms.Label lbl_ItemTree_SellingPrice;
        private System.Windows.Forms.TextBox txt_ItemTree_ReorderLevel;
        private System.Windows.Forms.Label lbl_ItemTree_ReorderLevel;
        private System.Windows.Forms.TextBox txt_ItemTree_BasicUOM;
        private System.Windows.Forms.Label lbl_ItemTree_BasicUOM;
        private System.Windows.Forms.TextBox txt_ItemTree_Name;
        private System.Windows.Forms.Label lbl_ItemTree_Name;
        private System.Windows.Forms.TextBox txt_ItemTree_ItemID;
        private System.Windows.Forms.Label lbl_ItemTree_ItemID;
        private System.Windows.Forms.TextBox txt_ItemTree_Category;
        private System.Windows.Forms.Label lbl_ItemTree_Category;
        private System.Windows.Forms.TextBox txt_ItemTree_Barcode;
        private System.Windows.Forms.Label lbl_ItemTree_Barcode;
    }
}