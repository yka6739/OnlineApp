using OnlineApp.Business.Entities;
using OnlineApp.Data.Contracts;
using OnlineApp.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp.Data.Repositories
{
    public class LookUpRepository : ILookUpRepository
    {
        OnlineAppDbContext ctx;

        public LookUpRepository()
        {
            ctx = new OnlineAppDbContext();
        }
        public IEnumerable<Country> GetCountriesName()
        {
            return (from e in ctx.CountrySet
                    select e);
        }

        public IEnumerable<Education> GetEducationName()
        {
            return (from e in ctx.EducationSet
                    select e);
        }
    }
}
