using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Teamerino_Memerino
{
    public class SalesRecordItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _barcode = new int();
        private int _quantity = new int();
        private double _pricePerItem = 0.0;

        public SalesRecordItem(int barcode, int quantity, double pricePerItem)
        {
            _barcode = barcode;
            _quantity = quantity;
            _pricePerItem = pricePerItem;
        }

        public SalesRecordItem Copy()
        {
            return (SalesRecordItem)MemberwiseClone();
        }

        public string ToCSV()
        {
            string result = _barcode.ToString() + ","
                          + _quantity.ToString() + ","
                          + _pricePerItem.ToString();
            return result;
        }

        public int Barcode
        {
            get
            {
                return _barcode;
            }
        }

        public string ItemName
        {
            get
            {
                InventoryItem invItem = Database.Instance.FindItemByBarcorde(_barcode);
                if (invItem == null)
                    return "#UNKOWN ITEM#";
                else
                    return invItem.ItemName;
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
                NotifyPropertyChanged();
                NotifyPropertyChanged("Price");
            }
        }

        public double Price
        {
            get
            {
                return _quantity * _pricePerItem;
            }
        }
    }
}
