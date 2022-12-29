using _04TelegramBot;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";
ButtonBot buttonbot = new ButtonBot(token);
buttonbot.Start();

app.MapGet("/", () => "Button bot");

app.Run();
