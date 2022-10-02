using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;


namespace AlexzanderCowell
{
    public class IFStatement : MonoBehaviour
    {
        float calculatedNumber = 8f; //number of which holds base value

        // Start
        void Startcheck()
        {
            calculatedNumber = UnityEngine.Random.Range(1, 10);
            if (calculatedNumber == 8)
            {
                Debug.Log("The number was exactly 8");
            }
            else if (calculatedNumber > 5)
            {
                Debug.Log("The number was greater then 3");
            }
            else if (calculatedNumber < 6)
            {
                Debug.Log("The number was less than 3 or greater than 5");
            }
            else if (calculatedNumber != 4)
            {
                Debug.Log("The number is not 4");
            }
            else if (calculatedNumber > 3)
            {
                Debug.Log("The number was greater then 5");
            }
        }
        //Update
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Startcheck();
        }

 
        private int Add(int v1, int v2)
        {
            int result;
            int v = v1 + v2;
            result = v;

            return result;
        }
    }
}
