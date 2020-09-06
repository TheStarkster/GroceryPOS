namespace Grocery.Admin.Master
{
    partial class Frm_Master_ItemListingMaster
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ItemListing_RowCount = new System.Windows.Forms.Label();
            this.cob_ItemListing_RowCount = new System.Windows.Forms.ComboBox();
            this.cob_ItemListing_SrchMethod = new System.Windows.Forms.ComboBox();
            this.lbl_ItemListing_SrchMethod = new System.Windows.Forms.Label();
            this.lbl_ItemListing_F1ItemName = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_F2Barcode = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_F3Category = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_F4SubCategory = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_F5Supplier = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_F6Brand = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_F7Cost = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_F8SellPrice = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_CntrlRItemRef = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_CntrlMModel = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_CntrlOColor = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_CntrlESize = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_CntrlNArt = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_F12All = new System.Windows.Forms.LinkLabel();
            this.gb_ItemListing_ItemExport = new System.Windows.Forms.GroupBox();
            this.btn_ItemListing_EportToTextFile = new System.Windows.Forms.Button();
            this.btn_ItemListing_ExportToExcelFile = new System.Windows.Forms.Button();
            this.txt_ItemListing_ItemExport = new System.Windows.Forms.TextBox();
            this.lbl_ItemListing_PDTDataFile = new System.Windows.Forms.LinkLabel();
            this.GV_ItemListing_ItemListing = new System.Windows.Forms.DataGridView();
            this.lbl_ItemListing_ItemMultiEdit = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_BarcodeBlocking = new System.Windows.Forms.LinkLabel();
            this.lbl_ItemListing_WeighingScaleItems = new System.Windows.Forms.LinkLabel();
            this.cb_ItemListing_ReorderItems = new System.Windows.Forms.CheckBox();
            this.txt_ItemListing_CurrentCriteria = new System.Windows.Forms.TextBox();
            this.lbl_ItemListing_CurrentCriteria = new System.Windows.Forms.Label();
            this.btn_ItemListing_SrchCurrentCriteria = new System.Windows.Forms.Button();
            this.lbl_ItemListing_RowCountInfo = new System.Windows.Forms.Label();
            this.lbl_ItemListing_BarcodeInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_ItemListing_ItemExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemListing_ItemListing)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ItemListing_BarcodeInfo);
            this.groupBox1.Controls.Add(this.lbl_ItemListing_RowCountInfo);
            this.groupBox1.Controls.Add(this.btn_ItemListing_SrchCurrentCriteria);
            this.groupBox1.Controls.Add(this.lbl_ItemListing_CurrentCriteria);
            this.groupBox1.Controls.Add(this.txt_ItemListing_CurrentCriteria);
            this.groupBox1.Controls.Add(this.cb_ItemListing_ReorderItems);
            this.groupBox1.Controls.Add(this.lbl_ItemListing_WeighingScaleItems);
            this.groupBox1.Controls.Add(this.lbl_ItemListing_BarcodeBlocking);
            this.groupBox1.Controls.Add(this.lbl_ItemListing_ItemMultiEdit);
            this.groupBox1.Controls.Add(this.GV_ItemListing_ItemListing);
            this.groupBox1.Controls.Add(this.lbl_ItemListing_PDTDataFile);
            this.groupBox1.Controls.Add(this.gb_ItemListing_ItemExport);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 721);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searched Item Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_ItemListing_F12All);
            this.panel1.Controls.Add(this.lbl_ItemListing_CntrlNArt);
            this.panel1.Controls.Add(this.lbl_ItemListing_CntrlESize);
            this.panel1.Controls.Add(this.lbl_ItemListing_CntrlOColor);
            this.panel1.Controls.Add(this.lbl_ItemListing_CntrlMModel);
            this.panel1.Controls.Add(this.lbl_ItemListing_CntrlRItemRef);
            this.panel1.Controls.Add(this.lbl_ItemListing_F8SellPrice);
            this.panel1.Controls.Add(this.lbl_ItemListing_F7Cost);
            this.panel1.Controls.Add(this.lbl_ItemListing_F6Brand);
            this.panel1.Controls.Add(this.lbl_ItemListing_F5Supplier);
            this.panel1.Controls.Add(this.lbl_ItemListing_F4SubCategory);
            this.panel1.Controls.Add(this.lbl_ItemListing_F3Category);
            this.panel1.Controls.Add(this.lbl_ItemListing_F2Barcode);
            this.panel1.Controls.Add(this.lbl_ItemListing_F1ItemName);
            this.panel1.Controls.Add(this.cob_ItemListing_SrchMethod);
            this.panel1.Controls.Add(this.lbl_ItemListing_SrchMethod);
            this.panel1.Controls.Add(this.cob_ItemListing_RowCount);
            this.panel1.Controls.Add(this.lbl_ItemListing_RowCount);
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 440);
            this.panel1.TabIndex = 0;
            // 
            // lbl_ItemListing_RowCount
            // 
            this.lbl_ItemListing_RowCount.AutoSize = true;
            this.lbl_ItemListing_RowCount.Location = new System.Drawing.Point(4, 10);
            this.lbl_ItemListing_RowCount.Name = "lbl_ItemListing_RowCount";
            this.lbl_ItemListing_RowCount.Size = new System.Drawing.Size(67, 15);
            this.lbl_ItemListing_RowCount.TabIndex = 0;
            this.lbl_ItemListing_RowCount.Text = "Row Count";
            // 
            // cob_ItemListing_RowCount
            // 
            this.cob_ItemListing_RowCount.FormattingEnabled = true;
            this.cob_ItemListing_RowCount.Location = new System.Drawing.Point(3, 28);
            this.cob_ItemListing_RowCount.Name = "cob_ItemListing_RowCount";
            this.cob_ItemListing_RowCount.Size = new System.Drawing.Size(130, 23);
            this.cob_ItemListing_RowCount.TabIndex = 1;
            // 
            // cob_ItemListing_SrchMethod
            // 
            this.cob_ItemListing_SrchMethod.FormattingEnabled = true;
            this.cob_ItemListing_SrchMethod.Location = new System.Drawing.Point(3, 72);
            this.cob_ItemListing_SrchMethod.Name = "cob_ItemListing_SrchMethod";
            this.cob_ItemListing_SrchMethod.Size = new System.Drawing.Size(130, 23);
            this.cob_ItemListing_SrchMethod.TabIndex = 3;
            // 
            // lbl_ItemListing_SrchMethod
            // 
            this.lbl_ItemListing_SrchMethod.AutoSize = true;
            this.lbl_ItemListing_SrchMethod.Location = new System.Drawing.Point(3, 54);
            this.lbl_ItemListing_SrchMethod.Name = "lbl_ItemListing_SrchMethod";
            this.lbl_ItemListing_SrchMethod.Size = new System.Drawing.Size(89, 15);
            this.lbl_ItemListing_SrchMethod.TabIndex = 2;
            this.lbl_ItemListing_SrchMethod.Text = "Search Method";
            // 
            // lbl_ItemListing_F1ItemName
            // 
            this.lbl_ItemListing_F1ItemName.AutoSize = true;
            this.lbl_ItemListing_F1ItemName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_F1ItemName.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_F1ItemName.Location = new System.Drawing.Point(16, 98);
            this.lbl_ItemListing_F1ItemName.Name = "lbl_ItemListing_F1ItemName";
            this.lbl_ItemListing_F1ItemName.Size = new System.Drawing.Size(86, 15);
            this.lbl_ItemListing_F1ItemName.TabIndex = 4;
            this.lbl_ItemListing_F1ItemName.TabStop = true;
            this.lbl_ItemListing_F1ItemName.Text = "F1 - Item Name";
            // 
            // lbl_ItemListing_F2Barcode
            // 
            this.lbl_ItemListing_F2Barcode.AutoSize = true;
            this.lbl_ItemListing_F2Barcode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_F2Barcode.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_F2Barcode.Location = new System.Drawing.Point(16, 122);
            this.lbl_ItemListing_F2Barcode.Name = "lbl_ItemListing_F2Barcode";
            this.lbl_ItemListing_F2Barcode.Size = new System.Drawing.Size(74, 15);
            this.lbl_ItemListing_F2Barcode.TabIndex = 5;
            this.lbl_ItemListing_F2Barcode.TabStop = true;
            this.lbl_ItemListing_F2Barcode.Text = "F2 - Barcode";
            // 
            // lbl_ItemListing_F3Category
            // 
            this.lbl_ItemListing_F3Category.AutoSize = true;
            this.lbl_ItemListing_F3Category.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_F3Category.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_F3Category.Location = new System.Drawing.Point(16, 147);
            this.lbl_ItemListing_F3Category.Name = "lbl_ItemListing_F3Category";
            this.lbl_ItemListing_F3Category.Size = new System.Drawing.Size(79, 15);
            this.lbl_ItemListing_F3Category.TabIndex = 6;
            this.lbl_ItemListing_F3Category.TabStop = true;
            this.lbl_ItemListing_F3Category.Text = "F3 - Category";
            // 
            // lbl_ItemListing_F4SubCategory
            // 
            this.lbl_ItemListing_F4SubCategory.AutoSize = true;
            this.lbl_ItemListing_F4SubCategory.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_F4SubCategory.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_F4SubCategory.Location = new System.Drawing.Point(16, 171);
            this.lbl_ItemListing_F4SubCategory.Name = "lbl_ItemListing_F4SubCategory";
            this.lbl_ItemListing_F4SubCategory.Size = new System.Drawing.Size(103, 15);
            this.lbl_ItemListing_F4SubCategory.TabIndex = 7;
            this.lbl_ItemListing_F4SubCategory.TabStop = true;
            this.lbl_ItemListing_F4SubCategory.Text = "F4 - Sub Category";
            // 
            // lbl_ItemListing_F5Supplier
            // 
            this.lbl_ItemListing_F5Supplier.AutoSize = true;
            this.lbl_ItemListing_F5Supplier.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_F5Supplier.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_F5Supplier.Location = new System.Drawing.Point(16, 196);
            this.lbl_ItemListing_F5Supplier.Name = "lbl_ItemListing_F5Supplier";
            this.lbl_ItemListing_F5Supplier.Size = new System.Drawing.Size(74, 15);
            this.lbl_ItemListing_F5Supplier.TabIndex = 8;
            this.lbl_ItemListing_F5Supplier.TabStop = true;
            this.lbl_ItemListing_F5Supplier.Text = "F5 - Supplier";
            // 
            // lbl_ItemListing_F6Brand
            // 
            this.lbl_ItemListing_F6Brand.AutoSize = true;
            this.lbl_ItemListing_F6Brand.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_F6Brand.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_F6Brand.Location = new System.Drawing.Point(16, 221);
            this.lbl_ItemListing_F6Brand.Name = "lbl_ItemListing_F6Brand";
            this.lbl_ItemListing_F6Brand.Size = new System.Drawing.Size(62, 15);
            this.lbl_ItemListing_F6Brand.TabIndex = 9;
            this.lbl_ItemListing_F6Brand.TabStop = true;
            this.lbl_ItemListing_F6Brand.Text = "F6 - Brand";
            // 
            // lbl_ItemListing_F7Cost
            // 
            this.lbl_ItemListing_F7Cost.AutoSize = true;
            this.lbl_ItemListing_F7Cost.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_F7Cost.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_F7Cost.Location = new System.Drawing.Point(16, 245);
            this.lbl_ItemListing_F7Cost.Name = "lbl_ItemListing_F7Cost";
            this.lbl_ItemListing_F7Cost.Size = new System.Drawing.Size(55, 15);
            this.lbl_ItemListing_F7Cost.TabIndex = 10;
            this.lbl_ItemListing_F7Cost.TabStop = true;
            this.lbl_ItemListing_F7Cost.Text = "F7 - Cost";
            // 
            // lbl_ItemListing_F8SellPrice
            // 
            this.lbl_ItemListing_F8SellPrice.AutoSize = true;
            this.lbl_ItemListing_F8SellPrice.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_F8SellPrice.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_F8SellPrice.Location = new System.Drawing.Point(16, 270);
            this.lbl_ItemListing_F8SellPrice.Name = "lbl_ItemListing_F8SellPrice";
            this.lbl_ItemListing_F8SellPrice.Size = new System.Drawing.Size(78, 15);
            this.lbl_ItemListing_F8SellPrice.TabIndex = 11;
            this.lbl_ItemListing_F8SellPrice.TabStop = true;
            this.lbl_ItemListing_F8SellPrice.Text = "F8 - Sell Price";
            // 
            // lbl_ItemListing_CntrlRItemRef
            // 
            this.lbl_ItemListing_CntrlRItemRef.AutoSize = true;
            this.lbl_ItemListing_CntrlRItemRef.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_CntrlRItemRef.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_CntrlRItemRef.Location = new System.Drawing.Point(16, 294);
            this.lbl_ItemListing_CntrlRItemRef.Name = "lbl_ItemListing_CntrlRItemRef";
            this.lbl_ItemListing_CntrlRItemRef.Size = new System.Drawing.Size(98, 15);
            this.lbl_ItemListing_CntrlRItemRef.TabIndex = 12;
            this.lbl_ItemListing_CntrlRItemRef.TabStop = true;
            this.lbl_ItemListing_CntrlRItemRef.Text = "Cntrl R - Item Ref";
            // 
            // lbl_ItemListing_CntrlMModel
            // 
            this.lbl_ItemListing_CntrlMModel.AutoSize = true;
            this.lbl_ItemListing_CntrlMModel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_CntrlMModel.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_CntrlMModel.Location = new System.Drawing.Point(16, 318);
            this.lbl_ItemListing_CntrlMModel.Name = "lbl_ItemListing_CntrlMModel";
            this.lbl_ItemListing_CntrlMModel.Size = new System.Drawing.Size(93, 15);
            this.lbl_ItemListing_CntrlMModel.TabIndex = 13;
            this.lbl_ItemListing_CntrlMModel.TabStop = true;
            this.lbl_ItemListing_CntrlMModel.Text = "Cntrl M - Model";
            // 
            // lbl_ItemListing_CntrlOColor
            // 
            this.lbl_ItemListing_CntrlOColor.AutoSize = true;
            this.lbl_ItemListing_CntrlOColor.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_CntrlOColor.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_CntrlOColor.Location = new System.Drawing.Point(16, 342);
            this.lbl_ItemListing_CntrlOColor.Name = "lbl_ItemListing_CntrlOColor";
            this.lbl_ItemListing_CntrlOColor.Size = new System.Drawing.Size(84, 15);
            this.lbl_ItemListing_CntrlOColor.TabIndex = 14;
            this.lbl_ItemListing_CntrlOColor.TabStop = true;
            this.lbl_ItemListing_CntrlOColor.Text = "Cntrl O - Color";
            // 
            // lbl_ItemListing_CntrlESize
            // 
            this.lbl_ItemListing_CntrlESize.AutoSize = true;
            this.lbl_ItemListing_CntrlESize.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_CntrlESize.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_CntrlESize.Location = new System.Drawing.Point(16, 367);
            this.lbl_ItemListing_CntrlESize.Name = "lbl_ItemListing_CntrlESize";
            this.lbl_ItemListing_CntrlESize.Size = new System.Drawing.Size(74, 15);
            this.lbl_ItemListing_CntrlESize.TabIndex = 15;
            this.lbl_ItemListing_CntrlESize.TabStop = true;
            this.lbl_ItemListing_CntrlESize.Text = "Cntrl E - Size";
            // 
            // lbl_ItemListing_CntrlNArt
            // 
            this.lbl_ItemListing_CntrlNArt.AutoSize = true;
            this.lbl_ItemListing_CntrlNArt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_CntrlNArt.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_CntrlNArt.Location = new System.Drawing.Point(16, 392);
            this.lbl_ItemListing_CntrlNArt.Name = "lbl_ItemListing_CntrlNArt";
            this.lbl_ItemListing_CntrlNArt.Size = new System.Drawing.Size(72, 15);
            this.lbl_ItemListing_CntrlNArt.TabIndex = 16;
            this.lbl_ItemListing_CntrlNArt.TabStop = true;
            this.lbl_ItemListing_CntrlNArt.Text = "Cntrl N - Art";
            // 
            // lbl_ItemListing_F12All
            // 
            this.lbl_ItemListing_F12All.AutoSize = true;
            this.lbl_ItemListing_F12All.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_ItemListing_F12All.LinkColor = System.Drawing.Color.Black;
            this.lbl_ItemListing_F12All.Location = new System.Drawing.Point(16, 416);
            this.lbl_ItemListing_F12All.Name = "lbl_ItemListing_F12All";
            this.lbl_ItemListing_F12All.Size = new System.Drawing.Size(51, 15);
            this.lbl_ItemListing_F12All.TabIndex = 17;
            this.lbl_ItemListing_F12All.TabStop = true;
            this.lbl_ItemListing_F12All.Text = "F12 - All";
            // 
            // gb_ItemListing_ItemExport
            // 
            this.gb_ItemListing_ItemExport.Controls.Add(this.txt_ItemListing_ItemExport);
            this.gb_ItemListing_ItemExport.Controls.Add(this.btn_ItemListing_ExportToExcelFile);
            this.gb_ItemListing_ItemExport.Controls.Add(this.btn_ItemListing_EportToTextFile);
            this.gb_ItemListing_ItemExport.Location = new System.Drawing.Point(6, 513);
            this.gb_ItemListing_ItemExport.Name = "gb_ItemListing_ItemExport";
            this.gb_ItemListing_ItemExport.Size = new System.Drawing.Size(133, 156);
            this.gb_ItemListing_ItemExport.TabIndex = 1;
            this.gb_ItemListing_ItemExport.TabStop = false;
            this.gb_ItemListing_ItemExport.Text = "Item Export";
            // 
            // btn_ItemListing_EportToTextFile
            // 
            this.btn_ItemListing_EportToTextFile.Location = new System.Drawing.Point(13, 21);
            this.btn_ItemListing_EportToTextFile.Name = "btn_ItemListing_EportToTextFile";
            this.btn_ItemListing_EportToTextFile.Size = new System.Drawing.Size(106, 47);
            this.btn_ItemListing_EportToTextFile.TabIndex = 0;
            this.btn_ItemListing_EportToTextFile.Text = "Export To Text File";
            this.btn_ItemListing_EportToTextFile.UseVisualStyleBackColor = true;
            // 
            // btn_ItemListing_ExportToExcelFile
            // 
            this.btn_ItemListing_ExportToExcelFile.Location = new System.Drawing.Point(13, 76);
            this.btn_ItemListing_ExportToExcelFile.Name = "btn_ItemListing_ExportToExcelFile";
            this.btn_ItemListing_ExportToExcelFile.Size = new System.Drawing.Size(106, 47);
            this.btn_ItemListing_ExportToExcelFile.TabIndex = 1;
            this.btn_ItemListing_ExportToExcelFile.Text = "Export To Excel File";
            this.btn_ItemListing_ExportToExcelFile.UseVisualStyleBackColor = true;
            // 
            // txt_ItemListing_ItemExport
            // 
            this.txt_ItemListing_ItemExport.Location = new System.Drawing.Point(14, 129);
            this.txt_ItemListing_ItemExport.Name = "txt_ItemListing_ItemExport";
            this.txt_ItemListing_ItemExport.Size = new System.Drawing.Size(105, 22);
            this.txt_ItemListing_ItemExport.TabIndex = 2;
            // 
            // lbl_ItemListing_PDTDataFile
            // 
            this.lbl_ItemListing_PDTDataFile.AutoSize = true;
            this.lbl_ItemListing_PDTDataFile.Location = new System.Drawing.Point(13, 671);
            this.lbl_ItemListing_PDTDataFile.Name = "lbl_ItemListing_PDTDataFile";
            this.lbl_ItemListing_PDTDataFile.Size = new System.Drawing.Size(105, 15);
            this.lbl_ItemListing_PDTDataFile.TabIndex = 2;
            this.lbl_ItemListing_PDTDataFile.TabStop = true;
            this.lbl_ItemListing_PDTDataFile.Text = "PDT Data File (F9)";
            // 
            // GV_ItemListing_ItemListing
            // 
            this.GV_ItemListing_ItemListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ItemListing_ItemListing.Location = new System.Drawing.Point(149, 67);
            this.GV_ItemListing_ItemListing.Name = "GV_ItemListing_ItemListing";
            this.GV_ItemListing_ItemListing.Size = new System.Drawing.Size(1088, 648);
            this.GV_ItemListing_ItemListing.TabIndex = 3;
            // 
            // lbl_ItemListing_ItemMultiEdit
            // 
            this.lbl_ItemListing_ItemMultiEdit.AutoSize = true;
            this.lbl_ItemListing_ItemMultiEdit.Location = new System.Drawing.Point(463, 12);
            this.lbl_ItemListing_ItemMultiEdit.Name = "lbl_ItemListing_ItemMultiEdit";
            this.lbl_ItemListing_ItemMultiEdit.Size = new System.Drawing.Size(86, 15);
            this.lbl_ItemListing_ItemMultiEdit.TabIndex = 4;
            this.lbl_ItemListing_ItemMultiEdit.TabStop = true;
            this.lbl_ItemListing_ItemMultiEdit.Text = "Item Multi Edit";
            // 
            // lbl_ItemListing_BarcodeBlocking
            // 
            this.lbl_ItemListing_BarcodeBlocking.AutoSize = true;
            this.lbl_ItemListing_BarcodeBlocking.Location = new System.Drawing.Point(463, 40);
            this.lbl_ItemListing_BarcodeBlocking.Name = "lbl_ItemListing_BarcodeBlocking";
            this.lbl_ItemListing_BarcodeBlocking.Size = new System.Drawing.Size(101, 15);
            this.lbl_ItemListing_BarcodeBlocking.TabIndex = 5;
            this.lbl_ItemListing_BarcodeBlocking.TabStop = true;
            this.lbl_ItemListing_BarcodeBlocking.Text = "Barcode Blocking";
            // 
            // lbl_ItemListing_WeighingScaleItems
            // 
            this.lbl_ItemListing_WeighingScaleItems.AutoSize = true;
            this.lbl_ItemListing_WeighingScaleItems.Location = new System.Drawing.Point(572, 12);
            this.lbl_ItemListing_WeighingScaleItems.Name = "lbl_ItemListing_WeighingScaleItems";
            this.lbl_ItemListing_WeighingScaleItems.Size = new System.Drawing.Size(122, 15);
            this.lbl_ItemListing_WeighingScaleItems.TabIndex = 6;
            this.lbl_ItemListing_WeighingScaleItems.TabStop = true;
            this.lbl_ItemListing_WeighingScaleItems.Text = "Weighing Scale Items";
            // 
            // cb_ItemListing_ReorderItems
            // 
            this.cb_ItemListing_ReorderItems.AutoSize = true;
            this.cb_ItemListing_ReorderItems.Location = new System.Drawing.Point(655, 41);
            this.cb_ItemListing_ReorderItems.Name = "cb_ItemListing_ReorderItems";
            this.cb_ItemListing_ReorderItems.Size = new System.Drawing.Size(129, 19);
            this.cb_ItemListing_ReorderItems.TabIndex = 7;
            this.cb_ItemListing_ReorderItems.Text = "Reorder Items Only";
            this.cb_ItemListing_ReorderItems.UseVisualStyleBackColor = true;
            // 
            // txt_ItemListing_CurrentCriteria
            // 
            this.txt_ItemListing_CurrentCriteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_ItemListing_CurrentCriteria.Location = new System.Drawing.Point(790, 40);
            this.txt_ItemListing_CurrentCriteria.Name = "txt_ItemListing_CurrentCriteria";
            this.txt_ItemListing_CurrentCriteria.Size = new System.Drawing.Size(407, 22);
            this.txt_ItemListing_CurrentCriteria.TabIndex = 8;
            // 
            // lbl_ItemListing_CurrentCriteria
            // 
            this.lbl_ItemListing_CurrentCriteria.AutoSize = true;
            this.lbl_ItemListing_CurrentCriteria.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemListing_CurrentCriteria.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_ItemListing_CurrentCriteria.Location = new System.Drawing.Point(787, 12);
            this.lbl_ItemListing_CurrentCriteria.Name = "lbl_ItemListing_CurrentCriteria";
            this.lbl_ItemListing_CurrentCriteria.Size = new System.Drawing.Size(168, 15);
            this.lbl_ItemListing_CurrentCriteria.TabIndex = 9;
            this.lbl_ItemListing_CurrentCriteria.Text = "Current Criteria : Item Name";
            // 
            // btn_ItemListing_SrchCurrentCriteria
            // 
            this.btn_ItemListing_SrchCurrentCriteria.Image = global::Grocery.Admin.Properties.Resources.Zoom_icon;
            this.btn_ItemListing_SrchCurrentCriteria.Location = new System.Drawing.Point(1203, 25);
            this.btn_ItemListing_SrchCurrentCriteria.Name = "btn_ItemListing_SrchCurrentCriteria";
            this.btn_ItemListing_SrchCurrentCriteria.Size = new System.Drawing.Size(34, 37);
            this.btn_ItemListing_SrchCurrentCriteria.TabIndex = 10;
            this.btn_ItemListing_SrchCurrentCriteria.UseVisualStyleBackColor = true;
            // 
            // lbl_ItemListing_RowCountInfo
            // 
            this.lbl_ItemListing_RowCountInfo.AutoSize = true;
            this.lbl_ItemListing_RowCountInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemListing_RowCountInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_ItemListing_RowCountInfo.Location = new System.Drawing.Point(6, 22);
            this.lbl_ItemListing_RowCountInfo.Name = "lbl_ItemListing_RowCountInfo";
            this.lbl_ItemListing_RowCountInfo.Size = new System.Drawing.Size(325, 15);
            this.lbl_ItemListing_RowCountInfo.TabIndex = 11;
            this.lbl_ItemListing_RowCountInfo.Text = "* * Put 0 for Row Count To Exclude From Row Count Limit";
            // 
            // lbl_ItemListing_BarcodeInfo
            // 
            this.lbl_ItemListing_BarcodeInfo.AutoSize = true;
            this.lbl_ItemListing_BarcodeInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemListing_BarcodeInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_ItemListing_BarcodeInfo.Location = new System.Drawing.Point(6, 41);
            this.lbl_ItemListing_BarcodeInfo.Name = "lbl_ItemListing_BarcodeInfo";
            this.lbl_ItemListing_BarcodeInfo.Size = new System.Drawing.Size(408, 15);
            this.lbl_ItemListing_BarcodeInfo.TabIndex = 12;
            this.lbl_ItemListing_BarcodeInfo.Text = "* * Select Item And Press F11 For Barcode Printing, F10 For Item Editing";
            // 
            // Frm_Master_ItemListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 745);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Master_ItemListing";
            this.Text = "Frm_Master_ItemListing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_ItemListing_ItemExport.ResumeLayout(false);
            this.gb_ItemListing_ItemExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ItemListing_ItemListing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ItemListing_BarcodeInfo;
        private System.Windows.Forms.Label lbl_ItemListing_RowCountInfo;
        private System.Windows.Forms.Button btn_ItemListing_SrchCurrentCriteria;
        private System.Windows.Forms.Label lbl_ItemListing_CurrentCriteria;
        private System.Windows.Forms.TextBox txt_ItemListing_CurrentCriteria;
        private System.Windows.Forms.CheckBox cb_ItemListing_ReorderItems;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_WeighingScaleItems;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_BarcodeBlocking;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_ItemMultiEdit;
        private System.Windows.Forms.DataGridView GV_ItemListing_ItemListing;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_PDTDataFile;
        private System.Windows.Forms.GroupBox gb_ItemListing_ItemExport;
        private System.Windows.Forms.TextBox txt_ItemListing_ItemExport;
        private System.Windows.Forms.Button btn_ItemListing_ExportToExcelFile;
        private System.Windows.Forms.Button btn_ItemListing_EportToTextFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_F12All;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_CntrlNArt;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_CntrlESize;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_CntrlOColor;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_CntrlMModel;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_CntrlRItemRef;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_F8SellPrice;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_F7Cost;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_F6Brand;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_F5Supplier;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_F4SubCategory;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_F3Category;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_F2Barcode;
        private System.Windows.Forms.LinkLabel lbl_ItemListing_F1ItemName;
        private System.Windows.Forms.ComboBox cob_ItemListing_SrchMethod;
        private System.Windows.Forms.Label lbl_ItemListing_SrchMethod;
        private System.Windows.Forms.ComboBox cob_ItemListing_RowCount;
        private System.Windows.Forms.Label lbl_ItemListing_RowCount;
    }
}