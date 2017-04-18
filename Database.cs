using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamerino_Memerino
{
    class Database
    {
        static private Database instance = new Database();
        static public Database Instance { get { return instance; } }

        private List<InventoryStruct> itemlist = new List<InventoryStruct>();
        private List<SalesStruct> recordlist = new List<SalesStruct>();

        private BindingSource itemlistBinding = new BindingSource();
        private BindingSource recordlistBinding = new BindingSource();     

        //Load item and record
        private Database()
        {
            itemlistBinding.DataSource = typeof(InventoryStruct);
            recordlistBinding.DataSource = typeof(SalesStruct);
        }

        public List<InventoryStruct> ShowItem()
        {
            return itemlist;
        }

        public List<SalesStruct> ShowRecord()
        {
            return recordlist;
        }

        public void AddItem(InventoryStruct item)
        {
            itemlist.Add(item);
            itemlistBinding.Add(item);
        }

        public void RemoveItem(InventoryStruct item)
        {
            itemlist.Remove(item);
            itemlistBinding.Remove(item);
        }

        public void BindInventoryToDVG(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = true;
            dgv.DataSource = itemlistBinding;
        }

        public void BindInventoryToListBox(ListBox list)
        {
            list.DataSource = itemlistBinding;
        }

        public void BindSalesToDVG(DataGridView dgv)
        {
            dgv.DataSource = recordlistBinding;
        }

        public void EditItem()
        {

        }

        public void AddRecord(DataGridView dgv)
        {
            SalesStruct Record = new SalesStruct();

            Record.RecordNum = recordlist.Count + 1;
            Record.Time = DateTime.Now.ToString("h:mm:ss");
            Record.Date = DateTime.Today.ToString("d");
            Record.Price = 0.00;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                InventoryStruct theItem = new InventoryStruct();

                foreach (InventoryStruct i in itemlist)
                {
                    if (i.Barcode == int.Parse(row.Cells[0].Value.ToString()))
                    {
                        theItem = i;
                        break;
                    }
                }

                Record.Price += theItem.Price * int.Parse(row.Cells[2].Value.ToString());
                Record.ItemQuantity.Barcode.Add((int)row.Cells[0].Value);
                Record.ItemQuantity.Quantity.Add(int.Parse(row.Cells[2].Value.ToString()));
            }

            recordlist.Add(Record);
            recordlistBinding.Add(Record);
        }

        public void RemoveRecord()
        {

        }

        public void EditRecord(DataGridView dgv, SalesStruct recordToEdit)
        {
            int index = recordlist.FindIndex(x => x == recordToEdit);
            SalesStruct newRecord = recordlist[index];

            newRecord.ItemQuantity = new SalesStockStruct();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                InventoryStruct theItem = new InventoryStruct();

                foreach (InventoryStruct i in itemlist)
                {
                    if (i.Barcode == int.Parse(row.Cells[0].Value.ToString()))
                    {
                        theItem = i;
                        break;
                    }
                }

                newRecord.Price += theItem.Price * int.Parse(row.Cells[2].Value.ToString());
                newRecord.ItemQuantity.Barcode.Add((int)row.Cells[0].Value);
                newRecord.ItemQuantity.Quantity.Add(int.Parse(row.Cells[2].Value.ToString()));
            }

            recordlistBinding[index] = newRecord;
            recordlist[index] = newRecord;
        }

        public void WriteToFile()
        {

        }
    }
}
