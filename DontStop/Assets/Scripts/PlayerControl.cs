using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public float V0 = 0.16f; //初速度
    public Rigidbody2D rg; //玩家的rigibody
    public float jumpPower; //跳跃力量
    public bool onGround = false; //是否在地上
    public BoxCollider2D characterCollider; //玩家的碰撞体
    private float characterSizeX = 10.24f; //玩家碰撞体的X大小
    private float characterSizeY = 7.68f;  //玩家碰撞体的Y大小
    public float duckRate = 0.5f;  //下蹲改变的碰撞体大小比例
    public float duckTimer= 1.0f;
    public bool isDuck =false;
    public Vector3 speed, StartPosition;
    public bool canDragMap = false;
    public float dragSpeed = 0.05f;
    private float duckAgainTimer = 0.1f;
    void Start () {
        rg = GetComponent<Rigidbody2D>();  //获取玩家rigibody
    }
    void Update () {
        this.transform.position += new Vector3(V0, 0, 0);
        if (canDragMap)
        {
            LeftRightControl();
        }
        if (onGround)
        {
            if (Input.GetKeyDown(KeyCode.W) && isDuck == false)
            {
                rg.AddForce(transform.up * jumpPower);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                characterCollider.size = new Vector2 (characterSizeX, characterSizeY * duckRate);
                characterCollider.offset = new Vector2(0, -characterSizeY * duckRate / 2);
                isDuck = true;
            }
            
        }
        if (isDuck)
        {
            duckTimer -= Time.deltaTime;
            
            if (duckTimer < 0)
            {
                characterCollider.size = new Vector2(characterSizeX, characterSizeY);
                characterCollider.offset = new Vector2(0, 0);
                duckTimer = 1.0f;
                duckAgainTimer = 0.1f;
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
