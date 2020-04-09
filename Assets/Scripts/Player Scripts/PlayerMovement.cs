using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb ;
    Vector3 movement;
    public float speed = 5f;


    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
        //Getting player input to allow character to move sideways
        movement.x = Input.GetAxisRaw("Horizontal");
       
        
    }//End of update

    public void FixedUpdate()
    {
        //Update the position of the character
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }//End of FixedUpdate

    

}//End of PlayerMovement
