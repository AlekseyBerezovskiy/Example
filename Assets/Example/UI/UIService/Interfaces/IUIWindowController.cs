using System;

namespace UIService
{
    public interface IUIWindowController : IDisposable
    {
        void ShowWindow(int layer = 0);
        void HideWindow();
    }
}