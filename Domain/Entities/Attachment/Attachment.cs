using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Attachment
{
    public class Attachment: BaseEntity
    {
        public string? Name { get; set; }

        public string? StoragePath { get; set; }

        public Guid MessageId { get; set; }

    }
}
