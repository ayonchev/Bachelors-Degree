using NUnit.Framework;
using ShipCrash.UI.Entities;
using ShipCrash.UI.Entities.DefensiveUnits;
using ShipCrash.UI.Entities.Enemies;
using System;

namespace ShipCrash.Tests
{
    [TestFixture, Apartment(System.Threading.ApartmentState.STA)]
    public class EnemyTests
    {
        [SetUp]
        public void Setup()
        {
            AppContainer.CreateApp();
        }

        [TestCase(typeof(BasicEnemy), typeof(BasicShootingTower))]
        [TestCase(typeof(PowerfulEnemy), typeof(PowerfulShootingTower))]
        [TestCase(typeof(FastEnemy), typeof(FastShootingTower))]
        public void Attack_ShouldKillDefensiveUnit(Type enemyType, Type defensiveUnitType)
        {
            BaseEntity.EntityDestroyed = (entity) => Console.WriteLine(entity.GetType().Name);
            Enemy enemy = Activator.CreateInstance(enemyType, new object[] { null }) as Enemy;
            DefensiveUnit defensiveUnit = Activator.CreateInstance(defensiveUnitType) as DefensiveUnit;

            enemy.Attack(defensiveUnit);
            Assert.IsTrue(defensiveUnit.LifePoints <= 0);
        }

    }
}