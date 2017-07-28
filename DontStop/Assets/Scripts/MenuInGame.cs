using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInGame : MonoBehaviour {
    public GameObject menu;
    public bool showMenu = false;
    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            if (showMenu == true)
            {
                showMenu = false;
                menu.SetActive(false);
                Time.timeScale = 1;
                player.GetComponent<PlayerControl>().enabled = true;
            }
            else
            {
                showMenu = true;
                menu.SetActive(true);
                Time.timeScale = 0;
                player.GetComponent<PlayerControl>().enabled = false;
            }
        }
	}
}
