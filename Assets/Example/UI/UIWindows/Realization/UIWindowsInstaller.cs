using Example.UI.UIWindows.Realization.ExampleView;
using Zenject;

namespace Example.UI.UIWindows.Realization
{
    public class UIWindowsInstaller : Installer<UIWindowsInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<UIExampleViewController>()
                .AsSingle();
        }
    }
}