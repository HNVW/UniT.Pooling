#nullable enable
namespace UniT.Pooling.Default.DI
{
    using UniT.DI;

    public static class ObjectPoolManagerInternalDI
    {
        public static void AddObjectPoolManager(this DependencyContainer container)
        {
            container.AddInterfaces<ObjectPoolManager>();
        }
    }
}