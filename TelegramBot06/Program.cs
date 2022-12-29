using _06TelegramBot;

namespace TelegramBot06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";
            WeatherBot weatherbot = new WeatherBot(token);
            weatherbot.Start();
            weatherbot.Getinf();

            Console.ReadLine();
        }
    }
}