using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TemperatureConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITempSvc" in both code and config file together.
    [ServiceContract]
    public interface ITempSvc
    {
        [OperationContract]
        double FahrenheitToCelsius(double f);
    }
}
