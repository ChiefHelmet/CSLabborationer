using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb2_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //namn

            double dowJones = -0.046;
            double nasdaq = -0.041;
            double stockholm = -0.024;
            double milano = -0.067;
            double paris = -0.055;

            Console.WriteLine($"Dow Jones {dowJones:p} och Nasdaq {nasdaq:p}. Stockholm {stockholm:p}, Milano {milano:p}, Paris {paris:p}");

            #region
            //string stockRegion01 = "Dow Jones";
            //string stockRegion02 = "Nasdaq";
            //string stockRegion03 = "Stockholm";
            //string stockRegion04 = "Milano";
            //string stockRegion05 = "Paris";
            //double stockShift01 = 4.6;
            //double stockShift02 = 4.1;
            //double stockShift03 = -2.4;
            //double stockShift04 = -6.7;
            //double stockShift05 = -5.5;

            //Console.WriteLine(stockRegion01 + " sjönk med " + stockShift01 + " procent och " + stockRegion02 + " med " + stockShift02 + " procent. " + stockRegion03 + " " + stockShift03 + " procent, " + stockRegion04 + " " + stockShift04 + " procent, " + stockRegion05 + " " + stockShift05 + " procent. \r\n");

            //Console.WriteLine($"{stockRegion01} sjönk med {stockShift01} procent och {stockRegion02} med {stockShift02} procent. {stockRegion03} {stockShift03} procent, {stockRegion04} {stockShift04} procent, {stockRegion05} {stockShift05} procent. \r\n");

            //Console.WriteLine("{0} sjönk med {1} procent och {2} med {3} procent. {4} {5} procent, {6} {7} procent, {8} {9} procent. \r\n", stockRegion01, stockShift01, stockRegion02, stockShift02, stockRegion03, stockShift03, stockRegion04, stockShift04, stockRegion05, stockShift05);

            //Console.WriteLine("{0} sjönk med {5} procent och {1} med {6} procent. {2} {7} procent, {3} {8} procent, {4} {9} procent. \r\n", stockRegion01, stockRegion02, stockRegion03, stockRegion04, stockRegion05, stockShift01, stockShift02, stockShift03, stockShift04, stockShift05);
            #endregion

            //konstant

            const double PI = Math.PI;

            Console.WriteLine("Talet π är cirka {0} men kan anrundas till {1:f2} och kan lite grovt skrivas som {2:f0}.\r\n", PI, PI, PI);

            #region
            //Console.WriteLine("Talet π är cirka " + Math.Round(Math.PI,9) + " men kan anrundas till " + Math.Round(Math.PI,2) + " och kan lite grovt skrivas som " + Math.Round(Math.PI) + ".\r\n");
            #endregion


            string jonasName = "Jonas";
            string jonasHomeTown = "Helsingborg";
            string jonasHomeTurf = "Stattena";
            string jonasFavouriteStore = "Hemköp";

            Console.WriteLine($"Han heter {jonasName} och bor i {jonasHomeTown} på {jonasHomeTurf} vid {jonasFavouriteStore}. \r\n");

            Console.WriteLine("Han heter {0} och bor i {1} på {2} vid {3}.\r\n", "Jonas", jonasHomeTown, jonasHomeTurf, "Hemköp");
        }
    }
}
