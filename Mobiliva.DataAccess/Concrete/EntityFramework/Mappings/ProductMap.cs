using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobiliva.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);

            builder.Property(x => x.Category).IsRequired();
            builder.Property(x => x.Category).HasMaxLength(500);

            builder.Property(x => x.Unit).IsRequired();
            builder.Property(x => x.Unit).HasMaxLength(500);

            
        }
    }
}
