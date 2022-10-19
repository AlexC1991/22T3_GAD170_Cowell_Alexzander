using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlexzanderCowell
{

}


public class ContactDeliveryFun : MonoBehaviour { 

    // Character 1
    [SerializeField] TMPro.TMP_InputField nameInput1;
    [SerializeField] TMPro.TMP_InputField phonenumberInput1;
    [SerializeField] TMPro.TMP_InputField preferrednameInput1;
    [SerializeField] TMPro.TMP_InputField emailInput1;
    [SerializeField] TMPro.TMP_InputField addressInput1;

    // Character 2
    [SerializeField] TMPro.TMP_InputField nameInput2;
    [SerializeField] TMPro.TMP_InputField phonenumberInput2;
    [SerializeField] TMPro.TMP_InputField preferrednameInput2;
    [SerializeField] TMPro.TMP_InputField emailInput2;
    [SerializeField] TMPro.TMP_InputField addressInput2;

    // Character 3
    [SerializeField] TMPro.TMP_InputField nameInput3;
    [SerializeField] TMPro.TMP_InputField phonenumberInput3;
    [SerializeField] TMPro.TMP_InputField preferrednameInput3;
    [SerializeField] TMPro.TMP_InputField emailInput3;
    [SerializeField] TMPro.TMP_InputField addressInput3;

    // Character 1
    [SerializeField] Text printName1;
    [SerializeField] Text printPhone1;
    [SerializeField] Text printEmail1;
    [SerializeField] Text printAddress1;
    [SerializeField] Text printPreferred1;

    // Character 2
    [SerializeField] Text printName2;
    [SerializeField] Text printPhone2;
    [SerializeField] Text printEmail2;
    [SerializeField] Text printAddress2;
    [SerializeField] Text printPreferred2;

    // Character 3
    [SerializeField] Text printName3;
    [SerializeField] Text printPhone3;
    [SerializeField] Text printEmail3;
    [SerializeField] Text printAddress3;
    [SerializeField] Text printPreferred3;

    // Character 1
    private string firstlastName1;
    private string phoneNumber1;
    private string preferredName1;
    private string email1;
    private string Address1;
   
    // Character 2
    private string firstlastName2;
    private string phoneNumber2;
    private string preferredName2;
    private string email2;
    private string Address2;
    private string firstlastName3;
    
    // Character 3
    private string phoneNumber3;
    private string preferredName3;
    private string email3;
    private string Address3;


    public void Setup()
    {

        // Character 3
        firstlastName1 = nameInput1.text;
        phoneNumber1 = phonenumberInput1.text;
        preferredName1 = preferrednameInput1.text;
        email1 = emailInput1.text;
        Address1 = addressInput1.text;

        // Character 2
        firstlastName2 = nameInput2.text;
        phoneNumber2 = phonenumberInput2.text;
        preferredName2 = preferrednameInput2.text;
        email2 = emailInput2.text;
        Address2 = addressInput2.text;

        // Character 3
        firstlastName3 = nameInput3.text;
        phoneNumber3 = phonenumberInput3.text;
        preferredName3 = preferrednameInput3.text;
        email3 = emailInput3.text;
        Address3 = addressInput3.text;

    }

    public void Printit()
    {
        Character1();
        Character2();
        Character3();
       
    }

    public void Character1()
    {

        printName1.text = "My Name is " + firstlastName1.ToString();
        printPhone1.text = "My Phone Number is " + phoneNumber1.ToString();
        printEmail1.text = "My Email is " + email1.ToString();
        printAddress1.text = "My Address is " + Address1.ToString();
        printPreferred1.text = "My Preferred Name is " + preferredName1.ToString();
            
        Debug.Log("Character 1");
            Debug.Log(firstlastName1);
            Debug.Log(phoneNumber1);
            Debug.Log(email1);
            Debug.Log(Address1);
            Debug.Log(preferredName1);


    }

    public void Character2()
    {
        printName2.text = "My Name is " + firstlastName2.ToString();
        printPhone2.text = "My Phone Number is " + phoneNumber2.ToString();
        printEmail2.text = "My Email is " + email2.ToString();
        printAddress2.text = "My Address is " + Address2.ToString();
        printPreferred2.text = "My Preferred Name is " + preferredName2.ToString();

        Debug.Log("Character 2");
        Debug.Log(firstlastName2);
        Debug.Log(phoneNumber2);
        Debug.Log(email2);
        Debug.Log(Address2);
        Debug.Log(preferredName2);

    }

    public void Character3()
    {
        printName3.text = "My Name is " + firstlastName3.ToString();
        printPhone3.text = "My Phone Number is " + phoneNumber3.ToString();
        printEmail3.text = "My Email is " + email3.ToString();
        printAddress3.text = "My Address is " + Address3.ToString();
        printPreferred3.text = "My Preferred Name is " + preferredName3.ToString();

        Debug.Log("Character 3");
        Debug.Log(firstlastName3);
        Debug.Log(phoneNumber3);
        Debug.Log(email3);
        Debug.Log(Address3);
        Debug.Log(preferredName3);
    }
}

