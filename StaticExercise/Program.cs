namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The Celsius of 212F is : ");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(212));
            Console.Write("The Fahrenheit of 100C is : ");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(100));
        }
    }
}
