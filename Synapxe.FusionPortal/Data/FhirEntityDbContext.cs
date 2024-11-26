// -------------------------------------------------------------------------------------------------
// Copyright (c) Integrated Health Information Systems Pte Ltd. All rights reserved.
// -------------------------------------------------------------------------------------------------

using Ihis.FhirEngine.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synapxe.FusionPortal.Model;
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


        public DbSet<InventoryEntity> Inventory => Set<InventoryEntity>();

        public DbSet<ActivityEntity> Activity => Set<ActivityEntity>();

        public DbSet<TestActivityEntity> TestActivity => Set<TestActivityEntity>();

        public DbSet<ApplicationEntity> Application => Set<ApplicationEntity>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseFhirConventions(this);
        }

        // FlattenObject, automapper<ApplicationEntity,FlattenObject>
        public List<ApplicationEntity>GetAPplications()
        {
             return this.Application.Where(x => x.Name == "Test").ToList();
        }
    }
}
