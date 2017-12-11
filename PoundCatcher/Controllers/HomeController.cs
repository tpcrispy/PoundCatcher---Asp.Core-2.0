using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoundCatcher.Models;
using PoundCatcher.Data;
using PoundCatcher.Models.Dogs;
using PoundCatcher.Models.DogViewModels;

namespace PoundCatcher.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDog _dogService;

        public  HomeController(IDog dogService)
        {
            _dogService = dogService;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
