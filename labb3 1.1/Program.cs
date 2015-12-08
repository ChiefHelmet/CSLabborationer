using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person01 = new Person();
            //person01.SetName("Lårentz");
            //Console.WriteLine(person01.GetName());

            //Person person02 = new Person();
            //person02.SetName(Console.ReadLine());
            //Console.WriteLine(person02.GetName());
            
            Point point01 = new Point();
            point01.SetXCoordinate(25);
            point01.SetYCoordinate(30);
            Circle circle01 = new Circle();
            circle01.SetCenter(point01);
            circle01.SetDiameter(10);
            Console.WriteLine(circle01.GetCircumference() + " " + circle01.GetCenter().GetXCoordinate() + " " + circle01.GetCenter().GetYCoordinate());

            Console.WriteLine("\r\n\r\n");

            Adventurer spencer = new Adventurer();

            Weapon shipGradeWeapon01 = new Weapon();
            shipGradeWeapon01.SetConfiguration("2X ventral & dorsal quad blaster-cannons");
            shipGradeWeapon01.SetModel("Czerka Corp Panzerkampfvagen-kanonen");
            shipGradeWeapon01.SetEnergyOutput("Somethihng techy-sounding");
            
            Weapon blasterPistol01 = new Weapon();
            blasterPistol01.SetConfiguration("Blaster Pistol");
            blasterPistol01.SetModel("SoroSuub X-30 Lancer");
            blasterPistol01.SetEnergyOutput("Something techy-sounding");

            Spaceship lightFreighter01 = new Spaceship();
            lightFreighter01.SetShipModel("YT-2400 Corellian Light Freighter");
            lightFreighter01.SetMaxSpeed("2.5 lightspeed");
            lightFreighter01.SetCargoCapacity(85);
            lightFreighter01.SetShipWeapon(shipGradeWeapon01);

            spencer.SetName("Spencer Lombax");
            spencer.SetTitle("Space Smuggler");
            spencer.SetWeapon(blasterPistol01);
            spencer.SetSpaceship(lightFreighter01);

            Console.WriteLine();
        }
    }
}
