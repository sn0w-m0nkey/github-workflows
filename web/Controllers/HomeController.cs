using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using web.Configuration;
using web.Models;
using web.ViewModels;

namespace web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppConfig _appConfig;

    public HomeController(ILogger<HomeController> logger, IOptions<AppConfig> appConfigOptions)
    {
        _logger = logger;
        _appConfig = appConfigOptions.Value;
    }

    public IActionResult Index()
    {
        var indexViewModel = new IndexViewModel()
        {
            Environment = _appConfig.Environment
        };
        
        return View(indexViewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
