using Emmer_opdracht;
using Emmer_opdracht.Expetions;

public class BucketClassTest
{
    
    [TestCase(12)]
    [TestCase(2500)]
    [TestCase(10)]
    public void CapacityGivesCorrectValue(int capacity)
    {
       Bucket bucket = new Bucket(capacity, 0);
       Assert.That(bucket.Capacity, Is.EqualTo(capacity));
    }
    
    [TestCase(2500, 310)]
    public void ContentGivesCorrectValue(int capacity, int content)
    {
        Bucket bucket = new Bucket(capacity, content);
        Assert.That(bucket.Content, Is.EqualTo(content));
    }
    
    [TestCase(-2500)]
    public void ContentCantBeNegative(int content)
    {
        Bucket bucket = new Bucket(2500, content);
        Assert.That(bucket.Content, Is.EqualTo(0));
    }
    
    [TestCase(-2500)]
    public void CapacityCantBeNegative(int capacity)
    {
        Assert.Throws<ValueOutOfBoundsExeption>(() => new Bucket(capacity, 10));
    }
    
    [Test]
    public void CapacityCantBeLowerHigherThan2500()
    {
        Assert.Throws<ValueOutOfBoundsExeption>(() => new Bucket(2501, 10));
    }

    [Test]
    public void ContentCanBeSet()
    {
        Bucket bucket = new Bucket(2500, 10);
        bucket.Content = 20;
        Assert.That(bucket.Content, Is.EqualTo(20));
    }
    
    [Test]
    public void AddContentWithFillFunction()
    {
        Bucket bucket = new Bucket(2500, 10);
        bucket.Fill(20);
        Assert.That(bucket.Content, Is.EqualTo(30));
    }
    
    [Test]
    public void AddContentWithFillFunctionOverCapacity()
    {
        Bucket bucket = new Bucket(2500, 2490);
        bucket.Fill(20);
        Assert.That(bucket.Content, Is.EqualTo(2490));
    }
    
    [Test]
    public void AddContentWithFillFunctionCheckEventIsSend()
    {
        Bucket bucket = new Bucket(2500, 10);
        bucket.Full += (sender, args) => Assert.Pass();
        bucket.Fill(2490);
        Assert.Fail();
    }
    
    [Test]
    public void AddContentWithFillFunctionOverCapacityCheckEventIsSend()
    {
        Bucket bucket = new Bucket(2500, 2490);
        bucket.Overflowed += (sender, args) =>
        {
            if (args.OverflowAmount == 10)
            {
                Assert.Pass();
            }
        };
        bucket.Fill(20);
        Assert.Fail();
    }
    
    [Test]
    public void RemoveContentWithEmptyFunction()
    {
        Bucket bucket = new Bucket(2500, 30);
        bucket.Empty(20);
        Assert.That(bucket.Content, Is.EqualTo(10));
    }
    
    [Test]
    public void RemoveContentWithEmptyFunctionOverContent()
    {
        Bucket bucket = new Bucket(2500, 30);
        Assert.Throws<ValueOutOfBoundsExeption>(() => bucket.Empty(40));
    }
    
    [Test]
    public void EmptyBucket()
    {
        Bucket bucket = new Bucket(2500, 30);
        bucket.Empty();
        Assert.That(bucket.Content, Is.EqualTo(0));
    }
    
    [Test]
    public void CapacityCantBeLowerThan10()
    {
        Assert.Throws<ValueOutOfBoundsExeption>(() => new Bucket(5, 10));
    }
    
    [Test]
    public void BucketCanBeCreatedWithDefaultValues()
    {
        Bucket bucket = new Bucket();
        Assert.That(bucket.Capacity, Is.EqualTo(12));
        Assert.That(bucket.Content, Is.EqualTo(0));
    }
    
    [Test]
    public void BucketCanBeFilledWithAnotherBucket()
    {
        Bucket bucket = new Bucket(2500, 10);
        Bucket bucket2 = new Bucket(2500, 20);
        bucket.fillWithBucket(bucket2);
        Assert.That(bucket.Content, Is.EqualTo(30));
        Assert.That(bucket2.Content, Is.EqualTo(0));
    }
    
}