using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkDotController : MonoBehaviour
{
    public GameObject pinkDot;
    private static int counter;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && counter<14)
        {
            Instantiate(pinkDot, new Vector2(0f, -2.41f), Quaternion.identity);
            counter++;
            



        }


    }
}
