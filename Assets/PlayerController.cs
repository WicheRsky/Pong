using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 1f;
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < 5)
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }
        
        if (Input.GetKey(downKey) && transform.position.y > -5)
        {
            transform.position -= Vector3.up * Time.deltaTime * speed;
        }
    }
}