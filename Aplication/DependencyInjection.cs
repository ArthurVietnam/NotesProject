using System.Reflection;
using Aplication.Common.Behaviors;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Aplication;

public static class DependencyInjection
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
        services.AddTransient(typeof(IPipelineBehavior<,>),typeof(ValidationBehavior<,>));
        return services;
    }
}