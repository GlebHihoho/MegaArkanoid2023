using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameStateManager : MonoBehaviour
    {
        private bool gameResult;

        public event Action OnWin;
        public event Action OnLose;
        
        public void Win()
        {
            if (!gameResult)
            {
                OnWin?.Invoke();
                gameResult = true;
            }
        }

        public void Lose()
        {
            if (!gameResult)
            {
                OnLose?.Invoke();
                gameResult = true;
            }
        }
    }
}
