using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawn : MonoBehaviour
{
    public GameObject fruit;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(fruit, transform);
    }
}
