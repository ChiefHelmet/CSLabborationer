using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Person

            //Person person01 = new Person();
            //person01.SetName("Manfred Lejderhååsen");
            //Console.WriteLine(person01.GetName());

            //Person person02 = new Person();
            //person02.SetName("Nissemann Bengtzon");
            //Console.WriteLine(person02.GetName());

            //Person person03 = new Person();
            //person03.SetName("Lårentz Huttifnutt");
            //Console.WriteLine(person03.GetName());

            ////Person person04 = new Person();
            ////person04.SetName(Console.ReadLine());
            ////Console.WriteLine(person04.GetName());
            #endregion

            #region circle
            //Circle circle01 = new Circle();
            //circle01.SetDiameter(10);
            //Console.WriteLine(circle01.GetCircumference());

            //Circle circle02 = new Circle();
            //circle02.SetDiameter(25);
            //Console.WriteLine(circle02.GetCircumference());

            //Circle circle03 = new Circle();
            //circle03.SetDiameter(double.Parse(Console.ReadLine()));
            //Console.WriteLine(circle03.GetCircumference());
            #endregion

            Point point04 = new Point();
            point04.SetX(int.Parse(Console.ReadLine()));
            point04.SetY(int.Parse(Console.ReadLine()));
            Circle circle04 = new Circle();
            circle04.SetCenter(point04);
            string circleRepresentaion = circle04.GetCenter().GetX() + ", " + circle04.GetCenter().GetY();
            Console.WriteLine(circleRepresentaion);

        }
    }
}
