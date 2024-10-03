using Emmer_opdracht;
using Emmer_opdracht.Expetions;

namespace UnitTestBucket;

public class OilbarrelClassTest
{
    [Test]
    public void CapacityGivesCorrectValue()
    {
        Oilbarrel barrel = new Oilbarrel();
        Assert.That(barrel.Capacity, Is.EqualTo(159));
    }
    
    [TestCase(10)]
    public void ContentGivesCorrectValue(int content)
    {
        Oilbarrel barrel = new Oilbarrel(content);
        Assert.That(barrel.Content, Is.EqualTo(content));
    }
    
    [TestCase(-2500)]
    public void ContentCantBeNegative(int content)
    {
        Assert.Throws<ValueOutOfBoundsExeption>(() => new Oilbarrel(content));
    }

    [Test]
    public void ContentCanBeSet()
    {
        Oilbarrel barrel = new Oilbarrel(10);
        barrel.Content = 20;
        Assert.That(barrel.Content, Is.EqualTo(20));
    }
    
    [Test]
    public void AddContentWithFillFunction()
    {
        Oilbarrel barrel = new Oilbarrel(10);
        barrel.Fill(20);
        Assert.That(barrel.Content, Is.EqualTo(30));
    }
    
    [Test]
    public void AddContentWithFillFunctionOverCapacity()
    {
        Oilbarrel barrel = new Oilbarrel(10);

        Assert.Throws<ValueOutOfBoundsExeption>(() => barrel.Fill(200));

    }
    
    [Test]
    public void RemoveContentWithEmptyFunction()
    {
        Oilbarrel barrel = new Oilbarrel(10);
        barrel.Empty(5);
        Assert.That(barrel.Content, Is.EqualTo(5));
    }
    
    [Test]
    public void RemoveContentWithEmptyFunctionOverContent()
    {
        Oilbarrel barrel = new Oilbarrel(10);
        Assert.Throws<ValueOutOfBoundsExeption>(() => barrel.Empty(20));
    }
    
    [Test]
    public void EmptyBarrel()
    {
        Oilbarrel barrel = new Oilbarrel(10);
        barrel.Empty();
        Assert.That(barrel.Content, Is.EqualTo(0));
    }
    

}