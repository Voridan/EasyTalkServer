namespace Domain.Entities
{
    public class Technology
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Freelancer>? Freelancers { get; set; }

    }
}
