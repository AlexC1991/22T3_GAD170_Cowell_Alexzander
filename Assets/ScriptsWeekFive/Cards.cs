using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using System.Security.Cryptography;
using System;
using UnityEngine.UI;
using System.Net.NetworkInformation;

namespace AlexzanderCowell
{

}
public class Cards : MonoBehaviour
{
    [SerializeField] private Text printCards;
    private string printCardA;
    private string printCardB;
    private string printCardC;
    private string printCardD;
    private int convertIt1;
    private int convertIt2;
    private int convertThem;



    private List<string> cardList = new List<string>();

    private List<string> cardList2 = new List<string>();

    private List<string> cardList3 = new List<string>();


    private void Awake()
    {
        cardList.Add("Clubs");
        cardList.Add("Hearts");
        cardList.Add("Spades");
        cardList.Add("Diamonds");

        cardList2.Add("2");
        cardList2.Add("3");
        cardList2.Add("4");
        cardList2.Add("5");
        cardList2.Add("6");
        cardList2.Add("7");
        cardList2.Add("8");
        cardList2.Add("9");
        cardList2.Add("10");

        cardList3.Add("Queen");
        cardList3.Add("King");
        cardList3.Add("Ace");
        cardList3.Add("Jack");
    }

    private void Start()
    {
        convertIt2 = cardList2.Count;
        convertIt1 = cardList3.Count;
        


    }

    private void Update()
    {
        printCardA = cardList[UnityEngine.Random.Range(0, cardList.Count)];
        printCardB = cardList2[UnityEngine.Random.Range(0, cardList2.Count)];
        printCardC = cardList3[UnityEngine.Random.Range(0, cardList3.Count)];
        convertThem = (UnityEngine.Random.Range(convertIt2, convertIt1));
        Convertor();
    }

    private void Convertor()
    {
        
    }

    public void NGenerator()
    {

        printCards.text = " Is your card the " + printCardB + " of " + printCardA + " ?".ToString();



    }
}
