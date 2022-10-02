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
        [Range(0, 20)]
        [SerializeField] private float statPool;
        private float strength = 0f;
        private float aglity = 0f;
        private float intelligence = 0f;
        // Start 
        void Print()
        {
            strength = Random.Range(0, 7);
            aglity = Random.Range(0, 6);
            intelligence = Random.Range(0, 7);

            Debug.Log("CHARACTER STATS");

            statPool -= strength;
            Debug.Log("Character's Strength " + strength);           

            statPool -= aglity;
            Debug.Log("Character's Aglity " + aglity);

            statPool -= intelligence;
            Debug.Log("Character's Intelligence " + intelligence);

            Debug.Log("Stat Pool Total " + statPool);
            

        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
                Print();
                
        }

    }

}
