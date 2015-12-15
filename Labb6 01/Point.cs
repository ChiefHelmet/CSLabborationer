using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_01
{
    class Point
    {
        private int x;
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        //Point ANewPoint3D = new Point3D(4,4,4);

        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static implicit operator Point3D(Point point)
        {
            return new Point3D(point.X, point.Y);
        }

        public override string ToString()
        {
            return $"X: {X}. Y: {Y}";
        }


        //public void SetX(int x)
        //{
        //    this.x = x;
        //}

        //public int GetX()
        //{
        //    return x;
        //}

        //public void SetY(int y)
        //{
        //    this.y = y;
        //}
        //public int GetY()
        //{
        //    return y;
        //}
    }
}
