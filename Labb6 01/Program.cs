﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //float
            //long
            //char
            //string
            //unsigned long

            //float aFloat = 10.05f;
            //long aLong = -5000;
            //char aChat = 'D';
            //string aString = "Ze German";
            //ulong anUlong = 9000;

            //Point point = new Point3D(4,4,4);
            //{

            //}
            //Point3D point3D = new Point(); //  går inte

            Point pointToPoint3D = new Point();
            Point3D point3D = pointToPoint3D;

            Console.WriteLine(pointToPoint3D);
            Console.WriteLine(point3D);

            MyDoubleType myDoubleType = new MyDoubleType();
            myDoubleType.DoubleValue = 2000;
            Console.WriteLine(myDoubleType.DoubleValue);



            //Point3D point3DToPoint = new Point3D();
            //Point point = (Point)point3DToPoint; // Detta gick, däremot





        }
    }
}