using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleAppCoffeeMakerH2
{
    class Gui
    {
        private void GetTerminal()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine("=============================================");
            Console.WriteLine("             Chose you´re beverage           ");
            Console.WriteLine("=============================================");

            Console.WriteLine("Please choose which beverage, \nyou want to be made for you");
            Console.ResetColor();

            Console.WriteLine("1. Filter-coffee ");
            Console.WriteLine("2. Tea");
            Console.WriteLine("3. Espresso");
        }

        private void Replenishment(string whatNeedsAnRefill)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( $"The {whatNeedsAnRefill} tank is allmost emty \nplease refill now");
            Console.ResetColor();
        }

        public void ShowDrink()
        {
            Console.WriteLine("How much is there of :");
            Console.Write("Water (ml) ) ");
            int water = Convert.ToInt32(Console.ReadLine());
            Console.Write("Produkt  (grams) ) ");
            int produkt = Convert.ToInt32(Console.ReadLine());

            this.GetTerminal();

            Console.WriteLine("Chose an number :");
            int userChooseDrink = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userChooseDrink)
            {
                case 1:
                    HotDrink coffee = new CoffeeMachine(water, produkt, "Filter - coffee", "Coffee beanies", 96);
                    if (water <= 250 || produkt <= 17)
                    {
                        this.Replenishment(coffee.CheckContents());
                    }
                    else
                    {
                        Console.WriteLine(coffee.MakeDrink());
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine(coffee.ServeDrink());
                    }
                    break;

                case 2:
                    Console.Write("which type of Tea would you like : ");
                    string produktType = Console.ReadLine();
                    Console.Write("what temperature must the tea be : ");
                    int temp = Convert.ToInt32(Console.ReadLine());

                    HotDrink te = new Tea(water, produkt, "Tee", produktType, temp);
                    if (water <= 250 || produkt <= 12)
                    {
                        this.Replenishment(te.CheckContents());
                    }
                    else
                    {
                        Console.WriteLine(te.MakeDrink());
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine(te.ServeDrink());
                    }
                    break;

                case 3:
                    HotDrink espresso = new CoffeeMachine(water, produkt, "Espresso", "Coffee beanies", 96);
                    if (water <= 100 || produkt <= 20)
                    {
                        this.Replenishment(espresso.CheckContents());
                    }
                    else
                    {
                        Console.WriteLine(espresso.MakeDrink());
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine(espresso.ServeDrink());
                    }
                    break;

                default:
                    Console.WriteLine("Please enter a valid number ");
                    break;
            }
        }
    }
}
