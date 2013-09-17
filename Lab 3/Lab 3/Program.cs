using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3
{
    /// <summary>
    /// Convert temperature from F to C
    /// </summary>
    class Program
    {
        /// <summary>
        /// Convert temp from F to C
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // ask for temperature
            Console.Write("Enter temperature (F): ");
            float originalFahrenheit = float.Parse(Console.ReadLine());

            // convert temperatures
            float celsius = convertFahrenheitToCelsius(originalFahrenheit);
            float fahrenheit = convertCelsiusToFahrenheit(celsius);

            // output results
            Console.WriteLine("Celsius: " + celsius);
            Console.WriteLine("Fahrenheit: " + fahrenheit);
        }

        /// <summary>
        /// Convert temperature from F to C
        /// </summary>
        /// <param name="originalFahrenheit">Temperature in Fahrenheit</param>
        /// <returns>Temperature in Celsius</returns>
        private static float convertFahrenheitToCelsius(float originalFahrenheit)
        {
            return (originalFahrenheit - 32) / 9 * 5;
        }

        /// <summary>
        /// Convert temperature from C to F
        /// </summary>
        /// <param name="originalCelsius">Temperature in Celsius</param>
        /// <returns>Temperature in Fahrenheit</returns>
        private static float convertCelsiusToFahrenheit(float originalCelsius)
        {
            return originalCelsius * 9 / 5 + 32;
        }
    }
}
