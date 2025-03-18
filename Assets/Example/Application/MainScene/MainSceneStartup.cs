using Example.Camera.Realization;
using Example.UI.UIWindows.Realization.ExampleView;
using UIService;

namespace Example.Application.MainScene
{
    public class MainSceneStartup
    {
        public MainSceneStartup(
            IUIRoot uiRoot,
            CameraView cameraView,
            UIExampleViewController exampleViewController)
        {
            uiRoot.Camera = cameraView.Camera;
            
            exampleViewController.ShowWindow();
        }
    }
}
