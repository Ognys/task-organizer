using Microsoft.AspNetCore.Mvc;
using Organaize.Models;
using System.Collections.Generic;
using Organaize.Services;

namespace Organaize.Controllers;

public class TaskController : Controller
{
    private static List<TaskModel> tasks = new List<TaskModel>();
    private static int NextId = 1;

    public IActionResult Index()
    {
        var months = new MonthService();
        ViewBag.Months = months.GenerateMonths();

        return View(tasks);
    }

    public IActionResult CreateTask()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateTask(TaskModel task)
    {
        if (ModelState.IsValid)
        {
            task.Id = NextId++;
            tasks.Add(task);
            return RedirectToAction("Index");
        }

        return View(task);
    }

    [HttpPost]
    public IActionResult ToggleComplete(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.IsCompleted = !task.IsCompleted;
        }

        return RedirectToAction("Index");
    }
}