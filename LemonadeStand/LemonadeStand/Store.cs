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
        public void Sells()
        {
            string purchaseChoice = "";
            while (purchaseChoice != "I'm good to go.")
            {

                Console.WriteLine("Welcome to the store! What would you like to buy? We sell: \n\"lemons\" ($.89 for 10, $1.50 for 20, $2.79 for 40), \n\"sugar\" ($.89 for 10 (cups of sugar), $1.50 for 20, $2.79 for 40),  \n\"ice cubes\" ($.89 for 100, $1.50 for 250, $2.79 for 500), \n\"cups\" ($.89 for 25, $1.50 for 50, $2.79 for 100). \nIf you're good to go, just say, \"I'm good to go.\"");
                purchaseChoice = Console.ReadLine();
                switch (purchaseChoice)
                {
                    case "lemons":
                        Console.WriteLine("How many lemons? 10, 20, or 40?");
                        string number = Console.ReadLine();
                        switch (number)
                        {
                            case "10":
                                totalCost += tenLemons;
                                totalLemons += 10;
                                break;
                            case "20":
                                totalCost += twentyLemons;
                                totalLemons += 20;
                                break;
                            case "40":
                                totalCost += fortyLemons;
                                totalLemons += 40;
                                break;
                            default:
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
                                break;
                            case "20":
                                totalCost += twentyCupsOfSugar;
                                totalCupsOfSugar += 20;
                                break;
                            case "40":
                                totalCost += fortyCupsOfSugar;
                                totalCupsOfSugar += 40;
                                break;
                            default:
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
                                break;
                            case "50":
                                totalCost += fiftyCups;
                                totalCups += 50;
                                break;
                            case "100":
                                totalCost += oneHundredCups;
                                totalCups += 100;
                                break;
                        }
                        break;
                    case "ice cubes":
                        Console.WriteLine("How many ice cubes? 100, 250, or 500?");
                        number = Console.ReadLine();
                        switch (number)
                        {
                            case "100":
                                totalCost += oneHundredIceCubes;
                                totalIceCubes += 100;
                                break;
                            case "250":
                                totalCost += twoHundredFiftyIceCubes;
                                totalIceCubes += 250;
                                break;
                            case "500":
                                totalCost += fiveHundredIceCubes;
                                totalIceCubes += 500;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "I'm good to go.":
                        break;

                }

            }
            
        }




















    }
}
