using Zenject;

namespace UIService 
{
    public class UIServiceInstaller : Installer<UIServiceInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<IUIRoot>()
                .To<UIRoot>()
                .FromComponentInNewPrefabResource(nameof(UIRoot))
                .AsSingle();

            Container
                .Bind<IUIService>()
                .To<UIService>()
                .AsSingle()
                .NonLazy();
        }
    }
}
