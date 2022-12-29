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
        DateTime dateTime;
        Timer timer;
        string timeLeft;
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

        private void TimerWork(object obj)
        {
            if(DateTime.Now < dateTime)
            {
                var re = dateTime.Subtract(DateTime.Now);
                timeLeft = $"{re.Days} days {re.Hours}:{re.Minutes}:{re.Seconds}";
                return;
            }

            Sound.VulumeMax();
            StartVideo.Start(videoLink);
            timer.Dispose();
            timer = null;
        }
        private async Task UpdateHandler(ITelegramBotClient botClient, Update update, CancellationToken ct)
        {
            if(action == "Set Video Link")  //если от пользователя ождается ссылка на бот
            {
                videoLink = update.Message.Text;    //устанавливаем ссылку, которая находится в сообщении
                action = "";                        //обнуляем действие
                await telegramBot.SendTextMessageAsync(update.Message.From.Id, $"U r right!");

                return;
            }
            else if (action == "Set dateTime")
            {
                if(!DateTime.TryParse(update.Message.Text, out dateTime))
                {
                    await telegramBot.SendTextMessageAsync(update.Message.From.Id, $"You sent the wrong format of date, please resend another one in this format: {DateTime.Now} ");
                    return;
                }
                action = "";
                await telegramBot.SendTextMessageAsync(update.Message.From.Id, $"Everything is right!");
                return;
            }


            if(update.Message.Text == "Start timer!")
            {
                if(timer != null)
                {
                    timer.Dispose();
                }

                timer = new Timer(new TimerCallback(TimerWork), null, 0, 500);
            }
            else if(update.Message.Text == "Time left!")
            {
                await telegramBot.SendTextMessageAsync(update.Message.From.Id, $"Left: {timeLeft}");
            }
            else if (update.Message.Text == "/start")    //если это первый вход в бота
            {
                StartCommand(update);
            }
            else if (update.Message.Text == "Open Console")  //открываем консоль
            {
                ConsoleManager.Show();
            }
            else if (update.Message.Text == "Close Console") //закрываем консоль
            {
                ConsoleManager.Hide();
            }
            else if (update.Message.Text == "Set Video Link")  //кнопка установки видео
            {
                await telegramBot.SendTextMessageAsync(update.Message.From.Id, "I'm waiting for your video!");
                action = update.Message.Text;

            }
            else if (update.Message.Text == "Set dateTime")
            {
                await telegramBot.SendTextMessageAsync(update.Message.From.Id, "I'm waiting for your date and time!");
                action = update.Message.Text;
            }
            else if (update.Message.Text == "+")
            {
                Sound.Louder();
            }
            else if (update.Message.Text == "-")
            {
                Sound.Quiet();
            }

            else if (update.Message.Text == "🔇")
            {
                Sound.Mute();
            }




        }
        private async Task StartCommand(Update update)
        {
            KeyboardButton[][] keyboardButtons =    //создаем кнопки
               {
                    new KeyboardButton[]{"Start timer!"},
                    new KeyboardButton[]{"Time left!"},
                    new KeyboardButton[]{"Open Console", "Close Console"},
                    new KeyboardButton[]{"Set Video Link", "Set dateTime"},
                    new KeyboardButton[]{"+","-", "🔇" }
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
