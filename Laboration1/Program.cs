using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();

            int selectedOption = 0;
            while (selectedOption != 4)
            {
                try
                {
                    PrintMenu();
                    selectedOption = int.Parse(Console.ReadLine());
                    if (selectedOption < 1 || selectedOption > 4)
                        throw new Exception("Option must be a value between 1 and 4");
                    switch (selectedOption)
                    {
                        case 1:
                            CreateItem(stock);
                            break;
                        case 2:
                            Inventory(stock);
                            break;
                        case 3:
                            PrintStock(stock);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void PrintStock(Stock stock)
        {
            for (int i = 0; i < stock.Length; i++)
            {
                if (stock[i] is EcoStockItem)
                    Console.WriteLine($"{stock[i]} - Eco");
                else
                    Console.WriteLine(stock[i]);
            }
        }

        private static void Inventory(Stock stock)
        {
            Console.WriteLine("Id of the item?");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine($"How many {stock.GetItem(id).Name} are there?");
            int quantity = int.Parse(Console.ReadLine());
            stock.GetItem(id).StockCount = quantity;
        }

        private static void CreateItem(Stock stock)
        {
            Console.WriteLine("Create plate or juice?");
            string plateOrJuice = Console.ReadLine();
            if (plateOrJuice.ToLower() != "juice" && plateOrJuice.ToLower() != "plate")
                throw new Exception("Must be either plate or juice");
            int id = stock.Length;
            Console.WriteLine("Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Type?");
            string type = Console.ReadLine();
            if (plateOrJuice == "juice")
            {
                Console.WriteLine("Mark?");
                string mark = Console.ReadLine();
                stock.AddItem(new Juice(id, name, mark, type));
            }
            else
                stock.AddItem(new Plate(id, name, type));
        }

        private static void PrintMenu()
        {
            Console.WriteLine("1- Skapa vara");
            Console.WriteLine("2- Inventera vara");
            Console.WriteLine("3- Lista varor");
            Console.WriteLine("4- Avsluta");
        }
    }
}
