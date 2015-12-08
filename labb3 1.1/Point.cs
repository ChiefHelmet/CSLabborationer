using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._1
{
    public class Point
    {
        private int xCoordinate;
        private int yCoordinate;

        public void SetXCoordinate(int thisSetsTheXCoordinate)
        {
            xCoordinate = thisSetsTheXCoordinate;
        }
        public int GetXCoordinate()
        {
            return xCoordinate;
        }
        public void SetYCoordinate(int thisSetsTheYCoordinate)
        {
            yCoordinate = thisSetsTheYCoordinate;
        }
        public int GetYCoordinate()
        {
            return yCoordinate;
        }
    }
}
