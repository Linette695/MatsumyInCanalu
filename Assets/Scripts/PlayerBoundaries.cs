using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundaries : MonoBehaviour
{
    private Vector2 scrBoundaries;  //Will hold the screen boundaries
    public Camera MainCamera;   //Will hold the main camera of the scene 
    // Start is called before the first frame update
    void Start()
    {
        //Obtain the current screen boundaries
        scrBoundaries = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));

    }//End of Start

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPosition = transform.position;
        viewPosition.x = Mathf.Clamp(viewPosition.x, scrBoundaries.x * -1, scrBoundaries.x);
        transform.position = viewPosition;
        
    }//End of LateUpdate


}//End of PlayerBoundaries class
