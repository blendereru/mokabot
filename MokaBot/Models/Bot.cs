using Telegram.Bot;

namespace MokaBot.Models;

public static class Bot
{
    private static TelegramBotClient? Client { get; set; }
    public static TelegramBotClient GetTelegramBot()
    {
        if (Client != null)
        {
            return Client;
        }
        Client = new TelegramBotClient("7430714529:AAH58S0YLzGIFUvvyWJl8clSkL18MIjURt8");
        return Client;
    }
}