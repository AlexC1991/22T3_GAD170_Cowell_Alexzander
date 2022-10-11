using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexzanderCowell 
{

    public class PowerLevel : MonoBehaviour {
        [SerializeField] private int strengthOne;
        [SerializeField] private int agilityOne;
        [SerializeField] private int intelligenceOne;
        private int strengthTwo = 5;
        private int agilityTwo = 5;
        private int intelligenceTwo = 10;
        private int totalOne;
        private float totalX2One;
        private float totalX3One;
        private int totalTwo;
        private float totalX2Two;
        private float totalX3Two;
        private float WinnerIs;
        private float Percentage;


        private void Update() {

            if (Input.GetKeyDown(KeyCode.Return)){

                totalOne = strengthOne * (2) + agilityOne;

                totalX2One = (float)(totalOne * (1.5));

                totalX3One = totalX2One + intelligenceOne;

            }

            if (Input.GetKeyDown(KeyCode.Return))
            {

                totalTwo = strengthTwo * (2) + agilityTwo;

                totalX2Two = (float)(totalTwo * (1.5));

                totalX3Two = totalX2Two + intelligenceTwo;

                Percentage = (totalX3One / totalX3Two) * 100;

            }

            if (Input.GetKeyDown(KeyCode.Return)) 
            {
                StartSummary();
            }
            
            void StartSummary()
            {
                if (totalX3One > totalX3Two)
                {
                    Debug.Log("The Winner is Player One!");
                }
                else Debug.Log("The Winner is Player Two!");

                Debug.Log("Player one had " + totalX3One + " power level");
                Debug.Log("Player two had " + totalX3Two + " power level");
                Debug.Log("The winner won by " + Percentage + " percent.");
            }



        } 
      }





}
