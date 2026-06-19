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
