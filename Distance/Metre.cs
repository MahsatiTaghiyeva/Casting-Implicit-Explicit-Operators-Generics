public class Metre
{
    public double Value {get; set;}
    public Metre(double value)
    {
        Value = value;
    }
    public static implicit operator Kilometre(Metre metre)
    {
        return new Kilometre(metre.Value / 1000);
    }
}