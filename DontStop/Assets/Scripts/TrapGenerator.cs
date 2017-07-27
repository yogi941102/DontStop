using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapGenerator : MonoBehaviour {
    public GameObject[] traps;
    public GameObject trapGenerator;
    private int index;
    private float nowTime = 0;
    public float freshTime = 3.5f;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        nowTime += Time.deltaTime;
        if (nowTime > freshTime)
        {
            index = Random.Range(0, traps.Length);
            Instantiate(traps[index], trapGenerator.transform.position, Quaternion.identity);
            nowTime = 0;
        }
    }
}
