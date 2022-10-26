[Test]
public void HaveCorrectInitialValues()
{
    var hero = new Mage();
    Assert.That(hero.Level, expression: Is.EqualTo(expected: HeroConstants.InitialLevel));
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
