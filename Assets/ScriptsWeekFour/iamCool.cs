using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexzanderCowell
{

}
public class imSoCool : MonoBehaviour
{
    [SerializeField] Conversions conversions;

    private float A = 10f;
   

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            bool conversions = GetComponent<Conversions>().z < A;
            Debug.Log("Temp 0-10 then Very Cold weather");
        }
    }



}
