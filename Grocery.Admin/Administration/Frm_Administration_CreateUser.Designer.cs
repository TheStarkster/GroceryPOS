namespace Grocery.Admin.Administration
{
    partial class Frm_Administration_CreateUser
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
            this.gb_CreateUser_UserDetails = new System.Windows.Forms.GroupBox();
            this.lbl_CreateUser_StaffName = new System.Windows.Forms.Label();
            this.lbl_CreateUser_UserName = new System.Windows.Forms.Label();
            this.txt_CreateUser_StaffName = new System.Windows.Forms.TextBox();
            this.txt_CreateUser_UserName = new System.Windows.Forms.TextBox();
            this.txt_CreateUser_Password = new System.Windows.Forms.TextBox();
            this.lbl_CreateUser_Password = new System.Windows.Forms.Label();
            this.txt_CreateUser_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_CreateUser_ConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_CreateUser_CostCenter = new System.Windows.Forms.Label();
            this.cob_CreateUser_CostCenter = new System.Windows.Forms.ComboBox();
            this.gb_CreateUser_PermissionLevel = new System.Windows.Forms.GroupBox();
            this.rb_CreateUser_User = new System.Windows.Forms.RadioButton();
            this.rb_CreateUser_Admin = new System.Windows.Forms.RadioButton();
            this.rb_CreateUser_Supervisor = new System.Windows.Forms.RadioButton();
            this.gb_CreateUser_AccessibleLevel = new System.Windows.Forms.GroupBox();
            this.cb_CreateUser_ViewCost = new System.Windows.Forms.CheckBox();
            this.cb_CreateUser_SalesPRWithoutStock = new System.Windows.Forms.CheckBox();
            this.cb_CreateUser_ViewStock = new System.Windows.Forms.CheckBox();
            this.cb_CreateUser_ViewGraph = new System.Windows.Forms.CheckBox();
            this.cb_CreateUser_UnderCostSale = new System.Windows.Forms.CheckBox();
            this.btn_CreateUser_Create = new System.Windows.Forms.Button();
            this.btn_CreateUser_Cancel = new System.Windows.Forms.Button();
            this.gb_CreateUser_UserDetails.SuspendLayout();
            this.gb_CreateUser_PermissionLevel.SuspendLayout();
            this.gb_CreateUser_AccessibleLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_CreateUser_UserDetails
            // 
            this.gb_CreateUser_UserDetails.Controls.Add(this.gb_CreateUser_AccessibleLevel);
            this.gb_CreateUser_UserDetails.Controls.Add(this.gb_CreateUser_PermissionLevel);
            this.gb_CreateUser_UserDetails.Controls.Add(this.cob_CreateUser_CostCenter);
            this.gb_CreateUser_UserDetails.Controls.Add(this.lbl_CreateUser_CostCenter);
            this.gb_CreateUser_UserDetails.Controls.Add(this.txt_CreateUser_ConfirmPassword);
            this.gb_CreateUser_UserDetails.Controls.Add(this.lbl_CreateUser_ConfirmPassword);
            this.gb_CreateUser_UserDetails.Controls.Add(this.txt_CreateUser_Password);
            this.gb_CreateUser_UserDetails.Controls.Add(this.lbl_CreateUser_Password);
            this.gb_CreateUser_UserDetails.Controls.Add(this.txt_CreateUser_UserName);
            this.gb_CreateUser_UserDetails.Controls.Add(this.txt_CreateUser_StaffName);
            this.gb_CreateUser_UserDetails.Controls.Add(this.lbl_CreateUser_UserName);
            this.gb_CreateUser_UserDetails.Controls.Add(this.lbl_CreateUser_StaffName);
            this.gb_CreateUser_UserDetails.Location = new System.Drawing.Point(13, 13);
            this.gb_CreateUser_UserDetails.Name = "gb_CreateUser_UserDetails";
            this.gb_CreateUser_UserDetails.Size = new System.Drawing.Size(595, 216);
            this.gb_CreateUser_UserDetails.TabIndex = 0;
            this.gb_CreateUser_UserDetails.TabStop = false;
            this.gb_CreateUser_UserDetails.Text = "User Details";
            // 
            // lbl_CreateUser_StaffName
            // 
            this.lbl_CreateUser_StaffName.AutoSize = true;
            this.lbl_CreateUser_StaffName.Location = new System.Drawing.Point(15, 31);
            this.lbl_CreateUser_StaffName.Name = "lbl_CreateUser_StaffName";
            this.lbl_CreateUser_StaffName.Size = new System.Drawing.Size(65, 15);
            this.lbl_CreateUser_StaffName.TabIndex = 0;
            this.lbl_CreateUser_StaffName.Text = "Staff Name";
            // 
            // lbl_CreateUser_UserName
            // 
            this.lbl_CreateUser_UserName.AutoSize = true;
            this.lbl_CreateUser_UserName.Location = new System.Drawing.Point(16, 59);
            this.lbl_CreateUser_UserName.Name = "lbl_CreateUser_UserName";
            this.lbl_CreateUser_UserName.Size = new System.Drawing.Size(65, 15);
            this.lbl_CreateUser_UserName.TabIndex = 1;
            this.lbl_CreateUser_UserName.Text = "User Name";
            // 
            // txt_CreateUser_StaffName
            // 
            this.txt_CreateUser_StaffName.Location = new System.Drawing.Point(126, 31);
            this.txt_CreateUser_StaffName.Name = "txt_CreateUser_StaffName";
            this.txt_CreateUser_StaffName.Size = new System.Drawing.Size(304, 22);
            this.txt_CreateUser_StaffName.TabIndex = 2;
            // 
            // txt_CreateUser_UserName
            // 
            this.txt_CreateUser_UserName.Location = new System.Drawing.Point(126, 59);
            this.txt_CreateUser_UserName.Name = "txt_CreateUser_UserName";
            this.txt_CreateUser_UserName.Size = new System.Drawing.Size(304, 22);
            this.txt_CreateUser_UserName.TabIndex = 3;
            // 
            // txt_CreateUser_Password
            // 
            this.txt_CreateUser_Password.Location = new System.Drawing.Point(126, 87);
            this.txt_CreateUser_Password.Name = "txt_CreateUser_Password";
            this.txt_CreateUser_Password.Size = new System.Drawing.Size(304, 22);
            this.txt_CreateUser_Password.TabIndex = 5;
            // 
            // lbl_CreateUser_Password
            // 
            this.lbl_CreateUser_Password.AutoSize = true;
            this.lbl_CreateUser_Password.Location = new System.Drawing.Point(16, 87);
            this.lbl_CreateUser_Password.Name = "lbl_CreateUser_Password";
            this.lbl_CreateUser_Password.Size = new System.Drawing.Size(59, 15);
            this.lbl_CreateUser_Password.TabIndex = 4;
            this.lbl_CreateUser_Password.Text = "Password";
            // 
            // txt_CreateUser_ConfirmPassword
            // 
            this.txt_CreateUser_ConfirmPassword.Location = new System.Drawing.Point(126, 115);
            this.txt_CreateUser_ConfirmPassword.Name = "txt_CreateUser_ConfirmPassword";
            this.txt_CreateUser_ConfirmPassword.Size = new System.Drawing.Size(304, 22);
            this.txt_CreateUser_ConfirmPassword.TabIndex = 7;
            // 
            // lbl_CreateUser_ConfirmPassword
            // 
            this.lbl_CreateUser_ConfirmPassword.AutoSize = true;
            this.lbl_CreateUser_ConfirmPassword.Location = new System.Drawing.Point(16, 115);
            this.lbl_CreateUser_ConfirmPassword.Name = "lbl_CreateUser_ConfirmPassword";
            this.lbl_CreateUser_ConfirmPassword.Size = new System.Drawing.Size(104, 15);
            this.lbl_CreateUser_ConfirmPassword.TabIndex = 6;
            this.lbl_CreateUser_ConfirmPassword.Text = "Confirm Password";
            // 
            // lbl_CreateUser_CostCenter
            // 
            this.lbl_CreateUser_CostCenter.AutoSize = true;
            this.lbl_CreateUser_CostCenter.Location = new System.Drawing.Point(440, 18);
            this.lbl_CreateUser_CostCenter.Name = "lbl_CreateUser_CostCenter";
            this.lbl_CreateUser_CostCenter.Size = new System.Drawing.Size(70, 15);
            this.lbl_CreateUser_CostCenter.TabIndex = 8;
            this.lbl_CreateUser_CostCenter.Text = "Cost Center";
            // 
            // cob_CreateUser_CostCenter
            // 
            this.cob_CreateUser_CostCenter.FormattingEnabled = true;
            this.cob_CreateUser_CostCenter.Location = new System.Drawing.Point(443, 36);
            this.cob_CreateUser_CostCenter.Name = "cob_CreateUser_CostCenter";
            this.cob_CreateUser_CostCenter.Size = new System.Drawing.Size(141, 23);
            this.cob_CreateUser_CostCenter.TabIndex = 9;
            // 
            // gb_CreateUser_PermissionLevel
            // 
            this.gb_CreateUser_PermissionLevel.Controls.Add(this.rb_CreateUser_Supervisor);
            this.gb_CreateUser_PermissionLevel.Controls.Add(this.rb_CreateUser_Admin);
            this.gb_CreateUser_PermissionLevel.Controls.Add(this.rb_CreateUser_User);
            this.gb_CreateUser_PermissionLevel.Location = new System.Drawing.Point(443, 66);
            this.gb_CreateUser_PermissionLevel.Name = "gb_CreateUser_PermissionLevel";
            this.gb_CreateUser_PermissionLevel.Size = new System.Drawing.Size(141, 71);
            this.gb_CreateUser_PermissionLevel.TabIndex = 10;
            this.gb_CreateUser_PermissionLevel.TabStop = false;
            this.gb_CreateUser_PermissionLevel.Text = "Permission Level";
            // 
            // rb_CreateUser_User
            // 
            this.rb_CreateUser_User.AutoSize = true;
            this.rb_CreateUser_User.Location = new System.Drawing.Point(7, 25);
            this.rb_CreateUser_User.Name = "rb_CreateUser_User";
            this.rb_CreateUser_User.Size = new System.Drawing.Size(50, 19);
            this.rb_CreateUser_User.TabIndex = 0;
            this.rb_CreateUser_User.TabStop = true;
            this.rb_CreateUser_User.Text = "User";
            this.rb_CreateUser_User.UseVisualStyleBackColor = true;
            // 
            // rb_CreateUser_Admin
            // 
            this.rb_CreateUser_Admin.AutoSize = true;
            this.rb_CreateUser_Admin.Location = new System.Drawing.Point(63, 24);
            this.rb_CreateUser_Admin.Name = "rb_CreateUser_Admin";
            this.rb_CreateUser_Admin.Size = new System.Drawing.Size(61, 19);
            this.rb_CreateUser_Admin.TabIndex = 1;
            this.rb_CreateUser_Admin.TabStop = true;
            this.rb_CreateUser_Admin.Text = "Admin";
            this.rb_CreateUser_Admin.UseVisualStyleBackColor = true;
            // 
            // rb_CreateUser_Supervisor
            // 
            this.rb_CreateUser_Supervisor.AutoSize = true;
            this.rb_CreateUser_Supervisor.Location = new System.Drawing.Point(6, 47);
            this.rb_CreateUser_Supervisor.Name = "rb_CreateUser_Supervisor";
            this.rb_CreateUser_Supervisor.Size = new System.Drawing.Size(83, 19);
            this.rb_CreateUser_Supervisor.TabIndex = 2;
            this.rb_CreateUser_Supervisor.TabStop = true;
            this.rb_CreateUser_Supervisor.Text = "Supervisor";
            this.rb_CreateUser_Supervisor.UseVisualStyleBackColor = true;
            // 
            // gb_CreateUser_AccessibleLevel
            // 
            this.gb_CreateUser_AccessibleLevel.Controls.Add(this.cb_CreateUser_UnderCostSale);
            this.gb_CreateUser_AccessibleLevel.Controls.Add(this.cb_CreateUser_ViewGraph);
            this.gb_CreateUser_AccessibleLevel.Controls.Add(this.cb_CreateUser_ViewStock);
            this.gb_CreateUser_AccessibleLevel.Controls.Add(this.cb_CreateUser_SalesPRWithoutStock);
            this.gb_CreateUser_AccessibleLevel.Controls.Add(this.cb_CreateUser_ViewCost);
            this.gb_CreateUser_AccessibleLevel.Location = new System.Drawing.Point(19, 152);
            this.gb_CreateUser_AccessibleLevel.Name = "gb_CreateUser_AccessibleLevel";
            this.gb_CreateUser_AccessibleLevel.Size = new System.Drawing.Size(565, 52);
            this.gb_CreateUser_AccessibleLevel.TabIndex = 11;
            this.gb_CreateUser_AccessibleLevel.TabStop = false;
            this.gb_CreateUser_AccessibleLevel.Text = "Accessible Level";
            // 
            // cb_CreateUser_ViewCost
            // 
            this.cb_CreateUser_ViewCost.AutoSize = true;
            this.cb_CreateUser_ViewCost.Location = new System.Drawing.Point(6, 21);
            this.cb_CreateUser_ViewCost.Name = "cb_CreateUser_ViewCost";
            this.cb_CreateUser_ViewCost.Size = new System.Drawing.Size(79, 19);
            this.cb_CreateUser_ViewCost.TabIndex = 0;
            this.cb_CreateUser_ViewCost.Text = "View Cost";
            this.cb_CreateUser_ViewCost.UseVisualStyleBackColor = true;
            // 
            // cb_CreateUser_SalesPRWithoutStock
            // 
            this.cb_CreateUser_SalesPRWithoutStock.AutoSize = true;
            this.cb_CreateUser_SalesPRWithoutStock.Location = new System.Drawing.Point(91, 21);
            this.cb_CreateUser_SalesPRWithoutStock.Name = "cb_CreateUser_SalesPRWithoutStock";
            this.cb_CreateUser_SalesPRWithoutStock.Size = new System.Drawing.Size(153, 19);
            this.cb_CreateUser_SalesPRWithoutStock.TabIndex = 1;
            this.cb_CreateUser_SalesPRWithoutStock.Text = "Sales/PR Without Stock";
            this.cb_CreateUser_SalesPRWithoutStock.UseVisualStyleBackColor = true;
            // 
            // cb_CreateUser_ViewStock
            // 
            this.cb_CreateUser_ViewStock.AutoSize = true;
            this.cb_CreateUser_ViewStock.Location = new System.Drawing.Point(250, 21);
            this.cb_CreateUser_ViewStock.Name = "cb_CreateUser_ViewStock";
            this.cb_CreateUser_ViewStock.Size = new System.Drawing.Size(84, 19);
            this.cb_CreateUser_ViewStock.TabIndex = 2;
            this.cb_CreateUser_ViewStock.Text = "View Stock";
            this.cb_CreateUser_ViewStock.UseVisualStyleBackColor = true;
            // 
            // cb_CreateUser_ViewGraph
            // 
            this.cb_CreateUser_ViewGraph.AutoSize = true;
            this.cb_CreateUser_ViewGraph.Location = new System.Drawing.Point(340, 21);
            this.cb_CreateUser_ViewGraph.Name = "cb_CreateUser_ViewGraph";
            this.cb_CreateUser_ViewGraph.Size = new System.Drawing.Size(86, 19);
            this.cb_CreateUser_ViewGraph.TabIndex = 3;
            this.cb_CreateUser_ViewGraph.Text = "View Graph";
            this.cb_CreateUser_ViewGraph.UseVisualStyleBackColor = true;
            // 
            // cb_CreateUser_UnderCostSale
            // 
            this.cb_CreateUser_UnderCostSale.AutoSize = true;
            this.cb_CreateUser_UnderCostSale.Location = new System.Drawing.Point(431, 21);
            this.cb_CreateUser_UnderCostSale.Name = "cb_CreateUser_UnderCostSale";
            this.cb_CreateUser_UnderCostSale.Size = new System.Drawing.Size(112, 19);
            this.cb_CreateUser_UnderCostSale.TabIndex = 4;
            this.cb_CreateUser_UnderCostSale.Text = "Under Cost Sale";
            this.cb_CreateUser_UnderCostSale.UseVisualStyleBackColor = true;
            // 
            // btn_CreateUser_Create
            // 
            this.btn_CreateUser_Create.Location = new System.Drawing.Point(452, 235);
            this.btn_CreateUser_Create.Name = "btn_CreateUser_Create";
            this.btn_CreateUser_Create.Size = new System.Drawing.Size(75, 37);
            this.btn_CreateUser_Create.TabIndex = 1;
            this.btn_CreateUser_Create.Text = "Create";
            this.btn_CreateUser_Create.UseVisualStyleBackColor = true;
            // 
            // btn_CreateUser_Cancel
            // 
            this.btn_CreateUser_Cancel.Location = new System.Drawing.Point(533, 235);
            this.btn_CreateUser_Cancel.Name = "btn_CreateUser_Cancel";
            this.btn_CreateUser_Cancel.Size = new System.Drawing.Size(75, 37);
            this.btn_CreateUser_Cancel.TabIndex = 2;
            this.btn_CreateUser_Cancel.Text = "Cancel";
            this.btn_CreateUser_Cancel.UseVisualStyleBackColor = true;
            // 
            // Frm_Administration_CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 281);
            this.Controls.Add(this.btn_CreateUser_Cancel);
            this.Controls.Add(this.btn_CreateUser_Create);
            this.Controls.Add(this.gb_CreateUser_UserDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Administration_CreateUser";
            this.Text = "Frm_Administration_CreateUser";
            this.gb_CreateUser_UserDetails.ResumeLayout(false);
            this.gb_CreateUser_UserDetails.PerformLayout();
            this.gb_CreateUser_PermissionLevel.ResumeLayout(false);
            this.gb_CreateUser_PermissionLevel.PerformLayout();
            this.gb_CreateUser_AccessibleLevel.ResumeLayout(false);
            this.gb_CreateUser_AccessibleLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CreateUser_UserDetails;
        private System.Windows.Forms.GroupBox gb_CreateUser_AccessibleLevel;
        private System.Windows.Forms.CheckBox cb_CreateUser_UnderCostSale;
        private System.Windows.Forms.CheckBox cb_CreateUser_ViewGraph;
        private System.Windows.Forms.CheckBox cb_CreateUser_ViewStock;
        private System.Windows.Forms.CheckBox cb_CreateUser_SalesPRWithoutStock;
        private System.Windows.Forms.CheckBox cb_CreateUser_ViewCost;
        private System.Windows.Forms.GroupBox gb_CreateUser_PermissionLevel;
        private System.Windows.Forms.RadioButton rb_CreateUser_Supervisor;
        private System.Windows.Forms.RadioButton rb_CreateUser_Admin;
        private System.Windows.Forms.RadioButton rb_CreateUser_User;
        private System.Windows.Forms.ComboBox cob_CreateUser_CostCenter;
        private System.Windows.Forms.Label lbl_CreateUser_CostCenter;
        private System.Windows.Forms.TextBox txt_CreateUser_ConfirmPassword;
        private System.Windows.Forms.Label lbl_CreateUser_ConfirmPassword;
        private System.Windows.Forms.TextBox txt_CreateUser_Password;
        private System.Windows.Forms.Label lbl_CreateUser_Password;
        private System.Windows.Forms.TextBox txt_CreateUser_UserName;
        private System.Windows.Forms.TextBox txt_CreateUser_StaffName;
        private System.Windows.Forms.Label lbl_CreateUser_UserName;
        private System.Windows.Forms.Label lbl_CreateUser_StaffName;
        private System.Windows.Forms.Button btn_CreateUser_Create;
        private System.Windows.Forms.Button btn_CreateUser_Cancel;
    }
}