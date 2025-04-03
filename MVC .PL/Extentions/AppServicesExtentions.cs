using Microsoft.Extensions.DependencyInjection;
using MVC.BLL;
using MVC.BLL.Interfaces;
using MVC.BLL.Repositories;

namespace MVC_.PL.Extentions
{
    public static class AppServicesExtentions
    {
        public static IServiceCollection AddApplictionServices(this IServiceCollection services)
        {
            //services.AddScoped<IDapartmentRepository, DepartmentRepository>();
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            // Add IDapartmentRepository and DepartmentRepository to services

            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
