using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmWeatherApp.Util
{
    public static class Converter
    {
        public static string DegToCompass(int degrees)
        {
            var compArr =new string[] {"N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", 
                "W", "WNW", "NW", "NNW" };

            int value = Convert.ToInt32(Math.Floor(degrees / 22.5 + 0.5));
            return compArr[value % 16];
        }

        public static int CelsiusToFarenheit(int celsius) => ((celsius*9)/5 +32);

        public static string MpsToMph(int mps) => (mps * 2.236936).ToString("n2");
        public static string KmtoMiles(int km) => (km /1.609).ToString("n2");

        public static DateTime UnixTimeStampToDateTime(int unixTimeStamp, int timezone )
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp + timezone);
            return dtDateTime;
        }

        public static string KelvinToCelsius(double temp) => (Convert.ToInt32(temp - 273.15)).ToString();
        public static string KelvinToFarenheit(double temp) => CelsiusToFarenheit(Convert.ToInt32(temp - 273.15)).ToString();

        //public static string UnixTimeStampToDayOfWeek(int unixTimeStamp, int timezone)

    }
}
