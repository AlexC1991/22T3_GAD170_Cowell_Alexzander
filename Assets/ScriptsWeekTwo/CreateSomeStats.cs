using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;
using System.Reflection;


namespace AlexzanderCowell
{
    public class CreateSomeStats : MonoBehaviour
    {
        [Header("Character Stats")]
        private int strength = 0;
        private int aglity = 0;
        private int intelligence = 0;
        private bool Key;

        // Start 
        private void Update() 
           
        {
            Key = Input.GetButtonDown("Submit");
            
            if (Key == true)
                
            {

                int statPool = 20;
                strength = Random.Range(1, statPool);
                statPool = statPool - strength;
                aglity = Random.Range(1, statPool);
                statPool = statPool - aglity;
                intelligence = Random.Range(1, statPool);
                statPool = statPool - intelligence;

                // Output of Stats
                Debug.Log("CHARACTER STATS");
                Debug.Log("Character's Strength " + strength);
                Debug.Log("Character's Aglity " + aglity);
                Debug.Log("Character's Intelligence " + intelligence);
                Debug.Log("statPool Total " + statPool);

            }

        }

    }
}