﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class DiliveryConfiguration : IEntityTypeConfiguration<Dilivery>
    {
        public void Configure(EntityTypeBuilder<Dilivery> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Status)
                .IsRequired();
            builder.Property(d => d.Method)
                .IsRequired();
         
        }
    }
}
