﻿
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfiguration
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(p => p.CreatedDate)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(p => p.Name)
                .HasMaxLength(256);
            builder
                .Property(p => p.Description)
                .HasMaxLength(4096);
            builder
                .HasOne(p => p.Client)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClientId)
                .IsRequired();
            builder
                .HasMany(p => p.Topics)
                .WithOne(t => t.Project)
                .HasForeignKey(t => t.ProjectId);
            builder
                .HasMany(p => p.Freelancers)
                .WithMany(f => f.Projects);
        }
    }
}
