﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        //Debug.LogFormat ("collision is (0)",collision.gameObject.tag);
        if (collision.gameObject.tag == "Red")
        {
            Destroy(collision.gameObject);
        }

    }	
}
