﻿using Microsoft.AspNetCore.Mvc;

namespace GameStore.PL.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}