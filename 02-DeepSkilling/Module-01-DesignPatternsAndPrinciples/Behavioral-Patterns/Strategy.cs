using System;

interface IPaymentStrategy
{
    void Pay();
}

class CreditCardPayment : IPaymentStrategy
{
    public void Pay()
    {
        Console.WriteLine("Paid using Credit Card");
    }
}
