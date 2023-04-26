using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BrnasM3.Models;
using System.ComponentModel;

namespace BrnasM3.Controllers;

///<summary>
///Represents a class controller that has actions for rendering different views.
///</summary>
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    ///<summary>
    ///Controller has actions for displaying index view.
    ///</summary>
    public IActionResult Index()
    {
        return View();
    }

    ///<summary>
    ///Controller has actions for displaying about view.
    ///</summary>
    public async Task<IActionResult> About()
    {
        return View(await AboutModel.GetAboutModelAsync());
    }

    ///<summary>
    ///Controller has actions for displaying coop view.
    ///</summary>
    public async Task<IActionResult> Coop()
{
    return View(await CoopTableModel.GetCoopTableModelViewAsync());
}

    ///<summary>
    ///Controller has actions for displaying employment view.
    ///</summary>
    public async Task<IActionResult> Employment()
    {
        return View(await EmploymentTableModel.GetEmploymentTableModelViewAsync());
    }

    ///<summary>
    ///Controller has actions for displaying undergrad view.
    ///</summary>
    public async Task<IActionResult> Undergraduate()
    {
        return View(await UndergraduateModel.GetUndergraduateModelViewAsync());
    }

    ///<summary>
    ///Controller has actions for displaying graduate view.
    ///</summary>
    public async Task<IActionResult> Graduate()
    {
        return View(await GraduateModel.GetGraduateModelViewAsync());
    }

    ///<summary>
    ///Controller has actions for displaying faculty view.
    ///</summary>
    public async Task<IActionResult> Faculty()
    {
        return View(await FacultyModelView.GetFacultyModelViewAsync());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

