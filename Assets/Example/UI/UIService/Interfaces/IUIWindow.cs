using System;

namespace UIService 
{
    public interface IUIWindow : IDisposable
    {
        void Show();    
        void Hide();
    }
}
