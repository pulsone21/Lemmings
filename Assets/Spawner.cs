using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int amountSpawns;
    public int currentSpawns = 0;
    public GameObject spawnPrefab;

    float iterationTime = 0;

    // Update is called once per frame
    void Update()
    {
        if (currentSpawns < amountSpawns)
        {
            iterationTime += Time.deltaTime;
            if (iterationTime > 1)
            {
                iterationTime = 0;
                Instantiate<GameObject>(spawnPrefab, transform.position, Quaternion.identity);
                currentSpawns++;
            }
        }
        else
        {
            this.enabled = false;
        }
    }
}
