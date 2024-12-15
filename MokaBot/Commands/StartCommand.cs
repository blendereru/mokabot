using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace MokaBot.Commands;

public class StartCommand : CommandBase
{
    public override string Name { get; protected set; } = "/start";
    public override bool IsActive { get; protected set; } = false;

    public override async Task ExecuteAsync(Update update)
    {
        if (update.Message is null)
        {
            return;
        }

        var chatId = update.Message.Chat.Id;
        var replyMarkup = new ReplyKeyboardMarkup(new[]
        {
            new KeyboardButton("Chat with admin")
        });
        await Client.SendTextMessageAsync(
            chatId: chatId,
            text: "Welcome to the MokaBot! Tap the button below to start conversation",
            replyMarkup: replyMarkup);
    }
}