using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace VendorRegistration.API.Extensions
{
    public static class HostExtensions
    {

        public static IHost MigrateDatabase<TContext>(this IHost host,
                                                        Action<TContext, IServiceProvider> seeder,
                                                        int? retry = 0) where TContext : DbContext
        {
            int retryForAvailability = retry.Value;

            using (var scope = host.Services.CreateScope())
            {

                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<TContext>>();
                var context = services.GetService<TContext>();

                try
                {
                    logger.LogInformation("Migrating database associated with Context {DBContextName}", typeof(TContext).Name);

                    InvokeSeeder(seeder, context, services);//seeding the database

                    logger.LogInformation("Migrated database associated with Context {DBContextName}", typeof(TContext).Name);
                }
                catch (SqlException Ex)
                {

                    logger.LogError(Ex, "An Error Occured when trying to Migrate the databse");

                    if(retryForAvailability <50)
                    {
                        retryForAvailability++;
                        System.Threading.Thread.Sleep(2000);
                        MigrateDatabase<TContext>(host, seeder, retryForAvailability);
                    }
                }

            }
            return host;
        }

        private static void InvokeSeeder<TContext>(Action<TContext, IServiceProvider> seeder, 
                                                                TContext context, 
                                                                IServiceProvider services) 
                                                                where TContext : DbContext
        {
            context.Database.Migrate();
            seeder(context, services);
        }

        
    }
}
