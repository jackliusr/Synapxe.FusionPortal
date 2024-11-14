// -------------------------------------------------------------------------------------------------
// Copyright (c) Integrated Health Information Systems Pte Ltd. All rights reserved.
// -------------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;

namespace Synapxe.FusionPortal.Data
{
    public class FhirEntityDbContext : DbContext
    {
        public FhirEntityDbContext(DbContextOptions<FhirEntityDbContext> options)
            : base(options)
        {
        }


        public DbSet<EducationEntity> Education => Set<EducationEntity>();

        public DbSet<InventoryEntity> Inventory => Set<InventoryEntity>();

        public DbSet<KtloTaskEntity> KtloTask => Set<KtloTaskEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseFhirConventions(this);
        }
    }
}
