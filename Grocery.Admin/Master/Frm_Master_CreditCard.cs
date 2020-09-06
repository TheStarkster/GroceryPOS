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
    public partial class Frm_Master_CreditCard : Form
    {
        string FormName = "CC";
        Int32 ActionFlag = 0;
        public Frm_Master_CreditCard()
        {
            InitializeComponent();
        }

        private void btn_Master_CreditCard_New_Click(object sender, EventArgs e)
        {
            txt_Master_CreditCard_Name.Enabled = true;
            txt_Master_CreditCard_Bank.Enabled = true;
            txt_Master_CreditCard_CommissionRate.Enabled = true;
            btn_Master_CreditCard_New.Enabled = false;
            btn_Master_CreditCard_Edit.Enabled = false;
            btn_Master_CreditCard_Delete.Enabled = false;
            btn_Master_CreditCard_Save.Enabled = true;
            btn_Master_CreditCard_Close.Visible = false;
            btn_Master_CreditCard_Cancel.Visible = true;
            txt_Master_CreditCard_Id.Text = Creditcard.GetNextIDValue();
            ActionFlag = 1;
        }

        private void Frm_Master_CreditCard_Load(object sender, EventArgs e)
        {
            btn_Master_CreditCard_Save.Enabled = false;
            btn_Master_CreditCard_Cancel.Visible = false;
            btn_Master_CreditCard_Edit.Enabled = false;
            btn_Master_CreditCard_Delete.Enabled = false;
            PopulateCreditcardMaster();
        }
        private void PopulateCreditcardMaster()
        {
            GV_CreditCardMaster.Rows.Clear();
            var creditcard = Creditcard.Get()
                            .Where(x => x.ID.ToLower().Contains(txt_Master_CreditCard_Id_Search.Text.ToLower())
                                && x.Name.ToLower().Contains(txt_Master_CreditCard_Name_Search.Text.ToLower())).ToList();
            if (creditcard.Count > 0)
            {
                for (int i = 0; i < creditcard.Count; i++)
                {
                    GV_CreditCardMaster.Rows.Add();
                    GV_CreditCardMaster.Rows[i].Cells["clmID"].Value = creditcard[i].ID;
                    GV_CreditCardMaster.Rows[i].Cells["clmName"].Value = creditcard[i].Name;
                    GV_CreditCardMaster.Rows[i].Cells["clmBank"].Value = creditcard[i].Bank;
                    GV_CreditCardMaster.Rows[i].Cells["clmCommissionRate"].Value = creditcard[i].CommissionRate;
                }
            }
        }
        private void GV_CreditCardMaster_DoubleClick(object sender, EventArgs e)
        {
            txt_Master_CreditCard_Id.Text = GV_CreditCardMaster.CurrentRow.Cells["clmID"].Value.ToString();
            txt_Master_CreditCard_Name.Text = GV_CreditCardMaster.CurrentRow.Cells["clmName"].Value.ToString();
            txt_Master_CreditCard_Bank.Text = GV_CreditCardMaster.CurrentRow.Cells["clmBank"].Value.ToString();
            txt_Master_CreditCard_CommissionRate.Text = GV_CreditCardMaster.CurrentRow.Cells["clmCommissionRate"].Value.ToString();
            ActionFlag = 2;
            btn_Master_CreditCard_Save.Enabled = true;
            btn_Master_CreditCard_New.Enabled = true;
            btn_Master_CreditCard_Delete.Enabled = true;
            btn_Master_CreditCard_Close.Visible = false;
            btn_Master_CreditCard_Cancel.Visible = true;
            btn_Master_CreditCard_Edit.Enabled = false;
        }

        private void btn_Master_CreditCard_Edit_Click(object sender, EventArgs e)
        {
            if (GV_CreditCardMaster.Rows.Count > 0)
            {
                ActionFlag = 2;
                btn_Master_CreditCard_New.Enabled = false;
                btn_Master_CreditCard_Delete.Enabled = false;
                btn_Master_CreditCard_Close.Visible = false;
                btn_Master_CreditCard_Cancel.Visible = true;
                txt_Master_CreditCard_Id.Text = GV_CreditCardMaster.Rows[0].Cells["clmID"].Value.ToString();
                txt_Master_CreditCard_Name.Text = GV_CreditCardMaster.Rows[0].Cells["clmName"].Value.ToString();
                txt_Master_CreditCard_Bank.Text = GV_CreditCardMaster.Rows[0].Cells["clmBank"].Value.ToString();
                txt_Master_CreditCard_CommissionRate.Text = GV_CreditCardMaster.Rows[0].Cells["clmCommissionRate"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No data available.");
            }
        }

        private void btn_Master_CreditCard_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete the record?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int currencyid = Creditcard.SP_Creditcard(3, txt_Master_CreditCard_Id.Text, "", "", "", GolobalItems.UserId);
                if (currencyid > 0)
                    MessageBox.Show("Data deleted succesfully!");
                PopulateCreditcardMaster();
                ClearField();
            }
        }
        private void ClearField()
        {
            txt_Master_CreditCard_Id.Text = "";
            txt_Master_CreditCard_Name.Text = "";
            txt_Master_CreditCard_Bank.Text = "";
            txt_Master_CreditCard_CommissionRate.Text = "";
        }
        private void btn_Master_CreditCard_Save_Click(object sender, EventArgs e)
        {
            if (txt_Master_CreditCard_Id.Text.Length == 0)
            {
                MessageBox.Show("ID is blank!");
                return;
            }
            if (txt_Master_CreditCard_Name.Text.Length == 0)
            {
                MessageBox.Show("Name is blank!");
                return;
            }
            int creditcardid = Creditcard.SP_Creditcard(ActionFlag, txt_Master_CreditCard_Id.Text, txt_Master_CreditCard_Name.Text, txt_Master_CreditCard_Bank.Text, txt_Master_CreditCard_CommissionRate.Text, GolobalItems.UserId);
            if (creditcardid > 0)
                MessageBox.Show("Data inserted succesfully!");
            PopulateCreditcardMaster();
            ClearField();
        }

        private void btn_Master_CreditCard_Close_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close the form?",
                                     GolobalItems.MessageCaption,
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Master_CreditCard_Cancel_Click(object sender, EventArgs e)
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

        private void txt_Master_CreditCard_Id_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateCreditcardMaster();
        }

        private void txt_Master_CreditCard_Name_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateCreditcardMaster();
        }
    }
}
