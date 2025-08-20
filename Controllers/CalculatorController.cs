using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers;

public class CalculatorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}