
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfiguration
{
    internal class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder
                .HasKey(a => a.MessageId);
            builder
                .Property(a => a.MessageId)
                .IsRequired();
            builder
                .Property(a => a.Name)
                .IsRequired();
            builder
                .Property(a => a.StoragePath)
                .IsRequired();
            builder
                .Property(a => a.CreatedDate)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .HasOne(a => a.Message)
                .WithMany(m => m.Attachments)
                .HasForeignKey(a => a.MessageId)
                .IsRequired();
        }
    }
}
