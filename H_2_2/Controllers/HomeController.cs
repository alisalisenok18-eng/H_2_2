using H_2_2.Models;
using H_2_2.Model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace H_2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(
        string firstName,
        string lastName,
        DateTime birthDate,
        string description)
    {
        if (string.IsNullOrEmpty(firstName))
            firstName = "Алиса";

        if (string.IsNullOrEmpty(lastName))
            lastName = "Воронкова";

        if (birthDate == default)
            birthDate = new DateTime(2009, 01, 12);

        if (string.IsNullOrEmpty(description))
            description = "Виновата, что не делала это задание , " +
                          "а делает его только перед следующим занятием.";

        var card = new VisitCard(firstName, lastName, birthDate, description);
        return View(card);
    }
}
