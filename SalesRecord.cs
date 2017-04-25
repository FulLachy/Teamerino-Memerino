using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamerino_Memerino
{
    public class SalesRecord
    {
        static private int _nextRecordNumber;

        private int _recnum;
        private DateTime _datetime;
        private List<SalesRecordItem> _items = new List<SalesRecordItem>();
        private BindingSource _itemlistBinding = new BindingSource();

        public SalesRecord(int recordNumber = -1)
        {
            if (recordNumber == -1)
            {
                _recnum = _nextRecordNumber++;
            }
            else
            {
                _recnum = recordNumber;
                if (recordNumber >= _nextRecordNumber)
                {
                    _nextRecordNumber = recordNumber + 1;
                }
            }
            _datetime = DateTime.UtcNow;
            _itemlistBinding.DataSource = typeof(SalesRecordItem);
        }

        public SalesRecord Copy()
        {
            SalesRecord result = new SalesRecord(_recnum);
            result._datetime = _datetime;
            foreach (SalesRecordItem item in _items)
            {
                result.AddItem(item.Copy());
            }
            return result;
        }

        public int RecordNum
        {
            get
            {
                return _recnum;
            }
            set
            {
                _recnum = value;
            }
        }

        public double Price
        {
            get
            {
                double result = 0.0;
                foreach (SalesRecordItem saleItem in _items)
                {
                    result += saleItem.Price;
                }
                return result;
            }
        }

        public string Time
        {
            get
            {
                return _datetime.ToLocalTime().ToString("h:mm:ss");
            }
        }
        public string Date
        {
            get
            {
                return _datetime.ToLocalTime().ToString("d");
            }
        }

        public void AddItem(SalesRecordItem item)
        {
            _items.Add(item);
            _itemlistBinding.Add(item);
        }

        public void RemoveItem(SalesRecordItem item)
        {
            _items.Add(item);
            _itemlistBinding.Remove(item);
        }

        public List<SalesRecordItem> Items
        {
            get
            {
                return _items;
            }
        }

        public void bindItemsToDGV(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = true;
            dgv.DataSource = _itemlistBinding;
        }

    }

   
}
