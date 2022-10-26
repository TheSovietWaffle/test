using HeroesGame.Contract;
using HeroesGame.Implementation.Hero;
using HeroesGame.Implementation.Monster;
using NUnit.Framework;
using System;

namespace HeroesGame.Tests
{
    public class CombatProcessorShould

    {
        private CombatProcessor _cp;

        public int Level { get; private set; }

        [SetUp]
        public void Setup()
        {
            this._cp = new CombatProcessor(new Hunter());
        }

        [Test]
        public void initializeCorrectly()
        {
            Assert.That(this._cp.Hero, Is.Not.Null);
            Assert.That(this._cp.Logger, Is.Not.Null);
            Assert.That(this._cp.Logger, Is.Empty);
        }

        [Test]
        public void FightCorrectly_WeakerEnemy()
        {
            IMonster monster = new MedusaTheGorgon(level: 1);
            this.LevelUpHero(50);
            this._cp.Fight(monster);
            var logger = this._cp.Logger;
            Assert.That(logger.Count, expression: Is.EqualTo(expected: 2));
            Assert.That(logger, expression: Does.Contain(expected: "x").And.Contains(expected: "y"));
        }

        [Test]
        public void FightCorrectlyAndRepeatedly_StrongerEnemy()
        {
            IMonster monster = new MedusaTheGorgon(level: 50);
            this._cp.Fight(monster);
            var logger = this._cp.Logger;
            Assert.That(logger.Count, expression: Has.Count.EqualTo(expected: 12));
            Assert.That(logger, expression: Does.Contain(expected: "x"));
        }
        private void LevelUpHero(int v)
        {
            this.Level = v;
        }
    }
}