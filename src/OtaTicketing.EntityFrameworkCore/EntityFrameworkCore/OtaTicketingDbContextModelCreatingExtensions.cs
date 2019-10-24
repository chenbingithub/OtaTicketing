using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OtaTicketing.Agencies;
using OtaTicketing.Parks;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace OtaTicketing.EntityFrameworkCore
{
    public static class OtaTicketingDbContextModelCreatingExtensions
    {
        public static void ConfigureOtaTicketing(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Park>(b =>
            {
                b.ToTable(OtaTicketingConsts.DbTablePrefix+typeof(Park).Name);
                b.ConfigureExtraProperties();
            });
            builder.Entity<Agency>(b =>
            {
                b.ToTable(OtaTicketingConsts.DbTablePrefix + typeof(Agency).Name);
                b.ConfigureExtraProperties();
            });
            builder.Entity<AgencyType>(b =>
            {
                b.ToTable(OtaTicketingConsts.DbTablePrefix + typeof(AgencyType).Name);
                b.ConfigureExtraProperties();
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}