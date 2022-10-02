using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlexzanderCowell
{

    public class CoinFlip : MonoBehaviour
    {
        private float coinToss = 0;

        void Flip()
        {
            coinToss = Random.Range(0, 3);
            if (coinToss == 2)
            {
                Debug.Log("Coin Toss is Tails");
            }
            else if (coinToss == 3)
            {
                Debug.Log("Coin Toss is a Draw");
            }
            else if (coinToss == 1)
            {
                Debug.Log("Coin Toss is Heads");
            }
            else if (coinToss == 0)
            {
                Debug.Log("Try Again");
            }
        }
        void Update()
            {
                if (Input.GetKeyDown(KeyCode.Tab))
                    Flip();

            }
    }
}
