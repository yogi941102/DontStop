using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {
    public GameObject readyCanvas;
    public GameObject player;
    public GameObject blue;
    public GameObject red;
    int i = 1;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlayerControl>().enabled = false;
        Time.timeScale = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.RightArrow) && i == 1)
        {
            blue.SetActive(false);
            red.SetActive(true);
            Debug.Log(i);
            i++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && i == 2)
        {
            Debug.Log(i);
            //blue.SetActive(false);
            //red.SetActive(false);
            readyCanvas.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
