using OnlineApp.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp.Client.Contracts
{
    public interface IOnlineService
    {
        Task<IEnumerable<VW_Individual>> GetAllIndividualVW(IndividualSearch filter);
        Task<IEnumerable<VW_Individual>> GetEntities();
    }
}
