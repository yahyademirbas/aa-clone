using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //public GameObject rotator;
    SpriteRenderer rotatorRenderer;

    public static Rotator instance;

    public void Awake()
    {
        instance = this;
    }

    float rotationSpeed = 100f;
    float red=42, green=54, blue=59;
    // Start is called before the first frame update
    void Start()
    {
        rotatorRenderer = GetComponent<SpriteRenderer>();
        
    }
    public void ChangeColor()
    {
        if(red< 217 && green< 72 && blue< 91) {
            red += 13.5f;
            green += 1.4f;
            blue += 2.5f;
            
        rotatorRenderer.color = new Color(red / 255f, green / 255f, blue / 255f);
        }
        else
        rotatorRenderer.color = new Color(232f / 255f, 74f / 255f, 95f / 255f);

    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        
    }
}
