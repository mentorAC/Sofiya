using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace _04TelegramBot
{
    internal class ButtonBot
    {
        private TelegramBotClient botclient;  
        public ButtonBot(string token)
        {
            botclient = new TelegramBotClient(token);
        }
        public void Start()
        {
            botclient.StartReceiving(updateHandler: UpdateHandler, pollingErrorHandler: Erorhandler);
        }

        private Task Erorhandler(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            Console.WriteLine("Error");
            return Task.CompletedTask;
        }

        private async Task UpdateHandler(ITelegramBotClient arg1, Update update, CancellationToken arg3)
        {
            // /start
            string messege = update.Message.Text;

            var id = update.Message.From.Id;
            #region Task1
            //if(messege == "/start")
            //{
            //    KeyboardButton[][] keyboardButtons =
            //    {
            //        new KeyboardButton[] {"Button1", "Button2", "Button3" },
            //        new KeyboardButton[] {"Button4"},
            //        new KeyboardButton[] {"Button5", "Button6" }
            //    };

            //    ReplyKeyboardMarkup replyKeyboard = new ReplyKeyboardMarkup(keyboardButtons)
            //    {
            //        ResizeKeyboard = true
            //    };

            //    await botclient.SendTextMessageAsync(id, "Your buttons:", replyMarkup: replyKeyboard);

            //    #region Matrix
            //    //int[,] matrix = new int[10, 10];
            //    //int[][] nums = new int[3][];
            //    //nums[0] = new int[2];
            //    //nums[1] = new int[5];
            //    //nums[2] = new int[6];

            //    //int[][] nums =
            //    //{
            //    //    new int[]{1,2,3 },
            //    //    new int[]{1 },
            //    //    new int[]{1,2,3 }
            //    //};
            //    #endregion
            //}
            //else if(messege == "Button1")
            //{
            //    await botclient.SendTextMessageAsync(id, "Your click on first button!");
            //}
            #endregion
            if(messege == "/start")
            {
                KeyboardButton[][] button =
                {
                    new KeyboardButton[]{ "Time⌚️", "Date📅" },
                    new KeyboardButton[]{ "📅DataTime⌚️" }
                };
                ReplyKeyboardMarkup reply = new ReplyKeyboardMarkup(button)
                {
                    ResizeKeyboard = true
                };
                await botclient.SendTextMessageAsync(id, "Your botons:", replyMarkup: reply);
                
            }
            if(messege == "Time⌚️")
            {
                DateTime time = DateTime.Now;
                
                await botclient.SendTextMessageAsync(id, time.ToString("hh:mm:ss"));
                //string time = DateTime.Now.ToString("hh:mm:ss");
            }
            if(messege == "Date📅")
            {
                DateTime date = DateTime.Now;
                await botclient.SendTextMessageAsync(id, date.ToString("dd.MM.yy"));
            }
            if (messege == "📅DataTime⌚️")
            {
                DateTime datetime = DateTime.Now;
                await botclient.SendTextMessageAsync(id, datetime.ToString("hh:mm:ss dd.MM.yy"));
            }
            //Time | Date
            // DateTime
        }
    }

    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
