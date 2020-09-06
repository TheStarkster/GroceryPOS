using Grocery.BussinessLogic.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery.Admin.Common
{
    public partial class frm_Common_View : Form
    {
        public string Parameter;
        DataTable dt = new DataTable();
        public frm_Common_View()
        {
            InitializeComponent();
        }

        private void frm_Common_View_Load(object sender, EventArgs e)
        {
            dt = CommonFunction.GetListView(Parameter);
            dgv_list.DataSource = dt;
            if (dt != null)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    cbox_SearchOn.Items.Add(col.ColumnName);
                }
                cbox_SearchOn.SelectedIndex = 0;
            }
        }


        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView firstView = new DataView(dt);
                firstView.RowFilter = "Convert([" + cbox_SearchOn.Text + "], System.String)" + "  like '*" + txt_KeyWord.Text + "*'";

                dgv_list.DataSource = firstView;
            }
            catch (Exception ex) { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            GolobalItems.UniqueId = dgv_list.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void dgv_list_DoubleClick(object sender, EventArgs e)
        {
            GolobalItems.UniqueId = dgv_list.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
