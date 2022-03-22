using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallBase ball;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void ResetBallPosition()
    {
        ball.ResetBall();
    }
}
