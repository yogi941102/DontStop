using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {
    public GameObject sceneManager;
	// Use this for initialization
	void Start () {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager");

	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void OnScene(string i)
    {
        sceneManager.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(i);
    }
    public void ExitGame()
    {
        Application.Quit();
        sceneManager.GetComponent<AudioSource>().Play();
    }
}
