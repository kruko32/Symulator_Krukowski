﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizja : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
           
        }

    private void OnCollisionEnter(Collision collision)
    {
        Application.Quit();
    }

}


