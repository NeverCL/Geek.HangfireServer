using System.ComponentModel.DataAnnotations;

namespace Geek.Hangfire.Core.Job
{
    /// <summary>
    /// Json断定任务
    /// 描述：请求指定Url地址获取json字符串，通过路径求出实际值与计划值比较，比较成功则通知
    /// </summary>
    public class JsonDecideJob
    {
        [Key]
        public string JobId { get; set; }
        public string Url { get; set; }
        public string JsonPath { get; set; }
        public string PlanValue { get; set; }
    }
}