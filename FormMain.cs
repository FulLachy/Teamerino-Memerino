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
            SalesRecord newRecord = new SalesRecord();
            form_sales.RecordToEdit = newRecord;
            form_sales.ShowDialog();
        }

        private void button_edit_record_Click(object sender, EventArgs e)
        {
            //The record is passed over to the sales form
            if (dgv_main.CurrentRow != null)
            {
                SalesRecord record = Database.Instance.FindRecordByRecordNumber((dgv_main.CurrentRow.DataBoundItem as SalesRecord).RecordNum);
                form_sales.RecordToEdit = record.Copy();
                form_sales.ShowDialog();
            }
            //If there are no selected cells then the form will not show up
            else
            {
                MessageBox.Show("Please select a sales record.");
            }
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
