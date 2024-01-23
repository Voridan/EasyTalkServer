namespace Domain.Entities
{
    public class Message: BaseEntity
    {
        public string? Text { get; set; }

        public Guid PersonId { get; set; }

        public Guid ChatId { get; set; }
    }
}
