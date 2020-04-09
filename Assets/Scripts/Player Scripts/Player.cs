using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Sphere"))
        {
            Debug.Log("Character has touched sphere");
        }

    }//End of OnCollision2D
}
