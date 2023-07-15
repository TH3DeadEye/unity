using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * (Time.deltaTime * speed), Space.Self);
            Debug.Log("Key Presed");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * (Time.deltaTime * speed), Space.Self);
            Debug.Log("Key Presed");
        }
        else
        {
            transform.Translate(Vector2.zero, Space.Self); 
        }
    }
}
