using UnityEngine;

namespace Example.Camera.Realization
{
    public class CameraView : MonoBehaviour
    {
        public UnityEngine.Camera Camera => camera;
        
        [SerializeField] private UnityEngine.Camera camera;
    }
}