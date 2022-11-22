using ANK_9.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK_9.DAL.Concrete.Context.Configuration
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.ID)
                   .UseIdentityColumn();

            builder.Property(x => x.IsActive)
                   .IsRequired()
                   .HasColumnType("bit");

            builder.Property(x => x.CreateOn)
                   .IsRequired()
                   .HasColumnType("datetime2(7)");

            builder.Property(x => x.UpdateOn)
                   .IsRequired(false)
                   .HasColumnType("datetime2(7)");

            builder.HasKey(x => x.ID);
        }
    }
}
