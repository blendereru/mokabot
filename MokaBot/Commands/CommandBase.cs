using System.Threading.Tasks;
using MokaBot.Models;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace MokaBot.Commands;
public abstract class CommandBase
{
    public TelegramBotClient Client => Bot.GetTelegramBot();
    public abstract string Name { get; protected set; }
    public abstract bool IsActive { get; protected set; }
    public abstract Task ExecuteAsync(Update update);
}