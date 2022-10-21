using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace AlexzanderCowell
{

}
public class LeapYear : MonoBehaviour
{
    public Text answerText; // Calls for the TextMeshPro to be used in script.
    private float A = 4f;
    public TMPro.TMP_InputField yearConverstions;
    private bool yearYes = true;
    private bool yearNo = false;
    private float yearYes2 = 503f;
    private float yearNo2 = 499.25f;
    private float c;
    private float a;

    void Maths()
    {
         a = Convert.ToInt32(yearConverstions.text);
         c = a / A;
        Debug.Log(c);
        if (c <= yearNo2){
            answerText.text = yearNo.ToString();
        }

        if (c >= yearYes2)
        {
            answerText.text = yearYes.ToString();
        }

        
       
        
        
    }

    

}
