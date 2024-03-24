using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class birdController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public Vector2 jumpForce;
    public float maxVerticalVelocity = 5;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Hello world");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("Junp");
            rigidbody2D.velocity = new Vector2(0, 0);
            rigidbody2D.AddForce(jumpForce, ForceMode2D.Impulse);
            
        }

        if(rigidbody2D.velocityY > maxVerticalVelocity)
        {
            rigidbody2D.velocity = new Vector2(0, maxVerticalVelocity);
        }
    }
}
