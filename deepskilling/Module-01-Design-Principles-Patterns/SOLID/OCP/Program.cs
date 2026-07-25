using System;

interface IPayment
{
    void Pay();
}

class CreditCardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment made using Credit Card");
    }
}

class UpiPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment made using UPI");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment1 = new CreditCardPayment();
        payment1.Pay();

        IPayment payment2 = new UpiPayment();
        payment2.Pay();
    }
}