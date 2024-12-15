using Microsoft.AspNetCore.Mvc;
using MokaBot.Models;
using Telegram.Bot.Types;

namespace MokaBot.Controllers;
[ApiController]
[Route("/")]
public class BotController : Controller
{
    private readonly UpdateDistributor _updateDistributor;

    public BotController(UpdateDistributor updateDistributor)
    {
        _updateDistributor = updateDistributor;
    }
    [HttpPost]
    public async Task Post(Update update)
    {
        if (update.Message is null)
        {
            return;
        }
        await _updateDistributor.GetUpdate(update);
    }

    [HttpGet]
    public string Get() => "Telegram bot was started";
}