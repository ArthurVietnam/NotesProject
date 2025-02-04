using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Aplication;

public static class DependencyInjection
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}