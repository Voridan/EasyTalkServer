namespace Domain.Entities
{
    public class Freelancer: BaseEntity
    {
        public string? Specialization { get; set; }

        public int Rate { get; set; }

        public Guid? PersonId { get; set; }

        public ICollection<Technology>? Technologies { get; set; }
        
        public Person? Person { get; set; } = null!;
    }
}
