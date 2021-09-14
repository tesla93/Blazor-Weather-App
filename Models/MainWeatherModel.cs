using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmWeatherApp.Models
{
    public class MainWeatherModel
    {
      
        public string City { get; set; }
        public string Country { get; set; }
        public string Hour { get; set; }
        public string DayOfWeek { get; set; }
        public string DescriptionWeather { get; set; }
        public string Temperature { get; set; }
        public string FeelsLike { get; set; }
        public string SrcWeatherIcon { get; set; }
    }
}
