﻿
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfiguration
{
    internal class FreelancerConfiguration : IEntityTypeConfiguration<Freelancer>
    {
        public void Configure(EntityTypeBuilder<Freelancer> builder)
        {
            builder
                .HasKey(f => f.PersonId);
            builder
                .Property(f => f.PersonId)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(f => f.CreatedDate)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .HasOne(f => f.Person)
                .WithOne(p => p.Freelancer)
                .HasForeignKey<Freelancer>(f => f.PersonId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            builder
                .HasMany(f => f.Projects)
                .WithMany(p => p.Freelancers);
            builder
                .HasMany(f => f.Technologies)
                .WithMany(t => t.Freelancers);
        }
    }
}
