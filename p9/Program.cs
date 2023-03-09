using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p9
{
    class Program
    {
        public static double celsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double fahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Celsius value: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Fahrenheit value: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius to fahrenheit: ");
            Console.WriteLine("Celcius: " + celsius + "\nFahrenheit: "
            + celsiusToFahrenheit(celsius));
            Console.WriteLine("Fahrenheit to Celsius: ");
            Console.WriteLine("Fahrenheit: " + fahrenheit + "\nCelsius: "
            + fahrenheitToCelsius(fahrenheit));
            Console.ReadLine();
        }
    }
}
