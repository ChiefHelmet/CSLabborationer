using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Program
    {
        private Stock ActiveStock
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program._InitialiseStock();
            program._PrintMenu();
        }

        private void _InitialiseStock()
        {
            ActiveStock = _CreateDummyData();

            //for (int i = 0; i < stock.Length; i++)
            //{
            //    Console.WriteLine(stock.GetItem(i));
            //    Console.WriteLine("--------------");
            //}
        }

        private Stock _CreateDummyData()
        {
            Stock stock = new Stock();

            Juice appleJuice = new Juice() { Id = 0, Name = "Brädhult", Type = "Apple", Marking = "Krav", StockCount = 20 };
            Juice orangeJuice = new Juice() { Id = 0, Name = "Plankhult", Type = "Orange", Marking = "EG", StockCount = 25 };

            Plate redPlate = new Plate() { Id = 0, Name = "Plåthult", Type = "Deep", StockCount = 125 };
            Plate bluePlate = new Plate() { Id = 0, Name = "Porslinhult", Type = "Flat", StockCount = 321 };

            stock.AddItem((StockItem)appleJuice);
            stock.AddItem((StockItem)orangeJuice);
            stock.AddItem((StockItem)redPlate);
            stock.AddItem((StockItem)bluePlate);

            return stock;
        }

        private void _PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("1: Skapa vara");
            Console.WriteLine("2: Inventera vara");
            Console.WriteLine("3: Lista varor");
            Console.WriteLine("4: Avsluta");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    _PrintCreateMenu();
                    break;
                case '2':
                    _EditItemStock();
                    break;
                case '3':
                    _ListItems();
                    break;
                case '4':
                    return;
                default:
                    _PrintMenu();
                    break;
            }
        }

        private void _ListItems(bool goBackToMenu = true)
        {
            Console.Clear();
            for (int i = 0; i < ActiveStock.Length; i++)
            {
                StockItem item = ActiveStock.GetItem(i);

                if (item != null)
                {
                    Console.WriteLine(i + "\r\n" + item.ToString());
                    if (item is EcoStockItem)
                    {
                        Console.WriteLine("ECO");
                    }
                    Console.WriteLine("------------");
                }
            }

            
            if (goBackToMenu)
            {
                Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
                Console.ReadKey();

                _PrintMenu();
            }
        }

        private void _EditItemStock()
        {
            _ListItems(goBackToMenu: false);
            int userInput = _GetNumberFromUser("Select item to update: ", 0);

            while (!_EditItemByIndex(userInput))
            {
                userInput = _GetNumberFromUser("Selection was not a valid item.\r\nSelect item to update: ", 0);
            }

            _PrintMenu();
        }

        private bool _EditItemByIndex(int index)
        {
            if (index < ActiveStock.Length && ActiveStock.GetItem(index) != null)
            {
                StockItem item = ActiveStock.GetItem(index);

                Console.WriteLine("Curent stock " + item.StockCount);
                item.StockCount = _GetNumberFromUser("Set new stock value: ", 0);

                return true;
            }

            return false;
        }

        private void _CreateItem(string itemType)
        {
            Console.Clear();

            Console.Write("Produktnamn: ");
            var name = Console.ReadLine();

            Console.Write("Typ: ");
            var type = Console.ReadLine();

            string marking = "";
            if (itemType == "juice")
            {
                Console.Write("Ekologisk märkning: ");
                marking = Console.ReadLine();
            }

            var stockCount = _GetNumberFromUser("Antal: ", 0);

            try
            {
                switch (itemType)
                {
                    case "juice":
                        var juice = new Juice() { Id = 0, Name = name, Type = type, Marking = marking, StockCount = stockCount };
                        ActiveStock.AddItem(juice);
                        break;
                    case "plate":
                        ActiveStock.AddItem(
                            new Plate() { Id = 0, Name = name, Type = type, StockCount = stockCount }
                            );
                        break;
                    default:
                        throw new Exception(itemType + " is not a valid product type.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Varan kunde inte läggas till.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tryck på valfri tangent för att fortsätta.");
                Console.ReadKey();
            }

            _PrintCreateMenu();
        }

        private void _PrintCreateMenu()
        {
            Console.Clear();
            Console.WriteLine("Vilken produkt vill du lägga till?");
            Console.WriteLine("1: Juice");
            Console.WriteLine("2: Tallrik");
            Console.WriteLine("3. Gå tillbaka");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    _CreateItem("juice");
                    break;
                case '2':
                    _CreateItem("plate");
                    break;
                case '3':
                    _PrintMenu();
                    break;
                default:
                    _PrintCreateMenu();
                    break;
            }
        }

        private int _GetNumberFromUser(string message, int min = int.MinValue, int max = int.MaxValue)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();

            int parsedUserInput;

            while (true)
            {
                if (int.TryParse(userInput, out parsedUserInput) && parsedUserInput >= min && parsedUserInput <= max)
                {
                    return parsedUserInput;
                }

                else
                {
                    Console.WriteLine(userInput + " is not a valid number or out of range.");
                    Console.Write(message);
                    userInput = Console.ReadLine();
                }
            }
        }
    }
}
