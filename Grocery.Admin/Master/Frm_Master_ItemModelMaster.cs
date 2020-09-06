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
    public partial class Frm_Master_ItemModelMaster : Form
    {
        string FormName = "IM";
        Int32 ActionFlag = 0;
        public Frm_Master_ItemModelMaster()
        {
            InitializeComponent();
        }

        private void Frm_Master_ItemModelMaster_Load(object sender, EventArgs e)
        {
            btn_ItemModel_Save.Enabled = false;
            btn_ItemModel_Cancel.Visible = false;
            btn_ItemModel_Edit.Enabled = false;
            btn_ItemModel_Delete.Enabled = false;
            PopulateItemModelMaster();
        }
        private void PopulateItemModelMaster()
        {

            GV_ItemModel_ModelDetails.Rows.Clear();
            var itemmodel = ItemModel.Get()
                            .Where(x => x.ModelName.ToLower().Contains(txt_ItemModel_SrchModelName.Text.ToLower())).ToList();
            if (itemmodel.Count > 0)
            {
                for (int i = 0; i < itemmodel.Count; i++)
                {
                    GV_ItemModel_ModelDetails.Rows.Add();
                    GV_ItemModel_ModelDetails.Rows[i].Cells["clmmodelID"].Value = itemmodel[i].modelID;
                    GV_ItemModel_ModelDetails.Rows[i].Cells["clmModelName"].Value = itemmodel[i].ModelName;
                    GV_ItemModel_ModelDetails.Rows[i].Cells["clmDescription"].Value = itemmodel[i].Description;
                }
            }
        }
        private void btn_ItemModel_New_Click(object sender, EventArgs e)
        {
            txt_ItemModel_ModelName.Enabled = true;
            txt_ItemModel_ModelDesc.Enabled = true;
            btn_ItemModel_New.Enabled = false;
            btn_ItemModel_Edit.Enabled = false;
            btn_ItemModel_Delete.Enabled = false;
            btn_ItemModel_Save.Enabled = true;
            btn_ItemModel_Close.Visible = false;
            btn_ItemModel_Cancel.Visible = true;
            txt_ItemModel_ModelID.Text = ItemModel.GetNextIDValue();
            ActionFlag = 1;
        }

        private void btn_ItemModel_Edit_Click(object sender, EventArgs e)
        {
            if (GV_ItemModel_ModelDetails.Rows.Count > 0)
            {
                ActionFlag = 2;
                btn_ItemModel_New.Enabled = false;
                btn_ItemModel_Delete.Enabled = false;
                btn_ItemModel_Close.Visible = false;
                btn_ItemModel_Cancel.Visible = true;
                txt_ItemModel_ModelID.Text = GV_ItemModel_ModelDetails.Rows[0].Cells["clmmodelID"].Value.ToString();
                txt_ItemModel_ModelName.Text = GV_ItemModel_ModelDetails.Rows[0].Cells["clmModelName"].Value.ToString();
                txt_ItemModel_ModelDesc.Text = GV_ItemModel_ModelDetails.Rows[0].Cells["clmDescription"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No data available.");
            }
        }

        private void btn_ItemModel_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete the record?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int modelid = ItemModel.SP_ItemModel(3, txt_ItemModel_ModelID.Text, "", "", GolobalItems.UserId);
                if (modelid > 0)
                    MessageBox.Show("Data deleted succesfully!");
                PopulateItemModelMaster();
                ClearField();
            }
        }
        private void ClearField()
        {
            txt_ItemModel_ModelID.Text = "";
            txt_ItemModel_ModelName.Text = "";
            txt_ItemModel_ModelDesc.Text = "";
        }
        private void btn_ItemModel_Save_Click(object sender, EventArgs e)
        {
            if (txt_ItemModel_ModelID.Text.Length == 0)
            {
                MessageBox.Show("Id is blank!");
                return;
            }
            if (txt_ItemModel_ModelName.Text.Length == 0)
            {
                MessageBox.Show("Name is blank!");
                return;
            }
            int modelid = ItemModel.SP_ItemModel(ActionFlag, txt_ItemModel_ModelID.Text, txt_ItemModel_ModelName.Text, txt_ItemModel_ModelDesc.Text, GolobalItems.UserId);
            if (modelid > 0)
                MessageBox.Show("Data inserted succesfully!");
            PopulateItemModelMaster();
            ClearField();
        }

        private void btn_ItemModel_Close_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close the form?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_ItemModel_Cancel_Click(object sender, EventArgs e)
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

        private void txt_ItemModel_SrchModelName_TextChanged(object sender, EventArgs e)
        {
            PopulateItemModelMaster();
        }

        private void GV_ItemModel_ModelDetails_DoubleClick(object sender, EventArgs e)
        {
            txt_ItemModel_ModelID.Text = GV_ItemModel_ModelDetails.CurrentRow.Cells["clmmodelID"].Value.ToString();
            txt_ItemModel_ModelName.Text = GV_ItemModel_ModelDetails.CurrentRow.Cells["clmModelName"].Value.ToString();
            txt_ItemModel_ModelDesc.Text = GV_ItemModel_ModelDetails.CurrentRow.Cells["clmDescription"].Value.ToString();
            ActionFlag = 2;
            btn_ItemModel_Save.Enabled = true;
            btn_ItemModel_Delete.Enabled = true;
            btn_ItemModel_Cancel.Visible = true;
            btn_ItemModel_Close.Visible = false;
            btn_ItemModel_Edit.Enabled = false;
            btn_ItemModel_New.Enabled = true;
        }
    }
}
