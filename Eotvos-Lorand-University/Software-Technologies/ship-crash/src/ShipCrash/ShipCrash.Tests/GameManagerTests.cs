using NUnit.Framework;
using ShipCrash.UI.Managers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Controls;

namespace ShipCrash.Tests
{
    [TestFixture, Apartment(System.Threading.ApartmentState.STA)]
    public class GameManagerTests
    {
        [SetUp]
        public void Setup()
        {
            AppContainer.CreateApp();
        }
        //[Test]
        public void Start_ShouldAddNewEnemies()
        {
            GameManager gameManager = new GameManager(new Canvas());
            gameManager.Start();

            //Need to find a way to make the Dispatcher Timer work in the tests.
            Thread.Sleep(5000);
            Assert.IsTrue(gameManager.Enemies.Count > 0);
        }

    }
}
