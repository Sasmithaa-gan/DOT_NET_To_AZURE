using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using grid_view.Models;
namespace grid_view.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CountryModel _countryModel = new CountryModel();
            _countryModel.CountryList = GetCountryList();
            return View(_countryModel);
        }

        /// 

        /// Country list
        ///
        public List<Country> GetCountryList()
        {
            List<Country> _country = new List<Country>();
            _country.Add(new Country { ID = 1, CountryName = "India", Population = 124000, FlagURL = "CountryFlag/india.png" });
            _country.Add(new Country { ID = 1, CountryName = "China", Population = 84545, FlagURL = "CountryFlag/china.png" });
            _country.Add(new Country { ID = 1, CountryName = "Germany", Population = 9354999, FlagURL = "CountryFlag/germany.png" });
            _country.Add(new Country { ID = 1, CountryName = "Japan", Population = 24999, FlagURL = "CountryFlag/japan.png" });
            return _country;
        }
    }
}