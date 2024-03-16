
using dotnetmastery8net.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using System.Data;
using System;
using Microsoft.Extensions.DependencyInjection;


public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("LocalDb");

       
        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
           


            options.UseSqlServer(connectionString);

        });

        //services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        //services.AddScoped<ApplicationDbContextInitialiser>();

//#if (UseApiOnly)
//        services.AddAuthentication()
//            .AddBearerToken(IdentityConstants.BearerScheme);

//        services.AddAuthorizationBuilder();

//        services
//            .AddIdentityCore<ApplicationUser>()
//            .AddRoles<IdentityRole>()
//            .AddEntityFrameworkStores<ApplicationDbContext>()
//            .AddApiEndpoints();
//#else
//        services
//            .AddDefaultIdentity<ApplicationUser>()
//            .AddRoles<IdentityRole>()
//            .AddEntityFrameworkStores<ApplicationDbContext>();
//#endif

//        services.AddSingleton(TimeProvider.System);
//        services.AddTransient<IIdentityService, IdentityService>();
//        services.AddAuthorization(options =>
//            options.AddPolicy(Policies.CanPurge, policy => policy.RequireRole(Roles.Administrator)));

        return services;
    }
}