using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class BallsManager : MonoBehaviour
    {
        [SerializeField] private GameStateManager _gameStateManager;
        [SerializeField] private BallLauncher _ballLauncher;
        private HashSet<Ball> _balls = new HashSet<Ball>();
        
        public static BallsManager Instance => _instance;
        private static BallsManager _instance;

        private int _currentBallCount;
        
        private void Awake()
        {
            _instance = this;
            _balls = FindObjectsOfType<Ball>().ToHashSet();

            _currentBallCount = _ballLauncher.GetBallsCount();
        }

        public void DestroyBall(Ball ball)
        {
            Destroy(ball.gameObject);
            _balls.Remove(ball);
            _currentBallCount -= 1;

            if (_currentBallCount == 0)
            {
                _gameStateManager.Lose();
            }
        }
    }
}
