using System;
using UnityEngine;

namespace UIService 
{
    public interface IUIService : IDisposable
    {
        T Show<T>(int layer = 0) where T : UIWindow;
        void Hide<T>(Action onEnd = null) where T : UIWindow;
        void HideAll(Action onEnd = null);
        T Get<T>() where T : UIWindow;
    }
}
