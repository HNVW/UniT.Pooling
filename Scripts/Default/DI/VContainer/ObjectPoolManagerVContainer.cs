#nullable enable
namespace UniT.Pooling.DI
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