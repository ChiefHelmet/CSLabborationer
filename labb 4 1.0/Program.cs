using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var car01 = new Bil();
            var car02 = new Bil("Wolksvagen", 4, "Flowery", "combi");
            var car03 = new Bil(numberOfGears: 6, brand: "DeLorean", configuration: "cupe", color: "Stainless Steel Grey");

            Console.WriteLine(car01);
            Console.WriteLine(car02);
            Console.WriteLine(car03);

            //Uppgift 1: OM man skriver något annat än 'combi' eller 'cupe' så kraschar programmet, men BARA om man har har en else med ett exception. Kommenterana ut 'else { throw new Exception(); }' så fungerar allting som vanligt.

           var radio01 = new Radio();
            var radio02 = new Radio(frequency: 139.71, powerOn: true, volume: 50);
            var radio03 = new Radio(volume: 14, frequency: 400);

            Radio radio04 = new Radio() { Frequency = 140.98, PowerOn = true, Volume = 3 };
            Radio radio05 = new Radio { Frequency = 141.38, PowerOn = false, Volume = 8 };
            //Object initialisers, notera att det är nu stora bokstäver innanför måsvingarna, till skillnad från tidigare när det vara små bokstäver innanför paranteserna. Sen saknas paranteserna på andra object initialiser, kolla med freddie om det gör ågon skillnad.

            Console.WriteLine(radio01);
            Console.WriteLine(radio02);
            Console.WriteLine(radio03);
            Console.WriteLine(radio04);
            Console.WriteLine(radio05);

            Book book01 = new Book();

            Console.WriteLine(book01);

            Pet pet01 = new Pet();

            Console.WriteLine(pet01);

        }


    }
}
