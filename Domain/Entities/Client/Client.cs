namespace Domain.Entities
{
    public class Client: BaseEntity
    {
        public Guid? PersonId { get; set; }

        public Person? Person { get; set; }
    }
}
