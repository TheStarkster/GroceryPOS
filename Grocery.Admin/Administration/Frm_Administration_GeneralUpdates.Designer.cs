namespace Grocery.Admin.Administration
{
    partial class Frm_Administration_GeneralUpdates
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
            this.gb_GeneralUpdates_GeneralDataUpdates = new System.Windows.Forms.GroupBox();
            this.rb_GeneralUpdates_UpdateCurrentStock = new System.Windows.Forms.RadioButton();
            this.rb_GeneralUpdates_UpdateSalesCost = new System.Windows.Forms.RadioButton();
            this.rb_GeneralUpdates_UpdateUOM = new System.Windows.Forms.RadioButton();
            this.rb_GeneralUpdates_RefreshTemperoryData = new System.Windows.Forms.RadioButton();
            this.rb_GeneralUpdates_UpdateLastLandCost = new System.Windows.Forms.RadioButton();
            this.rb_GeneralUpdates_RegulatesTransDate = new System.Windows.Forms.RadioButton();
            this.rb_GeneralUpdates_UpdateItemDescription = new System.Windows.Forms.RadioButton();
            this.rb_GeneralUpdates_StockRegisterStockUpdation = new System.Windows.Forms.RadioButton();
            this.rb_GeneralUpdates_UpdateWeighedAverageCost = new System.Windows.Forms.RadioButton();
            this.rb_GeneralUpdates_PopulatesTablesWithTransIds = new System.Windows.Forms.RadioButton();
            this.lbl_GeneralUpdates_OnOrAfter = new System.Windows.Forms.Label();
            this.dt_GeneralUpdates_OnOrAfterDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_GeneralUpdates_CostCenter = new System.Windows.Forms.Label();
            this.cob_GeneralUpdates_CostCenter = new System.Windows.Forms.ComboBox();
            this.cb_GeneralUpdates_SpecifyItemToUpdate = new System.Windows.Forms.CheckBox();
            this.txt_GeneralUpdates_ItemSpecifiedForUpdate = new System.Windows.Forms.TextBox();
            this.lbl_GeneralUpdates_Barcode = new System.Windows.Forms.Label();
            this.txt_GeneralUpdates_Barcode = new System.Windows.Forms.TextBox();
            this.txt_GeneralUpdates_ItemID = new System.Windows.Forms.TextBox();
            this.lbl_GeneralUpdates_ItemID = new System.Windows.Forms.Label();
            this.txt_GeneralUpdates = new System.Windows.Forms.RichTextBox();
            this.btn_GeneralUpdates_TransactionProcessing = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_GeneralUpdates_Proceed = new System.Windows.Forms.Button();
            this.gb_GeneralUpdates_GeneralDataUpdates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_GeneralUpdates_GeneralDataUpdates
            // 
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.dt_GeneralUpdates_OnOrAfterDate);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.lbl_GeneralUpdates_OnOrAfter);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_PopulatesTablesWithTransIds);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_UpdateWeighedAverageCost);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_StockRegisterStockUpdation);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_UpdateItemDescription);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_RegulatesTransDate);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_UpdateLastLandCost);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_RefreshTemperoryData);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_UpdateUOM);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_UpdateSalesCost);
            this.gb_GeneralUpdates_GeneralDataUpdates.Controls.Add(this.rb_GeneralUpdates_UpdateCurrentStock);
            this.gb_GeneralUpdates_GeneralDataUpdates.Location = new System.Drawing.Point(13, 13);
            this.gb_GeneralUpdates_GeneralDataUpdates.Name = "gb_GeneralUpdates_GeneralDataUpdates";
            this.gb_GeneralUpdates_GeneralDataUpdates.Size = new System.Drawing.Size(267, 304);
            this.gb_GeneralUpdates_GeneralDataUpdates.TabIndex = 0;
            this.gb_GeneralUpdates_GeneralDataUpdates.TabStop = false;
            this.gb_GeneralUpdates_GeneralDataUpdates.Text = "General Data Updates";
            // 
            // rb_GeneralUpdates_UpdateCurrentStock
            // 
            this.rb_GeneralUpdates_UpdateCurrentStock.AutoSize = true;
            this.rb_GeneralUpdates_UpdateCurrentStock.Location = new System.Drawing.Point(7, 22);
            this.rb_GeneralUpdates_UpdateCurrentStock.Name = "rb_GeneralUpdates_UpdateCurrentStock";
            this.rb_GeneralUpdates_UpdateCurrentStock.Size = new System.Drawing.Size(256, 19);
            this.rb_GeneralUpdates_UpdateCurrentStock.TabIndex = 0;
            this.rb_GeneralUpdates_UpdateCurrentStock.TabStop = true;
            this.rb_GeneralUpdates_UpdateCurrentStock.Text = "Update Current Stock (Stock Recalculation)";
            this.rb_GeneralUpdates_UpdateCurrentStock.UseVisualStyleBackColor = true;
            // 
            // rb_GeneralUpdates_UpdateSalesCost
            // 
            this.rb_GeneralUpdates_UpdateSalesCost.AutoSize = true;
            this.rb_GeneralUpdates_UpdateSalesCost.Location = new System.Drawing.Point(7, 47);
            this.rb_GeneralUpdates_UpdateSalesCost.Name = "rb_GeneralUpdates_UpdateSalesCost";
            this.rb_GeneralUpdates_UpdateSalesCost.Size = new System.Drawing.Size(123, 19);
            this.rb_GeneralUpdates_UpdateSalesCost.TabIndex = 1;
            this.rb_GeneralUpdates_UpdateSalesCost.TabStop = true;
            this.rb_GeneralUpdates_UpdateSalesCost.Text = "Update Sales Cost";
            this.rb_GeneralUpdates_UpdateSalesCost.UseVisualStyleBackColor = true;
            // 
            // rb_GeneralUpdates_UpdateUOM
            // 
            this.rb_GeneralUpdates_UpdateUOM.AutoSize = true;
            this.rb_GeneralUpdates_UpdateUOM.Location = new System.Drawing.Point(7, 72);
            this.rb_GeneralUpdates_UpdateUOM.Name = "rb_GeneralUpdates_UpdateUOM";
            this.rb_GeneralUpdates_UpdateUOM.Size = new System.Drawing.Size(97, 19);
            this.rb_GeneralUpdates_UpdateUOM.TabIndex = 2;
            this.rb_GeneralUpdates_UpdateUOM.TabStop = true;
            this.rb_GeneralUpdates_UpdateUOM.Text = "Update UOM";
            this.rb_GeneralUpdates_UpdateUOM.UseVisualStyleBackColor = true;
            // 
            // rb_GeneralUpdates_RefreshTemperoryData
            // 
            this.rb_GeneralUpdates_RefreshTemperoryData.AutoSize = true;
            this.rb_GeneralUpdates_RefreshTemperoryData.Location = new System.Drawing.Point(7, 97);
            this.rb_GeneralUpdates_RefreshTemperoryData.Name = "rb_GeneralUpdates_RefreshTemperoryData";
            this.rb_GeneralUpdates_RefreshTemperoryData.Size = new System.Drawing.Size(154, 19);
            this.rb_GeneralUpdates_RefreshTemperoryData.TabIndex = 3;
            this.rb_GeneralUpdates_RefreshTemperoryData.TabStop = true;
            this.rb_GeneralUpdates_RefreshTemperoryData.Text = "Refresh Temperory Data";
            this.rb_GeneralUpdates_RefreshTemperoryData.UseVisualStyleBackColor = true;
            // 
            // rb_GeneralUpdates_UpdateLastLandCost
            // 
            this.rb_GeneralUpdates_UpdateLastLandCost.AutoSize = true;
            this.rb_GeneralUpdates_UpdateLastLandCost.Location = new System.Drawing.Point(7, 122);
            this.rb_GeneralUpdates_UpdateLastLandCost.Name = "rb_GeneralUpdates_UpdateLastLandCost";
            this.rb_GeneralUpdates_UpdateLastLandCost.Size = new System.Drawing.Size(148, 19);
            this.rb_GeneralUpdates_UpdateLastLandCost.TabIndex = 4;
            this.rb_GeneralUpdates_UpdateLastLandCost.TabStop = true;
            this.rb_GeneralUpdates_UpdateLastLandCost.Text = "Update Last Land Cost";
            this.rb_GeneralUpdates_UpdateLastLandCost.UseVisualStyleBackColor = true;
            // 
            // rb_GeneralUpdates_RegulatesTransDate
            // 
            this.rb_GeneralUpdates_RegulatesTransDate.AutoSize = true;
            this.rb_GeneralUpdates_RegulatesTransDate.Location = new System.Drawing.Point(7, 147);
            this.rb_GeneralUpdates_RegulatesTransDate.Name = "rb_GeneralUpdates_RegulatesTransDate";
            this.rb_GeneralUpdates_RegulatesTransDate.Size = new System.Drawing.Size(140, 19);
            this.rb_GeneralUpdates_RegulatesTransDate.TabIndex = 5;
            this.rb_GeneralUpdates_RegulatesTransDate.TabStop = true;
            this.rb_GeneralUpdates_RegulatesTransDate.Text = "Regulates Trans Date";
            this.rb_GeneralUpdates_RegulatesTransDate.UseVisualStyleBackColor = true;
            // 
            // rb_GeneralUpdates_UpdateItemDescription
            // 
            this.rb_GeneralUpdates_UpdateItemDescription.AutoSize = true;
            this.rb_GeneralUpdates_UpdateItemDescription.Location = new System.Drawing.Point(7, 172);
            this.rb_GeneralUpdates_UpdateItemDescription.Name = "rb_GeneralUpdates_UpdateItemDescription";
            this.rb_GeneralUpdates_UpdateItemDescription.Size = new System.Drawing.Size(155, 19);
            this.rb_GeneralUpdates_UpdateItemDescription.TabIndex = 6;
            this.rb_GeneralUpdates_UpdateItemDescription.TabStop = true;
            this.rb_GeneralUpdates_UpdateItemDescription.Text = "Update Item Description";
            this.rb_GeneralUpdates_UpdateItemDescription.UseVisualStyleBackColor = true;
            // 
            // rb_GeneralUpdates_StockRegisterStockUpdation
            // 
            this.rb_GeneralUpdates_StockRegisterStockUpdation.AutoSize = true;
            this.rb_GeneralUpdates_StockRegisterStockUpdation.Location = new System.Drawing.Point(7, 197);
            this.rb_GeneralUpdates_StockRegisterStockUpdation.Name = "rb_GeneralUpdates_StockRegisterStockUpdation";
            this.rb_GeneralUpdates_StockRegisterStockUpdation.Size = new System.Drawing.Size(188, 19);
            this.rb_GeneralUpdates_StockRegisterStockUpdation.TabIndex = 7;
            this.rb_GeneralUpdates_StockRegisterStockUpdation.TabStop = true;
            this.rb_GeneralUpdates_StockRegisterStockUpdation.Text = "Stock Register Stock Updation";
            this.rb_GeneralUpdates_StockRegisterStockUpdation.UseVisualStyleBackColor = true;
            // 
            // rb_GeneralUpdates_UpdateWeighedAverageCost
            // 
            this.rb_GeneralUpdates_UpdateWeighedAverageCost.AutoSize = true;
            this.rb_GeneralUpdates_UpdateWeighedAverageCost.Location = new System.Drawing.Point(7, 222);
            this.rb_GeneralUpdates_UpdateWeighedAverageCost.Name = "rb_GeneralUpdates_UpdateWeighedAverageCost";
            this.rb_GeneralUpdates_UpdateWeighedAverageCost.Size = new System.Drawing.Size(194, 19);
            this.rb_GeneralUpdates_UpdateWeighedAverageCost.TabIndex = 8;
            this.rb_GeneralUpdates_UpdateWeighedAverageCost.TabStop = true;
            this.rb_GeneralUpdates_UpdateWeighedAverageCost.Text = "Update Weighted Average Cost";
            this.rb_GeneralUpdates_UpdateWeighedAverageCost.UseVisualStyleBackColor = true;
            // 
            // rb_GeneralUpdates_PopulatesTablesWithTransIds
            // 
            this.rb_GeneralUpdates_PopulatesTablesWithTransIds.AutoSize = true;
            this.rb_GeneralUpdates_PopulatesTablesWithTransIds.Location = new System.Drawing.Point(7, 247);
            this.rb_GeneralUpdates_PopulatesTablesWithTransIds.Name = "rb_GeneralUpdates_PopulatesTablesWithTransIds";
            this.rb_GeneralUpdates_PopulatesTablesWithTransIds.Size = new System.Drawing.Size(199, 19);
            this.rb_GeneralUpdates_PopulatesTablesWithTransIds.TabIndex = 9;
            this.rb_GeneralUpdates_PopulatesTablesWithTransIds.TabStop = true;
            this.rb_GeneralUpdates_PopulatesTablesWithTransIds.Text = "Populates Tables With Trans Ids";
            this.rb_GeneralUpdates_PopulatesTablesWithTransIds.UseVisualStyleBackColor = true;
            // 
            // lbl_GeneralUpdates_OnOrAfter
            // 
            this.lbl_GeneralUpdates_OnOrAfter.AutoSize = true;
            this.lbl_GeneralUpdates_OnOrAfter.Location = new System.Drawing.Point(7, 273);
            this.lbl_GeneralUpdates_OnOrAfter.Name = "lbl_GeneralUpdates_OnOrAfter";
            this.lbl_GeneralUpdates_OnOrAfter.Size = new System.Drawing.Size(69, 15);
            this.lbl_GeneralUpdates_OnOrAfter.TabIndex = 10;
            this.lbl_GeneralUpdates_OnOrAfter.Text = "On Or After";
            // 
            // dt_GeneralUpdates_OnOrAfterDate
            // 
            this.dt_GeneralUpdates_OnOrAfterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_GeneralUpdates_OnOrAfterDate.Location = new System.Drawing.Point(82, 273);
            this.dt_GeneralUpdates_OnOrAfterDate.Name = "dt_GeneralUpdates_OnOrAfterDate";
            this.dt_GeneralUpdates_OnOrAfterDate.Size = new System.Drawing.Size(101, 22);
            this.dt_GeneralUpdates_OnOrAfterDate.TabIndex = 11;
            // 
            // lbl_GeneralUpdates_CostCenter
            // 
            this.lbl_GeneralUpdates_CostCenter.AutoSize = true;
            this.lbl_GeneralUpdates_CostCenter.Location = new System.Drawing.Point(287, 24);
            this.lbl_GeneralUpdates_CostCenter.Name = "lbl_GeneralUpdates_CostCenter";
            this.lbl_GeneralUpdates_CostCenter.Size = new System.Drawing.Size(70, 15);
            this.lbl_GeneralUpdates_CostCenter.TabIndex = 1;
            this.lbl_GeneralUpdates_CostCenter.Text = "Cost Center";
            // 
            // cob_GeneralUpdates_CostCenter
            // 
            this.cob_GeneralUpdates_CostCenter.FormattingEnabled = true;
            this.cob_GeneralUpdates_CostCenter.Location = new System.Drawing.Point(361, 21);
            this.cob_GeneralUpdates_CostCenter.Name = "cob_GeneralUpdates_CostCenter";
            this.cob_GeneralUpdates_CostCenter.Size = new System.Drawing.Size(189, 23);
            this.cob_GeneralUpdates_CostCenter.TabIndex = 2;
            // 
            // cb_GeneralUpdates_SpecifyItemToUpdate
            // 
            this.cb_GeneralUpdates_SpecifyItemToUpdate.AutoSize = true;
            this.cb_GeneralUpdates_SpecifyItemToUpdate.Location = new System.Drawing.Point(290, 60);
            this.cb_GeneralUpdates_SpecifyItemToUpdate.Name = "cb_GeneralUpdates_SpecifyItemToUpdate";
            this.cb_GeneralUpdates_SpecifyItemToUpdate.Size = new System.Drawing.Size(151, 19);
            this.cb_GeneralUpdates_SpecifyItemToUpdate.TabIndex = 3;
            this.cb_GeneralUpdates_SpecifyItemToUpdate.Text = "Specify Item To Update";
            this.cb_GeneralUpdates_SpecifyItemToUpdate.UseVisualStyleBackColor = true;
            // 
            // txt_GeneralUpdates_ItemSpecifiedForUpdate
            // 
            this.txt_GeneralUpdates_ItemSpecifiedForUpdate.Location = new System.Drawing.Point(290, 82);
            this.txt_GeneralUpdates_ItemSpecifiedForUpdate.Name = "txt_GeneralUpdates_ItemSpecifiedForUpdate";
            this.txt_GeneralUpdates_ItemSpecifiedForUpdate.Size = new System.Drawing.Size(263, 22);
            this.txt_GeneralUpdates_ItemSpecifiedForUpdate.TabIndex = 4;
            // 
            // lbl_GeneralUpdates_Barcode
            // 
            this.lbl_GeneralUpdates_Barcode.AutoSize = true;
            this.lbl_GeneralUpdates_Barcode.Location = new System.Drawing.Point(290, 110);
            this.lbl_GeneralUpdates_Barcode.Name = "lbl_GeneralUpdates_Barcode";
            this.lbl_GeneralUpdates_Barcode.Size = new System.Drawing.Size(51, 15);
            this.lbl_GeneralUpdates_Barcode.TabIndex = 5;
            this.lbl_GeneralUpdates_Barcode.Text = "Barcode";
            // 
            // txt_GeneralUpdates_Barcode
            // 
            this.txt_GeneralUpdates_Barcode.Location = new System.Drawing.Point(290, 128);
            this.txt_GeneralUpdates_Barcode.Name = "txt_GeneralUpdates_Barcode";
            this.txt_GeneralUpdates_Barcode.Size = new System.Drawing.Size(129, 22);
            this.txt_GeneralUpdates_Barcode.TabIndex = 6;
            // 
            // txt_GeneralUpdates_ItemID
            // 
            this.txt_GeneralUpdates_ItemID.Location = new System.Drawing.Point(425, 128);
            this.txt_GeneralUpdates_ItemID.Name = "txt_GeneralUpdates_ItemID";
            this.txt_GeneralUpdates_ItemID.Size = new System.Drawing.Size(128, 22);
            this.txt_GeneralUpdates_ItemID.TabIndex = 8;
            // 
            // lbl_GeneralUpdates_ItemID
            // 
            this.lbl_GeneralUpdates_ItemID.AutoSize = true;
            this.lbl_GeneralUpdates_ItemID.Location = new System.Drawing.Point(431, 110);
            this.lbl_GeneralUpdates_ItemID.Name = "lbl_GeneralUpdates_ItemID";
            this.lbl_GeneralUpdates_ItemID.Size = new System.Drawing.Size(46, 15);
            this.lbl_GeneralUpdates_ItemID.TabIndex = 7;
            this.lbl_GeneralUpdates_ItemID.Text = "Item ID";
            // 
            // txt_GeneralUpdates
            // 
            this.txt_GeneralUpdates.Location = new System.Drawing.Point(287, 156);
            this.txt_GeneralUpdates.Name = "txt_GeneralUpdates";
            this.txt_GeneralUpdates.Size = new System.Drawing.Size(263, 69);
            this.txt_GeneralUpdates.TabIndex = 9;
            this.txt_GeneralUpdates.Text = "";
            // 
            // btn_GeneralUpdates_TransactionProcessing
            // 
            this.btn_GeneralUpdates_TransactionProcessing.Location = new System.Drawing.Point(434, 270);
            this.btn_GeneralUpdates_TransactionProcessing.Name = "btn_GeneralUpdates_TransactionProcessing";
            this.btn_GeneralUpdates_TransactionProcessing.Size = new System.Drawing.Size(119, 47);
            this.btn_GeneralUpdates_TransactionProcessing.TabIndex = 10;
            this.btn_GeneralUpdates_TransactionProcessing.Text = "Transaction Processing";
            this.btn_GeneralUpdates_TransactionProcessing.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 324);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(438, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 352);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(438, 22);
            this.textBox5.TabIndex = 12;
            // 
            // btn_GeneralUpdates_Proceed
            // 
            this.btn_GeneralUpdates_Proceed.Location = new System.Drawing.Point(457, 324);
            this.btn_GeneralUpdates_Proceed.Name = "btn_GeneralUpdates_Proceed";
            this.btn_GeneralUpdates_Proceed.Size = new System.Drawing.Size(96, 50);
            this.btn_GeneralUpdates_Proceed.TabIndex = 13;
            this.btn_GeneralUpdates_Proceed.Text = "Proceed";
            this.btn_GeneralUpdates_Proceed.UseVisualStyleBackColor = true;
            // 
            // Frm_Administration_GeneralUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 380);
            this.Controls.Add(this.btn_GeneralUpdates_Proceed);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_GeneralUpdates_TransactionProcessing);
            this.Controls.Add(this.txt_GeneralUpdates);
            this.Controls.Add(this.txt_GeneralUpdates_ItemID);
            this.Controls.Add(this.lbl_GeneralUpdates_ItemID);
            this.Controls.Add(this.txt_GeneralUpdates_Barcode);
            this.Controls.Add(this.lbl_GeneralUpdates_Barcode);
            this.Controls.Add(this.txt_GeneralUpdates_ItemSpecifiedForUpdate);
            this.Controls.Add(this.cb_GeneralUpdates_SpecifyItemToUpdate);
            this.Controls.Add(this.cob_GeneralUpdates_CostCenter);
            this.Controls.Add(this.lbl_GeneralUpdates_CostCenter);
            this.Controls.Add(this.gb_GeneralUpdates_GeneralDataUpdates);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Administration_GeneralUpdates";
            this.Text = "Frm_Administration_GeneralUpdates";
            this.gb_GeneralUpdates_GeneralDataUpdates.ResumeLayout(false);
            this.gb_GeneralUpdates_GeneralDataUpdates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_GeneralUpdates_GeneralDataUpdates;
        private System.Windows.Forms.DateTimePicker dt_GeneralUpdates_OnOrAfterDate;
        private System.Windows.Forms.Label lbl_GeneralUpdates_OnOrAfter;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_PopulatesTablesWithTransIds;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_UpdateWeighedAverageCost;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_StockRegisterStockUpdation;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_UpdateItemDescription;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_RegulatesTransDate;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_UpdateLastLandCost;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_RefreshTemperoryData;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_UpdateUOM;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_UpdateSalesCost;
        private System.Windows.Forms.RadioButton rb_GeneralUpdates_UpdateCurrentStock;
        private System.Windows.Forms.Label lbl_GeneralUpdates_CostCenter;
        private System.Windows.Forms.ComboBox cob_GeneralUpdates_CostCenter;
        private System.Windows.Forms.CheckBox cb_GeneralUpdates_SpecifyItemToUpdate;
        private System.Windows.Forms.TextBox txt_GeneralUpdates_ItemSpecifiedForUpdate;
        private System.Windows.Forms.Label lbl_GeneralUpdates_Barcode;
        private System.Windows.Forms.TextBox txt_GeneralUpdates_Barcode;
        private System.Windows.Forms.TextBox txt_GeneralUpdates_ItemID;
        private System.Windows.Forms.Label lbl_GeneralUpdates_ItemID;
        private System.Windows.Forms.RichTextBox txt_GeneralUpdates;
        private System.Windows.Forms.Button btn_GeneralUpdates_TransactionProcessing;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_GeneralUpdates_Proceed;
    }
}