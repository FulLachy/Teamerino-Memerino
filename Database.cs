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

        public SalesRecord FindRecordByRecordNumber(int recordNum)
        {
            SalesRecord result = recordlist.Find(x => x.RecordNum == recordNum);
                return result;
        }

        public void EditItem()
        {

        }

        public void AddRecord(SalesRecord record)
        {
            recordlist.Add(record);
            recordlistBinding.Add(record);

            foreach (SalesRecordItem saleItem in record.Items)
            {
                InventoryItem invItem = FindItemByBarcorde(saleItem.Barcode);
                if (invItem != null)
                {
                    invItem.Stock -= saleItem.Quantity;
                    if (invItem.Stock < 0)
                    {
                        MessageBox.Show("Warning: " + invItem.ItemName + " stock level has gone negative!");
                    }
                    else if (invItem.Stock < invItem.LowStockLevel)
                    {
                        MessageBox.Show("Warning: " + invItem.ItemName + " stock level is running low!");
                    }
                }
            }
        }

        public void AddOrEditRecord(SalesRecord record)
        {
            SalesRecord found = recordlist.Find(x => x.RecordNum == record.RecordNum);
            if (found != null)
            {
                foreach (SalesRecordItem stockToIncrease in found.Items)
                {
                    InventoryItem theItem = FindItemByBarcorde(stockToIncrease.Barcode);
                    if (theItem != null)
                        theItem.Stock += stockToIncrease.Quantity;
                }

                recordlist.Remove(found);
            }
            AddRecord(record);
        }

        //This method finds a item using a given barcode
        public InventoryItem FindItemByBarcorde(int barcode)
        {
            InventoryItem theItem = itemlist.Find(x => x.Barcode == barcode);
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
                int c = 0;
                double y = 0;
                List<int> v = new List<int> { };
                Int32.TryParse(x[0], out c);
                int RecordNum = c;
                Double.TryParse(x[1], out y);
                // loadRecord.Price = y;
                // loadRecord.Time = x[2];
                // loadRecord.Date = x[3];
                //NeedQuantity
                SalesRecord loadRecord = new SalesRecord(RecordNum);

                for (int z = 4; z < x.Count<string>() - 2; z += 3)
                {
                    int Barcode;
                    Int32.TryParse(x[z], out Barcode);
                    int Quantity;
                    Int32.TryParse(x[z + 1], out Quantity);
                    int PricePerItem;
                    Int32.TryParse(x[z + 2], out PricePerItem);
                    var item = new SalesRecordItem(Barcode, Quantity, PricePerItem);
                    loadRecord.AddItem(item);
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
