﻿using CO._2CS.GOCE.Platform.DatabaseLayer.Models;
using System.Data.Entity;

namespace CO._2CS.GOCE.Platform.DatabaseLayer.Contexts
{
    public class GOCEContext : DbContext
    {
        const string SCHEMA_NAME = "GOCE";

        public GOCEContext() : base("GOCEContext")
        {
        }

        public DbSet<EventType> EventType { get; set; }
        //public DbSet<GeoEvent> GeoEvent { get; set; }
        //public DbSet<GMessage> GMessage { get; set; }
        //public DbSet<MessageRecipient> MessageRecipient { get; set; }
        //public DbSet<MessageStatus> MessageStatus { get; set; }
        //public DbSet<Recurrence> Recurrence { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<GeoEvent>()
            //    .HasRequired(ge => ge.OriginalGeoEvent)
            //    .WithRequiredDependent()
            //    .Map(config => config.MapKey("OriginalID"));

            //modelBuilder.Entity<GeoEvent>().ToTable("GeoEvent", SCHEMA_NAME);

            base.OnModelCreating(modelBuilder);
        }
    }
}