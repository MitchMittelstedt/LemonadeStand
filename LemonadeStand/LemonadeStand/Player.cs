using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        


        //HAS
        public string name;
        public int pitcher;
        public int updatedTotalLemons;
        public int updatedTotalCupsOfSugar;
        public int cupsToPitcher;
        public Inventory inventory;
        public LemonadeRecipe recipe;

        //CONSTRUCTOR
        public Player()
        {
            recipe = new LemonadeRecipe();
            inventory = new Inventory();
            pitcher = 0;
            cupsToPitcher = 8;
        }

        //DOES

        public void MakePitcher()
        {
            inventory.totalNumberOfLemons -= recipe.numberOfLemons;
            inventory.totalNumberOfCupsOfSugar -= recipe.numberOfCupsOfSugar;
            inventory.totalNumberOfIceCubes -= recipe.numberOfIceCubes;
            inventory.totalNumberOfCups -= cupsToPitcher;
        }

        public void SellCupOfLemonadeToCustomer()
        {
            while(cupsToPitcher > 0)
            {
                cupsToPitcher--;
            }
            MakePitcher();
        }

















    }
}
