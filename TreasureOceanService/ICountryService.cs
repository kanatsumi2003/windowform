using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;

namespace TreasureOceanService
{
    public interface ICountryService
    {
        List<Country> GetCountries();
    }
}
