using System.Dynamic;
using Emmer_opdracht.Expetions;

namespace Emmer_opdracht;



public abstract class Container
{
    //events
    
    //overflow event
    public class OverflowedEventArgs : EventArgs
    {
        public int OverflowAmount { get; }

        public OverflowedEventArgs(int overflowAmount)
        {
            OverflowAmount = overflowAmount;
        }
    }
    public delegate void OverflowedEventHandler(object sender, OverflowedEventArgs args);
    
    public event OverflowedEventHandler Overflowed;
    
    protected virtual void OnOverflowed(int overflowAmount)
    {
        Overflowed?.Invoke(this, new OverflowedEventArgs(overflowAmount));
    }
    
    //full event
    public delegate void FullEventHandler(object sender, EventArgs e);
    
    public event FullEventHandler Full;
    protected virtual void OnFull()
    {
        Full?.Invoke(this, EventArgs.Empty);
    }
    
    //arguments
    private int _capacity;
    
    public int Capacity
    {
        get
        {
            return _capacity;
        }
        set
        {
            if (value >= 0)
            {
                _capacity = value;
            }
        }
    }

    private int _content;
    
    public int Content
    {
        get
        {
            return _content;
        }
        set
        {
            if (value >= 0)
            {
                _content = value;
            }
            else
            {
                throw new ValueOutOfBoundsExeption("Value can not be negative");
            }
        }
    }
    
    
    
    
    public void Empty()
    {
        this.Empty(Content);
    }
    
    public void Empty(int amount)
    {
        Content -= amount;
    }

    public void Fill(int amount)
    {
        if (Content + amount == (int)Capacity)
        {
            OnFull();
        }

        if (Content + amount > (int)Capacity)
        {
            int overflow = (Content + amount) - (int)Capacity;
            Content = (int)Capacity;
            OnOverflowed(overflow);
        }
        
        if (Content + amount <= (int)Capacity)
        {
            Content += amount;
        }
        
    }


   
}