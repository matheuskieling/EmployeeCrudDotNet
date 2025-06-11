using EmployeeAdminPortal2.Data.Repositories;
using EmployeeAdminPortal2.Data.Repositories.Interfaces;
using EmployeeAdminPortal2.Services;
using EmployeeAdminPortal2.Services.Interfaces;

namespace EmployeeAdminPortal2.Config;

public static class DependencyInjection
{
    public static void InitDependencyInjection(this IServiceCollection services)
    {
        #region Services
            services.AddScoped<IEmployeeService, EmployeeService>();
        #endregion
        
        #region Repositories
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        #endregion
    }
}