#nullable enable
namespace UniT.Pooling.DI
{
    using InternalDI;

    public static class ObjectPoolManagerInternalDI
    {
        public static void AddObjectPoolManager(this DependencyContainer container)
        {
            container.AddInterfaces<ObjectPoolManager>();
        }
    }
}