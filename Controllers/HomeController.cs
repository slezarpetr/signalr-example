using BlazorServerSignalRApp.Server.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public HomeController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task<IActionResult> Index()
        {
            await _hubContext.Clients.All.SendAsync("Notify", $"Home page loaded at: {DateTime.Now}");
            return View();
        }
    }
}
