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
            Database.Instance.BindInventoryToDVG(DGV_Inv);
            DGV_Inv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Inv.AutoResizeColumns();
        }

        private void bt_Add_Inv_Click(object sender, EventArgs e)
        {
            Database.Instance.AddItem(new InventoryItem());
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (DGV_Inv.CurrentRow == null) return;
            var item = (InventoryItem)DGV_Inv.CurrentRow.DataBoundItem;
            var confirmation = MessageBox.Show("Are you sure you want to remove " + item.ItemName + " from database?", "Confirm Removal", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                Database.Instance.RemoveItem(item);
            }
        }

        private void invalidate_cell(DataGridView dgv, DataGridViewCell cell, DataGridViewCellValidatingEventArgs e, String message)
        {
            cell.Value = cell.Value;
            e.Cancel = true;
            ((DataGridView)dgv).Rows[e.RowIndex].ErrorText = message;
        }

        private void dgv_Cell_Validating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dgv = ((DataGridView)sender);
            string header = dgv.Columns[e.ColumnIndex].HeaderText;
            var cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
            try
            {
                if (header.Equals("Barcode") || header.Equals("Stock") || header.Equals("LowStockLevel"))
                {
                    var c0 = 0;
                    if (e.FormattedValue == null || !int.TryParse(e.FormattedValue.ToString(), out c0))
                        invalidate_cell(dgv, cell, e, header + " Must Be an Integer");
                    if (c0 < 0)
                        invalidate_cell(dgv, cell, e, header + " Must Be Positive");
                }
                else if (header.Equals("PricePerUnit"))
                {
                    double c0 = 0;
                    if (e.FormattedValue == null || !double.TryParse(e.FormattedValue.ToString(), out c0))
                        invalidate_cell(dgv, cell, e, header + " Must be a Number, don't include $ at the start");
                }
            }
            catch
            {
                invalidate_cell(dgv, cell, e, header + " Unhandled error");
            }
        }

        private void DGV_Inv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ((DataGridView)sender).Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGV_Inv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
