using System;

namespace CO._2CS.GOCE.Platform.DatabaseLayer.Models
{
    public class MessageStatus
    {
        public Guid ID { get; set; }

        public MessageRecipient MessageRecipient { get; set; }

        public Guid UserID { get; set; }

        public bool IsRead { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public Guid CreatedByID { get; set; }
    }
}
