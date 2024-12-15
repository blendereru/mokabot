using MokaBot.Commands;
using Telegram.Bot.Types;

namespace MokaBot.Models;

public class CommandExecutor
{
    private readonly List<CommandBase> _commands = new List<CommandBase>()
    {
        new AdminCommand(),
        new StartCommand()
    };

    private CommandBase? _activeCommand;

    public async Task GetUpdate(Update update)
    {
        if (update.Message is null || string.IsNullOrEmpty(update.Message.Text))
        {
            return;
        }
        if (_activeCommand is not null)
        {
            await _activeCommand.ExecuteAsync(update);
            if (!_activeCommand.IsActive)
            {
                _activeCommand = null;
            }
            return;
        }
        if (update.Message.Text == "Chat with admin")
        {
            var adminCommand = _commands.FirstOrDefault(cmd => cmd.Name == "/admin");
            if (adminCommand is not null)
            {
                _activeCommand = adminCommand;
                await adminCommand.ExecuteAsync(update);
            }
            return;
        }
        foreach (var command in _commands)
        {
            if (command.Name == update.Message.Text)
            {
                _activeCommand = command;
                await command.ExecuteAsync(update);
                break;
            }
        }
    }
}