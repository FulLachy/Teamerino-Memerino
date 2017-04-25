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

        private Database()
        {
            itemlistBinding.DataSource = typeof(InventoryItem);
            recordlistBinding.DataSource = typeof(SalesRecord);

            LoadItems();
            LoadRecords();

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            WriteItems();
            WriteRecords();
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
                recordlistBinding.Remove(found);
            }
            AddRecord(record);
        }

        //This method finds a item using a given barcode
        public InventoryItem FindItemByBarcorde(int barcode)
        {
            InventoryItem theItem = itemlist.Find(x => x.Barcode == barcode);
            return theItem;
        }

        private void LoadItems()
        {
            List<string[]> rows = System.IO.File.ReadAllLines("...//...//Resources//Items//inventory.txt").Select(x => x.Split(',')).ToList();
            if (rows.Count <= 1) return;
            rows.ForEach(x => {
                InventoryItem loadItem = new InventoryItem(x);
                AddItem(loadItem);
            });
        }

        private void LoadRecords()
        {
            List<string[]> rows = System.IO.File.ReadAllLines("...//...//Resources//Records//sales.txt").Select(x => x.Split(',')).ToList();
            if (rows.Count <= 1) return;
            rows.ForEach(x => {
                SalesRecord loadRecord = new SalesRecord(x);
                AddRecord(loadRecord);
            });
        }

        private void WriteRecords()
        {
            List<string> saveText = new List<string>();
            foreach (SalesRecord record in recordlist)
                saveText.Add(record.ToCSV());
            System.IO.File.WriteAllLines("...//...//Resources//Records//sales.txt", saveText);
        }

        private void WriteItems()
        {
            List<string> saveText = new List<string>();
            foreach(InventoryItem item in itemlist)
                saveText.Add(item.ToCSV());
            System.IO.File.WriteAllLines("...//...//Resources//Items//inventory.txt", saveText);
        }
    }
}
