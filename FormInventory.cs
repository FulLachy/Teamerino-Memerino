using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamerino_Memerino
{
    public partial class FormInventory : Form
    {
        FormAddEditInv add_edit_inv = new FormAddEditInv();

        public FormInventory()
        {
            InitializeComponent();
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            //load in information from text file??
        }

        private void bt_Remove_Inv_Click(object sender, EventArgs e)
        {
            //remove selected row
        }

        private void bt_Add_Inv_Click(object sender, EventArgs e)
        {
            add_edit_inv.Show();
        }

        private void bt_Edit_Inv_Click(object sender, EventArgs e)
        {
            add_edit_inv.Show();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
