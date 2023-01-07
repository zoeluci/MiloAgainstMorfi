using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    float fruitSpeed = 3f;
    public Vector2 movementDirection = new Vector2(1,0);
    void Update()
    {
        transform.Translate(fruitSpeed * movementDirection.x * Time.deltaTime, fruitSpeed * movementDirection.y * Time.deltaTime, 0);

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.GetComponent<TurnTrigger>() != null)
        {
            movementDirection = col.gameObject.GetComponent<TurnTrigger>().turnDirection;
        }
    }
}
