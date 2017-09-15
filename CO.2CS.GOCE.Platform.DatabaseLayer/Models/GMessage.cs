using System;

namespace CO._2CS.GOCE.Platform.DatabaseLayer.Models
{
    public class GMessage
    {
        public Guid ID { get; set; }

        public Guid SenderID { get; set; }

        public string Message { get; set; }

        public DateTimeOffset CreationTime { get; set; }
    }
}
