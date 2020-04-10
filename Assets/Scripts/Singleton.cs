using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reference: based on the youtube tutorial https://www.youtube.com/watch?v=CPKAgyp8cno
public class Singleton : MonoBehaviour
{

    public static Singleton Instance { get; private set; }

    public PlayerInfo info;



    private void Awake()
    {
        //info = GameObject.Find("PlayerInfo").GetComponent<PlayerInfo>();
        info = new PlayerInfo();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }
    }
}//End of Singleton class
