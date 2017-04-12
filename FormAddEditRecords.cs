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
        public FormAddSalesRecord()
        {
            InitializeComponent();
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
            if (DGV_AddEditSales.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to Save");
            }

            //Checks for each quantity if its an integer higher than 0
            else
            {
                bool success = true;

                foreach (DataGridViewRow row in DGV_AddEditSales.Rows)
                {
                    int value = 0;
                    if (int.TryParse(row.Cells[2].Value.ToString(), out value))
                    {
                        if (value <= 0)
                        {
                            MessageBox.Show("One of the quantity levels is lower than 0");
                            row.Selected = true;
                            success = false;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("One of the quantity levels is not a number.");
                        row.Selected = true;
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    Database.Instance.AddRecord(DGV_AddEditSales);
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            //Clears information
            DGV_AddEditSales.Rows.Clear();
            Close();
        }

        private void FormEditRecord_Load(object sender, EventArgs e)
        {
            Database.Instance.BindInventoryToListBox(listBox_items);
            if (DGV_AddEditSales.ColumnCount == 0)
            {
                DGV_AddEditSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DGV_AddEditSales.Columns.Add("Barcode", "Barcode");
                DGV_AddEditSales.Columns.Add("ItemName", "Item Name");
                DGV_AddEditSales.Columns.Add("Quantity", "Quantity");

                DGV_AddEditSales.ReadOnly = false;

                for (int i = 0; i < DGV_AddEditSales.ColumnCount; i++)
                {
                    if (DGV_AddEditSales.Columns[i].HeaderText != "Quantity")
                    {
                        DGV_AddEditSales.Columns[i].ReadOnly = true;
                    }
                }
            }
        }

        private void button_move_item_Click(object sender, EventArgs e)
        {
            InventoryStruct theItem = (InventoryStruct)listBox_items.SelectedItem;
            bool found = false;

            //Attempts to find the item in the current stock table
            foreach (DataGridViewRow row in DGV_AddEditSales.Rows)
            {
                if (row.Cells[0].Value.Equals(theItem.Barcode))
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }

            //If the item is not in the stock table then it adds the item
            if (!found)
            {
                DGV_AddEditSales.Rows.Add(theItem.Barcode, theItem.ItemName, "0");
            }
        }

        private void comboBox_item_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.DGV_AddEditSales.SelectedRows)
            {
                DGV_AddEditSales.Rows.RemoveAt(item.Index);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //Search code goes here
        }
    }
}