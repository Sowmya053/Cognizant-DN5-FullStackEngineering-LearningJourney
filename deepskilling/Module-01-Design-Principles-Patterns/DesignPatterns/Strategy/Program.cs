using System;

interface IPaymentStrategy
{
    void Pay(int amount);
}

class CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Credit Card");
    }
}

class UpiPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paid ₹{amount} using UPI");
    }
}

class ShoppingCart
{
    private IPaymentStrategy paymentStrategy;

    public ShoppingCart(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void Checkout(int amount)
    {
        paymentStrategy.Pay(amount);
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart1 = new ShoppingCart(new CreditCardPayment());
        cart1.Checkout(1000);

        ShoppingCart cart2 = new ShoppingCart(new UpiPayment());
        cart2.Checkout(500);
    }
}