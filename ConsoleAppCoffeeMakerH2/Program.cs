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

            gui.ShowDrink();
            //Console.WriteLine("How much is there of :");
            //Console.Write("Water) ");
            //int water = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Produkt) ");
            //int produkt = Convert.ToInt32(Console.ReadLine());

            //gui.GetTerminal();

            //Console.WriteLine("Chose an number :");
            //int userChooseDrink = int.Parse(Console.ReadLine());
            //Console.Clear();

            //switch (userChooseDrink)
            //{
            //    case 1:
            //        HotDrink coffee = new CoffeeMachine(water, produkt, "Filter - coffee", "Coffee beanies", 96);
            //        if (water <= 10 || produkt <= 7)
            //        {
            //            gui.Replenishment(coffee.CheckContents());
            //        }
            //        else
            //        {
            //            Console.WriteLine(coffee.MakeDrink());
            //            Console.WriteLine(coffee.ServeDrink());
            //        }
            //        break;

            //    case 2:
            //        Console.Write("which type of Tea would you like : ");
            //        string produktType = Console.ReadLine();
            //        Console.Write("what temperature must the tea be : ");
            //        int temp = Convert.ToInt32(Console.ReadLine());

            //        HotDrink te = new Tea(water, produkt, "Tee", produktType, temp);
            //        if (water <= 10 || produkt <= 12)
            //        {
            //            gui.Replenishment(te.CheckContents());
            //        }
            //        else
            //        {
            //            Console.WriteLine(te.MakeDrink());
            //            Console.WriteLine(te.ServeDrink());
            //        }
            //        break;

            //    case 3:
            //        HotDrink espresso = new CoffeeMachine(water, produkt, "Espresso", "Coffee beanies", 96);
            //        if (water <= 3 || produkt <= 5)
            //        {
            //            gui.Replenishment(espresso.CheckContents());
            //        }
            //        else
            //        {
            //            Console.WriteLine(espresso.MakeDrink());
            //            Console.WriteLine(espresso.ServeDrink());
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Please enter a valid number ");
            //        break;
            //}
            Console.ReadKey();
        }
    }
}
