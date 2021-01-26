using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Weather1.Models
{
    public class WeatherCurrentModel
    {
        public string City { get; set; }
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public double Wind_Speed { get; set; }
        public int Cloudy { get; set; }
    }
}
