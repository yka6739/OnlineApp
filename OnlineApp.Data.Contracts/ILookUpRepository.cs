using OnlineApp.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp.Data.Contracts
{
    public interface ILookUpRepository
    {
        IEnumerable<Education> GetEducationName();
        IEnumerable<Country> GetCountriesName();
    }
}
