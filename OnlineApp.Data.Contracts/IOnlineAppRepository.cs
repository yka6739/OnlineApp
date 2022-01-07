using Core.Contracts;
using OnlineApp.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp.Data.Contracts
{
    public interface IOnlineAppRepository:ICoreRepository<Individual, VW_Individual, IndividualSearch>
    {

    }
}
