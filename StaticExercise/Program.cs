namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Celsius = TempConverter.FahrenheitToCelsius(212);
            Console.WriteLine($"{Celsius} degrees Celsius");

            Console.WriteLine();

            var Fahrenheit = TempConverter.CelsiusToFahrenheit(100);
            Console.WriteLine($"{Fahrenheit} degrees Fahrenheit");
        }
    }
    public static class TempConverter
    {
        public static double FahrenheitToCelsius (double F)
        {
            return ((F - 32) * 5/9);
        }   
        public static double CelsiusToFahrenheit (double C)
        {
            return (C * 9/5 + 32);
        }
    }
}
