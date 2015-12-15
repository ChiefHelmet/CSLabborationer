using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_01
{
    class MyDoubleType
    {
        private double doubleValue;

        public double DoubleValue
        {
            get
            {
                return doubleValue;

            }
            set { doubleValue = value; }
        }

        public MyDoubleType()
        {
            DoubleValue = 2000;
        }

        public MyDoubleType(double doubleD)
        {
            DoubleValue = doubleD;
        }

        public static MyDoubleType operator +(MyDoubleType myDoubleType, double doubleTrouble)
        {
            myDoubleType.DoubleValue += doubleTrouble;
            return myDoubleType;
        }
        public static MyDoubleType operator +(MyDoubleType myDoubleType, MyDoubleType doubleTrouble)
        {
            myDoubleType.DoubleValue += doubleTrouble.DoubleValue;
            return myDoubleType;
        }
        public static MyDoubleType operator -(MyDoubleType myDoubleType, double doubleTrouble)
        {
            var result = new MyDoubleType();
            result.DoubleValue = myDoubleType.DoubleValue - doubleTrouble;
            //myDoubleType.DoubleValue -= doubleTrouble;
            //return myDoubleType;
            return result;
        }
        public static MyDoubleType operator *(MyDoubleType myDoubleType, double doubleTrouble)
        {
            ////skapa en ny retur 
            //myDoubleType.DoubleValue = myDoubleType.DoubleValue * doubleTrouble;
            //return myDoubleType;

            return new MyDoubleType(myDoubleType.DoubleValue * doubleTrouble);
        }
        public static MyDoubleType operator /(MyDoubleType myDoubleType, double doubleTrouble)
        {
            myDoubleType.DoubleValue /= doubleTrouble;
            return myDoubleType;
        }
        public static bool operator ==(MyDoubleType myDoubleType, double doubleTrouble)
        {

            return myDoubleType.DoubleValue == doubleTrouble;
        }
        public static bool operator !=(MyDoubleType myDoubleType, double doubleTrouble)
        {

            return myDoubleType.DoubleValue != doubleTrouble;
        }

        //Varför måste != finnas bara för att == finns?
        public static bool operator <(MyDoubleType myDoubleType, double doubleTrouble)
        {

            return myDoubleType.DoubleValue < doubleTrouble;
        }

        public static bool operator >(MyDoubleType myDoubleType, double doubleTrouble)
        {

            return myDoubleType.DoubleValue > doubleTrouble;
        }
        // samma här
        public static bool operator <(MyDoubleType myDoubleType, MyDoubleType doubleTrouble)
        {

            return myDoubleType.DoubleValue < doubleTrouble.DoubleValue;
        }
        public static bool operator >(MyDoubleType myDoubleType, MyDoubleType doubleTrouble)
        {

            return myDoubleType.DoubleValue > doubleTrouble.DoubleValue;
        }



        public override string ToString()
        {
            return doubleValue.ToString();
        }
    }
}
