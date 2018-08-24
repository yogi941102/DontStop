﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassLevel1 : MonoBehaviour {
    public string levelName;
    GameObject player;
    public GameObject canvas;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        player.GetComponent<PlayerControl>().enabled = false;
        canvas.SetActive(true);
    }
}
