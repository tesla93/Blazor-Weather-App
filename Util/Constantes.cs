using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmWeatherApp.Util
{
    public static class Constantes
    {
        public const string API_KEY = "bbf85e7bb336fd76f6356bfb4e8e3fd0";
        public const string PRIMARY_CITY = "Holguin";

        public const string URL_API_WEATHER = "api.openweathermap.org/data/2.5/weather?q=${input}&units=metric&appid=${API_KEY}";
    }
}
