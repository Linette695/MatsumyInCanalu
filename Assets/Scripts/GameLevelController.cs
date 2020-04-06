using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if player has quitted the game using the escape key
        if (Input.GetKeyDown(KeyCode.Escape)){
            #if UNITY_EDITOR
             UnityEditor.EditorApplication.isPlaying = false;
            #else
              Application.Quit();
            #endif
        }

    }//End of Update 


}//End of GameLevelController class
