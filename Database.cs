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

        //Load item and record
        private Database()
        {
            itemlistBinding.DataSource = typeof(InventoryStruct);
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

        public void EditItem()
        {

        }

        public void AddRecord()
        {

        }

        public void RemoveRecord()
        {

        }

        public void EditRecord()
        {

        }

        public void WriteToFile()
        {

        }
    }
}
