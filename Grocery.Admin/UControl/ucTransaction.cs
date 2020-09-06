using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery.Admin.UControl
{
    public partial class ucTransaction : UserControl
    {
        public ucTransaction()
        {
            InitializeComponent();
        }
        public void Enable_Disable(string action)
        {

            if (action == "Default")
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
                btnPrint.Enabled = false;
                btnCancel.Enabled = false;
                btnClose.Enabled = true;
            }
            else if (action == "Add")
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnView.Enabled = false;
                btnPrint.Enabled = true;
                btnCancel.Enabled = true;
                btnClose.Enabled = false;
            }
            else if (action == "Edit")
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnView.Enabled = false;
                btnPrint.Enabled = true;
                btnCancel.Enabled = true;
                btnClose.Enabled = false;
            }
            else if (action == "Save")
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
                btnPrint.Enabled = false;
                btnCancel.Enabled = false;
                btnClose.Enabled = true;
            }
            else if (action == "Delete")
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
                btnPrint.Enabled = false;
                btnCancel.Enabled = false;
                btnClose.Enabled = true;
            }
            else if (action == "View")
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnView.Enabled = false;
                btnPrint.Enabled = false;
                btnCancel.Enabled = true;
                btnClose.Enabled = true;
            }
            else if (action == "Print")
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
                btnPrint.Enabled = false;
                btnCancel.Enabled = false;
                btnClose.Enabled = true;
            }
            else if (action == "Cancel")
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
                btnPrint.Enabled = false;
                btnCancel.Enabled = false;
                btnClose.Enabled = true;
            }
            else if (action == "Close")
            { }
        }
    }
}
