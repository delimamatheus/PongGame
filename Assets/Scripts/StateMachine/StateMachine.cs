using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class StateMachine : MonoBehaviour
{
    public enum States
    {
        MENU,
        PLAYING,
        RESET_POSITION,
        END_GAME
    }

    public Dictionary<States, StateBase> DictionaryState;
    private StateBase _currentState;
    private Player player;
    public float timeToStartGame = 1f;

    public static StateMachine Instance;

    private void Awake()
    {
        Instance = this;

        DictionaryState = new Dictionary<States, StateBase>();
        DictionaryState.Add(States.MENU, new StateBase());
        DictionaryState.Add(States.PLAYING, new StatePlaying());
        DictionaryState.Add(States.RESET_POSITION, new StateResetPosition());
        DictionaryState.Add(States.END_GAME, new StateBase());

        SwitchStates(States.MENU);
    }

    private void SwitchStates(States state)
    {
        if (_currentState != null) _currentState.OnStateExit();

        _currentState = DictionaryState[state];

        _currentState.OnStateEnter(player);
    }

    private void Update()
    {
        if (_currentState != null) _currentState.OnStateStay();

        if (Input.GetKeyDown(KeyCode.Space))
         {
            SwitchStates(States.PLAYING);
         }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.ResetGame();
        }
    }

    public void ResetPosition()
    {
        SwitchStates(States.RESET_POSITION);
    }
}