using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;

namespace TreasureOceanDAO
{
    public class CountryDAO
    {
        public CountryDAO() { }
        public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country(1, "England"));
            countries.Add(new Country(2, "French"));
            countries.Add(new Country(3, "Thailand"));
            countries.Add(new Country(4, "New Zealand"));
            countries.Add(new Country(5, "Japan"));
            return countries;
        }
    }
}
