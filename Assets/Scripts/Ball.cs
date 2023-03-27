using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Ball : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            // var otherBlock = collision.transform.GetComponent<Block>();
            // if (otherBlock == null) return;

            // то же самое
            if (collision.transform.TryGetComponent<Block>(out Block otherBlock))
            {
                // разрушить блок
            }
        }
    }
}