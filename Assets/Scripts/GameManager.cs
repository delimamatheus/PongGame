using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallBase ball;
    public Player player1;
    public Player player2;


    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void ResetPositions()
    {
        ball.CanMove(false);
        player1.CanMove(false);
        player2.CanMove(false);
        ball.ResetBall();
        player1.ResetPlayerPosition();
        player2.ResetPlayerPosition();
    }

    public void StartGame()
    {
        ball.CanMove(true);
        player1.CanMove(true);
        player2.CanMove(true);
    }

    public void ResetGame()
    {
        ResetPositions();
        ResetPoints();
    }

    public void ResetPoints()
    {
        player1.currentPoints = 0;
        player2.currentPoints = 0;
        player1.updateUI();
        player2.updateUI();
    }
}
