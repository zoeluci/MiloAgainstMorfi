using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public float fruitSpeed;
    public Vector2 movementDirection;
    void Update()
    {
        transform.Translate(fruitSpeed * movementDirection.x, fruitSpeed * movementDirection.y, 0);

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.GetComponent<TurnTrigger>() != null)
        {
            movementDirection = col.gameObject.GetComponent<TurnTrigger>().turnDirection;
        }
    }
}
