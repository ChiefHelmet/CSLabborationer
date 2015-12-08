using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class StockItem
    {
        private int _id;
        private string _name;
        private int _stockCount;

        internal int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        internal string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        internal int StockCount
        {
            get
            {
                return _stockCount;
            }

            set
            {
                _stockCount = value;
            }
        }

        internal StockItem()
        {

        }

        public override string ToString()
        {
            return $"ID: {Id}\r\nName: {Name}\r\nStockCount: {StockCount}\r\n";
        }
    }
}
