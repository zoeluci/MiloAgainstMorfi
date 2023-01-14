using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawn : MonoBehaviour
{
    float time;
    public float spawnTime;
    public GameObject[] fruitPrefabs;
    public float fruitSpeed;
    void Update()
    {
        time += Time.deltaTime;
        if(time > spawnTime)
        {
            GameObject spawnedFruit = Instantiate(fruitPrefabs[Random.Range(0, fruitPrefabs.Length)], transform);
            time = 0;
            spawnedFruit.GetComponent<Fruit>().speed = fruitSpeed;
        }
    }
}
