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
    public partial class FormSales : Form
    {
        FormAddEditRecord form_add_edit_record = new FormAddEditRecord();
        public FormSales()
        {
            InitializeComponent();
        }

        private void FormSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void button_new_sales_record_Click(object sender, EventArgs e)
        {
            form_add_edit_record.Show();
        }

        private void button_edit_record_Click(object sender, EventArgs e)
        {
            form_add_edit_record.Show();
        }
    }
}
