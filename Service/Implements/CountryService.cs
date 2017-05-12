using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories;
using Services.Abstracts;

namespace Services.Implements
{
    public class CountryService: ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryService(ICountryRepository conCountryRepository)
        {
            _countryRepository = conCountryRepository;
        }
        public IEnumerable<Country> GetCountries()
        {
            var result = _countryRepository.GetCountries();
            return result;
        }
    }
}
