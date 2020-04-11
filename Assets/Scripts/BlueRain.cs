using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueRain : MonoBehaviour
{
    public float delay = 0.3f;  //The delay time for the sphere to spawn  
    public GameObject blueRain;   //The object for the sphere
    public bool spawnOn = true;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    // Update is called once per frame
    private void Update()
    {

    }
    void Spawn()
    {
        if (spawnOn == true)
        {
            Instantiate(blueRain, new Vector3(Random.Range(-9, 10), 10, 0), Quaternion.identity);
        }
       
        
    }
}//End of BlueRain class
