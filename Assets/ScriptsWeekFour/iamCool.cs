using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexzanderCowell
{

}
public class imSoCool : MonoBehaviour
{
    [SerializeField] Conversions convertThis;
    private float A = 10f;
    private float B = 20f;
    private float C = 13f;
    private float D = 14f;
    private float E = 30f;
    private float F = 40f;
    private float G = 35f;
    private float H = 37f;

    private void Start()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            bool v = GetComponent<Conversions>().z <= A;
            Debug.Log("Temp 0-10 then Very Cold weather");
        }
    }



}
