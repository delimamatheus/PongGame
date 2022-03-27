using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallBase ball;

    public float timeSetBallFree = 1f;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void ResetBall()
    {
        ball.CanMove(false);
        ball.ResetBall();
        Invoke(nameof(SetBallFree), timeSetBallFree);
    }

    private void SetBallFree()
    {
        ball.CanMove(true);
    }

    public void StartGame()
    {
        ball.CanMove(true);
    }
}
