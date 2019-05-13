using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTest
{
    [TestClass]
    public class AddToInventoryGameClassTest
    {
        [TestMethod]
        public void Subtract_StoreMoney_FromInventory()
        {
            //Arrange
            Player player = new Player();
            Game game = new Game();
            Inventory inventory = new Inventory();
            Store store = new Store();
            double expected = 15.00;
            double actual;
            store.totalCost = 5.00;
            //Act
            game.UpdateInventoryAfterStore();
            actual = player.inventory.cash -= store.totalCost;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_StoreLemons_ToInventory()
        {
            //Arrange
            Player player = new Player();
            Game game = new Game();
            Inventory inventory = new Inventory();
            Store store = new Store();
            int expected = 5;
            int actual;
            store.totalLemons = 5;
            //Act
            game.UpdateInventoryAfterStore();
            actual = player.inventory.totalNumberOfLemons += store.totalLemons;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_StoreCupsOfSugar_ToInventory()
        {
            //Arrange
            Player player = new Player();
            Game game = new Game();
            Inventory inventory = new Inventory();
            Store store = new Store();
            int expected = 5;
            int actual;
            store.totalCupsOfSugar = 5;
            //Act
            game.UpdateInventoryAfterStore();
            actual = player.inventory.totalNumberOfCupsOfSugar += store.totalCupsOfSugar;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_StoreCups_ToInventory()
        {
            //Arrange
            Player player = new Player();
            Game game = new Game();
            Inventory inventory = new Inventory();
            Store store = new Store();
            int expected = 5;
            int actual;
            store.totalCups = 5;
            //Act
            game.UpdateInventoryAfterStore();
            actual = player.inventory.totalNumberOfCups += store.totalCups;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}