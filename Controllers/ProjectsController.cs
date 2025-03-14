using ICE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ICE.Controllers;

public class ProjectsController : Controller
{
    public ProjectsController() {}

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Project project)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Index");
        }
        return View(project);
    }

    [HttpGet]
    public IActionResult Details()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Details2()
    {
        return View();
    }
}