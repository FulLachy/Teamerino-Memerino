using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamerino_Memerino
{
    class InventoryStruct
    {
        private int _barcode;
        private string _itemname;
        private int _stock;
        private int _lowstock;
        private double _price;

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
    }
}
