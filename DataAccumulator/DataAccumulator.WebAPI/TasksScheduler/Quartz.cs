using Quartz;
using Quartz.Impl;
using Quartz.Spi;

namespace DataAccumulator.WebAPI.TasksScheduler
{
    public class Quartz
    {
        private IScheduler _scheduler;

        /// <summary>
        /// Used scheduler
        /// </summary>
        public static IScheduler Scheduler { get { return Instance._scheduler; } }

        // Singleton
        private static Quartz _instance = null;

        /// <summary>
        /// Singleton
        /// </summary>
        public static Quartz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Quartz();
                }
                return _instance;
            }
        }

        private Quartz()
        {
            // Initialize
            Init();
        }

        private async void Init()
        {
            // Scheduler set with standard scheduler factory
            _scheduler = await new StdSchedulerFactory().GetScheduler();
        }

        /// <summary>
        /// Defines the JobFactory from which the jobs are generated
        /// </summary>
        /// <param name="jobFactory"></param>
        /// <returns></returns>
        public IScheduler UseJobFactory(IJobFactory jobFactory)
        {
            Scheduler.JobFactory = jobFactory;
            return Scheduler;
        }

        /// <summary>
        /// Adds a new job to the scheduler
        /// </summary>
        /// <typeparam name="T">Job is generated</typeparam>
        /// <param name="name">Name of the job</param>
        /// <param name="group">Group of jobs</param>
        /// <param name="interval">Interval between execution in seconds</param>
        public async void AddJob<T>(string name, string group, int interval)
            where T : IJob
        {
            // Create a job
            IJobDetail job = JobBuilder.Create<T>()
                .WithIdentity(name, group)
                .Build();

            // Create triggers
            ITrigger jobTrigger = TriggerBuilder.Create()
                .WithIdentity(name + "Trigger", group)
                .StartNow() // Start now
                .WithSimpleSchedule(t => t.WithIntervalInMinutes(interval).RepeatForever()) // With repetition every interval minutes
                .Build();

            // Attach job
            await Scheduler.ScheduleJob(job, jobTrigger);
        }

        /// <summary>
        /// Starts the scheduler
        /// </summary>
        public static async void Start()
        {
            await Scheduler.Start();
        }
    }
}
