using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeRecipe
    {
        //has
        public int numberOfLemons;
        public int numberOfCupsOfSugar;
        public int numberOfIceCubes;

        //constructor  
        public LemonadeRecipe()
        {

        }

        //does

        public void GetRecipe()

        {
            Console.WriteLine("How many lemons per pitcher?");
            numberOfLemons = int.Parse(Console.ReadLine());

            Console.WriteLine("How many cups of sugar per pitcher?");
            numberOfCupsOfSugar = int.Parse(Console.ReadLine());

            Console.WriteLine("How many ice cubes?");
            numberOfIceCubes = int.Parse(Console.ReadLine());
        }

        public void DisplaySettings()
        {
            Console.WriteLine($"Today, you prepared your lemonade with {numberOfLemons} lemons, {numberOfCupsOfSugar} cups of sugar, and {numberOfIceCubes} ice cubes. Good luck!");
        }
       













        
    }
}
