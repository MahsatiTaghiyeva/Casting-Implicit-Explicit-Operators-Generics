public class Celsius
{
    public double Degree { get; set;}
    public Celsius(double degree)
    {
        Degree = degree;
    }
    public static implicit operator Kelvin(Celsius degree)
    {
        return new Kelvin(degree.Degree + 273);
    }
}