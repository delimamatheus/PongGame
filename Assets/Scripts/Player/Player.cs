using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;

    [Header("Key Setup")]
    public KeyCode keyCodeMoveUp = KeyCode.UpArrow;
    public KeyCode keyCodeMoveDown = KeyCode.DownArrow;

    public Rigidbody2D myrigidbody2D;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyCodeMoveUp))
        {
            myrigidbody2D.MovePosition(transform.position + (transform.up * speed));
        }else if (Input.GetKey(keyCodeMoveDown))
        {
            myrigidbody2D.MovePosition(transform.position + (transform.up * -speed));
        }

    }
}
