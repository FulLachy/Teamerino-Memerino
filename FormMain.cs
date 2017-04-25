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
        FormAddSalesRecord form_sales = new FormAddSalesRecord();
        FormInventory form_inventory = new FormInventory();
        public FormMain()
        {
            InitializeComponent();
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
            Database.Instance.BindSalesToDVG(dgv_main);
            dgv_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_main.AutoResizeColumns();
            Database.Instance.LoadItems();
            Database.Instance.LoadRecords();
        }

        private void button_add_record_Click(object sender, EventArgs e)
        {
            form_sales.RecordToEdit = null;
            form_sales.ShowDialog();
        }

        private void button_edit_record_Click(object sender, EventArgs e)
        {
            //The record is passed over to the sales form
            if (dgv_main.SelectedCells.Count != 0)
            {
                DataGridViewRow theRow = dgv_main.Rows[dgv_main.SelectedCells[0].RowIndex];
                List<SalesStruct> theRecords = Database.Instance.ShowRecord();
                form_sales.RecordToEdit = theRecords.Find(x => x.RecordNum == (int)theRow.Cells[0].Value);
                form_sales.ShowDialog();
            }
            //If there are no selected cells then the form will not show up
            else
            {
                MessageBox.Show("Please select a sales record.");
            }
        }
    }
}
