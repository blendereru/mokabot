using Telegram.Bot.Types;

namespace MokaBot.Models;

public class UpdateDistributor
{
    private readonly Dictionary<long, CommandExecutor> _listeners = new Dictionary<long, CommandExecutor>();
    public async Task GetUpdate(Update update)
    {
        if (update.Message == null)
        {
            return;
        }
        var chatId = update.Message.Chat.Id;
        if (!_listeners.TryGetValue(chatId, out var executor))
        {
            executor = new CommandExecutor();
            _listeners[chatId] = executor;
        }
        await executor.GetUpdate(update);
    }
}