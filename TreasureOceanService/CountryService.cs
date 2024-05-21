using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;
using TreasureOceanRepository;

namespace TreasureOceanService
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository iCountryRepository;
        public CountryService() 
        {
            if(iCountryRepository == null)
            {
                iCountryRepository = new CountryRepository();
            }
        }

        public List<Country> GetCountries()
        {
            return iCountryRepository.GetCountries();
        }
    }
}
