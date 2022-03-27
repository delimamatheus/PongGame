using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D myrigidbody2D;
    public bool _canMove = false;

    [Header("Key Setup")]
    public KeyCode keyCodeMoveUp = KeyCode.UpArrow;
    public KeyCode keyCodeMoveDown = KeyCode.DownArrow;

    [Header("Initial Position")]
    private Vector3 _startPosition;

    [Header("Points")]
    public int currentPoints;
    public TextMeshProUGUI uiTextPoint;

    private void Awake()
    {
        _startPosition = transform.position;
        ResetPlayer();
    }

    private void ResetPlayer()
    {
        currentPoints = 0;
        updateUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_canMove) return;

        if (Input.GetKey(keyCodeMoveUp))
        {
            myrigidbody2D.MovePosition(transform.position + (transform.up * speed));
        }else if (Input.GetKey(keyCodeMoveDown))
        {
            myrigidbody2D.MovePosition(transform.position + (transform.up * -speed));
        }

    }

    public void AddPoint()
    {
        currentPoints++;
        updateUI();
    }

    public void updateUI()
    {
        uiTextPoint.text = currentPoints.ToString();
    }

    public void CanMove(bool state)
    {
        _canMove = state;
    }

    public void ResetPlayerPosition()
    {
        transform.position = _startPosition;
    }
}
