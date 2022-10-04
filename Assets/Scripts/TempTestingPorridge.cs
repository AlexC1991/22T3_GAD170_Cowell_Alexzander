using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlexzanderCowell
{
}
public class TempTestingPorridge : MonoBehaviour{
     
    [Range(50, 120)]
    [SerializeField] private float porridgeTesting;
    [Range(0,10)]
    [SerializeField] private float porridgeCooking;
    private float porridgeTooHot = 70f;
    private float porridgeTooCold = 40f;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            porridgeTesting -= porridgeCooking;

            PorridgeTest();
        }

        
    }

    private void PorridgeTest(){
        Debug.Log("What is the Current Temp? " + (int)porridgeTesting);

        if (porridgeTooHot < porridgeTesting){
            Debug.Log("Porridge is Too Hot");
        }

        else if (porridgeTooCold > porridgeTesting){
            Debug.Log("Porridge is too Cold");
        }

        else{
            Debug.Log("Porridge is just Right");
        }
    }


}
