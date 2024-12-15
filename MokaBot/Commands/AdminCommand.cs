using Telegram.Bot;
using Telegram.Bot.Types;
using System.Collections.Concurrent;

namespace MokaBot.Commands;
public class AdminCommand : CommandBase
{
    public override string Name { get; protected set; } = "/admin";
    public override bool IsActive { get; protected set; } = true;
    private readonly long _adminId = 13333333333; // change your id here.
    public override async Task ExecuteAsync(Update update)
    {
        if (update.Message is null || string.IsNullOrEmpty(update.Message.Text))
        {
            return;
        }
        var chatId = update.Message.Chat.Id;
        var messageText = update.Message.Text;

        if (chatId == _adminId)
        {
            await Client.SendTextMessageAsync(_adminId, messageText);
        }
        else
        {
            await Client.SendTextMessageAsync(chatId, messageText);
        }
    }
}
