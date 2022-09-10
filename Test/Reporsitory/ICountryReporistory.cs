using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Repository
{
    public interface ICountryReporistory
    {
        IList<Country> GetCountry();
        Country GetCountry(string countryId);
        void Add(Country country);
        Country Update(Country country);
        void Delete(Country country);
    }
}
