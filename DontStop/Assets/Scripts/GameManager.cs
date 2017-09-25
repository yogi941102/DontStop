using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject player;
	public GameObject tuitorialCanvas;
	public GameObject blueTuitorial;
	public GameObject redTuitorial;
	public GameObject readyCanvas;
	public Data data;

	int i =1;

	// Use this for initialization
	void Start () 
	{
		player.GetComponent<PlayerControl> ().enabled = false;
		Time.timeScale = 0;
		if (data.tutorial > 0)
		{
			readyCanvas.SetActive (true);
		}
		else 
		{
			tuitorialCanvas.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (data.tutorial == 0) 
		{
			if (Input.GetKeyUp(KeyCode.RightArrow) && i == 1)
			{
				blueTuitorial.SetActive(false);
				redTuitorial.SetActive(true);
				i++;
			}
			if (Input.GetKeyDown(KeyCode.RightArrow) && i == 2)
			{
				//blue.SetActive(false);
				//red.SetActive(false);
				readyCanvas.SetActive(true);
				data.tutorial++;
				Destroy(tuitorialCanvas.gameObject);
			}
		}
	}
}
