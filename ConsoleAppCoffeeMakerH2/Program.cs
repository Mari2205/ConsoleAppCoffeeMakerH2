using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCoffeeMakerH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();


            Console.WriteLine("How much is there of :");
            Console.Write("Water) ");
            int water = Convert.ToInt32(Console.ReadLine());
            Console.Write("Produkt) ");
            int produkt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type of :");
            Console.Write("Drink) ");
            string drinkType = Console.ReadLine();
            Console.Write("Produkt) ");
            string produktType = Console.ReadLine();
            Console.WriteLine("what shut the tempertur be : ");
            int temp = Convert.ToInt32(Console.ReadLine());

            gui.GetTerminal();

            Console.WriteLine("Chose an number :");
            int userChooseDrink = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userChooseDrink)
            {
                case 1:
                    HotDrink coffee = new HotDrink(water, produkt, drinkType, produktType, temp);
                    Console.WriteLine(coffee.MakeDrink());
                    Console.WriteLine(coffee.ServeDrink());

                    break;

                case 2:
                    HotDrink te = new HotDrink(water, produkt, drinkType, produktType, temp);
                    Console.WriteLine(te.MakeDrink());
                    Console.WriteLine(te.ServeDrink());

                    break;

                default:
                    Console.WriteLine("Please enter a valid number ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
