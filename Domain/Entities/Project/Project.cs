using Domain.Enums;

namespace Domain.Entities
{
    public class Project: BaseEntity
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public ProjectStatus? Status { get; set; }

        public Guid ClientId { get; set; }

        public Client? Client { get; set; }

        public ICollection<Freelancer>? Freelancers { get; set; }

        public ICollection<Topic>? Topics { get; set; }
    }
}
