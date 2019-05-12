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
        public int cupsToPitcher;
        public int numberOfBuyers;
        public Inventory inventory;
        public LemonadeRecipe recipe;

        //CONSTRUCTOR
        public Player()
        {
            recipe = new LemonadeRecipe();
            inventory = new Inventory();
            pitcher = 0;
            cupsToPitcher = 8;
            numberOfBuyers = 0;
        }
        //DOES
        public void MakePitcher()
        {
            cupsToPitcher = 8;
            inventory.totalNumberOfLemons -= recipe.numberOfLemons;
            inventory.totalNumberOfCupsOfSugar -= recipe.numberOfCupsOfSugar;
            inventory.totalNumberOfIceCubes -= recipe.numberOfIceCubes;
            inventory.totalNumberOfCups -= cupsToPitcher;
        }

        public void SellCupOfLemonadeToCustomer()
        {
            if(cupsToPitcher > 0)
            {
                cupsToPitcher--;
            }
            //else
            //{

            //    if (inventory.totalNumberOfLemons >= recipe.numberOfLemons && inventory.totalNumberOfCupsOfSugar >= recipe.numberOfCupsOfSugar && inventory.totalNumberOfIceCubes >= recipe.numberOfIceCubes && inventory.totalNumberOfCups >= cupsToPitcher)
            //    {
            //    cupsToPitcher = 8;
            //    MakePitcher();
            //    }
            //}
        }

















    }
}
