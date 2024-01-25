using Domain.Enums;

namespace Domain.Entities
{
    public class Freelancer
    {
        public Guid? PersonId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Specialization? Specialization { get; set; }

        public uint Rate { get; set; }
        
        public Person? Person { get; set; } = null!;

        public ICollection<Project>? Projects { get; set; }
        
        public ICollection<Technology>? Technologies { get; set; }
    }
}
