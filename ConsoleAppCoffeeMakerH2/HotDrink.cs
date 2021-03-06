﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ConsoleAppCoffeeMakerH2
{
    class HotDrink
    {
        private string drinkType;
        private string produktType;
        private int tempatur;
        private int howMuchWaterLeft;
        private int howMuchProdukteft;


        int WaterTank { get => howMuchWaterLeft; set => howMuchWaterLeft = value; }
        string DrinkType { get => drinkType; set => drinkType = value; }
        string ProduktType { get => produktType; set => produktType = value; }
        int Tempatur { get => tempatur; set => tempatur = value; }
        int HowMuchProduktLeft { get => howMuchProdukteft; set => howMuchProdukteft = value; }

        public HotDrink (int waterInTank, int howMuchproduktLeft, string typeOfDrink, string produktType, int whichTempatur)
        {
            this.WaterTank = waterInTank;
            this.DrinkType = typeOfDrink;
            this.ProduktType = produktType;
            this.Tempatur = whichTempatur;
            this.HowMuchProduktLeft = howMuchproduktLeft;
        }


        public string ServeDrink()
        {
            string drink = $"you´re {this.drinkType} are ready at the " +
                $"tempatur {this.tempatur} and es made with {this.produktType}";
            return drink;
        }

        public string MakeDrink()
        {
            string mackingAnDrink = $"heating up the water and adding the {this.produktType}";
            return mackingAnDrink;
        }

        public string CheckContents()
        {
            if (howMuchWaterLeft <= 10 || howMuchProdukteft <= 7)
            {
                if (howMuchWaterLeft <= 10)
                {
                    return "water";
                }
                else if (howMuchProdukteft <= 7)
                {
                    return "Produkt";
                }
            }

            return "error occurred, pleace restart now \n";
        }
    }
}
