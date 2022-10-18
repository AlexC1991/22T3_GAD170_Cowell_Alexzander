using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace AlexzanderCowell
{

}
public class Conversions : MonoBehaviour
{
   [SerializeField] TMPro.TMP_InputField tempConversion;
   [SerializeField] Text tempAnswer;
     float t;
     float e;
     public float z;
    public void ConversionStart()
    {
         t = Convert.ToInt32(tempConversion.text);
         e = t - 32;
         z = (float)(e * 0.5556);
        Debug.Log(z);
        Answer();
    }

   public void Answer()
    {
        tempAnswer.text = z.ToString() + "C";
    }

}
