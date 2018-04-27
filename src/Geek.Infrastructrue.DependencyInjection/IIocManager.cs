namespace Geek.Infrastructrue.DependencyInjection
{
    public interface IIocManager
    {
        T GetService<T>();
    }
}