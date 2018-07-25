using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TemperatureConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TempSvc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TempSvc.svc or TempSvc.svc.cs at the Solution Explorer and start debugging.
    public class TempSvc : ITempSvc
    {
        public void DoWork()
        {
        }

        public TemperatureCelsius FahrenheitToCelsius(TemperatureFahrenheit f)
        {
            var result = new TemperatureCelsius
            {
                Value = (f.Value - 32) * 5 / 9,
                DateComputed = DateTime.Now
            };
            return result;
        }
    }
}
