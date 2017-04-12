using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamerino_Memerino
{
    class SalesStockStruct
    {
        //The index crosses over, that is item with barcode[0] has quantity[0]
        private List<int> _barcode = new List<int>();
        private List<int> _quantity = new List<int>();

        public List<int> Barcode
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

        public List<int> Quantity
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
