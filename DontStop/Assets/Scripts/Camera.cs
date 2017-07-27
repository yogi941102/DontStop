using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public Transform target;
    public GameObject player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.LookAt(target);
        this.gameObject.transform.position = new Vector3(player.gameObject.transform.position.x, player.gameObject.transform.position.y, -10);
    }
}
