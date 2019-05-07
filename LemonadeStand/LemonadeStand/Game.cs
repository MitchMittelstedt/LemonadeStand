using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {



        //HAS
        public LemonadeRecipe recipe;
        public Player gamePlayer;
        public Day dayNumber;
        public Store store;

        //CONSTRUCTOR
        public Game()
        {
            recipe = new LemonadeRecipe();
            gamePlayer = new Player();
            dayNumber = new Day();
            store = new Store();
        }


        //DOES
        public void PlayGame()
        {
            GetName();
            do
            {
                store.Sells();
                gamePlayer.inventory.cash -= store.totalCost;
                DisplayInventory();
                recipe.GetRecipe();
                gamePlayer.inventory.totalNumberOfLemons -= store.totalLemons;
                gamePlayer.inventory.totalNumberOfCupsOfSugar -= store.totalCupsOfSugar;
                gamePlayer.inventory.totalNumberOfCups -= store.totalCups;
                gamePlayer.inventory.totalNumberOfIceCubes -= store.totalIceCubes;
                recipe.DisplaySettings();
                Console.ReadLine();
                dayNumber.count++;
            }
            while (dayNumber.count < dayNumber.totalCount);




        }

        public void GetName()
        {
            Console.WriteLine("Please enter your name.");
            gamePlayer.name = Console.ReadLine();
        }


        public void DisplayInventory()
        {
            Console.WriteLine($"{gamePlayer.inventory.totalNumberOfLemons} lemons, {gamePlayer.inventory.totalNumberOfCupsOfSugar} cups of sugar, {gamePlayer.inventory.totalNumberOfCups} ice cubes, {gamePlayer.inventory.totalNumberOfCups} cups.");
        }
    }
}
