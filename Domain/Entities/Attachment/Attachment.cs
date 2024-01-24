﻿namespace Domain.Entities
{
    public class Attachment
    {
        public Guid MessageId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string? Name { get; set; }

        public string? StoragePath { get; set; }

        public Message? Message { get; set; }
    }
}
