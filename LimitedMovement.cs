using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedMovement : MonoBehaviour
{
    private Vector2 TargetPos;
    public float Ymovement;
    public float Speed;
    public float MaxY;
    public float MinY;
    public int health = 100;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, TargetPos, Speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxY)
        {
            TargetPos = new Vector2(transform.position.x, transform.position.y + Ymovement);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > MinY)
        {
            TargetPos = new Vector2(transform.position.x, transform.position.y - Ymovement);
        }
    }
}
