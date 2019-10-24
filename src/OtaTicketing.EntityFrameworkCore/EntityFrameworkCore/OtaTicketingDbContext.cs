﻿using Microsoft.EntityFrameworkCore;
using OtaTicketing.Agencies;
using OtaTicketing.Parks;
using OtaTicketing.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;

namespace OtaTicketing.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See OtaTicketingMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class OtaTicketingDbContext : AbpDbContext<OtaTicketingDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Agency> Agencys { get; set; }
        public DbSet<AgencyType> AgencyTypes { get; set; }
        public DbSet<Park> Parks { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside OtaTicketingDbContextModelCreatingExtensions.ConfigureOtaTicketing
         */

        public OtaTicketingDbContext(DbContextOptions<OtaTicketingDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable("AbpUsers"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureFullAudited();
                b.ConfigureExtraProperties();
                b.ConfigureConcurrencyStamp();
                b.ConfigureAbpUser();

                //Moved customization to a method so we can share it with the OtaTicketingMigrationsDbContext class
                b.ConfigureCustomUserProperties();
            });

            /* Configure your own tables/entities inside the ConfigureOtaTicketing method */

            builder.ConfigureOtaTicketing();
        }
    }
}
