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

        private List<InventoryItem> itemlist = new List<InventoryItem>();
        private List<SalesRecord> recordlist = new List<SalesRecord>();

        private BindingSource itemlistBinding = new BindingSource();
        private BindingSource recordlistBinding = new BindingSource();     

        //Load item and record
        private Database()
        {
            itemlistBinding.DataSource = typeof(InventoryItem);
            recordlistBinding.DataSource = typeof(SalesRecord);
        }

        public List<InventoryItem> ShowItem()
        {
            return itemlist;
        }

        public List<SalesRecord> ShowRecord()
        {
            return recordlist;
        }

        public void AddItem(InventoryItem item)
        {
            itemlist.Add(item);
            itemlistBinding.Add(item);
        }

        public void RemoveItem(InventoryItem item)
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

        /*public void AddRecord(DataGridView dgv)
        {
            SalesStruct Record = new SalesStruct();

            //Sets the sales record information
            Record.RecordNum = recordlist.Count + 1;
            Record.Time = DateTime.Now.ToString("h:mm:ss");
            Record.Date = DateTime.Today.ToString("d");
            Record.Price = 0.00;

            //Sets the item quantity information
            foreach (DataGridViewRow row in dgv.Rows)
            {
                InventoryStruct theItem = FindItemByBarcorde(int.Parse(row.Cells[0].Value.ToString()));
                Record.Price += theItem.PricePerUnit * int.Parse(row.Cells[2].Value.ToString());

                //Creates the item stock and adds it to the sales record
                SalesStockStruct tempStock = new SalesStockStruct();
                tempStock.Barcode = (int)row.Cells[0].Value;
                tempStock.Quantity = int.Parse(row.Cells[2].Value.ToString());
                Record.ItemQuantity.Add(tempStock);

                //Sets the quantity of the item accordingly
                theItem.Stock -= tempStock.Quantity;
                if (theItem.Stock < 0)
                {
                    MessageBox.Show("Warning: " + theItem.ItemName + " stock level has gone negative!");
                }
                else if (theItem.Stock < theItem.LowStockLevel)
                {
                    MessageBox.Show("Warning: " + theItem.ItemName + " stock level is running low!");
                }
            }

            recordlist.Add(Record);
            recordlistBinding.Add(Record);
        }*/

        public void AddRecord(SalesRecord record)
        {
            recordlist.Add(record);
            recordlistBinding.Add(record);
        }

        public void RemoveRecord()
        {

        }

        public void EditRecord(DataGridView dgv, SalesRecord recordToEdit)
        {
            //Increases the stock of each item that was in the sales record
            foreach (SalesRecordItem stockToIncrease in recordToEdit.Items)
            {
                InventoryItem theItem = FindItemByBarcorde(stockToIncrease.Barcode);
                theItem.Stock += stockToIncrease.Quantity;
            }

            recordToEdit.Items = new List<SalesRecordItem>();
            recordToEdit.Price = 0;

            //Adds in the new item stocks to the record
            foreach (DataGridViewRow row in dgv.Rows)
            {
                InventoryItem theItem = FindItemByBarcorde(int.Parse(row.Cells[0].Value.ToString()));
                recordToEdit.Price += theItem.PricePerUnit * int.Parse(row.Cells[2].Value.ToString());

                SalesRecordItem tempStock = new SalesRecordItem();
                tempStock.Barcode = (int)row.Cells[0].Value;
                tempStock.Quantity = int.Parse(row.Cells[2].Value.ToString());
                recordToEdit.Items.Add(tempStock);

                //Sets the quantity of the item accordingly
                theItem.Stock -= tempStock.Quantity;
                if (theItem.Stock < 0)
                {
                    MessageBox.Show("Warning: " + theItem.ItemName + " stock level has gone negative!");
                }
                else if (theItem.Stock < theItem.LowStockLevel)
                {
                    MessageBox.Show("Warning: " + theItem.ItemName + " stock level is running low!");
                }
            }
        }

        //This method finds a item using a given barcode
        private InventoryItem FindItemByBarcorde(int barcode)
        {
            InventoryItem theItem = new InventoryItem();

            foreach (InventoryItem i in itemlist)
            {
                if (i.Barcode == barcode)
                {
                    theItem = i;
                    break;
                }
            }

            return theItem;
        }
        public void LoadItems()
        {
            List<string[]> rows = System.IO.File.ReadAllLines("...//...//Resources//Items//inventory.txt").Select(x => x.Split(',')).ToList();
            rows.ForEach(x => {
                InventoryItem loadItem = new InventoryItem();
                int c = 0;
                double y = 0;
                Int32.TryParse(x[0], out c);
                loadItem.Barcode = c;
                loadItem.ItemName = x[1];
                Int32.TryParse(x[2], out c);
                loadItem.Stock = c;
                Int32.TryParse(x[3], out c);
                loadItem.LowStockLevel = c;
                double.TryParse(x[4], out y);
                loadItem.PricePerUnit = y;
                Database.Instance.AddItem(loadItem);
            });
        }
        public void LoadRecords()
        {
            List<string[]> rows = System.IO.File.ReadAllLines("...//...//Resources//Records//sales.txt").Select(x => x.Split(',')).ToList();
            rows.ForEach(x => {
                SalesRecord loadRecord = new SalesRecord();
                int c = 0;
                double y = 0;
                List<int> v = new List<int> { };
                Int32.TryParse(x[0], out c);
                loadRecord.RecordNum = c;
                Double.TryParse(x[1], out y);
                loadRecord.Price = y;
                loadRecord.Time = x[2];
                loadRecord.Date = x[3];
                //NeedQuantity
                for (int z = 4; z < x.Count<string>() - 1; z += 2)
                {
                    var item = new SalesRecordItem();
                    Int32.TryParse(x[z], out c);
                    item.Barcode = c;
                    Int32.TryParse(x[z + 1], out c);
                    item.Quantity = c;
                    loadRecord.Items.Add(item);
                }
                AddRecord(loadRecord);
            });
        }
        public void WriteSales()
        {
            string line = "";
            string[] saveText = new string[recordlist.Count];
            int c = 0;
           // System.IO.File.WriteAllText("...//...//Resources//Records//sales.txt", "");
            foreach (SalesRecord sale in recordlist)
            {
                int i = 0;
                line += sale.RecordNum.ToString();
                line += ",";
                line += sale.Price.ToString();
                line += ",";
                line += sale.Time.ToString();
                line += ",";
                line += sale.Date.ToString();
                line += ",";
                while (i < sale.Items.Count)
                {
                    line += sale.Items[i].Barcode.ToString();
                    line += ",";
                    line += sale.Items[i].Quantity.ToString();
                    line += ",";
                    i++;
                }
                line.TrimEnd(',');
                saveText[c] = line;
                line = "";
                c++;
            }
            System.IO.File.WriteAllLines("...//...//Resources//Records//sales.txt", saveText);
        }
        public void WriteItems(string path, DataGridView dgv)
        {
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgv.SelectAll();
            DataObject toSave = dgv.GetClipboardContent();
            System.IO.File.WriteAllText(path, toSave.GetText(TextDataFormat.CommaSeparatedValue));
        }
    }
}
