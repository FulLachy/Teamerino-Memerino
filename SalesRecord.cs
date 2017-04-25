using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamerino_Memerino
{
    public class SalesRecord : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
                    _nextRecordNumber = recordNumber + 1;
            }
            _datetime = DateTime.UtcNow;
            _itemlistBinding.DataSource = typeof(SalesRecordItem);
        }

        public SalesRecord(string[] x)
        {
            Int32.TryParse(x[0], out _recnum);
            if (_recnum >= _nextRecordNumber)
                _nextRecordNumber = _recnum + 1;

            Int64 datetimeticks;
            Int64.TryParse(x[1], out datetimeticks);
            _datetime = new DateTime(datetimeticks);

            for (int z = 2; z < x.Count<string>() - 2; z += 3)
            {
                int Barcode;
                Int32.TryParse(x[z], out Barcode);
                int Quantity;
                Int32.TryParse(x[z + 1], out Quantity);
                double PricePerItem;
                Double.TryParse(x[z + 2], out PricePerItem);
                var item = new SalesRecordItem(Barcode, Quantity, PricePerItem);
                AddItem(item);
            }
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

        public string ToCSV()
        {
            string result = _recnum.ToString() + ","
                          + _datetime.Ticks.ToString();
            foreach (SalesRecordItem salesItem in _items)
                result += "," + salesItem.ToCSV();
            return result;
        }

        public int RecordNum
        {
            get
            {
                return _recnum;
            }
        }

        public double Price
        {
            get
            {
                double result = 0.0;
                foreach (SalesRecordItem saleItem in _items)
                    result += saleItem.Price;
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
