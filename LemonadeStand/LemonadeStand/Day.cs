﻿using System;
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
        public int totalDayCount;
        public int dayOfWeek;
        public string currentDay;
        public int totalChance;
        public List<string> whichDay = new List<string>();
        public Weather weather;
        public Customer customer;
        public Random random;

        //CONSTRUCTOR
        public Day ()
        {
            count = 1;
            whichDay.Add("Sunday");
            whichDay.Add("Monday");
            whichDay.Add("Tuesday");
            whichDay.Add("Wednesday");
            whichDay.Add("Thursday");
            whichDay.Add("Friday");
            whichDay.Add("Saturday");
            random = new Random();
        }
        //DOES

        
        public string DayToStart()
        {
            dayOfWeek = random.Next(0, 8);
            for(int i = 0; i < 7; i++)
            {
                currentDay = whichDay[i];
            }
            return currentDay;
        }

        public void totalChanceByDay()
        {
            switch(currentDay)
            {

                case "Sunday":
                    totalChance = random.Next(70, 91);
                    break;
                case "Monday":
                    totalChance = random.Next(40, 61);
                    break;
                case "Tuesday":
                    totalChance = random.Next(40, 51);
                    break;
                case "Wednesday":
                    totalChance = random.Next(60, 81);
                    break;
                case "Thursday":
                    totalChance = random.Next(70, 91);
                    break;
                case "Friday":
                    totalChance = random.Next(80, 101);
                    break;
                case "Saturday":
                    totalChance = random.Next(80, 101);
                    break;
            }
        }

        public void totalChanceByWeather()
        {
            switch(weather.)
            {

            }
        }



        public void GetWeather()
        {
            //random weather
        }
















    }
}
