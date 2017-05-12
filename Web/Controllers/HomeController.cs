using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Abstracts;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryService _countryService;

        public HomeController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        // GET: Home
        public ActionResult Index()
        {
            var countries = _countryService.GetCountries();
            return View(countries);
        }
    }
}