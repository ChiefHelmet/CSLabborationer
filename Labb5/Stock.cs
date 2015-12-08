using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Stock
    {
        private StockItem[] _stockItem = new StockItem[10];

        private StockItem this[int index]
        {
            get
            {
                if (index >= 0 && index < this._stockItem.Length)
                    return this._stockItem[index];
                else
                    throw new Exception($"Noooo. Getting index [{index}] is out of boundary.");
            }
            set
            {
                if (index >= 0 && index < this._stockItem.Length)
                    this._stockItem[index] = value;
                else
                    throw new Exception($"Noooo. Setting index [{index}] is out of boundary.");
            }
        }

        internal int Length { get { return this._stockItem.Length; } }
        internal int Count { get { return this._stockItem.Count(); } }

        internal Stock()
        {

        }

        internal bool AddÍtem(StockItem item)
        {
            try
            {
                int freeIndexPosition = -1;

                for (int i = 0; i < this._stockItem.Length; i++)
                {
                    if (this._stockItem[i] == null)
                    {
                        freeIndexPosition = i;
                        break;
                    }
                }

                if (freeIndexPosition == -1)
                    throw new Exception("Your shit doset fit.");
                else
                    this._stockItem[freeIndexPosition] = item;

                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }

        internal StockItem GetItem(int index)
        {
            return this[index];
        }

        public override string ToString()
        {
            //TODO: Implemnt.
            return base.ToString();
        }
    }
}
