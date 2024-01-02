using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public float speed;
    public Vector2 movementDirection = new Vector2(1,0);
    void Update()
    {
        transform.Translate(speed * movementDirection.x * Time.deltaTime, speed * movementDirection.y * Time.deltaTime, 0);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.GetComponent<TurnTrigger>() != null)
        {
            movementDirection = col.gameObject.GetComponent<TurnTrigger>().turnDirection;
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }
    }
}
