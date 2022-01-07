using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineApp.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp.Data.Mapper
{
    public class VW_IndividualConfiguration : IEntityTypeConfiguration<VW_Individual>
    {
        public void Configure(EntityTypeBuilder<VW_Individual> builder)
        {
            builder.ToView("VW_Individual");
            builder.HasKey(t => t.IndividualId);
        }
    }
}
