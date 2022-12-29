using System.Globalization;

namespace _05TelegramBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";
            Telegramsend telegrambot = new Telegramsend(token);
            telegrambot.Start();
            telegrambot.Getinf();
            string data = Console.ReadLine();
            telegrambot.TextSend(data);

            Console.ReadLine();
        }
    }
}