using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Spi;

namespace DataAccumulator.WebAPI.TasksScheduler
{
    public static class QuartzExtensions
    {
        public static void UseQuartz(this IApplicationBuilder app)
        {
            app.ApplicationServices.GetService<IScheduler>();
        }

        public static void UseQuartz(this IApplicationBuilder app, Action<TasksScheduler.Quartz> configuration)
        {
            // Job Factory through IOC container
            var jobFactory = (IJobFactory)app.ApplicationServices.GetService(typeof(IJobFactory));
            // Set job factory
            TasksScheduler.Quartz.Instance.UseJobFactory(jobFactory);

            // Run configuration
            configuration.Invoke(TasksScheduler.Quartz.Instance);
            // Run Quartz
            TasksScheduler.Quartz.Start();
        }
    }
}
