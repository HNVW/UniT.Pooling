#nullable enable
namespace UniT.Pooling.Default.DI
{
    using Zenject;

    public static class ObjectPoolManagerZenject
    {
        public static void BindObjectPoolManager(this DiContainer container)
        {
            container.BindInterfacesTo<ObjectPoolManager>().AsSingle();
        }
    }
}