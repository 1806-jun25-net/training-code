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
        public double FahrenheitToCelsius(double f)
        {
            return (f-32)*5/9;
        }
    }
}
