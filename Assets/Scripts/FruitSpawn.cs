using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawn : MonoBehaviour
{
    float time;
    public float spawnTime;
    public GameObject[] fruitPrefabs;

    void Update()
    {
        time += Time.deltaTime;
        if(time > spawnTime)
        {
            Instantiate(fruitPrefabs[Random.Range(0, fruitPrefabs.Length)], transform);
            time = 0;
        }
    }
}
