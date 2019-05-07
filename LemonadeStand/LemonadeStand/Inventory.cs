using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //HAS
        public int totalNumberOfLemons;
        public int totalNumberOfCupsOfSugar;
        public int totalNumberOfCups;
        public int totalNumberOfIceCubes;
        public double cash;
        public LemonadeRecipe recipe;

        //CONSTRUCTOR
        public Inventory()
        {
            totalNumberOfLemons = 0;
            totalNumberOfCupsOfSugar = 0;
            totalNumberOfCups = 0;
            totalNumberOfIceCubes = 0;
            cash = 20.00;
            recipe = new LemonadeRecipe();
        }
        //DOES















    }
}
