using UnityEngine;

namespace UIService
{
    public interface IUIRoot
    {
        Canvas Canvas { get; set; }
        Camera Camera { get; set; }
        LayerContainer Container { get; }
        Transform PoolContainer { get; }
    }
}
