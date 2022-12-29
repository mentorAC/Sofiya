using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Les15
{
    internal class GetInfo
    {
        public WeatherInfo WeatherInfo(string lan, string lon)
        {
            string requestUrl = $"https://api.openweathermap.org/data/2.5/weather?lat={lan}&lon={lon}&appid=27a89482475ba4710adb1f994183253d&units=metric";
            var request = WebRequest.Create(requestUrl);
            var response = request.GetResponse();
            string answer;
            using (StreamReader streamreader = new StreamReader(response.GetResponseStream()))
            {
                answer = streamreader.ReadToEnd();
            }
            WeatherInfo weather = JsonConvert.DeserializeObject<WeatherInfo>(answer);
            return weather;
        }
    }
}
