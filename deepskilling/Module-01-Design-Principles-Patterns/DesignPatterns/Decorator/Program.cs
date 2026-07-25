using System;

interface ICoffee
{
    string GetDescription();
}

class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }
}

class MilkDecorator : ICoffee
{
    private ICoffee coffee;

    public MilkDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public string GetDescription()
    {
        return coffee.GetDescription() + " + Milk";
    }
}

class SugarDecorator : ICoffee
{
    private ICoffee coffee;

    public SugarDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public string GetDescription()
    {
        return coffee.GetDescription() + " + Sugar";
    }
}

class Program
{
    static void Main()
    {
        ICoffee coffee = new SimpleCoffee();

        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);

        Console.WriteLine(coffee.GetDescription());
    }
}