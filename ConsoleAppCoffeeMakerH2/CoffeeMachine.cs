using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCoffeeMakerH2
{
    class CoffeeMachine : HotDrink
    {
        public CoffeeMachine(int waterInTank, int howMuchproduktLeft, string typeOfDrink, string produktType, int whichTempatur) : 
            base ( waterInTank, howMuchproduktLeft, typeOfDrink, produktType, whichTempatur)
        {

        }
    }
}
