using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TemperatureConversionService
{
    [DataContract]
    public class TemperatureCelsius
    {
        [DataMember]
        public double Value { get; set; }

        [DataMember]
        public DateTime DateComputed { get; set; }
    }
}