using Microsoft.AspNetCore.SignalR;
namespace SuperTikTakToe.Hubs;

public class GameHub : Hub
{
    public async Task EndTurn()
    {
        await Clients.All.SendAsync("NextTurn");
    }
}