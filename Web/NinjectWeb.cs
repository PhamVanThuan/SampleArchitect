using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;
using DataAccess.Repositories;
using Ninject.Modules;
using Services.Abstracts;
using Services.Implements;

namespace Web
{
    public class NinjectWeb: NinjectModule
    {
        public override void Load()
        {
            var sampleContext = new SampleContext();
            Bind<ISampleContext>().ToConstant(sampleContext);
            Bind<ICountryRepository>().To<CountryRepository>();
            Bind<ICountryService>().To<CountryService>();
        }
    }
}