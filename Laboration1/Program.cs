﻿using System;
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
                            stock = CreateItem(stock);
                            break;
                        case 2:
                            int juiceCount = 0;
                            int plateCount = 0;
                            for (int i = 0; i < StockItem.StockCount; i++)
                            {
                                if (stock[i] is Juice)
                                    juiceCount++;
                                else if (stock[i] is Plate)
                                    plateCount++;
                            }
                            Console.WriteLine($"There are {juiceCount} juices.");
                            Console.WriteLine($"There are {plateCount} plates.");
                            break;
                        case 3:
                            for (int i = 0; i < StockItem.StockCount; i++)
                            {
                                if(stock[i] is EcoStockItem)
                                    Console.WriteLine($"(Eco) {stock[i]}");
                                else
                                    Console.WriteLine(stock[i]);
                            }
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

        private static Stock CreateItem(Stock stock)
        {
            Console.WriteLine("Create plate or juice?");
            string plateOrJuice = Console.ReadLine();
            if (plateOrJuice != "juice" && plateOrJuice != "plate")
                throw new Exception("Must be either plate or juice");
            int id = StockItem.StockCount;
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
            return stock;
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
