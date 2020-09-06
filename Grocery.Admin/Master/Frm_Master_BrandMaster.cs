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
    public partial class Frm_Master_BrandMaster : Form
    {
        string FormName = "BM";
        Int32 ActionFlag = 0;
        public Frm_Master_BrandMaster()
        {
            InitializeComponent();
        }
        
        private void Frm_Master_BrandMaster_Load(object sender, EventArgs e)
        {
            btn_BrandMaster_Save.Enabled = false;
            btn_BrandMaster_Cancel.Visible = false;
            btn_BrandMaster_Edit.Enabled = false;
            btn_BrandMaster_Delete.Enabled = false;
            PopulateBrandMaster();
        }
        private void PopulateBrandMaster()
        {
            GV_BrandMaster.Rows.Clear();
            var brand = Brand.Get()
                            .Where(x => x.brandid.ToLower().Contains(txt_BrandMaster_BrandId_Search.Text.ToLower()) 
                                && x.brandname.ToLower().Contains(txt_BrandMaster_BrandName_Search.Text.ToLower())).ToList();
            if (brand.Count > 0)
            {
                for (int i = 0; i < brand.Count; i++)
                {
                    GV_BrandMaster.Rows.Add();
                    GV_BrandMaster.Rows[i].Cells["clmBrandid"].Value = brand[i].brandid;
                    GV_BrandMaster.Rows[i].Cells["clmBrandname"].Value = brand[i].brandname;
                    GV_BrandMaster.Rows[i].Cells["clmBranddesc"].Value = brand[i].branddesc;
                }
            }
        }
        private void btn_BrandMaster_New_Click(object sender, EventArgs e)
        {
            txt_BrandMaster_BrandName.Enabled = true;
            txt_BrandMaster_BrandDescription.Enabled = true;
            btn_BrandMaster_New.Enabled = false;
            btn_BrandMaster_Edit.Enabled = false;
            btn_BrandMaster_Delete.Enabled = false;
            btn_BrandMaster_Save.Enabled = true;
            btn_BrandMaster_Close.Visible = false;
            btn_BrandMaster_Cancel.Visible = true;
            txt_BrandMaster_BrandId.Text = CommonFunction.GenerateNoSeries(GolobalItems.BranchCode, FormName);
            ActionFlag = 1;
        }

        private void btn_BrandMaster_Edit_Click(object sender, EventArgs e)
        {
            if (GV_BrandMaster.Rows.Count > 0)
            {
                ActionFlag = 2;
                btn_BrandMaster_New.Enabled = false;
                btn_BrandMaster_Delete.Enabled = false;
                btn_BrandMaster_Close.Visible = false;
                btn_BrandMaster_Cancel.Visible = true;
                txt_BrandMaster_BrandId.Text = GV_BrandMaster.Rows[0].Cells["clmBrandid"].Value.ToString();
                txt_BrandMaster_BrandName.Text = GV_BrandMaster.Rows[0].Cells["clmBrandname"].Value.ToString();
                txt_BrandMaster_BrandDescription.Text = GV_BrandMaster.Rows[0].Cells["clmBranddesc"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No data available.");
            }
        }

        private void txt_BrandMaster_BrandId_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateBrandMaster();
        }

        private void txt_BrandMaster_BrandName_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateBrandMaster();
        }

        private void btn_BrandMaster_Close_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close the form?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_BrandMaster_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete the record?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int brandid = Brand.SP_Brand(3, txt_BrandMaster_BrandId.Text, txt_BrandMaster_BrandName.Text, txt_BrandMaster_BrandDescription.Text, GolobalItems.UserId);
                if (brandid > 0)
                    MessageBox.Show("Data deleted succesfully!");
                PopulateBrandMaster();
                ClearField();
            }
        }

        private void btn_BrandMaster_Save_Click(object sender, EventArgs e)
        {
            if(txt_BrandMaster_BrandId.Text.Length == 0)
            {
                MessageBox.Show("Brand Id is blank!");
                return;
            }
            if (txt_BrandMaster_BrandName.Text.Length == 0)
            {
                MessageBox.Show("Brand Name is blank!");
                return;
            }
            int brandid = Brand.SP_Brand(ActionFlag, txt_BrandMaster_BrandId.Text, txt_BrandMaster_BrandName.Text, txt_BrandMaster_BrandDescription.Text, GolobalItems.UserId);
            if (brandid > 0)
                MessageBox.Show("Data inserted succesfully!");
            PopulateBrandMaster();
            ClearField();
        }
        private void ClearField()
        {
            txt_BrandMaster_BrandId.Text = "";
            txt_BrandMaster_BrandName.Text = "";
            txt_BrandMaster_BrandDescription.Text = "";
        }
        private void GV_BrandMaster_DoubleClick(object sender, EventArgs e)
        {
            txt_BrandMaster_BrandId.Text = GV_BrandMaster.CurrentRow.Cells["clmBrandid"].Value.ToString();
            txt_BrandMaster_BrandName.Text = GV_BrandMaster.CurrentRow.Cells["clmBrandname"].Value.ToString();
            txt_BrandMaster_BrandDescription.Text = GV_BrandMaster.CurrentRow.Cells["clmBranddesc"].Value.ToString();
            ActionFlag = 2;
            btn_BrandMaster_Save.Enabled = true;
            btn_BrandMaster_Delete.Enabled = true;
            btn_BrandMaster_Cancel.Visible = true;
            btn_BrandMaster_Close.Visible = false;
            btn_BrandMaster_Edit.Enabled = false;
            btn_BrandMaster_New.Enabled = true;
        }

        private void btn_BrandMaster_Cancel_Click(object sender, EventArgs e)
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
    }
}
