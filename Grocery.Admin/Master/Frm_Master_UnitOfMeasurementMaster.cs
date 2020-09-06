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
    public partial class Frm_Master_UnitOfMeasurementMaster : Form
    {
        string FormName = "UOM";
        Int32 ActionFlag = 0;
        public Frm_Master_UnitOfMeasurementMaster()
        {
            InitializeComponent();
        }

        private void Frm_Master_UnitOfMeasurementMaster_Load(object sender, EventArgs e)
        {
            btn_UnitOfMeasurementMaster_Save.Enabled = false;
            btn_UnitOfMeasurementMaster_Cancel.Visible = false;
            btn_UnitOfMeasurementMaster_Edit.Enabled = false;
            btn_UnitOfMeasurementMaster_Delete.Enabled = false;
            PopulateUomMaster();
        }
        private void PopulateUomMaster()
        {
            GV_Uom.Rows.Clear();
            var uom = Uom.Get()
                            .Where(x => x.UOM_Name.ToLower().Contains(txt_UnitOfMeasurementMaster_UnitName_Search.Text.ToLower())).ToList();
            if (uom.Count > 0)
            {
                for (int i = 0; i < uom.Count; i++)
                {
                    GV_Uom.Rows.Add();
                    GV_Uom.Rows[i].Cells["UomId"].Value = uom[i].UOMId;
                    GV_Uom.Rows[i].Cells["UomName"].Value = uom[i].UOM_Name;
                    GV_Uom.Rows[i].Cells["UomPrintAs"].Value = uom[i].UOM_Printas;
                }
            }
        }
        private void btn_UnitOfMeasurementMaster_New_Click(object sender, EventArgs e)
        {
            txt_UnitOfMeasurementMaster_UomName.Enabled = true;
            txt_UnitOfMeasurementMaster_UomPrintAs.Enabled = true;
            btn_UnitOfMeasurementMaster_New.Enabled = false;
            btn_UnitOfMeasurementMaster_Edit.Enabled = false;
            btn_UnitOfMeasurementMaster_Delete.Enabled = false;
            btn_UnitOfMeasurementMaster_Save.Enabled = true;
            btn_UnitOfMeasurementMaster_Close.Visible = false;
            btn_UnitOfMeasurementMaster_Cancel.Visible = true;
            txt_UnitOfMeasurementMaster_UomId.Text = Uom.GetNextIDValue();
            ActionFlag = 1;
        }

        private void btn_UnitOfMeasurementMaster_Edit_Click(object sender, EventArgs e)
        {
            if (GV_Uom.Rows.Count > 0)
            {
                ActionFlag = 2;
                btn_UnitOfMeasurementMaster_New.Enabled = false;
                btn_UnitOfMeasurementMaster_Delete.Enabled = false;
                btn_UnitOfMeasurementMaster_Close.Visible = false;
                btn_UnitOfMeasurementMaster_Cancel.Visible = true;
                txt_UnitOfMeasurementMaster_UomId.Text = GV_Uom.Rows[0].Cells["UomId"].Value.ToString();
                txt_UnitOfMeasurementMaster_UomName.Text = GV_Uom.Rows[0].Cells["UomName"].Value.ToString();
                txt_UnitOfMeasurementMaster_UomPrintAs.Text = GV_Uom.Rows[0].Cells["UomPrintAs"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No data available.");
            }
        }

        private void btn_UnitOfMeasurementMaster_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete the record?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int uomid = Uom.SP_Uom(3, txt_UnitOfMeasurementMaster_UomId.Text, txt_UnitOfMeasurementMaster_UomName.Text, txt_UnitOfMeasurementMaster_UomPrintAs.Text, GolobalItems.UserId);
                if (uomid > 0)
                    MessageBox.Show("Data deleted succesfully!");
                PopulateUomMaster();
                ClearField();
            }
        }

        private void btn_UnitOfMeasurementMaster_Save_Click(object sender, EventArgs e)
        {
            if (txt_UnitOfMeasurementMaster_UomId.Text.Length == 0)
            {
                MessageBox.Show("UOM Id is blank!");
                return;
            }
            if (txt_UnitOfMeasurementMaster_UomName.Text.Length == 0)
            {
                MessageBox.Show("Name is blank!");
                return;
            }
            int uomid = Brand.SP_Brand(ActionFlag, txt_UnitOfMeasurementMaster_UomId.Text, txt_UnitOfMeasurementMaster_UomName.Text, txt_UnitOfMeasurementMaster_UomPrintAs.Text, GolobalItems.UserId);
            if (uomid > 0)
                MessageBox.Show("Data inserted succesfully!");
            PopulateUomMaster();
            ClearField();
        }
        private void ClearField()
        {
            txt_UnitOfMeasurementMaster_UomId.Text = "";
            txt_UnitOfMeasurementMaster_UomName.Text = "";
            txt_UnitOfMeasurementMaster_UomPrintAs.Text = "";
        }
        private void btn_UnitOfMeasurementMaster_Close_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close the form?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_UnitOfMeasurementMaster_UnitName_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateUomMaster();
        }

        private void GV_Uom_DoubleClick(object sender, EventArgs e)
        {
            txt_UnitOfMeasurementMaster_UomId.Text = GV_Uom.CurrentRow.Cells["UomId"].Value.ToString();
            txt_UnitOfMeasurementMaster_UomName.Text = GV_Uom.CurrentRow.Cells["UomName"].Value.ToString();
            txt_UnitOfMeasurementMaster_UomPrintAs.Text = GV_Uom.CurrentRow.Cells["UomPrintAs"].Value.ToString();
            ActionFlag = 2;
            btn_UnitOfMeasurementMaster_Save.Enabled = true;
            btn_UnitOfMeasurementMaster_Delete.Enabled = true;
            btn_UnitOfMeasurementMaster_Cancel.Visible = true;
            btn_UnitOfMeasurementMaster_Close.Visible = false;
            btn_UnitOfMeasurementMaster_Edit.Enabled = false;
            btn_UnitOfMeasurementMaster_New.Enabled = true;
        }

        private void btn_UnitOfMeasurementMaster_Cancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to discard all changes?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ClearField();
            }
        }
    }
}
