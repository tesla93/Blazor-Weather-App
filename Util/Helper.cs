using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorWasmWeatherApp.Util
{
    public static class Helper
    {
        public static JsonSerializerOptions defaultJsonSerializerOptions =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        private static async Task<T> Deserialize<T>(HttpResponseMessage httpResponse)
        {
            var responseString = await httpResponse?.Content.ReadAsStringAsync() ?? "";
            return JsonSerializer.Deserialize<T>(responseString, defaultJsonSerializerOptions);
        }

    }

   
}
