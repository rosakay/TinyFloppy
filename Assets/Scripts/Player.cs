using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int score;
    public float JumpForce;

    Rigidbody myRigi;
    [HideInInspector]  // ���åH�U�@��A��Unity�ɭ����]�����}���Ѽ�
    public bool isJumpPressed, gameOver;
    private void Awake()
    {
        // ���o����
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
            // ���D
            if (Input.GetKeyDown(KeyCode.Space))  // GetKeyDown() �����b Update() ����A�~��T�O���`����C
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
