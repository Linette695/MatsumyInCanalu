﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres : MonoBehaviour
{
    public float delay = 0.5f;  //The delay time for the sphere to spawn  
    public GameObject sphere;   //The object for the sphere

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    // Update is called once per frame
   

    void Spawn()
    {
        Instantiate(sphere, new Vector3(Random.Range(-8, 8), 10, 0), Quaternion.identity);
    }
}