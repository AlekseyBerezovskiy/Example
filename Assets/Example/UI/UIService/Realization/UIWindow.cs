using UnityEngine;

namespace UIService
{
    public abstract class UIWindow : MonoBehaviour, IUIWindow
    {
        public abstract void Show();
        public abstract void Hide();
        public virtual void Dispose() { }
    }
}
