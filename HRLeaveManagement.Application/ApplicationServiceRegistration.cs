using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace HRLeaveManagement.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();

        services.AddAutoMapper(executingAssembly);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(executingAssembly));

        return services;
    }
}