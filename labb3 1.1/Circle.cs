using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._1
{
    public class Circle
    {
        private double diameter;
        private Point center;

        public void SetDiameter(double thisSetsTheDiameter)
        {
            diameter = thisSetsTheDiameter;
        }
        public double GetDiameter()
        {
            return diameter;
        }
        public double GetCircumference()
        {
            return diameter * Math.PI;
        }
        public void SetCenter(Point thisSetsTheCoordinates)
        {
            center = thisSetsTheCoordinates;
        }
        public Point GetCenter()
        {
            return center;
        }
    }
}
