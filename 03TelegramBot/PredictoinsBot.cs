using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace _03TelegramBot
{
    internal class PredictionsBot
    {
        private Answer answer = new Answer();
        private TelegramBotClient botclient;
        public PredictionsBot(string token)
        {
            botclient = new TelegramBotClient(token);
        }
        public void Start()
        {
            botclient.StartReceiving(updateHandler: Updatehandler,
                                    pollingErrorHandler:PollingError);
        }

        private Task PollingError(ITelegramBotClient telegramBot, 
                                  Exception exception, 
                                  CancellationToken token)
        {
            Console.WriteLine("Error");
            return Task.CompletedTask;
        }

        private async Task Updatehandler(ITelegramBotClient clientbot, 
                                         Update update, 
                                         CancellationToken token)
        {
            string message = update.Message.Text;
            var id = update.Message.From.Id;
            if(message== "/start")
            {
                string massege = 
                    "It's a predictionsbot, to recieve an answar " +
                    "plese write your question.";
                await botclient.SendTextMessageAsync(id, massege);
                return;
            }

            await botclient.SendTextMessageAsync(id, answer.Chose());
        }
    }
    
}
