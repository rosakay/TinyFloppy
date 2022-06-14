using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    float ScreenBound = -16.0f;
    public float speed;
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        if(transform.position.x < ScreenBound)
        {
           Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        //Debug.Log("Im dead");
    }
}
