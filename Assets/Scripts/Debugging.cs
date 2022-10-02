using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;

namespace AlexzanderCowell
{
    public class Debugging : MonoBehaviour
{   
        [SerializeField] private string favouriteGame = "World of Tanks";
        [SerializeField] private int hoursPlayed = 5000;
        [SerializeField] private int gamePrice = 0; 
        // Start 
        void Start()
        {

            Debug.Log("My favourite game is " + favouriteGame);
            Debug.Log("Hours i have Played is " + hoursPlayed);
            Debug.Log("The Price of the Game is " + gamePrice);
        }

    }
}

