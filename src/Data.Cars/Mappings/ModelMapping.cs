using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Negocios.Carros.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Cars.Mappings
{
    public class ModelMapping : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            throw new NotImplementedException();
        }
    }
}
