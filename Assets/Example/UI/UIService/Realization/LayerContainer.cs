﻿using UnityEngine;

namespace UIService
{
    public class LayerContainer : MonoBehaviour
    {
        public Transform[] Layers => layers;
        
        [SerializeField] private Transform[] layers;
    }
}