using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //HAS (DO LIST)
        public int numberOfPeople;
        public int temperature;
        public int forecastTemperature;
        public int weatherCondition;
        public int forecastWeatherCondition;
        public string currentWeather;
        public string forecastWeather;
        public List<string> conditions = new List<string>();
        public List<string> forecastWeatherList = new List<string>();
        public List<int> forecastTemperatureList = new List<int>();
        public Random random;
        public Customer customer;
        //CONSTRUCTOR
        public Weather()
        {

            conditions.Add("sunny");
            conditions.Add("rainy");
            conditions.Add("cloudy");
            conditions.Add("windy");
            conditions.Add("tornado");
            conditions.Add("volcano");
            random = new Random();
            customer = new Customer();
            numberOfPeople = 0;
        }

        //DOES

        public void ForecastWeatherAndTemperature()
        {
            forecastWeatherCondition = random.Next(0, 6);
            forecastWeather = conditions[weatherCondition];
            temperature = random.Next(50, 101);
        }

        public void ForecastWeatherForDurationOfGame()
        {

        }

        public void ForecastTemperatureForDurationOfGame()
        {

        }

        public void CurrentWeatherAndTemperature()
        {
            weatherCondition = random.Next(0, 6);
            currentWeather = conditions[weatherCondition];
            temperature = random.Next(50, 101);
        }

        public void GetNumberOfPeopleAccordingToWeather()
        {
            switch(currentWeather)
            {
                case "sunny":
                    numberOfPeople += random.Next(50, 101);
                    break;
                case "rainy":
                    numberOfPeople += random.Next(30, 61);
                    break;
                case "cloudy":
                    numberOfPeople += random.Next(40, 86);
                    break;
                case "windy":
                    numberOfPeople += random.Next(40, 86);
                    break;
                case "tornado":
                    numberOfPeople += random.Next(0, 11);
                    break;
                case "volcano":
                    numberOfPeople += random.Next(50, 101);
                    break;
            }
            if (temperature > 90)
            {
                numberOfPeople += random.Next(70, 101);
            }
            else if (temperature > 80 && temperature < 91)
            {
                numberOfPeople += random.Next(80, 121);
            }
            else if (temperature > 70 && temperature < 81)
            {
                numberOfPeople += random.Next(70, 111);
            }
            else if (temperature > 60 && temperature < 71)
            {
                numberOfPeople += random.Next(40, 81);
            }
            else
            {
                numberOfPeople += random.Next(20, 41);
            }
            numberOfPeople /= 2;
        }
    }
}
