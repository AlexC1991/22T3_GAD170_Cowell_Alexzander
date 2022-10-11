using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintMyName : MonoBehaviour
{
    private TMPro.TextMeshProUGUI textMesh; // Calls for the TextMeshPro to be used in script.
    private string myName; // Variable to call to what i want it to do.

    private void Start()
    {
        textMesh = GetComponent<TMPro.TextMeshProUGUI>(); // Gets textMesh variable to use the component for the script below it to output.

        myName = "First Name: Alexzander " + "     Last Name: Cowell"; // myName variable to output a word because it's a string.
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // This script will continously be put on screen when pressing space.
        {
            textMesh.text = myName.ToString();
        }
        
    }

}
