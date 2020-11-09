using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCoffeeMakerH2
{
    class Gui
    {
        public void GetTerminal()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine("=============================================");
            Console.WriteLine("             Chose you´re beverage           ");
            Console.WriteLine("=============================================");

            Console.WriteLine("Please choose which beverage, \nyou want to be made for you");
            Console.ResetColor();

            Console.WriteLine("1. Filter-coffee ");
            Console.WriteLine("2. Te");
        }

        public void Replenishment(string whatNeedsAnRefill)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( $"The {whatNeedsAnRefill} tank is allmost emty \nplease refill now");
            Console.ResetColor();
        }
    }
}
