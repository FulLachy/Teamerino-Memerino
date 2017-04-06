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
        FormEditRecord form_add_record = new FormEditRecord();
        FormEdit

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
            FormEditRecord.Show();
        }

        private void button_edit_record_Click(object sender, EventArgs e)
        {
            
        }

        private void FormSales_Load(object sender, EventArgs e)
        {

        }
    }
}
