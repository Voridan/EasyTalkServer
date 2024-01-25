﻿
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfiguration
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(p => p.Password)
                .IsRequired();
            builder
                .Property(p => p.Salt)
                .IsRequired();
            builder
                .Property(p => p.Email)
                .IsRequired();
            builder
                .Property(p => p.CreatedDate)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .HasOne(p => p.Client)
                .WithOne(p => p.Person)
                .HasForeignKey<Client>(c => c.PersonId)
                .IsRequired(false);
            builder
                .HasOne(p => p.Freelancer)
                .WithOne(p => p.Person)
                .HasForeignKey<Freelancer>(f => f.PersonId)
                .IsRequired(false);
            builder
                .HasMany(p => p.Chats)
                .WithMany(c => c.People);
            builder
                .HasMany(p => p.Messages)
                .WithOne(m => m.Person)
                .HasForeignKey(m => m.PersonId);
        }
    }
}
