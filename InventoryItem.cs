using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamerino_Memerino
{
    public class InventoryItem
    {
        private int _barcode     = 0;
        private string _itemname = "";
        private int _stock       = 0;
        private int _lowstock    = 0;
        private double _price    = 0.0;
        private string _tag      = "";

        public InventoryItem()
        {

        }

        public InventoryItem(string[] x)
        {
            Int32.TryParse(x[0], out _barcode);
            _itemname = x[1];
            Int32.TryParse(x[2], out _stock);
            Int32.TryParse(x[3], out _lowstock);
            Double.TryParse(x[4], out _price);
            _tag = x[5];
        }

        public string ToCSV()
        {
            string result = _barcode.ToString() + ","
                          + _itemname.ToString() + ","
                          + _stock.ToString() + ","
                          + _lowstock.ToString() + ","
                          + _price.ToString() + ","
                          + _tag.ToString();
            return result;
        }

        public int Barcode
        {
            get
            {
                return _barcode;
            }
            set
            {
                _barcode = value;
            }

        }

        public string ItemName
        {
            get
            {
                return _itemname;
            }
            set
            {
                _itemname = value;
            }
        }
        
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }

        public int LowStockLevel
        {
            get
            {
                return _lowstock;
            }
            set
            {
                _lowstock = value;
            }
        }

        public double PricePerUnit
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public string Tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
            }
        }

        public override string ToString()
        {
            return ItemName;
        }
    }
}
