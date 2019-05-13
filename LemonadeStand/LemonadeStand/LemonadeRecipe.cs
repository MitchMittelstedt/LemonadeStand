using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class LemonadeRecipe
    {
        //has
        public int numberOfLemons;
        public int numberOfCupsOfSugar;
        public int numberOfIceCubes;

        //constructor  
        public LemonadeRecipe()
        {
            numberOfLemons = 0;
            numberOfCupsOfSugar = 0;
            numberOfIceCubes = 0;
        }

        //does

        public void GetRecipe()

        {
            Console.WriteLine("How many lemons per pitcher?");
            numberOfLemons = int.Parse(Console.ReadLine());
            if(numberOfLemons > 0)
            {
                Console.WriteLine("How many cups of sugar per pitcher?");
                numberOfCupsOfSugar = int.Parse(Console.ReadLine());
                if(numberOfCupsOfSugar > 0)
                {
                    Console.WriteLine("How many ice cubes?");
                    numberOfIceCubes = int.Parse(Console.ReadLine());
                    if(numberOfIceCubes > 0)
                    {
                        Console.WriteLine("Thank you!");
                    }else
                    {
                        GetRecipe();
                    }
                }else
                {
                    GetRecipe();
                }
            }
            else
            {
                GetRecipe();
            }



        }















        
    }
}
