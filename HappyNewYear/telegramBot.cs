using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace HappyNewYear
{
    internal class TelegramBot
    {
        TelegramBotClient telegramBot;      //бот 
        string action;                      //ожидаемое действие пользователя
        string videoLink;                   //ссылка на видео
        public TelegramBot(string token)    //конструктор, который принемает токен
        {
            telegramBot = new TelegramBotClient(token);
        }
        public async void Status()          //получаем статус бота
        {
            var botInfo = await telegramBot.GetMeAsync();
            Console.WriteLine(botInfo.Id);
        }
        public void Start()                 //запускаем бота
        {
            telegramBot.StartReceiving(UpdateHandler, PoolingErrorHandler);
        }

        private Task PoolingErrorHandler(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            Console.WriteLine("Error");
            return Task.CompletedTask;
        }

        private async Task UpdateHandler(ITelegramBotClient botClient, Update update, CancellationToken ct)
        {
            if(action == "Set Video Link")  //если от пользователя ождается ссылка на бот
            {
                videoLink = update.Message.Text;    //устанавливаем ссылку, которая находится в сообщении
                action = "";                        //обнуляем действие
            }

            if (update.Message.Text == "/start")    //если это первый вход в бота
            {
                StartCommand(update);
            }
            else if(update.Message.Text == "Open Console")  //открываем консоль
            {
                ConsoleManager.Show();
            }
            else if(update.Message.Text == "Close Console") //закрываем консоль
            {
                ConsoleManager.Hide();
            }
            else if(update.Message.Text=="Set Video Link")  //кнопка установки видео
            {
                action = update.Message.Text;
            }
        }
        private async Task StartCommand(Update update)
        {
            KeyboardButton[][] keyboardButtons =    //создаем кнопки
               {
                    new KeyboardButton[]{"Open Console", "Close Console"},
                    new KeyboardButton[]{"Set Video Link"}
                };
            var replyKeyboardMarkup = new ReplyKeyboardMarkup(keyboardButtons)
            {
                ResizeKeyboard = true
            };

            await telegramBot.SendTextMessageAsync(chatId: update.Message.From.Id,  //отправляем кнопки
                                           text: "Hi",
                                           replyMarkup: replyKeyboardMarkup);
        }
    }
}
