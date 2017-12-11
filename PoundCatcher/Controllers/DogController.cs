using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoundCatcher.Data;
using PoundCatcher.Models.DogViewModels;
using PoundCatcher.Models.Dogs;

namespace PoundCatcher.Controllers
{
    public class DogController : Controller
    {
        //DATA INJECTION FOR DB CONTEXT
        public  DogController(IDog dogService)
        {
            _dogService = dogService;
        }

        public IActionResult Index()
        {
            var dogs = _dogService.GetBasicDogs().Select(dog => new BasicDogModel
            {
                Id = dog.Id,
                MicroChip = dog.MicroChip,
                Name = dog.Name,
                OwnersName = dog.Owner.FirstName,
                TagColor = dog.TagColor
            });

            var model = new BasicDogList
            {
                BasicDogListView = dogs
            };
            return View(model);
        }


        //DATA INJECT VARS
        private readonly IDog _dogService;

    }
}