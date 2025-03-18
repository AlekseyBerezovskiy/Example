namespace UIService
{
    public abstract class UIWindowController<T> : IUIWindowController where T : UIWindow
    {
        protected T uiWindow;
        
        private IUIService _uiService;
        
        public UIWindowController(
            IUIService uiService)
        {
            _uiService = uiService;
            
            uiWindow = uiService.Get<T>();
        }

        public virtual void Dispose()
        {
            _uiService = null;
            uiWindow = null;
        }

        public virtual void ShowWindow(int layer = 0)
        {
            _uiService.Show<T>(layer);
        }

        public virtual void HideWindow()
        {
            _uiService.Hide<T>();
        }
    }
}