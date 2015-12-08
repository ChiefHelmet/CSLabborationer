using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class EcoStockItem : StockItem
    {
        private string _marking;

        public string Marking
        {
            get
            {
                return _marking;
            }

            set
            {
                if (value.ToLower() == "krav" || value.ToLower() == "eg")
                {
                    _marking = value;
                }
                else
                {
                    throw new Exception($"{value} is invalid marking");
                }
            }
        }

        internal EcoStockItem()
        {

        }

        public override string ToString()
        {
            return $"Marking: {Marking}\r\n" + base.ToString();
        }
    }
}
