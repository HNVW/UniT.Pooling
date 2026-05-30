#nullable enable
namespace UniT.Pooling.Default.DI
{
    using VContainer;

    public static class ObjectPoolManagerVContainer
    {
        public static void RegisterObjectPoolManager(this IContainerBuilder builder)
        {
            builder.Register<ObjectPoolManager>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}