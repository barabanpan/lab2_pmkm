using System;

class Purse
{
    static public void Main()
    {
        Console.WriteLine("Purse project is running...");

        CreditCard creditCard = new CreditCard("0904623442");
        Console.WriteLine(creditCard.info());

        Console.Read();
    }
}