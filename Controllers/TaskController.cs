using Microsoft.AspNetCore.Mvc;
using Organaize.Models;
using System.Collections.Generic;
using Organaize.Services;
using Microsoft.VisualBasic;

namespace Organaize.Controllers;

public class TaskController : Controller
{
    private static List<TaskModel> tasks = new List<TaskModel>();
    private static int NextId = 1;
    public IActionResult Index(int? indexMonths)
    {
        ViewBag.Months = MonthService.GenerateMonths();

        if(indexMonths.HasValue)
        {
            ViewBag.Days = GetDaysService.GetDays(indexMonths.Value);
        }

        return View(tasks);
    }

}