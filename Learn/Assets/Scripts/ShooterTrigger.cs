﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTrigger : MonoBehaviour
{
    public GameObject LogShooterObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            LogShooterObject.GetComponent<LogShooter>().ShotLog("Hello");
        }   
    }
}
