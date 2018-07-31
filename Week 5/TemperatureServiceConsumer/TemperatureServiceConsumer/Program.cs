using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureServiceConsumer.TempSvc;

namespace TemperatureServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new TempSvcClient())
            {
                var input = new TemperatureFahrenheit { Value = 50 }; // deg fahrenheit
                TemperatureCelsius result = client.FahrenheitToCelsius(input);
                Console.WriteLine($"F: ({input.Value}, {input.DateComputed})," +
                    $" C: ({result.Value}, {result.DateComputed})");
            }
        }
    }
}
