public class CreditCard
{
    string number;

    public CreditCard(string number)
    {
        this.number = number;
    }

    public string info()
    {
        return "CreditCard with number " + number;
    }
}