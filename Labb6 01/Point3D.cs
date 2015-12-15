using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_01
{
    class Point3D
    {
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public Point3D()
        {
            
        }
        
        public Point3D(int x, int y, int z = 0)// : base(x, y)
        {
            //this.X = x;
            //this.Y = y;
            this.Z = z;
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
