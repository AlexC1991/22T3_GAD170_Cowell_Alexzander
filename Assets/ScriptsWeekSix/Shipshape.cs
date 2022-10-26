using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlexzanderCowellAndKayBarhoum
{

}
public class Shipshape : MonoBehaviour
{
    [SerializeField] private Text outPut;
    [SerializeField] private GameObject thisCube;
    private float T;
    private float Y;
    private float moveSpeed = 10;
    private bool newPostion = false;
    void Update()

    {
        T = GetComponent<Transform>().position.x;
        Y = GetComponent<Transform>().position.y;


        if (Input.GetButton("Horizontal"))
        {
            thisCube.transform.position += new Vector3(Input.GetAxis("Horizontal"), 0) * Time.deltaTime * moveSpeed;
        }



        if (T < 0)
        {
            newPostion = false;

        }
        else
            newPostion = true;

        if (newPostion == true)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            outPut.text = " Color is RED ".ToString();

        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
            outPut.text = " Color is BLUE ".ToString();

        }

    }

}
