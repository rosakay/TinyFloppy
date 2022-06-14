using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int score;
    public float JumpForce;

    Rigidbody myRigi;
    [HideInInspector]  // 隱藏以下一行，於Unity界面中設為公開的參數
    public bool isJumpPressed, gameOver;
    private void Awake()
    {
        // 取得元件
        myRigi = GetComponent<Rigidbody>();

        isJumpPressed = false;
        gameOver = false;

        score = 0;
        //JumpForce = 5.0f;
        Physics.gravity = new Vector3(0, -15.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            // 跳躍
            if (Input.GetKeyDown(KeyCode.Space))  // GetKeyDown() 必須在 Update() 執行，才能確保正常執行。
            {
                //Debug.Log("spsp");
                isJumpPressed = true;
                //canJump = false;
            }
        }

    }

    private void FixedUpdate()
    {
        if (isJumpPressed)
        {
            // Debug.Log("WTF!!");
            myRigi.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);

            isJumpPressed = false;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "DeadTouch")
        {
            gameOver = true;
            Debug.LogWarning("GameOver");
        }
    }
}
