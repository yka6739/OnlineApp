using OnlineApp.Client.Contracts;
using OnlineApp.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp.Client.Services
{
    public class OnlineService:IOnlineService
    {
        private readonly IHttpService _httpService;

        public OnlineService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<VW_Individual>> GetAllIndividualVW(IndividualSearch filter)
        {
            return await _httpService.GetFilteredEntities<VW_Individual>("api/pocs/GetFilteredIndividuals", filter);
        }

        public async Task<IEnumerable<VW_Individual>> GetEntities()
        {
            return await _httpService.GetEntities<VW_Individual>("api/pocs/GetFilteredIndividuals");
        }
    }
}
