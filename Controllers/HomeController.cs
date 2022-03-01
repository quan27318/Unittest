using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Models;
using UnitTest.Service;
namespace UnitTest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private IPerson _iPerson;
    public HomeController(ILogger<HomeController> logger, IPerson iPerson)
    {
        _logger = logger;
        _iPerson = iPerson;
    }

    public IActionResult Index()
    {
        return View(_iPerson.GetAll());
    }
    [HttpPost]
    public IActionResult Create(Person per){
        _iPerson.Create(per);
        return RedirectToAction("Index");
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Update(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
