using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexzanderCowell
{

}


public class IsThisYourCard : MonoBehaviour
{
    [SerializeField] private List<ContactDeliveryFun> contacts = new List<ContactDeliveryFun>();


    private void Start()
    {
        for(int i = 0; i < contacts.Count; i++)
        {
            contacts[0].Setup();
        }
    }
}
