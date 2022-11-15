using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.XR;

namespace AlexzanderCowell
{


    public class GameManager : MonoBehaviour
    {
        [SerializeField] private BigArmy bArmy;
        private int health = 100;
        [SerializeField] private GameObject locationCharacter;
        private GameObject killCharacter;
        [SerializeField] Text clarification;
        private int morale = 100;
        
        private float xValue;
        private float yValue;
        private float zValue;
               
        private string freddy = "Player";
        private BigArmy theArmy;
        private int deleteHealth;
        private int deleteMorale;
        private bool validation;
        private BigArmy returnIt;
        [SerializeField] private GameObject thisCharacter;
        private GameObject alphaCharacter;
        [SerializeField] private List<BigArmy> armyList = new List<BigArmy>();

        private void Start()
        {
            xValue = locationCharacter.GetComponent<Transform>().position.x;
            yValue = locationCharacter.GetComponent<Transform>().position.y;
            zValue = locationCharacter.GetComponent<Transform>().position.z;
        }

            public void Spawn(){
                theArmy = Instantiate(bArmy, transform);
                theArmy._name = freddy;
                theArmy._healthy = health;
                theArmy._theMorel = morale;
                
                theArmy._character = thisCharacter;
                alphaCharacter = theArmy._character;                                                      
                theArmy._playerNumber = armyList.Count();
                clarification.text = (theArmy._name + " " + theArmy._playerNumber.ToString());
                theArmy._outPutting = clarification;
                returnIt = theArmy;
                
                 armyList.Add(returnIt);               
                
            
                killCharacter = (GameObject)Instantiate(returnIt._character, new Vector3(xValue, yValue, zValue), Quaternion.identity);
                Debug.Log("Name: " + returnIt._name + " " + returnIt._playerNumber +  "\n" + " Health: " + returnIt._healthy + " Morale : " + returnIt._theMorel);
            Debug.Log(killCharacter + "1");
        
            }

        private void Update(){
            deleteHealth = Random.Range(1, 8);
            deleteMorale = Random.Range(1, 12);
           KillIt();
            
        }

        private void KillIt()
        {
            if (Input.GetKeyDown(KeyCode.Space)){               
                validation = true;
                if (validation == true)
                {
                    foreach (BigArmy army in armyList.ToList())
                    {
                        army._healthy -= (deleteHealth);
                        army._theMorel -= (deleteMorale);

                        Debug.Log(army._theMorel + " " + army._healthy);
                        if (army._theMorel < 50){
                            army._character.GetComponentInChildren<SpriteRenderer>().color = Color.blue;
                        }
                        if (army._healthy <= 0){
                            Object.Destroy(killCharacter);
                            armyList.Clear();
                        }

                        
     
                    }                   
                }
                else 
                    validation = false;
                              
            }
  
            
        }
    }
     




}
