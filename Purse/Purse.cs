using System;

class Purse
{
    static public void Main()
    {
        Console.WriteLine("Purse project is running...");

        BusinessCard businessCard = new BusinessCard("1234567890");
        Console.WriteLine(businessCard.info());

        Money money = new Money(300);
        Console.WriteLine(money.HowMuch());

        CreditCard creditCard = new CreditCard("0904623442");
        Console.WriteLine(creditCard.info());

        Console.Read();
    }
}