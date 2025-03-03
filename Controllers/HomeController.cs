using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;  // <-- Asegúrate de que esta línea esté incluida

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
