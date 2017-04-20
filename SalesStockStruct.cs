using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamerino_Memerino
{
    public class SalesStockStruct
    {
        private int _barcode = new int();
        private int _quantity = new int();

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

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }
    }
}
