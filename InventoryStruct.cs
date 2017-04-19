using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamerino_Memerino
{
    public class InventoryStruct
    {
        private int _barcode     = 0;
        private string _itemname = "";
        private int _stock       = 0;
        private int _lowstock    = 0;
        private double _price    = 0.0;

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

        public double Price
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

        public override string ToString()
        {
            return ItemName;
        }
    }
}
