using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineApp.Business.Entities;
using OnlineApp.Data.Contracts;
using System;
using System.Collections.Generic;

namespace OnlineApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineAppController : ControllerBase
    {
        private readonly ILogger<OnlineAppController> _logger;
        private readonly ILookUpRepository _lookUpRepository;
        private readonly IOnlineAppRepository _onlineAppRepository;

        public OnlineAppController(ILogger<OnlineAppController> logger, IOnlineAppRepository onlineAppRepository,
            ILookUpRepository lookUpRepository
            )
        {

            _logger = logger;
            _onlineAppRepository = onlineAppRepository;
            _lookUpRepository = lookUpRepository;
        }
        [HttpPost("AllIndividuals")]
        public IEnumerable<VW_Individual> AllIndividuals(IndividualSearch filter)
        {
            return _onlineAppRepository.GetVwEntities(filter);
        }
        [HttpPost("SaveIndividual")]
        public Individual SaveIndividual(Individual individual)
        {
            if (individual.IndividualId == 0)
            {
                return _onlineAppRepository.Add(individual);
            }
            else
            {
                return _onlineAppRepository.Update(individual);
            }
        }
        [HttpGet("GetIndividualByGuid/{individualGuid}")]
        public Individual GetIndividualByGuid(Guid individualGuid)
        {

            return _onlineAppRepository.Get(individualGuid);

        }
        [HttpGet("RemoveIndividual/{individualGuid}")]
        public bool DeleteIndividual(Guid individualGuid)
        {
            try
            {
                _onlineAppRepository.Remove(individualGuid);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        [HttpGet("GetEducationNames")]

        public IEnumerable<Education> GetEducationNames()
        {
            return _lookUpRepository.GetEducationName();
        }
        [HttpGet("GetCountriesNames")]

        public IEnumerable<Country> GetCountriesNames()
        {
            return _lookUpRepository.GetCountriesName();
        }
    }
}
