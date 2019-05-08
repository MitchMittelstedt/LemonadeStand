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
        public int weatherCondition;
        public string currentWeather;
        public List<string> conditions = new List<string>();
        public Random random;
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
        }

        //DOES

        public void CurrentWeather()
        {
            weatherCondition = random.Next(0, 6);
            currentWeather = conditions[weatherCondition];
        }


















    }
}
