
using System.Runtime.CompilerServices;
using Emmer_opdracht.Expetions;

namespace Emmer_opdracht;

public class Oilbarrel : Container
{
    public int Capacity
    {
        get => base.Capacity;
    }
    public Oilbarrel() : this(0)
    {
    }
    public Oilbarrel(int content)
    {
        base.Capacity = 159;

        if (content > Capacity)
        {
            new ValueOutOfBoundsExeption($"content value ({content}) too high for capacity value ({Capacity})");
        }
     
        Content = content;
    }
}