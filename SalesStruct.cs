using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamerino_Memerino
{
    class SalesStruct
    {
            
        private int _recnum;
        private double _price;
        private DateTime _date;
        private DateTime _time;

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
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return _time;
            }

            set
            {
                _time = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }

    }

   
}
