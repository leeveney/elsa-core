using Elsa.Activities.Scheduling.Contracts;
using Elsa.Modules.Quartz.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Elsa.Modules.Quartz.Services;

public class QuartzSchedulingServiceProvider : ISchedulingServiceProvider
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddQuartzModule();
    }
}