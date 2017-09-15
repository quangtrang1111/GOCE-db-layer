using System;
using System.Data.Entity.Spatial;

namespace CO._2CS.GOCE.Platform.DatabaseLayer.Models
{
    public class GeoEvent
    {
        //internal GeoEvent OriginalGeoEvent { get; private set; }

        public Guid ID { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset EndTime { get; set; }

        //public DbGeography GeoRef { get; set; }

        public Guid OrginalID { get; set; }

        public Guid EventTypeID { get; set; } // TODO

        public string Attributes { get; set; }

        public bool IsCurrent { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public Guid CreatedByID { get; set; }
    }
}
