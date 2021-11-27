using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryPatternWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternWebApp.IRepositories;
using RepositoryPatternWebApp.Repositories;

namespace RepositoryPatternWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMyModelRepository _myModelRepository;

        public HomeController(ILogger<HomeController> logger, IMyModelRepository myModelRepository)
        {
            _logger = logger;
            _myModelRepository = myModelRepository;
        }

        public IActionResult Index()
        {
            MyModel myModel = new MyModel
            {
                Id=1,
                Name = "javad jahangiri"
            };

            _myModelRepository.Add(myModel);

            var data = _myModelRepository.GetList();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
