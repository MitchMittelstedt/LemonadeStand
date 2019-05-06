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

        //CONSTRUCTOR
        public Game()
        {
            recipe = new LemonadeRecipe();
            gamePlayer = new Player();
            dayNumber = new Day();
        }


        //DOES
        public void PlayGame()
        {
            GetName();
            do
            {
                recipe.GetRecipe();
            }
            while(dayNumber.count < dayNumber.totalCount);
            
            


        }

        public void GetName()
        {
            Console.WriteLine("Please enter your name.");
            gamePlayer.name = Console.ReadLine();
        }

















    }
}
