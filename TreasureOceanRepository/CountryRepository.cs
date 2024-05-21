using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;
using TreasureOceanDAO;

namespace TreasureOceanRepository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly CountryDAO countryDAO;
        public CountryRepository() 
        {
            if (countryDAO == null)
            {
                countryDAO = new CountryDAO();
            }
        }

        public List<Country> GetCountries()
        {
            return countryDAO.GetCountries();
        }
    }
}
