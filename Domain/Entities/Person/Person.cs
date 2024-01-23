namespace Domain.Entities
{
    public class Person: BaseEntity
    {
        public Gender? Gender { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateOnly? DateOfBirth {  get; set; }
        
        public string? Location { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Salt { get; set; }

        public string? PhotoLocation { get; set; }

        public ICollection<Chat> Chats { get; set; } = null!;

        public Client? Client { get; set; }

        public Freelancer? Freelancer { get; set; }

        public ICollection<Project>? Projects { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
