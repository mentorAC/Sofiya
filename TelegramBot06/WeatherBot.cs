using Les15;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace _06TelegramBot
{
    internal class WeatherBot
    {
        TelegramBotClient botClient;
        GetInfo GetInfo;
        public WeatherBot(string token)
        {
            botClient = new TelegramBotClient(token);
            GetInfo = new GetInfo();    //создаем обьект для запросов
        }
        public void Start()
        {
            botClient.StartReceiving(updateHandler: updateHandler, pollingErrorHandler: pollingErrorHandler);
        }

        private Task pollingErrorHandler(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            Console.WriteLine("Error!");
            return Task.CompletedTask;
        }
        public async void Getinf()
        {
            var inform = await botClient.GetMeAsync();
            Console.WriteLine($"{inform}");
        }
        private async Task updateHandler(ITelegramBotClient arg1, Update update, CancellationToken arg3)
        {
            if(update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Location)    //проверяем, если тип сообщение  это локация
            {
                var lon = update.Message.Location.Longitude.ToString(); //получаем долготу и широту в отдельные переменные
                var lat = update.Message.Location.Latitude.ToString();

                var weather = GetInfo.WeatherInfo(lat, lon);    //делвем завпро

                //отправляем пользователю результат в виде сообщени 
                string message = $"Tempreture: {weather.main.temp}\n Max: {weather.main.temp_max}\n Min{weather.main.temp_min}\n City: {weather.name}"; ;
                botClient.SendTextMessageAsync(update.Message.From.Id, message);
            }
        }


    }
}
