using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class LaserPointerView : MonoBehaviour
    {
        [SerializeField] private AimInputProviderBase _aimInputProvider;
        
        private void Update()
        {
            // Повернуться в сторону прицела
            Vector3 targetPoint = _aimInputProvider.GetAimTarget();
            //
            // transform.up = targetPoint - transform.position;

            // Следить за позицией игрока
        }
    }
}