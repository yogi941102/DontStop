using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {
    public GameObject explosionPrefeb;
    public GameObject dieCanvas;
    GameObject player;
    GameObject mainCamera;
    AudioSource[] audioSource;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        audioSource = mainCamera.GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            audioSource[4].Play();
            Instantiate(explosionPrefeb, this.gameObject.transform.position, Quaternion.identity);
            this.gameObject.transform.position = new Vector2(0, 1000000);
            Destroy(this.gameObject, 3);
            Invoke("GameOver", 1.5f);
            PauseGame();
        }
    }
    void GameOver()
    {
        dieCanvas.SetActive(true);
    }
    void PauseGame()
    {
        player.GetComponent<PlayerControl>().enabled = false;
    }
}
