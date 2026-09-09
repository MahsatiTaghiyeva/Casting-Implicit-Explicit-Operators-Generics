public class Gram
{
    public double Amount {get; set;}
    public Gram(double amount)
    {
        Amount = amount;
    }
    public static explicit operator Kilogram(Gram amount)
    {
        return new Kilogram(amount.Amount/1000);
    }
}