using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Database;
using TaskManager.Models;

namespace TaskManager.Controllers;

public class TaskController : Controller
{
    private readonly AppDbContext _context;

    public TaskController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var tasks = _context.Tasks.ToList();
        ViewBag.Tasks = tasks;
        return View();
    }

    public IActionResult Show(int id)
    {
        var task = _context.Tasks.Find(id);
        if (task == null)
        {
            return NotFound();
        }
        ViewBag.Task = task;
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Save(TaskManager.Models.Task task)
    {
        _context.Tasks.Add(task);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var task = _context.Tasks.Find(id);
        if (task == null)
        {
            return NotFound();
        }
        ViewBag.Task = task;
        return View();
    }

    [HttpPost]
    public IActionResult Update(TaskManager.Models.Task task)
    {
        var existingTask = _context.Tasks.Find(task.Id);
        if (existingTask == null)
        {
            return NotFound();
        }
        existingTask.Title = task.Title;
        existingTask.Description = task.Description;
        existingTask.IsComplete = task.IsComplete;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var task = _context.Tasks.Find(id);
        if (task == null)
        {
            return NotFound();
        }
        _context.Tasks.Remove(task);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult About()
    {
        ViewBag.Content =
            "This App is a simple task manager app developed using ASP.NET Core by @marcuwynu23";
        return View("/Views/About.cshtml");
    }
}
