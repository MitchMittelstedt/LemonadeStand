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
        public Player player;
        public Day day;
        public Store store;
        public List<int> dailyLogOfCustomers = new List<int>();
        public List<int> dailyLogOfAllCustomers = new List<int>();
        public Random random;
        //CONSTRUCTOR
        public Game()
        {
            player = new Player();
            day = new Day();
            store = new Store();
            random = new Random();
        }


        //DOES
        public void PlayGame()
        {
            GetName();
            GetNumberOfDays();
            day.DayToStart();
            DisplayForecastWeatherAndTemperatureForDurationOfGame();
            do
            {
                DisplayDayNumberAndDay();
                day.weather.CurrentWeatherAndTemperature();
                day.weather.GetNumberOfPeopleAccordingToWeather();
                DisplayActualWeatherAndTemperature();
                DisplayInventory();
                store.Sells();
                UpdateInventoryAfterStore();
                DisplayInventory();
                player.recipe.GetRecipe();
                DisplayInventory();
                SetPrice();
                DisplaySettings();
                day.GenerateListOfPeopleChances();
                player.MakePitcher();
                ConvertToBuyOrNot();
                DisplayDayOverview();
                NextDay();
            }
            while (day.dayCount < day.totalDayCount);
            DisplayEndOverview();
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
            if (day.totalDayCount == 7 || day.totalDayCount == 14 || day.totalDayCount == 28)
            {
                return;
            }
            else
            {
                GetNumberOfDays();
            }
        }

        public void DisplayForecastWeatherAndTemperatureForDurationOfGame()
        {
            for (int i = 0; i < day.totalDayCount; i++)
            {
                day.weather.ForecastWeatherAndTemperature();
                day.weather.forecastWeatherList.Add(day.weather.forecastWeather);
                day.weather.forecastTemperatureList.Add(day.weather.forecastTemperature);
            }
            day.weather.forecastWeatherList.ForEach(Console.WriteLine);
            day.weather.forecastTemperatureList.ForEach(Console.WriteLine);
        }


        public void DisplayDayNumberAndDay()
        {
            Console.WriteLine($"{player.name}, this is day #{day.dayCount}, a {day.currentDay}.");
        }

        public void DisplayActualWeatherAndTemperature()
        {
            Console.WriteLine($"For better or worse, the actual weather is {day.weather.currentWeather} at {day.weather.temperature}.");
        }

        public void NextDay()
        {
            dailyLogOfAllCustomers.Add(day.customer.peopleChances.Count());
            dailyLogOfCustomers.Add(player.numberOfBuyers);
            player.numberOfBuyers = 0;
            day.customer.peopleChances.Clear();
            player.inventory.totalNumberOfIceCubes = 0;
            day.dayCount++;
            if (day.dayOfWeek == 6)
            {
                day.dayOfWeek = 0;
            }
            else
            {
            day.dayOfWeek++;
            int index = day.dayOfWeek;
            day.currentDay = day.whichDay[index];
            }
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
            day.pricePerDay = double.Parse(Console.ReadLine());
        }

        public void UpdateInventoryAfterDay()
        {
            player.inventory.totalNumberOfIceCubes = 0;
            Console.WriteLine($"Your inventory has been updated: {player.inventory.totalNumberOfLemons} lemons, {player.inventory.totalNumberOfCupsOfSugar} cups of sugar, {player.inventory.totalNumberOfIceCubes} ice cubes, {player.inventory.totalNumberOfCups} cups, and ${player.inventory.cash}.");
        }

        public void DisplaySettings()
        {
            Console.WriteLine($"Today, you prepared your lemonade with {player.recipe.numberOfLemons} lemons, {player.recipe.numberOfCupsOfSugar} cups of sugar, and {player.recipe.numberOfIceCubes} ice cubes, and the price you set is ${day.pricePerDay}. Good luck!");
        }


        public void DisplayInventory()
        {
            Console.WriteLine($"Your inventory includes the following: {player.inventory.totalNumberOfLemons} lemons, {player.inventory.totalNumberOfCupsOfSugar} cups of sugar, {player.inventory.totalNumberOfIceCubes} ice cubes, {player.inventory.totalNumberOfCups} cups, and ${player.inventory.cash}.");
        }

        public void ConvertToBuyOrNot() //SellLemonadeToCustomers()
        {
            foreach (int element in day.customer.peopleChances) //why is it selling to more than the number of chances?
            {
                if (element > 50)
                {
                    player.inventory.cash += day.pricePerDay;
                    player.numberOfBuyers++;
                    player.SellCupOfLemonadeToCustomer();


                    if (player.cupsToPitcher == 0)
                    {
                        if (player.inventory.totalNumberOfLemons >= player.recipe.numberOfLemons && player.inventory.totalNumberOfCupsOfSugar >= player.recipe.numberOfCupsOfSugar && player.inventory.totalNumberOfIceCubes >= player.recipe.numberOfIceCubes && player.inventory.totalNumberOfCups >= player.cupsToPitcher)
                        {
                            player.MakePitcher();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        public void DisplayDayOverview()
        {
            Console.WriteLine($"You sold lemonade to {player.numberOfBuyers} of {day.customer.peopleChances.Count()} customers.");
        }

        public void DisplayEndOverview()
        {
            Console.WriteLine($"You sold lemonade to {dailyLogOfCustomers.Sum()} of a total {dailyLogOfAllCustomers.Sum()} possible customers. \n\nYou made ${player.inventory.cash}!\n\nPlay again (1) or quit?");
            int playAgainOrQuit = int.Parse(Console.ReadLine());
            switch(playAgainOrQuit)
            {
                case 1:
                    PlayGame();
                    break;
                case 2:
                    break;
                default:
                    DisplayEndOverview();
                    break;
            }
        }
        public void WeatherForecast()
        {

        }
    }
}
                  