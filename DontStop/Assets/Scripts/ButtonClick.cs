using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {
    public GameObject mainCamera;
    AudioSource[] audioSource;
	// Use this for initialization
	void Start () {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        audioSource = mainCamera.GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void OnScene(string i)
    {
        audioSource[1].Play();
        SceneManager.LoadScene(i);
    }
    public void ExitGame()
    {
        Application.Quit();
        audioSource[1].Play();
    }
}
