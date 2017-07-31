using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerarelated : MonoBehaviour
{
    public Transform target;
    public GameObject player;
    public GameObject Eyes;
    public float cameraOffset = 3.0f;
    //Vector2 cameraPos;
    //Vector2 playerPos;
    //private float V0;
    public PlayerControl pc;
    // Use this for initialization
    void Start()
    {
        //def = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    //    cameraPos = Eyes.transform.position;
    //    playerPos = player.transform.position;
        //this.transform.position = player.transform.position + def;
        //V0 = player.gameObject.GetComponent<PlayerControl>().V0;
        
        //Eyes.transform.position += pc.speed;
        //if (playerPos.x>cameraPos.x - cameraOffset)
        //{
        //    V0 = player.gameObject.GetComponent<PlayerControl>().V0;
        //    Eyes.transform.position = Vector2.MoveTowards(cameraPos, new Vector2(playerPos.x + cameraOffset, cameraPos.y), Time.deltaTime*V0);
        //}
    }
}



