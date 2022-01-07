using Core.Common;
using OnlineApp.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp.Data.Helpers
{
    public abstract  class OnlineAppDbContextBase<T,VW> : CoreRepository<T, VW, IndividualSearch, OnlineAppDbContext>
         where T : class, new()
       where VW : class, new()
    {
    }
}
