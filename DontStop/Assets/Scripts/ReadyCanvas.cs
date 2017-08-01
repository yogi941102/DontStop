using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyCanvas : MonoBehaviour {
    public GameObject player;
    public bool player1Ready = false;
    public bool player2Ready = false;
    public GameObject blueReady;
    public GameObject redReady;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlayerControl>().enabled = false;
    }

    // Update is called once per frame
    void Update () {
        //player1 is ready
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            blueReady.SetActive(true);
            player1Ready = true;
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            player1Ready = false;
            blueReady.SetActive(false);
        }
        
        //player2 is ready
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            redReady.SetActive(true);
            player2Ready = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            redReady.SetActive(false);
            player2Ready = false;
        }
        //都准备好,就开始游戏
        if (player1Ready == true && player2Ready == true)
        {
            Time.timeScale = 1;
            player.GetComponent<PlayerControl>().enabled = true;
            Destroy(this.gameObject, 0.5f);
            Destroy(this);
            //this.gameObject.SetActive(false);
        }

        

    }
    
}
