using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery.Cashier.POS
{
    public partial class Frm_POS_SalesInvoice : Form
    {
        public Frm_POS_SalesInvoice()
        {
            InitializeComponent();
        }

        private void Frm_POS_SalesInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            var CashierSystem = new Frm_POS_CashierSystem();
            CashierSystem.Show();
        }
    }
}
