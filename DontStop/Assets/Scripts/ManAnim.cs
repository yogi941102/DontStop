﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManAnim : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = transform.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnAniDuck()
    {
        anim.SetTrigger("duck");
    }
    public void OnAniJump()
    {
        anim.SetTrigger("jump");
    }
}
