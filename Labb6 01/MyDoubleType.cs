using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_01
{
    class MyDoubleType
    {
        public double DoubleValue { get; set; } // för när man inte behöver validera. Om vi vill validera, använd den nedanför

        // public TYPE Type { get; set; } // <- prop

        //    private double doubleValue; // <- propfull

        //    public double DoubleValue
        //    {
        //        get { return doubleValue; }
        //        set { doubleValue = value; }
        //    }

        
        
        //public static MyDoubleType operator +()
        
        
        

        public override string ToString()
        {
            return DoubleValue.ToString();
            //return base.ToString();
        }
    }
}
