using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

//токен полученный из телеграма
string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";
var bot = new TelegramBotClient(token);
bot.StartReceiving(
    updateHandler: UpdateAsync,
    pollingErrorHandler: PollingerrorHandler);

var botInfo = await bot.GetMeAsync();
Console.WriteLine($"Bot {botInfo} have already started to work");
Console.ReadLine();

async Task UpdateAsync (ITelegramBotClient botClient, Update update, CancellationToken token)
{
    //получаем айди пользователя 
    var id = update.Message.Chat.Id;
    //есть еще один вариант получения айди
    //var id2 = update.Message.From.Id;

    //получаем сообщение, которое отправил пользователя
    string massege = update.Message.Text;

    //если пользователь отправил /start
    if (massege == "/start")
    {
        //тогда мы генерируем случайное число
        Random random = new Random();
        int num = random.Next(0, 15);
    }
    //если полученное сообщение это число, которое меньше загаданного
    if (int.Parse(massege) < 1)
    {
        //выводим сообщение, что сило меньше
        string less = "the num is bigger";
        await bot.SendTextMessageAsync(id, less);
    }
    //если введенное число больше 
    else if (int.Parse(massege) > 1)
    {
        //отправляем сообщение, что число меньше
        string more = "the num is smaller";
        await bot.SendTextMessageAsync(id, more);
    }
    else
    {
        //ну а иначе пользователь побеждает 
        string win = "YOU WON!!!!";
        await bot.SendTextMessageAsync(id, win);
    }

    #region Task1
    //этот код показывает логику, что бы бот отправлял сообщение то самое которое 
    //ему присылает пользователь, но если пользователь отправляет "Какое время?",
    //бот присылает текущее время 

    //DateTime date = new DateTime();
    //date = DateTime.Now;
    //if(update.Message.Text == "Какое время?")
    //{
    //   await bot.SendTextMessageAsync(id, date.ToString());
    //}
    //else if(update.Message.Text != "Какое время?")
    //{
    //    await bot.SendTextMessageAsync(
    //        id, 
    //        $"||{massege}||🇺🇦🤔😜",
    //        parseMode: ParseMode.MarkdownV2);
    //}
    #endregion
}
Task PollingerrorHandler(ITelegramBotClient botClient, Exception exception, CancellationToken token)
{
    return Task.CompletedTask;
}