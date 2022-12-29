using _03TelegramBot;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Telegram Bot");

string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";
PredictionsBot bot = new PredictionsBot(token);
bot.Start();

app.Run();