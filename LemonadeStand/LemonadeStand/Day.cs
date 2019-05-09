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
        public int dayCount;
        public int totalDayCount;
        public int dayOfWeek;
        public string currentDay;
        public int totalChance;
        public List<string> whichDay = new List<string>();
        public int numberOfChanceVariables;
        public Weather weather;
        public Customer customer;
        public Random random;

        //CONSTRUCTOR
        public Day ()
        {
            dayCount = 1;
            whichDay.Add("Sunday");
            whichDay.Add("Monday");
            whichDay.Add("Tuesday");
            whichDay.Add("Wednesday");
            whichDay.Add("Thursday");
            whichDay.Add("Friday");
            whichDay.Add("Saturday");
            random = new Random();
            customer = new Customer();
            weather = new Weather();
            totalChance = 0;
            numberOfChanceVariables = 4;
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

        public int TotalChanceByDay()
        {
            switch(currentDay)
            {
                case "Sunday":
                    totalChance += random.Next(70, 91);
                    break;
                case "Monday":
                    totalChance += random.Next(40, 61);
                    break;
                case "Tuesday":
                    totalChance += random.Next(40, 51);
                    break;
                case "Wednesday":
                    totalChance += random.Next(60, 81);
                    break;
                case "Thursday":
                    totalChance += random.Next(70, 91);
                    break;
                case "Friday":
                    totalChance += random.Next(80, 101);
                    break;
                case "Saturday":
                    totalChance += random.Next(80, 101);
                    break;
            }
            switch (weather.currentWeather)
            {
                case "sunny":
                    totalChance += random.Next(80, 101);
                    break;

                case "rainy":
                    totalChance += random.Next(20, 31);
                    break;

                case "cloudy":
                    totalChance += random.Next(50, 81);
                    break;

                case "windy":
                    totalChance += random.Next(70, 81);
                    break;

                case "tornado":
                    totalChance += random.Next(0, 21);
                    break;

                case "volcano":
                    totalChance += random.Next(0, 11);
                    break;
            }
            if (weather.temperature > 90)
            {
                totalChance += random.Next(90, 101);
            }
            else if (weather.temperature > 80 && weather.temperature < 90)
            {
                totalChance += random.Next(80, 91);
            }
            else if (weather.temperature > 70 && weather.temperature < 80)
            {
                totalChance += random.Next(70, 81);
            }
            else if (weather.temperature > 60 && weather.temperature < 70)
            {
                totalChance += random.Next(60, 71);
            }
            else
            {
                totalChance += random.Next(50, 61);
            }
            totalChance = GenerateIndividualCustomerChance();
            return totalChance;
        }

        public int GenerateIndividualCustomerChance()
        {
            customer.chanceToBuyLemonade = random.Next(0, 100);
            totalChance += customer.chanceToBuyLemonade;
            totalChance /= numberOfChanceVariables;
            return totalChance;
        }
        public void GenerateListOfPeopleChances()
        {
            for (int i = 0; i < weather.numberOfPeople; i++)
            {
                customer.peopleChances.Add(TotalChanceByDay()); //now there's a list of people chances
            }

        }


    }





}





        //switch (weather.currentWeather)
        //{
        //    case "sunny":
        //        totalChance += random.Next(80, 101);
        //        break;
        //    case "rainy":
        //        totalChance += random.Next(20, 31);
        //        break;
        //    case "cloudy":
        //        totalChance += random.Next(50, 81);
        //        break;
        //    case "windy":
        //        totalChance += random.Next(70, 81);
        //        break;
        //    case "tornado":
        //        totalChance += random.Next(0, 21);
        //        break;
        //    case "volcano":
        //        totalChance += random.Next(0, 11);
        //        break;
        //}




    























    

