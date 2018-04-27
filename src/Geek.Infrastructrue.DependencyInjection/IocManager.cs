using Microsoft.Extensions.DependencyInjection;

namespace Geek.Infrastructrue.DependencyInjection
{
    /// <summary>
    /// 提供底层获取上层ServiceProvider的能力
    /// </summary>
    public class IocManager
    {
        public static ServiceProvider ServiceProvider = null;
        public static T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }
    }
}