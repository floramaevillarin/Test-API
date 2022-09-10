using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Repository
{
    public interface ICityReporistory
    {
        IList<City> GetCity();
        City GetCity(string cityId);
        void Add(City city);
        City Update(City city);
        void Delete(City city);
    }
}
