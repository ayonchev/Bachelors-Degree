using NUnit.Framework;
using ShipCrash.UI.Entities;
using ShipCrash.UI.Entities.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShipCrash.Tests
{
    [TestFixture, Apartment(System.Threading.ApartmentState.STA)]
    public class IslandTests
    {
        [SetUp]
        public void Setup()
        {
            AppContainer.CreateApp();
        }

        [Test]
        public void OnHit_ShouldReduceLifePointsWithOne()
        {
            Island island = new Island();
            BaseEntity.EntityAdded = (e,p) => Console.WriteLine("Added!");
            island.CreateTowers();
            Enemy enemy = new BasicEnemy(null);
            BaseEntity.EntityDestroyed = (entity) => Console.WriteLine(entity.GetType().Name);
            int expectedLifePoints = island.LifePoints - 1;
            enemy.Attack(island);
            Assert.AreEqual(expectedLifePoints, island.LifePoints);
        }
    }
}
