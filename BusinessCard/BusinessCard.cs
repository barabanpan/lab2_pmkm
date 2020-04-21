public class BusinessCard
{
    string number;

    public BusinessCard(string number)
    {
        this.number = number;
    }

    public string info()
    {
        return "BusinessCard witn number " + number;
    }
}