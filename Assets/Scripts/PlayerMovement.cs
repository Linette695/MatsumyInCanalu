using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb ;
    Vector2 movement;
    public float speed = 5f;


    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        //Getting player input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
    }//End of update

    public void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
