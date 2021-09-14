using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmWeatherApp.Models
{
    public class Sys
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }
}
