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
    public partial class Frm_Master_StockLocation : Form
    {
        string FormName = "SL";
        Int32 ActionFlag = 0;
        public Frm_Master_StockLocation()
        {
            InitializeComponent();
        }

        private void Frm_Master_StockLocation_Load(object sender, EventArgs e)
        {
            btn_Master_StockLocation_Save.Enabled = false;
            btn_Master_StockLocation_Cancel.Visible = false;
            btn_Master_StockLocation_Edit.Enabled = false;
            btn_Master_StockLocation_Delete.Enabled = false;
            PopulateStockLocationMaster();
        }
        private void PopulateStockLocationMaster()
        {
            GV_Stocklocation.Rows.Clear();
            var stock = Stocklocation.Get()
                            .Where(x => x.StockLocation.ToLower().Contains(txt_Master_StockLocation_Location_Search.Text.ToLower())
                                && x.StockDesc.ToLower().Contains(txt_Master_StockLocation_Description_Search.Text.ToLower())).ToList();
            if (stock.Count > 0)
            {
                for (int i = 0; i < stock.Count; i++)
                {
                    GV_Stocklocation.Rows.Add();
                    GV_Stocklocation.Rows[i].Cells["StockId"].Value = stock[i].StockId;
                    GV_Stocklocation.Rows[i].Cells["StockLocation"].Value = stock[i].StockLocation;
                    GV_Stocklocation.Rows[i].Cells["StockDesc"].Value = stock[i].StockDesc;
                }
            }
        }
        private void btn_Master_StockLocation_New_Click(object sender, EventArgs e)
        {
            txt_Master_StockLocation_StockLocation.Enabled = true;
            txt_Master_StockLocation_StockDescription.Enabled = true;
            btn_Master_StockLocation_New.Enabled = false;
            btn_Master_StockLocation_Edit.Enabled = false;
            btn_Master_StockLocation_Delete.Enabled = false;
            btn_Master_StockLocation_Save.Enabled = true;
            btn_Master_StockLocation_Close.Visible = false;
            btn_Master_StockLocation_Cancel.Visible = true;
            txt_Master_StockLocationr_StockId.Text = Stocklocation.GetNextIDValue();
            ActionFlag = 1;
        }

        private void btn_Master_StockLocation_Edit_Click(object sender, EventArgs e)
        {
            if (GV_Stocklocation.Rows.Count > 0)
            {
                ActionFlag = 2;
                btn_Master_StockLocation_New.Enabled = false;
                btn_Master_StockLocation_Delete.Enabled = false;
                btn_Master_StockLocation_Close.Visible = false;
                btn_Master_StockLocation_Cancel.Visible = true;
                txt_Master_StockLocationr_StockId.Text = GV_Stocklocation.Rows[0].Cells["StockId"].Value.ToString();
                txt_Master_StockLocation_StockLocation.Text = GV_Stocklocation.Rows[0].Cells["StockLocation"].Value.ToString();
                txt_Master_StockLocation_StockDescription.Text = GV_Stocklocation.Rows[0].Cells["StockDesc"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No data available.");
            }
        }

        private void btn_Master_StockLocation_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete the record?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int brandid = Brand.SP_Brand(3, txt_Master_StockLocationr_StockId.Text, "", "", GolobalItems.UserId);
                if (brandid > 0)
                    MessageBox.Show("Data deleted succesfully!");
                PopulateStockLocationMaster();
                ClearField();
            }
        }
        private void ClearField()
        {
            txt_Master_StockLocationr_StockId.Text = "";
            txt_Master_StockLocation_StockLocation.Text = "";
            txt_Master_StockLocation_StockDescription.Text = "";
        }
        private void btn_Master_StockLocation_Save_Click(object sender, EventArgs e)
        {
            if (txt_Master_StockLocationr_StockId.Text.Length == 0)
            {
                MessageBox.Show("Stock Id is blank!");
                return;
            }
            if (txt_Master_StockLocation_StockLocation.Text.Length == 0)
            {
                MessageBox.Show("Stock Location is blank!");
                return;
            }
            int stockid = Stocklocation.SP_StockLocation(ActionFlag, txt_Master_StockLocationr_StockId.Text, txt_Master_StockLocation_StockLocation.Text, txt_Master_StockLocation_StockDescription.Text, GolobalItems.UserId);
            if (stockid > 0)
                MessageBox.Show("Data inserted succesfully!");
            PopulateStockLocationMaster();
            ClearField();
        }

        private void btn_Master_StockLocation_Close_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close the form?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Master_StockLocation_Cancel_Click(object sender, EventArgs e)
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

        private void txt_Master_StockLocation_Location_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateStockLocationMaster();
        }

        private void txt_Master_StockLocation_Description_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateStockLocationMaster();
        }

        private void GV_Stocklocation_DoubleClick(object sender, EventArgs e)
        {
            txt_Master_StockLocationr_StockId.Text = GV_Stocklocation.CurrentRow.Cells["StockId"].Value.ToString();
            txt_Master_StockLocation_StockLocation.Text = GV_Stocklocation.CurrentRow.Cells["StockLocation"].Value.ToString();
            txt_Master_StockLocation_StockDescription.Text = GV_Stocklocation.CurrentRow.Cells["StockDesc"].Value.ToString();
            ActionFlag = 2;
            btn_Master_StockLocation_Save.Enabled = true;
            btn_Master_StockLocation_Delete.Enabled = true;
            btn_Master_StockLocation_Cancel.Visible = true;
            btn_Master_StockLocation_Close.Visible = false;
            btn_Master_StockLocation_Edit.Enabled = false;
            btn_Master_StockLocation_New.Enabled = true;
        }
    }
}
