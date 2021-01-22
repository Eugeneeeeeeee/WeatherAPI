using System;
using System.Collections.Generic;

namespace Weather1
{
    public class WeatherForecastModel
    {
        public string City { get; set; }
        public DateTime Date { get; set; }
        public double Temperature_min { get; set; }
        public double Temperature_max { get; set; }
        public double Wind_Speed { get; set; }
        public int Cloudy { get; set; }
    }
}