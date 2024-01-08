using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlinePortfolioZB.Emails;
using OnlinePortfolioZB.Models;

namespace OnlinePortfolioZB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailService _emailService;

        public HomeController(ILogger<HomeController> logger, 
            IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactMe(ContactMeMessage viewModel)
        {
            throw new NotImplementedException("Removing this functionality untill captcha or something can be used");
            //if (!ModelState.IsValid)
            //{
            //    return View("Partials/_ContactPartial", viewModel);
            //}

            //_emailService.ContactMe(viewModel.Name, viewModel.Email, viewModel.Message);

            //return RedirectToAction(nameof(Index));
        }
    }
}
