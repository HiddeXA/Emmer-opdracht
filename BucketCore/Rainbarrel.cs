using Emmer_opdracht.Expetions;

namespace Emmer_opdracht;

public class Rainbarrel : Container
{
    public int Capacity
    {
        get => base.Capacity;
    }
    public Rainbarrel(CapacitySizes capacity) : this(capacity, 0)
    {
    } 
    
    public Rainbarrel(CapacitySizes capacity, int content)
    {
        base.Capacity = (int)capacity;
        if (Capacity <= (int)capacity)
        {
            Content = content;
        }
        else
        {
            // Content = 0;
            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.WriteLine($"capacity value too low for content setting content to: {Content}");
            // Console.ResetColor();
            new ValueOutOfBoundsExeption($"content value ({content}) too high for capacity value ({Capacity})");
        }
    }

    public enum CapacitySizes
    {
        Small = 80,
        Medium = 100,
        Large = 120,
    }
}