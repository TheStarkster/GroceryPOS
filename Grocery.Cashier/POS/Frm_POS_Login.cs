using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grocery.BussinessLogic.Repositories;

namespace Grocery.Cashier.POS
{
    public partial class Frm_POS_Login : Form
    {
        CashierLogin login = new CashierLogin();
        DataTable userData;
        String password;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Frm_POS_Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            textBox1.PasswordChar = '\u25CF';
            do_Login();
        }
        public void do_Login()
        {
            DataTable branches = login.GetBranches();
            comboBox1.ValueMember = "branchid";
            comboBox1.DisplayMember = "branchname";
            comboBox1.DataSource = branches;
            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue != null)
            {
                DataTable users = login.GetUsers(comboBox1.SelectedValue.ToString());
                comboBox2.ValueMember = "id";
                comboBox2.DisplayMember = "username";
                comboBox2.DataSource = users;
                comboBox2.SelectedIndex = -1;

                userData = users;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userData != null && comboBox2.SelectedIndex != -1)
            {
                foreach (DataRow row in userData.Rows)
                {
                    if (row["id"].ToString() == comboBox2.SelectedValue.ToString())
                    {
                        password = row["passWord"].ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == password)
            {
                var CashierSystem = new Frm_POS_CashierSystem();
                CashierSystem.Show();
                this.Hide();
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Check Your Password", "Unauthorized");
            }
        }
    }
}
