using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BrnasM3.Models;

namespace BrnasM3.Controllers;

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

    public async Task<IActionResult> News()
    {
        return View(await NewsModel.GetViewModelAsync());
    }

    public async Task<IActionResult> About()
    {
        return View(await AboutModel.GetAboutModelAsync());
    }


    public async Task<IActionResult> Coop()
{
    return View(await CoopTableModel.GetCoopTableModelViewAsync());
}


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

