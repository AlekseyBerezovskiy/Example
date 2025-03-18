using UIService;
using UnityEngine;

namespace Example.UI.UIWindows.Realization.ExampleView
{
    public class UIExampleViewController : UIWindowController<UIExampleWindow>
    {
        private const string DebugMessage = "Press";
        
        public UIExampleViewController(
            IUIService uiService) 
            : base(uiService)
        {
            uiWindow.OnPressMeButtonClickEvent += OnPressMeButtonClick;
        }

        public override void Dispose()
        {
            uiWindow.OnPressMeButtonClickEvent -= OnPressMeButtonClick;
            
            base.Dispose();
            
            // TODO: finalizing
        }

        public override void ShowWindow(int layer = 0)
        {
            base.ShowWindow(layer);
            
            // TODO: show window logic
        }

        public override void HideWindow()
        {
            base.HideWindow();
            
            // TODO: hide window logic
        }

        private void OnPressMeButtonClick()
        {
            Debug.Log(DebugMessage);
        }
    }
}