using CO._2CS.GOCE.Platform.DatabaseLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CO._2CS.GOCE.Platform.DatabaseLayer.Controllers
{
    public class DefaultController : ApiController
    {
        private GOCEContext db = new GOCEContext();

        // GET: api/Default
        public IEnumerable<string> Get()
        {
            var id = Guid.NewGuid();
            var date = DateTimeOffset.Now;
            db.GeoEvent.Add(new Models.GeoEvent
            {
                ID = id,
                StartTime = date,
                EndTime = date,
                CreationTime = date,
                CreatedByID = id,
                //GeoRef = DbGeography.PointFromText(
                //       string.Format("POINT({0} {1})", -121.527200, 45.712113),
                //        4326
                //    ),
                EventTypeID = Guid.Parse("C71CCE5D-8B98-4572-5254-08D4FA5EC9BE"),
                IsCurrent = true,
                IsDeleted = false,
                OrginalID = id,
                Attributes = "",
                //OrginalID = null,
                //EventTypeID = null,
                ////GeoRef = null
            });
            db.EventType.Add(new Models.EventType
            {
                ID = Guid.NewGuid(),
                Name = "123"
            });
            db.SaveChanges();
            var test = db.GeoEvent.Count().ToString();
            return new string[] { test };
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
