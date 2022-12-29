using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

#region F
//namespace _01TelegramBot
//{
//    internal class Program
//    {

//        static async void StartBot()
//        {
//            string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";
//            var botClient = new TelegramBotClient(token);

//            var bot = botClient.GetMeAsync().Result;
//            Console.WriteLine($"It is bot {bot.Id}, name: {bot.FirstName}");
//            //Console.ReadLine();
//        }

//        static void Main(string[] args)
//        {
//            StartBot();
//        }
//    }
//}
#endregion

//токен полученный из телеграма
string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";

//создаем обьект телеграм бота
TelegramBotClient botClient = new TelegramBotClient(token);

//начинаем прослушивать бота
botClient.StartReceiving(
    updateHandler: UpdateAsync,             //метод обновлений
    pollingErrorHandler: PollingErrorAsync  //метод ошибок
    );

//связываемся с ботом
var me = botClient.GetMeAsync().Result;

//выводим на экран результат связи
Console.WriteLine($"Start listening for {me.Username}");

//ждем ввода в консоль(что бы прога не закрылась)
Console.ReadLine();
////////////////////////////////////////////
//метод обновлений бота 
async Task UpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
{
    //получаем текст сообщения
    string msg = update.Message.Text;

    //получаем имя отправителя
    var firstName = update.Message.Chat.FirstName;

    //выводим на кран имя и текст сообщения
    Console.WriteLine($"Received user: {firstName} msg: {msg}");
}

//метод ошибок
Task PollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
{
    //если ошибка происходит, то выводим на экран сообщение
    Console.WriteLine("Error");

    //в результате работы отправляем "завершенную задау"
    return Task.CompletedTask;
}