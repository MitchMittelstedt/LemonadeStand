using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //HAS
        public int count;
        public int totalCount;
        public string weather;
        //CONSTRUCTOR
        public Day ()
        {
            count = 0;
        }
        //DOES
        public void GetNumberOfDays()
        {
            Console.WriteLine("Select the number of days the game runs: 7, 14, or 28");
            totalCount = int.Parse(Console.ReadLine());
        }

        public void GetWeather()
        {
            //random weather
        }
















    }
}
