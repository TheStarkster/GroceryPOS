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
    public partial class Frm_Master_WarehouseMaster : Form
    {
        string FormName = "WH";
        Int32 ActionFlag = 0;



        public Frm_Master_WarehouseMaster()
        {
            InitializeComponent();
        }

        private void Frm_Master_WarehouseMaster_Load(object sender, EventArgs e)
        {
            btn_WarehouseMaster_Save.Enabled = false;
            btn_WarehouseMaster_Cancel.Visible = false;
            btn_WarehouseMaster_Edit.Enabled = false;
            btn_WarehouseMaster_Delete.Enabled = false;
            PopulateWarehouseMaster();
        }
        private void PopulateWarehouseMaster()
        {
            GV_WarehouseMaster.Rows.Clear();

            var warehouse = Warehouse.Get()
                           .Where(x => x.WhID.ToLower().Contains(txt_Warehouse_WarehouseId_Search.Text.ToLower())
                               && x.WhName.ToLower().Contains(txt_Warehouse_WarehouseName_Search.Text.ToLower())).ToList();


            if (warehouse.Count > 0)
            {
                for(int i=0; i<warehouse.Count;i++)
                {
                    GV_WarehouseMaster.Rows.Add();
                    GV_WarehouseMaster.Rows[i].Cells["clmWarehouseId"].Value = warehouse[i].WhID;
                    GV_WarehouseMaster.Rows[i].Cells["clmWarehouseName"].Value = warehouse[i].WhName;
                    GV_WarehouseMaster.Rows[i].Cells["clmSalesman"].Value = warehouse[i].Salesman;
                    GV_WarehouseMaster.Rows[i].Cells["clmEmpId"].Value = warehouse[i].EmpID;

                    //var salesman = warehouse[i].Salesman;
                    //cob_WarehouseMaster_WarehouseSalesman.Items.Add(salesman);
                }
            }

    
            
        }
        private void btn_WarehouseMaster_New_Click(object sender, EventArgs e)
        {
            txt_WarehouseMaster_WarehouseName.Enabled = true;
            txt_WarehouseMaster_WarehouseEmpID.Enabled = true;
            cob_WarehouseMaster_WarehouseSalesman.Enabled = true;
            btn_WarehouseMaster_New.Enabled = false;
            btn_WarehouseMaster_Edit.Enabled = false;
            btn_WarehouseMaster_Save.Enabled = true;
            btn_WarehouseMaster_Close.Visible = false;
            btn_WarehouseMaster_Cancel.Visible = true;

            txt_WarehouseMaster_WarehouseId.Text = Warehouse.GetNextIDValue();

          

            ActionFlag = 1;

        }

        private void btn_WarehouseMaster_Edit_Click(object sender, EventArgs e)
        {

            if(GV_WarehouseMaster.Rows.Count>0)
            {
                ActionFlag = 2;
                btn_WarehouseMaster_New.Enabled = false;
                btn_WarehouseMaster_Delete.Enabled = false;
                btn_WarehouseMaster_Close.Visible = false;
                btn_WarehouseMaster_Cancel.Visible = true;
                txt_WarehouseMaster_WarehouseId.Text = GV_WarehouseMaster.CurrentRow.Cells["clmWarehouseId"].Value.ToString();
                txt_WarehouseMaster_WarehouseName.Text = GV_WarehouseMaster.CurrentRow.Cells["clmWarehouseName"].Value.ToString();
                cob_WarehouseMaster_WarehouseSalesman.Text = GV_WarehouseMaster.CurrentRow.Cells["clmSalesman"].Value.ToString();
                txt_WarehouseMaster_WarehouseEmpID.Text = GV_WarehouseMaster.CurrentRow.Cells["clmEmpId"].Value.ToString();

            }
            {
                MessageBox.Show("No data available.");
            }

        }

        private void btn_WarehouseMaster_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete the record?", GolobalItems.MessageCaption, MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                int warehouseid = Warehouse.SP_Warehouse(3, txt_WarehouseMaster_WarehouseId.Text, txt_WarehouseMaster_WarehouseName.Text, txt_WarehouseMaster_WarehouseEmpID.Text, GolobalItems.UserId);
                if (warehouseid > 0)
                    MessageBox.Show("Data deleted Successfully!");
                PopulateWarehouseMaster();
                ClearField();
            }

        }

        private void btn_WarehouseMaster_Save_Click(object sender, EventArgs e)
        {
           if(txt_WarehouseMaster_WarehouseId.Text.Length==0)
            {
                MessageBox.Show("ID is blank!");
                return;
            }
            if (txt_WarehouseMaster_WarehouseName.Text.Length == 0)
            {
                MessageBox.Show("Warehouse Name is blank!");
                return;
            }
            if (cob_WarehouseMaster_WarehouseSalesman.Text.Length == 0)
            {
                MessageBox.Show("Salesman Field is blank!");
                return;
            }
            if (txt_WarehouseMaster_WarehouseEmpID.Text.Length == 0)
            {
                MessageBox.Show("Employee ID is blank!");
                return;
            }
            int warehouseid = Warehouse.SP_Warehouse(ActionFlag, txt_WarehouseMaster_WarehouseId.Text, txt_WarehouseMaster_WarehouseName.Text, txt_WarehouseMaster_WarehouseEmpID.Text, GolobalItems.UserId);
            if (warehouseid > 0)
                MessageBox.Show("Data inserted succesfully!");
            PopulateWarehouseMaster();
            ClearField();

        }

        private void btn_WarehouseMaster_Close_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are You sure to close the form?", GolobalItems.MessageCaption, MessageBoxButtons.YesNo);

            if(confirmResult==DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btn_WarehouseMaster_Cancel_Click(object sender, EventArgs e)
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
            btn_WarehouseMaster_New.Enabled = true;
            btn_WarehouseMaster_Close.Visible = true;
            btn_WarehouseMaster_Edit.Enabled = false;
            btn_WarehouseMaster_Save.Enabled = false;
            btn_WarehouseMaster_Delete.Enabled = false;
        }

        private void txt_Warehouse_WarehouseId_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateWarehouseMaster();
        }

        private void txt_Warehouse_WarehouseName_Search_TextChanged(object sender, EventArgs e)
        {
            PopulateWarehouseMaster();
        }

        private void ClearField()
        {
            txt_WarehouseMaster_WarehouseId.Text = "";
            txt_WarehouseMaster_WarehouseName.Text= "";
            txt_WarehouseMaster_WarehouseEmpID.Text = "";
            cob_WarehouseMaster_WarehouseSalesman.Text = "";
          
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_WarehouseMaster_WarehouseId.Text = GV_WarehouseMaster.CurrentRow.Cells["clmWarehouseId"].Value.ToString();
            txt_WarehouseMaster_WarehouseName.Text = GV_WarehouseMaster.CurrentRow.Cells["clmWarehouseName"].Value.ToString();
            cob_WarehouseMaster_WarehouseSalesman.Text = GV_WarehouseMaster.CurrentRow.Cells["clmSalesman"].Value.ToString();
            txt_WarehouseMaster_WarehouseEmpID.Text = GV_WarehouseMaster.CurrentRow.Cells["clmEmpId"].Value.ToString();
            ActionFlag = 2;
            btn_WarehouseMaster_Save.Enabled = true;
            btn_WarehouseMaster_New.Enabled = true;
            btn_WarehouseMaster_Delete.Enabled = true;
            btn_WarehouseMaster_Close.Visible = false;
            btn_WarehouseMaster_Cancel.Visible = true;
            btn_WarehouseMaster_Edit.Enabled = false;


        }

        private void cob_WarehouseMaster_WarehouseSalesman_SelectedIndexChanged(object sender, EventArgs e)
        {
            var salesmanempID = Warehouse.Get()
                           .Where(x => x.Salesman.ToLower().Contains(cob_WarehouseMaster_WarehouseSalesman.Text.ToLower())).ToList();
            txt_WarehouseMaster_WarehouseEmpID.Text = salesmanempID[0].EmpID.ToString();
        }
    }
}
