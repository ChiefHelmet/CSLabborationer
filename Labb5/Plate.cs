using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Plate:StockItem
    {
        private string _type;

        internal string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (value.ToLower() == "flat" || value.ToLower() == "deep")
                {
                    _type = value;
                }
                else { throw new Exception(string.Format("{0} is not a valid type.", value)); }
            }
        }

        internal Plate()
        {

        }

        public override string ToString()
        {
            return $"Type: {Type}\r\n" + base.ToString();
        }
    }
}
