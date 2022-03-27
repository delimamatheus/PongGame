using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    public Player player;
    public string tagToCheck = "Ball";
    public int lastWinner;
    public static TriggerPoint Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == tagToCheck)
        {
            CountPoint();
            Debug.Log(player.name);
            Debug.Log(lastWinner);
        }
    }

    private void CountPoint()
    {
        StateMachine.Instance.ResetPosition();
        player.AddPoint();

        if (player.name == "Player1") lastWinner = 1;

        if (player.name == "Player2") lastWinner = 2;

    }


}
