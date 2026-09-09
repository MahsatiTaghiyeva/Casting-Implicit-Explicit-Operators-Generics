public class Farenheit
{
    public double Degree {get; set;}
    public Farenheit(double degree)
    {
        Degree = degree;   
    }
    public static explicit operator Celsius(Farenheit farenheit)
    {
        return new Celsius((farenheit.Degree-32)*5/9 );
    }
}