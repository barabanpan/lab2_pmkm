﻿public class Money
{
    double amount;

    public Money(double amount)
    {
        this.amount = amount;
    }
    public string HowMuch()
    {
        return "Money:" + amount;
    }
}