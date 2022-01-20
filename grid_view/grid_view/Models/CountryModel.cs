using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace grid_view.Models
{
    public class CountryModel
    {
        public List<Country> CountryList { get; set; }
    }
    public class Country
    {
        public int ID { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }
        public string FlagURL { get; set; }
    }
}
