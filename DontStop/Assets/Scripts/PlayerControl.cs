﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public float V0 = 0.12f; //初速度
    public Rigidbody2D rg; //玩家的rigibody
    public float jumpPower; //跳跃力量
    public bool onGround = false; //是否在地上
    public BoxCollider2D characterCollider; //玩家的碰撞体
    private float characterSizeX = 0.44f; //玩家碰撞体的X大小
    private float characterSizeY = 0.53f;  //玩家碰撞体的Y大小
    public float duckRate = 0.5f;  //下蹲改变的碰撞体大小比例
    float duckTimer;
    public float setDuckTime = 0.6f;
    public bool isDuck =false;
    //public Vector3 speed, StartPosition;
    public bool canDragMap = false;
    public float dragSpeed = 0.07f;
    public GameObject mainCamera;
    AudioSource[] audioSource;
    public GameObject controllerLeft;
    public GameObject controllerMiddle;
    public GameObject controllerRight;

    //private Animator animator;
    void Start () {
        duckTimer = setDuckTime;
        rg = GetComponent<Rigidbody2D>();  //获取玩家rigibody
        onGround = true;
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        audioSource = mainCamera.GetComponents<AudioSource>();
}
    void Update () {
        this.transform.position += new Vector3(V0, 0, 0);
        if (canDragMap)
        {
            LeftRightControl();
        }
        if (onGround)
        {
            //if (Input.GetKeyDown(KeyCode.JoystickButton6) && isDuck == false)
            if (Input.GetKeyDown(KeyCode.W) && isDuck == false)
            {
                rg.AddForce(transform.up * jumpPower);
                transform.GetComponent<ManAnim>().OnAniJump();
                audioSource[2].Play();
            }
            //if (Input.GetAxis("Down") != 0)
            if (Input.GetKeyDown(KeyCode.S))
            {
                characterCollider.size = new Vector2 (characterSizeX, characterSizeY * duckRate);
                characterCollider.offset = new Vector2(0, -characterSizeY * duckRate / 2);
                isDuck = true;
                transform.GetComponent<ManAnim>().OnAniDuck();
                audioSource[3].Play();
            }
        }
        if (isDuck)
        {
            duckTimer -= Time.deltaTime;

            if (duckTimer < 0)
            {
                characterCollider.size = new Vector2(characterSizeX, characterSizeY);
                characterCollider.offset = new Vector2(0, 0);
                duckTimer = setDuckTime;
                isDuck = false;
            }
        }
        Camera.main.transform.position += new Vector3(V0, 0, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CanDrag")
        {
            canDragMap = true;
        }
        if (collision.gameObject.tag == "CanNotDrag")
        {
            canDragMap = false;
        }
    }

    void LeftRightControl()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            controllerLeft.SetActive(true);
            controllerMiddle.SetActive(false);
            controllerRight.SetActive(false);
            audioSource[5].Play();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            controllerLeft.SetActive(false);
            controllerMiddle.SetActive(true);
            controllerRight.SetActive(false);
            audioSource[5].Pause();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            controllerLeft.SetActive(false);
            controllerMiddle.SetActive(false);
            controllerRight.SetActive(true);
            audioSource[6].Play();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            controllerLeft.SetActive(false);
            controllerMiddle.SetActive(true);
            controllerRight.SetActive(false);
            audioSource[6].Pause();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(dragSpeed, 0, 0);
            Camera.main.transform.position += new Vector3(dragSpeed, 0, 0);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(-dragSpeed, 0, 0);
            Camera.main.transform.position += new Vector3(-dragSpeed, 0, 0);
        }
    }
}
