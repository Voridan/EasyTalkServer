
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Database
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }

        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        DbSet<Person> People { get; set; }

        DbSet<Client> Clients { get; set; }

        DbSet<Freelancer> Freelancers { get; set; }

        DbSet<Technology> Technologies { get; set; }

        DbSet<Project> Projects { get; set; }

        DbSet<Topic> Topics { get; set; }

        DbSet<Chatshot> Chatshots { get; set; }

        DbSet<Chat> Chats { get; set; }

        DbSet<Message> Messages { get; set; }

        DbSet<Attachment> Attachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}

