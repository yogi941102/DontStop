using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public Rigidbody2D rg;
    // Use this for initialization
    void Start () {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        rg.velocity = new Vector2(3, 0);
    }
}
