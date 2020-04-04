using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }//End of Update


    public void switchScenes(int x)
    {
        Debug.Log("You've changed scnes to: " + x);
        SceneManager.LoadScene(x);
    }//End of switchScenes

    public void end()
    {
        Debug.Log("You've clicked the quit button! ");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif


    }//End of End






}//End of Buttons class
