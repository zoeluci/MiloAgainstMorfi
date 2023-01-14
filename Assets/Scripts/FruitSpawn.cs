using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawn : MonoBehaviour
{
    float time;
    public float spawnTime;
    public float fruitSpeed;
    public float fruitProbability;
    public GameObject[] fruitPrefabs;
    public GameObject[] nonFruitPrefabs;
    void Update()
    {
        time += Time.deltaTime;
        if(time > spawnTime)
        {
            GameObject[] prefabsToSpawn;
            if(Random.value < fruitProbability)
            {
                prefabsToSpawn = fruitPrefabs;
            }
            else
            {
                prefabsToSpawn = nonFruitPrefabs;
            }
            GameObject spawnedFruit = Instantiate(prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length)], transform);
            time = 0;
            spawnedFruit.GetComponent<Fruit>().speed = fruitSpeed;
        }
    }
}
