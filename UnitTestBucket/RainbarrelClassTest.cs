using Emmer_opdracht;
using Emmer_opdracht.Expetions;

namespace UnitTestBucket;

public class RainbarrelClassTest
{
    [TestCase(Rainbarrel.CapacitySizes.Small)]
    [TestCase(Rainbarrel.CapacitySizes.Medium)]
    [TestCase(Rainbarrel.CapacitySizes.Large)]
    public void CapacityGivesCorrectValue(Rainbarrel.CapacitySizes capacity)
    {
        Rainbarrel barrel = new Rainbarrel(capacity);
        Assert.That(barrel.Capacity, Is.EqualTo((int)capacity));
    }
    
    [TestCase(Rainbarrel.CapacitySizes.Small, 10)]
    public void ContentGivesCorrectValue(Rainbarrel.CapacitySizes capacity, int content)
    {
        Rainbarrel barrel = new Rainbarrel(capacity, content);
        Assert.That(barrel.Content, Is.EqualTo(content));
    }

    [Test]
    public void ContentCanBeSet()
    {
        Rainbarrel barrel = new Rainbarrel(Rainbarrel.CapacitySizes.Small, 10);
        barrel.Content = 20;
        Assert.That(barrel.Content, Is.EqualTo(20));
    }
    
    [Test]
    public void AddContentWithFillFunction()
    {
        Rainbarrel barrel = new Rainbarrel(Rainbarrel.CapacitySizes.Small, 10);
        barrel.Fill(20);
        Assert.That(barrel.Content, Is.EqualTo(30));
    }
    
    [Test]
    public void AddContentWithFillFunctionOverCapacity()
    {
        Rainbarrel barrel = new Rainbarrel(Rainbarrel.CapacitySizes.Small, 10);
        Assert.Throws<ValueOutOfBoundsExeption>(() => barrel.Fill(200));
        
    }
    
    [Test]
    public void RemoveContentWithEmptyFunction()
    {
        Rainbarrel barrel = new Rainbarrel(Rainbarrel.CapacitySizes.Small, 10);
        barrel.Empty(5);
        Assert.That(barrel.Content, Is.EqualTo(5));
    }
    
    [Test]
    public void RemoveContentWithEmptyFunctionOverContent()
    {
        Rainbarrel barrel = new Rainbarrel(Rainbarrel.CapacitySizes.Small, 10);
        Assert.Throws<ValueOutOfBoundsExeption>(() => barrel.Empty(20));
    }
    
    [Test]
    public void EmptyBarrel()
    {
        Rainbarrel barrel = new Rainbarrel(Rainbarrel.CapacitySizes.Small, 10);
        barrel.Empty();
        Assert.That(barrel.Content, Is.EqualTo(0));
    }
    
    [Test]
    public void CapacityCanOnlyBe80_100Or120()
    {
        foreach (var value in Enum.GetValues(typeof(Rainbarrel.CapacitySizes)))
        {
            Assert.That((int)value, Is.EqualTo(80).Or.EqualTo(100).Or.EqualTo(120));
        }
        
    }
    
   

}