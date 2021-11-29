using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    public int Damage = 5;
    public float Speed = 10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<LimitedMovement>().health -= Damage;
            Debug.Log(other.gameObject.GetComponent<LimitedMovement>().health);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }
}
