namespace Emmer_opdracht.Expetions;

public class ValueOutOfBoundsExeption : Exception
{
    public ValueOutOfBoundsExeption()
    {
    }

    public ValueOutOfBoundsExeption(string message)
        : base(message)
    {
    }

    public ValueOutOfBoundsExeption(string message, Exception inner)
        : base(message, inner)
    {
    }
}