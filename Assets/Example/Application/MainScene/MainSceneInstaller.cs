using Example.Camera.Realization;
using Example.UI.UIWindows.Realization;
using UIService;
using Zenject;

namespace Example.Application.MainScene
{
    public class MainSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            UIServiceInstaller.Install(Container);
            UIWindowsInstaller.Install(Container);
            
            Container
                .Bind<CameraView>()
                .FromResources(nameof(CameraView))
                .AsSingle();
            
            Container
                .Bind<MainSceneStartup>()
                .AsSingle()
                .NonLazy();
        }
    }
}