using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkDotProjector : MonoBehaviour
{
    private bool isPinned;
    private float speed = 30f;
    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Black")
        {
            isPinned = true;
            transform.SetParent(collision.transform);
            Rotator.instance.ChangeColor();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!isPinned)
        {
            rigidBody.MovePosition(rigidBody.position + Vector2.up * speed * Time.deltaTime);

        }
        
    }
}
