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

    public async Task<IActionResult> Employment()
    {
        return View(await EmploymentTableModel.GetEmploymentTableModelViewAsync());
    }

    public async Task<IActionResult> Undergraduate()
    {
        return View(await UndergraduateModel.GetUndergraduateModelViewAsync());
    }

    public async Task<IActionResult> Graduate()
    {
        return View(await GraduateModel.GetGraduateModelViewAsync());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

