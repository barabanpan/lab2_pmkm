using System;

class Purse
{
    static public void Main()
    {
        Console.WriteLine("Purse project is running...");

        Money money = new Money(300);
        Console.WriteLine(money.HowMuch());

        Console.Read();
    }
}