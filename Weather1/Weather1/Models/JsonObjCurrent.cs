using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Weather1.Models
{
    public class JsonObjCurrent
    {
        public coord Coord { get; set; }
        public List<weather> weather { get; set; }
        [JsonProperty("base")]
        public string _base { get; set; }
        public main main { get; set; }
        public int visibility { get; set; }
        public wind wind { get; set; }
        public clouds clouds { get; set; }
        public long dt { get; set; }
        public sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }

    }

    public class coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }
    public class weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
    public class main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }
    public class wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }
    public class clouds
    {
        public int all { get; set; }
    }
    public class sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }
    }
}