using Emmer_opdracht.Expetions;

namespace Emmer_opdracht;

public class Bucket : Container
{
    public int Capacity => base.Capacity;

    public Bucket() : this(12,0)
    {
    }
    
    public Bucket(int capacity) : this(capacity,0)
    {
    }
    
    public Bucket(int capacity, int content)
    {
        if (capacity < 10)
        {
            throw new ValueOutOfBoundsExeption($"capacity value ({capacity}) too low capacity value must be between 10 and 2500");
        } 
        
        if (capacity > 2500)
        {
            throw new ValueOutOfBoundsExeption($"capacity value ({capacity}) too high capacity value must be between 10 and 2500");
        }

        if (content < 0)
        {
            content = 0;
        }

        if (capacity < content)
        {
            throw new ValueOutOfBoundsExeption($"content value ({content}) too high for capacity value ({capacity})");
        }
        
        base.Capacity = capacity;
        Content = content;
    }

    public void fillWithBucket(Bucket bucket)
    {
        if (bucket.Content + this.Content <= this.Capacity)
        {
            this.Content += bucket.Content;
            bucket.Content = 0;
        }
        else
        {
            new ValueOutOfBoundsExeption("capacity value too low to add bucket's content");
        }
    }
}