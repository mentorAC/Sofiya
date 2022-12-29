namespace HappyNewYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string token = "5928348935:AAGqw6MDE4Xnka3P84PIfMyGpKMrBWjDr30";

            TelegramBot telegram = new TelegramBot(token);
            telegram.Status();
            telegram.Start();
            Console.ReadLine();
                
                

        }
    }
}