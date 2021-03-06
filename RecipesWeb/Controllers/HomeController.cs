﻿using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipesCore.Services;
using RecipesWeb.Models;
using RecipesWeb.ViewModels;

namespace RecipesWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipesService _recipesService;

        public HomeController(IRecipesService recipesService)
        {
            _recipesService = recipesService;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Recipes = _recipesService.GetAll()
            };

            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
