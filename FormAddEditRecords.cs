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
        private SalesStruct _recordToEdit;



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

            //Checks for each quantity if its an integer higher than 0
            else
            {
                bool success = true;

                foreach (DataGridViewRow row in DGV_AddEditSales.Rows)
                {
                    int value = 0;
                    //The program attempts to convert the value into an integer
                    if (int.TryParse(row.Cells[2].Value.ToString(), out value))
                    {
                        //The record will not be saved if the value is less or equal to 0
                        if (value <= 0)
                        {
                            MessageBox.Show("One of the quantity levels is lower than 0");
                            row.Selected = true;
                            success = false;
                            break;
                        }
                    }
                    //If the attempt failed, the record will not be saved
                    else
                    {
                        MessageBox.Show("One of the quantity levels is not a number.");
                        row.Selected = true;
                        success = false;
                        break;
                    }
                }

                //if all of the items have passed validation, the record will be saved
                if (success)
                {
                    if (RecordToEdit == null)
                    {
                        Database.Instance.AddRecord(new SalesStruct());
                    }
                    else
                    {
                        Database.Instance.EditRecord(DGV_AddEditSales, RecordToEdit);
                    }
                    Database.Instance.WriteSales();
                    DGV_AddEditSales.Rows.Clear();
                    Close();
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void FormEditRecord_Load(object sender, EventArgs e)
        {
            Database.Instance.BindInventoryToListBox(listBox_items);
            //This if statement will only execute the first time the form loads
            //It will add the columns necessary to the table
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

            if (_recordToEdit != null)
            {
                List<SalesStockStruct> itemStock = _recordToEdit.Item;
                for (int i = 0; i < itemStock.Count; i++)
                {
                    InventoryStruct item = Database.Instance.ShowItem().Find(x => x.Barcode == itemStock[i].Barcode);
                    DGV_AddEditSales.Rows.Add(item.Barcode, item.ItemName, itemStock[i].Quantity);
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
            if (!found && theItem != null)
            {
                DGV_AddEditSales.Rows.Add(theItem.Barcode, theItem.ItemName, "0");
            }
        }

        private void comboBox_item_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            //Removes the selected items
            foreach (DataGridViewRow item in DGV_AddEditSales.SelectedRows)
            {
                DGV_AddEditSales.Rows.RemoveAt(item.Index);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            BindingSource tempSource = new BindingSource();
            tempSource.DataSource = typeof(InventoryStruct);

            //Only items that have the same name in the text box will be shown
            if (txt_Search.Text != "Search Here...")
            {
                foreach (InventoryStruct item in Database.Instance.ShowItem())
                {
                    if (item.ItemName.Contains(txt_Search.Text))
                    {
                        tempSource.Add(item);
                    }
                }

                listBox_items.DataSource = tempSource;
            }
        }

        public SalesStruct RecordToEdit
        {
            get
            {
                return _recordToEdit;
            }
            set
            {
                _recordToEdit = value;
            }
        }
    }
}