﻿namespace Domain.Entities
{
    public class Chat: BaseEntity
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Message> Messages { get; set; } = null!;
    }
}
