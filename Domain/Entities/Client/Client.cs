namespace Domain.Entities
{
    public class Client
    {
        public Guid? PersonId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Person? Person { get; set; }

        public ICollection<Project>? Projects { get; set; }
    }
}
