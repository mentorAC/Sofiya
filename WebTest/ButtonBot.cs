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
            //    //создаем зупчастый массив кнопок
            //    KeyboardButton[][] keyboardButtons =
            //    {
            //        new KeyboardButton[] {"Button1", "Button2", "Button3" },
            //        new KeyboardButton[] {"Button4"},
            //        new KeyboardButton[] {"Button5", "Button6" }
            //    };
            //      
            //    //создаем обьект клавиатуры кнопок
            //    ReplyKeyboardMarkup replyKeyboard = new ReplyKeyboardMarkup(keyboardButtons)
            //    {
            //        //устанавливаем настройку изменения размера клавиатуры
            //        ResizeKeyboard = true
            //    };
            //    //replyMarkup: replyKeyboard отправляем клавиатуру кнопок
            //    await botclient.SendTextMessageAsync(id, "Your buttons:", replyMarkup: replyKeyboard);

            //    #region Matrix
            //    //int[,] matrix = new int[10, 10];    //обычный массив
            //    //int[][] nums = new int[3][];        //зубчастый массив
            //    //nums[0] = new int[2];               //это массив у которого в строках модет быть разное ко-во елементов 
            //    //nums[1] = new int[5];
            //    //nums[2] = new int[6];

            //    //еще пример зупчастого массива
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
            if (messege == "/start")
            {
                //выше описано
                //+ для оформления мы легко можем использовать смайлы
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
            //обработка нажатия - это обработка сообщения бота, сообщение будет с текстом
            //названия кнопки
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
        }
    }

    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
