using App.Entities;
using System;
using System.Globalization;

namespace App // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = [];

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine()!);

                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                switch (typeProduct)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);  
                        list.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine()!);
                        list.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    case 'c':
                        list.Add(new Product(name, price));
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}