﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace Services.Abstracts
{
    public interface ICountryService
    {
        IEnumerable<Country> GetCountries();
    }
}
