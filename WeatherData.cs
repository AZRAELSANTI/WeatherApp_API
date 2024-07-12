using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp_API
{
    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

    }
    public class Current
    {
        [JsonProperty("temp_c")]
        public double TempC { get; set; }
        [JsonProperty("condition")]
        public double Condition { get; set; }
        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }
        [JsonProperty("humidity")]
        public double Humidity { get; set; }
    }
    public class Condition {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
    public class WeatherData
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("current")]
        public Current Current { get; set; }
    }
}
