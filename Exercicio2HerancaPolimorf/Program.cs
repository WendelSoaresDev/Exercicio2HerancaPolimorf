using System;
using Exercicio2HerancaPolimorf.Entities;
using System.Collections;
namespace Exercicio2HerancaPolimorf
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the numer of products: ");
            int n = int.Parse(Console.ReadLine());



            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported(c/u/i)?");
                char statusProduct = char.Parse(Console.ReadLine());

                if(statusProduct == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));

                }
                if(statusProduct == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    list.Add(new Product(name, price));
                }
                if (statusProduct == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manDate));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}