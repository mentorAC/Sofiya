namespace _03TelegramBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";
            PredictionsBot bot = new PredictionsBot(token);
            bot.Start();
            Console.ReadLine();
        }
    }
}