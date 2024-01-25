﻿
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfiguration
{
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
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
                .HasOne(t => t.Project)
                .WithMany(p => p.Topics)
                .HasForeignKey(t => t.Project)
                .IsRequired();
            builder
                .HasMany(t => t.Chatshots)
                .WithOne(c => c.Topic)
                .HasForeignKey(c => c.TopicId);
        }
    }
}
