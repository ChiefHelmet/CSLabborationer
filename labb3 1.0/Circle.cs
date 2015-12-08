using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._0
{
    public class Circle
    {
        private double diameter;
        private Point point;
        

        public double GetDiameter()
        {
            return diameter;
        }
        public void SetDiameter(double diameter)
        {
            if(!double.IsNaN(diameter))
            this.diameter = diameter;
        }
        public double GetCircumference()
        {
            return diameter * Math.PI;
        }
        public void SetCenter(Point point)
        {
            this.point = point;
        }
        public Point GetCenter()
        {
            return point;
        }
    }
}
