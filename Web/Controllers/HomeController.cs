using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Logging;
using Services.Abstracts;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly ILoggingService _loggingService;

        public HomeController(ICountryService countryService, ILoggingService loggingService)
        {
            _countryService = countryService;
            _loggingService = loggingService;
        }

        // GET: Home
        public ActionResult Index()
        {
            var countries = _countryService.GetCountries();
            _loggingService.Information("Home controller");
            return View(countries);
        }
    }
}