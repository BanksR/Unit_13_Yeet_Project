﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTrap : MonoBehaviour
{
    private Animator anim;

	// Use this for initialization
	void Awake ()
    {
        anim = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {

            anim.SetTrigger("Trap");
        }
	}
}
