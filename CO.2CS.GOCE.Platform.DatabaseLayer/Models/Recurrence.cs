using System;

namespace CO._2CS.GOCE.Platform.DatabaseLayer.Models
{
    public class Recurrence
    {
        public Guid ID { get; set; }

        public GeoEvent GeoEvent { get; set; }

        public DateTimeOffset CreationTime { get; set; }
    }
}
