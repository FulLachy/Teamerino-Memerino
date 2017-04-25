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
    public partial class FormAddSalesRecord : Form
    {
        private SalesRecord _recordToEdit;



        public FormAddSalesRecord()
        {
            InitializeComponent();
            txt_Search.ForeColor = SystemColors.GrayText;
            txt_Search.Text = "Search Here...";
            txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Text.Length == 0)
            {
                txt_Search.ForeColor = SystemColors.GrayText;
                txt_Search.Text = "Search Here...";
            }
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search Here...")
            {
                txt_Search.Text = "";
                txt_Search.ForeColor = SystemColors.WindowText;
            }
        }

        private void FormAddEditRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //The record does not save if no items have been added to the record
            if (DGV_AddEditSales.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to Save");
            }
            else
            {
                Database.Instance.AddOrEditRecord(_recordToEdit);
                Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEditRecord_Load(object sender, EventArgs e)
        {
            Database.Instance.BindInventoryToListBox(listBox_items);
        }

        private void button_move_item_Click(object sender, EventArgs e)
        {
            InventoryItem invItem = (InventoryItem)listBox_items.SelectedItem;
            if (invItem == null) return;
            SalesRecordItem salesItem = _recordToEdit.Items.Find(x => x.Barcode == invItem.Barcode);

            //If the item is not in the stock table then it adds the item
            if (salesItem != null)
            {
                salesItem.Quantity += 1;
            }
            else
            {
                _recordToEdit.AddItem(new SalesRecordItem(invItem.Barcode, 1, invItem.PricePerUnit));
            }
        }

        private void comboBox_item_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            SalesRecordItem salesItem = DGV_AddEditSales.CurrentRow.DataBoundItem as SalesRecordItem;
            if (salesItem != null)
                _recordToEdit.RemoveItem(salesItem);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            BindingSource tempSource = new BindingSource();
            tempSource.DataSource = typeof(InventoryItem);

            //Only items that have the same name in the text box will be shown
            if (txt_Search.Text != "Search Here...")
            {
                foreach (InventoryItem item in Database.Instance.ShowItem())
                {
                    if (item.ItemName.Contains(txt_Search.Text))
                    {
                        tempSource.Add(item);
                    }
                }

                listBox_items.DataSource = tempSource;
            }
        }

        public SalesRecord RecordToEdit
        {
            get
            {
                return _recordToEdit;
            }
            set
            {
                _recordToEdit = value;
                _recordToEdit.bindItemsToDGV(DGV_AddEditSales);
            }
        }

        private void invalidate_cell(DataGridView dgv, DataGridViewCell cell, DataGridViewCellValidatingEventArgs e, String message)
        {
            cell.Value = cell.Value;
            e.Cancel = true;
            ((DataGridView)dgv).Rows[e.RowIndex].ErrorText = message;
            MessageBox.Show(message);
        }

        private void DGV_AddEditSales_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dgv = ((DataGridView)sender);
            string header = dgv.Columns[e.ColumnIndex].HeaderText;
            var cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
            try
            {
                if (header.Equals("Quantity"))
                {
                    var c0 = 0;
                    if (e.FormattedValue == null || !int.TryParse(e.FormattedValue.ToString(), out c0))
                        invalidate_cell(dgv, cell, e, header + " Must Be an Integer");
                    else if (c0 <= 0)
                        invalidate_cell(dgv, cell, e, header + " Must Be Positive");
                }
            }
            catch
            {
                invalidate_cell(dgv, cell, e, header + " Unhandled error");
            }
        }

        private void DGV_AddEditSales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ((DataGridView)sender).Rows[e.RowIndex].ErrorText = String.Empty;
        }
    }
}