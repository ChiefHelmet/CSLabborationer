using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_01
{
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {
            
        }
        
        public Point3D(int x, int y, int z = 0)// : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public static explicit operator Point(Point3D point)
        {
            return new Point(point.X, point.Y);
        }
        public override string ToString()
        {
            return $"{base.ToString()}. Z: {Z}";
        }

        //public void SetZ(int z)
        //{
        //    this.z = z;
        //}
        //public int GetZ()
        //{
        //    return z;
        //}
    }
}
