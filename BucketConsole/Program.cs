using Emmer_opdracht;

Console.WriteLine("f1");
Bucket bucket = new();
Oilbarrel oilbarrel = new(100);
Rainbarrel rainbarrel = new(Rainbarrel.CapacitySizes.Medium);

Console.WriteLine(bucket.Capacity);
Console.WriteLine(oilbarrel.Capacity);
Console.WriteLine(rainbarrel.Capacity);

Console.WriteLine("f2");

bucket.Content = 300;
oilbarrel.Content = 132;
rainbarrel.Content = 2;

Console.WriteLine(bucket.Content);
Console.WriteLine(oilbarrel.Content);
Console.WriteLine(rainbarrel.Content);

Console.WriteLine("f3");
    
bucket = new(-10,-100);
oilbarrel = new(-100);
rainbarrel = new(Rainbarrel.CapacitySizes.Small);

Console.WriteLine(bucket.Content);
Console.WriteLine(oilbarrel.Content);
Console.WriteLine(rainbarrel.Content);

Console.WriteLine("f4");
bucket = new(3000,4000);
Console.WriteLine(bucket.Content);
Console.WriteLine(bucket.Capacity);

Console.WriteLine("f5");

Console.WriteLine(bucket.Content);
Console.WriteLine(oilbarrel.Content);
Console.WriteLine(rainbarrel.Content);

Console.WriteLine(bucket.Capacity);
Console.WriteLine(oilbarrel.Capacity);
Console.WriteLine(rainbarrel.Capacity);

Console.WriteLine("f6");

Console.WriteLine(bucket.Content);
Console.WriteLine(oilbarrel.Content);
Console.WriteLine(rainbarrel.Content);

bucket.Content = 400;
oilbarrel.Content = 410;
rainbarrel.Content = 432;

Console.WriteLine(bucket.Content);
Console.WriteLine(oilbarrel.Content);
Console.WriteLine(rainbarrel.Content);

Console.WriteLine("f7");

bucket = new(1000, 50);
oilbarrel = new(50);
rainbarrel = new(Rainbarrel.CapacitySizes.Large, 50);

Console.WriteLine(bucket.Content);
Console.WriteLine(oilbarrel.Content);
Console.WriteLine(rainbarrel.Content);

bucket.Fill(20);
oilbarrel.Fill(20);
rainbarrel.Fill(20);

Console.WriteLine(bucket.Content);
Console.WriteLine(oilbarrel.Content);
Console.WriteLine(rainbarrel.Content);

bucket.Empty(10);
oilbarrel.Empty(14);
rainbarrel.Empty(13);

Console.WriteLine(bucket.Content);
Console.WriteLine(oilbarrel.Content);
Console.WriteLine(rainbarrel.Content);

Console.WriteLine("f8");

bucket.Empty();
oilbarrel.Empty();
rainbarrel.Empty();

Console.WriteLine(bucket.Content);
Console.WriteLine(oilbarrel.Content);
Console.WriteLine(rainbarrel.Content);

Console.WriteLine("f9");

bucket = new();

Console.WriteLine(bucket.Capacity);

bucket = new(4);

Console.WriteLine(bucket.Capacity);

Console.WriteLine("f10");
oilbarrel = new();
Console.WriteLine(oilbarrel.Capacity);

Console.WriteLine("f11");
rainbarrel = new(Rainbarrel.CapacitySizes.Small);
Console.WriteLine(rainbarrel.Capacity);

rainbarrel = new(Rainbarrel.CapacitySizes.Medium);
Console.WriteLine(rainbarrel.Capacity);

rainbarrel = new(Rainbarrel.CapacitySizes.Large);
Console.WriteLine(rainbarrel.Capacity);

//f12

// bucket.Capacity = 1;
// rainbarrel.Capacity = 1;
// oilbarrel.Capacity = 1;

Console.WriteLine("f13");

bucket = new(400,100);
Bucket bucket2 = new Bucket(100, 100);
bucket.fillWithBucket(bucket2);

Console.WriteLine(bucket.Content);
Console.WriteLine(bucket2.Content);





