namespace _04TelegramBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";
            ButtonBot buttonbot = new ButtonBot(token);
            buttonbot.Start();
            Console.ReadLine();

        }
    }
}