// -------------------------------------------------------------------------------------------------
// Copyright (c) Integrated Health Information Systems Pte Ltd. All rights reserved.
// -------------------------------------------------------------------------------------------------

using Ihis.FhirEngine.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Synapxe.FusionPortal.Data
{
    public class FhirEntityDbContext : DbContext
    {
        public FhirEntityDbContext(DbContextOptions<FhirEntityDbContext> options)
            : base(options)
        {
        }


        public DbSet<KtloTaskEntity> KtloTask => Set<KtloTaskEntity>();

        public DbSet<KtloActivityEntity> KtloActivity => Set<KtloActivityEntity>();

        public DbSet<DocumentReferenceEntity> DocumentReference => Set<DocumentReferenceEntity>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityTypes = modelBuilder.Model.GetEntityTypes().ToList();


            modelBuilder.Entity<DocumentReferenceEntity>()
                .OwnsMany(x => x.Identifier, o => o.ToJson())
                .OwnsMany(x=> x.Category, o => o.ToJson())
                .OwnsMany(x => x.Author, o => o.ToJson())
                .OwnsMany(x => x.RelatesTo, o => o.ToJson())
                .OwnsMany(x => x.SecurityLabel, o => o.ToJson())
                .OwnsMany(x => x.Event, o => o.ToJson())
                .OwnsMany(x=> x.Content, o => o.ToJson())
                .OwnsMany(x => x.BodySite, o => o.ToJson());

            modelBuilder.UseFhirConventions(this);
        }
    }
}
