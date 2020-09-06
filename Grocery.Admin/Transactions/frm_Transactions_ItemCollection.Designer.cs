namespace Grocery.Admin.Transactions
{
    partial class frm_Transactions_ItemCollection
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
            this.btn_ItemCollection_ItemName = new System.Windows.Forms.Label();
            this.txt_ItemCollection_ItemName = new System.Windows.Forms.TextBox();
            this.btn_ItemCollection_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ItemCollection_ItemName
            // 
            this.btn_ItemCollection_ItemName.AutoSize = true;
            this.btn_ItemCollection_ItemName.Location = new System.Drawing.Point(13, 13);
            this.btn_ItemCollection_ItemName.Name = "btn_ItemCollection_ItemName";
            this.btn_ItemCollection_ItemName.Size = new System.Drawing.Size(63, 15);
            this.btn_ItemCollection_ItemName.TabIndex = 0;
            this.btn_ItemCollection_ItemName.Text = "Item Name";
            // 
            // txt_ItemCollection_ItemName
            // 
            this.txt_ItemCollection_ItemName.Location = new System.Drawing.Point(16, 32);
            this.txt_ItemCollection_ItemName.Name = "txt_ItemCollection_ItemName";
            this.txt_ItemCollection_ItemName.Size = new System.Drawing.Size(254, 22);
            this.txt_ItemCollection_ItemName.TabIndex = 1;
            // 
            // btn_ItemCollection_Update
            // 
            this.btn_ItemCollection_Update.Location = new System.Drawing.Point(184, 60);
            this.btn_ItemCollection_Update.Name = "btn_ItemCollection_Update";
            this.btn_ItemCollection_Update.Size = new System.Drawing.Size(86, 37);
            this.btn_ItemCollection_Update.TabIndex = 2;
            this.btn_ItemCollection_Update.Text = "Update";
            this.btn_ItemCollection_Update.UseVisualStyleBackColor = true;
            // 
            // frm_Transactions_ItemCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 103);
            this.Controls.Add(this.btn_ItemCollection_Update);
            this.Controls.Add(this.txt_ItemCollection_ItemName);
            this.Controls.Add(this.btn_ItemCollection_ItemName);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Transactions_ItemCollection";
            this.Text = "frm_Transactions_ItemCollection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_ItemCollection_ItemName;
        private System.Windows.Forms.TextBox txt_ItemCollection_ItemName;
        private System.Windows.Forms.Button btn_ItemCollection_Update;
    }
}