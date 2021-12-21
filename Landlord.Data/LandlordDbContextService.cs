using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Landlord.Data
{
    public static class LandlordDbContextService
    {
        public static IServiceCollection AddLandlordDbContext(
        
            this IServiceCollection services,
                string connectionString){
            services.AddDbContext<LandlordDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            return services;
            }
    }
}
