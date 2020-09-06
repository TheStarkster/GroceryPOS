using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grocery.BussinessLogic;
using Grocery.BussinessLogic.Repositories;
using Grocery.DataAccess.Model;

namespace Grocery.Admin.Master
{
    public partial class frm_Master_BranchMaster : Form
    {
        UnitofWorkMaster MasterMenu;
        public frm_Master_BranchMaster()
        {
            MasterMenu = new UnitofWorkMaster();
            InitializeComponent();
        }

        private void Frm_Master_ItemBranch_Load(object sender, EventArgs e)
        {
            GV_BranchMaster.DataSource = MasterMenu.BranchMasters.GetBranch_MastersBy("1");
            
        }
    }
}
