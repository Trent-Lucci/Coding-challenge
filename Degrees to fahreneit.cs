// See https://aka.ms/new-console-template for more information
//Converting to Celcius

using System;

public class TemperatureConverter
{
    public static void ConvertFahrenheitToCelsius(int fahrenheit)
    {
        decimal temperature = ((fahrenheit - 32) * 5m / 9m);
        Console.WriteLine("The temperature is " + Math.Round(temperature) + " degrees celsius");
    }
    public static void Main(string[] args)
    {
        ConvertFahrenheitToCelsius(94);
    }
}