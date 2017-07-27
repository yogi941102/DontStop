using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {
    public GameObject explosionPrefeb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            Instantiate(explosionPrefeb, this.gameObject.transform.position, Quaternion.identity);
            this.gameObject.transform.position = new Vector2(0, 1000000);
            Destroy(this.gameObject, 3);
            Invoke("GameOver", 2.0f);
        }
    }
    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
