using Microsoft.Extensions.DependencyInjection;

using Sample.ElasticApm.Domain.Application;
using Sample.ElasticApm.Domain.Interface;
using Sample.ElasticApm.WebApi.Core.HealthCheck;

namespace Sample.ElasticApm.WebApi.Core.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<ISampleApplication, SampleApplication>();
            services.AddTransient<IMyCustomService, MyCustomService>();
        }
    }
}