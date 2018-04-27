using System.ComponentModel.DataAnnotations;

namespace Geek.Hangfire.Core.Job
{
    public class JobBase
    {
        [StringLength(128)]
        public string Id { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; }
        /// <summary>
        /// 任务计划时间
        /// </summary>
        /// <returns></returns>
        public string Cron { get; set; }
    }
}