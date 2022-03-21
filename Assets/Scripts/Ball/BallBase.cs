using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public Vector3 speed = new Vector3(1, 1, 0);
    public string keyToCheck = "Player";

    [Header("Randomization")]
    public Vector2 randSpeedY = new Vector2(1, 3);
    public Vector2 randSpeedX = new Vector2(1, 3);

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == keyToCheck)
        {
            OnPlayerCollision();
        }
        else
        { 
            speed.y *= -1;
        }
    }

    private void OnPlayerCollision()
    {

        // Randomizando X

        speed.x *= -1;

        float rand = Random.Range(randSpeedX.x, randSpeedX.y);

        if(speed.x < 0)
        {
            rand = -rand;
        }

        speed.x = rand;

        // Randomizando Y

        rand = Random.Range(randSpeedY.x, randSpeedY.y);

        speed.y = rand;
    }
}