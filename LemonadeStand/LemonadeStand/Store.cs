using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //HAS
        public double totalCost;
        public double tenLemons;
        public double twentyLemons;
        public double fortyLemons;
        public double tenCupsOfSugar;
        public double twentyCupsOfSugar;
        public double fortyCupsOfSugar;
        public double twentyFiveCups;
        public double fiftyCups;
        public double oneHundredCups;
        public double oneHundredIceCubes;
        public double twoHundredFiftyIceCubes;
        public double fiveHundredIceCubes;
        public int totalLemons;
        public int totalCupsOfSugar;
        public int totalCups;
        public int totalIceCubes;
        //CONSTRUCTOR
        public Store()
        {
            tenLemons = 0.89;
            twentyLemons = 1.50;
            fortyLemons = 2.79;
            tenCupsOfSugar = .89;
            twentyCupsOfSugar = 1.50;
            fortyCupsOfSugar = 2.79;
            twentyFiveCups = 0.89;
            fiftyCups = 1.50;
            oneHundredCups = 2.79;
            oneHundredIceCubes = 0.89;
            twoHundredFiftyIceCubes = 1.50;
            fiveHundredIceCubes = 2.79;
            totalCost = 0.00;
            totalLemons = 0;
            totalCupsOfSugar = 0;
            totalCups = 0;
            totalIceCubes = 0;
    }
        //DOES
        public void Sells() //adds cost of purchases together . . . move to player class?
        {
            Console.WriteLine("What would you like to buy?");
            string purchaseChoice = Console.ReadLine();
            switch(purchaseChoice)
            {
                case "lemons":
                    Console.WriteLine("How many lemons? 10, 20, or 40?");
                    string number = Console.ReadLine();
                    switch(number)
                    {
                        case "10":
                            totalCost += tenLemons;
                            totalLemons += 10;
                            Sells();
                            break;
                        case "20":
                            totalCost += twentyLemons;
                            totalLemons += 20;
                            Sells();
                            break;
                        case "40":
                            totalCost += fortyLemons;
                            totalLemons += 40;
                            Sells();
                            break;
                    }
                    break;
                case "sugar":
                    Console.WriteLine("How many cups of sugar? 10, 20, or 40?");
                    number = Console.ReadLine();
                    switch (number)
                    {
                        case "10":
                            totalCost += tenCupsOfSugar;
                            totalCupsOfSugar += 10;
                            Sells();
                            break;
                        case "20":
                            totalCost += twentyCupsOfSugar;
                            totalCupsOfSugar += 20;
                            Sells();
                            break;
                        case "40":
                            totalCost += fortyCupsOfSugar;
                            totalCupsOfSugar += 40;
                            Sells();
                            break;
                    }
                    break;
                case "cups":
                    Console.WriteLine("How many cups? 25, 50, or 100?");
                    number = Console.ReadLine();
                    switch (number)
                    {
                        case "25":
                            totalCost += twentyFiveCups;
                            totalCups += 25;
                            Sells();
                            break;
                        case "50":
                            totalCost += fiftyCups;
                            totalCups += 50;
                            Sells();
                            break;
                        case "100":
                            totalCost += oneHundredCups;
                            totalCups += 100;
                            Sells();
                            break;
                    }
                    break;
                case "ice cubes":
                    Console.WriteLine("How many ice cubes? 100, 250, or 500?");
                    number = Console.ReadLine();
                    switch(number)
                    {
                        case "100":
                            totalCost += oneHundredIceCubes;
                            totalIceCubes += 100;
                            Sells();
                            break;
                        case "250":
                            totalCost += twoHundredFiftyIceCubes;
                            totalIceCubes += 250;
                            Sells();
                            break;
                        case "500":
                            totalCost += fiveHundredIceCubes;
                            totalIceCubes += 500;
                            Sells();
                            break;
                    }
                    break;
            }

        }




















    }
}
