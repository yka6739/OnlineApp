using Microsoft.AspNetCore.Components;
using OnlineApp.Client.Contracts;
using OnlineApp.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineApp.Client.Pages
{
    public  partial class IndividualList
    {
        [Inject]
        public IOnlineService _PocService { get; set; }
        public List<VW_Individual> Individuals { get; set; } = new List<VW_Individual>();

        //public List<Country> Countries { get; set; } = new List<Country>();
        protected async override Task OnInitializedAsync()
        {
            //return base.OnInitializedAsync();

            await loadData();
        }

        private async Task loadData()
        {
            // Countries = (await _PocService.GetAllCountries()).ToList();

            Individuals = (await _PocService.GetEntities()).ToList();
        }

    }
}
