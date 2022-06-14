using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float PosY;
    //Player GetPlayer;

    public GameObject[] Walls;

    static GameManager instance = null;
    private GameManager()
    {

    }
    public static GameManager Instance
    {
        get
        {
            if (instance == null) instance = new GameManager();
            return instance;
        }
    }
    private void Start()
    {
        InvokeRepeating("SpawnWall", 1.0f, 1.25f);
        Debug.Log("Start");
        //GetPlayer = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Time.timeScale = 0;
        }

    }
    private void SpawnWall()
    {
        PosY = Random.Range(-1.5f, 1.5f);
        Instantiate(Walls[0], new Vector3(25.0f, PosY, 0.0f), Walls[0].transform.rotation);
    }
}
