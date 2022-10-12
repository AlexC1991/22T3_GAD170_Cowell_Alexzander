using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlexzanderCowell
{

}
public class LeapYear : MonoBehaviour
{
    private TMPro.TextMeshProUGUI textMesh; // Calls for the TextMeshPro to be used in script.
    private string yearAnswer; // Variable to call to what i want it to do.
    InputField yearField;


    private void Update()
    {
        
    }

    private void Start()
    {
        textMesh = GetComponent<TMPro.TextMeshProUGUI>(); // Gets textMesh variable to use the component for the script below it to output.

    }
}
