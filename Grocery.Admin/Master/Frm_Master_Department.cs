using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grocery.Admin.Common;
using Grocery.BussinessLogic.Repositories;

namespace Grocery.Admin.Master
{
    public partial class Frm_Master_Department : Form
    {
        string FormName = "DM";
        Int32 ActionFlag = 0;
        public Frm_Master_Department()
        {
            InitializeComponent();
        }

        private void txt_Master_Departmet_DepartmentId_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateDepartmentMaster();
        }

        private void txt_Master_Departmet_DepartmentName_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateDepartmentMaster();
        }

        private void btn_Master_Department_New_Click(object sender, EventArgs e)
        {
            txt_Master_Department_DepartmentName.Enabled = true;
            txt_Master_Department_DepartmentDescription.Enabled = true;
            txt_Master_Department_ArabicName.Enabled = true;
            btn_Master_Department_New.Enabled = false;
            btn_Master_Department_Edit.Enabled = false;
            btn_Master_Department_Delete.Enabled = false;
            btn_Master_Department_Save.Enabled = true;
            btn_Master_Department_Close.Visible = false;
            btn_Master_Department_Cancel.Visible = true;
            txt_Master_Department_DepartmentId.Text = Department.GetNextIDValue();
            ActionFlag = 1;
        }

        private void btn_Master_Department_Edit_Click(object sender, EventArgs e)
        {
            if (GV_Department.Rows.Count > 0)
            {
                ActionFlag = 2;
                btn_Master_Department_New.Enabled = false;
                btn_Master_Department_Delete.Enabled = false;
                btn_Master_Department_Close.Visible = false;
                btn_Master_Department_Cancel.Visible = true;
                txt_Master_Department_DepartmentId.Text = GV_Department.Rows[0].Cells["Dpt_Id"].Value.ToString();
                txt_Master_Department_DepartmentName.Text = GV_Department.Rows[0].Cells["Dtp_Name"].Value.ToString();
                txt_Master_Department_DepartmentDescription.Text = GV_Department.Rows[0].Cells["DepartmentDesc"].Value.ToString();
                txt_Master_Department_ArabicName.Text = GV_Department.Rows[0].Cells["ArabicName"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No data available.");
            }
        }

        private void btn_Master_Department_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete the record?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int departmentid = Department.SP_Department(3, txt_Master_Department_DepartmentId.Text, txt_Master_Department_DepartmentName.Text, txt_Master_Department_DepartmentDescription.Text, txt_Master_Department_ArabicName.Text, GolobalItems.UserId);
                if (departmentid > 0)
                    MessageBox.Show("Data deleted succesfully!");
                PopulateDepartmentMaster();
                ClearField();
            }
        }
        private void ClearField()
        {
            txt_Master_Department_DepartmentId.Text = "";
            txt_Master_Department_DepartmentName.Text = "";
            txt_Master_Department_DepartmentDescription.Text = "";
            txt_Master_Department_ArabicName.Text = "";
        }
        private void btn_Master_Department_Save_Click(object sender, EventArgs e)
        {
            if (txt_Master_Department_DepartmentId.Text.Length == 0)
            {
                MessageBox.Show("Department Id is blank!");
                return;
            }
            if (txt_Master_Department_DepartmentName.Text.Length == 0)
            {
                MessageBox.Show("Name is blank!");
                return;
            }
            int departmentid = Department.SP_Department(ActionFlag, txt_Master_Department_DepartmentId.Text, txt_Master_Department_DepartmentName.Text, txt_Master_Department_DepartmentDescription.Text,txt_Master_Department_ArabicName.Text, GolobalItems.UserId);
            if (departmentid > 0)
                MessageBox.Show("Data inserted succesfully!");
            PopulateDepartmentMaster();
            ClearField();
        }

        private void btn_Master_Department_Close_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close the form?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Master_Department_Cancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to discard all changes?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ClearField();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void Frm_Master_Department_Load(object sender, EventArgs e)
        {
            btn_Master_Department_Save.Enabled = false;
            btn_Master_Department_Cancel.Visible = false;
            btn_Master_Department_Edit.Enabled = false;
            btn_Master_Department_Delete.Enabled = false;
            PopulateDepartmentMaster();
        }
        private void PopulateDepartmentMaster()
        {
            
            GV_Department.Rows.Clear();
            var department = Department.Get()
                            .Where(x => x.Dpt_Id.ToLower().Contains(txt_Master_Departmet_DepartmentId_Search.Text.ToLower())
                                && x.Dtp_Name.ToLower().Contains(txt_Master_Departmet_DepartmentName_Search.Text.ToLower())).ToList();
            if (department.Count > 0)
            {
                for (int i = 0; i < department.Count; i++)
                {
                    GV_Department.Rows.Add();
                    GV_Department.Rows[i].Cells["Dpt_Id"].Value = department[i].Dpt_Id;
                    GV_Department.Rows[i].Cells["Dtp_Name"].Value = department[i].Dtp_Name;
                    GV_Department.Rows[i].Cells["DepartmentDesc"].Value = department[i].DepartmentDesc;
                    GV_Department.Rows[i].Cells["ArabicName"].Value = department[i].arabicname;
                }
            }
        }

        private void GV_Department_DoubleClick(object sender, EventArgs e)
        {
            txt_Master_Department_DepartmentId.Text = GV_Department.CurrentRow.Cells["Dpt_Id"].Value.ToString();
            txt_Master_Department_DepartmentName.Text = GV_Department.CurrentRow.Cells["Dtp_Name"].Value.ToString();
            txt_Master_Department_DepartmentDescription.Text = GV_Department.CurrentRow.Cells["DepartmentDesc"].Value.ToString();
            txt_Master_Department_ArabicName.Text = GV_Department.CurrentRow.Cells["ArabicName"].Value.ToString();
            ActionFlag = 2;
            btn_Master_Department_Save.Enabled = true;
            btn_Master_Department_Delete.Enabled = true;
            btn_Master_Department_Cancel.Visible = true;
            btn_Master_Department_Close.Visible = false;
            btn_Master_Department_Edit.Enabled = false;
            btn_Master_Department_New.Enabled = true;
        }
    }
}
