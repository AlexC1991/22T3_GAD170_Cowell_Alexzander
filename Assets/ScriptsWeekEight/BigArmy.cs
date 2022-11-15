using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlexzanderCowell
{


    public class BigArmy : MonoBehaviour
    {
        
        [HideInInspector] public GameObject _character;
        [HideInInspector] public int _healthy;
        [HideInInspector] public int _theMorel;
        [HideInInspector] public string _name;
        [HideInInspector] public int _playerNumber;
        [HideInInspector] public Text _outPutting;
        public BigArmy(string name, int playerNumber, int number1,int number2, GameObject character, Text outPutting)
        {
            _name = name;
            _playerNumber = playerNumber;
            _healthy = number1;
            _theMorel = number2;
            _character = character;
            _outPutting = outPutting;
        }
    }
}
