using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;

namespace _05TelegramBot
{
    internal class Telegramsend
    {
        TelegramBotClient botClient;
        string filename = "clients.txt";
        public Telegramsend(string token )
        {
            botClient = new TelegramBotClient(token);


        }
        public void Start()
        {

            botClient.StartReceiving(updateHandler: updateHandler,pollingErrorHandler: pollingErrorHandler);
            if (!System.IO.File.Exists(filename))
            {
               System.IO.File.Create(filename).Close();
            }
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
        private async Task updateHandler(ITelegramBotClient arg1, Update arg2, CancellationToken arg3)
        {
            var id = arg2.Message.From.Id;
            if(arg2.Message.Text == "/start")
            {
                string[] fileread = System.IO.File.ReadAllLines(filename);
                bool isExist = false;
                for(int i = 0; i < fileread.Length; i++)
                {
                    if (fileread[i]== id.ToString())
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist == false)
                {
                    //System.IO.File.AppendAllText(filename, id.ToString()+"\n") ;
                    System.IO.File.AppendAllText(filename, $"{id}\n");
                }
            }
        }

        public async void TextSend(string sendtext)
        {
            string[] filelines = System.IO.File.ReadAllLines(filename);

            for (int i = 0; i < filelines.Length; i++)
            {
                try
                {
                    await botClient.SendTextMessageAsync(filelines[i], sendtext);
                }
                catch { }
            }
            
        }
    }
}
