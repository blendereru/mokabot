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
        Client = new TelegramBotClient("your_token");
        return Client;
    }
}