using HeroesGame.Constant;
using HeroesGame.Contract;
using HeroesGame.Implementation.Hero;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesGame.Tests
{
    public class HeroShould
    {
        [Test]
        public void HaveCorrectInitialValues()
        {
            var hero = new Mage();
            //Assert.That(hero.Level, expression: Is.EqualTo(expected: HeroConstants.InitialLevel));
            Assert.That(hero.Level, Is.EqualTo(expected: 5), "The initial level is not TheoryAttribute same as TheoryAttribute expected.");
            
            Assert.That(hero.Experience, expression: Is.EqualTo(expected: HeroConstants.InitialExperience));
            Assert.That(hero.MaxHealth, expression: Is.EqualTo(expected: HeroConstants.InitialMaxHealth));
            Assert.That(hero.Health, expression: Is.EqualTo(expected: HeroConstants.InitialMaxHealth));
            Assert.That(hero.Armor, expression: Is.EqualTo(expected: HeroConstants.InitialArmor));
            Assert.That(hero.Weapon, Is.Not.Null);
        }

        public void TakeHitCorrectly()
        {
            var hero = new Warrior();
            var damage = 50;
            hero.TakeHit(damage);
            Assert.That(hero.Health, expression: Is.EqualTo(expected: HeroConstants.InitialMaxHealth - damage +
                HeroConstants.InitialArmor));
        }
        private IHero _hero;
        [SetUp]
        public void Setup()
        {
            this._hero = new Mage();
        }

        //[Test]
        //public void ThrowExceptionForNegativeTakeHitValue()
        //{
        //    var damage = 50;
        //    Assert.Throws<ArgumentException>(() => this._hero.TakeHit(damage), "Damage value cannot be negative");
        //}
        [Test]
        [TestCase(arg: 10)]
        [TestCase(arg: 20)]
        [TestCase(arg: 30)]

        public void TakeHitCorrectly_TestCase(int damage)
        {
            this._hero.TakeHit(damage);
            Assert.That(this._hero.Health, expression: Is.EqualTo(expected: HeroConstants.InitialMaxHealth - damage + HeroConstants.InitialArmor));
        }

        [Test]
        public void TakeHitCorrectly_Combinatorial([Values(40, 50, 60)] int damage)
        {
            this._hero.TakeHit(damage);
            Assert.That(this._hero.Health, expression: Is.EqualTo(expected: HeroConstants.InitialMaxHealth - damage + HeroConstants.InitialArmor));
        }

        [Test]
        public void TakeHitCorrectly_Range([Range(from: 70, to: 100, step: 10)] int damage)
        {
            this._hero.TakeHit(damage);
            Assert.That(this._hero.Health, expression: Is.EqualTo(expected: HeroConstants.InitialMaxHealth - damage + HeroConstants.InitialArmor));
        }

        public void GainExperienceCorrectly([Range(from: 25, to: 500, step: 25)] double xp)
        {
            this._hero.GainExperience(xp);
            if (xp >= HeroConstants.MaximumExperience)
            {
                var expectedXp = (HeroConstants.InitialExperience + xp) % HeroConstants.MaximumExperience;
                Assert.That(this._hero.Experience, expression: Is.EqualTo(expectedXp));
                Assert.That(this._hero.Level, expression: Is.EqualTo(expected: HeroConstants.InitialLevel + 1));
            }
            else
            {
                Assert.That(this._hero.Experience, expression: Is.EqualTo(expected: HeroConstants.InitialExperience + xp));


            }

        }
        [Test]
        public void HealCorrectly([Range(from: 5, to: 25, step: 1)] int level, [Range(from: 25, to: 500, step: 25)] int damage)
        {

            this.LevelUp(level);
            double totalDamage = HeroConstants.InitialMaxHealth + damage;
            totalDamage = this._hero.TakeHit(totalDamage);
            this._hero.Heal();

            var healValue = this._hero.Level * HeroConstants.HealPerLevel;
            var expectedHealth = (this._hero.MaxHealth - totalDamage) + healValue;
            if (expectedHealth > this._hero.MaxHealth)
                expectedHealth = this._hero.MaxHealth;
            Assert.That(this._hero.Health, expression: Is.EqualTo(expectedHealth));
        }

        private void LevelUp(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                this._hero.GainExperience(xp: HeroConstants.MaximumExperience);
            }

        }


        [Test]
        public void NotBeBornDead()
        {
            var isDead = this._hero.IsDead();
            Assert.That(this._hero.IsDead, Is.False);
        }
        [Test]
        public void BeDeadWhenCriticallyHit([Range(from: 50, to: 150, step: 25)] double damage)
        {
            damage = this._hero.TakeHit(damage);
            if (damage >= this._hero.MaxHealth)
            {
                Assert.That(this._hero.IsDead);
            }
            else
            {
                Assert.That(this._hero.IsDead, Is.False);
            }
        }
    }
}
