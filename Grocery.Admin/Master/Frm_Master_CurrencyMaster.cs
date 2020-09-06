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
    public partial class Frm_Master_CurrencyMaster : Form
    {
        string FormName = "CR";
        Int32 ActionFlag = 0;
        public Frm_Master_CurrencyMaster()
        {
            InitializeComponent();
        }

        private void Frm_Master_CurrencyMaster_Load(object sender, EventArgs e)
        {
            
            btn_Master_CurrencyMaster_Save.Enabled = false;
            btn_Master_CurrencyMaster_Cancel.Visible = false;
            btn_Master_CurrencyMaster_Edit.Enabled = false;
            btn_Master_CurrencyMaster_Delete.Enabled = false;
            PopulateCurrencyMaster();
        }
        private void PopulateCurrencyMaster()
        {
            GV_CurrencyMaster.Rows.Clear();
            var currency = Currency.Get()
                            .Where(x => x.ID.ToLower().Contains(txt_Master_CurrencyMaster_CurrencyId_Search.Text.ToLower())
                                && x.Name.ToLower().Contains(txt_Master_CurrencyMaster_CurrencyName_Search.Text.ToLower())).ToList();
            if (currency.Count > 0)
            {
                for (int i = 0; i < currency.Count; i++)
                {
                    GV_CurrencyMaster.Rows.Add();
                    GV_CurrencyMaster.Rows[i].Cells["clmID"].Value = currency[i].ID;
                    GV_CurrencyMaster.Rows[i].Cells["clmName"].Value = currency[i].Name;
                    GV_CurrencyMaster.Rows[i].Cells["clmExRate"].Value = currency[i].ExRate;
                    GV_CurrencyMaster.Rows[i].Cells["clmRemark"].Value = currency[i].Remark;
                }
            }
        }
        private void btn_Master_CurrencyMaster_New_Click(object sender, EventArgs e)
        {
            txt_Master_CurrencyMaster_CurrencyName.Enabled = true;
            txt_Master_CurrencyMaster_ExchangeRate.Enabled = true;
            txt_Master_CurrencyMaster_Remarks.Enabled = true;
            btn_Master_CurrencyMaster_New.Enabled = false;
            btn_Master_CurrencyMaster_Edit.Enabled = false;
            btn_Master_CurrencyMaster_Delete.Enabled = false;
            btn_Master_CurrencyMaster_Save.Enabled = true;
            btn_Master_CurrencyMaster_Close.Visible = false;
            btn_Master_CurrencyMaster_Cancel.Visible = true;            
            txt_Master_CurrencyMaster_CurrencyId.Text = Currency.GetNextIDValue();
            ActionFlag = 1;
        }

        private void btn_Master_CurrencyMaster_Edit_Click(object sender, EventArgs e)
        {
            if (GV_CurrencyMaster.Rows.Count > 0)
            {
                ActionFlag = 2;
                btn_Master_CurrencyMaster_New.Enabled = false;
                btn_Master_CurrencyMaster_Delete.Enabled = false;
                btn_Master_CurrencyMaster_Close.Visible = false;
                btn_Master_CurrencyMaster_Cancel.Visible = true;
                txt_Master_CurrencyMaster_CurrencyId.Text = GV_CurrencyMaster.Rows[0].Cells["clmID"].Value.ToString();
                txt_Master_CurrencyMaster_CurrencyName.Text = GV_CurrencyMaster.Rows[0].Cells["clmName"].Value.ToString();
                txt_Master_CurrencyMaster_ExchangeRate.Text = GV_CurrencyMaster.Rows[0].Cells["clmExRate"].Value.ToString();
                txt_Master_CurrencyMaster_Remarks.Text = GV_CurrencyMaster.Rows[0].Cells["clmRemark"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No data available.");
            }
        }

        private void btn_Master_CurrencyMaster_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete the record?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int currencyid = Currency.SP_Currency(3, txt_Master_CurrencyMaster_CurrencyId.Text, txt_Master_CurrencyMaster_CurrencyName.Text, txt_Master_CurrencyMaster_ExchangeRate.Text,txt_Master_CurrencyMaster_Remarks.Text, GolobalItems.UserId);
                if (currencyid > 0)
                    MessageBox.Show("Data deleted succesfully!");
                PopulateCurrencyMaster();
                ClearField();
            }
        }
        private void ClearField()
        {
            txt_Master_CurrencyMaster_CurrencyId.Text = "";
            txt_Master_CurrencyMaster_CurrencyName.Text = "";
            txt_Master_CurrencyMaster_ExchangeRate.Text = "";
            txt_Master_CurrencyMaster_Remarks.Text = "";    
        }
        private void btn_Master_CurrencyMaster_Save_Click(object sender, EventArgs e)
        {
            if (txt_Master_CurrencyMaster_CurrencyId.Text.Length == 0)
            {
                MessageBox.Show("ID is blank!");
                return;
            }
            if (txt_Master_CurrencyMaster_CurrencyName.Text.Length == 0)
            {
                MessageBox.Show("Currency Name is blank!");
                return;
            }
            if (txt_Master_CurrencyMaster_ExchangeRate.Text.Length == 0)
            {
                MessageBox.Show("Rate is blank!");
                return;
            }
            int currencyid = Currency.SP_Currency(ActionFlag, txt_Master_CurrencyMaster_CurrencyId.Text, txt_Master_CurrencyMaster_CurrencyName.Text, txt_Master_CurrencyMaster_ExchangeRate.Text, txt_Master_CurrencyMaster_Remarks.Text, GolobalItems.UserId);
            if (currencyid > 0)
                MessageBox.Show("Data inserted succesfully!");
            PopulateCurrencyMaster();
            ClearField();
        }

        private void btn_Master_CurrencyMaster_Close_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close the form?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Master_CurrencyMaster_Cancel_Click(object sender, EventArgs e)
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

        private void txt_Master_CurrencyMaster_CurrencyId_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateCurrencyMaster();
        }

        private void txt_Master_CurrencyMaster_CurrencyName_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateCurrencyMaster();
        }

        private void GV_CurrencyMaster_DoubleClick(object sender, EventArgs e)
        {
            txt_Master_CurrencyMaster_CurrencyId.Text = GV_CurrencyMaster.CurrentRow.Cells["clmID"].Value.ToString();
            txt_Master_CurrencyMaster_CurrencyName.Text = GV_CurrencyMaster.CurrentRow.Cells["clmName"].Value.ToString();
            txt_Master_CurrencyMaster_ExchangeRate.Text = GV_CurrencyMaster.CurrentRow.Cells["clmExRate"].Value.ToString();
            txt_Master_CurrencyMaster_Remarks.Text = GV_CurrencyMaster.CurrentRow.Cells["clmRemark"].Value.ToString();
            ActionFlag = 2;
            btn_Master_CurrencyMaster_Save.Enabled = true;
            btn_Master_CurrencyMaster_New.Enabled = true;
            btn_Master_CurrencyMaster_Delete.Enabled = true;
            btn_Master_CurrencyMaster_Close.Visible = false;
            btn_Master_CurrencyMaster_Cancel.Visible = true;
            btn_Master_CurrencyMaster_Edit.Enabled = false;
        }
    }
}
