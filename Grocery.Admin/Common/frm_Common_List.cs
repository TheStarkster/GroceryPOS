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
    public partial class frm_Common_List : Form
    {
        public string Parameter;
        public DataTable ODataTable;
        public int formWidth ;

        public frm_Common_List()
        {
            InitializeComponent();
        }

        private void frm_Common_List_Load(object sender, EventArgs e)
        {
            dgv_list.DataSource = ODataTable;
            txt_KeyWord.Focus();

            if (formWidth > 0) { this.Width = formWidth; }

            if (ODataTable.Rows.Count > 0)
            {
                dgv_list.AllowUserToResizeColumns = true;
                dgv_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_list.Columns[0].Resizable = DataGridViewTriState.True;
            }
            
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView firstView = new DataView(ODataTable);
                firstView.RowFilter = "Convert([" + dgv_list.Columns[0].Name + "], System.String)" + "  like '*" + txt_KeyWord.Text + "*'";
                dgv_list.DataSource = firstView;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, GolobalItems.MessageCaption); }
        }

        private void txt_KeyWord_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    dgv_list.Focus();
                    dgv_list.CurrentRow.Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setSelectedData()
        {
            GolobalItems.glbListItem.Items.Clear();
            foreach (DataGridViewCell cell in dgv_list.CurrentRow.Cells)
            {
                GolobalItems.glbListItem.Items.Add(cell.Value);
            }
        }

       
        private void dgv_list_DoubleClick(object sender, EventArgs e)
        {
            setSelectedData();
        }

        private void dgv_list_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    setSelectedData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GolobalItems.MessageCaption);
            }
        }

        private void dgv_list_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
            }
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
