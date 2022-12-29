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
            //строка запросов
            string requestUrl = $"https://api.openweathermap.org/data/2.5/weather?lat={lan}&lon={lon}&appid=    !!!API_KEY!!!!    &units=metric";
            //создаем запрос по созданной ссылке
            var request = WebRequest.Create(requestUrl);
            //получаем ответ 
            var response = request.GetResponse();
            string answer;
            //вытягиваем строку ответа из обьекта ответа
            using (StreamReader streamreader = new StreamReader(response.GetResponseStream()))
            {
                answer = streamreader.ReadToEnd();
            }
            //десериализуем строку джейсона в обькт типа WeatherInfo
            WeatherInfo weather = JsonConvert.DeserializeObject<WeatherInfo>(answer);
            return weather;
        }
    }
}
