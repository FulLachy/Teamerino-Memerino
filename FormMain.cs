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
    public partial class FormMain : Form
    {
        FormSales form_sales = new FormSales();
        FormInventory form_inventory = new FormInventory();
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_sales_records_Click(object sender, EventArgs e)
        {
            form_sales.ShowDialog();
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            form_inventory.ShowDialog();
        }

        private void button_reports_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
