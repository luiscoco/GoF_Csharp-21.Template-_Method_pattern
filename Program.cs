using System;

class Program
{
    static void Main(string[] args)
    {
        BeverageTemplate tea = new Tea();
        BeverageTemplate coffee = new Coffee();

        Console.WriteLine("Making tea...");
        tea.PrepareBeverage();

        Console.WriteLine("\nMaking coffee...");
        coffee.PrepareBeverage();
    }
}

// Abstract base class defining the template method
abstract class BeverageTemplate
{
    public void PrepareBeverage()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    protected void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    protected abstract void Brew();

    protected void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    protected abstract void AddCondiments();
}

// Concrete subclass for tea
class Tea : BeverageTemplate
{
    protected override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }
}

// Concrete subclass for coffee
class Coffee : BeverageTemplate
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping coffee through filter");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding sugar and milk");
    }
}
