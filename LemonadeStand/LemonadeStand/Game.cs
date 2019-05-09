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
        public Player player;
        public Day day;
        public Store store;
        public int pricePerDay;

        //CONSTRUCTOR
        public Game()
        {
            recipe = new LemonadeRecipe();
            player = new Player();
            day = new Day();
            store = new Store();
        }


        //DOES
        public void PlayGame()
        {
            GetName();
            GetNumberOfDays();
            day.DayToStart();
            do
            {
                DisplayDayNumberAndDay();
                DisplayInventory();
                store.Sells();
                UpdateInventoryAfterStore();
                DisplayInventory();
                recipe.GetRecipe();
                DisplayInventory();
                recipe.DisplaySettings();
                SetPrice();
                day.GenerateListOfPeopleChances();
                player.MakePitcher();
                while (player.inventory.totalNumberOfLemons > 0 && player.inventory.totalNumberOfCupsOfSugar > 0 && player.inventory.totalNumberOfIceCubes > 0 && player.inventory.totalNumberOfCups > 0)
                {
                    //if customer buys a lemonade (above a certain % for true)
                    player.SellCupOfLemonadeToCustomer();
                }
                Console.ReadLine();
                day.dayCount++;
                NextDay();
            }
            while (day.dayCount < day.totalDayCount);
            DisplayInventory();
        }

        public void GetName()
        {
            Console.WriteLine("Please enter your name.");
            player.name = Console.ReadLine();
        }

        public void GetNumberOfDays()
        {
            Console.WriteLine($"Hello, {player.name}. Select the number of days the game runs: 7, 14, or 28");
            day.totalDayCount = int.Parse(Console.ReadLine());
            if(day.totalDayCount == 7 || day.totalDayCount == 14 || day.totalDayCount == 28)
            {
                return;
            }
            else
            {
                GetNumberOfDays();
            }
        }

        public void DisplayDayNumberAndDay()
        {
            Console.WriteLine($"{player.name}, this is day #{day.dayCount}, a {day.currentDay}.");
        }

        public void NextDay()
        {
            day.dayOfWeek++;
            int index = day.dayOfWeek;
            day.currentDay = day.whichDay[index + 1];
        }

        public void UpdateInventoryAfterStore()
        {
            player.inventory.cash -= store.totalCost;
            player.inventory.totalNumberOfLemons += store.totalLemons;
            player.inventory.totalNumberOfCupsOfSugar += store.totalCupsOfSugar;
            player.inventory.totalNumberOfCups += store.totalCups;
            player.inventory.totalNumberOfIceCubes += store.totalIceCubes;
        }

        public void SetPrice()
        {
            Console.WriteLine("What will the price of a cup of lemonade be today?");
            pricePerDay = int.Parse(Console.ReadLine());
        }

        public void UpdateInventoryAfterDay()
        {
            player.inventory.totalNumberOfIceCubes = 0;
            Console.WriteLine($"Your inventory has been updated: {player.inventory.totalNumberOfLemons} lemons, {player.inventory.totalNumberOfCupsOfSugar} cups of sugar, {player.inventory.totalNumberOfIceCubes} ice cubes, {player.inventory.totalNumberOfCups} cups, and ${player.inventory.cash}.");
        }


        public void DisplayInventory()
        {
            Console.WriteLine($"Your inventory includes the following: {player.inventory.totalNumberOfLemons} lemons, {player.inventory.totalNumberOfCupsOfSugar} cups of sugar, {player.inventory.totalNumberOfIceCubes} ice cubes, {player.inventory.totalNumberOfCups} cups, and ${player.inventory.cash}.");
        }

        public void ConvertToBuyOrNot()
        {
            foreach (int element in day.customer.peopleChances)
            {
                if (element > 50)
                {
                    player.SellCupOfLemonadeToCustomer();
                }
            }
        }
    }
}
