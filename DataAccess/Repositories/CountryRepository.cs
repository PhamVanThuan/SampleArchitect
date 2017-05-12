using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.TrulyRepository;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class CountryRepository: EntityFrameworkRepository<SampleContext>, ICountryRepository
    {
        public CountryRepository(SampleContext context) : base(context)
        {
        }

        public IEnumerable<Country> GetCountries()
        {
            var result = context.Countries.ToList();
            return result;
        }
    }
}
