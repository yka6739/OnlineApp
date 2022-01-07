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
    public class OnlineAppRepository : OnlineAppDbContextBase<Individual, VW_Individual>, IOnlineAppRepository
    {
        protected override Individual AddEntity(OnlineAppDbContext entityContext, Individual entity)
        {
            return entityContext.IndividualSet.Add(entity).Entity;
        }

        protected override IEnumerable<Individual> GetEntities(OnlineAppDbContext entityContext)
        {
            return (from e in entityContext.IndividualSet
                    select e);
        }

        protected override Individual GetEntity(OnlineAppDbContext entityContext, int id)
        {
            return (from e in entityContext.IndividualSet
                    where e.IndividualId == id
                    select e).SingleOrDefault();
        }

        protected override Individual GetEntity(OnlineAppDbContext entityContext, Guid guid)
        {
            return (from e in entityContext.IndividualSet
                    where e.IndividualGuid == guid
                    select e).FirstOrDefault();
        }

        protected override IEnumerable<VW_Individual> GetViewEntities(OnlineAppDbContext entityContext, IndividualSearch filter)
        {
            if (!string.IsNullOrEmpty(filter.Name))
            {
                return (from e in entityContext.IndividualVWSet
                        where e.Name.ToLower() == filter.Name.ToLower()
                        select e);
            }

            return (from e in entityContext.IndividualVWSet
                    select e);
        }

        protected override VW_Individual GetViewEntity(OnlineAppDbContext entityContext, IndividualSearch filter)
        {
            throw new NotImplementedException();
        }

        protected override VW_Individual GetViewEntity(OnlineAppDbContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override VW_Individual GetViewEntity(OnlineAppDbContext entityContext, Guid guid)
        {
            throw new NotImplementedException();
        }

        protected override Individual UpdateEntity(OnlineAppDbContext entityContext, Individual entity)
        {
            return (from e in entityContext.IndividualSet
                    where e.IndividualId == entity.IndividualId
                    select e).FirstOrDefault();
        }
    }
}
