using System;

namespace CO._2CS.GOCE.Platform.DatabaseLayer.Models
{
    public class MessageRecipient
    {
        public Guid ID { get; set; }

        public GMessage GMessage { get; set; }

        public Guid PrincipalID { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public Guid CreatedByID { get; set; }
    }
}
