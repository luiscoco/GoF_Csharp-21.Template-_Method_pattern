# GoF_Csharp-21.Template-_Method_pattern

The Template Method Pattern is a behavioral design pattern that defines the structure of an algorithm while allowing subclasses to provide specific implementations for certain steps of that algorithm. This pattern promotes code reusability and flexibility by providing a common structure that can be customized by subclasses.

Here's a simple explanation of the Template Method Pattern:

Define an abstract base class that contains the overall algorithm structure. This class contains one or more template methods that outline the steps of the algorithm. Some of these steps can be left abstract, allowing subclasses to provide their own implementations.

Concrete subclasses extend the base class and provide implementations for the abstract steps. These implementations are specific to each subclass, allowing them to customize the behavior of the algorithm.

The template methods in the base class call the abstract and concrete methods as needed to execute the algorithm.

```csharp
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
```













