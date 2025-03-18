using System;
using UIService;
using UnityEngine;
using UnityEngine.UI;

namespace Example.UI.UIWindows.Realization.ExampleView
{
    public class UIExampleWindow : UIWindow
    {
        public event Action OnPressMeButtonClickEvent;

        [SerializeField] private Button pressMeButton;
        
        public override void Show()
        {
            pressMeButton.onClick.AddListener(OnPressMeButtonClick); 
        }

        public override void Hide()
        {
            pressMeButton.onClick.RemoveListener(OnPressMeButtonClick);
        }

        private void OnPressMeButtonClick()
        {
            OnPressMeButtonClickEvent?.Invoke();
        }
    }
}