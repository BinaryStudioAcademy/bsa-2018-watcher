using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Spi;

namespace DataAccumulator.WebAPI.Jobs
{
    public static class QuartzExtensions
    {
        public static void UseQuartz(this IApplicationBuilder app)
        {
            app.ApplicationServices.GetService<IScheduler>();
        }

        public static void UseQuartz(this IApplicationBuilder app, Action<Jobs.Quartz> configuration)
        {
            // Job Factory through IOC container
            var jobFactory = (IJobFactory)app.ApplicationServices.GetService(typeof(IJobFactory));
            // Set job factory
            Jobs.Quartz.Instance.UseJobFactory(jobFactory);

            // Run configuration
            configuration.Invoke(Jobs.Quartz.Instance);
            // Run Quartz
            Jobs.Quartz.Start();
        }
    }
}
